using System;

class RamaGame
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в аркаду по сюжету Рамаяны!");

        Console.Write("Введите имя главного героя: ");
        string heroName = Console.ReadLine();

        Console.WriteLine($"Привет, {heroName}! Тебе предстоит спасти свою жену Ситу из клеша, жестокого демона!");

        Console.WriteLine("Игра началась!");

        int enemyHealth = 100;
        int heroHealth = 100;
        int heroDamage = 20;
        int enemyDamage = 30;

        while (heroHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"Здоровье героя: {heroHealth}");
            Console.WriteLine($"Здоровье врага: {enemyHealth}");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Атаковать");
            Console.WriteLine("2. Уклониться");
            Console.WriteLine("3. Защищаться");

            Console.Write("Введите номер действия: ");
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine($"Вы атаковали врага и нанесли {heroDamage} урона!");
                    enemyHealth -= heroDamage;
                    break;
                case 2:
                    Console.WriteLine($"Вы уклонились от атаки врага!");
                    break;
                case 3:
                    Console.WriteLine($"Вы защитились от атаки врага и получили урон {enemyDamage / 2}!");
                    heroHealth -= enemyDamage / 2;
                    break;
                default:
                    Console.WriteLine("Неправильный выбор, вы пропускаете ход.");
                    break;
            }

            if (enemyHealth > 0)
            {
                Console.WriteLine("Враг атакует!");
                Console.WriteLine($"Вам нанесено {enemyDamage} урона!");
                heroHealth -= enemyDamage;
            }
        }

        if (heroHealth <= 0)
        {
            Console.WriteLine("Вы проиграли! Ваша жена Сита остается в плену клеши.");
        }
        else
        {
            Console.WriteLine("Вы победили! Сита спасена и теперь вы можете жить вместе счастливо.");
        }
    }
}