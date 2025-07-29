
namespace Pedidos.Herencia
{
    public class Electronico : Producto
    {
        public int GarantiaMeses { get; set; }
        public string Voltaje { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine($"Voltaje: {Voltaje}");
        }
    }
}
