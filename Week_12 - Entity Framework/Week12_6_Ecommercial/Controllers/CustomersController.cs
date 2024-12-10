using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Week12_6_Ecommercial.Data;
using Week12_6_Ecommercial.Dto;
using Week12_6_Ecommercial.Models;

namespace Week12_6_Ecommercial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public CustomersController(EcommerceContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customer == null) return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Create(Customer customer)
        {
            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers([FromQuery] CustomerFilterDto filter)
        {
            var query = _context.Customers.AsQueryable();

            if (filter.StartDate.HasValue)
            {
                query = query.Where(c => c.SignUpDate >= filter.StartDate.Value);
            }

            if (filter.EndDate.HasValue)
            {
                query = query.Where(c => c.SignUpDate <= filter.EndDate.Value);
            }

            if (!string.IsNullOrWhiteSpace(filter.NameSearch))
            {
                query = query.Where(c => c.FirstName.Contains(filter.NameSearch) || c.LastName.Contains(filter.NameSearch));
            }

            if (!string.IsNullOrWhiteSpace(filter.EmailSearch))
            {
                query = query.Where(c => c.Email.Contains(filter.EmailSearch));
            }

            query = query.OrderBy(c => c.LastName)
                         .ThenBy(c => c.FirstName);

            var totalCount = await query.CountAsync();

            var totalPages = (int)Math.Ceiling(totalCount / (double)filter.PageSize);

            var customers = await query
                                       .Skip((filter.Page - 1) * filter.PageSize)
                                       .Take(filter.PageSize)
                                       .Select(c => new CustomerDto
                                       {
                                           Id = c.Id,
                                           Email = c.Email,
                                           FullName = $"{c.FirstName} {c.LastName}",
                                           SignUpDate = c.SignUpDate,
                                       }).ToListAsync();

            var response = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPages = filter.Page,
                PageSize = filter.PageSize,
                Customers = customers,
            };

            return Ok(response);

            /*
             /api/customers
             /api/customers?startDate=2023-04-04&nameSearch=nazif
             */
        }
    }
}