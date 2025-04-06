namespace LeetCode;

// Você recebe um array de inteiros chamado `height` de tamanho n.
// Existem n linhas verticais desenhadas de forma que os dois pontos finais
// da i-ésima linha são (i, 0) e (i, height[i]).
//
// Encontre duas linhas que, junto com o eixo x, formem um contêiner que 
// consiga armazenar a maior quantidade de água possível.
//
// Retorne a quantidade máxima de água que esse contêiner pode armazenar.
//
// Observação: o contêiner não pode estar inclinado.
//
// Exemplo 1:
// Input: height = [1,8,6,2,5,4,8,3,7]
// Output: 49
// Explicação: As linhas verticais são representadas pelo array [1,8,6,2,5,4,8,3,7].
// Nesse caso, a maior área de água (seção azul) que o contêiner pode conter é 49.
public static class ContainerWithMostWater11
{
    public static int MaxArea(int[] height)
    {
        var leftPointer = 0;
        var rightPointer = height.Length - 1;
        
        var maxArea = 0;

        while (leftPointer < rightPointer)
        {
            var heightRect = Math.Min(height[leftPointer], height[rightPointer]);
            var widthRect = rightPointer - leftPointer;
            var area = heightRect * widthRect;
            maxArea = Math.Max(maxArea, area);

            if (height[leftPointer] < height[rightPointer])
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }
        
        return maxArea;
    }
}