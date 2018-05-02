using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
   public class FileReader
    {
        public string[] Read(string filename)
        {
            try
            {
                return File.ReadAllLines(filename);

            }
            catch (Exception e)
            {
               
                throw new Exception(e.Message);
            }
            
            

        }
    }
}
