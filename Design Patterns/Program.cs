// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Design_Patterns.BuilderPattern;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Client code creates the builder object, passes it to the director,and then initiates the construction process.
        /// The end result is retireved from builder object.
        /// End result is collected from the builder object as director might not be aware of/dependent upon concrete builders
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product product;
            Director director = new Director();

            CokeConcreteBuilder cokebuilder = new CokeConcreteBuilder();
            product = director.NutritionalFactDirectorMethod(cokebuilder);
            Console.WriteLine("---------------------------------------------"); 
            

            MaggieConcreteBuilder maggieBuilder = new MaggieConcreteBuilder();
            product = director.NutritionalFactDirectorMethod(maggieBuilder);

        }
    }
}
