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

            #region Q5: Write a generic method FindMax<T> that finds maximum value

            //int maxNumber = Utility.FindMax(20, 50);
            //Console.WriteLine(maxNumber);

            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>.

            //IRepository<Product> repo = new ProductRepository();
            //repo.Add(new Product { Id = 1, Name = "Mobile" });

            //var product = repo.Get(1);  // Helping With AI
            //Console.WriteLine(product.Name);

            #endregion

            #region Q7: What is the 'struct' constraint? Write an example

            // The Struct Constraints Allows Only Value Types.

            //Box<int> calc = new Box<int> { Value = 42 };
            //Console.WriteLine(calc.Value);


            #endregion

            #region Q8: What is the 'class' constraint? Write an example.

            // The Class Constraints Allows Only Reference Types 

            //ObjectRepository<string> repo = new ObjectRepository<string> { Item = "Ay7aga" };
            //Console.WriteLine(repo.Item);

            #endregion

        }
    }
}
