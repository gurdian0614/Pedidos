
namespace Pedidos.Herencia
{
    public class Libro : Producto
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:C}");
            Console.WriteLine($"Cantidad disponible: {Stock}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }
    }
}
