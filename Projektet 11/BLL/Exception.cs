using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FileNotFoundException : Exception
    {

      public  FileNotFoundException (string message) : base(message) 
        {
            MessageBox.Show(message);
        }




    }
}
