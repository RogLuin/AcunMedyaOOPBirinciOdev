using System.Net.Mail;

namespace acunMedyaOOPOdev;

public class developer : employee
{
    public string about { get; set; }

    public developer(string FirstName, double FirstSalary, string FirstDepartment, string firstAbout)
    
    {
        Name = FirstName;
        Salary = FirstSalary;
        Department = FirstDepartment;
        about = firstAbout;

    }
    public override double CalculateBonus()
    {
        return Salary * 0.10; // Geliştirici için %10 prim
    }
    
    
}



