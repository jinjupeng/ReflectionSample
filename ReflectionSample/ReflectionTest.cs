using System;
using System.Reflection;

namespace ReflectionSample
{
    class ReflectionTest
    {
        /*
        static void Main(string[] args)
        {
            Type people = null;
            //注意：执行这句代码时要将ClassPeople.dll复制到Debug目录下，这样才能找到这个文件
            Assembly ass = Assembly.LoadFrom("ClassPeople.dll");
            Type[] mytypes = ass.GetTypes();
            Console.WriteLine("列出程序集中的所有类型");
            foreach (Type t in mytypes)
            {
                Console.WriteLine(t.Name);
                if (t.Name == "People")
                {
                    people = t;
                }
            }
            Console.WriteLine("列出People类中的方法：");
            MethodInfo[] methodInfo = people.GetMethods();
            foreach (MethodInfo mi in methodInfo)
            {
                Console.WriteLine(mi.Name);
            }
            //实例化People，并调用Say方法
            Object obj = Activator.CreateInstance(people);
            Object objName = Activator.CreateInstance(people, "kobe");
            MethodInfo minfo = people.GetMethod("Say");
            Console.WriteLine("调用Say方法");
            minfo.Invoke(obj, null);
            minfo.Invoke(objName, null);
            Console.ReadLine();
        }
        */
    }

}
