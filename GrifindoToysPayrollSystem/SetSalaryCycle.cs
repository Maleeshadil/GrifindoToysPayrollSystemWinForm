using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class SetSalaryCycle : Form
    {
        //Create Rounded Coner Form 

        //Fields
        private int borderRadius = 10;

        private int borderSize = 2;

        private Color borderColor = Color.MediumSeaGreen;
        

        public SetSalaryCycle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.PanelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void GetSalaryReport_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

       

        private void GetSalaryReport_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void GetSalaryReport_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void GetSalaryReport_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(PanelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }
               

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CheckValidationErrors())
            {
                return;
            }
            else
            {
                OverallSalarySummary.startDate = tbSDate.Text;
                OverallSalarySummary.endDate = tbEDate.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

           

        }
        //Validates the input fields and displays an error message if the input is invalid
        private void ValidateInput(TextBox textBox, Label errorLabel, Func<string, bool> validateMethod, string errorMessage)
        {
            // Continuously validate the input until it meets the validation criteria
            while (!validateMethod(textBox.Text))
            {
                // Display the error message and set focus back to the TextBox
                errorLabel.Visible = true;

                errorLabel.Text = errorMessage;

                textBox.Focus();
                return;
            }


        }

        //Validation methods for "Date" input fields, using the ValidateInput method
        private void txtSDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbSDate, lbIsValidSDate, Validator.IsValidDate, "Invalid date format.please enter in this format(MM/dd/yyyy)");
        }

        private void tbEDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbEDate, lbIsValidEDate, Validator.IsValidDate, "Invalid date format.please enter in this format(MM/dd/yyyy)");
        }

        // Handles TextChanged events for "Date input fields,
        //dynamically updating corresponding error labels by hiding them when the input is modified or corrected
        private void tbSDate_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidSDate.Text != "")
            {
                lbIsValidSDate.Visible = false;
                return;
            }
        }

        private void tbEDate_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidEDate.Text != "")
            {
                lbIsValidEDate.Visible = false;
                return;
            }
        }
        private void SetSalaryCycle_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckValidationErrors()
        {
            // List of label-textbox pairs to check validation
            var validationControls = new List<(Label, TextBox)>
            {
                (lbIsValidSDate,tbSDate), 
                (lbIsValidEDate,tbEDate),

            };

            foreach (var (errorLabel, textBox) in validationControls)
            {
                // If an error label is visible, there's an error
                if (errorLabel.Visible)
                {
                    MessageBox.Show("Please correct the highlighted errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return true; // Stop further execution
                }
            }

            return false; // No validation errors
        }
    }
}
    

