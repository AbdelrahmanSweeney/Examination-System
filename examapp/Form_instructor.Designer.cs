
namespace examapp
{
    partial class Form_instructor
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
            this.dataG_inst = new System.Windows.Forms.DataGridView();
            this.btnDeleteins = new System.Windows.Forms.Button();
            this.btnAddInst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_inst)).BeginInit();
            this.SuspendLayout();
            // 
            // dataG_inst
            // 
            this.dataG_inst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_inst.Location = new System.Drawing.Point(28, 116);
            this.dataG_inst.Name = "dataG_inst";
            this.dataG_inst.Size = new System.Drawing.Size(738, 204);
            this.dataG_inst.TabIndex = 14;
            // 
            // btnDeleteins
            // 
            this.btnDeleteins.Location = new System.Drawing.Point(285, 50);
            this.btnDeleteins.Name = "btnDeleteins";
            this.btnDeleteins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteins.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteins.TabIndex = 13;
            this.btnDeleteins.Text = "Delete Instructor";
            this.btnDeleteins.UseVisualStyleBackColor = true;
            this.btnDeleteins.Click += new System.EventHandler(this.btnDeleteins_Click);
            // 
            // btnAddInst
            // 
            this.btnAddInst.Location = new System.Drawing.Point(38, 50);
            this.btnAddInst.Name = "btnAddInst";
            this.btnAddInst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddInst.Size = new System.Drawing.Size(157, 23);
            this.btnAddInst.TabIndex = 12;
            this.btnAddInst.Text = "Add Instructor";
            this.btnAddInst.UseVisualStyleBackColor = true;
            this.btnAddInst.Click += new System.EventHandler(this.btnAddInst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Instructor list:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(546, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.Size = new System.Drawing.Size(157, 37);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(462, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(157, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Instructor";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form_instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataG_inst);
            this.Controls.Add(this.btnDeleteins);
            this.Controls.Add(this.btnAddInst);
            this.Name = "Form_instructor";
            this.Text = "instructor";
            ((System.ComponentModel.ISupportInitialize)(this.dataG_inst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataG_inst;
        private System.Windows.Forms.Button btnDeleteins;
        private System.Windows.Forms.Button btnAddInst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
    }
}