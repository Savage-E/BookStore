using System;
using System.Windows.Forms;

namespace BookStore
{
    partial class WinForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._OpenXmlBtn = new System.Windows.Forms.Button();
            this.Год = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Автор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Книга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this._SaveXmlBtn = new System.Windows.Forms.Button();
            this._AddBtn = new System.Windows.Forms.Button();
            this._DeleteBtn = new System.Windows.Forms.Button();
            this._ReportHtmlBtn = new System.Windows.Forms.Button();
            this._editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _OpenXmlBtn
            // 
            this._OpenXmlBtn.BackColor = System.Drawing.Color.Gold;
            this._OpenXmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._OpenXmlBtn.ForeColor = System.Drawing.Color.Transparent;
            this._OpenXmlBtn.Location = new System.Drawing.Point(174, 77);
            this._OpenXmlBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._OpenXmlBtn.Name = "_OpenXmlBtn";
            this._OpenXmlBtn.Size = new System.Drawing.Size(170, 45);
            this._OpenXmlBtn.TabIndex = 1;
            this._OpenXmlBtn.Text = "Открыть XML";
            this._OpenXmlBtn.UseVisualStyleBackColor = false;
            this._OpenXmlBtn.Click += new System.EventHandler(this._OpenXmlBtn_Click);
            // 
            // Год
            // 
            this.Год.DataPropertyName = "year";
            this.Год.HeaderText = "Год";
            this.Год.MinimumWidth = 8;
            this.Год.Name = "Год";
            this.Год.ReadOnly = true;
            this.Год.Width = 150;
            // 
            // Цена
            // 
            this.Цена.DataPropertyName = "price";
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 8;
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            this.Цена.Width = 150;
            // 
            // Категория
            // 
            this.Категория.DataPropertyName = "category";
            this.Категория.HeaderText = "Категория";
            this.Категория.MinimumWidth = 8;
            this.Категория.Name = "Категория";
            this.Категория.ReadOnly = true;
            this.Категория.Width = 150;
            // 
            // Автор
            // 
            this.Автор.DataPropertyName = "author";
            this.Автор.HeaderText = "Автор";
            this.Автор.MinimumWidth = 8;
            this.Автор.Name = "Автор";
            this.Автор.ReadOnly = true;
            this.Автор.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Автор.Width = 150;
            // 
            // Книга
            // 
            this.Книга.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Книга.DataPropertyName = "title";
            this.Книга.HeaderText = "Книга";
            this.Книга.MinimumWidth = 8;
            this.Книга.Name = "Книга";
            this.Книга.ReadOnly = true;
            this.Книга.Width = 114;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Книга,
            this.Автор,
            this.Категория,
            this.Цена,
            this.Год});
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DataGridView.Location = new System.Drawing.Point(174, 142);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Size = new System.Drawing.Size(717, 335);
            this.DataGridView.TabIndex = 0;
            // 
            // _SaveXmlBtn
            // 
            this._SaveXmlBtn.BackColor = System.Drawing.Color.Tomato;
            this._SaveXmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._SaveXmlBtn.ForeColor = System.Drawing.Color.White;
            this._SaveXmlBtn.Location = new System.Drawing.Point(371, 77);
            this._SaveXmlBtn.Name = "_SaveXmlBtn";
            this._SaveXmlBtn.Size = new System.Drawing.Size(170, 45);
            this._SaveXmlBtn.TabIndex = 2;
            this._SaveXmlBtn.Text = "Сохранить XML";
            this._SaveXmlBtn.UseVisualStyleBackColor = false;
            this._SaveXmlBtn.Click += new System.EventHandler(this._SaveXmlBtn_Click);
            // 
            // _AddBtn
            // 
            this._AddBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this._AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._AddBtn.ForeColor = System.Drawing.Color.White;
            this._AddBtn.Location = new System.Drawing.Point(174, 485);
            this._AddBtn.Name = "_AddBtn";
            this._AddBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._AddBtn.Size = new System.Drawing.Size(170, 64);
            this._AddBtn.TabIndex = 3;
            this._AddBtn.Text = "Добавить запись";
            this._AddBtn.UseVisualStyleBackColor = false;
            this._AddBtn.Click += new System.EventHandler(this._AddBtn_Click);
            // 
            // _DeleteBtn
            // 
            this._DeleteBtn.BackColor = System.Drawing.Color.Black;
            this._DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._DeleteBtn.ForeColor = System.Drawing.Color.White;
            this._DeleteBtn.Location = new System.Drawing.Point(727, 485);
            this._DeleteBtn.Name = "_DeleteBtn";
            this._DeleteBtn.Size = new System.Drawing.Size(170, 64);
            this._DeleteBtn.TabIndex = 4;
            this._DeleteBtn.Text = "Удалить запись";
            this._DeleteBtn.UseVisualStyleBackColor = false;
            this._DeleteBtn.Click += new System.EventHandler(this._DeleteBtn_Click);
            // 
            // _ReportHtmlBtn
            // 
            this._ReportHtmlBtn.BackColor = System.Drawing.Color.Chartreuse;
            this._ReportHtmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ReportHtmlBtn.ForeColor = System.Drawing.Color.White;
            this._ReportHtmlBtn.Location = new System.Drawing.Point(727, 77);
            this._ReportHtmlBtn.Name = "_ReportHtmlBtn";
            this._ReportHtmlBtn.Size = new System.Drawing.Size(164, 45);
            this._ReportHtmlBtn.TabIndex = 5;
            this._ReportHtmlBtn.Text = "Отчет в HTML";
            this._ReportHtmlBtn.UseVisualStyleBackColor = false;
            this._ReportHtmlBtn.Click += new System.EventHandler(this._ReportHtmlBtn_Click);
            // 
            // _editBtn
            // 
            this._editBtn.BackColor = System.Drawing.Color.Gray;
            this._editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._editBtn.ForeColor = System.Drawing.Color.White;
            this._editBtn.Location = new System.Drawing.Point(441, 485);
            this._editBtn.Name = "_editBtn";
            this._editBtn.Size = new System.Drawing.Size(170, 64);
            this._editBtn.TabIndex = 6;
            this._editBtn.Text = "Редактировать";
            this._editBtn.UseVisualStyleBackColor = false;
            this._editBtn.Click += new System.EventHandler(this._editBtn_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this._editBtn);
            this.Controls.Add(this._ReportHtmlBtn);
            this.Controls.Add(this._DeleteBtn);
            this.Controls.Add(this._AddBtn);
            this.Controls.Add(this._SaveXmlBtn);
            this.Controls.Add(this._OpenXmlBtn);
            this.Controls.Add(this.DataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WinForm";
            this.Text = "Учет книг";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button _OpenXmlBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
        private System.Windows.Forms.DataGridViewTextBoxColumn Автор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Книга;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button _SaveXmlBtn;
        private System.Windows.Forms.Button _AddBtn;
        private System.Windows.Forms.Button _DeleteBtn;
        private System.Windows.Forms.Button _ReportHtmlBtn;
        private System.Windows.Forms.Button _editBtn;
    }
}

