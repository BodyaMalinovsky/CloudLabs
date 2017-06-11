using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class TestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<string> Names { get; set; }
    }
}
