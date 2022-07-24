using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.AZ_Project_CSharp
{
    public class WrongInputException : ApplicationException
    {

        public override string Message => $"Your input has not been identified by our system, Try again ...";
    }

    public class SystemCorruptionException : ApplicationException
    {
        public override string Message => $"System has been corrupted for a particular reason - Please start your operation again ...";
    }

    public class UsernameOrPasswordWrong : ApplicationException
    {
        public override string Message => $"Username or password has been entered incorrectly, try again ...";
    }

    public class NotFoundByEnteredIDException : ApplicationException
    {
        public override string Message => $"The data you are looking for with entered ID do not exist in this context - Try Again...";
    }

    public class NotFoundVacancyByIDException : ApplicationException
    {
        public override string Message => "The vacancy with your input ID has not been found in our database !!!";
    }

    public class NotFoundCVByIDException : ApplicationException
    {
        public override string Message => "The CV with your input ID has not been found in our database !!!";
    }

    public class NotFoundApplierByIDException : ApplicationException
    {
        public override string Message => "The Applier with your input ID has not been found in our database !!!";
    }

    public class CVMustBeFulfilledException : ApplicationException
    {
        public override string Message => "Dear user, you currently do not have any CV, for bid you first need to create one !!!";
    }
    class Helper
    {
        public static void ShowMenu()
        {
            Console.WriteLine("A D M I N    1");
            Console.WriteLine("U S E R      2");
        }

        public static void ShowAdminMenu()
        {
            Console.WriteLine("Place a new announcement      1");
            Console.WriteLine("Take a look at ads            2");
            Console.WriteLine("Observe appliers              3");
            Console.WriteLine("Look at Notifications         4");
        }

        public static void ShowUserMenu()
        {
            Console.WriteLine("Show Work Announcements         1");
            Console.WriteLine("Bid Add                         2");
            Console.WriteLine("Show CVs                        3");
            Console.WriteLine("Create new CV                   4");
            Console.WriteLine("Look at Notifications           5");
        }

        public static void ShowCategories(string[][] strings, string[]strings_2)
        {
            Console.WriteLine();
            for (int i = 0; i < strings.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine(strings_2[i]);Console.ResetColor();
                for (int k = 0; k < strings[i].Length; k++)
                {
                    Console.WriteLine(strings[i][k]);
                }
                Console.WriteLine();
            }
        }

        public static void ShowFilterMenu()
        {
            Console.WriteLine("By City           1");
            Console.WriteLine("By Salary         2");
            Console.WriteLine("By Age            3");
            Console.WriteLine("By Company        4");
            Console.WriteLine("\nSkip Filtering    0");
        }

        public static void ShowVacancies(List<Vacancy> vacancies)
        {
            foreach (var vacancy in vacancies)
            {
                vacancy.ShowVacancy();
            }
        }

        public static void FilterProcess()
        {
            var vacancies = Globals.dataBase.GetVacanciesList();
            Helper.ShowFilterMenu();
            string filter_choice = Console.ReadLine();

            if (filter_choice == "1")
            {
                Console.WriteLine("Enter city name: ");
                string city = Console.ReadLine();
                var selectedVacancies = vacancies.Where(c => c.City.StartsWith(city)).ToList();
                if (selectedVacancies.Count != 0)
                {
                    Console.Clear();
                    Helper.ShowVacancies(selectedVacancies);
                }
                else { Console.WriteLine("We could not find any result specific to your search"); }
            }
            else if (filter_choice == "2")
            {
                Console.WriteLine("Enter minimum salary: ");
                string min_salary = Console.ReadLine();
                Console.WriteLine("Enter maximum salary: ");
                string max_salary = Console.ReadLine();
                var selectedVacancies = vacancies.Where(c => Convert.ToInt32(c.MinSalary) >= Convert.ToInt32(min_salary) && Convert.ToInt32(c.MaxSalary) <= Convert.ToInt32(max_salary));
                Console.Clear();
                if (selectedVacancies.ToList().Count != 0)
                {
                    Console.Clear();
                    Helper.ShowVacancies(selectedVacancies.ToList());
                }
                else { Console.WriteLine("We could not find any result specific to your search"); }
            }

            else if (filter_choice == "3")
            {
                Console.WriteLine("Enter minimum age: ");
                string min_age = Console.ReadLine();
                Console.WriteLine("Enter maximum age: ");
                string max_age = Console.ReadLine();
                var selectedVacancies = vacancies.Where(c => Convert.ToInt32(c.MinAge) >= Convert.ToInt32(min_age) && Convert.ToInt32(c.MaxAge) <= Convert.ToInt32(max_age));
                Console.Clear();
                if (selectedVacancies.ToList().Count != 0)
                {
                    Console.Clear();
                    Helper.ShowVacancies(selectedVacancies.ToList());
                }
                else { Console.WriteLine("We could not find any result specific to your search"); }
            }

            else if (filter_choice == "4")
            {
                Console.WriteLine("Enter company name: ");
                string comp = Console.ReadLine();
                var selectedVacancies = vacancies.Where(c => c.CompanyName.StartsWith(comp)).ToList();
                if (selectedVacancies.Count != 0)
                {
                    Console.Clear();
                    Helper.ShowVacancies(selectedVacancies);
                }
                else { Console.WriteLine("We could not find any result specific to your search"); }
            }
            else if(filter_choice == "0")
            {
                Console.Clear();
                ShowVacancies(vacancies);
            }
        }
    }


}
