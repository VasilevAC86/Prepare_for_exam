using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepare_for_exam
{
    public class StudentCollection<T> where T : IStudent
    {
        private List<T> students_ = new List<T>();
        public void AddStudent(T student)
        {
            students_.Add(student);
        }
        public void RemoveStudent(T student)
        {
            students_.Remove(student);
        }
        public void PrintAllStudent()
        {
            foreach (var s in students_) 
                Console.WriteLine($"Имя: {s.Name}, возраст = {s.Age}, специальность: {s.Major}");
        }
        public T Yanger()
        {
            return students_.OrderBy(s => s.Age).First();
        }
        public T Older()
        {
            return students_.OrderByDescending(s => s.Age).First();
        }
        // Для варианта c IEnumerable
        public IEnumerable<T> Special(string str)
        {            
            return students_.Where(s => s.Major == str).ToList();
        }
        // Для варианта без IEnumerable
        /*public List<T> Special(string str)
        {
            return students_.Where(s => s.Major == str).ToList();
        }*/
    }
}
