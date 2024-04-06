
using topshiriq;

using (var dbContext = new TalabaDbContext())
{
    Console.WriteLine($"\n1. Talabalar ro'yxatini ko'rsatish");
    Console.WriteLine("2. Yangi talaba qo'shish");
    Console.Write("Tanlang (1 yoki 2): ");

    string tanlov = Console.ReadLine();

    switch (tanlov)
    {
        case "1":
            KorsatishTalabalar(dbContext);
            break;
        case "2":
            YangiTalabaQoshish(dbContext);
            break;
        default:
            Console.WriteLine("Noto'g'ri tanlov!");
            break;
    }
}


static void KorsatishTalabalar(TalabaDbContext dbContext)
{
    var talabalar = dbContext.Talabalar.ToList();
    if (talabalar.Any())
    {
        Console.WriteLine("Talabalar ro'yxati:");

        foreach (var talaba in talabalar)
        {
            Console.WriteLine($"ID: {talaba.Id}, Ism: {talaba.Ism}, Familiya: {talaba.Familiya} " +
                $", Yosh :{talaba.Yosh}, Shahar:{talaba.Shahar}");
        }
    }
    else
    {
        Console.WriteLine("Hozircha talabalar mavjud emas!");
    }
}

static void YangiTalabaQoshish(TalabaDbContext dbContext)
{
    Console.Write("Talabaning ismini kiriting: ");
    string ism = Console.ReadLine();

    Console.Write("Talabaning familiyasini kiriting: ");
    string familiya = Console.ReadLine();

    Console.WriteLine("Talabaning Yoshini kiriting: ");
    int yosh = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Talabaning Shaxrini kiriting: ");
    string shaxar = Console.ReadLine();


    var yangiTalaba = new Talaba { Ism = ism, Familiya = familiya, Yosh = yosh, Shahar = shaxar };
    dbContext.Talabalar.Add(yangiTalaba);
    dbContext.SaveChanges();

    Console.WriteLine("Talaba muvaffaqiyatli qo'shildi.");

    //Console.WriteLine(dbContext.Talabalar.ToList<Talaba>());
}

