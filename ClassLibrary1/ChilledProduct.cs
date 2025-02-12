using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ChilledProduct:Product
    {
        public ChilledProduct(string productId) : base(productId)
        {
        }

        public override bool Check(Cell cell)
        {
            return base.Check(cell) && cell.Flags.HasFlag(flags.c);
        }
    }
}
