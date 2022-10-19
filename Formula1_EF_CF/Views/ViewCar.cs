using Formula1_EF_CF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Views
{
    internal class ViewCar
    {
        public ViewCar() { }

        public void MenuCar()
        {
            CarController car = new CarController();

            int op;
            do
            {
                Console.WriteLine("\n\t\t*** Menu Carro***");
                Console.WriteLine("\n1-Cadastrar Carro" +
                                  "\n2-Consultar Carros" +
                                  "\n3-Localizar Carro Específico" +
                                  "\n4-Remover Carro" +
                                  "\n5-Editar Carro" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        car.InsertCar();
                        Console.Clear();

                        break;
                    case 2:
                        car.ListCar();
                        Console.Clear();

                        break;
                    case 3:
                        car.UniqueCar();
                        Console.Clear();

                        break;
                    case 4:
                        car.DeleteCar();
                        Console.Clear();
                        break;
                    case 5:
                        car.UpdateCar();
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
