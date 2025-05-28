namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("John", "1234", "gear", "standing");
            //commando.Walk();
            //commando.Hide();
            //commando.Attack();
            //Weapon weapon = new Weapon("Rifle", "Glok", 30);
            //weapon.Shoot();
            //Console.WriteLine($"Weapon: {weapon.name}, Manufacturer: {weapon.manufacturer}, Remaining bullets: {weapon.numberOfBalls}");           
            Console.WriteLine(commando.SayName("dvxf"));
            //commando.CodeName = "12345";
            //Console.WriteLine(commando.CodeName);

            //Commando commando1 = new Commando("Yinon", "85410", "gear", "standing");
            //Commando airCommando1 = new AirCommando("Neria", "85411", "parachute gear", "standing");
            //Commando seaCommando1 = new SeaCommando("Izak", "85412", "swimming gear", "standing");
            //commando1.Attack();
            //airCommando1.Attack();
            //seaCommando1.Attack();
            //    Array Soldiers = new Commando[3] {commando1, airCommando1, seaCommando1};
            //    foreach (Commando soldier in Soldiers)
            //    {
            //        soldier.Attack();
            //    }
        }
    }
}
