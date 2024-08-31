Random dice = new Random();
int roll1 = dice.Next(0,7);
int roll2 = dice.Next(0,7);
int roll3 = dice.Next(0,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 15)
{
    Console.WriteLine("You Win!");
}

if (total < 15)
{
    Console.WriteLine("Better Luck Next Time...");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles!\n+2 Bonus to total!");
    total += 2;
}

if ((roll1 == roll2 ) && (roll2 == roll3))
{
    Console.WriteLine("You rolled Triples!\n+6 Bonus to total!");
    total += 6;
}