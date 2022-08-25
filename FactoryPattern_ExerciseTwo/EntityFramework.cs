namespace FactoryPattern_ExerciseTwo
{
    public class EntityFramework : IDataAccess
    {
        public void GetAccessType()
        {
            Console.WriteLine("Acessing DataBase using Entity Framework");
        }
    }
}