namespace Stock
{
    partial class StockMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stockUserControl1 = new Stock.stockUserControl();
            this.productsUserControl1 = new Stock.productsUserControl();
            this.productsButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.panelForButton = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.stockUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.productsUserControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(952, 695);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // stockUserControl1
            // 
            this.stockUserControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockUserControl1.ForeColor = System.Drawing.Color.Blue;
            this.stockUserControl1.Location = new System.Drawing.Point(3, 4);
            this.stockUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockUserControl1.Name = "stockUserControl1";
            this.stockUserControl1.Size = new System.Drawing.Size(1032, 799);
            this.stockUserControl1.TabIndex = 1;
            // 
            // productsUserControl1
            // 
            this.productsUserControl1.Location = new System.Drawing.Point(3, 811);
            this.productsUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsUserControl1.Name = "productsUserControl1";
            this.productsUserControl1.Size = new System.Drawing.Size(913, 639);
            this.productsUserControl1.TabIndex = 0;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.Transparent;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Location = new System.Drawing.Point(15, 147);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(129, 58);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "PRODUCTS";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.Transparent;
            this.stockButton.FlatAppearance.BorderSize = 0;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.Location = new System.Drawing.Point(15, 47);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(129, 52);
            this.stockButton.TabIndex = 1;
            this.stockButton.Text = "STOCK";
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // panelForButton
            // 
            this.panelForButton.BackColor = System.Drawing.Color.Blue;
            this.panelForButton.ForeColor = System.Drawing.Color.Blue;
            this.panelForButton.Location = new System.Drawing.Point(12, 54);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(11, 45);
            this.panelForButton.TabIndex = 2;
            // 
            // StockMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 846);
            this.Controls.Add(this.panelForButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockMain";
            this.ShowIcon = false;
            this.Text = "Stock database app";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockMain_FormClosing);
            this.Load += new System.EventHandler(this.StockMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private productsUserControl productsUserControl1;
        private stockUserControl stockUserControl1;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Panel panelForButton;
    }
}



