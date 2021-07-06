using BuilderDP.Compound;
using System;

namespace BuilderDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //HTML
            //var builder = new HtmlBuilder("ul");
            //builder.AddChild("li", "hello").AddChild("li", "world");
            //Console.WriteLine(builder.ToString());

            //Hierarchy
            //var me = Person.New
            //    .Called("Gabi")
            //    .WorksAsA("Intern Developer")
            //    .Build();

            //Console.WriteLine(me);

            //Compound
            var pb = new PersonBuilder();
            Person person = pb
                .Lives.At("123 London Road")
                      .In("London")
                      .WithPostcode("SW12AC")
                .Works.At("Microsoft")
                      .AsA("Software Engineer")
                      .Earning(100000);

            Console.WriteLine(person);
        }
    }
}
