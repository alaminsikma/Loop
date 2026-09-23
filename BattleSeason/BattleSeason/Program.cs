Console.Write("Input character's name: ");
string name = Console.ReadLine();

Console.Write("Input number of battles: ");
int battles = int.Parse(Console.ReadLine());

Console.Write("Input EXP gained per battle: ");
int expPerBattle = int.Parse(Console.ReadLine());
            
Console.WriteLine();

int totalExp = 0;

for (int i = 1; i <= battles; i++)
{
int previousExp = totalExp;
totalExp += expPerBattle;

Console.WriteLine($"Battle {i} | EXP gained: {expPerBattle} | Total EXP: {totalExp}");
int prevMilestone = previousExp / 100;
int currMilestone = totalExp / 100;

if (currMilestone > prevMilestone && currMilestone > 0)
    {
        for (int m = prevMilestone + 1; m <= currMilestone; m++)
        {
            Console.WriteLine($"*** Milestone reached! Total EXP: {m * 100} ***");
        }
    }
}

Console.WriteLine("\n=== BATTLE COMPLETE ===");
Console.WriteLine($"Character : {name}");
Console.WriteLine($"Battles   : {battles}");
Console.WriteLine($"Total EXP : {totalExp}");