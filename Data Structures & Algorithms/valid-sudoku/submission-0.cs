public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        // rows[i, num] = true se o num+1 já apareceu na i-ésima linha
        bool[,] rows = new bool[9, 9];
        // cols[j, num] = true se o num+1 já apareceu na j-ésima coluna
        bool[,] cols = new bool[9, 9];
        // boxes[b, num] = true se o num+1 já apareceu na b-ésima caixa 3×3
        bool[,] boxes = new bool[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];
                if (c == '.') 
                    continue;

                // Converte '1'→0, '9'→8
                int num = c - '1';

                // Índice da caixa 3×3 (0 a 8):
                int boxIndex = (i / 3) * 3 + (j / 3);

                // Se já vimos esse número na mesma linha, coluna ou caixa, é inválido:
                if (rows[i, num] || cols[j, num] || boxes[boxIndex, num])
                    return false;

                // Marca como visto:
                rows[i, num] = true;
                cols[j, num] = true;
                boxes[boxIndex, num] = true;
            }
        }

        return true;
    }
}
