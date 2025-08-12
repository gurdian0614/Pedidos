
using Pedidos;
using Pedidos.Herencia;

List<Producto> catalogo = new List<Producto>();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 1000;
electronico.Stock = 200;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
catalogo.Add(electronico);

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Señor de los Anillos";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "9788845292613";
libro.Autor = "J.R.R. Tolkien";
libro.NumeroPaginas = 500;
catalogo.Add(libro);

Libro libro1 = new Libro();
libro1.Id = 5;
libro1.Nombre = "Luna de Plutón";
libro1.Precio = 250;
libro1.Stock = 1600;
libro1.ISBN = "6070731743";
libro1.Autor = "Dross";
libro1.NumeroPaginas = 471;
catalogo.Add(libro1);

Pedido pedido = new Pedido(1);
bool continuarPedido = true;

while (continuarPedido)
{
    Console.WriteLine("----------- Catálogo de Productos -----------");
    foreach (Producto producto in catalogo)
    {
        producto.MostrarInformacion();
    }

    try
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------");
        Console.Write("Ingrese ID del producto o 0 para finalizar: ");
        int id = int.Parse(Console.ReadLine()); // Excepcion: FormatException

        if (id == 0)
        {
            continuarPedido = false;
            continue;
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Producto productoSeleccionado = catalogo.FirstOrDefault(producto => producto.Id == id);

        if (productoSeleccionado == null)
        {
            throw new ArgumentException($"El Id {id} no corresponde a ningún producto");
        }

        pedido.AgregarItem(productoSeleccionado, cantidad);


    } 
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Por favor ingrese solo números para el Id y la cantidad.");
        Console.ResetColor();
    }
    catch (InvalidOperationException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: {ex.Message}");
        Console.ResetColor();
    }
    catch (ArgumentException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: {ex.Message}");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR INESPERADO: {ex.Message}");
        Console.ResetColor();
    }
    finally
    {
        Console.WriteLine();
        Console.WriteLine("----------- ESTADO ACTUAL DEL PEDIDO -----------");
        pedido.MostrarDetalles();
    }
}