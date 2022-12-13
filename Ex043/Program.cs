internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа для поиска перечесения двух прямых");
        double x,y;
        Console.WriteLine("Координаты первой прямой линии");
        Console.Write("Введите b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Координаты второй прямой линии");
        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

       x = Math.Round((-b2+b1)/(-k1+k2),2);
       
       y = Math.Round(k2*x+b2,2);
       
       Console.Write("Точка пересечения двух линий: ({0};{1})",x,y);
    }
}