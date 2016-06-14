namespace Homework
{
    using System;

    public class Matrix<T>           //tasks 8,9,10
        where T : struct,
                  IComparable,
                  IComparable<T>,
                  IConvertible,
                  IEquatable<T>,
                  IFormattable
    {
        private T[,] matrix;

        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.matrix = new T[this.Rows, this.Columns];
        }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if ((first.Rows != second.Rows) && (first.Columns != second.Columns))
            {
                throw new ArgumentException("Not a valid matrix sizes to get the Sum");
            }

            var Sum = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    try
                    {
                        dynamic firstElement = first[row, col];
                        dynamic secondElement = second[row, col];

                        Sum[row, col] = firstElement + secondElement;
                    }
                    catch (Exception x)
                    {

                        throw x;
                    }
                }
            }
            return Sum;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if ((first.Rows != second.Rows) && (first.Columns != second.Columns))
            {
                throw new ArgumentException("Not a valid matrix sizes to get the difference");
            }

            var difference = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    try
                    {
                        dynamic firstElement = first[row, col];
                        dynamic secondElement = second[row, col];

                        difference[row, col] = firstElement - secondElement;
                    }
                    catch (Exception x)
                    {
                        throw x;
                    }
                }
            }
            return difference;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Columns != second.Rows)
            {
                throw new ArgumentException("Not a valid matrix sizes to get the product");
            }

            var product = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    dynamic sum = 0;

                    try
                    {
                        for (int position = 0; position < first.Columns; position++)
                        {
                            dynamic firstElement = first[row, position];
                            dynamic secondElement = second[position, col];

                            sum += firstElement * secondElement;
                        }
                    }
                    catch (Exception x)
                    {
                        throw x;
                    }

                    product[row, col] = sum;
                }
            }

            return product;
        }

        public static bool operator true(Matrix<T> M)
        {

            var output = true;

            for (int row = 0; row < M.Rows; row++)
            {
                for (int col = 0; col < M.Columns; col++)
                {
                    dynamic value = M[row, col];

                    if (value == 0)
                    {
                        output = false;
                    }
                }
            }

            return output;
        }

        public static bool operator false(Matrix<T> M)
        {
            var output = false;

            for (int row = 0; row < M.Rows; row++)
            {
                for (int col = 0; col < M.Columns; col++)
                {
                    dynamic value = M[row, col];

                    if (value == 0)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }



        public override string ToString()
        {
            string output =String.Empty;
            for (int row = 0; row < this.Rows; row++)
            {
                output += "| ";
                for (int col = 0; col < this.Columns; col++)
                {
                    output+= this.matrix[row, col]+" | ";
                }
                output += "\n";
             
            }

            return output;
        }
    }
}
