Random random = new Random();
int attack = random.Next(1, 11);

int heroVitality = 10;
int monsterVitality = 10;

do {
    attack = random.Next(1, 11);
    monsterVitality = monsterVitality - attack;
    Console.WriteLine("Monster was damaged and lost " + attack + " health and now has " + monsterVitality + " health.");
    if (monsterVitality <= 0) {
        Console.WriteLine("Hero wins!");
    }
    else {
        attack = random.Next(1, 11);
        heroVitality = heroVitality - attack;
        Console.WriteLine("Hero was damaged and lost " + attack + " health and now has " + heroVitality + " health.");
        if (heroVitality <= 0) {
            Console.WriteLine("Monster wins!");
        } continue;
    }
} while (heroVitality > 0 && monsterVitality > 0);