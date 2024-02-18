// LEETCODE 1481.Least Number of Unique Integers after K Removals - Medium

// Given an array of integers arr and an integer k. Find the least number of unique integers after removing exactly k elements.



// Example 1: Input: arr = [5, 5, 4], k = 1
// Output: 1
// Explanation: Remove the single 4, only 5 is left.

// Example 2: Input: arr = [4, 3, 1, 1, 3, 3, 2], k = 3
// Output: 2
// Explanation: Remove 4, 2 and either one of the two 1s or three 3s. 1 and 3 will be left.

static int FindLeastNumOfUniqueInts(int[] arr, int k)
{
	// Criar um dicionário, pois usaremos uma hash table para abrigar os valores e suas 
	// frequências correspondentes
	// No caso, um elemento do dicionário precisa conter: Sua chave, e sua frequência
	// tomando como exemplo arr = [4, 3, 1, 1, 3, 3, 2], k = 3, teremos um hash table mais ou menos assim: 
	// {4:1, 3:3, 1:2, 2:1}. O "Value" do elemento no caso seria a frequência com que eles aparecem

	var dict = new Dictionary<int, int>();

	for (var i = 0; i < arr.Length; i++)
	{
		// "se" já houver no dict a key arr[i]
		if (dict.ContainsKey(arr[i]))
			// se sim, dict na posição "arr[i]" aumentará em 1. No caso, aumenta a frequência de ocorrência daquele número

			// nesse caso, o elemento dict que já possuir essa chave irá ter seu valor aumentado em 1
			dict[arr[i]]++;
		else
			// Se não, adicionamos um elemento no dict, sendo o valor do array naquela posição 
			// com seu valor sendo 1 (pois não existia nenhum antes)
			dict.Add(arr[i], 1);
	}

	var sortedDict = dict.OrderBy(pair => pair.Value).ToList();

	foreach (var kvp in sortedDict)
	{
		// K é passado como argumento, pode variar. (nós escolhemos o K, o funcionamento da função conta com isso)
		if (k > 0)
		{
			if (k >= kvp.Value)
			{
				// Se k >= kvp.Value, kvp.Value que no caso aqui é o CONTADOR dos elementos,
				// Lembrando que estamos iterando pelo hash table SORTADO!!

				// k diminuirá em "kvp.Value" unidades. É como se o k fosse gastando a cada "uso"
				// Seu uso no caso, é eliminar as chaves de menor ocorrência

				// supondo k=3, cada vez que ele elimina a chave de menor ocorrência,
				// seu valor diminui em uma unidade, e a chave é eliminada.
				k -= kvp.Value;
				dict.Remove(kvp.Key);
			}
			else
			{
				dict[kvp.Key] -= k;
				k = 0;
			}
		}
		else
		{
			break;
		}
	}

	return dict.Count;

}

Console.WriteLine(FindLeastNumOfUniqueInts([4, 3, 1, 1, 3, 3, 2], 3));




// Comment: "least number of unique integers" means we want to minimize the number of distinct integers in the array.
// e.g. [5, 5, 1] has two distinct integers, 5 and 1. If we delete 1 we are left with [5, 5],
// meaning there is only one distinct integer: 5
// Try counting how many times each integer occurs,
// and greedily deleting from the integers with the lowest number of occurrences first.
// Suggestion: There are multiple ways to do this, I elected for bucket sort to achieve O(n) time complexity.

// Comment: Count the number of occurrences of each unique integer in the input array.
// Sort the list of counts in ascending order.
// Iterate through the sorted list of counts.
// If k is greater than or equal to the current count, subtract the current count from k.
// If k is less than the current count, set count to the number of remaining unique integers and break the loop.











// Solution n° 1
// Used a Priority Queue, Set and HashMap to.

// HashMap to store frequencies.
// Set to store the unique elements of the array.
// Priority Queue to store the elements by the order of frequency in ascending.
// Remove the least frequent element from the set till k becomes zero.
// If K becomes less than zero, that means we have removed an extra element. Add that element back.
// Return the size of the set.
