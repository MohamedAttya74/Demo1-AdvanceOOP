using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_AdvanceOOP
{
    internal static  class   Helper <T> where T: class, IComparable<T> , new() /* , IEnumerable<T>, ICloneable*/ // T must be Class or Struct Immplementing the built-in InterFace "IComparable"
        /* where T : class*/
    {      //    بس  Method   وممكن يكون علي ال    class   ممكن يكون علي ال  Genaric    ال 


        //Primary Constraint  [ 0 : 1 ]
        //  1-General Primary  Constraint 
        //     class => T Must Be Class
        //     struct => T Must Be Struct 
        //     notnull => T Must Be Not Nullable  ( C# 8.0 )
        //     defult  =>   Search    
        //     unmanged => 
        //     Enam => T must Be Enum (C# 7.3)  ==( Specila Primary Constraint not General Primary  Constraint )
        // 2- Specila Primary Constraint (USer-Defined Class (Except Sealed ))
        //     point => T Must Be Point  Or Another Class inherits from Point  

        ///  2 - Secondary constraint (InterFace Constraint )  [ 0 : M ]
        ///    IComparable<T> 
        ///  T Must Be class/struct Immplementing  IComparable

        // Paramterless  Constractor  Constraint [0:1]
        // T Must Be Datatype Having Accesable [non-private] Paramterless Constractor
        // Till C# 12.0 Only One Constructor Constraint
        // Can`t Use new()  [ Constractor  Constraint ] with struct [Specila Primary Constraint ]
        public static void BubbleSort(T[] Arr)
        {
            if(Arr is null || Arr.Length == 0) 
                    return;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0;j<Arr.Length-1-i; j++)
                {
                    if (Arr[j].CompareTo (Arr[j + 1]) ==  1 /*-1*/)
                    {
                    /*Helper<T>.*/  SWAP(ref Arr[j] , ref Arr[j+1]);
                    }
                }
            }
        }

        public static void BubbleSort(T[] Arr , IComparer <T> comparer)
        {
            if(Arr is null || Arr.Length == 0) 
                    return;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0;j<Arr.Length-1-i; j++)
                {
                    if (comparer.Compare (Arr[j], Arr[j + 1]) ==  1 )
                    {
                    /*Helper<T>.*/  SWAP(ref Arr[j] , ref Arr[j+1]);
                    }
                }
            }
        } 
        public static void BubbleSort(T[] Arr, Func<T, T, bool> comparer)
        {
            if(Arr is null || Arr.Length == 0) 
                    return;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0;j<Arr.Length-1-i; j++)
                {
                    if (comparer(Arr[j], Arr[j + 1]) )
                    {
                    /*Helper<T>.*/  SWAP(ref Arr[j] , ref Arr[j+1]);
                    }
                }
            }
        }







        public static void SWAP (ref T X  , ref T Y  )// T ==> Same Templet in C++ , JaveScript 
        {
            Console.WriteLine("=================SWAP=============== ");
            T Temp = X;
            X=Y; 
            Y=Temp;
        }


        public static int LinearSearch(T[] Arr, T Value)
        {
            if (Arr?.Length > 0 && Value is not null)

                for (int i = 0; i < Arr.Length; i++)
                {

                    //if (Value == Arr[i])
                    if (Value.Equals (Arr[i]))
                        return i;
                    
                }
            return -1;
        }
        public static int LinearSearch(T[] Arr, T Value, IEqualityComparer <T> equalityComparer)
        {
            if (Arr?.Length > 0 && Value is not null)

                for (int i = 0; i < Arr.Length; i++)
                {

                    //if (Value == Arr[i])
                    //if (Value.Equals (Arr[i]))
                    if (equalityComparer.Equals(Value, Arr[i]))
                        return i;
                    
                }
            return -1;
        }
        public static int LinearSearch(T[] Arr, T Value,Func<T,T,bool> equals)
        {
            if (Arr?.Length > 0 && Value is not null)

                for (int i = 0; i < Arr.Length; i++)
                {

                    //if (Value == Arr[i])
                    //if (Value.Equals (Arr[i]))
                    //if (equalityComparer.Equals(Value, Arr[i]))
                    if (equals(Value , Arr[i]))
                        return i;
                    
                }
            return -1;
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
