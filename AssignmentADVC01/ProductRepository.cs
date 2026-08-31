using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class ProductRepository : IRepository<Product>
    {
        private List<Product> items = new List<Product>();
        public void Add(Product item) => items.Add(item);
        public Product Get(int id) => items.Find(p => p.Id == id);
        public List<Product> GetAll() => items;
    }
}
