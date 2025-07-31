
using Pedidos;
using Pedidos.Herencia;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();

Producto producto1 = new Producto(); 
producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 15;

producto1.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 1);
pedido.AgregarItem(producto1, 5);
pedido.MostrarDetalles();

producto.MostrarInformacion();
producto1.MostrarInformacion();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 1000;
electronico.Stock = 200;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Señor de los Anillos";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "9788845292613";
libro.Autor = "J.R.R. Tolkien";
libro.NumeroPaginas = 500;
libro.MostrarInformacion();

Libro libro1 = new Libro();
libro1.Id = 5;
libro1.Nombre = "Luna de Plutón";
libro1.Precio = 250;
libro1.Stock = 1600;
libro1.ISBN = "6070731743";
libro1.Autor = "Dross";
libro1.NumeroPaginas = 471;
libro1.MostrarInformacion();