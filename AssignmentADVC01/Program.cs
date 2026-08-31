namespace AssignmentADVC01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1: What is a generic class? Why use generics?

            // Is A Class That Allows You To Write Classes, Interfaces and Methods With Type Parameters , While The Actual Type Is Specified When The Code Is Used,Not When It Is Written.
            // Because It Is Type Safe, Reusable, Better, Cleaner Code.

            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods

            //Container<string> container = new Container<string>();
            //container.Add("Ahmed");
            //container.Add("Mohamed");

            //Console.WriteLine(container.Get(0));
            //Console.WriteLine(container.Get(1)); 

            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey,TValue >.

            //Pair<int, string> student = new Pair<int, string>(1, "Ahmed");
            //Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");


            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.

            // Is A Method That Can Be Generic Even if The Class Is Not Generic [ Defines It's Own Parameters ].

            //int x = 5;
            //int y = 10;
            //Helper.Swap(ref x, ref y);
            //Console.WriteLine($"{x} {y}");

            #endregion

        }
    }
}
