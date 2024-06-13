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
            ContentList = new ListBox();
            CorzineButton = new Button();
            AddInCorzineButton = new Button();
            PriceList = new ListBox();
            cartListBox = new ListBox();
            totalPriceLabel = new Label();
            SuspendLayout();
            // 
            // ContentList
            // 
            ContentList.BorderStyle = BorderStyle.None;
            ContentList.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContentList.FormattingEnabled = true;
            ContentList.ItemHeight = 22;
            ContentList.Location = new Point(11, 72);
            ContentList.Name = "ContentList";
            ContentList.Size = new Size(375, 704);
            ContentList.TabIndex = 0;
            // 
            // CorzineButton
            // 
            CorzineButton.Cursor = Cursors.Hand;
            CorzineButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CorzineButton.Location = new Point(11, 10);
            CorzineButton.Name = "CorzineButton";
            CorzineButton.Size = new Size(141, 54);
            CorzineButton.TabIndex = 1;
            CorzineButton.Text = "Корзина";
            CorzineButton.UseVisualStyleBackColor = true;
            CorzineButton.Click += CorzineButton_Click;
            // 
            // AddInCorzineButton
            // 
            AddInCorzineButton.Cursor = Cursors.Hand;
            AddInCorzineButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddInCorzineButton.Location = new Point(158, 10);
            AddInCorzineButton.Name = "AddInCorzineButton";
            AddInCorzineButton.Size = new Size(221, 54);
            AddInCorzineButton.TabIndex = 3;
            AddInCorzineButton.Text = "Добавить в корзину";
            AddInCorzineButton.UseVisualStyleBackColor = true;
            AddInCorzineButton.Click += AddInCorzineButton_Click;
            // 
            // PriceList
            // 
            PriceList.BorderStyle = BorderStyle.None;
            PriceList.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceList.FormattingEnabled = true;
            PriceList.ItemHeight = 22;
            PriceList.Location = new Point(221, 70);
            PriceList.Name = "PriceList";
            PriceList.Size = new Size(165, 704);
            PriceList.TabIndex = 4;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(639, 92);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(95, 379);
            cartListBox.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(639, 49);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(75, 15);
            totalPriceLabel.TabIndex = 6;
            totalPriceLabel.Text = "Общая цена";
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 797);
            Controls.Add(totalPriceLabel);
            Controls.Add(cartListBox);
            Controls.Add(PriceList);
            Controls.Add(AddInCorzineButton);
            Controls.Add(CorzineButton);
            Controls.Add(ContentList);
            Name = "Catalog";
            Text = "Catalog";
            Load += Catalog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.ListBox ContentList;
        private System.Windows.Forms.Button CorzineButton;
        private System.Windows.Forms.Button AddInCorzineButton;
        private System.Windows.Forms.ListBox PriceList;
        private ListBox cartListBox;
        private Label totalPriceLabel;
    }
}

