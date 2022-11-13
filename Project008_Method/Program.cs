int Maximum(int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1;
int a2 = 20;
int a3 = 3;
int b1 = 4;
int b2 = 50;
int b3 = 6;
int c1 = 7;
int c2 = 8;
int c3 = 9;

// int max1 = Maximum(a1, b1, c1);
// int max2 = Maximum(a2, b2, c2);
// int max3 = Maximum(a3, b3, c3);
// int max = Maximum(max1, max2, max3);

int max = Maximum(
    Maximum(a1, b1, c1),
    Maximum(a2, b2, c2),
    Maximum(a3, b3, c3));

Console.WriteLine(max);
