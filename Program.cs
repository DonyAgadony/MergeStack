class Program
{
    public static void Main()
    {

    }
    public static Stack<int> ReverseStack(Stack<int> Stack)
    {
        Stack<int> Reversed = new Stack<int>();
        while (Stack.Count > 0)
        {
            Reversed.Push(Stack.Pop());
        }
        return Reversed;
    }
    public static Stack<int> MergeStack(Stack<int> stack1, Stack<int> stack2)
    {
        Stack<int> Merged = new();
        stack1 = ReverseStack(stack1);
        while (stack1.Count > 0)
        {
            Merged.Push(stack1.Pop());
        }
        stack2 = ReverseStack(stack2);
        while (stack2.Count > 0)
        {
            Merged.Push(stack2.Pop());
        }
        return Merged;
    }
}