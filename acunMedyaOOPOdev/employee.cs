namespace acunMedyaOOPOdev;

public class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
    

    public virtual double CalculateBonus()
    {
        return 0; // Varsayılan olarak 0 prim
    }

    public double GetTotalSalary()
    {
        return Salary + CalculateBonus();
    }
    
}