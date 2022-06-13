namespace NetSample.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee()
            {
                Id = 100,
                Name = "Vasya Pupkin"
            };
            emp.DoWork();

            var doctor = new Doctor()
            {
                Id = 200,
                Name = "Doctor Aybolit",
                Specialization = "Veterinarian"
            };
            doctor.DoWork();
            doctor.Heal(emp);

            var pathologist = new Pathologist()
            {
                Id = 13,
                Name = "Arthas",
                Specialization = "Necromancer"
            };

            pathologist.DoWork();
            pathologist.Heal(emp);

            pathologist.CheckEmployee(doctor);

            var miner = new Miner()
            {
                Id = 10000,
                Name = "Miner"
            };

            Employee pathologist2 = new Pathologist();
            Employee doctor2 = new Doctor();
            
            //var doctor2AsPathologist = (Pathologist)doctor2;
            Console.WriteLine(Environment.NewLine); //c.wl-> \n \n

            var employees = new[] { emp, doctor, pathologist };

            PrintEmployeesData(employees);
       
        }

        static void PrintEmployeesData(Employee[] employees)
        {
            foreach (var employee in employees)
            {
                PrintInfo(employee);
            }
        }

        //is & as
        static void PrintInfo(Employee employee)
        {
            //if (employee is Doctor)
            //{
            //    var doctor = (Doctor)employee;
            //    Console.WriteLine($"{doctor.Id}-{doctor.Name}-{doctor.Specialization}");
            //}
            //if (employee is Doctor)
            //{
            //    var doctor = employee as Doctor;
            //    Console.WriteLine($"{doctor?.Id}-{doctor?.Name}-{doctor?.Specialization}");
            //}
            //else
            //{
            //    Console.WriteLine($"{employee.Id}-{employee.Name}");
            //}
            var doctor = employee as Doctor;
            Console.WriteLine($"{doctor?.Id}-{doctor?.Name}-{doctor?.Specialization}");
        }
    }
}