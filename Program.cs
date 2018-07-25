using System;

namespace _7_24_comprehens
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            Employee[] employees = new Employee[2];
            Customer[] customers = new Customer[4];

            for(int i = 0, j = 0; i < 6; i++) 
            {
                if(i < 2) {
                    people[i] = new Employee();
                    employees[i] = (Employee) people[i];
                }
                else {
                    people[i] = new Customer();
                    customers[j] = (Customer) people[i];
                    j++;
                }
                people[i].Id = i;
            }

            customers[0].FirstName = "Jacob";
            customers[0].LastName = "Moodie";
            customers[0].DOB = new DateTime(1996, 05, 07);
            customers[0].Address = "1003 East JC Road";
            customers[0].City = "Onarga";
            customers[0].State = "IL";

            customers[1].FirstName = "Alice";
            customers[1].LastName = "Adams";
            customers[1].DOB = new DateTime(1997, 06, 08);
            customers[1].Address = "1 South Road";
            customers[1].City = "Pawnee";
            customers[1].State = "Ohio";

            customers[2].FirstName = "Barry";
            customers[2].LastName = "Barker";
            customers[2].DOB = new DateTime(1998, 07, 09);
            customers[2].Address = "2 West Drive";
            customers[2].City = "Quincy";
            customers[2].State = "New Hampshire";

            customers[3].FirstName = "Chris";
            customers[3].LastName = "Cherry";
            customers[3].DOB = new DateTime(1999, 08, 10);
            customers[3].Address = "3 North Plaza";
            customers[3].City = "Remington";
            customers[3].State = "Alaska";

            employees[1].FirstName = "Edward";
            employees[1].LastName = "Eldridge";
            employees[1].DOB = new DateTime(2001, 10, 12);
            employees[1].Department = "IT";
            employees[1].EmployeeId = 10;
            employees[1].DOJ = new DateTime(2010, 04, 04);
            
            employees[0].FirstName = "Donald";
            employees[0].LastName = "Dirks";
            employees[0].DOB = new DateTime(2000, 09, 11);
            employees[0].Department = "Marketing/Sales";
            employees[0].EmployeeId = 7;
            employees[0].DOJ = new DateTime(2018, 07, 23);

            Console.WriteLine("Unordered Listings: ");
            Console.WriteLine("\nAll of the people: ");
            printPeople(people);

            Console.WriteLine("\nAll of the employees: ");
            printPeople(employees);
            
            Console.WriteLine("\nAll of the customers: ");
            printPeople(customers);

            alphabetize(people);
            alphabetize(employees);
            alphabetize(customers);

            Console.WriteLine("\nAlphabetized Listings: ");
            Console.WriteLine("All of the people: ");
            printPeople(people);
            
            Console.WriteLine("\nAll of the customers: ");
            printPeople(customers);
            
            Console.WriteLine("\nAll of the employees: ");
            printPeople(employees);
        }
        
        static void printPeople(Person[] people)
        {
            foreach(Person person in people)
                Console.WriteLine(person.FirstName);
        }
        static void alphabetize(Person[] people) {
            for(int i = 0; i < people.Length - 1; i++) 
                for(int j = i + 1; j < people.Length; j++)
                    if(String.Compare(people[i].FirstName, people[j].FirstName) > 0)
                        people = Swap(people, i, j);
        }
        static Person[] Swap(Person[] people, int x, int y)
        {
            Person temp = people[x];
            people[x] = people[y];
            people[y] = temp;
            return people;
        }
    } 
}
