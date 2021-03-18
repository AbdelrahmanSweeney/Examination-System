
namespace examapp
{
    partial class Add_Topic
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
            this.comboxCourse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnaddST = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtopicName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboxCourse
            // 
            this.comboxCourse.FormattingEnabled = true;
            this.comboxCourse.Location = new System.Drawing.Point(148, 47);
            this.comboxCourse.Name = "comboxCourse";
            this.comboxCourse.Size = new System.Drawing.Size(216, 21);
            this.comboxCourse.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Topic Name";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(136, 264);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(92, 23);
            this.btnback.TabIndex = 51;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnaddST
            // 
            this.btnaddST.Location = new System.Drawing.Point(380, 264);
            this.btnaddST.Name = "btnaddST";
            this.btnaddST.Size = new System.Drawing.Size(92, 23);
            this.btnaddST.TabIndex = 50;
            this.btnaddST.Text = "Add";
            this.btnaddST.UseVisualStyleBackColor = true;
            this.btnaddST.Click += new System.EventHandler(this.btnaddST_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "CourseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Add Topic";
            // 
            // txtopicName
            // 
            this.txtopicName.Location = new System.Drawing.Point(148, 101);
            this.txtopicName.Name = "txtopicName";
            this.txtopicName.Size = new System.Drawing.Size(216, 20);
            this.txtopicName.TabIndex = 55;
            // 
            // addtopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtopicName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnaddST);
            this.Controls.Add(this.comboxCourse);
            this.Controls.Add(this.label12);
            this.Name = "addtopic";
            this.Text = "addtopic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxCourse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnaddST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtopicName;
    }
}