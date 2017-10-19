using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaConsole
{
    internal class Program
    {
        private static void DeleteNinja()
        {
            throw new NotImplementedException();
        }

        private static void InsertMultipleNinjas()
        {
            throw new NotImplementedException();
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "XaoSan",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1976, 1, 1),
                ClanId = 1
            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }

        private static void Main(string[] args)
        {
            InsertNinja();
            //InsertMultipleNinjas();
            //SimpleNinjaQuery();
            //SimpleNingaGraphQuery();
            //QueryAndUpdateNinja();
            //QueryAndUpdateNinjaDisconnected();
            //DeleteNinja();
            Console.ReadKey();
        }

        private static void QueryAndUpdateNinja()
        {
            throw new NotImplementedException();
        }

        private static void QueryAndUpdateNinjaDisconnected()
        {
            throw new NotImplementedException();
        }

        private static void SimpleNingaGraphQuery()
        {
            throw new NotImplementedException();
        }

        private static void SimpleNinjaQuery()
        {
            throw new NotImplementedException();
        }
    }
}