using System.Text;

namespace DesignPattern.Structural.Composite.DTOs.DataModelsDTO
{
    class PurchaseBill : IDTOModel
    {
        public List<OrderDTO> Orders { get; private set; }


        public PurchaseBill(List<OrderDTO> orders)
        {
            Orders = orders;
        }
        public void AddOrder(OrderDTO order)
        {
            Orders.Append(order);
        }

        public string[] Render()
        {
            //Orders.ToList().ForEach((x) => Array.ForEach(x.Render(), Console.WriteLine));
            //Array.ForEach(Orders.ToArray(), Console.WriteLine);
            StringBuilder sb = new StringBuilder();
            Orders.ToList().ForEach((o) => sb.AppendLine(o.Render().ToString()));
            return new[] { sb.ToString() };

        }
    }
}
