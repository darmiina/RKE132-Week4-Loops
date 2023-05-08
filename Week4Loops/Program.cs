// FOR-LOOP 
// Dry-principal - do not repeat yourself

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("We don't need no education.");
}

Console.WriteLine("Have a nice day.");


// Kasutaja poolt sisestatud numbrit korrutatakse väärtusega 1-10

Console.WriteLine("Enter a Number");
int userNumber = Int32.Parse(Console.ReadLine());
for(int i = 0;i < 10; i++)
{
    Console.WriteLine($"{i + 1} * {userNumber} = {(i + 1) * userNumber}");
}

