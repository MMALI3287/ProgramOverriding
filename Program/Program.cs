namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter real roll: ");
            var realRoll = Console.ReadLine();

            Console.WriteLine("Enter test roll: ");
            var testRoll = Console.ReadLine();

            Console.WriteLine("Real roll: " + realRoll + " and Test roll: " + testRoll);


            var overriding = new Overriding();
            overriding.ExploreOverRiding(realRoll!);



            var overRidingImplementation = new OverridingImplementation();
            overRidingImplementation.ImplementOverRiding(realRoll!, testRoll!);

            Console.ReadLine();
        }
    }
}
