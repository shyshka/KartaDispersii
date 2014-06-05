using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    class Global
    {
        public static string msgNotWorking = "Модуль еще не работает";
        public static string msgFrmMainTitle = "Выбор типа карт для контроля рассеяния. Файл: ";
        public static string msgGenerationDone = "Генерация файлов прошла успешно. Файлов: ";

        //отображения массива чисел в элементе DataGridView
        public static void ShowArrayInDataGrid(double[,] data, DataGridView dgView)
        {
            while (dgView.Rows.Count > 0)
                dgView.Rows.RemoveAt(0);

            while (dgView.Columns.Count > 0)
                dgView.Columns.RemoveAt(0);

            for (int i = 1; i <= data.GetLength(0); i++)
            {
                dgView.Columns.Add("X" + i.ToString(), "X" + i.ToString());
                dgView.Columns[i - 1].Width = 60;
            }
            dgView.Rows.Add(data.GetLength(1));

            for (int i = 0; i < dgView.Rows.Count; i++)
                dgView.Rows[i].HeaderCell.Value = (i + 1).ToString();

            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] >= 0.001)
                        dgView[i, j].Value = data[i, j].ToString("0.000");
                    else
                        dgView[i, j].Value = data[i, j].ToString("0.00E+00");
                }
        }

        public static void ShowArrayInDataGrid(double[, ,] data, int index, DataGridView dgView)
        {
            double[,] arrShow = new double[data.GetLength(0), data.GetLength(1)];
            for (int i = 0; i < arrShow.GetLength(0); i++)
                for (int j = 0; j < arrShow.GetLength(1); j++)
                    arrShow[i, j] = data[i, j, index];

            ShowArrayInDataGrid(arrShow, dgView);
        }

        public static void ShowArrayInDataGrid(double[] data, DataGridView dgView)
        {
            while (dgView.Rows.Count > 0)
                dgView.Rows.RemoveAt(0);

            while (dgView.Columns.Count > 0)
                dgView.Columns.RemoveAt(0);

            dgView.Columns.Add("Значение", "Значение");
            dgView.Columns[0].Width = 60;
            dgView.Rows.Add(data.GetLength(0));

            for (int i = 0; i < dgView.Rows.Count; i++)
                dgView.Rows[i].HeaderCell.Value = (i + 1).ToString();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i] >= 0.001)
                    dgView[0, i].Value = data[i].ToString("0.000");
                else
                    dgView[0, i].Value = data[i].ToString("0.00E+00");
            }
        }
    }
}
