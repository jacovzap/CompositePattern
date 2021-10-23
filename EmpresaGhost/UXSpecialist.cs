using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{
    class UXSpecialist : IEmployee
    {
        string Name { get; set; }
        int Ci { get; set; }

        public UXSpecialist(string Name, int Ci)
        {
            this.Name = Name;
            this.Ci = Ci;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("-------- UXSpecialist ---------");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Nombre: {Ci}");
        }
    }
}
