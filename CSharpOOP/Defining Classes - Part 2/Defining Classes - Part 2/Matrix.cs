namespace Defining_Classes___Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Matrix<T>
        where T: struct
    {
        public T[,] Array { get; set; }

        public Matrix(T[,] matrix)
        {
            this.Array = matrix;
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            CheckMatrixes(firstMatrix, secondMatrix);
            
            T[,] resultMatrix = new T[firstMatrix.Array.GetLength(0), firstMatrix.Array.GetLength(1)];

            for (int row = 0; row < firstMatrix.Array.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.Array.GetLength(1); col++)
                {
                    resultMatrix[row, col] = Addition<T>(firstMatrix.Array[row, col], secondMatrix.Array[row, col]);
                }
            }

            return new Matrix<T>(resultMatrix);
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            CheckMatrixes(firstMatrix, secondMatrix);

            T[,] resultMatrix = new T[firstMatrix.Array.GetLength(0), firstMatrix.Array.GetLength(1)];

            for (int row = 0; row < firstMatrix.Array.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.Array.GetLength(1); col++)
                {
                    resultMatrix[row, col] = Subtraction<T>(firstMatrix.Array[row, col], secondMatrix.Array[row, col]);
                }
            }

            return new Matrix<T>(resultMatrix);
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Array.GetLength(1) != secondMatrix.Array.GetLength(0))
            {
                throw new FormatException();
            }

            T[,] resultMatrix = new T[firstMatrix.Array.GetLength(0), secondMatrix.Array.GetLength(1)];

            for (int row = 0; row < firstMatrix.Array.GetLength(0); row++)
            {
                for (int col = 0; col < secondMatrix.Array.GetLength(1); col++)
                {
                    T sum = default(T);
                    for (int count = 0; count < firstMatrix.Array.GetLength(1); count++)
                    {
                        T countSum = Addition(firstMatrix.Array[row, count + firstMatrix.Array.GetLength(1)]
                            , secondMatrix.Array[count, col + secondMatrix.Array.GetLength(1)]);
                        sum = Addition<T>(sum, countSum);
                    }
                    resultMatrix[row, col + secondMatrix.Array.GetLength(1)] = sum;
                }
            }

            return new Matrix<T>(resultMatrix);
        }

        private static T Addition<D>(D a, D b)
            where D: struct
        {
            return (dynamic)a + (dynamic)b;
        }

        private static T Subtraction<D>(D a, D b)
            where D : struct
        {
            return (dynamic)a - (dynamic)b;
        }

        private static void CheckMatrixes(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Array.GetLength(0) != secondMatrix.Array.GetLength(0) ||
                firstMatrix.Array.GetLength(1) != secondMatrix.Array.GetLength(1))
            {
                throw new FormatException();
            }
        }

        public T this[int row, int col]
        {
            get
            {
                this.CheckIndexes(row, col);
                return this.Array[row, col];
            }

            set
            {
                this.CheckIndexes(row, col);
                this.Array[row, col] = value;
            }
        }

        private void CheckIndexes(int row, int col)
        {
            if (row < 0 || row >= this.Array.GetLength(0) ||
                col < 0 || col >= this.Array.GetLength(1))
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
