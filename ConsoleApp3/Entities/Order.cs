using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Entities.Enums;

namespace ConsoleApp3.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Id do Pedido: " + Id + ", \r\n" + "Hora que o pedido foi realizado: " + Moment + ", \r\n" + "Status do pedido: " + Status;
        }
    }
}
