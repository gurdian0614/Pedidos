
namespace Pedidos
{
    public class ItemPedido
    {
        // Puedo declarar objetos de clases abstractas siempre y cuando no las inicialice
        // es decir Producto = new Producto();
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Producto.Precio * Cantidad;

        // En este caso estamos asignando el objeto del parametro Producto a la propiedad abstracta Producto
        public ItemPedido(Producto Producto, int Cantidad) 
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
        }
    }
}
