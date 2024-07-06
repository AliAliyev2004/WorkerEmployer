
public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public string[] CVs { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    // CV 
    public string Specialty { get; set; }
    public string School { get; set; }
    public string University { get; set; }
    public string[] Skills { get; set; }
    public string[] CompaniesWorked { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Dictionary<string, string> Languages { get; set; }
    public bool HasDegree { get; set; }
    public string GitLink { get; set; }
    public string LinkedIn { get; set; }
}
