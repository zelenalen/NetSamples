namespace NetSamples.Classes;

public class Company
{
    public Employee[] employees { get; set; }

    void Do()
    {
        employees = new Employee[]
        {
            //new Employee(),
            //new Employee(),
            //new Employee(),
            //new Employee(),
        };
    }

    //private = only inside class
    //protected => only inside class & inside inherited classes 
    //public => available in every place of program  

    //internal => 

    //private protected => only inside class & inside inherited classes 
    //protected internal
}