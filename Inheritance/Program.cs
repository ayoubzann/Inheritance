using Employees;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Console.WriteLine("TIFFANYS & CO - PRIVATE PROGRAM TM\nPress the number of the action you want to pursue, and press [ENTER].\n1) Add an Employee\n2) Delete an Employee\n3) Exit");
            var menuChoice = Int32.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("a) Add a Manager\nb) Add an Engineer\nc) Add a Researcher");
                    var menuChoice1 = Console.ReadLine();

                    switch (menuChoice1)
                    {
                        case "a":

                            Manager manager = new();

                            Console.WriteLine("Please type in the first name of the manager and press [ENTER]:");
                            string managerFirstName = Console.ReadLine();
                            Console.WriteLine("Please type in the last name of the manager and press [ENTER]:");
                            string managerLastName = Console.ReadLine();
                            Console.WriteLine("Please type in the salary of the manager and press [ENTER]:");
                            int managerSalary = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Please type in how many meetings the manager will attend weekly and press [ENTER]:");
                            int managerMeetings = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Please type in how many vacation-weeks the manager has annually and press [ENTER]:");
                            int managerVacationWeeks = Int32.Parse(Console.ReadLine());

                            manager.firstName = managerFirstName;
                            manager.lastName = managerLastName;
                            manager.salary = managerSalary;
                            manager.meetingsPerWeek = managerMeetings;
                            manager.vacationsPerYear = managerVacationWeeks;
                            Employees.Add(manager);
                            
                            break;

                        case "b":

                            Engineer engineer = new();

                            Console.WriteLine("Please type in the first name of the engineer and press [ENTER]:");
                            string engineerFirstName = Console.ReadLine();
                            Console.WriteLine("Please type in the last name of the engineer and press [ENTER]:");
                            string engineerLastName = Console.ReadLine();
                            Console.WriteLine("Please type in the salary of the engineer and press [ENTER]:");
                            int engineerSalary = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Is the engineer able to use C#? If yes, type [yes] and press [ENTER]. If no, type [no] and press [ENTER]:");
                            string cSkill = Console.ReadLine();
                            if (cSkill == "yes")
                            {
                                engineer.cSharpSkill = true;
                            }
                            else
                            {
                                engineer.cSharpSkill = false;
                            }
                            Console.WriteLine("How many years of experience does the engineer have? Type the number of years and press [ENTER]:");
                            int engineerExperience = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What kind of engineering is the engineers field? Please write their field and press [ENTER]:");
                            string engineerField = Console.ReadLine();

                            engineer.firstName = engineerFirstName;
                            engineer.lastName = engineerLastName;
                            engineer.salary = engineerSalary;
                            engineer.xp = engineerExperience;
                            engineer.typeOfEngineer = engineerField;

                            Employees.Add(engineer);

                            break;

                        case "c":

                            Researcher researcher = new();

                            Console.WriteLine("Please type in the first name of the researcher and press [ENTER]:");
                            string researcherFirstName = Console.ReadLine();
                            Console.WriteLine("Please type in the last name of the researcher and press [ENTER]:");
                            string researcherLastName = Console.ReadLine();
                            Console.WriteLine("Please type in the salary of the researcher and press [ENTER]:");
                            int researcherSalary = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What university did the researcher get their Doctorate? Please type in the name of the university and press [ENTER]:");
                            string researcherUniversity = Console.ReadLine();
                            Console.WriteLine("What was the thesis statement of the researchers doctorate? Please type in the thesis question and press [ENTER]:");
                            string researcherThesis = Console.ReadLine();

                            researcher.firstName = researcherFirstName;
                            researcher.lastName = researcherLastName; 
                            researcher.salary = researcherSalary;
                            researcher.degree = researcherUniversity;
                            researcher.doctorateThesis = researcherThesis;

                            Employees.Add(researcher);
                            break;
                    }
                       
                    break;

                case 2:
                    
                            Console.WriteLine("What is the first name of the engineer?");
                            string toDeleteFirstName = Console.ReadLine();
                    Employee employeeToBeDeleted = Employees.Find(e => e.firstName == toDeleteFirstName);
                    if (employeeToBeDeleted != null)
                        Employees.Remove(employeeToBeDeleted);
                    else
                        Console.WriteLine($"Could not find {employeeToBeDeleted}");
                    break;


                case 3:

                    break;
            }
                    
            


        }
    }
}