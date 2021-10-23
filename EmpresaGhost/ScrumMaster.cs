using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{
    class ScrumMaster : IEmployee
    {
        string Name { get; set; }
        int Ci { get; set; }

        public ScrumMaster(string Name, int Ci)
        {
            this.Name = Name;
            this.Ci = Ci;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("-------- ScrumMaster ---------");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Nombre: {Ci}");
        }
    }
}
