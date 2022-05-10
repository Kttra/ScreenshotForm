//Using package Control.Draggable
namespace ScreenshotForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Allows the controls to be draggable
            ControlExtension.Draggable(button1, true);
            ControlExtension.Draggable(comboBox1, true);
            ControlExtension.Draggable(checkBox1, true);
            ControlExtension.Draggable(button1, true);
            ControlExtension.Draggable(label1, true);
            ControlExtension.Draggable(textBox1, true);
            ControlExtension.Draggable(panel1, true);
        }

        private void BtnScreenshot_Click(object sender, EventArgs e)
        {
            using Bitmap bmp = new Bitmap(ScreenPanel.Width, ScreenPanel.Height);
            ScreenPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //Save location to images folder: @"/images", by default we will save at executable directory
            bmp.Save(@"" + ImageName.Text + ".bmp");

            //If you want to save as jpg or png
            //bmp.Save(@"" + ImageName.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //bmp.Save(@"a" + ImageName.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

            MessageBox.Show("Image saved.", "Success");
        }

    }
}