using acunMedyaOOPOdev;
managerManager managerManager = new managerManager();
DeveloperManager developerManager = new DeveloperManager();
developer developer1 = new developer("Görkem",15000,"Backend",
    "Görkem, yazılım geliştirme alanında uzmanlaşmış bir geliştiricidir. " +
    "Özellikle C# ve .NET teknolojilerinde deneyim sahibidir. Temiz ve optimize kod yazmayı önemseyen Görkem, ekip çalışmasına yatkın olup sürekli kendini geliştirmeye odaklanmaktadır.");
developer1.Id = 1;
developer developer2 = new developer("Serkan",12000,"Frontend",
    "Serkan, modern web teknolojilerine hakim bir frontend geliştiricidir. React, Vue.js ve JavaScript konularında deneyimlidir. Kullanıcı odaklı arayüzler geliştirmeyi seven Serkan," +
    " estetik ve işlevselliği bir araya getirerek etkileyici web deneyimleri oluşturur.");
developer2.Id = 2;
developerManager.addDeveloper(developer1);
developerManager.addDeveloper(developer2);

Console.WriteLine("Developer Listesi :");
foreach (var developer in developerManager.getDevelopers())
{
    Console.WriteLine($"Developer :  İsmi : {developer.Name} ,Maaşı : {developer.Salary} ,Departmanı : {developer.Department}, Maaş bonusu : {developer.CalculateBonus()}, Hakkında : {developer.about}");
}

Manager manager1 = new Manager("Ahmet", 100000, "Backend", 20);
Manager manager2 = new Manager("Hakkı", 66000, "Fronted", 5);
manager1.Id = 1;
manager2.Id = 2;
managerManager.addManager(manager1);
managerManager.addManager(manager2);


Console.WriteLine("Manager Listesi :");
foreach (var managers in managerManager.getManagers())
{
    Console.WriteLine($"Managers: {managers.Name} Maaşı : {managers.Salary} , Departmanı : {managers.Department} , Takım Büyüklüğü : {managers.TeamSize}, Maaş bonusu : {managers.CalculateBonus()}");
    
}




