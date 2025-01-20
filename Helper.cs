using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_AdvanceOOP
{
    internal static  class   Helper <T> where T: IComparable<T>  // T must be Class or Struct Immplementing the built-in InterFace "IComparable"
        /* where T : class*/
    {      //    بس  Method   وممكن يكون علي ال    class   ممكن يكون علي ال  Genaric    ال 
                    
      
        
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
        } public static void BubbleSort(T[] Arr, Func<T, T, bool> comparer)
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
