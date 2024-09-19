using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class JogoDaVelha
{
    private char[,] tabuleiro; // vai ser a parte da matriz visual tabulheiro
    private char jogadorAtual;

    public JogoDaVelha()
    {
        tabuleiro = new char[3, 3];
        jogadorAtual = 'X'; //X vai começar o jogo
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        // numeros
        int cont = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = cont.ToString()[0];
                cont++;
            }
        }
    }

    public void ExibirTabuleiro()
    {
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }

    public bool FazerJogada(int posicao)
    {
        int row = (posicao - 1) / 3;
        int col = (posicao - 1) % 3;

        if (tabuleiro[row, col] != 'X' && tabuleiro[row, col] != 'O')
        {
            tabuleiro[row, col] = jogadorAtual;
            return true;
        }
        return false;
    }

    public bool VerificarVitoria()
    {
        //diagonal
        for (int i = 0; i < 3; i++)
        {
            if ((tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2]) || // Linhas
                (tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i]))  // Colunas
            {
                return true;
            }
        }

        // diagonal
        if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2]) ||
            (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0]))
        {
            return true;
        }

        return false;
    }

    public bool VerificarEmpate()
    {
        foreach (char posicao in tabuleiro)
        {
            if (posicao != 'X' && posicao != 'O')
            {
                return false;
            }
        }
        return true;
    }

    public void AlternarJogador()
    {
        jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
    }

    public char JogadorAtual()
    {
        return jogadorAtual;
    }
}

