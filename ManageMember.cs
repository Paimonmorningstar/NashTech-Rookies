using System;
using System.Collections.Generic;
 
namespace day_1
{
    public class ManageMember
    {
        public static List<Member> listMember = new List<Member>();

        public static void ListMember()
        {
            listMember.Add(new Member
            {
                FirstName = "Loc",
                LastName = "Nguyen",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 1, 21),
                BirthPlace = "BacNinh",
                PhoneNumber = "0961564730",
                IsGraduated = false
            });

            listMember.Add(new Member
            {
                FirstName = "Hung",
                LastName = "Vu",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 8, 6),
                BirthPlace = "Lao Cai",
                PhoneNumber = "0345801331",
                IsGraduated = false
            });
            
            listMember.Add(new Member
            {
                FirstName = "Linh",
                LastName = "Nhat",
                Gender = "Female",
                DateOfBirth = new DateTime(2000, 7, 24),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0977652575",
                IsGraduated = true
            });
            
        }
        public static void FindMale()
        {
            foreach (Member member in listMember)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine(member.Show);
                }
            }
        }
        public static void FindOldest()
        {
            Member Oldest = listMember.ElementAt(0);
            foreach(Member member in listMember)
            {
                if(member.Age > Oldest.Age)
                {
                    Oldest = member;
                }
            }
            Console.WriteLine(Oldest.Show);
        }
        public static void FullName()
        {
            foreach(Member member in listMember)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }
        }

        public static void FindYear()
        {
            int key = 0;
            while(key != 4)
            {
                key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                    {
                        Console.WriteLine("List members born in 2000: ");
                        foreach(Member member in listMember)
                        {
                            if(member.DateOfBirth.Year == 2000)
                            {
                                Console.WriteLine(member);
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("List members born before 2000: ");
                        foreach(Member member in listMember)
                        {
                            if(member.DateOfBirth.Year < 2000)
                            {
                                Console.WriteLine(member.Show);
                            }
                        }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("List members born after 2000: ");
                        foreach(Member member in listMember)
                        {
                            if(member.DateOfBirth.Year > 2000)
                            {
                                Console.WriteLine(member.Show);
                            }
                        }
                        break;
                    }
                }
            }
        }
        public static void FindFirstPersonWasBornHaNoi()
        {
            int index = 0;
            while(true) 
            {
                if (index >= listMember.Count) break;
                var member = listMember[index];
                if (member.BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(member.Show);
                    break;
                }
                ++index;
            }
        }
    }
}