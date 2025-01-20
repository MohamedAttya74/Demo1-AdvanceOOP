namespace Demo1_AdvanceOOP
{
      class Program
    {
        static void Main(string[] args)
        {

            #region Generic SWAP Example01 
            /// object  A = 5 ,  B = 10;   
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// Helper.SWAP/*<int>*/(ref A,ref B );
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");

            /// double K = 3.3, L = 4.4;
            /// Console.WriteLine($"K = {K}");
            /// Console.WriteLine($"L = {L}");
            /// Helper.SWAP /*<double>*/ (ref  K , ref  L);
            /// Console.WriteLine($"K = {K}");
            /// Console.WriteLine($"L = {L}");


            /// Point P01 = new Point(10, 20);
            /// Point P02 = new Point(50, 60);
            /// Console.WriteLine($"P01={P01}");
            /// Console.WriteLine($"P02={P02}");
            /// Helper.SWAP /*<Point>*/(ref P02, ref P01);
            /// Console.WriteLine($"P01={P01}");
            /// Console.WriteLine($"P02={P02}");


            #endregion

            #region Genaric Search Example02

            ///  int[] Numbers = [ 10 , 2 ,8 ,4 ,9 , 1, 5, 3, 7, 6  ];
            /// 
            /// int Result = Helper<int>.LinearSearch(Numbers, 9);
            ///  Console.WriteLine($"Result = {Result}");

            ///     Employee[] Employees =
            ///     {
            ///     
            ///         new Employee() { ID = 10 ,Name = "Ahmed" , Salary= 8_000 },
            ///         new Employee() { ID = 20 ,Name = "Omar" , Salary= 2_000 },
            ///         new Employee() { ID = 30 ,Name = "Omniaa" , Salary= 5_000 },
            ///         new Employee() { ID = 40 ,Name = "Sharaf" , Salary= 9_000 },
            ///         
            ///     };
            /// 
            ///  int index = Helper<Employee>.LinearSearch(Employees, new Employee() { ID = 30, Name = "Omniaa", Salary = 5_000 });
            ///  int index = Helper<Employee>.LinearSearch(Employees, new Employee() { Name = "Omniaa" },new EmployeeEqualityComparer());
            ///    int index = Helper<Employee>.LinearSearch(Employees, new Employee() { ID = 40 },new EmployeeEqualityComparerID());

            /// int index = Helper<Employee>.LinearSearch(Employees,
            /// 
            ///     new Employee() { ID = 10, Name = "Ahmed" },
            ///     delegate (Employee x, Employee y) { return x.Name == y.Name; }
            ///     ); ;

            ///  int index = Helper<Employee>.LinearSearch(Employees,
            /// 
            ///      new Employee() { ID = 10, Name = "Ahmed" },
            ///       ( x, y) =>  x.Name == y.Name 
            ///      ); ;
            /// 
            ///  
            /// 
            ///  
            ///  Console.WriteLine($"Index = {index}");

            /// Console.WriteLine($" index = {index}");
            ///   Employee E01 = new Employee() { ID = 10 , Name = "Ahmed" , Salary= 5_000 }; 
            ///   Employee E02 = new Employee() { ID = 10, Name = "Ahmed", Salary = 5_000 };
            /// 
            /// Console.WriteLine($"E01.GetHashCode() = {E01.GetHashCode()}");
            /// Console.WriteLine($"E02.GetHashCode() = {E02.GetHashCode()}");
            /// 
            /// //if (E01 == E02)   
            /// if (E01.Equals(E02))  //  هنا هيفرق  Equality  ف ال Interface   او ال Classes  زي ال   Ref انما لو بيقارن حاجه  State ب  State   هنا كان بيقارن  
            /// {
            ///     Console.WriteLine("EQUALS");
            /// }
            /// else
            /// {
            ///     Console.WriteLine("!EQUALS");
            /// }  
            #endregion

            #region EQUALITY  ( == , Equals )&& GetHashCode 

            ///   Employee E01 = new Employee() { ID = 10, Name = "Ahmed", Salary = 5_000 };
            ///   Employee E02 = new Employee() { ID = 10, Name = "Ahmed", Salary = 5_000 };
            /// 
            ///   Console.WriteLine($"E01.GetHashCode() = {E01.GetHashCode()}");
            ///   Console.WriteLine($" E02.GetHashCode() = {E02.GetHashCode()}");
            /// 
            /// 
            ///   //  if (E01 == E02)   // ==: Address   ب Address     بتقارن 
            ///   if (E01.Equals(E02))  //Referance Base Equality  يعني الاتنين 
            ///       Console.WriteLine("EQUALS");  //  زي ما هي  Referance Base Equality  ==  وال   Equals==> Value  Base Equality  كدا بقت ال   Override to Equals بعد ما عملت ال 
            ///   else
            ///       Console.WriteLine("!EQUALS"); 
            #endregion


            #region Genaric Example03 
            /// int[] Numbers = [9, 4, 10, 6, 2, 8, 5, 1, 3, 7]; 
            /// Helper<int>.BubbleSort(Numbers);
            /// 
            /// foreach (int number in Numbers)
            /// {
            ///     Console.WriteLine(number);
            /// }

            ///   Employee[] Employees =
            ///   {
            /// 
            ///        new Employee() { ID = 10 ,Name = "Ahmed" , Salary= 8_000 },
            ///        new Employee() { ID = 20 ,Name = "Omar" , Salary= 2_000 },
            ///        new Employee() { ID = 50 ,Name = "Zeyad" , Salary= 2_000 },
            ///        new Employee() { ID = 30 ,Name = "Omniaa" , Salary= 5_000 },
            ///        new Employee() { ID = 40 ,Name = "Sharaf" , Salary= 9_000 },
            /// 
            ///      };
            /// 
            ///     Helper<Employee>.BubbleSort(Employees);
            ///     Helper<Employee>.BubbleSort(Employees , new EmployeeComparerByID());  // Orderd By Id 
            ///     Helper<Employee>.BubbleSort(Employees , new EmployeeComparerByName());  // Orderd By Id 
            ///     Helper<Employee>.BubbleSort(Employees, delegate (Employee X, Employee Y)
            ///     {
            ///         return X.ID.CompareTo(Y.ID) == 1;
            ///     }); 
            /// 
            ///   Helper<Employee>.BubbleSort(Employees,  ( X, Y) => X.ID.CompareTo(Y.ID) == 1);
            ///    
            ///   
            ///     
            ///     
            ///   
            ///   foreach (var Employee in Employees)
            ///             Console.WriteLine(Employee);
            ///  
            #endregion
        
        
        
        }
    }
}
