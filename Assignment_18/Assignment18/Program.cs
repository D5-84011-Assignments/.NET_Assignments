namespace Assignment18
{
    internal class Program
    {
        public delegate void mydelete(int a, int b);
        public delegate void mydelete2(int a, int b);
        static void Main(string[] args)
        {

            #region  Unicast Delegate
            mydelete pointer = new mydelete(Math.Add);
            pointer.Invoke(5, 7);
            pointer = new mydelete(Math.Sub);
            pointer.Invoke(5, 7);
            pointer = new mydelete(Math.Multiply);
            pointer.Invoke(5, 7);
            pointer = new mydelete(Math.Divide);
            pointer.Invoke(5, 7);
            #endregion

            #region Multicast Delegate
            mydelete2 pointer2 = Math.Add;
            pointer2 += Math.Sub;
            pointer2 += Math.Multiply;
            pointer2 += Math.Divide;
            pointer2.Invoke(8, 4);
            #endregion
        }

    }
    class Math
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine("Addition" + (num1 + num2));
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine("Sub" + (num1 - num2));

        }
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiply" + (num1 * num2));

        }
        public static void Divide(int num1, int num2)
        {
            Console.WriteLine("Divide" + (num1 / num2));

        }

    }
}
