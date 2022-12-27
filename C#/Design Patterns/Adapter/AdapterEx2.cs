using System;
namespace AdapterExample
{
    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }

    // Adaptee
    public class MeatsDatabase
    {
        public float GetSafeCookingTemperature(string meat)
        {
            return meat.ToLower() switch
            {
                "fish" or "rabbit" => 145f,
                "chicken" or "turkey" => 165f,
                _ => 165f,
            };
        }

        public int GetCaloriesPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "fish" => 71,
                "rabbit" => 69,
                "chicken" => 66,
                "turkey" => 38,
                _ => 0,
            };
        }

        public double GetProteinPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "fish" => 7.33f,
                "rabbit" => 7.67f,
                "chicken" => 8.57f,
                "turkey" => 8.5f,
                _ => 0f,
            };
        }
    }

    // Target
    public class Meats
    {
        protected string MeatName;
        protected double SafeCookingTemperatureFahrenheit;
        protected double SafeCookingTemperatureCelsius;
        protected double CaloriesPerOunce;
        protected double CaloriesPerGram;
        protected double ProteinPerOunce;
        protected double ProteinPerGram;

        public Meats(string meatName) 
        { 
            this.MeatName = meatName;
        }

        public virtual void LoadData()
        {
            Console.WriteLine($"\nMeat: {MeatName} ------");
        }
    }
    
    // Adapter
    public class MeatDetails : Meats
    {
        private MeatsDatabase meatsDatabase;

        public MeatDetails(string name) : base(name)
        {
        }

        public override void LoadData()
        {
            meatsDatabase = new MeatsDatabase();
            SafeCookingTemperatureFahrenheit = meatsDatabase.GetSafeCookingTemperature(MeatName);
            SafeCookingTemperatureCelsius = FahrenheitToCelsius(SafeCookingTemperatureFahrenheit);
            CaloriesPerOunce = meatsDatabase.GetCaloriesPerOunce(MeatName);
            CaloriesPerGram = PoundsToGrams(CaloriesPerOunce);
            ProteinPerOunce = meatsDatabase.GetProteinPerOunce(MeatName);
            ProteinPerGram = PoundsToGrams(ProteinPerOunce);

            base.LoadData();
            Console.WriteLine($" Safe Cooking Temperature (Fahrenheit): {SafeCookingTemperatureFahrenheit}");
            Console.WriteLine($" Safe Cooking Temperature (Celcius): {SafeCookingTemperatureCelsius}");
            Console.WriteLine($" Calories per Ounce: {CaloriesPerOunce}");
            Console.WriteLine($" Calories per Gram: {CaloriesPerGram}");
            Console.WriteLine($" Protein per Ounce: {ProteinPerOunce}");
            Console.WriteLine($" Protein per Gram: {ProteinPerGram}");
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.55555;
        }

        private double PoundsToGrams(double pounds)
        {
            return pounds * 0.0283 / 1000;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Target
            Meats unknown = new Meats("Fish");
            unknown.LoadData();

            // Adapted
            MeatDetails fish = new MeatDetails("Fish");
            fish.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();
        }
    }
}