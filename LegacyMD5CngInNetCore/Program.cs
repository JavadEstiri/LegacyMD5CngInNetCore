namespace LegacyMD5CngInNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n\tEnter Any Text : ");
            string input = Console.ReadLine();

            var _mD5CngGenerator = new MD5CngGenerator();
            Console.WriteLine($"\n\tMD5Cng Result  : {_mD5CngGenerator.HashWithCngAlgorithm(input)}");
            Console.WriteLine($"\n\n\tThere Might Be Some '?' In Returned Hash . " +
                $"Its Because Im Using 'Encoding.Unicode'." +
                $"\n\tChange Encoding And Decoding As You Used To"
            );
            Console.ReadKey();
        }
    }
}
