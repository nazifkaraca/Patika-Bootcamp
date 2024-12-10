namespace Week12_6_Ecommercial.Dto
{
    public class CustomerFilterDto
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string NameSearch { get; set; }
        public string EmailSearch { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
