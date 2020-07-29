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
            get { return _TitleTbx.Text.Trim(); }
            set { _TitleTbx.Text = value.Trim(); }
        }

        public string Author
        {
            get { return _AuthorTbx.Text.Trim(); }
            set { _AuthorTbx.Text = value.Trim(); }
        }

        public string Category
        {
            get { return _CategoryTbx.Text.Trim(); }

            set { _CategoryTbx.Text = value.Trim(); }
        }

        public string Year
        {
            get { return _YearMaskedTbx.Text.Trim(); }
            set { _YearMaskedTbx.Text =  value.Trim(); }
        }

        public string Price
        {
            get { return _priceTbx.Text.Trim(' '); }
            set { _priceTbx.Text = value.Trim(); }
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _addBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _priceTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                               && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}