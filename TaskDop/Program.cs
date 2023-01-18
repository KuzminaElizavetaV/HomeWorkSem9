/*Задача со звездочкой: Пользователь вводит скобочные последовательности. 
В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите,
 состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена
Функция возвращает значение true, если закрытая скобка из строки находит пару с ранее помещенной в стек открытой скобкой
*/

bool FindPair(char charBracket1, char charBracket2)
{
    if (charBracket1 == '(' && charBracket2 == ')')
        return true;
    else if (charBracket1 == '{' && charBracket2 == '}')
        return true;
    else if (charBracket1 == '[' && charBracket2 == ']')
        return true;
    else
        return false;
}

bool CorrectBracketSequence(string charBracket)
{
    Stack<char> checkString = new Stack<char>();
    for (int i = 0; i < charBracket.Length; i++)
    {
        if (charBracket[i] == '{' || charBracket[i] == '(' || charBracket[i] == '[')
            checkString.Push(charBracket[i]);
        //для исключения ввода вложенных пар скобок типа ((({}))) использую очистку стека, если там уже есть открывающая скобка
        //иначе будет работать вложенная проверка
        if (checkString.Count > 1)
        {
            checkString.Clear();
            return false;
        } 

        if (charBracket[i] == '}' || charBracket[i] == ')' || charBracket[i] == ']')
        {        
            if (checkString.Count == 0)
            {
                return false;
            }
            else if (!FindPair(checkString.Pop(), charBracket[i]))
            {
                return false;
            }
        }
    }
    if (checkString.Count == 0) return true;
    else return false;
}

bool CheckStringStandardBracket(string charBracket)
{
    string standardBracket = "(){}[]";
    foreach (char item in charBracket)
    {
        if (!standardBracket.Contains(item))
            return false;
    }
    return true;
}

Console.Write("Введите последовательность из скобок: ");
string brackets = Console.ReadLine();

if (CheckStringStandardBracket(brackets))
{
    //сперва сделаем проверку скобочной последовательности на четность, если Да, то запускаем функцию проверки CorrectBracketSequence
    if (brackets.Length % 2 == 0) 
    {
        if (CorrectBracketSequence(brackets))
            Console.WriteLine("Последовательность " + brackets + " правильная!");
        else
            Console.WriteLine("Последовательность " + brackets + " неправильная!");
    }
    else 
        Console.WriteLine("Последовательность " + brackets + " неправильная!");
}
else 
Console.WriteLine("Введите последовательность из скобок, например, ()[]{} ");
