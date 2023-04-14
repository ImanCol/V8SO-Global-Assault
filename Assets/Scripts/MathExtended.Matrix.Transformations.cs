using System;

namespace MathExtended.Matrices
{
    public partial class Matrix
    {
        public static Matrix Rotation2D(double angle)
        {
            double num = Math.PI * angle / 180.0;
            return new Matrix(2)
            {
                [1, 1] = Math.Cos(num),
                [1, 2] = 0.0 - Math.Sin(num),
                [2, 1] = Math.Sin(num),
                [2, 2] = Math.Cos(num)
            };
        }

        public static Matrix Rotation3DX(double angle)
        {
            double num = Math.PI * angle / 180.0;
            return new Matrix(3)
            {
                [1, 1] = 1.0,
                [1, 2] = 0.0,
                [1, 3] = 0.0,
                [2, 1] = 0.0,
                [2, 2] = Math.Cos(num),
                [2, 3] = 0.0 - Math.Sin(num),
                [3, 1] = 0.0,
                [3, 2] = Math.Sin(num),
                [3, 3] = Math.Cos(num)
            };
        }

        public static Matrix Rotation3DY(double angle)
        {
            double num = Math.PI * angle / 180.0;
            return new Matrix(3)
            {
                [1, 1] = Math.Cos(num),
                [1, 2] = 0.0,
                [1, 3] = Math.Sin(num),
                [2, 1] = 0.0,
                [2, 2] = 1.0,
                [2, 3] = 0.0,
                [3, 1] = 0.0 - Math.Sin(num),
                [3, 2] = 0.0,
                [3, 3] = Math.Cos(num)
            };
        }

        public static Matrix Rotation3DZ(double angle)
        {
            double num = Math.PI * angle / 180.0;
            return new Matrix(3)
            {
                [1, 1] = Math.Cos(num),
                [1, 2] = 0.0 - Math.Sin(num),
                [1, 3] = 0.0,
                [2, 1] = Math.Sin(num),
                [2, 2] = Math.Cos(num),
                [2, 3] = 0.0,
                [3, 1] = 0.0,
                [3, 2] = 0.0,
                [3, 3] = 1.0
            };
        }

        public static Matrix Scaling(double factor)
        {
            return Scaling(factor, factor, factor);
        }

        public static Matrix Scaling(double factorX, double factorY, double factorZ)
        {
            return new Matrix(3)
            {
                [1, 1] = factorX,
                [1, 2] = 0.0,
                [1, 3] = 0.0,
                [2, 1] = 0.0,
                [2, 2] = factorY,
                [2, 3] = 0.0,
                [3, 1] = 0.0,
                [3, 2] = 0.0,
                [3, 3] = factorZ
            };
        }

        public static Matrix Translation(double moveX, double moveY, double moveZ)
        {
            Matrix matrix = new Matrix(4);
            matrix[1, 1] = 1.0;
            matrix[1, 2] = 0.0;
            matrix[1, 3] = 0.0;
            matrix[1, 3] = moveX;
            matrix[2, 1] = 0.0;
            matrix[2, 2] = 1.0;
            matrix[2, 3] = 0.0;
            matrix[2, 4] = moveY;
            matrix[3, 1] = 0.0;
            matrix[3, 2] = 0.0;
            matrix[3, 3] = 1.0;
            matrix[3, 4] = moveZ;
            matrix[4, 1] = 0.0;
            matrix[4, 2] = 0.0;
            matrix[4, 3] = 0.0;
            matrix[4, 4] = 1.0;
            return matrix;
        }

    }
}
