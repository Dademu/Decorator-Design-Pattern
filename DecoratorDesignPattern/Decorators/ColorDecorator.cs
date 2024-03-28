using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.Interfaces;
using DecoratorDesignPattern.Decorators;
using System;

namespace DecoratorDesignPattern.Decorators
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return $"\u001b[35m{base.GetText()}\u001b[0m"; // Colour: 35m (purple)
        }
    }
}
