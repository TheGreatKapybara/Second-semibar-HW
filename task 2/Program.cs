int number = Convert.ToInt32(Console.ReadLine());
string secondNumber = Convert.ToString(number);
if(secondNumber.Length < 3)
{
    System.Console.WriteLine("Третьего числа нет");
} else{
System.Console.WriteLine("Третья цифра - "+secondNumber[2]);
}
