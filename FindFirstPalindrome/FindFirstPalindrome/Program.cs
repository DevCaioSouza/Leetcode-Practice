static string FirstPalindrome(string[] words)
{
	foreach (string w in words)
	{
		if (w == String.Join("", w.Reverse()))
		{
			return w;
		}
	}

	return "";
}
Console.WriteLine(FirstPalindrome(["abc", "car", "racecar", "ada", "cool"]));



// Maneira alternativa de reverter um array:

// Primeiro, TRANSFORMAMOS A STRING EM UM ARRAY DE CHAR!!
// Um char é uma string de apenas um caractere. Quando temos um array de chars, temos algo equivalente a uma string
// O método ToCharArray() dará conta de fazer essa tarefa

// Para reverter o array, usamos o método Reverse

//static string Reverted(string s)
//{
//	char[] charArray = s.ToCharArray();
//	Array.Reverse(charArray);
//	return new string(charArray);
//}

//Console.WriteLine(Reverted("Carro"));