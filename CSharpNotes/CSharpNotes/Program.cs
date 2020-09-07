using System;
using static System.Console;
using System.Text;
using System.Linq;

namespace CSharpNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            Rectangle rect = new Rectangle(3,5);

            rect.Length = 2;
            rect.Width = 4;

            WriteLine(rect.CalculateArea());


            dynamic duo;
            duo = "Batman and Robin";

            #region Introduction to C#

            #region 0 INTRODUCTION----------------

            /*
                C# 
                    - like the "sharp" in musical notes developed by Microsoft
                    - one of the languages supported by common language infrastructure
                    - strongly and strictly-typed
                    - object-oriented (abstraction, encapsulation, inheritance, polymorphism)
                    - component-oriented (blocks of code are designed for independent trouble-shooting, separation of concerns, delegation of work)
                    - multi-paradigm (multiple approaches to coding is applicable)
                    event driven
                    - task driven (asynchronous compiling)
            */

            #endregion

            #region 1 VISUAL STUDIO----------------

            /*
                F12 - Go to Definition
    
                ctor - constructor
                prop - auto-implemented properties
                propfull - attributes and properties

            */



            #endregion

            #region 2 PROGRAM STRUCTURE----------------

            #region BASICS
            /*
                namespace 
                    - a way of grouping related classes together

                class 
                    - template for objects
                    - all members should be declared in a class

                static void Main (string[] args) 
                    - what the compiler looks for to start a program
                    - can be in any class but must be just one
                    - by declaring a static method, it automatically gets allocated a piece of memory 
            */
            #endregion

            #region IDE .NET Framework (Console)
            /*
                Solution Explorer (Console)
                    - gives you a structure of your current application

                        Solution
                            - may contain multiple projects inside

                        App.config
                            - XML file that contains metadata and helps make configurational changes with your application

                        References
                            - all related dll files used in your file
                            - referred in-file using the "using" preprocessor directive
            */
            #endregion

            #region IDE .NET Framework (GUI)
            /*
                Solution Explorer
                    - gives you a structure of your current application

                        Solution
                            - may contain multiple projects inside

                        Properties
                            - may contain multiple projects inside

                        References
                            - all related dll files used in your file
                            - referred in-file using the "using" preprocessor directive

                        App.config
                            - XML file that contains metadata and helps make configurational changes with your application

                        Form.cs
                            - has partial classes such as Form.cs, Form.Designer.cs and Form.resx

                        Program.cs
                            - has Main() that executes Application.Run(new Form())
                            - upon new Form() constructor is called in Program and defined in Form.cs, InitializeComponent() method is called and defined in Form.Designer.cs

                Properties
                    - properties for your controls

                Toolbox
                    - where you can get controls for your forms

            */
            #endregion

            #endregion

            #region 3 DATA TYPE----------------

            /*
                "Int32" (int object) vs "int" (data type)
                Employee t1 = new Employee(); (new keyword allocates memory in heap)

                VALUE vs REFERENCE

                    Primary Memory
                        * Stack - where values of value types are stored, and where pointers of reference types are stored (fixed memory upon assignment)
                        * Heap - where values of reference types are created for only during runtime 

                    Value
                        - Structs: byte | sbyte | short | ushort | int | uint | long | ulong | float | double | decimal | char | bool
                                   (8b)    (8b)   (16b)   (16b)   (32b)  (32b)  (64b)  (64b)   (32b)   (64b)    (128b)   (16b)   (8b) 
                        - enums: 

                        * const - cannot change after first assignment 

                    Reference
                        - string, array, object, class, interface, delegate


                PRIMITIVE vs NON-PRIMITIVE


                LITERAL vs VARIABLE


            */

            #endregion

            #region 4 TYPE CASTING----------------

            /*

                IMPLICIT
                    - done when working with smaller-memory to larger-memory data types

                    int a = 5;
                    double b = 3.2;
                    double c = a + b = 8.2;

                EXPLICIT
                    - done when working with larger-memory to smaller-memory data types
                    - larger-memory type loses value (for example, when double is used as an int because no more decimal values)
                    - has to be acknowledged

                    int a = 5;
                    double b = 3.2;
                    int c = a + (int) b = 8;

                BOXING
                    - when a value is copied from stack to heap

                    int a = 10;
                    object o = a; //o will be created in stack and 10 will created in heap, //object can store any type of data 

                UNBOXING
                    - when a value is copied from heap to stack

                    int b = (int) o; //b will be created in stack and will store the value of o at runtime, //if object o does not contain an int value, runtime will throw an exception


            */

            #endregion

            #region 5 NULL TYPE----------------

            /*
                Null
                    - when there is nothing inside
                    - only reference types can be null
                    - value types' default value is 0

                string s = null; //ok
                int a = null; //not ok
                int? a = null; //makes it ok 
                int b = a ?? 20; // if a is carrying a null value then 20, but if not then a

             */

            #endregion

            #region 6 OPERATIONS----------------

            #region BASICS
            /*
                Arithmetic + - * / % ++ -- += -= *= /=
                (pre-increment and post-increment matter during assignment)

                    Relational/Comparison == != > < >= <=
                (always returns boolean)

                Logical ! && || & | (double && and || do short-circuit evalution)
                (always returns boolean)

                Ternary Operators string s = (num % 2 == 0) ? "Even" : "Odd";

                string username = ReadLine();
                string password = ReadLine();
                string valid = (username=="sher" && password=="bdaynioyen") ? "ok" : "not ok";
            */
            #endregion

            #region OPERATOR OVERLOADING

            /*
                public static Length operator +(Length l1, Length l2)
                {
                    Length l3 = new Length();
                    l3.feet = l1.feet + l2.feet;
                    l3.inch = l1.inch + l2.inch;
                    if (l3.inch>=12)
                    {
                        l3.feet++;
                        l3.inch -= 12;
                    }
                    return l3;
                }
            */
            #endregion

            #endregion

            #region 7 CONTROL STATEMENTS----------------

            #region Simple
            /*

                int a = 5;

            */
            #endregion

            #region Selection (Conditional)

            #region IF, ELSE IF, ELSE
            /*

                if (  )
                {

                } else if (  )
                {

                } else
                {

                }

            */

            #endregion

            #region SWITCH

            /*

                switch (answer) // variable must contain a value type, and should be an equality operator
                {
                    'A':

                        break;
                    'B':

                        break;
                    default:

                        break;
                }

            */

            #endregion

            #endregion

            #region Iteration (Loop)

            #region WHILE
            /*

                while ()
                {
                    ;
                }

             */

            #endregion

            #region DO WHILE
            /*

                do
                {
                    ;
                } while ();

             */

            #endregion

            #region FOR
            /*

                for (int counter = 0; counter < length; counter++)
                {
                    ;
                }

             */
            #endregion

            #region FOREACH
            /*

                foreach (var a in varArray)
                {
                    ;
                }

             */

            #endregion

            #endregion

            #region Jump

            #region BREAK
            /*

                break - terminates the loop/switch (inner loop only if nested loop)

            */
            #endregion

            #region CONTINUE
            /*

                continue - forces the next iteration of the loop, skipping any code in between (inner loop only if nested loop)

            */
            #endregion

            #region GOTO
            /*

                goto - provides an unconditional jump from the goto to the labeled statement in the same function

                    int i = 1;
                abc:
                    WriteLine(i);
                    i++;
                    if (i<=10)
                        goto abc;

            */
            #endregion

            #region RETURN
            /*

                return

            */
            #endregion

            #endregion

            #endregion

            #region 8 ARRAYS----------------

            /*
                Arrays - used to store a collection of data and must be the same type
                         fixed-sized (may not be increased or decreased) upon size allocation
                         accessed by an index
             */

            #region SINGLE DIMENSION ARRAYS

            /*

                int[] intArray = new int[5]; //default values inside each index will be zero or null until initialized
                intArray[1] = 1;
                intArray[1] = 2;
                intArray[2] = 3;

                int[] intArray = new int[5]{1,2,3,4,5};

                int[] intArray = new int[]{1,2,3,4,5};

                int[] intArray = {1,2,3,4,5};


                string[] contents =
                {
                    "Hello there",
                    "This might not look like much but here is",
                    "My idea of a perfect Christmas"
                };

            */

            #endregion

            #region TWO DIMENSIONAL ARRAYS

            /*

                int[,] arr1 = new int[2,3] { {1,2,3},
                                             {1,2,3} };

            */

            #region CALORIE COUNTER
            /*

                int[,] calories = new int[7,3];
                int[] dailyTotal = new int[7];
                double[] dailyAverage = new double[7];

                for (int i = 0; i < calories.GetLength(0); i++)
                {
                    for (int j = 0; j < calories.GetLength(1); j++)
                    {
                        string input;
                        int value;
                        Write($"How much calories did you have for day {i+1} meal {j + 1}: ");
                        input = ReadLine();
                        while (int.TryParse(input, out value) == false)
                        {
                            Write("Please enter a valid number: ");
                            input = ReadLine();
                        }
                        calories[i, j] = value;
                        dailyTotal[i] += value;
                        dailyAverage[i] = (double)dailyTotal[i] / calories.GetLength(1);
                    }
                }

                for (int i = 0; i < calories.GetLength(0); i++)
                {
                    switch (i)
                    {
                        case 0:
                            WriteLine($"Monday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 1:
                            WriteLine($"Tuesday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 2:
                            WriteLine($"Wenesday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 3:
                            WriteLine($"Thursday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 4:
                            WriteLine($"Friday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 5:
                            WriteLine($"Saturday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                        case 6:
                            WriteLine($"Sunday: (Daily Total: {dailyTotal[i]}, Daily Average: {dailyAverage[i]})");
                            break;
                    }

                    for (int j = 0; j < calories.GetLength(1); j++)
                    {
                        switch (j)
                        {
                            case 0:
                                WriteLine($"Breakfast: {calories[i, j]}");
                                break;
                            case 1:
                                WriteLine($"Lunch: {calories[i, j]}");
                                break;
                            case 2:
                                WriteLine($"Dinner: {calories[i, j]}");
                                break;
                        }
                    }
                    WriteLine();
                }

                */
            #endregion

            #region MULTIPLICATION TABLE
            /*
                int[,] multiplicationTable = new int[10, 10];

                for (int i = 0; i < multiplicationTable.GetLength(0); i++)
                {
                    for (int j = 0; j < multiplicationTable.GetLength(1); j++)
                    {
                        multiplicationTable[i, j] = (i + 1) * (j + 1);
                    }
                }

                for (int i = 0; i < multiplicationTable.GetLength(0); i++)
                {
                    for (int j = 0; j < multiplicationTable.GetLength(1); j++)
                    {
                        Write(multiplicationTable[i, j] + "\t");
                    }
                    WriteLine();
                }
            */
            #endregion

            #endregion

            #region MULTI-DIMENSIONAL ARRAYS

            /*
                int[,,] arr1 = new int[2,2,3] { { {1,2,3},
                                                  {1,2,3} },
                                                { {1,2,3},
                                                  {1,2,3} } };

                int[,,] arr1 = new int[,,] { { {1,2,3},
                                                {1,2,3} },
                                                { {1,2,3},
                                                {1,2,3} } };
            */

            #endregion

            #region JAGGED ARRAYS

            /*
                int[][] arr = new int[3][];
                arr[0] = new int[3] {1,2,3};
                arr[1] = new int[2] {4,5};
                arr[2] = new int[4] {6,7,8,9};

            */

            #endregion

            #region STATIC METHODS
            /*
            
             */
            #endregion

            #region INSTANCE METHODS
            /*
            
             */
            #endregion

            #endregion

            #region 9 METHODS ----------------

            #region BASICS
            /*
                Methods - group of statements that together form a task
                    Method heading
                        Method signature - name and parameters for normal methods, but includes return types for delegates
                            Static/Instance - if class or object method
                            Return Type - void or data type (if data type, includes the return keyword)
                            Method name
                            Parameters - setting the pass-on values/references as method inputs
                                normal - value is passed
                                ref - reference is passed, has to be declared and assigned outside
                                out - reference is passed, has to be declared outside
                                params - only for arrays, means multiple number of items is accepted
                                named - can be declared not in order
                            Arguments - the actual data passed
                    Method body/definition - what will be executed

            */
            #endregion

            #region METHOD OVERLOADING

            /*
                - normally refers to overloading parameters aka creating new signatures, but in this case, rules can be set for polymorphism
             */

            #region IF NOTHING IS SET
            /*
                class Person
                {
                    public void Work();
                }
                class Employee: Person
                {
                    public new void Work();
                }

                class Program
                {
                    static void Main()
                    {
                        Person p1 = new Employee(); //this1
                        p1.Work(); //this2
                    }
                }

                //this1 is valid because Person (base type) can receive any value from Employee(derived type)
                //this2 will execute the Work() defined in Person class rather than the Employee which it was initialized with because it is bound to Person. At runtime, Employee couldn't power Person because it Person's signature did not allow it (has to be virtual or abstract)
            */
            #endregion

            #region NEW - ignores that there's already a parent method for this
            /*
                - not needed for Employee objects to use their own Work() but will clarify things for the compiler
            */
            #endregion

            #region OVERRIDE - child will make his own
            /*
                - Person object which was initialized as an Employee will now be able to use the Employee Work() method.
            */
            #endregion

            #region VIRTUAL - child may accept or make his own
            /*
                - allows the inheriting object to use or make their own same-name methods
            */
            #endregion

            #region ABSTRACT - forces the child to make his own
            /*
                - contracts the inheriting object to make their own definition of the same-name methods
            */
            #endregion

            #region SEALED
            /*
                - blocks the inheriting object to inherit the method
            */
            #endregion

            #endregion

            #region LAMBDA EXPRESSIONS
            /*
                - when the method is really small, to save memory/time, use a lambda expression

                int a = numPar => numPar * 100;

            */
            #endregion

            #endregion

            #region 10 STRING ----------------

            /*
             WriteLine($"I've got ${5:F2} in my pocket.");

             object.ToString();

             string s = "Jolli bee";
             s.ToUpper();
             s.ToLower();
             s.Replace(" ","")
             s.StartsWith("Jolli");
             s.StartsWith("E");
             s.Contains("ll");
             s.Equals("Jolli Bee", StringComparison.CurrentCultureIgnoreCase);
             s.IndexOf("i B", StringComparison.CurrentCultureIgnoreCase);
             s.LastIndexOf("l", 3, StringComparison.CurrentCultureIgnoreCase);
             s.Length;

             //concatenation
             string fullname = firstName + " " + lastName;
             string fullname = string.Concat(firstName," ",lastName);
             
             //from char
             char[] letters = {'H','e','l','l','o');
             string greetings = new string(letters);
             char[] ch = greetings.ToCharArray();

             //methods returning string
             string[] sarray = {"Hello,"from","Sher"};
             string message = String.Join("-",sarray);

             //formatting method to convert a value
             DateTime waiting = new DateTime(2012,10,10,17,58,1);
             string chat = String.Format("Message sent at {0:t} on {0:d}, waiting);

            //string builder
            string str = "Tutorials ";
            str = str+ "Point"; this doesn't only retain the original value in heap but instead creates a new one
            StringBuilder str = new StringBuilder("Tutorials ");
            str2.Append("Point");

            
             */

            #endregion

            #region 11 PREPROCESSOR DIRECTIVES----------------

            /*
                - tells the compiler what should be done before compilation
                - "using" references the libraries to be used in the program
                - #define - if define is present
                - #if - then this code will be executed
                - #else if - if not, and another one is defined instead, then this will
                - #else - if not, then this will
                - #region
                - #endregion
             
             */

            #endregion

            #region 12 OBJECT ORIENTED PROGRAMMING (OOPS)----------------

            /*
                - is a programming paradigm
                - describes the blueprint before implementation (much like creating an outline of what has to be done before starting, like listing down how to build a car and what parts vs buying the parts directly) (conceptual/logical design is done before allocation of memory through instantiation)
                - based on the concept of objects
                - objects may contain data and functionality
             */

            #region ENCAPSULATION
            /*
                - class should only contain relevant members (attributes, properties and methods)

            */

            #region DATA HIDING//SHADOWING
            /*
                - using the new keyword when method overloading so that it completely hides the base class method
             */

            #endregion

            #endregion

            #region ABSTRACTION
            /*
                - 

             */
            #endregion

            #region INHERITANCE
            /*
                - allows a base class to share its members with a derived class which allows reusability
                - when a derived class is lacking the required members, it takes from the base class
                - single inheritance
                - parent class constructs first. if no parent parameterized constructor, default constructor will be called. to call specific constructor, specify the base parameters
             */
            #endregion

            #region POLYMORPHISM
            /*
                - same name but different execution or "morphs" depending on context
             */

            #region CONSTRUCTOR OVERLOADING
            #endregion

            #region METHOD OVERLOADING
            #endregion

            #endregion

            #endregion

            #region 13 CLASSES AND OBJECTS----------------

            /*
                int marks; //object attribute
                static int maxMarks; //class attribute
            */

            #region CONSTRUCTORS

            #region DEFAULT - is the default if nothing is defined
            /*
                public class Rectangle()
                {
                    this.length = 5;
                }
            */
            #endregion

            #region PARAMETERIZED - will become the default if no default is defined
            /*
                public class Rectangle(int length)
                {
                    this.length = length;
                }

                Rectangle rect1 = new Rectangle(5);

            */
            #endregion

            #region COPY v1 - new object will be initialized with the same values with the copied object
            /*
                Rectangle rect2 = new Rectangle(rect1);
            */
            #endregion

            #region COPY v2 - new object will be pointing to the same thing as the copied object
            /*
                Rectangle rect2 = rect1;
            */
            #endregion

            #region STATIC - will be executed before the Main()
            /*
                static Rectangle()
                {
                    Rectangle.maxLength = 100;
                }

             */

            #endregion

            #region OBJECT INITIALIZER - same as named parameters
            /*
                Rectangle rect3 = new Rectangle{length=5};

                class Department
                {
                    Employee[] EmpList;

                    public Department()
                    {
                        EmpList = new Employee[3]
                        {
                            new Employee {Id=101, EmpName = "Alex"},
                            new Employee {Id=102, EmpName = "Dean"},
                            new Employee {Id=103, EmpName = "James"},
                        };
                    }
                }
            */
            #endregion

            #region BASE/DERIVED CLASS - to specify base class and derived class parameters at the same time
            /*
                class Child: Parent
                {
                    public Child(int intParameter) : base (intParameter)
                }

                order of construction:
                - derived static constructor
                - base static constructor
                - base instance constructor
                - derived instance constructor

            */
            #endregion

            #endregion

            #region ACCESS MODIFIERS
            /*
                private - within the class only
                protected - base class plus derived class
                internal - within project or assembly
                protected internal - within assembly and classes outside the assembly only derived from base class
                public - everywhere
            */
            #endregion

            #region ATTRIBUTES
            /*
                - a declarative tag used to pass information about the various elements at runtime depicted by square brackets placed above the element

                using System.Attributes;

                [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)] //limits attributes
                class SampleAttribute : Attributes
                {
                    public int Id {get; set}
                    public string Name {get; set}
                }

                [Sample(Id=10, Name="Tutorials")] //"Attribute" is optional
                class MyClass
                {
                    [Sample]
                    public int MyProperty {get; set;}
                    [Sample]
                    public void Method()
                    {

                    }
                }
            */
            #endregion

            #region PROPERTIES
            /*
                - a way to validate incoming attribute values
                - a way to set rules for getting and setting attribute values;

                private int amount;

                public int Amount
                {
                    get { return amount; }
                    set
                    {
                        if (value < 1000)
                        {
                            WriteLine("The amount should be 1000 or higher.");
                            return;
                        }
                        amount = value;
                    }
                }

            */
            #endregion

            #region INDEXERS
            /*
                - creating a get accessor that loops through each object to see if the parameter value matches the property value and returns the object. therefore, creating the this[parameter] acts as an indexer

                public Employee this[int id] //declared inside containing Department class
                {
                    get
                    {
                        foreach (Employee emp in EmpList)
                        {
                            if (id==emp.id)
                            {
                                return emp;
                            }
                        }
                        return null;
                    }
                }

                static void Main()
                {
                    WriteLine(employee[100].EmpName);
                }
            */
            #endregion

            #region ABSTRACT CLASS - forces children to make their own members
            #endregion

            #region INTERFACE - not a class, just a template. produces instance methods. almost like an entire abstraction
            /*
                
            */
            #endregion

            #region SEALED CLASS - cannot be a parent but can be a child
            #endregion

            #region PARTIAL CLASS - to divide the code into separate parts but will be treated as one during runtime
            #endregion

            #region GENERIC CLASS - allows the ambiguity of property data types, will be initialized upon construction
            /*
                class MyClass<P1, P2>
                {
                    public T1 MyProperty {get;set;}
                    public void MyMethod(T1 p1, T2 p2)
                    {
                        WriteLine(p1+" "+p2);
                    }
                }
                class Program
                {
                    static void Main()
                    {
                        MyClass<int, string> myObj = new MyClass<int, string>;
                        obj1.MyProperty = 10;
                        obj1.Method(10,"lalala");
                    }
                }
            */

            #endregion

            #endregion

            #region 14 STRUCT ----------------

            /*
                - behaves like a class but is structured as a value type instead of a reference type, therefore memory is allocated in the stack
                - not declared within a class but within the namespace

             */

            #endregion

            #region 15 ENUM ----------------

            /*
                - not declared within a class but within the namespace
                - contains constant list of values that may be int-able

                enum Gender
                {
                    Female, //=0 by default, can be changed
                    Male, //=1 by default, can be changed
                    Unkown //=2 by default, can be changed
                }

                class Human
                {
                    public Gender Gender {get;set;};
                }

                static void Main()
                {
                    Human h1 = new Human {Gender = Gender.Male}; // not 1
                    int sample = (int) h1.Gender;
                    WriteLine(sample);
                }
             */

            #endregion

            #region 16 DELEGATES----------------

            #region BASICS
            /*
                - behaves like a class but functions only as a storage of references to methods
                - not declared within a class but within the namespace

                - what for?
                    - EVENT HANDLERS
                        - for event-driven programming, events will not be able to carry the methods themselves. delegates will associate the method with the event 
                        - used for implementing events and callback methods
                    - MULTICAST DELEGATES
                        - it can hold the reference of multiple methods 

            */
            #endregion

            #region HOW IT WORKS
            /*
                - method signatures should be the same for declared delegate and method parameters 

                delegate int MyDel(int x, int y);
                class Program
                {
                    public static int Add(int x, int y)
                    {
                        return x+y;
                    }

                    public static int Multiply(int x, int y)
                    {
                        return x*y;
                    }

                    static void Main(string[] args)
                    {
                        MyDel del = new MyDel(Add); //stores Add as an argument to the method parameter. note that no () was used because no execution happened
                        int result = del(10,30); //knows to call on Add() method 
                        WriteLine(result); //writes 40

                        del = Multiply; //overwrites the Add method stored in the del reference
                        result = del(10,30); //calls on the Multiply method
                        WriteLine(result); //writes 300

                        del += Add; //multicasting
                        result = del(10,30);
                        WriteLine(result); //writes 40 but does not mean that Multiply was not executed. it just meant that result saved was the last method's but the first method was definitely executed. it just means that we have to make a few changes to the method definition (to act better lol) in order to make use of delegates' powers

                    }
                }
             */
            #endregion

            #region EVENTHANDLERS
            /*
                - EventHandler delegate return type must be void
                - all succeeding return types must be void
             */

            #region EASY EXAMPLE
            /*
                delegate void MyDel(object sender, EventArgs e);
                class Program
                {
                    public static void Add(int x, int y)
                    {
                        WriteLine(x+y);
                    }

                    public static void Multiply(int x, int y)
                    {
                        WriteLine(x+y);
                    }

                    static void Main(string[] args)
                    {
                        MyDel del = Add;
                        del += Multiply;
                        del(10,30); //executes both Add and Multiply and it is evident because WriteLine happens twice and no overwriting is happening
                    }
                }
                */
            #endregion

            #region EVENTHANDLER EXAMPLE
            /*
                delegate void EventHandler(object sender, EventArgs e);
                class Program
                {
                    public static void Add(int x, int y)
                    {
                        WriteLine(x+y);
                    }

                    public static void Multiply(int x, int y)
                    {
                        WriteLine(x+y);
                    }

                    static void Main(string[] args)
                    {

                    }
                }
                */
            #endregion

            #endregion

            #region ANONYMOUS FUNCTIONS
            /*
                - like EventHandler, this is a pre-set delegate signature that has set return types

                delegate void Del1();
                delegate int Del1(int a);

                class Program
                {
                    static void Main(string[] args)
                    {
                        Del1 a = delegate()
                        {
                            WriteLine("Hi");
                        }

                        Del2 b = delegate(int a)
                        {
                            return a*100;
                        }
                    }
                }

                ---


             */
            #endregion

            #region GENERIC DELEGATES (ACTION<>, FUNC<>, PREDICATE<>)
            /*
                - like EventHandler, this is a pre-set delegate signature that has set return types
                - Action<> returns void
                - Func<> returns any type via out
                - Predicate<> returns bool

                class Program
                {
                    public static void SampleMethod(string name)
                    {
                        WriteLine("Welcome " + name);
                    }

                    public static int Add(int x, int y)
                    {
                        return x*y;
                    }

                    public static bool Login(string uid)
                    {
                        if (uid == "sher")
                        {
                            return true;
                        } else
                        {
                            return false;
                        }
                    }
                    static void Main(string[] args)
                    {
                        Action<string> action = SampleMethod;
                        Func<int,int,int> func1 = Add;
                        Predicate<string> pred1 = Login;
                    }
                }
             */
            #endregion

            #region USING LAMBDA EXPRESSIONS
            /*
                - when the method is really small, to save memory/time, use a lambda expression

                delegate void Del(int x, int y);
                class Program
                {
                    static void Main(string[] args)
                    {
                        Del del = (x,y) =>
                        {
                            WriteLine(x*y);
                            WriteLine("Program ended...");
                        };
                        del(4,6);
                    }
                }

            */
            #endregion

            #endregion

            #region 17 GUI ----------------

            /*
             label
             textbox
             button
             checkbox
             radiobutton
             groupbox
             listbox
             combobox
             menustrip
             tabcontrol
             tooltip
             */

            #endregion

            #region 18 EXCEPTION HANDLING----------------

            #region BASICS
            /*
                - an application can run after successful compilation
                - "runtime" errors may be caused by lack of memory in the system, network error, internal issues
                - errors called "exceptions" will be "thrown"
                - program terminates abnormally as soon as it arises
                - we cannot avoid them but we can handle them
                - try catch, finally throws

                try
                {
                    int a = int.Parse(textboxA.Text);
                    int b = int.Parse(textboxB.Text);
                    int result = a/b;

                    if (b==0)
                    {
                        throw new DivideByZeroException();
                    }
                }
                catch (DivideByZeroException)
                {
                    labelC.Text = "Cannot divide by zero";
                }
                catch (FormatException)
                {
                    labelC.Text = "Please enter only non-decimal numbers";
                }
                catch (Exception ex)
                {
                    labelC.Text = ex.GetType() + " : " + ex.Message;
                }
                finally
                {
                    whether or not exceptions will be thrown or unhandled, this will be executed
                }

             */
            #endregion

            #region CUSTOM EXCEPTIONS
            /*
                - add a class
                - inherit from Exception (for Exception functionalities)
                - make your own message upon invoking
                - set string message as a parameter for both derived & base

                class MyCustomException : Exception
                {
                    public MyCustomException()
                    {

                    }
                    public MyCustomException(string message) : base(message)
                    {

                    }
                    public MyCustomException(string message, Exception innerException) : base(message, innerException)
                    {

                    }
                }

             */
            #endregion

            #endregion

            #region 19 REGULAR EXPRESSIONS ----------------

            /*
                - is a pattern that could be matched against an input text
                - a pattern consists of one or more character literals, operators, or constructs
                - .NET provides a regular expression engine that allows matching
                - System.Text.RegularExpressions provides Regex class which handles regular express tasks

                ^ starts with
                $ ends with
                [0-9a-zA-Z] possible characters
                {1,100} range
                ^[A-Za-z0-9]@[A-Za-z].[com|org|co|edu|]$

                public partial class Form1: Form
                {
                    private void button1_Click(object sender, EventArgs e)
                    {
                        Regex reg = new Regex(emailAddressTextbox.Text);
                        bool result = reg.IsMatch(confirmEmailAddressTextbox.Text);
                    }
                }

             */

            #endregion

            #region 20 COLLECTIONS ----------------
            /*
                - arrays that do not have a fixed size upon initialization 
             
                using System.Collections;
            */

            #region ArrayList
            /*
                - similar to array

                ArrayList list = new ArrayList();
                list.Add("One");
                list.Add("Two");
                list.Add("Three");
                list.Add("Four");
                list.Add("Five");

                foreach (object item in list)
                {
                    sampleListBox.Items.Add(item);
                }

                list.Remove("Three");
                list.RemoveAt(3);
                list.RemoveRange(3,1);
                list.Sort();
                list.Reverse();
                list.Count(); //array size
                list.Capacity(); //4 by default and doubles when exceeded
                list.TrimToSize(); //trims capacity to count size

             */
            #endregion

            #region Stack
            /*
                - LIFO

                Stack stack = new Stack();
                stack.Push("One");
                stack.Push("Two");
                stack.Push("Three");
                stack.Push("Four");
                stack.Push("Five");

                foreach (object item in stack)
                {
                    sampleListBox.Items.Add(item);
                }

                list.Pop();
                list.Peek();

             */
            #endregion

            #region Queue
            /*
                - FIFO

                Queue queue = new Queue();
                queue.Enqueue("One");
                queue.Enqueue("Two");
                queue.Enqueue("Three");
                queue.Enqueue("Four");
                queue.Enqueue("Five");

                foreach (var item in queue)
                {
                    sampleListBox.Items.Add(item);
                }

                list.Dequeue();
             */
            #endregion

            #region Hashtable
            /*
                - paired value (duplicate key not allowed)
                - key x dictionaryentry

                Hashtable ht;
                ht = new Hashtable();
                ht.Add("key 1", "value 1");
                ht.Add("key 2", "value 1");
                ht.Add("key 3", "value 1");
                ht.Add("key 4", "value 1");
                ht.Add("key 5", "value 1");
                ht.Add("key 6", "value 6");

                foreach (DictionaryEntry item in ht)
                {
                    listBox1.Items.Add(item.Key + " : " + item.Value);
                }

                ht[key 1];
                ht.Remove("key 1");
                ht.Contains("key 2");

             */
            #endregion

            #region SortedList
            /*
                - same as Hastable but keys will be sorted
             */
            #endregion

            #endregion

            #region 21 GENERIC COLLECTIONS ----------------
            /*
                - same as collections but typesafe
             
                using System.Collections.Generic;
            */

            #region List
            /*
                - similar to array

                List<int> list = new List<int>(5);
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);

                foreach (int item in list)
                {
                    sampleListBox.Items.Add(item);
                }

                list.RemoveAll();
                list.Remove(3);
                list.RemoveAt(3);
                list.RemoveRange(3,1);
                list.Sort();
                list.Reverse();
                list.Count(); //array size
                list.Capacity(); //4 by default and doubles when exceeded
                list.TrimToSize(); //trims capacity to count size

             */
            #endregion

            #region Stack
            /*
                - LIFO

                Stack<string> stack = new Stack<string>();
                stack.Push("One");
                stack.Push("Two");
                stack.Push("Three");
                stack.Push("Four");
                stack.Push("Five");

                foreach (object item in stack)
                {
                    sampleListBox.Items.Add(item);
                }

                list.Pop();
                list.Peek();

             */
            #endregion

            #region Queue
            /*
                - FIFO

                Queue<string> queue = new Queue<string>();
                queue.Enqueue("One");
                queue.Enqueue("Two");
                queue.Enqueue("Three");
                queue.Enqueue("Four");
                queue.Enqueue("Five");

                foreach (var item in queue)
                {
                    sampleListBox.Items.Add(item);
                }

                list.Dequeue();
             */
            #endregion

            #region Dictionary
            /*
                - paired value (duplicate key not allowed)
                - key x dictionaryentry

                Dictionary<int,string> dict;
                dict = new Dictionary();
                dict.Add(101, "value 1");
                dict.Add(102, "value 1");
                dict.Add(103, "value 1");
                dict.Add(104, "value 1");
                dict.Add(105, "value 1");
                dict.Add(106, "value 6");

                foreach (KeyValuePair<int, string> item in ht)
                {
                    listBox1.Items.Add(item.Key + " : " + item.Value);
                }

                dict[key 1];
                dict.Remove(101);
                dict.Contains(102);

             */
            #endregion

            #region SortedDictionary
            /*
                - same as Dictionary but keys will be sorted
             */
            #endregion

            #endregion

            #region 22 FILE HANDLING ----------------

            /*
                - store data permanently in secondary memory (text, plaintext, binary) and for debugging exceptions
                - File I/O
                - Streams (when a file is opened for reading or writing, it becomes a stream)
            */

            #region File
            /*
                - static class used for calling methods directly--that means you have to pass the location all the time

                using System.IO;

                File.Create(@"E:\data\sample.txt");
                File.Copy(@"E:\data\sample.txt",@"E:\data\temp\sample.txt");
                File.Move(@"E:\data\sample.txt",@"E:\data\temp\sample.txt");
                File.Move(@"E:\data\sample.txt",@"E:\data\renamed sample.txt");
                File.Delete(@"E:\data\sample.txt"); //will not be in recycle bin

            */
            #endregion

            #region FileInfo
            /*
                - instantiating this with the location as the parameter will allow you to call methods as instance methods directly without passing the location

                FileInfo file = new FileInfo(@"E:\data\sample.txt");

                file.Create();
                file.CopyTo(destination);
                file.MoveTo(destination);
                file.Delete();

            */
            #endregion

            #region StreamWriter
            /*

                FileInfo file = new FileInfo(@"E:\data\sample.txt");

                if (file.Exists)
                {
                    StreamWriter writer = file.CreateText();
                    writer.WriteLine(textBox1.Text);
                    writer.Close();
                }

            */
            #endregion

            #region StreamReader
            /*

                FileInfo file = new FileInfo(@"E:\data\sample.txt");

                if (file.Exists)
                {
                    StreamReader reader = file.OpenText();
                    string str = "";
                    while ((str = reader.ReadLine()) !=null)
                    {
                        textBox1.text += str;
                    }
                    reader.Close();
                }

            */
            #endregion

            #endregion

            #region 23 EXTENSION METHOD----------------

            /*
             
             */

            #endregion

            #region 24 ASSEMBLY ----------------

            /*
             
             */

            #endregion

            #region 25 REFLECTION ----------------

            /*
             
             */

            #endregion

            #region 26 MULTI-THREADING ----------------

            /*
             
             */

            #endregion

            #region 27 TASK PARALLEL LIBRARY ----------------

            /*
             
             */

            #endregion

            #region 28 ASYNCHRONOUS PROGRAMMING ----------------

            /*
             
             */

            #endregion

            #endregion

        }

    }

    abstract class Shape
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public abstract double CalculateArea();
    }

    class Rectangle:Shape
    {
        public Rectangle(double length, double width) : base(10,10)
        {

        }

        public override double CalculateArea()
        {
            return Length*Width;
        }
        public double CalculateParameter()
        {
            return this.Length + this.Width;
        }
    }

}
