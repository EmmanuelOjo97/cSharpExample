// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// what do we want?
// a paint calculator.
// how many areas are painting? what colour are we painting
// what do we need?
// dimensions of area, number of paint cans, paint colours 
// price of paint
// are we painting doors, walls, windows etc?
// hours to paint based on information provided.
//



namespace PainterList{
    class Program{
        static void Main (string[]args){
            // tins of paint
            double colourRed = 10.99;
            double colourBlue = 9.99;
            double colourPurple = 13.09;
            double colourYellow = 12.09;
            // paint colours required
            string coloursToBuy = "redx2,blue,purple";
            //cost of paint and labour
            double costOfPaint = colourRed * 2 + colourBlue + colourPurple;
            int numberOfTins = 4;
            double hoursTakenToComplete = 5.5;
            int callOutFee = 30;
            double totalCost = callOutFee ;
            // double totalCoster = callOutFee;
            //

            // double areaHeight = Convert.ToDouble(Console.ReadLine());
            // double areaWidth = Convert.ToDouble(Console.ReadLine());
            //
            Console.WriteLine(coloursToBuy);
            Console.WriteLine(numberOfTins);
            Console.WriteLine(hoursTakenToComplete);
            
            Console.WriteLine("How many areas do you want to paint?");
            int numberOfAreasToPaint = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("you have chosen " + numberOfAreasToPaint + " of areas to paint");



            Console.WriteLine("How many colours do you want?");
            int howManyColours = Convert.ToInt32(Console.In.ReadLine());
            string[] answer = new string[howManyColours];
            for(int i = 0; i < answer.Length; i++){
                answer[i]= Console.ReadLine();
            }
            Console.WriteLine("You have chosen " + answer.Length + " colours");
            Console.WriteLine(answer[0]);


            double totalSquareMeter = 0;
            // Console.WriteLine("Enter height in meters")
            for(int i = 1; i <= numberOfAreasToPaint; i++){
                        Console.WriteLine("Enter height in meters");
            double areaHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width in meters");
            double areaWidth = Convert.ToDouble(Console.ReadLine());
            double totalArea = areaHeight * areaWidth;
            Console.WriteLine("total area of "+ i + " "+ totalArea + " meters squared");
            totalSquareMeter = totalSquareMeter + totalArea ;
            }

            Console.WriteLine("The total square meters is " + totalSquareMeter + "m2");


            // string[] colourOptions = {"red","red","blue","purple","green"};
            double costOfMaterials = 0;
            for(int i = 0; i < answer.Length; i++){
            string paintColour = answer[i];
            switch(paintColour){
                case "yellow":
                Console.WriteLine("Buy yellow paint");
                costOfMaterials+=colourYellow;
                break;
                case "blue":
                Console.WriteLine("Buy blue paint");
                costOfMaterials+=colourBlue;
                break;
                case "red":
                Console.WriteLine("Buy red paint");
                costOfMaterials+=colourRed;
                break;
                case "purple":
                Console.WriteLine("Buy purple paint");
                costOfMaterials+=colourPurple;
                break;
                default:
                Console.WriteLine("Paint out of Stock");
                break;
            }
            }
            totalCost = Math.Round(totalCost + 15 * totalSquareMeter,2);
            Console.WriteLine("Call out fee plus cost per square meter is £" + totalCost );
            Console.WriteLine("Total cost of materials £" + costOfMaterials);

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