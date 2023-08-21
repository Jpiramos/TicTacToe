using System;

namespace TicTacToe
{
    class Program
    {
        // Lista de inteiros (9) { 9 espacos do jogo }
        static int[] board = new int[9];
       

        static void Main(string[] args)
        { 
            //0 = area nao ocupada, 1 = player1, 2 = player2
            for (int i = 0; i < 9; i++) 
            {
                board[i] = 0;
            }
            int userTurn = -1;
            int ComputerTurn = -1;
            Random rand = new Random();

            while(checkForWinner() == 0)
            {
                //Nao permitir que o user sobreponha uma posicao ja ocupada
                while (userTurn == -1 || board[userTurn] != 0) 
                {
                    Console.WriteLine("Entre com a posição desejada (0 - 8): ");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("Posição escolhida: " + userTurn);

                }
                board[userTurn] = 1;

                //Nao permitir que o computer sobreponha uma posicao ja ocupada
                while (ComputerTurn == -1 || board[ComputerTurn]!= 0)
                {
                    ComputerTurn = rand.Next(8);
                    Console.WriteLine("Computador escolheu o número: " + ComputerTurn);
                }
                board[ComputerTurn] = 2;
                printBoard();
            }
            Console.WriteLine("Jogador "+ checkForWinner() + " é o vencedor !");

        }

        private static int checkForWinner()
        {
            // 0 se ninguem ganha, numero do jogador se ele ganha


            // primeira linha
            if (board[0]== board[1] && board[1] == board[2])
            {
                return board[0];
            }

            //segunda linha
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }

            //terceira linha
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }

            //primeira coluna
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }

            //segunda coluna
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }

            //terceira coluna
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }

            //primeira diagonal
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            //segunda diagonal
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }

            return 0;
        }

        private static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {

                if (board[i] == 0)
                {
                    Console.Write(".");

                }

                if (board[i] == 1)
                {
                    Console.Write("X");

                }

                if (board[i] == 2)
                {
                    Console.Write("O");

                }

                //Pular linha para formar a tabela 3x3
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }

            }

        }

    }

}
