using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz figurę geometryczną:");
                Console.WriteLine("1.kwadrat");
                Console.WriteLine("2. prostokąt");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Koło");
                Console.WriteLine("5. Wyjściee");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateSquare();
                        break;
                    case 2:
                        CalculateRectangle();
                        break;
                    case 3:
                        CalculateTriangle();
                        break;
                    case 4:
                        CalculateCircle();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
        }

        static void CalculateSquare()
        {
            Console.Write("Podaj długość boku kwadratu: ");
            double side = double.Parse(Console.ReadLine());

            double perimeter = 4 * side;
            double area = side * side;

            Console.WriteLine($"Obwód kwadratu: {perimeter}");
            Console.WriteLine($"Pole kwadratu: {area}");
        }

        static void CalculateRectangle()
        {
            Console.Write("Podaj długość prostokąta: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Podaj szerokość prostokąta: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine($"Obwód prostokąta: {perimeter}");
            Console.WriteLine($"Pole prostokąta: {area}");
        }

        static void CalculateTriangle()
        {
            Console.Write("Podaj długość pierwszego boku trójkąta: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj długość drugiego boku trójkąta: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Podaj długość trzeciego boku trójkąta: ");
            double c = double.Parse(Console.ReadLine());

            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            double hypotenuse = Math.Max(a, Math.Max(b, c));
            double radius = (a * b * c) / (4 * area);

            Console.WriteLine($"Obwód trójkąta: {perimeter}");
            Console.WriteLine($"Pole trójkąta: {area}");

            if (IsRightTriangle(a, b, c))
            {
                Console.WriteLine($"Przeciwprostokątna trójkąta: {hypotenuse}");
            }
            else
            {
                Console.WriteLine("Trójkąt nie jest prostokątny.");
            }

            Console.WriteLine($"Promień okręgu opisanego na trójkącie: {radius}");
        }

        static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-9;
        }

        static void CalculateCircle()
        {
            Console.Write("Podaj promień koła: ");
            double radius = double.Parse(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"Obwód koła: {circumference}");
            Console.WriteLine($"Pole koła: {area}");
        }
    }
}