using Activity2DAL;
using Activity2DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL
{
    public class BL
    {
        public List<ProductDTO> GetProductsByPrice()
        {
            try
            {
                DAL dalObj = new DAL();
                List<ProductDTO> results = dalObj.FetchProductByPrice();
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
