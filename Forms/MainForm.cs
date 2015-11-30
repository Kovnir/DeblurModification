using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImageEditor;
using ImageRecovery.NonBlind;

namespace RecoveryModification
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поток, в котором происходит вся обработка.
        /// </summary>
        private Thread processingThread;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            sourcePictureBox.Image = Program.sourceImage;
            processingThread = new Thread(() =>
            {
                //разбываем изображения гакуссовым блюром 3х3
                SetStatus("Bluring...");
                ConvolutionFilter blur = Filters.Gaussian3x3BlurFilter;
                Image bluredImage = Program.sourceImage.FastConvolution(blur);
                ChangeImage(bluredPictureBox, bluredImage);
                //восстанавливаем инверсным фильтром
                SetStatus("Reconstucting...");
                Image reconstucted = InverseFiltering.Filtering(bluredImage, blur);
                ChangeImage(reconstructedPictureBox, reconstucted);
                //считаем отклонения
                SetStatus("Calculating color deviation...");
                double standardColorDeviationValue = Program.sourceImage.ColorDeviation(reconstucted);
                ChangeText(standardColorDeviation, standardColorDeviationValue.ToString());
                SetStatus("Calculating transition deviation...");
                double standardTransitionDeviationValue = Program.sourceImage.TransitionDeviation(reconstucted);
                ChangeText(standardTransitionDeviation, standardTransitionDeviationValue.ToString());
                //восстанавливаем млжифицированным алгоритмом
                SetStatus("Reconstucting by modified algorithm...");
                //расширяем изображение, чтобы результат свёртки не получился меньше
                Image expendedBluredImage = bluredImage.Expand((blur.filterMatrix.GetLength(0)-1)/2 + 1);
                //восстанавливаем дробные части интерполяцией
                double[,,] interpolated = expendedBluredImage.Interpolate();
                //восстанавливаем тем же алгоритмом, что и был (инверсная фильтрация)
                Image modifiedReconstucted = InverseFiltering.Filtering(interpolated, blur);
                ChangeImage(modifiedReconstructedPictureBox, modifiedReconstucted);
                //считаем отклонения
                SetStatus("Calculating color deviation...");
                double modifiedColorDeviationValue = Program.sourceImage.ColorDeviation(modifiedReconstucted);
                double colorDeviationPercents = Percents(standardColorDeviationValue, modifiedColorDeviationValue);
                ChangeText(modifiedColorDeviation, $"{modifiedColorDeviationValue} \t{colorDeviationPercents: 0.000}% better");
                SetStatus("Calculating transition deviation...");
                double modifiedTransitionDeviationValue = Program.sourceImage.TransitionDeviation(modifiedReconstucted);
                double transitionrDeviationPercents = Percents(standardTransitionDeviationValue, modifiedTransitionDeviationValue);
                ChangeText(modifiedTransitionDeviation, $"{modifiedTransitionDeviationValue} \t{transitionrDeviationPercents: 0.000}% better");
                //выводим статус: "Закончено"
                SetStatus("Complete!");
            });
            processingThread.Start();
        }

        /// <summary>
        /// Устанавливает статус в статус-бар.
        /// </summary>
        /// <param name="status">Новый статус.</param>
        private void SetStatus(string status)
        {
            toolStripStatusLabel.Text = "Status: " + status;
        }

        /// <summary>
        /// На сколько прочентов первое число больше второго.
        /// </summary>
        /// <returns></returns>
        private double Percents(double value1, double value2)
        {
            double percent = value1 / 100;
            return (value1 - value2) / percent;
        }
        /// <summary>
        /// Изменения текста на форме из любого потока.
        /// </summary>
        /// <param name="label">Метка, текст которой надо изменить</param>
        /// <param name="text">Новый текст</param>
        private void ChangeText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                Action<Label, string> callback = ChangeText;
                try
                {
                    Invoke(callback, new object[] { label, text });
                }
                catch
                {
                    // ignored
                }
            }
            else
            {
                label.Text = text;
            }
        }
        /// <summary>
        /// Изменения изоюражения на форме из любого потока.
        /// </summary>
        /// <param name="pictureBox">Picture box, изображение которого надо изменить.</param>
        /// <param name="image">Новое изображение.</param>
        private void ChangeImage(PictureBox pictureBox, Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                Action<PictureBox, Image> callback = ChangeImage;
                try
                {
                    Invoke(callback, new object[] { pictureBox, image });
                }
                catch
                {
                    // ignored
                }
            }
            else
            {
                pictureBox.Image = image;
            }
        }

        /// <summary>
        /// Forms the close.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void FormClose(object sender, FormClosedEventArgs e)
        {
            processingThread.Abort();
            Application.Exit();
        }

        /// <summary>
        /// Обработка события нажатия на изображение.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SaveImage(object sender, EventArgs e)
        {
            StartForm.SaveImage(((PictureBox)sender).Image);
        }

        /// <summary>
        /// Обработка нажатия на кнопку выбора нового изображения.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ChooseNewImage(object sender, EventArgs e)
        {
            processingThread.Abort();
            Program.startForm.Show();
            Hide();
        }
    }
}
