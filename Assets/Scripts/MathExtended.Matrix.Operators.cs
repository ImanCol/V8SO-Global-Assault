using System;
using System.Text;

namespace MathExtended.Matrices
{
    public partial class Matrix
    {
        #region Overloaded operators
        public static Matrix operator ~(Matrix matrix)
        {
            Matrix matrix2 = matrix.Duplicate();
            matrix2.Transpose();
            return matrix2;
        }

        public static Matrix operator !(Matrix matrix)
        {
            Matrix matrix2 = matrix.Duplicate();
            matrix2.Inverse();
            return matrix2;
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix matrix = first.Duplicate();
            matrix.Add(second);
            return matrix;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix matrix = first.Duplicate();
            matrix.Sub(second);
            return matrix;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix matrix = first.Duplicate();
            matrix.Multiply(second);
            return matrix;
        }

        public static Matrix operator *(Matrix matrix, double scalar)
        {
            Matrix matrix2 = matrix.Duplicate();
            matrix2.Multiply(scalar);
            return matrix2;
        }

        public static Matrix operator *(double scalar, Matrix matrix)
        {
            Matrix matrix2 = matrix.Duplicate();
            matrix2.Multiply(scalar);
            return matrix2;
        }

        public static bool operator ==(Matrix first, Matrix second)
        {
            bool flag = first.Rows == second.Rows && first.Columns == second.Columns;
            if (flag)
            {
                for (int i = 1; i <= first.Rows; i++)
                {
                    for (int j = 1; j <= first.Columns; j++)
                    {
                        flag &= (first[i, j] == second[i, j]);
                    }
                }
            }
            return flag;
        }

        public static bool operator !=(Matrix first, Matrix second)
        {
            bool flag = first.Rows != second.Rows || first.Columns != second.Columns;
            if (!flag)
            {
                for (int i = 1; i <= first.Rows; i++)
                {
                    for (int j = 1; j <= first.Columns; j++)
                    {
                        flag |= (first[i, j] != second[i, j]);
                    }
                }
            }
            return flag;
        }

        public static bool operator >(Matrix first, Matrix second)
        {
            return first.Rows * first.Columns > second.Rows * second.Columns;
        }

        public static bool operator <(Matrix first, Matrix second)
        {
            return first.Rows * first.Columns < second.Rows * second.Columns;
        }

        public static bool operator >=(Matrix first, Matrix second)
        {
            return first.Rows * first.Columns >= second.Rows * second.Columns;
        }

        public static bool operator <=(Matrix first, Matrix second)
        {
            return first.Rows * first.Columns <= second.Rows * second.Columns;
        }

        public override bool Equals(object obj)
        {
            Matrix matrix = obj as Matrix;
            if (obj == null)
            {
                return false;
            }
            bool flag = Rows == matrix.Rows && Columns == matrix.Columns;
            if (flag)
            {
                for (int i = 1; i <= Rows; i++)
                {
                    for (int j = 1; j <= Columns; j++)
                    {
                        flag &= (this[i, j] == matrix[i, j]);
                    }
                }
            }
            return flag;
        }

        public override int GetHashCode()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Rows).Append("x").Append(Columns)
                .Append("=");
            for (int i = 1; i <= Rows; i++)
            {
                for (int j = 1; j <= Columns; j++)
                {
                    stringBuilder.Append(this[i, j]).Append(";");
                }
            }
            return stringBuilder.ToString().GetHashCode();
        }
        #endregion
    }
}
