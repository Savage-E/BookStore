using System;
using System.Windows.Forms;

namespace BookStore
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
            WinForm main = Owner as WinForm;
        }

        public string Title
        {
            get { return _TitleTbx.Text; }
            set { _TitleTbx.Text = value; }
        }

        public string Author
        {
            get { return _AuthorTbx.Text; }
            set { _AuthorTbx.Text = value; }
        }

        public string Category
        {
            get { return _CategoryTbx.Text; }
            set { _CategoryTbx.Text = value; }
        }

        public string Year
        {
            get { return _YearTbx.Text; }
            set { _YearTbx.Text = value; }
        }

        public string Price
        {
            get { return _PriceTbx.Text; }
            set { _PriceTbx.Text = value; }
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _addBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}