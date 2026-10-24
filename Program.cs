
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);


yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
Console.WriteLine($"Уровень Ярослава: {yaroslav.Level}");

