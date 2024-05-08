namespace TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        PoliceOfficerWorkday mw = new PoliceOfficerWorkday();
        mw.CreateWorkday(); // Executes the template method
        Console.ReadKey();
    }
}

//WorkdayPlanner
//ManagerWorkday
//PoliceOfficerWorkday