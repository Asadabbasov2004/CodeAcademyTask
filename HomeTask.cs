//1. Verilmiş 3 müsbət ədəddən(rəqəmdən) 5ə bölünənlərinin cəmini tapın 
//Console.WriteLine("please enter first number");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("please enter second number");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("please enter third number");
//int c = int.Parse(Console.ReadLine());
// if (a>0 && b>0 && c > 0)
//{
//    if (a%5==0 && b%5==0 && c % 5 == 0)
//    {
//        Console.WriteLine("sum is :"+(a+b+c));
//    }
//    else
//    {
//        Console.WriteLine("the condition was not met");
//    }
//}
//else
//{
//    Console.WriteLine("Please enter positive number");
//}

//. Verilmiş 278 ədədinin rəqəmləri cəmini tapın (2+7+8 <-- bunu tapan alqoritm yazmalısınız).
int num = 278;
if (num != 0)
{
    int sum = 0;
    int residual;
    residual = num % 10;
    sum = sum + residual; //close method sum+=residual
    num = num / 10; //close path num/=10

    residual = num % 10;
    sum += residual;
    num /= 10;

    residual = num % 10;
    sum += residual;
    num /= 10;
    Console.WriteLine(sum);
}else
{
    Console.WriteLine("Number is Zero");
}
