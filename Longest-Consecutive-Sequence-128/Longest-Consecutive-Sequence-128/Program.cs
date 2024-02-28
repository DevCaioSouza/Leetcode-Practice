//128.Longest Consecutive Sequence
//Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

//You must write an algorithm that runs in O(n) time.
//Example 1:

//Input: nums = [100, 4, 200, 1, 3, 2]
//Output: 4
//Explanation: The longest consecutive elements sequence is [1, 2, 3, 4].Therefore its length is 4.

// Sugestão de algoritmo:
// 1 - Criar uma hash table vazia
// 2- Inserir todos os elementos do array no hash table
// 3- faça isso para cada arr[i]
// 4 - checar se esse elemento é um ponto de partida da subsequência. Para isso, procure por " arr[i] - 1 ". Se nada for encontrado
//	então esse é o primeiro elemento de uma subsequência
// 5 - Se esse elemento é o primeiro elemento, então conte o numero de elementos consecutivos a partir desse elemento. 
//	Iterar desde arr[i] + 1 até o último elemento encontrado
// 6 - se a contagem é maior do que a mais longa subsequência previamente encontrada, então atualize a contagem


static int LongestConsecutive(int[] nums)
{
	int Longest = 0;

	if (nums.Length == 0) return 0;

	// a escolha do HashSet é para que os elementos duplicados de nums só apareçam uma vez no HashSet
	var Set = new HashSet<int>(nums);

	foreach (var number in Set)
	{

		// aqui checamos se esse número é um potencial início de sequência. obviamente se houver algum
		// número anterior (ele - 1) a ele no HashSet ele não pode ser o início de uma sequência.
		if (!Set.Contains(number - 1))
		{
			var Length = 1;
			var Element = number;

			// aqui verificamos se existe algum número consecutivo ao "Element"
			while (Set.Contains(Element + 1))
			{
				Length++;
				Element++;
			}

			// Atualizando o tamanho da sequência de maior número de elementos
			Longest = Math.Max(Longest, Length);
		}
	}
	return Longest;
}

Console.WriteLine(LongestConsecutive([100, 4, 200, 1, 3, 2]));

// Complexidade para essa solução
// Time complexity: O(n)
// Construir o HashSet tem complexidade O(n), sendo n o número de elementos do array

// Iteramos por cada elemento do hashset uma única vez. No loop, performamos operações "time-constant" pra cada potencial
// início de sequência e potencialmente iterar sobre números consecutivos a esse. A complexidade desse loop é O(n)
// sendo n o número de elementos do hashset 

// Combinar ambos hashset construção e iteração, a complexidade geral é O(n)

// Space complexity: O(n)
// Criamos um hashset com o propósito de salvar os elementos "únicos" vindos do array de entrada.
// A complexidade espacial de construir o hashset é O(n), sendo n o numero de elementos do array de entrada

// Além do hashset, o espaço adicional usado pelo algoritmo é constante. Usamos algumas variáveis extras como Longest,
// Length, Element e os iteradores de loops, que não dependem do tamanho do array de entrada (nums)
// Portanto, a complexidade geral do esquema seria de O(n), devido à implementação do hashset