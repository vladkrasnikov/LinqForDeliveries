using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinqOnItems
{
    public class Data
    {
        public record Delivery(int Id, DateTime Date, string Supplier, int Amount, decimal Price);
        public record Items(int Id, string Name, int Amount, decimal Price);

            public static Items[] items = new Items[]
            {
                new Items (1, "Apple", 280, 1111),
                new Items (2, "Apple", 200, 2222),
                new Items (3, "Samsung", 150, 999),
                new Items (4, "Samsung", 250, 1999),
                new Items (5, "Samsung", 500, 2999),
                new Items (6, "Lenovo", 280, 400),
                new Items (7, "Lenovo", 300, 449),
                new Items (8, "Lenovo", 100, 549),
                new Items (9, "Lenovo", 50, 649),
                new Items (10, "Xiaomi", 500, 500),
                new Items (11, "Xiaomi", 400, 550),
                new Items (12, "Poco", 50, 440),
                new Items (13, "Poco", 10, 450),
                new Items (14, "HTC", 150, 350),
                new Items (15, "HTC", 50, 400),
                new Items (16, "Huawei", 150, 500),
                new Items (17, "Huawei", 250, 420),
                new Items (18, "OnePlus", 350, 450),
                new Items (19, "OnePlus", 250, 500),
                new Items (20, "Nokia", 150, 700),
                new Items (21, "Ok", 150, 700),
            };

            public static List<Delivery> deliveries = new List<Delivery>()
            {
                new Delivery(1, new DateTime(2020,8,11), "IphoneSupplier", 120, 1000),
                new Delivery(1, new DateTime(2020,5,12), "ISupplier", 160, 1100),
                new Delivery(2, new DateTime(2020,7,13), "AppleSupplier", 100, 1999),
                new Delivery(2, new DateTime(2020,4,14), "ASupplier", 100, 2000),
                new Delivery(3, new DateTime(2020,7,15), "SamsungSupplier", 50, 950),
                new Delivery(3, new DateTime(2020,6,19), "SamSupplier", 50, 945),
                new Delivery(3, new DateTime(2020,5,16), "SgSupplier", 50, 945),
                new Delivery(4, new DateTime(2020,9,17), "AndroidSupplier", 100, 1900),
                new Delivery(4, new DateTime(2020,10,14), "AndSupplier", 150, 1890),
                new Delivery(5, new DateTime(2020,11,18), "TSupplier", 250, 2800),
                new Delivery(5, new DateTime(2020,5,19), "FifthSupplier", 250, 2799),
                new Delivery(6, new DateTime(2020,5,20), "LenovoSupplier", 139, 395),
                new Delivery(6, new DateTime(2020,8,21), "LenSupplier", 70, 399),
                new Delivery(6, new DateTime(2020,9,22), "LSupplier", 71, 398),
                new Delivery(7, new DateTime(2020,10,23), "PremiumSupplier", 110, 395),
                new Delivery(7, new DateTime(2020,4,24), "ChinaSupplier", 90, 410),
                new Delivery(7, new DateTime(2020,8,25), "ThaiSupplier", 50, 405),
                new Delivery(7, new DateTime(2020,9,26), "SingSupplier", 50, 405),
                new Delivery(8, new DateTime(2020,8,26), "USASupplier", 100, 505),
                new Delivery(9, new DateTime(2020,10,26), "UKSupplier", 50, 605),
                new Delivery(10, new DateTime(2020,11,27), "GESupplier", 500, 399),
                new Delivery(11, new DateTime(2020,12,16), "BLSupplier", 400, 440),
                new Delivery(12, new DateTime(2020,6,28), "KMSupplier", 50, 400),
                new Delivery(13, new DateTime(2020,8,26), "FISupplier", 10, 410),
                new Delivery(14, new DateTime(2020,9,26), "ESSupplier", 150, 300),
                new Delivery(15, new DateTime(2020,8,26), "RUSupplier", 50, 350),
                new Delivery(16, new DateTime(2020,10,26), "SKSupplier", 150, 400),
                new Delivery(17, new DateTime(2020,11,26), "CZSupplier", 250, 405),
                new Delivery(18, new DateTime(2020,12,26), "PLSupplier", 350, 420),
                new Delivery(19, new DateTime(2020,9,26), "SGSupplier", 250, 450),
                new Delivery(20, new DateTime(2020,10,26), "SMSupplier", 150, 600),
            };
    }
}
