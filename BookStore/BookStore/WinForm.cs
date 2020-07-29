using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace BookStore
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void _OpenXmlBtn_Click(object sender, EventArgs e)
        {
            DataGridView.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;

            OpenFileDialog openFile = new OpenFileDialog();
            DataGridView.Rows.Clear();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                try
                {
                    xDoc.Load(openFile.FileName);
                    // Get root element.
                    XmlElement xRoot = xDoc.DocumentElement;
                    int n;
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Attributes.Count > 0)
                        {
                            n = DataGridView.Rows.Add();
                            //Get attributed node: "category"
                            XmlNode attr = xnode.Attributes.GetNamedItem("category");
                            if (attr != null)
                                DataGridView.Rows[n].Cells[2].Value = attr.Value;
                            //Get childnodes of the current node.
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "year")
                                    DataGridView.Rows[n].Cells[4].Value = childnode.InnerText;

                                if (childnode.Name == "price")

                                    DataGridView.Rows[n].Cells[3].Value = childnode.InnerText;
                                if (childnode.Name == "title")
                                {
                                    DataGridView.Rows[n].Cells[0].Value = childnode.InnerText;
                                }
                                if (childnode.Name == "author")
                                {
                                    if (DataGridView.Rows[n].Cells[1].Value != null)
                                        DataGridView.Rows[n].Cells[1].Value += ";" + childnode.InnerText;
                                    else DataGridView.Rows[n].Cells[1].Value = childnode.InnerText;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла!");
                }
            }
        }

        private void _SaveXmlBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!saveFile.FileName.Contains(".xml"))
                    saveFile.FileName += ".xml";
                SaveXml(saveFile.FileName);
            }
        }
        /// <summary>
        /// Saving XML file to the needded path
        /// </summary>
        /// <param name="filepath">Path of </param>
        private void SaveXml(string filepath)
        {
            XDocument xDoc = new XDocument(new XDeclaration("1.0", "utf-8", null));
            //Create xml file.
            XElement bookstore = new XElement("bookstore");
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                //Create book node.
                XElement xElement = new XElement("book");
                //Create attribute element.
                XAttribute bookCategoryAttr = new XAttribute("category", DataGridView.Rows[i].Cells[2].Value.ToString());
                XElement bookTitleElem = new XElement("title", DataGridView.Rows[i].Cells[0].Value);
                xElement.Add(bookTitleElem);
                //Array of authors.
                string[] names = DataGridView.Rows[i].Cells[1].Value.ToString().Split(';');
                int lengthNames = names.Length;

                XElement[] bookAuthorElems = new XElement[lengthNames];

                for (int j = 0; j < lengthNames; j++)
                {
                    bookAuthorElems[j] = new XElement("author", names[j]);
                    xElement.Add(bookAuthorElems[j]);
                }
                //Create last nodes.
                XElement bookYearElem = new XElement("year", DataGridView.Rows[i].Cells[4].Value);
                XElement bookpriceElem = new XElement("price", DataGridView.Rows[i].Cells[3].Value);
                //Add nodes to the element.
                xElement.Add(bookCategoryAttr);
                xElement.Add(bookYearElem);
                xElement.Add(bookpriceElem);

                //Add to root node.
                bookstore.Add(xElement);
            }
            //Add root element to whole document.
            xDoc.Add(bookstore);

            xDoc.Save(filepath);
        }

        private void _AddBtn_Click(object sender, EventArgs e)
        {
            InsertForm f = new InsertForm();
            //Link annex form to main one.
            f.Owner = this;
            f.ShowDialog();
            //If user presses "Отмена", do nothing.
            if (f.ActiveControl.Text != "Отмена")
            {
                AddingData(f, -1);
            }
        }

        private void _editBtn_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста");
            }
            else
            {
                //Get selected row.
                int index = DataGridView.CurrentRow.Index;

                InsertForm f = new InsertForm();
                f.Owner = this;

                //Add data from DataGridView to InsertForm.
                f.Title = (string)DataGridView.Rows[index].Cells[0].Value;
                f.Author = (string)DataGridView.Rows[index].Cells[1].Value;
                f.Category = (string)DataGridView.Rows[index].Cells[2].Value;
                f.Price = (string)DataGridView.Rows[index].Cells[3].Value;
                f.Year = (string)DataGridView.Rows[index].Cells[4].Value;
                f.ShowDialog();

                AddingData(f, index);
            }
        }
        /// <summary>
        /// Adding and editing data in DataGridView
        /// </summary>
        /// <param name="f">InsertForm</param>
        /// <param name="index">edited row</param>
        private void AddingData(InsertForm f, int index)
        {
            DataGridView.AllowUserToAddRows = false;

            int n;

            if (index < 0)
            {
                n = DataGridView.Rows.Count;

                DataGridView.Rows.Add();
            }
            else
            {
                int columnsCount = DataGridView.Columns.Count;
                n = index;
                for (int i = 0; i < columnsCount; i++)
                {
                    DataGridView.Rows[n].Cells[i].Value = "";
                }
            }

            DataGridView.Rows[n].Cells[0].Value = f.Title;
            DataGridView.Rows[n].Cells[1].Value = f.Author;
            DataGridView.Rows[n].Cells[2].Value = f.Category;
            if (!f.Price.Contains("."))
                DataGridView.Rows[n].Cells[3].Value = f.Price + ".00";
            else
            DataGridView.Rows[n].Cells[3].Value = f.Price;
            DataGridView.Rows[n].Cells[4].Value = f.Year;
        }
        /// <summary>
        /// Deleting needded row
        /// </summary>
        /// <param name="index">Index of selected row</param>
        private void DeleteRecord(int index)
        {
            DataGridView.Rows.RemoveAt(index);
        }

        private void _DeleteBtn_Click(object sender, EventArgs e)
        {
            //Check whether rows are empty, otherwise delete the selected row.
            if (DataGridView.Rows.Count == 0)
                MessageBox.Show("Таблица пуста!");
            else
            {
                //Get selected rows and then delete it.
                int index = DataGridView.CurrentRow.Index;

                DeleteRecord(index);
            }
        }

        private void _ReportHtmlBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TransformXMLToHTML(openFile.FileName, "rex.xsl");
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла!");
                }
            }
        }

        /// <summary>
        /// Transforming XML to  HTML.
        /// </summary>
        /// <param name="inputXml">Transformed XML file</param>
        /// <param name="xsltString">XSLT file</param>
        private void TransformXMLToHTML(string inputXml, string xsltString)
        {
            MessageBox.Show("Выберите путь для сохранения отчета в html");
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltString);

            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!saveFile.FileName.Contains(".html"))
                        saveFile.FileName += ".html";

                    // Execute the transform and output the results to a file.
                    xslt.Transform(inputXml, saveFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла!");
                }
            }
        }
    }
}