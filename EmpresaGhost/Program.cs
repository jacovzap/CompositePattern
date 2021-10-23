using System;

namespace EmpresaGhost
{
    class Program
    {
        static void Main(string[] args)
        {
            /////CREAMOS EMPLEADOS UNICOS (HOJAS) COMO EL PRODUCT OWNER O EL SCRUM MASTER
            IEmployee ProductOwnerEmployee = new ProductOwner("Pablo", 456789);
            IEmployee ScrumMasterEmployee = new ScrumMaster("Rodrigo", 045698);

            //// CREAMOS UN CONTENEDOR DE EMPLEADOS (UN EQUIPO DE DESARROLLO), COMPUESTO DE VARIOS EMPLEADOS
            EmployeeContainer TeamOne = new EmployeeContainer();
            IEmployee UXSpecialistTeamOne = new UXSpecialist("Pepe", 343233);
            IEmployee DeveloperTeamOne = new Developer("Pedro", 666768);
            IEmployee QATeamOne = new QAEngineer("Rosa" ,887908);

            TeamOne.AddEmployee(UXSpecialistTeamOne);
            TeamOne.AddEmployee(DeveloperTeamOne);
            TeamOne.AddEmployee(QATeamOne);

            //// CREAMOS UN SEGUNDO CONTENEDOR DE EMPLEADOS (OTRO EQUIPO DE DESARROLLO), COMPUESTO DE VARIOS EMPLEADOS
            EmployeeContainer TeamTwo = new EmployeeContainer();
            IEmployee UXSpecialistTeamTwo = new UXSpecialist("Maria", 345765);
            IEmployee DeveloperTeamTwo = new Developer("Alejandra", 590087);
            IEmployee QATeamTwo = new QAEngineer("Kevin", 124724);

            TeamTwo.AddEmployee(UXSpecialistTeamTwo);
            TeamTwo.AddEmployee(DeveloperTeamTwo);
            TeamTwo.AddEmployee(QATeamTwo);

            // AÑADIMOS A TODOS LOS EMPLEADOS EN UNA LISTA GLOBAL DE LA EMPRESA
            EmployeeContainer GhostEnterpriseEmployees = new EmployeeContainer();

            GhostEnterpriseEmployees.AddEmployee(ProductOwnerEmployee);
            GhostEnterpriseEmployees.AddEmployee(ScrumMasterEmployee);
            GhostEnterpriseEmployees.AddEmployee(TeamOne);
            GhostEnterpriseEmployees.AddEmployee(TeamTwo);

            // MOSTRAMOS A TODOS LOS EMPLEADOS EN LA EMPRESA
            GhostEnterpriseEmployees.DisplayEmployee();
        }
    }
}
