namespace TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        ManagerWorkday mw = new ManagerWorkday();
        mw.CreateWorkday(); // Executes the template method
        Console.ReadKey();
    }
}

//WorkdayPlanner
//ManagerWorkday
//PoliceOfficerWorkday