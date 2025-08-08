
using Pedidos.Herencia;

namespace Pedidos
{
    public class Pedido : IInformacionDetallada
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<ItemPedido> Items { get; set; }
        public decimal Total => Items.Sum(item => item.Subtotal);
        private bool TieneStock { get; set; }

        public Pedido(int IdPedido)
        {
            Id = IdPedido;
            Fecha = DateTime.Now;
            Items = new List<ItemPedido>();
        }

        // En este caso estamos asignando el objeto abstracto Producto como parametro
        public void AgregarItem(Producto Producto, int Cantidad)
        {
            if (Producto.Stock >= Cantidad)
            {
                Items.Add(new ItemPedido(Producto, Cantidad));
                Producto.DisminuirStock(Cantidad);
                Console.WriteLine($"El Producto {Producto.Nombre} con cantidad {Cantidad}, se ha agregado al Pedido");
                Console.WriteLine();
                TieneStock = true;
            } else
            {
                Console.WriteLine($"No hay suficiente stock de {Producto.Nombre}");
                Console.WriteLine();
                TieneStock = false;
            }
        }

        public void MostrarDetalles()
        {
            if(TieneStock)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(ObtenerInformacionDetallada());

                foreach (var item in Items)
                {
                    Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Subtotal: {item.Subtotal:C}");
                }
                Console.WriteLine($"Total: {Total:C}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
            }
        }

        public string ObtenerInformacionDetallada()
        {
            return $"Detalles del Pedido #{Id}\n" +
                   $"Fecha: {Fecha:dd/MM/yyyy HH:mm:ss}";
        }
    }
}
