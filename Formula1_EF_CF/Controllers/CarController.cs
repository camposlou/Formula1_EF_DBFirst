using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formula1_EF_CF.Controllers
{
    internal class CarController
    {
        #region INSERT
        public void InsertCar()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Cadastrar Carro<<<");

            using (var context = new Formula1Entities())
            {
                CARRO carro = new CARRO();
                Console.WriteLine("\nDigite o Id da Equipe: ");
                carro.IdEquipe = int.Parse(Console.ReadLine());
                Console.Write("\nModelo: ");
                carro.Modelo = Console.ReadLine();
                Console.Write("\nUnidade: ");
                carro.Unidade = int.Parse(Console.ReadLine());
                Console.Write("\nAno de Fabricação: ");
                carro.Ano_Fabricacao = int.Parse(Console.ReadLine());

                context.CARROes.Add(carro);
                context.SaveChanges();
                Console.WriteLine(carro.ToString());

                Console.WriteLine("\nCarro cadastrado com sucesso...");
                Console.ReadKey();

            }
        }
        #endregion

        #region SELECT ALL
        public void ListCar()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Listar Carros<<<");

            using (var context = new Formula1Entities())
            {
                var carros = new Formula1Entities().CARROes.ToList();
                foreach (var item in carros)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();

        }
        #endregion

        #region SELECT ONE
        public void UniqueCar()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Selecionar Carro Específico<<<");              
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                CARRO carro = new Formula1Entities().CARROes.Find(id);
                if (carro != null)
                {
                    Console.WriteLine(carro.ToString());
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nCarro não encontrada...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }

        }
        #endregion

        #region UPDATE
        public void UpdateCar()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Alterar Cadastro<<<");
                Console.WriteLine("Digite o Id do carro que deseja alterar o cadastro: ");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                CARRO carro = context.CARROes.Find(id);
                if (carro != null)
                {                    
                    Console.Write("Alterar Modelo: ");
                    carro.Modelo = Console.ReadLine();
                    Console.Write("\nAlterar a Unidade: ");
                    carro.Unidade = int.Parse(Console.ReadLine());
                    Console.Write("\nAlterar o Ano de Fabricação: ");
                    carro.Ano_Fabricacao = int.Parse(Console.ReadLine());
                    context.Entry(carro).State = EntityState.Modified;
                    context.CARROes.AddOrUpdate(carro);
                    context.SaveChanges();
                    Console.WriteLine(carro.ToString());
                    Console.WriteLine("\nDados do Carro alterado com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }

            }

        }
        #endregion

        #region DELETE
        public void DeleteCar()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Remover Carro<<<");
                Console.Write("\nDigite o Id: ");
                int id = int.Parse(Console.ReadLine());
                CARRO carro = context.CARROes.Find(id);
                if (carro != null)
                {
                    context.Entry(carro).State = EntityState.Deleted;
                    context.CARROes.Remove(carro);
                    context.SaveChanges();

                    Console.WriteLine("\nCarro removido com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Carro não encontrado!!!");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion       


    }
}
