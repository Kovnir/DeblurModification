using System;
using System.Windows.Forms;
using System.Drawing;

/// <summary>
/// Программа демонстрации модификации алгоритма восстановки изображения
/// </summary>
namespace RecoveryModification
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Исходное изображение
        /// </summary>
        public static Image sourceImage;
        /// <summary>
        /// Ссылка на начальную форму
        /// </summary>
        public static StartForm startForm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            Application.Run(startForm);
        }
    }
}
