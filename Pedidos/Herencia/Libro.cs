
namespace Pedidos.Herencia
{
    public class Libro : Producto
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }
    }
}
