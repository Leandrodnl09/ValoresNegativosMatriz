// Exercício do curso do Nélio Alves "Números negativos matriz"
// Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
// na tela somente os números negativos da matriz.
// Entrada:
// A entrada contém os números M e N na mesma linha, depois os dados da matriz.
// Saída:
// A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.


// Criação da Matriz;
string [] A = Console.ReadLine().Split(' ');
int M = int.Parse(A[0]);
int N = int.Parse(A[1]);

int [,] Mat = new int[M,N];

// Leitura dos dados;
for (int i = 0; i < M; i ++)
{
    string [] X = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j ++)
    {
        Mat[i, j] = int.Parse(X[j]);
    }
}

// Comando de saída;
Console.WriteLine("Valores negativos: ");

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j ++)
    {
        if (Mat[i, j] < 0)
        {
            Console.WriteLine(Mat[i, j]);
        }
    }
}

