using System;
using Constructs;
using HashiCorp.Cdktf;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            new NamerConstruct(app, "MyNamerConstruct");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}