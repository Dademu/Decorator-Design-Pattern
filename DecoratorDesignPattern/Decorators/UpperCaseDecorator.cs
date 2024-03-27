using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.Decorators;
using DecoratorDesignPattern.Interfaces;
using System;

namespace DecoratorDesignPattern.Decorators
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}
