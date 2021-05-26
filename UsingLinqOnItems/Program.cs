using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;


/* Елементи колекції «Товари» мають наступну структуру: код товару, назва товару, кількість одиниць
товару, відпускна ціна одиниці товару (коди унікальні, назви можуть повторюватися). Елементи
колекції «Поставки» містять код товару, дату, назву постачальника, обсяг поставок, ціну за
одиницю.
a) Вивести середній обсяг поставок товару з заданим кодом, здійснених протягом другого півріччя
минулого року.
b) Вивести постачальників, які поставили товар із заданою назвою за найменшою ціною.
c) Вивести по кожній наявній назві товару можливий прибуток від його реалізації.*/

namespace UsingLinqOnItems
{
    
    public class Program
    {
        /// <summary>
        /// Вивести середній обсяг поставок товару з заданим кодом, здійснених протягом другого півріччя минулого року.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static double Task1(int id)
        {
            var task1Query = from delivery in Data.deliveries
                             where delivery.Id == id && delivery.Date.Year == DateTime.Today.Date.Year - 1
                             && delivery.Date.Month >= 6
                             select delivery.Amount;

            Console.WriteLine($"Average amount of deliveries of id: {id} is: {task1Query.Average()}");

            return task1Query.Average();
        }
        /// <summary>
        /// Вивести постачальників, які поставили товар із заданою назвою за найменшою ціною.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Task2(string name)
        {
            string ansTask2 = "";
            var findId = from item in Data.items
                         where item.Name == name
                         join delivery in Data.deliveries on item.Id equals delivery.Id
                         select new { Name = item.Name, Supplier = delivery.Supplier, Price = delivery.Price };

            var minVal = findId.Min(x => x.Price);

            var findMin = from i in findId
                          where i.Price == minVal
                          select new { Name = i.Name, Supplier = i.Supplier, MinV = i.Price };

            foreach (var element in findMin)
            {
                ansTask2 += element.Supplier;
                Console.WriteLine($"Name : {element.Name}, {element.Supplier}, Price : {element.MinV}");

            }
            return ansTask2;
        }
        /// <summary>
        /// Вивести по кожній наявній назві товару можливий прибуток від його реалізації
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, decimal> Task3()
        {
            var task3Query = from item in Data.items
                             join delivery in Data.deliveries on item.Id equals delivery.Id
                             group new { sPrice = item.Price, dPrice = delivery.Price, Amount = delivery.Amount } by item.Name into nGroup
                             orderby nGroup.Key
                             select new { Name = nGroup.Key, Prubytok = nGroup.Sum(x => (x.sPrice - x.dPrice) * x.Amount) };

            /*var newq = from i in task3Query
                       select new { Name = i.Name };
            var newq2 = from item in Data.items
                        select new { Name = item.Name };
            var qq = newq2.Except(newq).Select(s=> new {Name = s.Name, Prubytok =(decimal) 0 });
            var ans = task3Query.Union(qq);*/

            //обираємо з айтемс поле нейм, далі виключаємо імя які обрано з такс3Квері і вибираємо новий нл з імям і прибуток 0, обєднуємо з такс3
            var ans = task3Query.Union(Data.items.Select(x => x.Name).Except(task3Query.Select(s => s.Name)).Select(y => new { Name = y, Prubytok = (decimal)0 }));

            Dictionary<string, decimal> prubytok = ans.ToDictionary(x => x.Name, s => s.Prubytok);

            foreach (var element in ans)
            {
                Console.WriteLine($"Name : {element.Name}, Prubytok : {element.Prubytok}");

            }
            return prubytok;
        }
        static void Main(string[] args)
        {
            /*Task1(id: 1);
            Task1(id: 2);
            Task1(id: 3);
            Task1(id: 4);
            Task1(id: 5);
            Task1(id: 6);
            Task1(id: 7);
            Task1(id: 8);
            Task1(id: 9);
            Task1(id: 10);*/
            Task1(7);
            Console.WriteLine();
            Task2("Samsung");
            //var s = Task2("Poco") + Task2("HTC");
            Console.WriteLine();
            Task3();
       
        }
    }
}
