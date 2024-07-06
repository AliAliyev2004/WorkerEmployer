
public class Program
{
    static Worker currentWorker;
    static Employer currentEmployer;

   
    public static void Login(string username, string password)
    {
        
        if (username == "worker1" && password == "password1")
        {
          
            currentWorker = new Worker
            {
                Id = 1,
                Name = "xxx",
                Surname = "MMM",
                City = "DDD",
                Phone = "11111111",
                Age = 30,
                Username = username,
                Password = password,
                CVs = new string[] { "CV1" },
                Specialty = "Software Engineer",
                School = "High School",
                University = "University ",
                Skills = new string[] { "C#", "Java", "Python" },
                CompaniesWorked = new string[] { "ABC ", "XYZ." },
                StartDate = new DateTime(2010, 1, 1),
                EndDate = new DateTime(2020, 12, 31),
                Languages = new Dictionary<string, string>
                {
                    { "English", "aaa" },
                    { "ccc", "bb" }
                },
                
            };

            DisplayWorkerScreen();
        }
        else if (username == "employer1" && password == "password1")
        {
            currentEmployer = new Employer
            {
                Id = 1,
                Name = "xx",
                Surname = "MM",
                City = "DDDD",
                Phone = "11111111",
                Age = 35,
                Username = username,
                Password = password,
                Vacancies = new List<Vacancy>
                {
                    new Vacancy
                    {
                        JobTitle = "Software Developer",
                        Description = "Developer",
                        Requirements = ".....",
                        Salary = 80000,
                        Deadline = new DateTime(2024, 12, 31)
                    },
                    new Vacancy
                    {
                        JobTitle = "Web Designer",
                        Description = "Design websites .",
                        Requirements = " HTML, CSS, JavaScript.",
                        Salary = 60000,
                        Deadline = new DateTime(2024, 12, 31)
                    }
                }
            };

            
            DisplayEmployerScreen();
        }
        else
        {
            Console.WriteLine("Invalid password or Username");
        }
    }

    
    public static void DisplayWorkerScreen()
    {
        Console.WriteLine($"Xos geldiniz {currentWorker.Name} {currentWorker.Surname}!");
       
    }

    
    public static void DisplayEmployerScreen()
    {
        Console.WriteLine($"Xoş geldiniz, {currentEmployer.Name} {currentEmployer.Surname}!");
        
    }

    public static void Main(string[] args)
    {
      
        Login("worker1", "password1");
        
    }
}
