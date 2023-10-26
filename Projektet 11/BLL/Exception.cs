using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Exceptions : Exception
    {
        public Exceptions(string meddelande) : base(meddelande)
        {

        }
        public void ExceptionHandler(string name, string url, string category)
        {
            if (name == null && url == null && category == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void ExceptionHandler(string parameter)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
