using System;

namespace ClassPeople
{
    public class People
    {
        private string name = null;
        public People() { }
        public People(string strName)
        {
            name = strName;
        }
        public void Say()
        {
            if (name == null)
            {
                Console.WriteLine("hi~~");
            }
            Console.WriteLine("hi" + name);
        }
    }
    public class Man
    {
        void Eat() { Console.WriteLine("EAT"); }
    }
}
