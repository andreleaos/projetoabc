namespace ConsoleAppExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploDeLooping();
        }

        static void ExemploDeLooping()
        {
            Console.WriteLine("Exemplo de Looping");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1).ToString());
            }
        }
    }
}