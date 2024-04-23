using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Service
{
    public class AsyncMethods
    {
       

       
        
            List<Student> Students = new List<Student>();


            public async Task AddStudentAsync(Student student)
            {
                await Task.Delay(500);
                Students.Add(student);
                Console.WriteLine("Telebe elave olundu!");
            }
            public async Task AsyncShowStudentInfo()
            {
                foreach (var item in Students)
                {
                    await Task.Delay(500);

                    Console.WriteLine(item.Name + "  " + item.Surname + "  " + item.Grade + " " + item.StudentPoint);
                }


            }



            public async Task AsyncGetAllStudentsByPoint(int minPoint, int maxPoint)
            {
                foreach (var item in Students)
                {
                    if (item.StudentPoint > minPoint && item.StudentPoint < maxPoint)
                    {
                        await Task.Delay(500);
                        Console.WriteLine(item.Name + "  " + item.Surname + "  " + item.Grade + " " + item.StudentPoint);
                    }
                }

            }

            public async Task AsyncFindStudentById(int id)
            {


                var student = Students.Find(b => b.Id == id);
                if (student != null)
                {
                    await Task.Delay(500);
                    Console.WriteLine(student.Name + "  " + student.Surname + "  " + student.Grade + " " + student.StudentPoint);
                }
                else
                {
                    await Task.Delay(400);
                    Console.WriteLine("Telelbe tapilmadi");
                }
            }
        }
    }


