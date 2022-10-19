using Formula1_EF_CF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Views
{
    internal class ViewDriver
    {
        public ViewDriver() { }

        public void MenuDriver()
        {
            DriverController piloto = new DriverController();

            int op;
            do
            {
                Console.WriteLine("\n\t\t*** Menu Piloto***");
                Console.WriteLine("\n1-Cadastrar Piloto" +
                                  "\n2-Consultar Pilotos" +
                                  "\n3-Localizar Piloto Específico" +
                                  "\n4-Remover Piloto" +
                                  "\n5-Editar Piloto" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        piloto.InsertDriver();
                        Console.Clear();

                        break;
                    case 2:
                        piloto.ListDriver();
                        Console.Clear();

                        break;
                    case 3:
                        piloto.UniqueDriver();
                        Console.Clear();

                        break;
                    case 4:
                        piloto.DeleteDriver();
                        Console.Clear();
                        break;
                    case 5:
                        piloto.UpdateDriver();
                        Console.Clear();
                        break;
                    default:
                        if (op < 0 || op > 5)
                        {

                            Console.WriteLine("\nOpção Invalida!!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                }
            } while (op != 0);
        }
    }
    
}
