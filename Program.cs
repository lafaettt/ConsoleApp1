namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region переменные
            //string q = "Дима";
            //char h = 'a';

            //int a = 1;
            //uint b = 2; //только +
            //double d = 3.5;

            //bool bools = true;

            //var name1 = "Дима";

            //// + - * /  //  %
            //#endregion

            //#region условия
            //if (a < 0)
            //{
            //    Console.WriteLine("А меньше 0");
            //}
            //else if (a > 0)
            //{
            //    Console.WriteLine("А больше 0");
            //}
            //else
            //{
            //    Console.WriteLine("А равно 0");
            //}
            //#endregion

            //#region цикл
            //while (b < 10)
            //{
            //    Console.WriteLine(b);
            //    b++;
            //}
            #endregion

            Random r = new Random();
            int number = r.Next(101);


            while (true)
            {

                Console.WriteLine("Угадай число");
                int log = int.Parse(Console.ReadLine());


                if (log == number)
                {
                    Console.WriteLine("Угадал!");
                    break;
                }
                else if (log < number)
                {
                    Console.WriteLine("больше");
                }
                else
                {
                    Console.WriteLine("меньше");
                }



            }
        }
    }
}