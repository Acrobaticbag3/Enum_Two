using System;

namespace Enum_Two {
    internal class Program {
        static void Main(string[] args) {
            string choiceOfShape;
            string choiceOfCalcualtion;
            choiceOfShape = Console.ReadLine();

            string questionOne = "Calculation 1, 2 or both: ";

            Shapes getParse;
            bool checkParse = Enum.TryParse(choiceOfShape, out getParse);

            switch (choiceOfShape) {

                case "Triangle":
                    

                    break;

                case "Rectangle":
                    
                    break;

                case "Circle":
                    
                    break;

                case "Cylinder":
                    
                    break;

                case "Sphere":
                    
                    break;
                
                default :
                    Console.WriteLine($"Error, no such shape found");
                    break;
            }
        }
    }
}