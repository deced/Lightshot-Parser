namespace LightShot
{
    partial class Main
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.StartUrlTb = new System.Windows.Forms.TextBox();
            this.GoodLabel = new System.Windows.Forms.Label();
            this.ParserProgressPb = new System.Windows.Forms.ProgressBar();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.UrlTypeComBox = new System.Windows.Forms.ComboBox();
            this.MaskDataLabel = new System.Windows.Forms.Label();
            this.DeletedLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseFolderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StartUrlTb
            // 
            this.StartUrlTb.Location = new System.Drawing.Point(93, 6);
            this.StartUrlTb.Name = "StartUrlTb";
            this.StartUrlTb.Size = new System.Drawing.Size(116, 20);
            this.StartUrlTb.TabIndex = 3;
            this.StartUrlTb.Tag = "";
            this.StartUrlTb.Click += new System.EventHandler(this.tbUrl_Click);
            this.StartUrlTb.Leave += new System.EventHandler(this.tbUrl_Leave);
            // 
            // GoodLabel
            // 
            this.GoodLabel.AutoSize = true;
            this.GoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GoodLabel.Location = new System.Drawing.Point(12, 34);
            this.GoodLabel.Name = "GoodLabel";
            this.GoodLabel.Size = new System.Drawing.Size(0, 15);
            this.GoodLabel.TabIndex = 5;
            // 
            // ParserProgressPb
            // 
            this.ParserProgressPb.Location = new System.Drawing.Point(12, 161);
            this.ParserProgressPb.Maximum = 1296;
            this.ParserProgressPb.Name = "ParserProgressPb";
            this.ParserProgressPb.Size = new System.Drawing.Size(285, 23);
            this.ParserProgressPb.Step = 1;
            this.ParserProgressPb.TabIndex = 6;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorsLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorsLabel.Location = new System.Drawing.Point(12, 50);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorsLabel.TabIndex = 7;
            // 
            // UrlTypeComBox
            // 
            this.UrlTypeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrlTypeComBox.FormattingEnabled = true;
            this.UrlTypeComBox.Items.AddRange(new object[] {
            "https://prnt.sc/XXXXXO",
            "https://prnt.sc/XXXXOO",
            "https://prnt.sc/XXXOOO",
            "https://prnt.sc/XXOOOO",
            "https://prnt.sc/XOOOOO",
            "https://prnt.sc/OOOOOO"});
            this.UrlTypeComBox.Location = new System.Drawing.Point(15, 110);
            this.UrlTypeComBox.Name = "UrlTypeComBox";
            this.UrlTypeComBox.Size = new System.Drawing.Size(154, 21);
            this.UrlTypeComBox.TabIndex = 8;
            this.UrlTypeComBox.SelectedIndexChanged += new System.EventHandler(this.UrlTypeComBox_SelectedIndexChanged);
            // 
            // MaskDataLabel
            // 
            this.MaskDataLabel.AutoSize = true;
            this.MaskDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskDataLabel.Location = new System.Drawing.Point(12, 134);
            this.MaskDataLabel.Name = "MaskDataLabel";
            this.MaskDataLabel.Size = new System.Drawing.Size(10, 15);
            this.MaskDataLabel.TabIndex = 9;
            this.MaskDataLabel.Text = " ";
            // 
            // DeletedLabel
            // 
            this.DeletedLabel.AutoSize = true;
            this.DeletedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DeletedLabel.Location = new System.Drawing.Point(12, 67);
            this.DeletedLabel.Name = "DeletedLabel";
            this.DeletedLabel.Size = new System.Drawing.Size(0, 15);
            this.DeletedLabel.TabIndex = 10;
            // 
            // ChooseFolderBtn
            // 
            this.ChooseFolderBtn.Location = new System.Drawing.Point(215, 3);
            this.ChooseFolderBtn.Name = "ChooseFolderBtn";
            this.ChooseFolderBtn.Size = new System.Drawing.Size(82, 23);
            this.ChooseFolderBtn.TabIndex = 11;
            this.ChooseFolderBtn.Text = "Выбор папки";
            this.ChooseFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseFolderBtn.Click += new System.EventHandler(this.ChooseFolderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Маска ссылки";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(215, 31);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(82, 23);
            this.CancelBtn.TabIndex = 14;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 195);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseFolderBtn);
            this.Controls.Add(this.DeletedLabel);
            this.Controls.Add(this.MaskDataLabel);
            this.Controls.Add(this.UrlTypeComBox);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.ParserProgressPb);
            this.Controls.Add(this.GoodLabel);
            this.Controls.Add(this.StartUrlTb);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = " Lightshot Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox StartUrlTb;
        private System.Windows.Forms.Label GoodLabel;
        private System.Windows.Forms.ProgressBar ParserProgressPb;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.ComboBox UrlTypeComBox;
        private System.Windows.Forms.Label MaskDataLabel;
        private System.Windows.Forms.Label DeletedLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button ChooseFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBtn;
    }
}

