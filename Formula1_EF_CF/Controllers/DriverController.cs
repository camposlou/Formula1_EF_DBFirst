using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Controllers
{
    internal class DriverController
    {
        #region INSERT
        public void InsertDriver()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Cadastrar Piloto<<<");

            using (var context = new Formula1Entities())
            {
                PILOTO piloto = new PILOTO();
                Console.Write("\nNome: ");
                piloto.Nome = Console.ReadLine();
                context.PILOTOes.Add(piloto);
                context.SaveChanges();
                Console.WriteLine(piloto.ToString());
                
                
                Console.WriteLine("\nPiloto cadastrado com sucesso...");
                Console.ReadKey();

            }
        }
        #endregion

        #region SELECT ALL
        public void ListDriver()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Listar Pilotos<<<");

            using (var context = new Formula1Entities())
            {
                var pilotos = new Formula1Entities().PILOTOes.ToList();
                foreach (var item in pilotos)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();

        }
        #endregion

        #region SELECT ONE
        public void UniqueDriver()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Selecionar Piloto Específico<<<");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                PILOTO piloto = new Formula1Entities().PILOTOes.Find(id);
                if (piloto != null)
                {
                    Console.WriteLine(piloto.ToString());
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nPiloto não encontrada...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }

        }
        #endregion

        #region UPDATE
        public void UpdateDriver()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Alterar Cadastro<<<");
                Console.WriteLine("Digite o nome do Piloto que deseja alterar o cadastro: ");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                PILOTO piloto = context.PILOTOes.Find(id);
                if (piloto != null)
                {                   
                    Console.Write("Alterar Nome: ");
                    piloto.Nome = Console.ReadLine();
                    context.Entry(piloto).State = EntityState.Modified;
                    context.PILOTOes.AddOrUpdate(piloto);
                    context.SaveChanges();
                    Console.WriteLine(piloto.ToString());
                    Console.WriteLine("\nNome do Piloto alterado com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }

            }

        }
        #endregion

        #region DELETE
        public void DeleteDriver()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Remover Piloto<<<");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                PILOTO piloto = context.PILOTOes.Find(id);
                if (piloto != null)
                {
                    context.Entry(piloto).State = EntityState.Deleted;
                    context.PILOTOes.Remove(piloto);
                    context.SaveChanges();

                    Console.WriteLine("\nPiloto removido com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Piloto não encontrado!!!");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion
        
    }
}
