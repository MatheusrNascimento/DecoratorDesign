using DecoratorDesign.Component;

namespace DecoratorDesign.ConcreteComponent
{
    public class Pizza : IPizza
    {
        public string Optional(){

            string pizza = "Pizza padrão ou normal";

            return pizza;
        }

        public decimal Price(){

            decimal preco = 10.00M;

            return preco;
        }
    }
}