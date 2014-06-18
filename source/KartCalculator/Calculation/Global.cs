using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace KartCalculator.Calculation
{
    public class Global
    {
        public delegate void IntHandler(int val);
        public delegate void StrHandler(string val);

        public static string MsgTitleApp = "Ульяновский Государственный Технический Университет\nКафедра ПМИ\n2014 год";

        public static string MsgBaseFileError = "Начальный файл не загружен в систему";
        public static string MsgFrmMainTitle = "Выбор типа карт для контроля рассеяния. {0}";
        public static string MsgGenerationDone = "Генерация файлов прошла успешно. Файлов: ";
        public static string MsgDeterminant = "Определитель матрицы: ";

        //отображения массива чисел в элементе DataGridView
        public static void ShowArrayInDataGrid(double[,] data, DataGridView dgView)
        {
            while (dgView.Rows.Count > 0)
                dgView.Rows.RemoveAt(0);

            while (dgView.Columns.Count > 0)
                dgView.Columns.RemoveAt(0);

            for (var i = 1; i <= data.GetLength(0); i++)
            {
                dgView.Columns.Add("X" + i, "X" + i);
                dgView.Columns[i - 1].Width = 60;
            }
            dgView.Rows.Add(data.GetLength(1));

            for (var i = 0; i < dgView.Rows.Count; i++)
                dgView.Rows[i].HeaderCell.Value = (i + 1).ToString(CultureInfo.InvariantCulture);

            for (var i = 0; i < data.GetLength(0); i++)
                for (var j = 0; j < data.GetLength(1); j++)
                    dgView[i, j].Value = GetString(data[i, j]);
        }

        public static void ShowArrayInDataGrid(double[,,] data, int index, DataGridView dgView)
        {
            var arrShow = new double[data.GetLength(0), data.GetLength(1)];
            for (var i = 0; i < arrShow.GetLength(0); i++)
                for (var j = 0; j < arrShow.GetLength(1); j++)
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
            dgView.Columns[0].Width = 55;
            dgView.Rows.Add(data.GetLength(0));

            for (var i = 0; i < dgView.Rows.Count; i++)
                dgView.Rows[i].HeaderCell.Value = (i + 1).ToString(CultureInfo.InvariantCulture);

            for (var i = 0; i < data.GetLength(0); i++)
                dgView[0, i].Value = GetString(data[i]);
        }

        public static string GetString(double val)
        {
            if (val >= 0.001)
                return val.ToString("0.000");
            return val.ToString("0.00E+00");
        }

        public static string GetPathBaseDir(BaseParams baseParams)
        {
            try
            {
                return Path.Combine(
// ReSharper disable once AssignNullToNotNullAttribute
                    Path.GetDirectoryName(Application.ExecutablePath),
                    Path.GetFileNameWithoutExtension(baseParams.FilePath) + "-" +
                           baseParams.CntParams + "-" +
                           baseParams.WeightViborka + "-" +
                           baseParams.CntViborka);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
