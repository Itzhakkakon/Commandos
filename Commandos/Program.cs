namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("John", 123, "Rifle", "standing");
            commando.Walk();
            commando.Hide();
            commando.Attack();
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            weapon.Shoot();
            Console.WriteLine($"Weapon: {weapon.name}, Manufacturer: {weapon.manufacturer}, Remaining bullets: {weapon.numberOfBalls}");
        }
    }
}
