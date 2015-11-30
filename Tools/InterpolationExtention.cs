using System;
using System.Drawing;
using ImageEditor;

namespace RecoveryModification
{
    /// <summary>
    /// Класс, реализующий восстановление дробной части, потерянной при округлении.
    /// </summary>
    public static class InterpolationExtention
    {
        /// <summary>
        /// Додумывание дробной части для матрицы.
        /// </summary>
        /// <param name="data">Исходный массив.</param>
        /// <returns>Результирующий массив</returns>
        private static double[,] FractionalPartRestoration(double[,] data)
        {
            int height = data.GetLength(0);
            int width = data.GetLength(1);
            double[,] newData = new double[height, width];
            double[,] newHorizontalData = data.Clone() as double[,];
            double[,] newVerticalData = data.Clone() as double[,];
            Func<double, double, double, double> Interpolate = (pre, current, next) =>
            {
                double newValue = (pre + next) / 2;

                if (newValue >= current + 0.5)
                    return current + 0.4999999;
                if (newValue < current - 0.5)
                    return current - 0.5;
                return newValue;
            };

            for (int i = 0; i < height; i++)
                for (int j = 1; j < width - 1; j++)
                    newHorizontalData[i, j] = Interpolate(newHorizontalData[i, j - 1], newHorizontalData[i, j], newHorizontalData[i, j + 1]);

            for (int i = 1; i < height - 1; i++)
                for (int j = 0; j < width; j++)
                    newVerticalData[i, j] = Interpolate(newVerticalData[i - 1, j], newVerticalData[i, j], newVerticalData[i + 1, j]);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    newData[i, j] = (newVerticalData[i, j] + newHorizontalData[i, j]) / 2;

            return newData;
        }

        /// <summary>
        /// Додумывание дробной части для изображения, представленного в виде матриц трёх каналов.
        /// </summary>
        /// <param name="data">Исходный массив.</param>
        /// <returns>Результирующий массив</returns>
        private static double[,,] FractionalPartRestoration(double[,,] data)
        {
            double[,] blue = new double[data.GetLength(0), data.GetLength(1)];
            double[,] green = new double[data.GetLength(0), data.GetLength(1)];
            double[,] red = new double[data.GetLength(0), data.GetLength(1)];
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    blue[i, j] = data[i, j, 0];
                    green[i, j] = data[i, j, 1];
                    red[i, j] = data[i, j, 2];
                }
            blue = FractionalPartRestoration(blue);
            green = FractionalPartRestoration(green);
            red = FractionalPartRestoration(red);
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j, 0] = blue[i, j];
                    data[i, j, 1] = green[i, j];
                    data[i, j, 2] = red[i, j];
                }
            return data;

        }

        /// <summary>
        /// Перевод изображения в три матрицы для каждого канала с восстановленной дробной частью.
        /// </summary>
        /// <param name="source">Исходне изображение.</param>
        /// <returns>Результирующий массив</returns>
        public static double[,,] Interpolate(this Image source)
        {
            double[] data = Converter.ToDoubleArray(source);
            int height = source.Height;
            int width = source.Width;
            double[,,] interpolateMatrix = new double[height, width, 3];
            int index = 0;
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    interpolateMatrix[i, j, 0] = data[index + 0];//blue channel
                    interpolateMatrix[i, j, 1] = data[index + 1];//green channel
                    interpolateMatrix[i, j, 2] = data[index + 2];//red channel
                    index += 4;
                }
            return FractionalPartRestoration(interpolateMatrix);
        }
    }
}
