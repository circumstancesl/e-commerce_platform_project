namespace Catalog
{
    partial class Catalog
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
            this.ContentList = new System.Windows.Forms.ListBox();
            this.CorzineButton = new System.Windows.Forms.Button();
            this.AddInCorzineButton = new System.Windows.Forms.Button();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ContentList
            // 
            this.ContentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentList.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentList.FormattingEnabled = true;
            this.ContentList.ItemHeight = 28;
            this.ContentList.Location = new System.Drawing.Point(13, 77);
            this.ContentList.Name = "ContentList";
            this.ContentList.Size = new System.Drawing.Size(429, 756);
            this.ContentList.TabIndex = 0;
            // 
            // CorzineButton
            // 
            this.CorzineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CorzineButton.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorzineButton.Location = new System.Drawing.Point(13, 11);
            this.CorzineButton.Name = "CorzineButton";
            this.CorzineButton.Size = new System.Drawing.Size(161, 58);
            this.CorzineButton.TabIndex = 1;
            this.CorzineButton.Text = "Корзина";
            this.CorzineButton.UseVisualStyleBackColor = true;
            this.CorzineButton.Click += new System.EventHandler(this.CorzineButton_Click);
            // 
            // AddInCorzineButton
            // 
            this.AddInCorzineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInCorzineButton.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInCorzineButton.Location = new System.Drawing.Point(180, 11);
            this.AddInCorzineButton.Name = "AddInCorzineButton";
            this.AddInCorzineButton.Size = new System.Drawing.Size(253, 58);
            this.AddInCorzineButton.TabIndex = 3;
            this.AddInCorzineButton.Text = "Добавить в корзину";
            this.AddInCorzineButton.UseVisualStyleBackColor = true;
            this.AddInCorzineButton.Click += new System.EventHandler(this.AddInCorzineButton_Click);
            // 
            // PriceList
            // 
            this.PriceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceList.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceList.FormattingEnabled = true;
            this.PriceList.ItemHeight = 28;
            this.PriceList.Location = new System.Drawing.Point(456, 77);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(189, 756);
            this.PriceList.TabIndex = 4;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 850);
            this.Controls.Add(this.PriceList);
            this.Controls.Add(this.AddInCorzineButton);
            this.Controls.Add(this.CorzineButton);
            this.Controls.Add(this.ContentList);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ContentList;
        private System.Windows.Forms.Button CorzineButton;
        private System.Windows.Forms.Button AddInCorzineButton;
        private System.Windows.Forms.ListBox PriceList;
    }
}

