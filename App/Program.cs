using System;

namespace OOPDemo
{
    // Inheritance and Method Overriding
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

        // Abstract Classes and Methods
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Console.WriteLine();

            // Abstract Classes and Methods
            Circle circle = new Circle(5.0);
            Console.WriteLine($"Circle area: {circle.GetArea()}");

            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");



        }
    }
}