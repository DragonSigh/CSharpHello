int a = 1;
int b = 6;
int c = 7;
int d = 3;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("max = ");
Console.Write(max);