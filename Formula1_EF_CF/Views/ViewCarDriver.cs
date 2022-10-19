using Formula1_EF_CF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Views
{
    internal class ViewCarDriver
    {
        public ViewCarDriver() { }

        public void MenuEvento()
        {
            CarDriverController evento = new CarDriverController();

            int op;
            do
            {
                Console.WriteLine("\n\t\t*** Menu Evento***");
                Console.WriteLine("\n1-Cadastrar Evento" +
                                  "\n2-Consultar Evento" +
                                  "\n3-Localizar Evento Específico" +
                                  "\n4-Remover Evento" +
                                  "\n5-Editar Evento" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        evento.InsertEvent();
                        Console.Clear();

                        break;
                    case 2:
                        evento.ListEvent();
                        Console.Clear();

                        break;
                    case 3:
                        evento.UniqueEvent();
                        Console.Clear();

                        break;
                    case 4:
                        evento.DeleteEvent();
                        Console.Clear();
                        break;
                    case 5:
                        evento.UpdateEvent();
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
