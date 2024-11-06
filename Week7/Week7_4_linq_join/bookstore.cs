using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_4_linq_join
{
    public class Authors
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Authors(int  authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }

    public class Books
    {
        public int BookId{ get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public Books(int bookId, string title, int authorId)
        {
            BookId = bookId;
            Title = title;
            AuthorId = authorId;
        }
    }
}
