Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
double y = 0;
switch (n)
{
    case 1:
        {
            double a = -1; double b= 3.4; double z = Math.Tan(b * x);
            if (x >= a) y = (Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2));
            else if ((a < x) && x <= Math.Pow(b, 3.5)) y = (a + Math.Log(Math.Abs(a + b * z)) - 2);
            else if (x > Math.Pow(b, 3.5)) y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
        }
        break;

        case 2:
        {
            double a = -3.2; double b = 5.5; double z = Math.Pow(Math.Tan(b * x), 2);
            if (x >= a) y = (Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2));
            else if ((a < x) && x <= Math.Pow(b, 3.5)) y = (a + Math.Log(Math.Abs(a + b * z)) - 2);
            else if (x > Math.Pow(b, 3.5)) y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
        }
        break;

        case 3:
        {
            double a = -5.2; double b = 7.2; double z = Math.Pow(Math.Tan(b * x),3);
            if (x >= a) y = (Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2));
            else if ((a < x) && x <= Math.Pow(b, 3.5)) y = (a + Math.Log(Math.Abs(a + b * z)) - 2);
            else if (x > Math.Pow(b, 3.5)) y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
        }
        break;
}