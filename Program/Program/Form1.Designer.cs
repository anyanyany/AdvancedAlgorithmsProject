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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadGraphButton = new System.Windows.Forms.Button();
            this.listOfEgdes = new System.Windows.Forms.ListBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfVertices = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.edgeFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.edgeTo = new System.Windows.Forms.NumericUpDown();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteEdgeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfVertices)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeTo)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.uploadGraphButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.computeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 380);
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
            this.uploadGraphButton.Size = new System.Drawing.Size(284, 56);
            this.uploadGraphButton.TabIndex = 0;
            this.uploadGraphButton.Text = "LOAD GRAPH";
            this.uploadGraphButton.UseVisualStyleBackColor = false;
            this.uploadGraphButton.Click += new System.EventHandler(this.uploadGraphButton_Click);
            // 
            // listOfEgdes
            // 
            this.listOfEgdes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfEgdes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listOfEgdes.FormattingEnabled = true;
            this.listOfEgdes.HorizontalScrollbar = true;
            this.listOfEgdes.ItemHeight = 21;
            this.listOfEgdes.Location = new System.Drawing.Point(3, 3);
            this.listOfEgdes.Name = "listOfEgdes";
            this.listOfEgdes.Size = new System.Drawing.Size(220, 236);
            this.listOfEgdes.TabIndex = 1;
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.DarkGray;
            this.computeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computeButton.FlatAppearance.BorderSize = 3;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computeButton.Location = new System.Drawing.Point(529, 3);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(292, 60);
            this.computeButton.TabIndex = 2;
            this.computeButton.Text = "FIND EDGE CONNECTIVITY";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultLabel.Font = new System.Drawing.Font("Century Gothic", 100F);
            this.resultLabel.Location = new System.Drawing.Point(529, 66);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(292, 293);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "?";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 69);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(283, 287);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.addEdgeButton, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 281);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "OR CREATE OWN ONE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numberOfVertices, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 44);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "number of vertices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfVertices
            // 
            this.numberOfVertices.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfVertices.Location = new System.Drawing.Point(188, 10);
            this.numberOfVertices.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numberOfVertices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfVertices.Name = "numberOfVertices";
            this.numberOfVertices.Size = new System.Drawing.Size(80, 26);
            this.numberOfVertices.TabIndex = 1;
            this.numberOfVertices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfVertices.ValueChanged += new System.EventHandler(this.numberOfVerticesValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "edges";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.edgeFrom, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.edgeTo, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(271, 43);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "from";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edgeFrom
            // 
            this.edgeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edgeFrom.Location = new System.Drawing.Point(70, 10);
            this.edgeFrom.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.edgeFrom.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edgeFrom.Name = "edgeFrom";
            this.edgeFrom.Size = new System.Drawing.Size(61, 27);
            this.edgeFrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(137, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "to";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edgeTo
            // 
            this.edgeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edgeTo.Location = new System.Drawing.Point(204, 10);
            this.edgeTo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.edgeTo.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edgeTo.Name = "edgeTo";
            this.edgeTo.Size = new System.Drawing.Size(64, 27);
            this.edgeTo.TabIndex = 6;
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEdgeButton.FlatAppearance.BorderSize = 2;
            this.addEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEdgeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEdgeButton.Location = new System.Drawing.Point(8, 238);
            this.addEdgeButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 5);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(261, 38);
            this.addEdgeButton.TabIndex = 4;
            this.addEdgeButton.Text = "ADD EDGE";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.deleteEdgeButton, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.listOfEgdes, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(297, 69);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(226, 287);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // deleteEdgeButton
            // 
            this.deleteEdgeButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteEdgeButton.FlatAppearance.BorderSize = 2;
            this.deleteEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEdgeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteEdgeButton.Location = new System.Drawing.Point(3, 242);
            this.deleteEdgeButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.deleteEdgeButton.Name = "deleteEdgeButton";
            this.deleteEdgeButton.Size = new System.Drawing.Size(220, 39);
            this.deleteEdgeButton.TabIndex = 5;
            this.deleteEdgeButton.Text = "DELETE EDGE";
            this.deleteEdgeButton.UseVisualStyleBackColor = false;
            this.deleteEdgeButton.Click += new System.EventHandler(this.deleteEdgeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edge connectivity";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfVertices)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeTo)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uploadGraphButton;
        private System.Windows.Forms.ListBox listOfEgdes;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfVertices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edgeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edgeTo;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button deleteEdgeButton;
    }
}

