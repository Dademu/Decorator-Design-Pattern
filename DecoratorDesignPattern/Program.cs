// See https://aka.ms/new-console-template for more information
using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.Decorators;
using DecoratorDesignPattern.Interfaces;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent
            var concreteComponent = new ConcreteComponent();

            // Create decorators
            var plainDecorator = new PlainDecorators(concreteComponent);
            var upperCaseDecorator = new UpperCaseDecorator(concreteComponent);
            var colorDecorator = new ColorDecorator(concreteComponent);

            // Call GetText() method on each object and print the result to the console
            Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
            Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
        }
    }
}

