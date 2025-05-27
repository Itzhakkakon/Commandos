namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("John", 1234, "gear", "standing");
            commando.Walk();
            commando.Hide();
            commando.Attack();
            Weapon weapon = new Weapon("Rifle", "Glok", 30);
            weapon.Shoot();
            Console.WriteLine($"Weapon: {weapon.name}, Manufacturer: {weapon.manufacturer}, Remaining bullets: {weapon.numberOfBalls}");
            commando.SayName("COLONEL");
        }
    }
}
