
int[] TwoSum(int[] nums, int target)
{
	Dictionary<int, int> dict = new Dictionary<int, int>();
	// Supondo que passamos TwoSum([1, 2, 7, 10, 23], 9))
	// o Dictionary ficaria dessa forma

	// {
	//    TKey , TValue (remaining)
	//     1 :   8 (traduzindo: na posição onde o valor é 1 falta 8 pro target)
	//     2 :   7
	//     7 :   2  -> o remaining aqui é o mesmo "valor" de uma TKey que já existe na tabela
	// }

	for (int i = 0; i < nums.Length; i++)
	{
		int remaining = target - nums[i];

		if (dict.ContainsKey(remaining))
		{
			return new int[] { dict[remaining], i };
		} else
		{
			dict[nums[i]] = i;
		}
	}

	throw new Exception("Not found");
}

Console.WriteLine("Resposta: " + string.Join(", ", TwoSum([1, 2, 7, 10, 23], 9)));

//**********************************************************************************************

//Para usar hash table no C# usamos a classe Dictionary()

//A classe Dictionary representa uma coleção de chaves e valores.
//É uma coleção do tipo chave/valor e implementa  a interface IDictionary
//que possui duas coleções no seu interior uma para guardar a chave e outra para guardar o valor.

//Esta classe esta definida no namespace System.Collections.Generic
//sendo uma classe genérica e pode armazenar qualquer tipo de dados em uma forma de chaves e valor,
//onde cada chave deve ser exclusiva na coleção.
//A classe Dictionary fornece recursos semelhantes a uma Hashtable, mas é fortemente tipada.
//Isso significa que seu código não precisa converter de objetos genéricos em tipos específicos.
//Isso também significa que a classe Dictionary garante que seu código passe os tipos corretos de objetos para ele.

//O objeto Dictionary pode ser atribuído a:
// 1) uma variável do tipo IDictionary<Tkey, TValue> ou:
// 2) classe Dictionary <TKey, Tvalue>. Exemplos de inicialização:

//IDictionary<int, string> dict = new Dictionary<int, string>();

//Dictionary<int, string> dict = new Dictionary<int, string>();

//No código cima especificamos os tipos de chave e valor ao declarar um objeto de dicionário.

//Um int é um tipo de chave e string é um tipo de valor que será armazenado em um objeto de dicionário chamado dict.
//Você pode usar qualquer tipo de dados C# válido para chaves e valores.

//As principais propridades da classe Dictionary são:

// Count: Obtém o número total de elementos no Dictionary<TKey, TValue>.
// IsReadOnly: Retorna um booleano indicando se o Dictionary<TKey, TValue> é somente leitura.
// Item: Obtém ou define o elemento com a chave especificada no Dictionary<TKey, TValue>.
// Keys: Retorna a coleção de chaves do Dictionary<TKey, TValue>
// Values: Retorna a coleta de valores no Dictionary<TKey, TValue>.

//Os principais métodos da classe Dictionary são:

//Add: Adiciona um item à coleção Dictionary.
//Add: Adiciona pares de valores-chave na coleção Dictionary<TKey, TValue>.
//Remove: Remove a primeira ocorrência do item especificado do Dictionary<TKey, TValue>.
//Remove: Remove o elemento com a chave especificada.
//ContainsKey: Verifica se a chave especificada existe em Dictionary<TKey, TValue>.
//ContainsValue: Verifica se o valor especificado existe em Dictionary<TKey, TValue>.
//Clear: Remove todos os elementos do Dictionary<TKey, TValue>.
//TryGetValue: Retorna true e atribui o valor com a chave especificada, se a chave não existir, retorna false.