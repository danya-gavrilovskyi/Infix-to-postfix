string[] Tokenizer(string input)
{
    string[] tokens = new string[20];
    int tokenIndex = -1;
    string postfix = "";

    void Push(string token)
    {
        tokens[++tokenIndex] = token;
    }

    foreach (char el in input)
    {
        if (Char.IsNumber(el))
        {
            postfix += el;
        }
        else if (el is '-' or '+' or '*' or '/' or '^' or '(' or ')')
        {

            if (postfix.Length > 0)
            {
                Push(postfix);
                postfix = "";
            }

            Push(el.ToString());
        }

    }

    if (postfix.Length > 0)
    {
        Push(postfix);
    }

    return tokens;
}

void Main()
{
    Console.WriteLine("Enter your expression: ");
    string input = Console.ReadLine()!;
}

Main();