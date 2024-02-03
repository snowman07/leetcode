// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

///////////////////////////////// Other way:

//Console.Write("Enter string: ");
//string userInput = Console.ReadLine();
//string reversedString = ReverseString(userInput);
//Console.WriteLine($"Reversed string: {reversedString}");


//static string ReverseString(string input)
//{
//    char[] chars = input.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

///////////////////////////////


Console.Write("Enter a string: ");
string userInput = Console.ReadLine();
char[] charArray = userInput.ToCharArray();
ReverseString(charArray);
Console.WriteLine("Reversed string: " + new string(charArray));


static void ReverseString(char[] chars)
{
    //Array.Reverse(chars); //simplest solution

    int left = 0;
    int right = chars.Length - 1;

    while (left < right)
    {
        //Swap characters at left and right indices
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;

        //Move the pointers towards the center of the array
        left++;
        right--;
    }
}


