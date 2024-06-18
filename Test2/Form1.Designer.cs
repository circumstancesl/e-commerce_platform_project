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
            button1 = new Button();
            SuspendLayout();
            // 
            // ContentList
            // 
            ContentList.BorderStyle = BorderStyle.None;
            ContentList.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContentList.FormattingEnabled = true;
            ContentList.ItemHeight = 29;
            ContentList.Location = new Point(13, 96);
            ContentList.Margin = new Padding(3, 4, 3, 4);
            ContentList.Name = "ContentList";
            ContentList.Size = new Size(429, 928);
            ContentList.TabIndex = 0;
            // 
            // CorzineButton
            // 
            CorzineButton.Cursor = Cursors.Hand;
            CorzineButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CorzineButton.Location = new Point(13, 13);
            CorzineButton.Margin = new Padding(3, 4, 3, 4);
            CorzineButton.Name = "CorzineButton";
            CorzineButton.Size = new Size(161, 72);
            CorzineButton.TabIndex = 1;
            CorzineButton.Text = "Корзина";
            CorzineButton.UseVisualStyleBackColor = true;
            CorzineButton.Click += CorzineButton_Click;
            // 
            // AddInCorzineButton
            // 
            AddInCorzineButton.Cursor = Cursors.Hand;
            AddInCorzineButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddInCorzineButton.Location = new Point(181, 13);
            AddInCorzineButton.Margin = new Padding(3, 4, 3, 4);
            AddInCorzineButton.Name = "AddInCorzineButton";
            AddInCorzineButton.Size = new Size(253, 72);
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
            PriceList.ItemHeight = 29;
            PriceList.Location = new Point(253, 93);
            PriceList.Margin = new Padding(3, 4, 3, 4);
            PriceList.Name = "PriceList";
            PriceList.Size = new Size(189, 928);
            PriceList.TabIndex = 4;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.Location = new Point(533, 93);
            cartListBox.Margin = new Padding(3, 4, 3, 4);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(157, 504);
            cartListBox.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(533, 35);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(95, 20);
            totalPriceLabel.TabIndex = 6;
            totalPriceLabel.Text = "Общая цена";
            // 
            // button1
            // 
            button1.Location = new Point(808, 93);
            button1.Name = "button1";
            button1.Size = new Size(137, 61);
            button1.TabIndex = 7;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 1055);
            Controls.Add(button1);
            Controls.Add(totalPriceLabel);
            Controls.Add(cartListBox);
            Controls.Add(PriceList);
            Controls.Add(AddInCorzineButton);
            Controls.Add(CorzineButton);
            Controls.Add(ContentList);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}

