using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_AdvanceOOP
{
    static  class   Helper
    {              //    بس  Method   وممكن يكون علي ال    class   ممكن يكون علي ال  Genaric    ال 

        public static void SWAP <T>(ref T X  , ref T Y  )// T ==> Same Templet in C++ , JaveScript 
        {
            Console.WriteLine("=================SWAP=============== ");
            T Temp = X;
            X=Y; 
            Y=Temp;
        }
        





        
    /// public static void SWAP (ref object  X  , ref object  Y  )
    /// {
    ///     Console.WriteLine("=================SWAP=============== ");
    ///     object  Temp = X;    // 1-    ودي حاجه مش حلوه طبعا   Boxing and UnBoxing   خلاني استخدم ال  Object  بس ال  
    ///     X=Y;                 // 2-Type Safe  الي بكتبه مش  Code ال 
    ///                          // 3-  ممكن يجي ودا مش كويس طبعا   Type بتاعي مفتوح ل اي  Scope   يعني ال Limits   مش  Object   ال 
    ///     Y = Temp;
    /// }






    /// public static void SWAP(ref double X  , ref double  Y  )
    /// {
    ///     Console.WriteLine("=================SWAP=============== ");
    ///     double Temp = X;
    ///     X=Y; 
    ///     Y=Temp;
    /// }
       
        
    /// public static void SWAP(ref Point X, ref Point Y)
    /// {
    ///     Console.WriteLine("=================SWAP=============== ");
    ///     Point Temp = X;
    ///     X = Y;
    ///     Y = Temp;
    /// }


    }
}
