namespace BookStore
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._TitleTbx = new System.Windows.Forms.TextBox();
            this._AuthorTbx = new System.Windows.Forms.TextBox();
            this._CategoryTbx = new System.Windows.Forms.TextBox();
            this._PriceTbx = new System.Windows.Forms.TextBox();
            this._YearTbx = new System.Windows.Forms.TextBox();
            this._titleLbl = new System.Windows.Forms.Label();
            this._authorLbl = new System.Windows.Forms.Label();
            this._categoryLbl = new System.Windows.Forms.Label();
            this._priceLbl = new System.Windows.Forms.Label();
            this._yearLbl = new System.Windows.Forms.Label();
            this._addBtn2 = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._noteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _TitleTbx
            // 
            this._TitleTbx.Location = new System.Drawing.Point(122, 122);
            this._TitleTbx.Name = "_TitleTbx";
            this._TitleTbx.Size = new System.Drawing.Size(188, 26);
            this._TitleTbx.TabIndex = 0;
            // 
            // _AuthorTbx
            // 
            this._AuthorTbx.Location = new System.Drawing.Point(122, 174);
            this._AuthorTbx.Name = "_AuthorTbx";
            this._AuthorTbx.Size = new System.Drawing.Size(188, 26);
            this._AuthorTbx.TabIndex = 1;
            // 
            // _CategoryTbx
            // 
            this._CategoryTbx.Location = new System.Drawing.Point(122, 229);
            this._CategoryTbx.Name = "_CategoryTbx";
            this._CategoryTbx.Size = new System.Drawing.Size(188, 26);
            this._CategoryTbx.TabIndex = 2;
            // 
            // _PriceTbx
            // 
            this._PriceTbx.Location = new System.Drawing.Point(122, 278);
            this._PriceTbx.Name = "_PriceTbx";
            this._PriceTbx.Size = new System.Drawing.Size(188, 26);
            this._PriceTbx.TabIndex = 3;
            // 
            // _YearTbx
            // 
            this._YearTbx.Location = new System.Drawing.Point(122, 326);
            this._YearTbx.Name = "_YearTbx";
            this._YearTbx.Size = new System.Drawing.Size(188, 26);
            this._YearTbx.TabIndex = 4;
            // 
            // _titleLbl
            // 
            this._titleLbl.Location = new System.Drawing.Point(12, 122);
            this._titleLbl.Name = "_titleLbl";
            this._titleLbl.Size = new System.Drawing.Size(72, 26);
            this._titleLbl.TabIndex = 5;
            this._titleLbl.Text = "Книга";
            // 
            // _authorLbl
            // 
            this._authorLbl.Location = new System.Drawing.Point(12, 177);
            this._authorLbl.Name = "_authorLbl";
            this._authorLbl.Size = new System.Drawing.Size(72, 26);
            this._authorLbl.TabIndex = 6;
            this._authorLbl.Text = "Автор";
            // 
            // _categoryLbl
            // 
            this._categoryLbl.Location = new System.Drawing.Point(12, 229);
            this._categoryLbl.Name = "_categoryLbl";
            this._categoryLbl.Size = new System.Drawing.Size(104, 26);
            this._categoryLbl.TabIndex = 7;
            this._categoryLbl.Text = "Категория";
            // 
            // _priceLbl
            // 
            this._priceLbl.Location = new System.Drawing.Point(12, 281);
            this._priceLbl.Name = "_priceLbl";
            this._priceLbl.Size = new System.Drawing.Size(72, 26);
            this._priceLbl.TabIndex = 8;
            this._priceLbl.Text = "Цена";
            // 
            // _yearLbl
            // 
            this._yearLbl.Location = new System.Drawing.Point(12, 326);
            this._yearLbl.Name = "_yearLbl";
            this._yearLbl.Size = new System.Drawing.Size(72, 61);
            this._yearLbl.TabIndex = 9;
            this._yearLbl.Text = "Год";
            // 
            // _addBtn2
            // 
            this._addBtn2.Location = new System.Drawing.Point(52, 370);
            this._addBtn2.Name = "_addBtn2";
            this._addBtn2.Size = new System.Drawing.Size(109, 57);
            this._addBtn2.TabIndex = 10;
            this._addBtn2.Text = "Добавить";
            this._addBtn2.UseVisualStyleBackColor = true;
            this._addBtn2.Click += new System.EventHandler(this._addBtn2_Click);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Location = new System.Drawing.Point(201, 370);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(109, 57);
            this._cancelBtn.TabIndex = 11;
            this._cancelBtn.Text = "Отмена";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // _noteLbl
            // 
            this._noteLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._noteLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._noteLbl.Location = new System.Drawing.Point(341, 121);
            this._noteLbl.Name = "_noteLbl";
            this._noteLbl.Size = new System.Drawing.Size(107, 126);
            this._noteLbl.TabIndex = 12;
            this._noteLbl.Text = "Замечание:Если авторов несколько, используйте \";\"";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this._noteLbl);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._addBtn2);
            this.Controls.Add(this._yearLbl);
            this.Controls.Add(this._priceLbl);
            this.Controls.Add(this._categoryLbl);
            this.Controls.Add(this._authorLbl);
            this.Controls.Add(this._titleLbl);
            this.Controls.Add(this._YearTbx);
            this.Controls.Add(this._PriceTbx);
            this.Controls.Add(this._CategoryTbx);
            this.Controls.Add(this._AuthorTbx);
            this.Controls.Add(this._TitleTbx);
            this.Name = "InsertForm";
            this.Text = "Добавление / Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TitleTbx;
        private System.Windows.Forms.TextBox _AuthorTbx;
        private System.Windows.Forms.TextBox _CategoryTbx;
        private System.Windows.Forms.TextBox _PriceTbx;
        private System.Windows.Forms.TextBox _YearTbx;
        private System.Windows.Forms.Label _titleLbl;
        private System.Windows.Forms.Label _authorLbl;
        private System.Windows.Forms.Label _categoryLbl;
        private System.Windows.Forms.Label _priceLbl;
        private System.Windows.Forms.Label _yearLbl;
        private System.Windows.Forms.Button _addBtn2;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.Label _noteLbl;
    }
}