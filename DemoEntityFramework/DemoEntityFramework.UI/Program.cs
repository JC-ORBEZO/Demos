using DemoEntityFramework.Entities;
using DemoEntityFramework.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int option = 0;
            int ingresoIncorrecto = 40;
            ShipperLogic shipper = new ShipperLogic();
            while (option==0)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---             TABLE SHIPPERS            ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---      1.- Listar Shippers              ---");
                Console.WriteLine("---      2.- Insertar Shipper            ---");
                Console.WriteLine("---      3.- Modificar Shipper             ---");
                Console.WriteLine("---      4.- Eliminar Shipper             ---");
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
                    case 1: Console.Clear();
                        Console.WriteLine("    Lista de Shippers    ");
                        Console.WriteLine("-------------------------");
                        foreach (var item in shipper.GetAll())
                        {
                            Console.WriteLine($"{item.ShipperID}    {item.CompanyName}");
                        }
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 2: Console.Clear();
                        Console.WriteLine("    Insertar Shipper    ");
                        Console.WriteLine("-------------------------");
                        Shippers nuevo = new Shippers();
                        Console.Write("CompanyName: ");
                        nuevo.CompanyName = Console.ReadLine();
                        shipper.Add(nuevo);
                        option = 0;
                        Console.ReadLine();
                        break;
                    case 3: Console.Clear();
                        Console.WriteLine("    Modificar Shipper    ");
                        Console.WriteLine("-------------------------");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("    Eliminar Shipper Por ID   ");
                        Console.WriteLine("------------------------------");
                        int id=0;
                        Console.Write("Ingrese el Id: ");
                        try
                        {
                            id = Int32.Parse(Console.ReadLine());
                            try
                            {
                                shipper.Delete(id);
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
                        Console.ReadLine();
                        break;
                    case 0:Console.Clear();
                        option = 39;
                        break;
                    default: Console.WriteLine("Ingreso incorrecto, vuelva a intentarlo.");
                        Console.ReadLine();                        
                        option = 0;
                        break;
                }
            }            
        }
    }
}
