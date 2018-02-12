namespace IT_1050_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("What is your first name?");
            string firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial?");
            string middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name?");
            string lastName = System.Console.ReadLine();
            string fullName = firstName + " " + middleInitial + " " + lastName;
            System.Console.Write("How tall are you in feet?");
            int heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How much taller are you in inches?");
            double heightInches = double.Parse(System.Console.ReadLine());
            double totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;
            System.Console.Write("How old are you?");
            int age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen?");
            bool isCitizen = System.Console.ReadLine().ToLower().StartsWith("y");
            bool canVote = isCitizen && age >= 18;

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.WriteLine(canVote);

        









        }
    }
}
