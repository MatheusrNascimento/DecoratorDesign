using DecoratorDesign.Component;
using DecoratorDesign.ConcreteComponent;

Console.WriteLine("⇢ Decorator Pizzaria ⇠  🤠");

IPizza pizzaBase = new Pizza();

Console.WriteLine(pizzaBase.Optional());
Console.WriteLine($"Preço: R$ {pizzaBase.Price()}");
Console.WriteLine("A pizza padrão foi criada \n Tecle qualquer tecla para o padrao decorator incrementar opçoes!");
Console.ReadKey();

System.Console.WriteLine("----> Inplementando decorator para inserir opçoes automaticas na pizza <------)");

IPizza pizzaWithOptional = new Pizza();