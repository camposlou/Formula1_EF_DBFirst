using Formula1_EF_CF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Views
{
    internal class View
    {
        public View() { }

        #region Menu Principal
        public static void Menu()
        {
            ViewTeam team = new ViewTeam();
            ViewCar car= new ViewCar();
            ViewDriver pilot = new ViewDriver();
            ViewCarDriver pilotCar = new ViewCarDriver();
            int op = 0;

            do
            {
                Console.WriteLine("\n\t\t>>>Menu Principal<<<");
                Console.WriteLine("\n1-Menu Equipes" +
                                  "\n2-Menu Carros" +
                                  "\n3-Menu Pilotos"+
                                  "\n4-Menu Eventos"+
                                  "\n0-Sair");
                Console.Write("\nOpção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear(); 
                        team.MenuTeam();
                        break;
                    case 2:
                        Console.Clear();
                        car.MenuCar();
                        break;
                    case 3:
                        Console.Clear();
                        pilot.MenuDriver();
                        break;
                    case 4:
                        Console.Clear();
                        pilotCar.MenuEvento();
                        break;

                    default:
                        if (op < 0 || op > 4)
                        {

                            Console.WriteLine("\nOpção Invalida!!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                }
            } while (op != 0);
        }
        #endregion

    }
}
