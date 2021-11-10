using Activity2BL;
using Activity2DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2PL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                BL blObj = new BL();

                List<ProductDTO> lstFinalResult = blObj.GetProductsByPrice();
                foreach (var pro in lstFinalResult)
                {
                    Console.WriteLine(pro.ProductName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
