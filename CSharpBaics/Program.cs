using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBaics.Basics;

namespace CSharpBaics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            //Reads input as a string
            string name = Console.ReadLine();

            //string interpolation
            Console.WriteLine($"Hi {name}");

            Console.ReadKey();

            //Data Types demonstration
            DataTypes dataTypes = new DataTypes();
            dataTypes.ShowDataTypes();

            //Operators & Expressions demonstration
            OperatorsExpressions oprators_Expressions = new OperatorsExpressions();
            oprators_Expressions.OperatorsExpressionsDemo();

            //input & Output demonstration
            InputOutput inputOutput = new InputOutput();
            inputOutput.InputOutputDemo();

            //Condional Statements demonstration
            ConditionalStatements conditionalStatements = new ConditionalStatements();
            conditionalStatements.ConditionalStatementsDemo();

            //Loops demonstration
            Loops loops = new Loops();
            loops.LoopsDemo();

            //Methods demonstration
            Methods_Parameters methods_Parameters = new Methods_Parameters();
            methods_Parameters.MethodsParametersDemo();

        }
    }
}
