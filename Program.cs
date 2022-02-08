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



            string[] colourOptions = {"red","red","blue","purple","green"};
            for(int i = 0; i < colourOptions.Length; i++){

            string paintColour = colourOptions[i];
            switch(paintColour){
                case "yellow":
                Console.WriteLine("Buy yellow paint");
                break;
                case "blue":
                Console.WriteLine("Buy blue paint");
                break;
                case "red":
                Console.WriteLine("Buy red paint");
                break;
                case "purple":
                Console.WriteLine("Buy purple paint");
                break;
                default:
                Console.WriteLine("Paint out of Stock");
                break;
            }
            }

            if(totalCost > 150){
                Console.WriteLine("Total cost before discount £" + totalCost);
                totalCost*=0.9;
                Console.WriteLine("10% discount applied: £" + totalCost);
                return;
            }else{
            Console.WriteLine("Total cost with no discount " + totalCost);
            return;
            }








            // int x = 5;
            // int y = 10;

            // if(x == y){
            //     Console.WriteLine(1);
            //     return;
            // }else if(x > y){
            //     Console.WriteLine(2);
            // }else{
            //     Console.WriteLine(3);
            // }

        }
    }
}