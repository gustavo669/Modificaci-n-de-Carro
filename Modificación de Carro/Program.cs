

using Modificación_de_Carro.Clases;

int mangas = 3;

ClsRace carrera = new ClsRace();
carrera.PedirDatosCarrera();

for (int i = 0; i < mangas; i++)
{
    Console.WriteLine($"Manga {i + 1}");
    carrera.IniciarCarrera();
    Console.WriteLine($"--------------------------------------");
}


// moficar el programa para que lleve el control de las mangas que va ganando por fase
// comentar los cambios que deben hacer 






















//Carro miCarrito = new Carro("Toyota",2022,"azul");
//Carro EstefaniCarrito = new Carro("Ferrari", 2022, "Rojo");

//String mensaje;
//mensaje = EstefaniCarrito.EncenderMotor();

//Console.WriteLine(mensaje);


//if (miCarrito.Modelo > EstefaniCarrito.Modelo)
//{
//    Console.WriteLine("El carro del profe es mas reciente");
//}
//else
//{
//    Console.WriteLine("El carro de Estefani es mas reciente");
//}


////Console.WriteLine($"teacher car is {miCarrito.Marca}");
//Console.WriteLine($"Estafani's car is {EstefaniCarrito.Marca}");
////Console.WriteLine($"Estafani's model car is {EstefaniCarrito.Modelo}");


////EstefaniCarrito.EncenderMotor();
//Console.WriteLine(EstefaniCarrito.GetVelocidadActual());
//EstefaniCarrito.EncenderMotor();

//for(int i = 0; i < 5; i++)
//{
//EstefaniCarrito.acelerar();
//}

//EstefaniCarrito.acelerar(3);
//EstefaniCarrito.acelerar(6);
//EstefaniCarrito.acelerar(1);
