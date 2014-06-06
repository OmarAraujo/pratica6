/*
 * Created by SharpDevelop.
 * User: Omar
 * Date: 05/06/2014
 * Time: 0:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;


namespace Practica6	
{
    class Program
	{
		public static void Main(string[] args)
		{
			int opc = 5;
			do{


				Console.WriteLine("Menu\n");
				Console.WriteLine("Opciones \n");
				Console.WriteLine("1) Ver \n");
				Console.WriteLine("2) Agregar \n");
				Console.WriteLine("3) Editar \n");
				Console.WriteLine("4) Eliminar \n");
				Console.WriteLine("5) Salir \n");


				opc = int.Parse(Console.ReadLine());
				
				Profesor maestros = new Profesor();

				switch(opc)
				{
						case 1:
									Console.Write("  Ver \n");
									maestros.mostrarTodos();
									break;


						case 2:
									Console.Write(" Agregar \n");
									Console.WriteLine("Introduce el codigo ");
									String codigo = Console.ReadLine();
									Console.WriteLine("Introduce el nombre ");
									String nombre = Console.ReadLine();
									maestros.insertarRegistroNuevo(codigo, nombre);
  									break;


						case 3:
									Console.Write(" Editar \n");
									Console.WriteLine("Dame el id de registro ");
									string id = Console.ReadLine();




									if(maestros.Buscarid(id)){
										Console.WriteLine("Codigo ");
										Console.WriteLine(" Nombre ");
										Console.WriteLine("Confirme que desea editarlo ");
										string resp = Console.ReadLine();
										if(resp == "s"){
											Console.WriteLine("Introduce el codigo ");
											codigo = Console.ReadLine();
											Console.WriteLine("Introduce el nombre ");
											nombre = Console.ReadLine();
											maestros.editarNombreCodigo(id, codigo, nombre);						
										}
									}
									else {
										Console.WriteLine( "Id no existe");
										Console.ReadLine();
									}
									break;


						case 4:
									Console.Write(" Eliminar \n");
									Console.WriteLine("Dame el id de registro ");
									id = Console.ReadLine();
									if(maestros.Buscarid(id)){
										codigo = Console.ReadLine();
										nombre = Console.ReadLine();


										Console.WriteLine("Confirme que desea aliminarlo ");
										string resp = Console.ReadLine();
										if(resp == "s")
											maestros.eliminarRegistroPorId(id);
									}
									else {
										Console.WriteLine( "Id no existe");
										Console.ReadLine();
									}
									break;


						case 5:
									break;


				}
				Console.WriteLine("Presiona una tecla para continuar ");
			Console.ReadLine();
			}while(opc < 5);
		}
	}
}