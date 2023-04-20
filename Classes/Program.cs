namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Sienna";
            myCar.Year = 2018;
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);



            Car tesla = new Car()
            {
                Make = "Tesla",
                Model = "Model 3",
                Year = 2019
            };
            Console.WriteLine(tesla.Make);
            Console.WriteLine(tesla.Model);
            Console.WriteLine(tesla.Year);



            
            var Audi = new Car()
            {
                Make = "Audi",
                Model = "Q7",
                Year = 2022
            };
            Console.WriteLine(Audi.Make);
            Console.WriteLine(Audi.Model);
            Console.WriteLine(Audi.Year);

        }

        
    }
}
