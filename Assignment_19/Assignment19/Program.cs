namespace Assignment19
{
    internal class Program
    {
        public delegate void mydelete(int a, int b);
        public delegate void mydelete2(int a, int b);
        static void Main(string[] args)
        {
            Math fun= new Math();   
            #region  Unicast Delegate
            mydelete pointer = new mydelete(fun.Add);
            pointer.Invoke(5, 7);
            pointer = new mydelete(fun.Sub);
            pointer.Invoke(5, 7);
            pointer = new mydelete(fun.Multiply);
            pointer.Invoke(5, 7);
            pointer = new mydelete(fun.Divide);
            pointer.Invoke(5, 7);
            #endregion

            #region Multicast Delegate
            mydelete2 pointer2 = fun.Add;
            pointer2 += fun.Sub;
            pointer2 += fun.Multiply;
            pointer2 += fun.Divide;
            pointer2.Invoke(8, 4);
            #endregion
        }

    }
    class Math
    {
        public  void Add(int num1, int num2)
        {
            Console.WriteLine("Addition" + (num1 + num2));
        }
        public  void Sub(int num1, int num2)
        {
            Console.WriteLine("Sub" + (num1 - num2));

        }
        public  void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiply" + (num1 * num2));

        }
        public  void Divide(int num1, int num2)
        {
            Console.WriteLine("Divide" + (num1 / num2));

        }

    }
}
