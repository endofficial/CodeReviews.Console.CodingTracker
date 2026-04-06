using CodingTracker.Data;
using CodingTracker.Controller;
using Dapper;
using Spectre.Console;

namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Register the TimeOnly type handler with Dapper
            SqlMapper.AddTypeHandler(new TimeOnlyTypeHandler()); 

            Database database = new();
            database.Initialize();

            RandomValues values = new RandomValues();
            values.ValueRandom();

            UserInterface ui = new();
            ui.MainMenu();
        }
    }
}
