namespace Search.Algorithms
{
    internal class StackAlgorithm
    {
        public void ExecuteStackAlgorithm()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4); // -> Last in and first out

            //Removing from the top, cause the stack works like this:
            //last in first out (the element)
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}