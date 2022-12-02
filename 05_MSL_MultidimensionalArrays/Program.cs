using System;
using System.Collections.Generic;
using System.Text;

namespace ARRAYS_MSLEARN{

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Building a bidimensional array...");
            BidimensionalArray(3, 3);
            
            Console.WriteLine("Building a tridimensional array...");
            TridimensionalArray(3, 3, 2);
        }

        static void BidimensionalArray(int columns, int rows){
            int[,] arr = new int[columns, rows];
            int columns_index, rows_index;

            for(columns_index = 0; columns_index < columns; columns_index++){

                for(rows_index = 0; rows_index < rows; rows_index++){
                    arr[columns_index, rows_index] = 0;
                    Console.Write("|" + arr[columns_index, rows_index]);
                }
                Console.Write("| \n");

            }
        }

        static void TridimensionalArray(int columns, int rows, int tridim){
            int[, ,] arr = new int[columns, rows, tridim];
            int columns_index, rows_index, tridim_index;
            int k = 3;

            for(tridim_index = 0; tridim_index < tridim; tridim_index++){
                Console.WriteLine($"Superimposed matriz index [{tridim_index}]");

                for(columns_index = 0; columns_index < columns; columns_index++){

                    for(rows_index = 0; rows_index < rows; rows_index++){
                        arr[columns_index, rows_index, tridim_index] = k;
                        Console.Write("|" + arr[columns_index, rows_index, tridim_index]);
                    }
                    Console.Write("| \n");

                }
                Console.WriteLine();
                k++;
            }
        }
    }

}