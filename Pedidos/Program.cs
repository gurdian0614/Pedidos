
using Pedidos;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();
producto.DisminuirStock(2);
producto.MostrarInformacion();
producto.DisminuirStock(15);
producto.MostrarInformacion();

Producto producto1 = new Producto(); 
producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 15;

producto1.MostrarInformacion();