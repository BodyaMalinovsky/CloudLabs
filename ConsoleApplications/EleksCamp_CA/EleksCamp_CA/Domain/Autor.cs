using System.Collections.Generic;
using EleksCamp_CA.Abstraction;

namespace EleksCamp_CA.Domain
{
    public class Autor : BookHolder
    {
        public string Name { get; private set; }

        public Autor(string name) : base()
        {
            this.Name = name;            
        }

        public Autor(string name, IList<int> booksIds) : base(booksIds)
        {
            this.Name = name;
        }
    }
}