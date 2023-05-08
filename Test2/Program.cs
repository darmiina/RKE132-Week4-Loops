//PIN'i valideerimine. Kasutaja peab sisestama oma PIN-koodi. Kui PIN on õige, konsoolis kuvatakse "Welcome!". Kasutajal on piiramatu arv katseid.

string userPIN;
while (true)
{
    Console.WriteLine("Enter your PIN");
    userPIN= Console.ReadLine();
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome");
        break;
    } else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}
