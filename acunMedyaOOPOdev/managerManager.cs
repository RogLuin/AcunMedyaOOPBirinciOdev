namespace acunMedyaOOPOdev;

public class managerManager : employee
{
    private List<Manager> managers = new List<Manager>();

    public void addManager(Manager manager)
    {
        managers.Add(manager);
    }

    public List<Manager> getManagers()
    {
        return managers;
    }
    public void removeManager(Manager manager)
    {
        var managerToRemove = managers.FirstOrDefault(s => s.Id == manager.Id);
        if (managerToRemove != null)
        {
            removeManager(managerToRemove);
            Console.WriteLine($"Manager: {manager.Name} Silindi");
        }
        else
        {
            Console.WriteLine("Manager Not Found");
        }
        
    }
}