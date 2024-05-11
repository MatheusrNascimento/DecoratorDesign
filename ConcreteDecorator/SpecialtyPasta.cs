using DecoratorDesign.Component;
using DecoratorDesign.Decorator;

namespace DecoratorDesign.ConcreteDecorator
{
    public class SpecialtyPasta : Pizza
    {
        public SpecialtyPasta(IPizza pizza) : base(pizza){}

        public override string Optional(){
            string pizza = base.Optional();
            pizza += "\r \n Com massa especial";

            return pizza;
        }

        public override decimal Price()
        {
            decimal price = base.Price();
            price += 6.00M;

            return price;
        }
    }
}