using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Product
    {
        string productId;

        public Product(string productId)
        {
            this.productId = productId;   
        }

        public string ProductId { get => productId;}


        public virtual bool Check(Cell cell) { 
            return true; 
        }
    }
}
