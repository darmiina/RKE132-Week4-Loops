Random rnd = new Random();

//for(int i = 0; i < 3; i++)
{
   //int myRandomNum = rnd.Next(0, 11); // 0 - 10
   //Console.WriteLine($"My random number is: {myRandomNum}");
}


// Juhuslike väärtuste leidmine ja nende summa

int myRandomNum;
int randomSum = 0;

for(int  i = 0; i < 10; i++)
    {
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");