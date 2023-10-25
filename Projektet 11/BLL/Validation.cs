using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class validation
    {

        public Boolean NotEmpty(string text) 
        {
            Boolean result = true;

            if (string.IsNullOrEmpty(text))
            {
                // felmedelande
                result = false;

            }

            return result;
            
        }

        public Boolean CheckURL(string url) 
        
        {

            Boolean result = true;
            if (!url.StartsWith("https://") && string.IsNullOrEmpty(url))
            {
                //felmedelande
                result = false;
            }
            return result;
        }

        public Boolean URLDuplicate(string url, string category)
        {
            Boolean result = false;


            //om en pod har samma url och kategori - nej. om pod samma url annan kategori - ja.

            return result;
        }

        














    }
}
