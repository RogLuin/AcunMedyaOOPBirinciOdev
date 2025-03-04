namespace acunMedyaOOPOdev;

public class DeveloperManager
{
    private List<developer> developers = new List<developer>();

    public void addDeveloper(developer developer)
    {
        developers.Add(developer);
    }

    public List<developer> getDevelopers()
    {
        return developers;
    }
    

    public void deleteDeveloper(int Id)
    {
        var developer = developers.FirstOrDefault(s => s.Id == Id);
        if (developer != null)
        {
            developers.Remove(developer);
            Console.WriteLine($"Developer :  {developer.Name}  Silindi !");
        }
        else
        {
                
            Console.WriteLine("Developer Bulunamadı.");
        }
        
    }
}