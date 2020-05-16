using System;

namespace TreePrinterToConsole
{
    class Program
    {
        static void PrintTreeWithAlignment(char[] tree)
        {
            var size = tree.Length;
            while (size > 0)
            {
                size = size / 2;
                printSpace(0, size - 1);
                Console.Write(tree[size]);
                for (int i = size + 1; i < tree.Length;)
                {
                    if (i + 2 * size < tree.Length)
                    {
                        printSpace(i, i + 2 * size);
                        i = i + 2 * size + 1;
                        if (i < tree.Length)
                        {
                            Console.Write(tree[i]);
                            i++;
                        }
                    }
                    else
                    {
                        printSpace(i, tree.Length - 1);
                        break;
                    }
                }
                Console.WriteLine();
            }
        }



        private static void printSpace(int lowerIndex, int upperIndex)
        {
            for (int i = lowerIndex; i <= upperIndex; i++)
            {
                Console.Write(" ");
            }
        }


        static void Main(String[] args)
        {
            /*
             * 
             * 
            1.
                | |a| | 
                |b| |c|
            2.

            | | | |a| | | |
            | |b| | | |c| |
            |d| |e| |f| |g|

            */

            //Sample run
            char[] treeInputZeroElement = new char[] { };
            char[] treeInputOneElement = new char[] { 'a' };
            char[] treeInputTwoElement = new char[] { 'a', 'b' };
            char[] treeInputThreeelement = new char[] { 'b', 'a', 'c' };
            char[] treeInputSevenElement = new char[] { 'd', 'b', 'e', 'a', 'f', 'c', 'g' };


            char[] treeInputThreeelementWithskewness = new char[] { '\0', 'a', 'c' };  // similar to {'', 'a', 'c'}
            char[] treeInputSevenElementWithSkewness = new char[] { 'd', 'b', '\0', 'a', '\0', 'c', 'g' }; // similar to {'d','b','','a', '','c','g'}
                                                                                                           //Sample Run
            Console.WriteLine("Sample run test cases");
            Console.WriteLine("1.zero element:=> similar to {}");
            PrintTreeWithAlignment(treeInputZeroElement);
            Console.WriteLine("1.one element:=> similar to {'a'}");
            PrintTreeWithAlignment(treeInputOneElement);
            Console.WriteLine("1.two elements:=> similar to { 'a','b'}");
            PrintTreeWithAlignment(treeInputTwoElement);
            Console.WriteLine("1.three elements:=> similar to { 'b', 'a', 'c'}");
            PrintTreeWithAlignment(treeInputThreeelement);
            Console.WriteLine("1.seven elements:=> similar to { 'd','b', 'e','a','f', 'c' ,'g'}");
            PrintTreeWithAlignment(treeInputSevenElement);
            Console.WriteLine("1.three  elements with one missing(skewed) element:=>similar to {'', 'a', 'c'}");
            PrintTreeWithAlignment(treeInputThreeelementWithskewness);
            Console.WriteLine("1.seven  elements wtih two missing(skewed) elements=>  similar to {'d','b','','a', '','c','g'}");
            PrintTreeWithAlignment(treeInputSevenElementWithSkewness);

            Console.ReadKey();
        }
    }
}
