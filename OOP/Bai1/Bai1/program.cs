using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai1
{
    class program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            while (true)
            {
                Console.WriteLine("Application Manager Officer");
                Console.WriteLine("Enter 1: To insert officer");
                Console.WriteLine("Enter 2: To search officer by name: ");
                Console.WriteLine("Enter 3: To show information officers");
                Console.WriteLine("Enter 4: To exit:");
                int choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter a: to insert Enginner");
                            Console.WriteLine("Enter b: to insert Worker");
                            Console.WriteLine("Enter c: to insert Staff");
                            string choose2 = Console.ReadLine();
                            switch (choose2)
                            {
                                case "a":
                                    {
                                        Console.WriteLine("Enter name: ");
                                        String name = Console.ReadLine();
                                        Console.WriteLine("Enter age:");
                                        int age = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter gender: ");
                                        String gender = Console.ReadLine();
                                        Console.WriteLine("Enter address: ");
                                        String address = Console.ReadLine();
                                        Console.WriteLine("Enter branch: ");
                                        String branch = Console.ReadLine();
                                        CanBo engineer = new KySu(name, age, gender, address, branch);
                                        qlcb.addOfficer(engineer);
                                        break;

                                    }
                                case "b":
                                    {
                                        Console.WriteLine("Enter name: ");
                                        String name = Console.ReadLine();
                                        Console.WriteLine("Enter age:");
                                        int age = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter gender: ");
                                        String gender = Console.ReadLine();
                                        Console.WriteLine("Enter address: ");
                                        String address = Console.ReadLine();
                                        Console.WriteLine("Enter level: ");
                                        int level = Int32.Parse(Console.ReadLine());
                                        CanBo worker = new CongNhan(name, age, gender, address, level);
                                        qlcb.addOfficer(worker);
                                        break;
                                    }
                                case "c":
                                    {
                                        Console.WriteLine("Enter name: ");
                                        String name = Console.ReadLine();
                                        Console.WriteLine("Enter age:");
                                        int age = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter gender: ");
                                        String gender = Console.ReadLine();
                                        Console.WriteLine("Enter address: ");
                                        String address = Console.ReadLine();
                                        Console.WriteLine("Enter task: ");
                                        String task = Console.ReadLine();
                                        CanBo staff = new NhanVien(name, age, gender, address, task);
                                        qlcb.addOfficer(staff);
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Invalid");
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter name to search: ");
                            String name = Console.ReadLine();
                            ArrayList a = new ArrayList();
                            a = qlcb.searchOfficerByName(name);
                            foreach (CanBo i in a)
                            {
                                Console.WriteLine(i.Name);
                            }
                            break;
                        }
                    case 3:
                        {
                            qlcb.showListInforOfficer();
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Invalid");
                        continue;
                }

            }
        }
    }
}
