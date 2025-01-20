using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_AdvanceOOP
{
     internal class  Employee
    {    // struct inherte from Class Value Type    after that Class Value Type inherte  from Object 
         // Equals and GetHashCode()     مهمين جدا وهما ال Two Methods  علي  override    مهم جدا وهو علشان ي   Object  و struct    بين اي   Class Value Type وجود ال 

        public int ID { get; set; }
        public string?  Name  { get; set; }
        public decimal Salary  { get; set; }



        public override bool Equals(object? obj)
        {
          /*  Employee? other = (Employee?) obj;*/ // Unsafe Casting 

            Employee? Other = obj as Employee;   // as:  Employee يكون من نوع ال  obj ودي معناها انها هتنجح ف حاله واحده وهي ان ال    Casting بنستخدمها ف ال 
            if (Other == null) return false;      
            return this.ID.Equals(Other.ID) && this.Name.Equals(Other.Name) && this.Salary.Equals(Other.Salary); 
        }

        //employee01= {ID = 10 , Name = "Ahmed" , Salary= 1000}
        //employee02= {ID = 1000 , Name = "Ahmed" , Salary= 10}

        public override int GetHashCode()
        {


            return HashCode.Combine(this.ID, this.Name , this.Salary);
             /// int hashcode = 11;  //  C# 8   وبيمنع التصادم ودا لحد  GetHashCode()افضل طريقه لل
        /// hashcode = (hashcode*7)    + this.ID.GetHashCode();
        /// hashcode = (hashcode * 7) + this.Name?.GetHashCode() ?? default(int) ;
        /// hashcode = (hashcode * 7) + this.Salary.GetHashCode();
        /// return hashcode;
              //return ID.GetHashCode() ^ Name?.GetHashCode() ?? default(int) /*0*/ ^  Salary.GetHashCode() ;  // +  بس ف نفس الوقت دي مش احسن طريقه علشان ممكن يحصل تصادم حتي بطريقه ال   Processing  اسرع فال 
             // return ID.GetHashCode() + Name?.GetHashCode() ?? default(int) /*0*/ + Salary.GetHashCode() ;
        }




        //public Employee(int id , string name , decimal salary )
        //{
        //    this.ID = id;
        //    this.Name = name;
        //    this.Salary = salary;
        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}




        /// public override bool Equals(object? obj)
        /// {
        ///     Employee? Other = (Employee?)obj;
        ///     if (Other is null) return false;
        ///     return this.ID == Other.ID && this.Name == Other.Name && this.Salary == Other.Salary;
        /// }
        /// 
        /// public override int GetHashCode()
        ///  {
        ///      return HashCode.Combine(this.ID, this.Name, this.Salary);
        ///  }  // Generate HashCode Based on State 
        ///  //  GetHashCode()   لازم اعمل زيها لل override  Equals لو عملت 

        /// public override bool Equals( object? obj) /*obj ==> E02 = new Employee() { ID = 10, Name = "Ahmed", Salary = 5_000 } */
        /// {
        ///     Employee? other = (Employee?) obj;    // Unsafe Casting : Compiler Cant Enforce Type Safty  [May Throw Exaption "InvalidCast Exception "]
        ///    if ( other is   null ) return false;
        ///     
        ///     return this.ID == other.ID && this.Name ==other.Name  
        /// }

        /// public static bool operator == (Employee left, Employee right)
        /// {
        ///     return   left.Equals(right);   //  ولا حاجه   Overloading  وبكدا مش محتاجين نعمل  
        ///              /*(left.ID == right.ID && left.Name == right.Name && left.Salary == right.Salary)*/;
        /// }
        /// public static bool operator != (Employee left, Employee right)
        /// {
        ///      return !left.Equals(right);
        ///            // !(left == right) ;
        /// }

    }
}
