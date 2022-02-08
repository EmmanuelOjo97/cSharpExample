// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace PainterList{
    class Program{
        static void Main (string[]args){
            double colourRed = 10.99;
            double colourBlue = 9.99;
            double colourPurple = 13.09;
            string coloursToBuy = "redx2,blue,purple";
            int numberOfTins = 4;
            double hoursTakenToComplete = 5.5;
            Console.WriteLine(coloursToBuy);
            Console.WriteLine(colourRed*2 + colourBlue + colourPurple );
            Console.WriteLine(numberOfTins);
            Console.WriteLine(hoursTakenToComplete);
            double nice = Math.Abs(-30.9);
            Console.WriteLine(nice);
        }
    }
}