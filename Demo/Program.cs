using Demo.Overloading;
using Demo.Overriding;

namespace Demo
{
    internal class Program
    {
        #region Methods Overloading 
        public static int SumNumbers(int a, int b)
        {
            return a + b;
        }
        public static int SumNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double SumNumbers(double a, double b)
        {
            return a + b;
        }
        public static double SumNumbers(int a, double b)
        {
            return a + b;
        }


        #endregion

        #region Operators Overloading 


        #endregion

        static void Main(string[] args)
        {
            #region Overloading
            //int A = 10, B = 20, C = 30;
            ////int result = SumTwoNumbers(A, B);
            ////Console.WriteLine($"The sum of {A} and {B} is: {result}");
            //int result = SumNumbers(A, B, C);
            //Console.WriteLine(result);
            #endregion

            #region Operators Overloading 
            //Complex C1 = new Complex() { Real = 10, Img = 5 };

            //Console.WriteLine($"C1 => {C1}");
            //Complex C2 = new Complex() { Real = 6, Img = 3 };
            //Console.WriteLine($"C2 => {C2}");
            //Console.WriteLine("=============================");
            ////Complex C3 = C1 - C2;
            ////Console.WriteLine($"C3 => {C3}");
            ////C3++;
            ////Console.WriteLine($"C3 ++ => {C3}");
            ////C3--;
            ////Console.WriteLine($"C3 -- => {C3}");

            ////if (C1 > C2)
            ////    Console.WriteLine(" C1 > C2 ");
            ////else
            ////    Console.WriteLine(" C1 < C2 ");
            ////string Z = (string)C2;
            ////int X = (int)C2;

            #endregion

            #region Casting Operators Overloading 
            //User user = new User()
            //{
            //    Id = 10,
            //    FullName = "Mostafa Hany",
            //    Email = "Mostafa@Gmail.Com",
            //    Password = "P@sswOrd",
            //    SecurityStamp = Guid.NewGuid()
            //};

            //UserViewModel userViewModel = (UserViewModel)user;
            //Console.WriteLine(userViewModel.Id);
            //Console.WriteLine(userViewModel.FirstName);
            //Console.WriteLine(userViewModel.LastName);
            //Console.WriteLine(userViewModel.Email);
            #endregion


            #region Overriding

           TypeA typeA = new TypeA(1);
            typeA.A = 1;
            typeA.MyFun01();
            typeA.MyFun02();

            TypeB typeB = new TypeB(1,2);
            typeB.A = 10;
            typeB.B = 20;
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion

         #region Binding
         TypeA typeARef = new TypeB(1, 2); //typeARef.b; //invalid
         //typeARef.B; //invalid
         typeARef.A = 100; // valid
        
         typeARef.MyFun01(); // non virtual metohd new resclve at compile time based on the type of  reference
         //    Static Binding || Early Binding
        
         typeARef.MyFun02(); //  virtual method override using  override keywords Resolve at runtime based on the type of object
        
         //    Dynamic Binding || Late Binding
        
         #endregion
        }
    }
}
