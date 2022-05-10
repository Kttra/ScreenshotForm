# ScreenshotForm
C# program that screenshots whatever is on top of the panel in a winform (uses .NET 6). Created because there are a lot of programs online that show how to screenshot a computer's desktop, but there's not much information on how to screenshot in a winform specifically. Knowing how to screenshot specific regions in a winform is powerful as it allows us to archive data.

This program uses the Control.Draggable nuget package in order to make the controls in the form draggable. You can drag around the buttons, combo box, check box, button, label, textbox, and colored panel. The program can screenshot any changes you made. Once you are ready to take a screenshot, add in a name in the textbox on the bottom and press on the screenshot button.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/167539360-f7a9fe22-6ef1-4555-afc1-66b039e6d9a3.png"><img>
</p>

**Screenshot**
----------------
Below is the image outputted ny the program itself. By default, the image is saved as a bmp file (a Bitmap image file). In the code, I have provided examples of how to change it to save as a jpg or png file instead as those are more common image types that are likely to be more compatible with other software.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/167540275-08da3b0f-7118-4be3-8d03-d38f9fbb6070.png"><img>
</p>

**Other Methods**
----------------
Although this program is mainly focused on capturing an image in a panel, I have decided to include other screenshot methods. In the source code, there is a method to screenshot your desktop screen, a method to draw the desktop image to a winform picture box, and a method to screenshot the entire form. Below is a summary of what types of methods are included in this project.
- Panel Capture
- Screen to Picture Box
- Form Capture
- Desktop Capture

```csharp
private void Screenshot()
{
    //Hide this form and temporarily pause for 1 second
    this.Hide();
    System.Threading.Thread.Sleep(1000);

    //Creating a new Bitmap object
    Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

    //Creating a Rectangle object which will capture our screen
    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

    //Creating a New Graphics Object
    Graphics captureGraphics = Graphics.FromImage(bmp);

    //Copying Image from The Screen
    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

    //Saving the Image File
    bmp.Save(@"Screenshot" + ImageName.Text + ".bmp");

    //Display the form again
    this.Show();
}
```
