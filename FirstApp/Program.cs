
namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        { 
            Store store = new Store();
            List<IEmployee> employees = new List<IEmployee>();
            employees.AddRange(new List<IEmployee> {
                new Manager("Mario", "Jusup", 165, 6, 150),
                new Cashier("Ivan", "Ivić", 80, 5),
                new Cashier("Iva", "Ivanović", 150, 4),
                new Cashier("Marko", "Markić", 160, 5) });
            store.Employees = employees;

            //String awaitKey;
            //do {
            //    awaitKey = Console.ReadLine();

            //} while (awaitKey != "q");

            Console.WriteLine(store.CalculateTotalExpnses(employees));
            Console.ReadLine();
        }
    }
}