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
    internal class CarDriverController
    {
        #region INSERT
        public void InsertEvent()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Cadastrar Evento<<<");

            using (var context = new Formula1Entities())
            {
                PILOTOCARRO pilotocarro = new PILOTOCARRO();
                Console.Write("\nDigite a Data do Evento: ");
                pilotocarro.Data_Evento = DateTime.Parse(Console.ReadLine());
                Console.Write("\nDigite o Id do Carro: ");
                pilotocarro.Id_Carro = int.Parse(Console.ReadLine());
                Console.Write("\nDigite o Id do Piloto: ");
                pilotocarro.Id_Piloto = int.Parse(Console.ReadLine());
                context.PILOTOCARROes.Add(pilotocarro);
                context.SaveChanges();
                Console.WriteLine(pilotocarro.ToString());

                Console.WriteLine("\nEvento cadastrado com sucesso...");
                Console.ReadKey();

            }
        }
        #endregion

        #region SELECT ALL
        public void ListEvent()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Listar Evento<<<");

            using (var context = new Formula1Entities())
            {
                var pilotocarros = new Formula1Entities().PILOTOCARROes.ToList();
                foreach (var item in pilotocarros)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();

        }
        #endregion

        #region SELECT ONE
        public void UniqueEvent()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Selecionar Evento Específico<<<");
                Console.Write("\nData do Evento: ");
                DateTime dataevento =DateTime.Parse(Console.ReadLine());
                PILOTOCARRO pilotocarro = context.PILOTOCARROes.Find(dataevento);
                if (pilotocarro != null)
                {
                    Console.WriteLine(pilotocarro.ToString());
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
        public void UpdateEvent()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Alterar Dados do Evento<<<");
                Console.WriteLine("Digite a data do Evento que deseja alterar os dados: ");
                Console.Write("\nData do evento: ");
                DateTime dataevento = DateTime.Parse(Console.ReadLine());
                PILOTOCARRO pilotocarro = context.PILOTOCARROes.Find(dataevento);
                if (pilotocarro != null)
                {                    
                    Console.Write("Alterar Data do Evento: ");
                    pilotocarro.Data_Evento = DateTime.Parse(Console.ReadLine());
                    Console.Write("\nAlterar o Id do Carro: ");
                    pilotocarro.Id_Carro = int.Parse(Console.ReadLine());
                    Console.Write("\nAlterar o Id do Piloto: ");
                    pilotocarro.Id_Piloto = int.Parse(Console.ReadLine());
                    context.Entry(pilotocarro).State = EntityState.Modified;
                    context.PILOTOCARROes.AddOrUpdate(pilotocarro);
                    context.SaveChanges();
                    Console.WriteLine(pilotocarro.ToString());
                    Console.WriteLine("\nDados do Evento alterado com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }

            }

        }
        #endregion

        #region DELETE
        public void DeleteEvent()
        {
            Console.Clear();
            using (var context = new Formula1Entities())
            {
                Console.WriteLine("\n>>>Remover Evento<<<");
                Console.Write("\nData do evento: ");
                DateTime dataevento = DateTime.Parse(Console.ReadLine());              

                PILOTOCARRO pilotocarro = context.PILOTOCARROes.Find(dataevento);
                if (pilotocarro != null)
                {
                    context.Entry(pilotocarro).State = EntityState.Deleted;
                    context.PILOTOCARROes.Remove(pilotocarro);
                    context.SaveChanges();

                    Console.WriteLine("\nEvento removido com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Evento não encontrado!!!");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion
       
    }
}
