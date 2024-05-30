string hello = " we are the champions?";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();


hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

firstLetter = hello[0];
Console.WriteLine(firstLetter);




