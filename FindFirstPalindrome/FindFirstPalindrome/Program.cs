//static string FirstPalindrome(string[] words)
//{
//	foreach (string w in words)
//	{
//		if (w == String.Join("", w.Reverse()))
//		{
//			return w;
//		}
//	}

//	return "";
//}

static string FirstPalindrome(string[] words)
{
	for(int i = 0; i<words.Length; i++)
	{
		string wordReverted = String.Join("", words[i].Reverse());
		if (words[i] == wordReverted)
		{
			return words[i];
		}
	}

	return "";
}

Console.WriteLine(FirstPalindrome(["abc", "car", "racecar", "ada", "cool"]));
Console.WriteLine(FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]));

// Prestemos atenção na complexidade de se usar reverse versus duplo ponteiro
// Para usar reverse precisamos salvar uma nova palavra na memória, além de precisar percorrer as duas palavras
// Usando duplo ponteiro (nas 2 extremidades) temos mais eficiência, pois apenas precisamos percorrer o array uma única vez
// no caso os ponteiros das pontas vão em direção ao meio

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