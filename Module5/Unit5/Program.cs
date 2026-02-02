/*
convert the message into a char array
reverse the chars
count the o's
convert it back to a string
print it out
*/


string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");