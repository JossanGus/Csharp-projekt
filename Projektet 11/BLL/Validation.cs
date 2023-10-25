using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class validation
    {

        public Boolean IsEmpty(string text) 
        {
            Boolean result = false;

            if (string.IsNullOrEmpty(text))
            {
                // felmedelande
                result = true;

            }

            return result;
            
        }

        public Boolean CheckURL(string url) 
        
        {

            Boolean result = false;
            if (url.StartsWith("http://") && !string.IsNullOrEmpty(url))
            {
                //felmedelande
                result = true;
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
