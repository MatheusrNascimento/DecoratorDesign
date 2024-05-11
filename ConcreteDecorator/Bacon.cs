using DecoratorDesign.Component;

namespace DecoratorDesign.ConcreteDecorator
{
    public class Bacon : Pizza
    {
        public Bacon(IPizza pizza) : base(pizza) {}

        public override string Optional(){

            string pizza = base.Optional();
            pizza += "\r \n Com bacon extra";

            return pizza;
        }

        public override decimal Price(){

            decimal pizza = base.Price();
            pizza += 4.00M;

            return pizza;
        }
    }
}