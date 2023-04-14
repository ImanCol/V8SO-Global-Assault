using System;

namespace MathExtended.Matrices
{
    public partial class Matrix
    {
        private void Zero()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = 0.0;
                }
            }
        }

        private void Identity()
        {
            if (!IsSquare)
            {
                throw new InvalidOperationException("Identity matrix must be square.");
            }
            Zero();
            for (int i = 0; i < Rows; i++)
            {
                _matrix[i, i] = 1.0;
            }
        }

        public static Matrix Zero(int size)
        {
            Matrix matrix = new Matrix(size);
            matrix.Zero();
            return matrix;
        }

        public static Matrix Zero(int rows, int cols)
        {
            Matrix matrix = new Matrix(rows, cols);
            matrix.Zero();
            return matrix;
        }

        public static Matrix Identity(int size)
        {
            Matrix matrix = new Matrix(size);
            matrix.Identity();
            return matrix;
        }

        public static Matrix Vandermonde(int rows, int cols)
        {
            Matrix matrix = new Matrix(rows, cols);
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    matrix[i, j] = Math.Pow(i, j - 1);
                }
            }
            return matrix;
        }
    }
}
