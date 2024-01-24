using DeepCopyEfCoreTest.Data;
using DeepCopyEfCoreTest.DeepCopying;
using DeepCopyEfCoreTest.Models.Models;

namespace DeepCopyEfCoreTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VerifyWorkingAsExpected();
            VerifyDeepCopyProblem();

            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        private static void VerifyDeepCopyProblem()
        {
            var dbContext = new AppDbContext();

            // Create Agenda
            var newAgenda = new Agenda();
            newAgenda.Points.Add(new AgendaPoint());

            // Deepcopy it
            var agendaDeepCopied = newAgenda.DeepCopy();

            // Track i2
            dbContext.Add(agendaDeepCopied);

            // Bam, two agenda points
            Console.WriteLine($"Count with deepcopy {agendaDeepCopied.Points.Count}");

        }

        private static void VerifyWorkingAsExpected()
        {
            var dbContext = new AppDbContext();

            // Create Agenda, it's important that the underlying collection is a HashSet
            var agenda1 = new Agenda();
            agenda1.Points.Add(new AgendaPoint());

            // Create another agenda, use the same point
            var agenda2 = new Agenda();
            agenda2.Points.Add(agenda1.Points.Single());

            // Track agenda2
            dbContext.Add(agenda2);

            // Check the agenda points, hopefully still one
            Console.WriteLine($"Count with normal workflow {agenda2.Points.Count}");
        }
    }
}
