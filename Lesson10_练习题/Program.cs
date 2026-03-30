using System;
using System.Runtime.Intrinsics;

namespace Lesson10_练习题
{
    class Person1
    {
        public int x1;
        public int y1;
        public static bool operator ==(Person1 i11, Person2 i22)
        {
            return i11.x1 == i22.x2 && i11.y1 == i22.y2;
        }
        public static bool operator !=(Person1 i11, Person2 i22)
        {
            return i11.x1 == i22.x2 && i11.y1 == i22.y2;
        }
    }
    class Person2
    {
        public int x2;
        public int y2;
    }


    class Vector3
    {
        public int x1;
        public int y1;
        public int z1;
        public static Vector3 operator + (Vector3 v1, Vector3 v2)
        {
            Vector3 vector3 = new Vector3();
            vector3.x1 = v1.x1 + v2.x1;
            vector3.y1 = v1.y1 + v2.y1;
            vector3.z1 = v1.z1 + v2.z1;
            return vector3;
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 vector3 = new Vector3();
            vector3.x1 = v1.x1 - v2.x1;
            vector3.y1 = v1.y1 - v2.y1;
            vector3.z1 = v1.z1 - v2.z1;
            return vector3;
        }
        public static Vector3 operator *(Vector3 v1, int num)
        {
            Vector3 vector3 = new Vector3();
            vector3.x1 = v1.x1 * num;
            vector3.y1 = v1.y1 * num;
            vector3.z1 = v1.z1 * num;
            return vector3;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("封装_运算符重载");
            #region 问题1

            //定义一个位置结构体或类，为其重载判断是否相等的运算符
            //(x1, y1） == (x2, y2)   =>    两个值同时相等才为true

            Person1 person1 = new Person1();
            person1.x1 = 1;
            person1.y1 = 2;
            Person2 person2 = new Person2();
            person2.x2 = 1;
            person2.y2 = 2;
            Console.WriteLine(person1 == person2);


            #endregion


            #region 问题2
            //定义一个Vector3类（x,y,z）通过重载运算符实现以下运算
            //(x1, y1, z1) + (x2, y2, z2) = (x1 + x2, y1 + y2, z1 + z2)
            //(x1, y1, z1) - (x2, y2, z2) = (x1 - x2, y1 - y2, z1 - z2)
            //(x1, y1, z1) * num = (x1 * num, y1 * num, z1 * num)

            Vector3 v = new Vector3();
            v.x1 = 1;
            v.y1 = 2;
            v.z1 = 3;
            Vector3 v2 = new Vector3();
            v2.x1 = 4;
            v2.y1 = 5;
            v2.z1 = 6;
            Vector3 vector3 = v-v2;

            Console.WriteLine(vector3.z1);




            #endregion




















        }
    }
}
