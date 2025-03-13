using Demos_OOP.Session04.Binding;

namespace Session04C__OOP
{
    internal class Session04
    {

   
        #region Overloding
        public static int Sum(int x, int y)
        { return x + y; }

        public static int sum(int x, int y, int z)
        { return x + y + z; }

        public static double Sum(double x, double y)
        { return x + y; }

        public static double Sum(int x, double y)
        { return x + y; }


        #endregion


        #region  Part11: When Binding Happens 
        //public static void ProcessEmployee(FullTimeEmployee employee)
        //{
        //    if( employee is not null )
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }

        //}

        public static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType(); // Static Polymorphism 
                employee.GetEmployeeData(); // Dynamic Polymorphism
            }

        }

        #endregion


       


        static void Main(string[] args)
        {
           
            #region Part02 : Polymerphism 
            /// Many Forms - Many Shapes 
            /// 1. Overloading  --> Multiple Forms Of Parameters in ( Functions - Methods - Constructors ) Have The Same Logic but Different Behavior .
            /// 2. Override -->   its Multiple Forms Of ( Methods ) , but it Requires " Inheritance ".


            /// Type of Polymorphism :
            /// 1. Static Polymorphism | Compile-time polymorphism  -->( method Overloading -  Operations Overloading - Indexer Overloading - Method Hiding )  
            /// 2. Dynamic Polymorphism | Run-time Polymorphism  -- > ( Method Overriding ) 


            #endregion

            #region part03 : [Method  Overloading ]
            //// Overloading Type :
            //// 1. Constructor Overloading
            //// 2. Indexer Overloading
            //// 3. Method Overloading
            //// 4. Operator Overloading
            //// 5. Casting Operator Overloading 

            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);//3


            #endregion

            #region Part04 : Operators Overloading [ binary Operators ]
            //// Syntax 
            //// public static Return type operator symbol(parameters)
            ////  {
            ////      //custom implementation
            ////  }


            //Complex C1 = new Complex();
            //C1.Real = 10;
            //C1.Img = 5;
            //Console.WriteLine(value: $"C1 : {C1}");

            //Complex C2 = new Complex();
            //C2.Real = 20;
            //C2.Img = 8;
            //Console.WriteLine(value: $"C2 : {C2}");

            //Complex? C3 = default;
            //C3 = C1 + C2;// valid
            ////= 
            //C3 += C1;
            //Console.WriteLine($"C3 :{C3}");

            #endregion

            #region Part05 : Operators Overloading [ Unary Operators ]
            //Complex C1 = new Complex();
            //C1.Real = 10;
            //C1.Img = 5;
            //Console.WriteLine(value: $"C1 : {C1}");

            //Complex? C3 = default;
            //C3 = ++C1;
            //Console.WriteLine($"C3 :{C3}");
            //Console.WriteLine($"C1 : {C1}");
            #endregion

            #region Part06 : Operators Overloading [ Realtoinal Operators ]
            //Complex C1 = new Complex();
            //C1.Real = 10;
            //C1.Img = 5;

            //Complex C2 = new Complex();
            //C2.Real = 20;
            //C2.Img = 8;

            //if (C1 > C2)
            //    Console.WriteLine($" C1 > C2");
            //else if (C1 < C2)
            //    Console.WriteLine($" C1<C2");
            //else 
            //    Console.WriteLine($" C1 = C2 ");


            #endregion

            #region Part06 : Operators Overloading [ Casting Operators Overloading ]
            //// Syntax
            //// public static [ Explicit | Implicit ] operator operator ( parameters)
            //// { Custom  implementation
            //Complex C1 = new Complex()
            //{
            //    Real = 1,
            //    Img = 2

            //};

            //int x = (int)C1; // (int ) => Casting operator
            //                 // valid after  casting operator overloading 

            //string str =(string) C1;

            #endregion

            #region Part07 : Casting Operators Overloading 

            //Complex C1 = new Complex() {  Real = 1  , Img=3};
            //int X = (int)C1;// (int) Casting Operator
            //                // Valid After Casting Operator Overloading 

            //string str = C1;


            #endregion

            #region Part08 : User Defined Casting Operator Overloading 

            //User userObj = new User()
            //{
            //    Id = 10,
            //    FullName = "Adel",
            //    Email = "AdelNasr@Gmail.com",
            //    Password = "Paskdla",
            //    SecuirtyStamp = Guid.NewGuid(),
            //};

            //UserViewModel userViewModel = (UserViewModel)userObj;
            ////(UserViewModel) => Casting Operator 
            //// Manual Mapping [User => UserViewModel]
            //// Model => ViewModel 
            //// ViewModel => Model
            #endregion

            #region Part09 :  Overriding 

            ////Supported With Class Only
            //// Function Overriding Must be with Relationship [ Inheritance ]

            //TypeA type = new TypeA(3);
            //type.MyFun01();
            //type.MyFun02();

            //TypeB type01 = new TypeB(3, 4);
            //type01.MyFun01();  // Static Polymorphism[ Compile-Time] -> Calling function Base On Reference Type 
            //type01.MyFun02(); // Dynamic Polymorphism  =>[ Runtime ] -> Calling Function Based on Object Type




            #endregion

            #region Part10 : Binding 
            //TypeA RefBase= new TypeB(1,2);
            //// Binding : Reference From Base Refer  To An Object From Child 
            //RefBase.A = 1;
            //// RefBase.B = 20; //Invalid 

            //RefBase.MyFun01();  // Static Polymorphism - Static Binding - Early Binding [ Compilation Time]
            //                    // This is MyFun01 From Base --> I Am  Base                   
            //                    // MyFun01() Method Non Virtual  , Override Using "New"
            //                    // Resolve At Compile Time Based On Reference Type 

            //RefBase.MyFun02();  // Dynamic Polymorphism - Dynamic Binding - Date Binding [ run-Time ]
            //                    // This is MyFun02 From TypeB --> A=1 , B=2
            //                    // MyFun02(0 Method Virtual Override Using " Override "
            //                    //Resolve At Run_Time Based On Object Type 


            #endregion

            #region Part11: When Binding Happens 

            //FullTimeEmployee fulltimeEmployeeObj = new FullTimeEmployee(1, "Adel", 25, 20000);
            //ProcessEmployee(fulltimeEmployeeObj);


            //PartTimeEmployee parttimeEmployeeObj = new PartTimeEmployee(1, "Adel", 25, 250, 250);
            //ProcessEmployee(parttimeEmployeeObj);

            #endregion

       

            
        }
    }
}
