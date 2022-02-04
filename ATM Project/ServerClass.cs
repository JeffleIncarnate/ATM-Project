using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    public class myRemoteClass: MarshalByRefObject
    {
        public myRemoteClass()
        {
            // TO DO: Add constructor logic here.
        }

        public bool SetString(String sTemp)
        {
            try
            {
                Console.WriteLine("This string '{0}' has a length of {1}", sTemp, sTemp.Length);
                return sTemp != "";
            }
            catch
            {
                return false;
            }
        }
    }
}
