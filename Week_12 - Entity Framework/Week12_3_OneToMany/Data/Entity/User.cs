using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_3_OneToMany.Data.Entity
{
    public class User
    {
        public int Id { get; set; }
        public int UserName { get; set; }
        public int Email { get; set; }

        // Navigation Property
        public List<Post> Posts { get; set; }
    }
}
