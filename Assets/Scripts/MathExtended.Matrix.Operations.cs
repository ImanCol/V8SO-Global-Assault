using System;

namespace MathExtended.Matrices
{
    public partial class Matrix
    {
        public void Multiply(Matrix Matrix)
        {
            if (Columns != Matrix.Rows)
            {
                throw new InvalidOperationException("Cannot multiply matrices of different sizes.");
            }
            double[,] array = new double[Rows, Matrix.Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Matrix.Columns; j++)
                {
                    double num = 0.0;
                    for (int k = 0; k < Columns; k++)
                    {
                        num += _matrix[i, k] * Matrix[k + 1, j + 1];
                    }
                    array[i, j] = num;
                }
            }
            _matrix = array;
        }

        public void HadamardProduct(Matrix Matrix)
        {
            if (Columns != Matrix.Columns || Rows != Matrix.Rows)
            {
                throw new InvalidOperationException("Cannot multiply matrices of different sizes.");
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    _matrix[i, j] *= Matrix[i + 1, j + 1];
                }
            }
        }

        public void Multiply(double Scalar)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] *= Scalar;
                }
            }
        }

        public void Add(Matrix Matrix)
        {
            if (Rows != Matrix.Rows || Columns != Matrix.Columns)
            {
                throw new InvalidOperationException("Cannot add matrices of different sizes.");
            }
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] += Matrix[i + 1, j + 1];
                }
            }
        }

        public void Sub(Matrix Matrix)
        {
            if (Rows != Matrix.Rows || Columns != Matrix.Columns)
            {
                throw new InvalidOperationException("Cannot sub matrices of different sizes.");
            }
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] -= Matrix[i + 1, j + 1];
                }
            }
        }

        public void Inverse()
        {
            if (!IsSquare)
            {
                throw new InvalidOperationException("Only square matrices can be inverted.");
            }
            int rows = Rows;
            double[,] array = _matrix.Clone() as double[,];
            double[,] array2 = _matrix.Clone() as double[,];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array2[i, j] = ((i == j) ? 1.0 : 0.0);
                }
            }
            for (int k = 0; k < rows; k++)
            {
                double num = array[k, k];
                for (int l = 0; l < rows; l++)
                {
                    array[k, l] /= num;
                    array2[k, l] /= num;
                }
                for (int m = 0; m < rows; m++)
                {
                    if (k != m)
                    {
                        num = array[m, k];
                        for (int n = 0; n < rows; n++)
                        {
                            array[m, n] -= num * array[k, n];
                            array2[m, n] -= num * array2[k, n];
                        }
                    }
                }
            }
            _matrix = array2;
        }

        public void Transpose()
        {
            double[,] array = new double[Columns, Rows];
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    array[j, i] = _matrix[i, j];
                }
            }
            _matrix = array;
        }

        public void Map(Func<double, double> func)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = func(_matrix[i, j]);
                }
            }
        }

        public void Randomize(double lowest, double highest)
        {
            Random random = new Random();
            double num = highest - lowest;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = random.NextDouble() * num + lowest;
                }
            }
        }

        public void Randomize()
        {
            Randomize(0.0, 1.0);
        }

        public Matrix Duplicate()
        {
            Matrix matrix = new Matrix(Rows, Columns);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i + 1, j + 1] = _matrix[i, j];
                }
            }
            return matrix;
        }
    }
}
