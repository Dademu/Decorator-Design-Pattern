using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.Interfaces;
using DecoratorDesignPattern.Decorators;

namespace DecoratorDesignPattern.Decorators
{
    public class PlainDecorators : Decorator<string>
    {
        public PlainDecorators(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return component.GetText();
        }
    }
}
