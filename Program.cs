using BSUIR_Lab_8_Task_4_5;
using BSUIR_Lab_8_Task_5;
using System.Linq;

// TASK 4
LINQInArray lINQArr = new LINQInArray(-10, 10);
lINQArr.StartTask();

//TASK 5
Console.Write("\n\n");

Company oil = new Company("Oil", new DateOnly(2020, 12, 10));
Company milka = new Company("Milka", new DateOnly(2010, 10, 6));
Company koin = new Company("Koin", new DateOnly(2012, 2, 24));
Company alphabet = new Company("alphabet", new DateOnly(2009, 3, 12));
Company motors = new Company("motors", new DateOnly(2011, 2, 24));
Company hp = new Company("HP", new DateOnly(2002, 7, 12));

List<Company> allCompanies = new List<Company>() { oil, milka, koin, alphabet, motors, hp };

Person<Company> alex = new Person<Company>("Alex", new DateOnly(1994, 10, 11), "software engineer", 1012.34, koin);
Person<Company> anna = new Person<Company>("Anna", new DateOnly(1993, 9, 10), "disigner", 1012.34, oil);
Person<Company> andrey = new Person<Company>("Andrey", new DateOnly(1992, 8, 9), "manual testing", 1012.34, milka);
Person<Company> kirill = new Person<Company>("Kirill", new DateOnly(1991, 7, 8), "test engineer", 1012.34, alphabet);
Person<Company> victoria = new Person<Company>("Victoria", new DateOnly(1990, 6, 7), "manager", 1012.34, milka);
Person<Company> liza = new Person<Company>("Liza", new DateOnly(1989, 5, 6), "boss)", 1012.34, koin);

List<Person<Company>> persons = new List<Person<Company>>() { alex, anna, andrey, kirill, victoria, liza };

//Task 5 Получите новую коллекцию, cписок компаний, в которых не работает ни одного сотрудника

//Коллекция всех компаний в которых работают сотрудники.
var companiesWorker = from p in persons
                      where p.company is not null
                      select p.company;
companiesWorker = companiesWorker.Distinct(); //удаление дубликатов.
//Cписок компаний, в которых не работает ни одного сотрудника
var companiesNotWorkers = allCompanies.Except(companiesWorker);

Console.WriteLine("Cписок компаний, в которых не работает ни одного сотрудника");
foreach (Company c in companiesNotWorkers)
{
    Console.WriteLine(c);
}
//Company: motors. Founding year: 24.02.2011
//Company: HP.Founding year: 12.07.2002
