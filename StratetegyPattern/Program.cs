// See https://aka.ms/new-console-template for more information
using StratetegyPattern.Strategy;
using StratetegyPattern.Strategy.Concrete;

Console.WriteLine("Hello, World!");

var context = new Context();

context.SetStrategy(new Substract());

var result = context.ExecuteStrategy(1, 2);

Console.WriteLine(result);



