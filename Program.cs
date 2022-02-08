// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace PainterList{
    class Program{
        static void Main (string[]args){
            // tins of paint
            double colourRed = 10.99;
            double colourBlue = 9.99;
            double colourPurple = 13.09;
            // paint colours required
            string coloursToBuy = "redx2,blue,purple";
            //cost of paint and labour
            double costOfPaint = colourRed * 2 + colourBlue + colourPurple;
            int numberOfTins = 4;
            double hoursTakenToComplete = 5.5;
            int labourCostPerhour = 30;
            double totalCost = labourCostPerhour * hoursTakenToComplete + costOfPaint;
            
            Console.WriteLine(coloursToBuy);
            Console.WriteLine(numberOfTins);
            Console.WriteLine(hoursTakenToComplete);
            Console.WriteLine(totalCost);



        }
    }
}