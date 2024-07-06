
public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Vacancy> Vacancies { get; set; }
}

public class Vacancy
{
    public string JobTitle { get; set; }
    public string Description { get; set; }
    public string Requirements { get; set; }
    public int Salary { get; set; }
    public DateTime Deadline { get; set; }
}

