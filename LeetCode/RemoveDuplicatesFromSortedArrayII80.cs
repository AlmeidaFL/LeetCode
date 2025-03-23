namespace LeetCode;

public class RemoveDuplicatesFromSortedArrayII80
{
    public static int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length <= 2) return nums.Length; // Se já tiver 2 ou menos elementos, retorna o tamanho.

        int index = 2; // Começamos da posição 2 porque os dois primeiros sempre podem ficar.

        for (int i = 2; i < nums.Length; i++) {
            if (nums[i] != nums[index - 2]) { // Só aceita se for diferente do elemento duas posições atrás.
                nums[index] = nums[i]; // Substitui na posição válida.
                index++; // Move o índice válido para frente.
            }
        }
    
        return index; // O novo tamanho da array válida.
    }
}