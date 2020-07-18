﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		/// <summary>
		/// DisplayBoard Method - Outputs the game board visually onto the console per turn
		/// </summary>
		public void DisplayBoard()
		{

			//TODO: Output the board to the console

			Console.WriteLine($"{GameBoard[0, 0]} | {GameBoard[0, 1]} | {GameBoard[0, 2]}");
			Console.WriteLine($"{GameBoard[1, 0]} | {GameBoard[1, 1]} | {GameBoard[1, 2]}");
			Console.WriteLine($"{GameBoard[2, 0]} | {GameBoard[2, 1]} | {GameBoard[2, 2]}");

		}
	}
}
