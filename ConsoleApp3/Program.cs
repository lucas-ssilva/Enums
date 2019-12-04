using System;
using ConsoleApp3.Entities;
using ConsoleApp3.Entities.Enums;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ordem = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(ordem);

            string txt = OrderStatus.PendingPayment.ToString(); //converter enum para string 

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // converter string para enum 

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
