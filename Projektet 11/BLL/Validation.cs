using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Validation
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
            if (!url.StartsWith("https://")) /*&& string.IsNullOrEmpty(url))*/
            {
                //felmedelande
                result = false;
            }
            return result;
        }

        public Boolean URLDuplicate(string url, List<Podcast> list)
        {
            Boolean result = false;
          
            foreach (var pod in list)
            {
                if (pod.Url.Equals(url)) 
                { 
                    result = true;
                    break;
                }
            }

                //om en pod har samma url och kategori - nej. om pod samma url annan kategori - ja.

                return result;
        }

        public Boolean CbSelected(int i)
        {
            Boolean result = false;

            if (i >= 0)
            {
                result = true;
            }

            return result;
        }















    }
}
