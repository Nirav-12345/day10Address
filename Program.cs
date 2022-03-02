using System;

namespace EmpUC10;

class Program
{
    public static void Main(string[] args)
    {
        EmpBui Build = new EmpBui();
        Build.U10C("Dmart", 2, 3, 4,0);
        Build.computeEmpWage();
    }
}