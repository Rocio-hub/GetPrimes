// See https://aka.ms/new-console-template for more information
using CompulsoryAssignment;
using System.Management;

PrimeGenerator generator = new PrimeGenerator();

ManagementObjectSearcher mos =
  new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
foreach (ManagementObject mo in mos.Get())
{
    Console.Write("RUNNING ON: ");
    Console.Write(mo["Name"]);
    Console.WriteLine("");
}

//3) Compare the performance of both methods for various ranges, like:

//a.
Console.WriteLine("\na. 1 – 1.000.000");
Console.Write("\n Total time in sequential:\t");
generator.performanceMeasurer(() => generator.GetPrimesSequential(1, 1000000));
Console.Write("\n Total time parallel:\t\t");
generator.performanceMeasurer(() => generator.GetPrimesParallel(1, 1000000));

//b.
Console.WriteLine("\nb. 1 – 10.000.000");
Console.Write("\n Total time in sequential:\t");
generator.performanceMeasurer(() => generator.GetPrimesSequential(1, 10000000));
Console.Write("\n Total time parallel:\t\t");
generator.performanceMeasurer(() => generator.GetPrimesParallel(1, 10000000));
//c.
Console.WriteLine("\nc. 1.000.000 – 2.000.000");
Console.Write("\n Total time in sequential:\t");
generator.performanceMeasurer(() => generator.GetPrimesSequential(1000000, 2000000));
Console.Write("\n Total time parallel:\t\t");
generator.performanceMeasurer(() => generator.GetPrimesParallel(1000000, 2000000));
//d.
Console.WriteLine("\nd. 10.000.000 – 20.000.000");
Console.Write("\n Total time in sequential:\t");
generator.performanceMeasurer(() => generator.GetPrimesSequential(10000000, 20000000));
Console.Write("\n Total time parallel:\t\t");
generator.performanceMeasurer(() => generator.GetPrimesParallel(10000000, 20000000));

Console.ReadKey();



