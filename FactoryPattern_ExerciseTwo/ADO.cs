namespace FactoryPattern_ExerciseTwo
{
    public class ADO : IDataAccess
    {
        public void GetAccessType()
        {
            Console.WriteLine("Acessing database using ADO.NET");
        }
    }
}