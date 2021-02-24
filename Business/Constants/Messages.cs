using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListelendi = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride 10dan fazla ürün olamaz";

        public static string ProductNameAlreadyExists = "Böyle bir isimde ürün zaten var";

        public static string ProductCategoryIsExceed = "15 i geçtiği için daha fazla ekleyemiyoruz";
    }
}
