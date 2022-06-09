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
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---             TABLE SHIPPERS            ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---      1.- Listar Shippers              ---");
                Console.WriteLine("---      2.- Modificar Shipper            ---");
                Console.WriteLine("---      3.- Insertar Shipper             ---");
                Console.WriteLine("---      4.- Eliminar Shipper             ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---      0.- Salir                        ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.Write("---");
                Console.Write("  Ingresar Opción:            ");
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
