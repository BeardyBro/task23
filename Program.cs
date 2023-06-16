Console.WriteLine("Insert number");
int num = Convert.ToInt32(Console.ReadLine());
int lol =1;
if (num <=0)
{Console.WriteLine("Try again");}
else{
    while (lol <=num)
    {
        int result = lol*lol*lol;
        Console.WriteLine(result);
        lol++;
    }
}