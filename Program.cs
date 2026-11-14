Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);
Hero sergey = new Hero("Сергей", 110);


// Console.WriteLine(yaroslav.GetInfo());
// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());
// Console.WriteLine();
// Console.WriteLine(alexander.GetInfo());

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");
if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

// Probe.Run();
int strongCount = 0;
Hero strongestHero = guild.Heroes[0];
foreach (Hero hero in guild.Heroes) {
    if (hero.MaxHealth >= 120) { 
        strongCount++;
    }
    if (hero.MaxHealth > strongestHero.MaxHealth) {
        strongestHero = hero;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");
Console.WriteLine($"Самый здоровый:: {strongestHero.Name} ({strongestHero.MaxHealth})");