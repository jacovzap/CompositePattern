# EJEMPLO UTILIZANDO EL PATRON DE DISEÑO ESTRUCTURAL COMPOSITE

### ENUNCIADO DEL PROBLEMA
##### Se tiene una empresa de desarrollo de software que utiliza metodologias agiles en el desarrollo de sus proyectos. Con este fin, la empresa necesita agupar a los empleados en varios equipos de desarrollo pertenecientes a la misma jerarquia, del mismo modo estos equipos pertenecen a una jerarquia mayor, la empresa. 
Al ser una empresa relativamente pequeña solo trabaja con un proyecto a la vez.
### SOLUCION AL PROBLEMA
Se utilizo el patron COMPOSITE que nos permite componer objetos en estructuras de arbol y trabajar con esas estructuras como si fueran individuales.
En el caso de la empresa, se tiene un unico Product Owner y un unico Scrum Master, estos representan hojas finales en el arbol empresa, sin embargo existen equipos de desarrollo que tienen detro de si mas empleados.
### DIAGRAMA UML


### MAIN
```
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
```
### RESULTADOS
Como resultado el programa imprime:
```
            -------- Product Owner ---------
            Nombre: Pablo
            Ci: 456789
            -------- ScrumMaster ---------
            Nombre: Rodrigo
            Ci: 45698
            -------- UXSpecialist ---------
            Nombre: Pepe
            Ci: 343233
            -------- DEVELOPER ---------
            Nombre: Pedro
            Ci: 666768
            -------- QA Engineer ---------
            Nombre: Rosa
            Ci: 887908
            -------- UXSpecialist ---------
            Nombre: Maria
            Ci: 345765
            -------- DEVELOPER ---------
            Nombre: Alejandra
            Ci: 590087
            -------- QA Engineer ---------
            Nombre: Kevin
            Ci: 124724
```