using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ShelvingUnit
    {
        Cell[,] cells=new Cell[10,10];
        public ShelvingUnit()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    flags flags = 0;
                  
                    if (j == 9)
                        flags = flags | flags.h;
                    if (i >6 && j>6)
                        flags = flags | flags.c;

                    cells[i, j] = new Cell(flags);


                }


        }

        public Tuple<int,int> Allocate_Cell(Product product, int quantity)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (cells[i, j].PutIfAvailable(product, quantity))
                    {
                         return new Tuple<int,int>(i, j);
                    }
                       
                }
            return null;
        }
    }
}
