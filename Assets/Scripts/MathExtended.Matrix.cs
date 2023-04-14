using System.Diagnostics;
using System.Text;

namespace MathExtended.Matrices
{
    [DebuggerDisplay("Matrix = {ToString()}")]
    public partial class Matrix
    {
        private double[,] _matrix;

        public int Rows => _matrix.GetLength(0);

        public int Columns => _matrix.GetLength(1);

        public bool IsSquare => Rows == Columns;

        public double this[int row, int column]
        {
            get
            {
                return _matrix[row - 1, column - 1];
            }
            set
            {
                _matrix[row - 1, column - 1] = value;
            }
        }

        public Matrix(int Rows, int Columns)
        {
            _matrix = new double[Rows, Columns];
        }

        public Matrix(int m)
            : this(m, m)
        {
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    stringBuilder.Append($"{_matrix[i, j]:N2}").Append(" ");
                }
                stringBuilder.Append(";");
            }
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }
    }
}
