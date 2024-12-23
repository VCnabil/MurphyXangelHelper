﻿namespace MurphyXangelHelper
{
    partial class MurphyXangelForm
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
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.rdoMakeNew = new System.Windows.Forms.RadioButton();
            this.rdoOverwrite = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(1, 12);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(2024, 38);
            this.txtDirectoryPath.TabIndex = 12;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(1045, 60);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(980, 106);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "Proc";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(1, 60);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(533, 106);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // rdoMakeNew
            // 
            this.rdoMakeNew.AutoSize = true;
            this.rdoMakeNew.Checked = true;
            this.rdoMakeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMakeNew.Location = new System.Drawing.Point(22, 24);
            this.rdoMakeNew.Name = "rdoMakeNew";
            this.rdoMakeNew.Size = new System.Drawing.Size(95, 35);
            this.rdoMakeNew.TabIndex = 3;
            this.rdoMakeNew.TabStop = true;
            this.rdoMakeNew.Text = "new";
            this.rdoMakeNew.UseVisualStyleBackColor = true;
            // 
            // rdoOverwrite
            // 
            this.rdoOverwrite.AutoSize = true;
            this.rdoOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOverwrite.Location = new System.Drawing.Point(22, 65);
            this.rdoOverwrite.Name = "rdoOverwrite";
            this.rdoOverwrite.Size = new System.Drawing.Size(171, 35);
            this.rdoOverwrite.TabIndex = 4;
            this.rdoOverwrite.Text = "Overrwrite";
            this.rdoOverwrite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMakeNew);
            this.groupBox1.Controls.Add(this.rdoOverwrite);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(708, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // MurphyXangelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2027, 174);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox1);
            this.Name = "MurphyXangelForm";
            this.Text = "MurphyXangelForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.RadioButton rdoMakeNew;
        private System.Windows.Forms.RadioButton rdoOverwrite;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}