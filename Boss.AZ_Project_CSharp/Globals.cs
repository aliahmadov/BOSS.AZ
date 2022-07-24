using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.AZ_Project_CSharp
{
    class Globals
    {
        public static string[] specialities = new string[10] {"Finance","Marketing","IT/Programming Field","Sale","Desing","Law",
        "Education/Schooling","Engineering","Service","Medical"};
        public static string[][] categories = new string[10][]
        {
            new string[8]{"Credit Specialist","Insurance","Audit","Accountant","Finance Analysis","Bank Service","Cashier","Economist"},
            new string[4]{ "Marketing Management", "Corporate Communications","Advertising","Corporating"},
            new string[6]{"System Management","Database Control","IT Specialist/Advisor","Programming","IT Project Management","Hardware Specialist"},
            new string[2]{"Real Estate Agent","Sale Specialist"},
            new string[3]{"Web Design","Artist","Fashion Design"},
            new string[3]{"Advocate","Law Advisor","Crime Investigation"},
            new string[4]{"Tutor","Language Specialist","Special Education","Schooling"},
            new string[4]{"Agriculture","Automated Machinery Control","Engineering","Construction"},
            new string[9]{"WarehouseMan","Janitor","Restaurant Job","Driver","BabySitter","Laboring","Translator","Courier","Security Agent"},
            new string[2]{"Doctor","Medical Advisor"}
        };

        public static Worker worker1 = new Worker()
        {
            Name = "Ali",
            Surname = "Ahmadov",
            Age = 20,
            City = "Baku",
            Phone = "050-311-72-66",
            Username = "user",
            Password = "user"
        };

        public static Worker worker2 = new Worker()
        {
            Name = "Michael",
            Surname = "Schofield",
            Age = 20,
            City = "Sumqayit",
            Phone = "070-310-23-11",
            Username = "user1",
            Password = "user1"
        };

        public static Employer employer1 = new Employer()
        {
            Name = "John",
            Surname = "Wick",
            Age = 25,
            Phone = "050-432-45-32",
            City = "Baku",
            Username = "admin",
            Password = "admin",
        };


        public static Employer employer2 = new Employer()
        {
            Name = "Sara",
            Surname = "Tancredi",
            Age = 25,
            Phone = "070-432-58-32",
            City = "Baku",
            Username = "admin1",
            Password = "admin1",
        };

        public static CV worker1_CV = new CV()
        {
            School = "Zangi Liceum",
            Speciality = "Programmer",
            UniScore = "653",
            HasCertificate = true,
            BeginDate = new DateTime(2015, 1, 1),
            EndDate = new DateTime(2018, 5, 5)
        };

        public static Vacancy vacancy = new Vacancy()
        {
            AboutWork = $@"
    We are looking for an experienced Strategy Manager. You will work directly with C-suite level executives to ensure that daily objectives, reports, and metrics align directly with the company’s goals.

    Evaluate new business models and corporate relationships.
    Negotiate complex business models, partnerships, transactions, and other commercial agreements.
    Identify and target attainable opportunities in the market.
    Clearly define company goals and long-term strategy.
    Examine the profitability of each product, store location, and line of business in order to redirect resources.
    Utilize skills in project management to lead large teams in change processes.
    Develop methods for motivating and inspiring stakeholders.
    Leverage professional networks to attain critical resources.
    Provide training materials for process owners who need support.

",
            Requirements = $@"

    Experience in strategic planning and business analytics.
    Ability to lead, inspire and motivate teams.
    Strong presentation and negotiation skills.
    Excellent verbal and written communication in [X] language.
    [X] degree in Business Administration or relevant fields.
",
            City = "Baku",
            CompanyName = "Game Developer X",
            Education = "Bachelor, Master",
            Email = "aahmadov7626@ada.edu.az",
            MinAge = "20",
            MaxAge = "30",
            MinSalary = "2000",
            MaxSalary = "3500",
            Category = "Front End Developer",
            ExperienceDuration = "3",
            Phones = "050-311-11-11",
            Position = "Head Manager"

        };


        public static Vacancy vacancy1 = new Vacancy()
        {
            AboutWork = $@"
  Full Stack Developers are responsible for designing and developing websites and platforms. 
They work with design teams to ensure that user interactions on web pages are intuitive and engaging.
They also provide back-end functionality that can run smoothly from any device or browser type commonly used today.

",
            Requirements = $@"

    Managing the complete software development process from conception to deployment

    Maintaining and upgrading the software following deployment

    Managing the end-to-end life cycle for the production of software and applications

    Overseeing and guiding the analyzing, writing, building, and deployment of software 

    Overseeing the automated testing and providing feedback to management during the development process 

    Modifying and testing changes to previously developed programs
",
            City = "Ganja",
            CompanyName = "Google",
            Education = "Bachelor, Master",
            Email = "johnAbruzzi@gmail.com",
            MinAge = "20",
            MaxAge = "45",
            MinSalary = "1000",
            MaxSalary = "5500",
            Category = "Full stack Developer",
            ExperienceDuration = "3",
            Phones = "050-984-84-74",
            Position = "Junier Developer"

        };


        public static Vacancy vacancy2 = new Vacancy()
        {
            AboutWork = $@"
  An Accountant helps businesses make critical financial decisions by collecting, tracking, and correcting the company's finances. 
They are responsible for financial audits, reconciling bank statements, and 
ensuring financial records are accurate throughout the year.
",
            Requirements = $@"
Tracking payments to internal and external stakeholders

Preparing budget forecasts

Processing tax payments and returns
",
            City = "Sumqayit",
            CompanyName = "Rafiq Holding",
            Education = "Bachelor, Master",
            Email = "rafiq_ismayilov@gmail.com",
            MinAge = "25",
            MaxAge = "50",
            MinSalary = "3500",
            MaxSalary = "4254",
            Category = "Accountant",
            ExperienceDuration = "5",
            Phones = "099-785-75-63",
            Position = "Head Accountant"

        };

        public static Vacancy vacancy3 = new Vacancy()
        {
            AboutWork = $@"
  Business Analysts conduct market analyses, analysing both product lines and the overall profitability of the business.
In addition, they develop and monitor data quality metrics and ensure business data and reporting needs are met.
Strong technology, analytical and communication skills are must-have traits.

",
            Requirements = $@"

    Creating a detailed business analysis, outlining problems, opportunities and solutions for a business
    Budgeting and forecasting
    Planning and monitoring
    Financial modelling
    Variance Analysis
    Pricing
    Reporting
    Defining business requirements and reporting them back to stakeholders
",
            City = "Baku",
            CompanyName = "Qurban MMC",
            Education = "Bachelor, Master",
            Email = "qurban_qurbanov@gmail.com",
            MinAge = "25",
            MaxAge = "50",
            MinSalary = "560",
            MaxSalary = "1250",
            Category = "Business Analyst",
            ExperienceDuration = "3",
            Phones = "077-568-12-78",
            Position = "Team Manager"

        };

        public static Human human = new Human();

        public static DataBase dataBase = new DataBase();

    }

}
