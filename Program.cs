// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Atama ve İşlemli Atama Operatörler***");

int x = 5;
int y= 3;
int z = x + y;
x = x-2;
Console.WriteLine(x);
y += 2;
Console.WriteLine(y);

Console.WriteLine("***Mantıksal Operatörler***");

bool isSuccess = true;
bool isFail = false;

if (isSuccess && isFail)
    Console.WriteLine("Succeed and Failed");

if (isSuccess && !isFail)
    Console.WriteLine("Succeed and not Failed");

if (isSuccess || isFail)
    Console.WriteLine("Succeed or Failed");

if (isSuccess || !isFail)
    Console.WriteLine("Succeed or not Failed");

Console.WriteLine("***İlişkisel Operatörler***");

int a = 3;
int b = 5;

bool sonuc = a<b;
Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

Console.WriteLine("***Aritmetik Operatörler***");

int sayi1 = 100;
int sayi2 = 50;
int result = 10;

result += sayi2;
Console.WriteLine(result);
result *= 2;
Console.WriteLine(result);
result = sayi1 - sayi2;
Console.WriteLine(result);
result /= sayi2;
Console.WriteLine(result);
