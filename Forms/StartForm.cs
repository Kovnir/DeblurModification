using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ImageEditor;

namespace RecoveryModification
{
    /// <summary>
    /// Форма выбора изображения
    /// </summary>
    public partial class StartForm : Form
    {
        /// <summary>
        /// Максимальный размер стороны уменьшенного изображения.
        /// </summary>
        private const int MAX_SIZE = 100;

        /// <summary>
        /// Initializes a new instance of the <see cref="StartForm"/> class.
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Окно выбора изображения.
        /// </summary>
        /// <returns>Выбронное изображение</returns>
        public static Image LoadImage()
        {
            Image image;
            OpenFileDialog ofd = new OpenFileDialog();          //попросим указать месторасположения файла
            ofd.Filter = "Images|*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() != DialogResult.OK)            //если не указано
                return null;                                         //уходим
            try
            {
                image = Image.FromFile(ofd.FileName);          //иначе пытаемся грузить картинку
            }
            catch                                               //если не удалось - сообщим об этом
            {
                MessageBox.Show("Не удалось загрузить изображение", "Loading exeption");
                return null;
            }
            return image;                                       //вернём изображение
        }

        /// <summary>
        /// Окно сохранения изоюбражения.
        /// </summary>
        /// <param name="image">Изображение, которое надо сохранить.</param>
        public static void SaveImage(Image image)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                image.Save(sfd.FileName, format);
            }
        }

        /// <summary>
        /// Запускает обработку.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartProcessing(object sender, EventArgs e)
        {
            if (previewPictureBox.Image == null)
            {
                Browse();
                if (previewPictureBox.Image != null)
                    ShowMainForm();
            }
            else
                ShowMainForm();
        }

        /// <summary>
        /// Показывает главную форму.
        /// </summary>
        private void ShowMainForm()
        {
            Program.sourceImage = previewPictureBox.Image;
            if (!originalSizeCheckBox.Checked)
                if (Program.sourceImage.Width > MAX_SIZE || Program.sourceImage.Height > MAX_SIZE)
                    if (Program.sourceImage.Width > Program.sourceImage.Height)
                        Program.sourceImage = Program.sourceImage.Scale(MAX_SIZE, MAX_SIZE * Program.sourceImage.Height/ Program.sourceImage.Width);
                    else
                        Program.sourceImage = Program.sourceImage.Scale(MAX_SIZE * Program.sourceImage.Width/ Program.sourceImage.Height, MAX_SIZE);
            MainForm maneForm = new MainForm();
            maneForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Выбор изображения.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Browse(object sender = null, EventArgs e = null)
        {
            previewPictureBox.Image = LoadImage();
            if (previewPictureBox.Image != null)
                sizeText.Text = $"{previewPictureBox.Image.Height}x{previewPictureBox.Image.Width}";
            else
                sizeText.Text = "?x?";
        }
    }
}
