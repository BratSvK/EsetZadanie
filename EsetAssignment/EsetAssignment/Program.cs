using EsetAssignment.Helpers;

namespace EsetAssignment;

public static class Program
{
       

    public static void Main(string[] args)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        // the code that you want to measure comes here
        System.Console.WriteLine("Ahoj, program začal");

        var a = TransformHelper.Transform(43858);

        System.Console.WriteLine(a);
            
        watch.Stop();
        System.Console.WriteLine($"Time elapsed {watch.ElapsedMilliseconds}");
    }
}
