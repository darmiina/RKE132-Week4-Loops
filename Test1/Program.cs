//Kasutaja peab sisestama oma PIN-koodi. Kui PIN on õige (,ehk kasutaja sisestab 1234), konsoolis kuvatakse "Welcome!". Kasutajal on kolm katset.

string userPIN;
int triesUsed = 0;
while (triesUsed!=3) 
{
    Console.WriteLine("Enter your PIN");
    userPIN = Console.ReadLine();
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
        triesUsed = 3; //number
    }else
    {
        Console.WriteLine($"Wrong PIN. Try again. {3 - triesUsed} tries left.");
        triesUsed ++;
    }
}