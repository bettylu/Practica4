using System;

namespace Practica4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int opc;
			do{
				
				
			
				Console.WriteLine("Seleccione una opcion:\n");
			
				Console.WriteLine("1.- Imprimir un producto \n");
				Console.WriteLine("2.- Capturar nuevo producto \n");
				Console.WriteLine("3.- Salir del programa \n");
				opc = int.Parse (Console.ReadLine());
				switch(opc)
				{
					
					case '1': 
					Console.Write("Imprimir producto \n");
					string url = "Archivo de productos.txt";
					Archivo archivo = new Archivo(url);
					archivo.leer(); 
					break;
					
					case '2':
					Console.WriteLine("\tProducto nuevo \n");
					Console.WriteLine("Introduce el nombre \n");
					String nombre = Console.ReadLine();
			        Console.WriteLine("Introduce el codigo \n");
					String codigo = Console.ReadLine();
					Console.WriteLine("Introduce la descripción \n");
					String descripción = Console.ReadLine();
					
					String registro = nombre + "," + codigo +"," + descripción + "\n";
					
					url = "Archivo de productos.txt";
					Archivo archivo1 = new Archivo(url);
                    
                		archivo1.escribir( registro ); 
                		archivo1.leer();
					
					System.Console.Read();
					break;
					
					
					case '3': 
					Console.Write("Salir del programa\n");
					Console.ReadKey(true);
					break;
			}
			}while(opc != 3);
			
		}
	}
}