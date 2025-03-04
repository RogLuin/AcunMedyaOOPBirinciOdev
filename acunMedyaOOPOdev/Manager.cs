namespace acunMedyaOOPOdev;

public class Manager : employee
{
    public int TeamSize { get; set; }

    public Manager(String Firstname, double Firstsalary, string FirstDepartmant ,int FirstteamSize)
    {
        Name = Firstname;
        Salary = Firstsalary;
        Department = FirstDepartmant;
        TeamSize = FirstteamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.20;
    }
    
}