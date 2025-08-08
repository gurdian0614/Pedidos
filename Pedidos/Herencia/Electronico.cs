
namespace Pedidos.Herencia
{
    public class Electronico : Producto
    {
        public Electronico() { }

        public Electronico(int Id, string Nombre, decimal Precio) : base(Id, Nombre, Precio)
        {
        }

        public int GarantiaMeses { get; set; }
        public string Voltaje { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine($"Voltaje: {Voltaje}");
        }

        public override void MostrarInformacion(string Direccion)
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine($"Voltaje: {Voltaje}");
        }

        public override void MostrarInformacion(string Direccion, string Dni)
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"DNI: {Dni}");
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine($"Voltaje: {Voltaje}");
        }
    }
}
