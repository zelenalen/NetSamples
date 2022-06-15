namespace NetSamples.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    point[i, j] = new Point()
                    {
                        X = j,
                        Y = i
                    };
                }                
            }

            var swordsman = new Fighter()
            {
                Name = "Swordsman",
                Cost = 10,
                HealthPoint = 5,
                CurrentPosition = new Point { X = 3, Y = 4 }
            };

            var lancer = new Fighter()
            {
                Name = "Lancer",
                Cost = 15,
                HealthPoint = 5,
                CurrentPosition = new Point { X = 4, Y = 3 }
            };

            var archer = new Archer()
            {
                Name = "Archer",
                Cost = 25,
                HealthPoint = 2,
                ArrowsCount = 5,
                CurrentPosition = new Point { X = 9, Y = 9 }
            };

            var wizard = new FlyingWizard()
            {
                Name = "Wizard",
                Cost = 50,
                HealthPoint = 1,
                CurrentPosition = new Point { X = 0, Y = 9}
            };
            
            swordsman.Fight(point[5,4]);
            Console.WriteLine();

            lancer.Fight(point[7,3]);
            Console.WriteLine();

            archer.Move(point[9,0]);
            for (int i = 0; i < 7; i++)
            {
                archer.Fight(point[0,0]);
            }
            Console.WriteLine();

            wizard.Move(point[7, 7]);
            wizard.Fight(point[5,5]);
            Console.WriteLine();

            var units = new Unit[]
            {
                swordsman, lancer, archer, wizard
            };
            //PrintOverrideSample(units);
            //PrintHiddenMethodSample(units);

            //var unit = new Unit();

            //IMoveable someObject = new FarmWithWheels();

            var someNewArray = new IMoveable[]
            {
                new Fighter(),
                new Archer(),
                new FarmWithWheels(),
                new MasterFighter()
            };
        }

        static void MoveObjectsToPoint(IMoveable[] objectsWhichCanMove, Point point)
        {
            foreach (var obj in objectsWhichCanMove)
            {
                obj.Move(point);
            }
        }



        static void PrintOverrideSample(Unit[] units)
        {
            foreach (var unit in units)
            {
                unit.Move(new Point{X = 0, Y = 0});
                unit.Fight(new Point { X = 0, Y = 0 });
                Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void PrintHiddenMethodSample(Unit[] units)
        {
            var fighter1 = new Fighter
            {
                Name = "Knight",
                Cost = 10,
                HealthPoint = 10,
                CurrentPosition = new Point { X = 3, Y = 4 }
            };

            fighter1.Report();
            fighter1.Heal();
            fighter1.Report();

            (fighter1 as Unit).Heal();
            fighter1.Report();

            foreach (var unit in units)
            {
                unit.Report();
                unit.Heal();
                unit.Report();
            }
        }
    }
}