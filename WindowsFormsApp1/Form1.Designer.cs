namespace WindowsFormsApp1
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
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnshow8 = new System.Windows.Forms.Button();
            this.btnshow7 = new System.Windows.Forms.Button();
            this.btnshow6 = new System.Windows.Forms.Button();
            this.btnshow5 = new System.Windows.Forms.Button();
            this.btnshow4 = new System.Windows.Forms.Button();
            this.btnshow3 = new System.Windows.Forms.Button();
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnshow2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(311, 258);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 24);
            this.cmbDays.TabIndex = 0;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnshow8);
            this.groupBox1.Controls.Add(this.btnshow7);
            this.groupBox1.Controls.Add(this.btnshow6);
            this.groupBox1.Controls.Add(this.btnshow5);
            this.groupBox1.Controls.Add(this.btnshow4);
            this.groupBox1.Controls.Add(this.btnshow3);
            this.groupBox1.Controls.Add(this.btnshow2);
            this.groupBox1.Controls.Add(this.btnshow1);
            this.groupBox1.Controls.Add(this.cmbDays);
            this.groupBox1.Location = new System.Drawing.Point(56, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnshow8
            // 
            this.btnshow8.Location = new System.Drawing.Point(305, 153);
            this.btnshow8.Name = "btnshow8";
            this.btnshow8.Size = new System.Drawing.Size(133, 33);
            this.btnshow8.TabIndex = 8;
            this.btnshow8.Text = "show8";
            this.btnshow8.UseVisualStyleBackColor = true;
            this.btnshow8.Click += new System.EventHandler(this.btnshow8_Click);
            // 
            // btnshow7
            // 
            this.btnshow7.Location = new System.Drawing.Point(43, 174);
            this.btnshow7.Name = "btnshow7";
            this.btnshow7.Size = new System.Drawing.Size(134, 33);
            this.btnshow7.TabIndex = 7;
            this.btnshow7.Text = "delete all items";
            this.btnshow7.UseVisualStyleBackColor = true;
            this.btnshow7.Click += new System.EventHandler(this.btnshow7_Click);
            // 
            // btnshow6
            // 
            this.btnshow6.Location = new System.Drawing.Point(140, 84);
            this.btnshow6.Name = "btnshow6";
            this.btnshow6.Size = new System.Drawing.Size(75, 71);
            this.btnshow6.TabIndex = 6;
            this.btnshow6.Text = "remove third item from down";
            this.btnshow6.UseVisualStyleBackColor = true;
            this.btnshow6.Click += new System.EventHandler(this.btnshow6_Click);
            // 
            // btnshow5
            // 
            this.btnshow5.Location = new System.Drawing.Point(23, 84);
            this.btnshow5.Name = "btnshow5";
            this.btnshow5.Size = new System.Drawing.Size(95, 63);
            this.btnshow5.TabIndex = 5;
            this.btnshow5.Text = "remove before last item";
            this.btnshow5.UseVisualStyleBackColor = true;
            this.btnshow5.Click += new System.EventHandler(this.btnshow5_Click);
            // 
            // btnshow4
            // 
            this.btnshow4.Location = new System.Drawing.Point(372, 43);
            this.btnshow4.Name = "btnshow4";
            this.btnshow4.Size = new System.Drawing.Size(104, 66);
            this.btnshow4.TabIndex = 4;
            this.btnshow4.Text = "remove last item";
            this.btnshow4.UseVisualStyleBackColor = true;
            this.btnshow4.Click += new System.EventHandler(this.btnshow4_Click);
            // 
            // btnshow3
            // 
            this.btnshow3.Location = new System.Drawing.Point(249, 43);
            this.btnshow3.Name = "btnshow3";
            this.btnshow3.Size = new System.Drawing.Size(102, 66);
            this.btnshow3.TabIndex = 3;
            this.btnshow3.Text = "Remove first item";
            this.btnshow3.UseVisualStyleBackColor = true;
            this.btnshow3.Click += new System.EventHandler(this.btnshow3_Click);
            // 
            // btnshow1
            // 
            this.btnshow1.Location = new System.Drawing.Point(23, 29);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(95, 49);
            this.btnshow1.TabIndex = 1;
            this.btnshow1.Text = "show selected";
            this.btnshow1.UseVisualStyleBackColor = true;
            this.btnshow1.Click += new System.EventHandler(this.btnshow1_Click);
            // 
            // btnshow2
            // 
            this.btnshow2.Location = new System.Drawing.Point(140, 43);
            this.btnshow2.Name = "btnshow2";
            this.btnshow2.Size = new System.Drawing.Size(75, 35);
            this.btnshow2.TabIndex = 2;
            this.btnshow2.Text = "selected";
            this.btnshow2.UseVisualStyleBackColor = true;
            this.btnshow2.Click += new System.EventHandler(this.btnshow2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnshow8;
        private System.Windows.Forms.Button btnshow7;
        private System.Windows.Forms.Button btnshow6;
        private System.Windows.Forms.Button btnshow5;
        private System.Windows.Forms.Button btnshow4;
        private System.Windows.Forms.Button btnshow3;
        private System.Windows.Forms.Button btnshow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnshow2;
    }
}

