
namespace examapp
{
    partial class Update_Topic
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
            this.txtopicName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnUdpate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtopicName
            // 
            this.txtopicName.Location = new System.Drawing.Point(153, 111);
            this.txtopicName.Name = "txtopicName";
            this.txtopicName.Size = new System.Drawing.Size(216, 20);
            this.txtopicName.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Update Topic";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(141, 274);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(92, 23);
            this.btnback.TabIndex = 58;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnUdpate
            // 
            this.btnUdpate.Location = new System.Drawing.Point(385, 274);
            this.btnUdpate.Name = "btnUdpate";
            this.btnUdpate.Size = new System.Drawing.Size(92, 23);
            this.btnUdpate.TabIndex = 57;
            this.btnUdpate.Text = "Update";
            this.btnUdpate.UseVisualStyleBackColor = true;
            this.btnUdpate.Click += new System.EventHandler(this.btnUdpate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Topic Name";
            // 
            // Update_Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtopicName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnUdpate);
            this.Controls.Add(this.label12);
            this.Name = "Update_Topic";
            this.Text = "Update_Topic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtopicName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnUdpate;
        private System.Windows.Forms.Label label12;
    }
}