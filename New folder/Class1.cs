using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    interface iStudent
    {
        int StuID { get; set; }
        string StudName { get; set; }
        string StudGender { get; set; }
        int StudAge { get; set; }
        string StudClass { get; set; }
        float StudAvgMark { get; }
        void Print();

    }
    public class Student : iStudent
    {
        public List<Student> StudentList = new List<Student>();

        public int total, average = 0;
        public int StuID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }
        public void Print()
        {
            Console.WriteLine("Student Info");
            Console.WriteLine("Student ID: {0}, Student Name: {1}, Student Age: {2}, Student Class: {3}, Student Average Mark: {4}", StuID, StudName, StudGender, StudAge, StudClass, StudAvgMark);
        }
        int[] MarkList = new int[3];
        public int this[int i]
        {
            get { return MarkList[i]; }
            set { MarkList[i] = value; }
        }
        public void CalAvg()
        {

            for (int i = 0; i < MarkList.Length; i++)
            {
                total += MarkList[i];
            }
            StudAvgMark = total / MarkList.Length;
        }
        public void InsertStudent()
        {
            Student st = new Student();
            Console.Write("Input Student ID: ");
            st.StuID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Student Name: ");
            st.StudName = Convert.ToString(Console.ReadLine());
            Console.Write("Input Student Gender: ");
            st.StudGender = Convert.ToString(Console.ReadLine());
            Console.Write("Input Student Age: ");
            st.StudAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Student Class: ");
            st.StudClass = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < MarkList.Length; i++)
            {
                Console.WriteLine("Input Mark {0}", i + 1);
                MarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
            StudentList.Add(st);
        }
        public List<Student> getStudentList()
        {
            return StudentList;
        }
        public void SortByName()
        {
            StudentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.StudName.CompareTo(st2.StudName);
            });
        }
        public void SortByAvg()
        {
            StudentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.StudAvgMark.CompareTo(st2.StudAvgMark);
            });
        }
        public void SortByClass()
        {
            StudentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.StudClass.CompareTo(st2.StudClass);
            });
        }
        public List<Student> FindByName(String keyword1)
        {
            List<Student> searchResult1 = new List<Student>();
            if (StudentList != null && StudentList.Count > 0)
            {
                foreach (Student st in StudentList)
                {
                    if (st.StudName.ToUpper().Contains(keyword1.ToUpper()))
                    {
                        searchResult1.Add(st);
                    }
                }
            }
            return searchResult1;
        }
        public List<Student> FindByID(float keyword2)
        {
            List<Student> searchResult2 = new List<Student>();
            if (StudentList != null && StudentList.Count > 0)
            {
                foreach (Student st in StudentList)
                {
                    if (st.StuID == keyword2)
                    {
                        searchResult2.Add(st);
                    }
                }
            }
            return searchResult2;
        }
        public List<Student> FindByClass(string keyword3)
        {
            List<Student> searchResult3 = new List<Student>();
            if (StudentList != null && StudentList.Count > 0)
            {
                foreach (Student st in StudentList)
                {
                    if (st.StudClass.ToUpper().Contains(keyword3.ToUpper()))
                    {
                        searchResult3.Add(st);
                    }
                }
            }
            return searchResult3;
        }
    }
}


