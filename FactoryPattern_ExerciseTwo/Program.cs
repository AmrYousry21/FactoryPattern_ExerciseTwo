namespace FactoryPattern_ExerciseTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of Database Connection ADO or Entity?");
            string input = Console.ReadLine();

            var result = Database.CreateDatabase(input);

            result.GetAccessType();
        }
    }
}