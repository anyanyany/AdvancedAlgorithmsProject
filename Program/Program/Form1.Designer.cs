namespace Program
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadGraphButton = new System.Windows.Forms.Button();
            this.listOfEgdes = new System.Windows.Forms.ListBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.uploadGraphButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listOfEgdes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.computeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uploadGraphButton
            // 
            this.uploadGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadGraphButton.FlatAppearance.BorderSize = 3;
            this.uploadGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadGraphButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadGraphButton.Location = new System.Drawing.Point(5, 5);
            this.uploadGraphButton.Margin = new System.Windows.Forms.Padding(5);
            this.uploadGraphButton.Name = "uploadGraphButton";
            this.uploadGraphButton.Size = new System.Drawing.Size(284, 44);
            this.uploadGraphButton.TabIndex = 0;
            this.uploadGraphButton.Text = "UPLOAD GRAPH";
            this.uploadGraphButton.UseVisualStyleBackColor = false;
            this.uploadGraphButton.Click += new System.EventHandler(this.uploadGraphButton_Click);
            // 
            // listOfEgdes
            // 
            this.listOfEgdes.FormattingEnabled = true;
            this.listOfEgdes.HorizontalScrollbar = true;
            this.listOfEgdes.Location = new System.Drawing.Point(297, 57);
            this.listOfEgdes.Name = "listOfEgdes";
            this.listOfEgdes.Size = new System.Drawing.Size(187, 225);
            this.listOfEgdes.TabIndex = 1;
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.DarkGray;
            this.computeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computeButton.FlatAppearance.BorderSize = 3;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computeButton.Location = new System.Drawing.Point(490, 3);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(312, 48);
            this.computeButton.TabIndex = 2;
            this.computeButton.Text = "FIND EDGE CONNECTIVITY";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(490, 54);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(312, 240);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "?";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edge connectivity";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uploadGraphButton;
        private System.Windows.Forms.ListBox listOfEgdes;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

