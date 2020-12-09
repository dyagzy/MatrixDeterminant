//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MatrixArray
//{

//    /* Exercise one -----
//         Write  C# program to obtain the determinatnt of this 4 dimensional array int [ , , ,]  myArray = new int [3,4,2,3]
        
//         */

//    /* Exercise two -----
//     Using  the determinant above, generate result of the above squaredWrite  
//    C# program to obtain the determinatnt of this 4 dimensional array int [ , , ,] myArray = new int [3,4,2,3] i.e find the square if the 
//    matrix in one abive

//     */
//    class MatrixArray
//    {
//        public static void GeneratedArray()
//        {

//            Console.WriteLine("How many dimensionsal array do you want to have?" + "");
//            int arrayDimension = int.Parse(Console.ReadLine());
//            int n = 0;
//            int m = 0;
//            double temp = 0;
//            double[,,,] multiple = new double[3, 4, 2, 3];

//            try
//            {

//                double[ , , , ] myArray = new double[3, 4, 2, 3]
//                {
//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}},

//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}},

//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}}


//                };


//                double[,,,] myArray2 = new double[3, 4, 2, 3]
//               {
//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}},

//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}},

//                    {{{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }},
//                    {{23,45,0 }, {23,45,0 }}}


//               };
//                Console.WriteLine(myArray.GetLength(0));
//                Console.WriteLine(myArray2.GetLength(1)-1);
//                if (myArray.GetLength(0) == myArray2.GetLength(1))
//                {
//                    Console.WriteLine("The two array is valid and can be multiplied together");
                    
                    
//                }
//                else
//                {
//                    for (int row = 0; row < myArray.GetLength(0); row++)
//                    {
//                        for (int col = 0; col < myArray2.GetLength(1) - 1; col++)
//                        {
//                            temp = 0;
//                            for (int k = 0; k < multiple.GetLength(1); k++)
//                            {
//                                temp += myArray[n, m, row, k] * myArray2[n, m, k, col];


//                            }
//                            multiple = temp
//                        }
//                    }
//                }


//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            Console.ReadLine();


//        }

     
       
//    }
//}
