using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{

    class QAEngineer : IEmployee
    {
        string Name { get; set; }
        int Ci { get; set; }

        public QAEngineer(string Name, int Ci)
        {
            this.Name = Name;
            this.Ci = Ci;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("-------- QA Engineer ---------");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Ci: {Ci}");
        }
    }
}
