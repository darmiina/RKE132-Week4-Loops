for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i + 1}");
}
Console.WriteLine("Have a nice day.");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"i = {i}");
}
Console.WriteLine("Have a nice day.");

int sum = 0;
for (int i = 1;i < 11;i++)
{
    Console.WriteLine($"i = {i}");
Console.WriteLine($"Current total: = {sum}");
sum = sum + i;
}
// Console.Writeline($"Final total {sum}");
Console.WriteLine("Have a nice day.");