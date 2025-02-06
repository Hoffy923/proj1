using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace proj1.Models
    {
        public class Product
        {
            //private string name;
            //public string GetName()
            //{
            //    return name;
            //}
            //public void Setname(string _name)
            //{
            //    //this.name = name; //bc derefrence happens auto
            //    name = _name;
            //}
            public int Id { get; set; }

            public string Name { get; set; } //called a property, this is the exact same as what is commented out above

            public string? Display
            {
                get
                {
                    return $"{Id}. {Name}";
                }
            }
            public Product()
            {
                Name = string.Empty;
            }
            public override string ToString()
            {
                return Display ?? string.Empty;//if Display is null, it forces string.Empty
            }
        }
    }
