public class Probe
{
    public static void Run()
    {
        Console.WriteLine(">>> Проба <<<");

        Hero probeHero = new Hero("Учебная проба", 100);
        List<Hero> probeList = new List<Hero>();
        probeList.Add(probeHero);

        probeHero.TakeDamage(20);

        Console.WriteLine($"Через переменную: {probeHero.Health}");
        Console.WriteLine($"Через список: {probeList[0].Health}");
        Console.WriteLine($"Элементов: {probeList.Count}");
    }
}
