namespace MatMag
{
    partial class usOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbOrderAll = new System.Windows.Forms.RadioButton();
            this.rbOrderOpen = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdNewOrder = new System.Windows.Forms.Button();
            this.cmdDeleteOrder = new System.Windows.Forms.Button();
            this.cmdSaveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 537);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 60);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbOrderOpen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbOrderAll, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbOrderAll
            // 
            this.rbOrderAll.AutoSize = true;
            this.rbOrderAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbOrderAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbOrderAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbOrderAll.Location = new System.Drawing.Point(3, 3);
            this.rbOrderAll.Name = "rbOrderAll";
            this.rbOrderAll.Size = new System.Drawing.Size(163, 42);
            this.rbOrderAll.TabIndex = 3;
            this.rbOrderAll.TabStop = true;
            this.rbOrderAll.Text = "Alle";
            this.rbOrderAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOrderAll.UseVisualStyleBackColor = true;
            // 
            // rbOrderOpen
            // 
            this.rbOrderOpen.AutoSize = true;
            this.rbOrderOpen.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbOrderOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbOrderOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbOrderOpen.Location = new System.Drawing.Point(172, 3);
            this.rbOrderOpen.Name = "rbOrderOpen";
            this.rbOrderOpen.Size = new System.Drawing.Size(163, 42);
            this.rbOrderOpen.TabIndex = 4;
            this.rbOrderOpen.TabStop = true;
            this.rbOrderOpen.Text = "Offen";
            this.rbOrderOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOrderOpen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 60);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.cmdSaveOrder, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdNewOrder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdDeleteOrder, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(288, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmdNewOrder
            // 
            this.cmdNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewOrder.Location = new System.Drawing.Point(7, 7);
            this.cmdNewOrder.Name = "cmdNewOrder";
            this.cmdNewOrder.Size = new System.Drawing.Size(120, 46);
            this.cmdNewOrder.TabIndex = 0;
            this.cmdNewOrder.Text = "Neu";
            this.cmdNewOrder.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteOrder
            // 
            this.cmdDeleteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteOrder.Location = new System.Drawing.Point(133, 7);
            this.cmdDeleteOrder.Name = "cmdDeleteOrder";
            this.cmdDeleteOrder.Size = new System.Drawing.Size(120, 46);
            this.cmdDeleteOrder.TabIndex = 1;
            this.cmdDeleteOrder.Text = "Löschen";
            this.cmdDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // cmdSaveOrder
            // 
            this.cmdSaveOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveOrder.Location = new System.Drawing.Point(259, 7);
            this.cmdSaveOrder.Name = "cmdSaveOrder";
            this.cmdSaveOrder.Size = new System.Drawing.Size(122, 46);
            this.cmdSaveOrder.TabIndex = 2;
            this.cmdSaveOrder.Text = "Speichern";
            this.cmdSaveOrder.UseVisualStyleBackColor = true;
            // 
            // usOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "usOrder";
            this.Size = new System.Drawing.Size(1020, 537);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbOrderOpen;
        private System.Windows.Forms.RadioButton rbOrderAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cmdSaveOrder;
        private System.Windows.Forms.Button cmdNewOrder;
        private System.Windows.Forms.Button cmdDeleteOrder;
    }
}
