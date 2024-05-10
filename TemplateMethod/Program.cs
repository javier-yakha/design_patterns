namespace TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        YakhaTraineeWorkday ytw = new YakhaTraineeWorkday();
        ytw.CreateWorkday(); // Executes the template method
        Console.ReadKey();
    }
}

//WorkdayPlanner
//ManagerWorkday
//PoliceOfficerWorkday