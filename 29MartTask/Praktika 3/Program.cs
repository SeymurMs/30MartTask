using System;

namespace Praktika_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string username;
            Console.WriteLine("Username Daxil edin :");
            username = Console.ReadLine();
            do
            {
                Console.WriteLine("Password Daxil edin:");
                password = Console.ReadLine();
            } while (!User.CheckPassword(password));

            int role;
            bool isNum;
            do
            {
                Console.WriteLine("1. Admin  2.Member");
                string roleStr = Console.ReadLine();
                isNum = int.TryParse(roleStr, out role);
            } while (!isNum || !Enum.IsDefined(typeof(Role),role));
            User user = new User(username, password, (Role)role);
            Department department = new Department(3);
            bool check = true;
            do
            {
                Console.WriteLine("Home\n");
                Console.WriteLine("1.Add Employee\n");
                Console.WriteLine("2. Get Employee\n");
                Console.WriteLine("3.Get All employee\n");
                Console.WriteLine("4.Quit\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (user.Role == Role.Admin )
                        {
                            Console.WriteLine("Name Daxil edin :");
                            string name = Console.ReadLine();


                            double salary;
                            bool isDouble;
                            do
                            {
                                Console.WriteLine("Maas daxil edin :");
                                string SalaryStr= Console.ReadLine();
                                isDouble = double.TryParse(SalaryStr, out salary);
                            } while (!isDouble);
                            Employee employee = new Employee(name, salary);

                            department.AddEmployee(employee);
                        }
                            else
                                Console.WriteLine("Admin deilsiniz");
                        break;
                        case "2":
                        int id;
                        bool isId;
                        do
                        {
                            Console.WriteLine("Axtarilan Idni daxil edin :");
                            string idStr = Console.ReadLine();
                            isId = int.TryParse(idStr, out id);
                        } while (!isId);
                        department.GetEmployeeById(id).ShowInfo();
                        break;
                    case "3":
                        foreach (var item in department.GetEmployees())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Bele bir emeliyyat yoxdur");
                        break;
                }
            } while (check);
        }
         
    }
}
