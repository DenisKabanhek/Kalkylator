using System;

public class GeometryCalculator
{
    public static void Main(string[] args)
    {
        // Круг
        double circleRadius = 5.2;
        double circleArea = CalculateCircleArea(circleRadius);
        Console.WriteLine($"Площадь круга с радиусом {circleRadius}: {circleArea}");

        // Прямоугольник
        double rectangleLength = 7.8;
        double rectangleWidth = 3.5;
        double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
        Console.WriteLine($"Площадь прямоугольника со сторонами {rectangleLength} и {rectangleWidth}: {rectangleArea}");

        // Треугольник
        double triangleBase = 4.0;
        double triangleHeight = 6.2;
        double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
        Console.WriteLine($"Площадь треугольника с основанием {triangleBase} и высотой {triangleHeight}: {triangleArea}");

        Console.ReadKey(); // Задерживаем консоль, чтобы увидеть результаты
    }


    // Функция для вычисления площади круга
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Функция для вычисления площади прямоугольника
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    // Функция для вычисления площади треугольника
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}