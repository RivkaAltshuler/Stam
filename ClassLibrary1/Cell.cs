using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Flags]
    public enum flags { none, c, h }
    public class Cell
    {
        string _product_id = null;
        private int _quantity = 0;

        public string ProductId
        {
            get
            {
                return _product_id;
            }

            set
            {
                if (_product_id != null)
                    throw new Exception("product is already set");

                _product_id = value;
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
            }
        }


        public readonly flags Flags;
        public Cell(flags flags)
        {
            this.Flags = flags;
        }

        public virtual bool PutIfAvailable(Product product, int quantity)
        {
            if (this.Quantity + quantity > 10)
                return false;

            if (this.ProductId != null && product.ProductId != this.ProductId)
                return false;

            if (!product.Check(this))
                return false;


            if (this.ProductId == null)
                this.ProductId = product.ProductId;

            this.Quantity += quantity;

            return true;

        }



    }
}
