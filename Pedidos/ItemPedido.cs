
namespace Pedidos
{
    public class ItemPedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Producto.Precio * Cantidad;

        public ItemPedido(Producto Producto, int Cantidad) 
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
        }
    }
}
