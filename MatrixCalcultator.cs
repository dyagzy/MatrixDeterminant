﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArray
{
    public class MatrixCalcultator
    {
        
        public static void PromptUser()
        {

            /* Prompts the user to dtermine the dimension or rank of its array or Matrix and also generets the array*/

            try
            {

                Console.WriteLine("How many dimensionsal array do you want to have?" + "");
                int arrayDimension = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (arrayDimension > 1)
                {
                    Console.WriteLine("***************You are Welcome to Multi-Dimensiosnal Array/Matrix Generator**************");
                    Console.WriteLine();
                    Console.WriteLine( new string ('-', 120));
                    int rows;
                    int cols;
                    switch (arrayDimension)
                    {
                        case 2: //Generates a 2 -Dimensional Array

                            Console.WriteLine("You have entered {0}, so a {0} " + "- Dimensional Array in the format \"[a , b]\" will be generated for you", arrayDimension);
                            Console.WriteLine();
                            Console.WriteLine("Please enter the number of rows of your Matrix");
                            rows = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the number of columns of your Matrix");
                            cols = int.Parse(Console.ReadLine());
                            Console.WriteLine("You are about to generate a {0} " + "- Dimensional Array  of a {1} by {2} Matrix", arrayDimension, rows, cols);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("The following will prompt you to enter a total of {0} elements in the {1} by {2} Matrix", rows * cols, rows, cols);
                            Console.WriteLine();
                            double[,] array2D = new double[rows, cols];

                            /* Accepts each elements of the Matrix to be created from the user*/
                            int i, j = 0;
                            for ( i = 0; i < rows; i++)
                            {
                               
                                for (j = 0; j < cols; j++)
                                {
                                    Console.WriteLine("Please enter the elements in the  Matrix in the [{0} , {1}] ", i, j);
                                    array2D[i,j] = int.Parse(Console.ReadLine());
                                }
                            }

                            /* Prints to the Console the Matrix created by the User to the Console*/

                            Console.Write("The Matrix created is : ");
                            Console.WriteLine();
                            
                            for (i = 0; i < array2D.GetLength(0); i++)
                            {
                                for (j = 0; j < array2D.GetLength(1); j++)
                                {
                                    
                                    Console.Write("{0}  " , array2D[i, j]);
                                    
                                }
                                Console.WriteLine("\n");
                                

                            }
                            double elementCount = array2D.Length;
                            Console.WriteLine("Number of element in the array is : {0}", elementCount);
                            Console.WriteLine();
                            Console.Write("Your matrix is a {0} by {1} Matrix", rows , cols);
                            Console.WriteLine();
                            Console.WriteLine("Would you like to calculate its determinant?");
                            string deterAns = Console.ReadLine();
                            string ans = deterAns.ToLower();
                            if (ans =="yes")
                            {
                                if (elementCount == 4)
                                {
                                    Console.WriteLine();
                                    double determinant = MatrixDeterminant_2By2(array2D, rows, cols);
                                    Console.WriteLine(" The determinanat of the matrix above is {0} matrix   ", determinant);
                                    Console.ReadLine();
                                }
                                else if (elementCount == 9)
                                {
                                    Console.WriteLine();
                                    double determinant = MatrixDeterminant_3By3(array2D, rows, cols);
                                    Console.WriteLine(" The determinanat of the matrix above is {0} matrix   ", determinant);
                                    Console.ReadLine();
                                }
                                
                            }



                            if (!MatrixCalcultator.isSquaredMatrix(rows , cols))
                            {
                                Console.WriteLine("Your Matrix is not a Squared Matrix hence, you can not calculate its dtereminat");
                            }
                            {

                            }

                            Console.ReadLine();
                            if (rows > 1 && cols > 1)
                            {

                            }
                            Console.ReadLine();
                            break;

                        case 3: //Generates a 3 -Dimensional Array
                            Console.WriteLine("You have entered {0}, so a {0} " + "- Dimensional array in the format \"[a, b, c]\" will be generated for you", arrayDimension);
                            Console.WriteLine("Please enter the number of rows of your Matrix");
                            rows = int.Parse(Console.ReadLine());
                            break;

                        case 4: //Generates a 4 -Dimensional Array
                            Console.WriteLine("You have entered {0}, so a {0} " + "- Dimensional array in the format \"[a, b, c, d]\" will be generated for you", arrayDimension);

                            break;

                        case 5: //Generates a 5 -Dimensional Array
                            Console.WriteLine("You have entered {0}, so a {0} " + "- Dimensional array in the format \"[a, b, c, d, e]\" will be generated for you", arrayDimension);

                            break;

                        default:
                            break;
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Only a single dimension Array or Matrx can be genereted based on the number {0} that you entered", arrayDimension);
                    Console.ReadLine();

                }
                

               
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*Checks if the matrix is a square matrix*/
        public  static bool isSquaredMatrix( int rows, int cols)
        {
            return rows == cols;
       
        }

        public static double MatrixDeterminant_2By2(double [,] arr, int rows, int cols)
        {
            double det = 0.0;
            if (!MatrixCalcultator.isSquaredMatrix(rows, cols))
            {
                Console.WriteLine("Your Matrix is not a Squared Matrix hence, you can not calculate its dtereminant");
            }
            else
            {
                
               det = (arr[0, 0] * arr[1, 1]) - (arr[0, 1] * arr[1, 1]);
            }
            return det;
            
        }
        public static double MatrixDeterminant_3By3(double[,] arr, int rows, int cols)
        {
            double det = 0.0;
            if (!MatrixCalcultator.isSquaredMatrix(rows, cols))
            {
                Console.WriteLine("Your Matrix is not a Squared Matrix hence, you can not calculate its dtereminant");
            }
            else
            {
                double a = (arr[0, 0] * ((arr[1, 1] * arr[2, 2]) - (arr[1, 2] * arr[2, 1])));
                double b = (arr[0, 1] * ((arr[1, 0] * arr[2, 2]) - (arr[1, 2] * arr[2, 0])));
                double c = (arr[0, 2] * ((arr[1, 0] * arr[2, 1]) - (arr[1, 1] * arr[2, 0])));

                det = a - b + c;
            }
            return det;

        }

        public static void MatrixMulitplication()
        {

        }

        public static void MatrixAddition()
        {
            
        }
    }
}
