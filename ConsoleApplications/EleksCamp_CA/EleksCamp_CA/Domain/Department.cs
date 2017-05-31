using System.Collections.Generic;
using EleksCamp_CA.Abstraction;

namespace EleksCamp_CA.Domain
{
    public class Department : BookHolder
    {
        public string Name { get; private set; }
        
        public Department(string name) : base()
        {
            this.Name = name;
        }

        public Department(string name, IList<int> booksIds) : base(booksIds)
        {
            this.Name = name;
        }
    }
}