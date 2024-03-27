using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern.Components
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hello, world!";
        }
    }
}
