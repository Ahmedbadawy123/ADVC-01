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

            #region Q9: What is the 'new()' constraint? Write an example.

            // The new() Constraints Requires That The Type Has a Public Parameterless CTOR .

            //var carFactory = new Factory<Car>();
            //Car myCar = carFactory.CreateInstance();
            //Console.WriteLine(myCar.Model);


            #endregion

            #region Q10: What is the interface constraint? Write an example

            // Constraints That Requires The Type Implements The Specified Interface.

            //var loggerService = new Logger<FileLogger>();
            //loggerService.Execute(new FileLogger());

            #endregion

            #region Q11: What is the base class constraint? Write an example

            // It Requires T to Inherit From a Specific Base Class.

            //Service<User> service = new Service<User>();
            //service.DisplayId(new User { Id = 2, Username = "Ali" });

            #endregion

            #region Q12: How do you apply multiple constraints? Write an example.

            //By Using Commas ( , )

            //var manager = new Manager<OrderEntity>();
            ////Manager<OrderEntity> newOrder = new Manager<OrderEntity>();
            //OrderEntity newOrder = manager.Process();

            #endregion

            #region Q13: What does the 'default' keyword do in generics?

            // Returns The Default Value For T


            #endregion

            #region Q14: Write a SafeList<T> that returns default when the index is invalid.

            //var list = new SafeList<int>();
            //list.Add(100);
            //list.Add(200);

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(10));

            // Asking AI

            #endregion

            #region Q15: What is covariance? Explain the 'out' keyword.

            // Covariance : Allows a More Derived Type to be Used Where a Base Type is Expected.
            // Out : Guarantees The Type is Used Only In Output Positions (Return Types).

            #endregion
        }
    }
}
