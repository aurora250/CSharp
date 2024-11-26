using System;

namespace demo_105
{
    class Animal
    {
        public int legs = 4;
    }
    class Dog: Animal {  }

    delegate T Factory <out T>();   //协变，由派生类指定的委托，令编译器明白需要额外的继承关系
    delegate void ActionOn<in T>(T a);   //逆变

    interface Iinter<T>
    {
        T PrintArg(T arg);
    }

    //class Myclass<S>: Iinter<string>, Iinter<S>   不允许，S可能为int，会导致重复继承
    class MyClass: Iinter<string>, Iinter<int>  //接口的泛型在继承时确定了
    {
        public string PrintArg(string arg)
        {
            Console.WriteLine(arg);
            return arg;
        }
        public int PrintArg(int arg)
        {
            Console.WriteLine(arg);
            return arg;
        }
    }
    internal class Program
    {
        static Dog DogMaker()
        {
            return new Dog(); 
        }
        static void Action(Animal a)
        {
            Console.WriteLine(a.legs.ToString());
        }
        static void Main(string[] args)
        {
            MyClass c= new MyClass();
            c.PrintArg(1);
            c.PrintArg("hello ,there");

            Factory<Dog> dogmaker = DogMaker;
            //Factory<Animal> animalmaker = dogmaker;   //这里无法继承是因为此时Dog和Animal是平行被delegate派生的关系
            Factory<Animal> animalmaker = dogmaker;

            ActionOn<Animal> act = Action;
            ActionOn<Dog> dog = act;
            dog(new Dog());
        }
    }
}
