using DecoratorDesign.Component;
using DecoratorDesign.Decorator;

namespace DecoratorDesign.ConcreteDecorator
{
    public class StuffedBorder : Pizza
    {
        public StuffedBorder(IPizza pizza) : base(pizza){}

        public override string Optional()
        {
            string pizza = base.Optional();
            pizza += "\r \n Com borda recheda}";

            return pizza;
        }

        public override decimal Price()
        {
            decimal price = base.Price();
            price += 5.00M;

            return price;
        }
    }
}