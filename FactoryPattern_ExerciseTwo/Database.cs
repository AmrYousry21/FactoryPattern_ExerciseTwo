namespace FactoryPattern_ExerciseTwo
{
    public static class Database 
    {
        public static IDataAccess CreateDatabase(string input) 
        {
            switch (input.ToLower()) 
            {
                case "ado":
                    return new ADO();
                    break;
                case "entity":
                    return new EntityFramework();
                    break;
                default:
                    return new ADO();
            }
        }
    }
}