namespace FactoryPatternVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires:");
            int tireCount = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Drive();
        }
    }
}