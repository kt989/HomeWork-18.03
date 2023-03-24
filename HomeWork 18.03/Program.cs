// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");
//#define Zadacha_1
//#define Zadacha_2
//#define Zadacha_3
//#define Zadacha_4
//#define Zadacha_5
//#define Zadacha_6
#define Zadacha_7

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
for (int j=5;j>=0;j--)
{
    arr_number[j] = number % 10;
    number = number / 10;
}
int rezult = 0;
int buffer = arr_number[arr_razryad[0]];
arr_number[arr_razryad[0]] = arr_number[arr_razryad[1]];
arr_number[arr_razryad[1]] = buffer;
for (int j = 0; j < 6; j++) Console.Write(arr_number[j]);
#endif

#if Zadacha_5
using System.Globalization;

Console.WriteLine("Введите дату: ");
string data_vvod = Console.ReadLine();
string[] data = data_vvod.Split(new Char[] { '.' });
int[] arr_data = new int[3];
int i = 0;
foreach (string item in data)
{
    arr_data[i++] = int.Parse(item);
}
/*foreach (int item in arr_data)
{
   Console.WriteLine(item) ;
}*/
if (arr_data[1] >= 3 && arr_data[1] <= 5) Console.WriteLine("Spring");
else if (arr_data[1] >= 6 && arr_data[1] <= 8) Console.WriteLine("Summer");
else if (arr_data[1] >= 9 && arr_data[1] <= 11) Console.WriteLine("Autum");
else Console.Write("Winter ");


DateTime dateValue = new DateTime(arr_data[2], arr_data[1], arr_data[0]);
Console.WriteLine(dateValue.DayOfWeek);


#endif

#if Zadacha_6
Console.WriteLine("Введите значение температуры: ");
double temp =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("В какую шкалу перевести: \n 1. В шкалу Цельсия\n   2. В шкалу Фаренгейта");
int var=Convert.ToInt32(Console.ReadLine());
bool check = true;
while (check)
{
    if (var == 1)
    {
        temp = (temp - 32)*5/9;
        Console.WriteLine("Значение по Цельсию равно " + temp);
        check = false;
    }

    else if (var == 2)
    {
        temp = 1.8 * temp + 32;
        Console.WriteLine("Значение по Фаренгейту равно " + temp);
        check = false;
    }
    else
    {
        Console.WriteLine("Повторите ввод: ");
        var = Convert.ToInt32(Console.ReadLine());
    }
}

/*ConsoleKeyInfo KeyPress;   хотела, чтобы стрелочка переходила, но пока не получилось 

Console.TreatControlCAsInput = true;

KeyPress = Console.ReadKey();
do
{
    KeyPress = Console.ReadKey();

} while (KeyPress.Key != ConsoleKey.Enter);*/


#endif

#if Zadacha_7
Console.WriteLine("Введите диапазон: начальное значение и конечное значение: ");
string[] arr = Console.ReadLine().Split(new Char[] { ' ' });
int[] diapazon = new int[2];
int i = 0;
foreach (string item in arr)
{
    diapazon[i++] = int.Parse(item);
}
if (diapazon[0] > diapazon[1])
{
    int buffer = diapazon[0];
    diapazon[0] = diapazon[1];
    diapazon[1] = buffer;   
}

Console.WriteLine("В диапазон от " + diapazon[0] + " до " + diapazon[1] + " входят следующие четные числа: ");
for (int j = diapazon[0]; j <= diapazon[1];j++)
{
    if (j % 2 == 0) Console.Write(j + "  ");
}
#endif