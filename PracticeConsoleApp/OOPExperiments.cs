using PracticeConsoleApp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class OOPExperiments
    {
        public void ArgumentPassByValue(string abc)
        {
            abc = "Changed Value";
        }
        public void ArgumentPassByReference(out string abc)
        {
            abc = "Changed Value";
        }
        public void ArgumentPassByValue(int abc)
        {
            abc = -1;
        }
        public void ArgumentPassByReference(out int abc)
        {
            abc = -1;
        }
        public void ArgumentPassByValue(Person abc)
        {
            abc.Age = -1;
            abc.Name = "Changed Name";
        }
    }
    
    public class ExecutingOOPExperiments
    {
        public void ArgumentPassByValueAndPassByRef()
        {
            OOPExperiments oop = new OOPExperiments();
            string str = "Original Value";
            oop.ArgumentPassByValue(str);
            Console.WriteLine(str);

            int num = 10;

            oop.ArgumentPassByValue(num);

            Console.WriteLine(num);
            Console.WriteLine("-----------------------------------");
            oop.ArgumentPassByReference(out str);
            Console.WriteLine(str);
            oop.ArgumentPassByReference(out num);
            Console.WriteLine(num);
            Console.WriteLine("-----------------------------------");
            Person person = new Person() { Name = "Original Name", Age = 20 };
            oop.ArgumentPassByValue(person);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}

/*
 
 When ref/out actually matters for reference types

Use them when I want to replace the caller’s variable with a new object (or ensure assignment):

void ReassignWithoutRef(Person p)
{
    // New reference assigned to parameter only
    p = new Person { Name = "New Inside", Age = 99 }; // caller not updated
}

void ReassignWithRef(ref Person p)
{
    // Replace caller’s variable
    p = new Person { Name = "New Inside", Age = 99 }; // caller sees it
}

void ProduceWithOut(out Person p)
{
    p = new Person { Name = "Created Inside", Age = 42 }; // must assign before return
}
 
 
 */