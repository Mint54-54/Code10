using System;


class Person
{
    public string Name;
    public int Age;
    internal string name;
    internal int age;

    public void Introduce()
    {
        System.Console.WriteLine($"Привет, мое имя {name}");
    }


    public Person( string name, int age)
    {
       name  = Name;
        age = Age;
    }

    public Person()
    {
    }

    public void Like()
    {
     Console.WriteLine($"имя {Name} , возраст {Age} ");   
    }
}
internal class Programing
{
    public static void Main()
    {
        Person peep = new Person();
        peep.name = "Ivan";
        peep.age = 50;

        Person peep2 = new Person();
        peep2.name = "2";
        peep2.age = 50;
        
        Person[] array = new Person[3];
        array[0] = peep;
        array[1] = peep2;


        System.Console.WriteLine(peep.name);
        System.Console.WriteLine(peep.age);

        peep.Introduce();
    }
}