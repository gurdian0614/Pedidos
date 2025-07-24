
namespace Pedidos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Cantidad disponible: {Stock}");
            Console.WriteLine();
        }

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
    }
}
