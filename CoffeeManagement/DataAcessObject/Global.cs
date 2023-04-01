using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DataAcessObject
{
    public static class Global
    {
        private static string _globalUser = "";

        public static string GlobalUser
        {
            get { return _globalUser; }
            set { _globalUser = value; }
        }
    }
}
