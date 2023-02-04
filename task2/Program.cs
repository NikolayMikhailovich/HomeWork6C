// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int K1 = 0;
const int B1 = 1;
const int K2 = 2;
const int B2 = 3;

void UserInput(double[] coeff, string message)
{
  System.Console.WriteLine($"Введите коэффициенты для уравнений k1, b1, k2, b2");
  for (int i = 0; i <= coeff.Length - 1; i++)
  {
    coeff[i] = Convert.ToDouble(Console.ReadLine());
  }
}
double FindX(double[] coeff)
{
  double x = (coeff[B2] - coeff[B1]) / (coeff[K1] - coeff[K2]);
  return x;
}

double FindY(double[] coeff)
{
  double x = FindX(coeff);
  double y = coeff[K1] * x + coeff[B1];
  return y;
}

double[] coeff = new double[4];
UserInput(coeff, "Введите коэффиценты для расчёта");
double resultX = FindX(coeff);
double resultY = FindY(coeff);
System.Console.WriteLine($"Координаты Х пересечения двух прямых с заданными коэффициентами{resultX},{resultY}");
Console.ResetColor();









// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");