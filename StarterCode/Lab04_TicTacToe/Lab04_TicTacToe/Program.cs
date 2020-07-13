﻿using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            Console.WriteLine("Player one: Please enter your name: ");
            string playerOne = Console.ReadLine();
            Console.WriteLine("Player two: Please enter your name: ");
            string playerTwo = Console.ReadLine();

            InstantiateGame(playerOne, playerTwo);

            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }

        static void InstantiateGame(string p1, string p2)
        {
            Player playerOne = new Player();
            playerOne.Name = p1;
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Name = p2;
            playerTwo.Marker = "O";

            Game newGame = new Game(playerOne, playerTwo);

            Player winner = newGame.Play();


            if (!(winner is null))
            {
                Console.WriteLine($"{winner.Name} Wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }


    }

