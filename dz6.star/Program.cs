Console.Write("Введите скобочную последовательность:");
string str = Console.ReadLine();

var myStack = new Stack<char>();

string answer = "yes";

for (int i = 0; i < str.Length; i++)
{
    bool isNotBracket = str[i] != '(' && str[i] != '[' && str[i] != '{' && str[i] != ')' && str[i] != ']'  && str[i] != ']';
    if (isNotBracket)
    {
        continue;
    }

    bool isOpeningBracket = str[i] == '(' || str[i] == '[';
    if (isOpeningBracket)
    {
        myStack.Push(str[i]);
    }

    if (str[i] == ')')
    {
        if (myStack.Count == 0)
        {
            answer = "no";
            break;
        }

        if (myStack.Pop() != '(')
        {
            answer = "no";
            break;
        }
    }

    if (str[i] == ']')
    {
        if (myStack.Count == 0)
        {
            answer = "no";
            break;
        }

        if (myStack.Pop() != '[')
        {
            answer = "no";
            break;
        }
    }
}

if (myStack.Count != 0)
{
    answer = "no";
}

Console.Clear();
Console.WriteLine(answer);
