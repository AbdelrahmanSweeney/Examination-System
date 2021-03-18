
namespace examapp
{
    partial class Form_Student_ByAdmin
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
            this.dataGStudent = new System.Windows.Forms.DataGridView();
            this.btndeletestudent = new System.Windows.Forms.Button();
            this.btnaddstu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGStudent
            // 
            this.dataGStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGStudent.Location = new System.Drawing.Point(46, 145);
            this.dataGStudent.Name = "dataGStudent";
            this.dataGStudent.Size = new System.Drawing.Size(627, 133);
            this.dataGStudent.TabIndex = 15;
            // 
            // btndeletestudent
            // 
            this.btndeletestudent.Location = new System.Drawing.Point(254, 37);
            this.btndeletestudent.Name = "btndeletestudent";
            this.btndeletestudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeletestudent.Size = new System.Drawing.Size(157, 23);
            this.btndeletestudent.TabIndex = 14;
            this.btndeletestudent.Text = "Delete Student";
            this.btndeletestudent.UseVisualStyleBackColor = true;
            this.btndeletestudent.Click += new System.EventHandler(this.btndeletestudent_Click);
            // 
            // btnaddstu
            // 
            this.btnaddstu.Location = new System.Drawing.Point(46, 37);
            this.btnaddstu.Name = "btnaddstu";
            this.btnaddstu.Size = new System.Drawing.Size(157, 23);
            this.btnaddstu.TabIndex = 13;
            this.btnaddstu.Text = "Add student";
            this.btnaddstu.UseVisualStyleBackColor = true;
            this.btnaddstu.Click += new System.EventHandler(this.btnaddstu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student list:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(447, 37);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(157, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update Student";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form_Student_ByAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGStudent);
            this.Controls.Add(this.btndeletestudent);
            this.Controls.Add(this.btnaddstu);
            this.Name = "Form_Student_ByAdmin";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGStudent;
        private System.Windows.Forms.Button btndeletestudent;
        private System.Windows.Forms.Button btnaddstu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdate;
    }
}