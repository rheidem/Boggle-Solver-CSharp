using System;

namespace BoggleSolverCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions s = new Solutions();
            s.Add("dog");
            s.Add("fish");
            s.Add("cat");
            s.Add("crocodile");
            s.Print();
        }
    }
}
