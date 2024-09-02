using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
namespace StudentRegistrationApplication
{
    class frmStudentRegistration
    {
        static void Main(string[] args)
        {
            while (true) // looping the program to run continuously
            {
                string greetings = ":>>>>) Welcome to STI (<<<<:";
                
                foreach (char letter in greetings)
                {
                    Console.Write(letter);
                    Thread.Sleep(100); //Types the statement with a 100 milliseconds interval
                }
                Console.Write("\n\nWould you like to enroll? (Yes or No): ");
                string askEnroll = Console.ReadLine().ToUpper();

                if (askEnroll == "YES")
                {
                    Console.Write("What is your budget range? (input a number in peso): ");
                    double askBduget = Convert.ToDouble(Console.ReadLine());
                    if (askBduget > 32000)
                    {
                        files();
                        FillUpForm();

                    }
                    else if (askBduget < 32000)
                    {
                        Console.WriteLine("I'm sorry, but you'll have to cover up an amount of greater than PHP32,000.00 if you want to proceed.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
                else if (askEnroll == "NO")
                {
                    Console.WriteLine("Thank you for your time.\nSTI is always open for you."); 
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            }
        }
        static void files()
        {
            string directorPath = @"C:\Users\Jungwon\OneDrive\Documents\Requirements";

            string[] filesToCheck = {
                            "GoodMoral.pdf",
                            "SHSDiploma.pdf",
                            "form137.pdf",
                            "PSA.pdf",
                            "MedicalCertificate.pdf",
                            "grades.xlsx"
                        };
            Console.WriteLine();
            foreach (string fileName in filesToCheck)
            {
                string filePath = Path.Combine(directorPath, fileName);
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"File {fileName} exists");
                    // note(for me :>) "$" is indicator to put a variable inside a statement w/ enclosing {}
   
                }
                else
                {
                    Console.WriteLine($"Filename {fileName} does not exist");
                    Console.WriteLine("Please fill in the requirements.");
                    string filesName = Console.ReadLine();
                    Console.ReadKey();
                }

            }
        }
        static void FillUpForm()
        {
            Console.WriteLine("\nThank you for complying. We will process the data right away within working hours.");
            Console.WriteLine("Please proceed on filling up this form:>");
            Console.Write("\nLast name: ");
            string lastName = Console.ReadLine();
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Suffix (if applicable): ");
            string suffixName = Console.ReadLine();

            Console.Write("Male or Female: ");
            string gender = Console.ReadLine();

            Console.Write("Date of Birth (dd/mm/yyyy): ");
            string birthDate = Console.ReadLine();

            Console.Write("[press enter to register]");
            Console.ReadLine();
            Console.WriteLine($"\nStudent Name: {firstName} {middleName} {lastName} {suffixName}");
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Date of Birth: " + birthDate);

            Console.WriteLine("\nWelcome STIer. You are now registered. \nPlease be updated for our further anouncements.");

            Console.ReadKey();

        }
    }
    
}//made by January Toribio Jr