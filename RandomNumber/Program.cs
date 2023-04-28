// Juhuslikud numbrid ja FOR-tsükkel

Random rnd = new Random();
int myRandomNum;
int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); // 0 - 10, otspunkt pole kaasa arvatud
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"Sum of the random numbers: {randomSum}");