
namespace Pedidos
{
    public abstract class Producto : IInformacionDetallada
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public abstract void MostrarInformacion();

        // Si el constructor no lleva parámetros, C# automáticamente lo crea por detrás

        public void DisminuirStock(int Cantidad)
        {
            if (Stock >= Cantidad)
            {
                Stock -= Cantidad;
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock de {Nombre}");
                Console.WriteLine();
            }
        }

        public string ObtenerInformacionDetallada()
        {
            return $"ID: {Id}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Precio: {Precio:C}\n" +
                   $"Cantidad disponible: {Stock}";
        }

    }
}
