using DecoratorDesign.Component;

namespace DecoratorDesign.ConcreteDecorator
{
    public class Pizza : IPizza
    {

        private readonly IPizza _pizza;

        public Pizza(IPizza pizza)
        {
            _pizza = pizza; 
        }

        public virtual string Optional()
        {
            string pizza = _pizza.Optional();

            return pizza;
        }

        public virtual decimal Price()
        {
            decimal preco = _pizza.Price();

            return preco;   
        }
    }
}