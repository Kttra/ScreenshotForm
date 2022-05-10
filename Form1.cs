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
            CapturePanel();

            //If you want to screenshot your copmuter screen call Screenshot();

            MessageBox.Show("Image saved.", "Success");
        }
        //Capture the winform panel
        private void CapturePanel()
        {
            using Bitmap bmp = new Bitmap(ScreenPanel.Width, ScreenPanel.Height);
            ScreenPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //Save location to images folder: @"/images", by default we will save at executable directory
            bmp.Save(@"" + ImageName.Text + ".bmp");

            //If you want to save as jpg or png
            //bmp.Save(@"" + ImageName.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //bmp.Save(@"a" + ImageName.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }
        //Screenshot to a picture box
        private void ScreenToBox()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //Creating a New Graphics Object
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Copying Image from The Screen
                g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            }

            //If you have a picture box in the form
            //PictureBox1.Image = Bitmap;
        }
        //Screenshot your computer screen
        private void DesktopScreenshot()
        {
            //Hide this form and temporarily pause for 1 second
            this.Hide();
            System.Threading.Thread.Sleep(1000);

            //Creating a new Bitmap object
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //Creating a Rectangle object which will capture our screen
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            //Creating a New Graphics Object
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Copying Image from The Screen
                g.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            }

            //Saving the Image File
            bmp.Save(@"PC" + ImageName.Text + ".bmp");

            //Display the form again
            this.Show();
        }
        //Screenshot the entire form (window)
        private void ScreenshotForm()
        {
            var form = Form.ActiveForm;
            using (var bmp = new Bitmap(form.Width, form.Height))
            {
                form.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"FormScreenshot.png");
            }
        }
    }
}
