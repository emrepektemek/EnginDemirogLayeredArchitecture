using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static verdiginde onu newlemiyorsun direkt kullaniyorsun 
    public static class Messages 
    {
        public static string ProductAdded = "Ürün eklendi"; // publicler pascal case, private olsaydı camel case
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        
    }
}
