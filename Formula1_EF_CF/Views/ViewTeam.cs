using Formula1_EF_CF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Views
{
    internal class ViewTeam
    {
        public ViewTeam() { }

         public void MenuTeam()
         {
            TeamController team = new TeamController();
            
            int op;
            do
            {
                Console.WriteLine("\n\t\t>>>Menu Equipes<<<");
                Console.WriteLine("\n1-Cadastrar Equipe" +
                                  "\n2-Consultar Equipes" +
                                  "\n3-Localizar Equipe Específica" +
                                  "\n4-Remover Equipe" +
                                  "\n5-Editar Equipe" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        team.InsertTeam();
                        Console.Clear();

                        break;
                    case 2:
                        team.ListTeam();
                        Console.Clear();

                        break;
                    case 3:
                        team.UniqueTeam();
                        Console.Clear();

                        break;
                    case 4:
                        team.DeleteTeam();
                        Console.Clear();
                        break;
                    case 5:
                        team.UpdateTeam();
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
