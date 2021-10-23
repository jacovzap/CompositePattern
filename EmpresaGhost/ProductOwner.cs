using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{

    class ProductOwner : IEmployee
    {
        string Name { get; set; }
        int Ci { get; set; }

        public ProductOwner(string Name, int Ci)
        {
            this.Name = Name;
            this.Ci = Ci;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("-------- Product Owner ---------");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Ci: {Ci}");
        }

    }
}
