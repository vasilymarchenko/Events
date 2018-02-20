namespace Delegates
{
    public class LambdaExample
    {
        delegate int Operation(int x, int y);

        public void DelegateUsage(int x, int y)
        {
            //Full sintax
            Operation op = Plus;
            int result = op.Invoke(x, y);

            //Anonim method
            Operation op2 = delegate(int a, int b)
            {
                return a + b;
            };
            result = op2(x, y);

            //lambda
            Operation op3 = (a, b) => a + b;
            result = op3(x, y);
        }

        private int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
