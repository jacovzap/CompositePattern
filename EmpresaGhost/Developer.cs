using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{
    class Developer : IEmployee
    {
         string Name { get; set; }
         int Ci { get; set; }

        public Developer(string Name, int Ci)
        {
            this.Name = Name;
            this.Ci = Ci;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("-------- DEVELOPER ---------");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Ci: {Ci}");
        }

    }
}
