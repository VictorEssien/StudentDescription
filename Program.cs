using System.Globalization;

namespace StudentDescription
{
    class Program
    {
        static void Main(string[] args)
        {

            int StudentId = 0;

            string? firstName = String.Empty;

            string? lastName = String.Empty;

            string? major = String.Empty;

            char gender = '\0';

            bool Graduated = false;


            Console.WriteLine("Please enter a unique student Id");
            StudentId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the student's first name: ");
            firstName = Console.ReadLine();


            Console.WriteLine("Please enter the student's last name: ");
            lastName = Console.ReadLine();


            Console.WriteLine("Please enter the student's major: ");
            major = Console.ReadLine();


            Console.WriteLine("Please enter the student's gender; ('f'= female, 'm'= male");
            gender = Convert.ToChar(value: Console.ReadLine());


            Console.WriteLine("Has this student graduated (true / false) ?");
            Graduated = Convert.ToBoolean(Console.ReadLine());

            var GradInfo = String.Empty;

            if (Graduated != true)
            {
                Console.WriteLine("What year is the student (freshman, sophmore, junior or senior)?");
                GradInfo += $"is currently a {Console.ReadLine()}";
            }

            else
            {
                Console.WriteLine("What date did the student graduate (MM/DD/YYYY)?");
                var GetDate = Console.ReadLine();

                DateTime UserDate = DateTime.ParseExact(GetDate, "d", DateTimeFormatInfo.InvariantInfo);
                var GradDate = UserDate.ToString("d");

                GradInfo += $"graduated on {GradDate}";
            }


            var genderInfo = (gender == 'f') ? "female" : "male";

            var description = $"The student with ID number {StudentId} is a {genderInfo} student ";
            description += $"named {firstName} {lastName}, and majored in {major}. \n\n";
            description += $"This student {GradInfo}";

            Console.Clear();

            Console.WriteLine(description);

            Console.ReadKey();

        }
    }
}
