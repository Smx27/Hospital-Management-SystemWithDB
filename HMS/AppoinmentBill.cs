using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class AppoinmentBill : Form
    {
        public AppoinmentBill()
        {
            InitializeComponent();

        }
        string _docname;
        string _categorie;
        string _date;
        string _pname;
        string _contact;
        string _amount;
        public string Docname { get => _docname; set => _docname = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Date { get => _date; set => _date = value; }
        public string Pname { get => _pname; set => _pname = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Amount { get => _amount; set => _amount = value; }
        private void AppoinmentBill_Load(object sender, EventArgs e)
        {
            lblDate.Text = _date;
            lblPatientName.Text = _pname;
            LblDocCAte.Text = _categorie;
            GBDoctorDetails.Text = _docname;
            double am = Convert.ToDouble(_amount) * 0.05;
            lblAmount.Text =_amount;
            lblTotalAmount.Text = Convert.ToString(am);
        }
        #region Printing The Bill
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            //Creates A object of panel
            this.Controls.Add(panel);
            //add controlls to panel
            Graphics graphics = panel.CreateGraphics(); // Creating a Graphics pointing to pael
            Size size = this.ClientSize;//Desining a object of size pointing to clint size
             bitmap= new Bitmap(size.Width, size.Height, graphics); //Creating a bitmap means image with the hight and weidth
            graphics = Graphics.FromImage(bitmap);//It collect all graphical unit to the bitmap Or It copyy the form to bitmap
            Point point = PointToScreen(panel.Location);//Creating a point that point to the screen 
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);//It also copy items from screen

            printPreviewDialog.Document = printDocument;//Pointing the document to print document
            printPreviewDialog.ShowDialog();//This opensthe print priview dialogue
        }
        #endregion

    }
}
