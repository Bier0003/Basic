using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Basic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //opgaver1+2
            int result = AddAndMultiply(2, 4, 5);
            Console.WriteLine(result);

            Console.WriteLine(AddAndMultiply(5, 6, 5));

            //opgaver3
            string result1 = CelToFah(2);
            Console.WriteLine(result1);


            //opgaver4
            Console.WriteLine("enter tempature?");
            string answer = Console.ReadLine();

            Console.WriteLine(CelToFa(Convert.ToInt32(answer)));

            //opgaver5-6
            Console.WriteLine("give me numbers 3,8");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());

            
            Console.WriteLine(Convert.ToInt32(a + b));
            Console.WriteLine(Convert.ToInt32(a - b));
            Console.WriteLine(Convert.ToInt32(a * b));
            if (a != 0 && b != 0)
            {
                Console.WriteLine(Convert.ToInt32(a / b));
            }
            else
            {
                Console.WriteLine("Can't devide by 0!");
            }
            //opgaver7

            Console.WriteLine("enter  2 number to make calculation +-*/ ");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal f = Convert.ToDecimal(Console.ReadLine());

            if (d==f)
            {
                Console.WriteLine("Re sults are the same");
            }
            else
            {
                Console.WriteLine(" Results are not the same");
            }


            //8 
            // opgaver9

          int result8 = MoDuLo(2, 4, 8);
            Console.WriteLine(result8);

            //opgaver10
            Console.WriteLine(CalMoDuLo(8,5,2));

            //opgaver11
            Console.WriteLine(TheCubeOf(5));

            //opgaver12
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5));

            //opgaver 13
            Console.WriteLine(swapsNum(2,3));
            // opgaver 14 
            Console.WriteLine(swapsNum(87,45));
            Console.WriteLine("Before a:"+ a+"b:"+b + "After a:"+ b+"b:"+a);
            Console.WriteLine(swapsNum(13, -2));
            Console.WriteLine("Before a:" + a + "b:" + b + "After a:" + b + "b:" + a);

        }

        //1-2
        public static int AddAndMultiply(int firstNumber, int secondNumber, int thirdNumber)
        {
            int output = 0;
            output = firstNumber + secondNumber;
            output = output * thirdNumber;
            return output;

        }
        //3
        static string CelToFah(float Celsius)
        {
            if (Celsius >= -271.15)
            {

                float output = (Celsius * 9) / 5 + 32;
                return output.ToString();
            }
            else
            {
                return "It dosen't exit!";
            }

        }
        //4
        static string CelToFa(float Cel)
        {
            if (Cel >= -300)
            {
                float Fah = (Cel * 9) / 5 + 32;
                return Fah.ToString();
            }
            else
            {
                return "Tempature below absolutely zero!";
            }
        }
            
            //6
        static string CheckResultSame(int a, int b)
        {
            if (a == b)
            {
            int Output = a = b;
            return Output.ToString("Same results");
                    
             }
             else 
             {
             return "Not same results";
             }
                
            
                
        }

        //7 finish





        //8
        
        

        //9
        static int MoDuLo(int FirstNum, int SecondNum, int ThirdNum)
        {
            int output8 = 0;
            output8 = FirstNum % SecondNum;
            output8 = output8 % ThirdNum;
            return output8;
        }
        //10
        static int CalMoDuLo( int First, int Second, int Third)
        {
            int output9 = 0;
            output9 = First - Second;
            output9 = Second - Third;
            return output9; 

        }
        //11-12
        static double TheCubeOf(double Num)
        {
             double output = Num * Num * Num;
            return  output;

        }

        //13
        static int swapsNum(int First, int Second)
        {
            int tem = First;
            First = Second;
            Second = tem;
            return tem;
        }
       



    }


}