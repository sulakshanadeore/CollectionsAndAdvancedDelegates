using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionModels
{
    public class User
    {
        public string UserName { get; set; }
        public int Password { get; set; }
    }


    public class Products
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }

        public float UnitPrice  { get; set; }

    }
}
