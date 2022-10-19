using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Controllers
{
    internal class TeamController
    {
        #region INSERT
        public void InsertTeam()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Cadastrar Equipe<<<");

            using (var context = new Formula1Entities())
            {
                EQUIPE equipe = new EQUIPE();
                Console.Write("\nNome: ");
                equipe.Nome = Console.ReadLine();              
                context.EQUIPEs.Add(equipe);
                context.SaveChanges();
                Console.WriteLine(equipe.ToString());

                Console.WriteLine("\nEquipe cadastrada com sucesso...");
                Console.ReadKey();
                
            }
        }
        #endregion

        #region SELECT ALL
        public void ListTeam()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Listar Equipes<<<");

            using (var context = new Formula1Entities())
            {
                var equipes = context.EQUIPEs.ToList();
                foreach (var item in equipes)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();

        }
        #endregion

        #region SELECT ONE
        public void UniqueTeam()
        {
            Console.Clear();
            using(var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Selecionar Equipe Específica<<<");
                Console.Write("\nID: ");
                int id = int.Parse(Console.ReadLine());
                EQUIPE equipe = new Formula1Entities().EQUIPEs.Find(id);
                if(equipe != null)
                {
                    Console.WriteLine(equipe.ToString());
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nEquipe não encontrada...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }

        }
        #endregion

        #region UPDATE
        public void UpdateTeam()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Alterar Cadastro<<<");
                Console.WriteLine("Digite o nome da Equipe que deseja alterar o cadastro: ");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                EQUIPE equipe = context.EQUIPEs.Find(id);
                if (equipe != null)
                {                   
                    Console.Write("Alterar Nome: ");
                    equipe.Nome = Console.ReadLine();
                    context.Entry(equipe).State = EntityState.Modified;
                    context.EQUIPEs.AddOrUpdate(equipe);
                    context.SaveChanges();
                    Console.WriteLine(equipe.ToString());
                    Console.WriteLine("\nNome de Equipe alterada com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }             

            }

        }
        #endregion

        #region DELETE
        public void DeleteTeam()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Remover Equipe<<<");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                EQUIPE equipe = context.EQUIPEs.Find(id);
                if(equipe != null)
                {
                    context.Entry(equipe).State= EntityState.Deleted;  
                    context.EQUIPEs.Remove(equipe);
                    context.SaveChanges();

                    Console.WriteLine("\nEquipe removida com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Equipe não encontrada!!!");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion
       

    }
}
