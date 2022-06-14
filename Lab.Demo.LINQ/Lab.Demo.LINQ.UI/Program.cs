using Lab.Demo.LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.LINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int ingresoIncorrecto = 40;
            while (option == 0)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---              TP 05 - LINQ             ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  1.- Query devolver objeto Customer   ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  2.- Products sin stock               ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  3.- Products con stock y  cuestan    ---");
                Console.WriteLine("---  más de 3 x unidad                    ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  4.- Customers de la Región WA        ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  5.- Primer elemento o nulo de una    ---");
                Console.WriteLine("---  lista de productos donde el ID       ---");
                Console.WriteLine("---  de producto sea igual a 789          ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  6.- Nombre de Customers en mayuscula ---");
                Console.WriteLine("---  y minuscula                          ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---  7.- Query para devolver Join entre   ---");
                Console.WriteLine("---  Customers y Orders dnde los customers---");
                Console.WriteLine("---  sean de la Región WA y la fecha de   ---");
                Console.WriteLine("---  orden sea mayor a 1/1/1997           ---");                
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---      0.- Salir                        ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.Write("---");
                Console.Write("  Ingresar Opción:            ");
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    option = ingresoIncorrecto;
                }
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("    Lista de Shippers    ");
                        Console.WriteLine("-------------------------");
                        ProductsLogic productLogic = new ProductsLogic();
                        var productos = from p in productLogic.GetAll()
                                        where p.UnitsInStock == 0
                                        select p;
                        option = 0;
                        foreach (var item in productos)
                        {
                            Console.WriteLine($"{item.ProductName}");
                            Console.WriteLine($"{item.UnitsInStock}");
                            Console.WriteLine("--------------------");
                        }
                        
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("    Insertar Shipper    ");
                        Console.WriteLine("-------------------------");
                        Console.Write("CompanyName: ");
                        option = 0;
                        Console.WriteLine("Shipper Insertado");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("    Modificar Shipper    ");
                        Console.WriteLine("-------------------------");
                        Console.Write("Id: ");
                        Console.Write("CompanyName: ");
                        try
                        {
                            Console.WriteLine("Shipper Modificado");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("El Id ingresado no existe");
                        }
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("    Eliminar Shipper Por ID   ");
                        Console.WriteLine("------------------------------");
                        int id = 0;
                        Console.Write("Ingrese el Id: ");
                        try
                        {
                            id = Int32.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Shipper Eliminado.");
                                Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("El Id ingresado no existe.");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ingreso incorrecto, vuelva a intentarlo.");
                            Console.ReadLine();
                        }
                        option = 0;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("    Lista de Shippers    ");
                        Console.WriteLine("-------------------------");
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("    Lista de Shippers    ");
                        Console.WriteLine("-------------------------");
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("    Lista de Shippers    ");
                        Console.WriteLine("-------------------------");
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.Clear();
                        option = 39;
                        break;
                    default:
                        Console.WriteLine("Ingreso incorrecto, vuelva a intentarlo.");
                        Console.ReadLine();
                        option = 0;
                        break;
                }
            }




            //ProductsLogic products = new ProductsLogic();
            //foreach (var item in products.GetAll())
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            //Console.WriteLine("------------------------------");



            //Demo 1 a 3
            //
            //var query = products.GetAll().Where(x => x.ProductName == "Valkoinen suklaa");
            ////var query77 = products.GetAll().Where(x => x.ProductName == "Valkoinen suklaa").ToList();
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}

            //Console.WriteLine("------------------------------");
            //var query2 = products.GetAll().OrderBy(m => m.UnitPrice).ThenByDescending(m => m.ProductName).ThenBy(m => m.ProductID);
            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"{item.UnitPrice}");
            //}

            //Console.WriteLine("------------------------------");
            //var query3 = products.GetAll().Any(m => m.ProductName.Contains("Valkoinen"));
            //Console.WriteLine(query3);            

            //Console.WriteLine("------------------------------");
            //Console.WriteLine(query2.Count());
            //Console.ReadLine();

            #region Expresiones Lambda
            //Tipos de delegados: function y action
            //Func<int, int> square = x => x * x;
            //Func<int, int, int> add = (x, y) => x + y;

            //Action<int> printScreen = x => Console.WriteLine(x);
            //Console.ReadLine();
            Func<int, int> square = x => x * x;
            square(2); //=> 4
            Func<int, int, int> add = (x, y) => x + y;
            add(5, 4); //=> 9
            add(square(2), 4); //=> 8
            
            Action<int> printScreen = x => Console.WriteLine(x);
            printScreen(add(square(2), 3)); //=> Console.WriteLine(7)
            #endregion
        }
    }

    /*
     * 01:01:40
     * ¿Qué es LINQ?
     * Dato importante: Extension Methods => 
     * Sintaxis a utilizar: IEnumerable y Iquerible
     * 
     * Query Syntax VS Method Syntax
     * 
     * 
     * Tipos de Operadores: 
     * 1.- ejecución difererida 
     * La operación no se ejecuta donde se declara.
     * Se ejecuta cuando se intenta acceder a la información.
     *  1.a) Streaming
     *  No necesitan leer todos los datos del origen para realizar la operación.
     *  Ejemplo: Where
     * 
     *  1.b) Non Streaming
     *  Necesitan leer todos los datos del origen.
     *  Ejemplo: OrderBy
     * 
     * 2.- ejecución inmediata
     * Se leen los datos y se ejecuta la operación cuando se define la query.
     * Ejemplo: First, ToList
     * 
     */
}
