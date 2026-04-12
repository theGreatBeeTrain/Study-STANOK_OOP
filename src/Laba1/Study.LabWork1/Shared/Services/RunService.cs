using System.Diagnostics.Metrics;
using Study.LabWork1.Shared.Abstractions;
using Study.LabWork1.Features;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
///

public class RunService : IRunService
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public void RunTask1() => throw new NotImplementedException();
    
    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3()
    {
        Tree t1 = new Tree(1);
        t1.print();
        Console.WriteLine("================================");
        List<double> l1 = new List<double> { 1, 2, 3, 4 };
        Tree t2 = new Tree(312, 4, l1);
        t2.print();
        Console.WriteLine("================================");

        List<Tree> l2 = new List<Tree> { t1, t2, (Tree)3.0, (Tree)4 };
        Tree t3 = new Tree(12, 4, l2);
        t3.print();
        Console.WriteLine("================================");

        List<Tree> l3 = new List<Tree> { t2, t2, (Tree)3.0, t3 };
        Tree t4 = new Tree(99999, 4, l3);
        t4.print();
        Console.WriteLine("================================");

    }
}
