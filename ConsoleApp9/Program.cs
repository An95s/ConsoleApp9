namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
             for (int i=50;i<=70;i++)
            {
                int b = 0;
                b = i;
                do
                {
                    if (b % 2 == 0)
                    {
                        b = b / 2;

                    }
                    else
                    {
                        b = (b * 3 + 1) / 2;
                    }
                }
                while (b != 1);
                Console.WriteLine(b);
                

            }


        }
    }
}