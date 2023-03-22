// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//#define Zadacha_1
//#define Zadacha_2
//#define Zadacha_3
#define Zadacha_4
//#define Zadacha_5
//#define Zadacha_6
//#define Zadacha_7

#if Zadacha_1
Console.WriteLine("Введите целое число от 1 до 100:  ");
int a;
a=Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 100)
{
    Console.WriteLine("\nОшибка ввода! Введите целое число от 1 до 100:  ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a % 3 == 0 && a % 5 == 0) Console.WriteLine("Fizz Buzz");
else if (a % 3 == 0) Console.WriteLine("Fizz");
else if (a % 5 == 0) Console.WriteLine("Buzz");
else Console.WriteLine(a);
#endif

#if Zadacha_2
Console.WriteLine("Введите число: ");
double numer;
numer = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите процент: ");
int procent;
procent = Convert.ToInt32(Console.ReadLine());
double rezultat = numer * procent / 100;
Console.WriteLine(procent + " процентов от " + numer + " равено " + rezultat);
#endif

#if Zadacha_3
Console.WriteLine("Введите четыре цифры через пробел: ");
string chislo = Console.ReadLine();
string[] arr = chislo.Split(new Char[] { ' ' });
int[] arr_rez = new int[4];
int i = 0;
foreach (string item in arr)
{
    arr_rez[i++] = int.Parse(item);
}
int rez = 0;
for (int j=0; j<4; j++)
{
    rez = rez*10+arr_rez[j];
}
Console.WriteLine("Результат: " + rez );
#endif

#if Zadacha_4
Console.WriteLine("Введите шестизначное число: ");
int number=Convert.ToInt32(Console.ReadLine());
int count, iter;
count = 0;
do
{
    iter = number;
    while (iter % 10 != 0)
    {
        count++;
        iter /= 10;
        //Console.WriteLine("Iter="+iter+"\n"+"Count=" + count);
    }
    if (count != 6)
    {
        Console.WriteLine("Необходимо ввести шестизначное число. Повторите ввод: ");
        number = Convert.ToInt32(Console.ReadLine());
        count = 0;
    }
}
while (count != 6);
Console.WriteLine("Введите номера разрядов, которые необходимо поменять местами: ");
string razryad = Console.ReadLine();
string[] arr = razryad.Split(new Char[] { ' ' });
int[] arr_razryad = new int[2];
int i = 0;
foreach (string item in arr)
{
    arr_razryad[i++] = int.Parse(item);
}
int[] arr_number = new int[6];
for (int j = 5; j >= 0; j--)
{
    arr_number[j] = number % 10;
    number /= 10;
    Console.WriteLine(j+"-ый элемент="+arr_number[j]);
}
int rezult = 0;
for (int j = 0;j < 6; j++)// не придумала пока как поменять разряды местами
{

}
#endif

#if Zadacha_7

#endif