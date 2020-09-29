﻿namespace MovieLibrary.WinformsHost
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this._chkClassic = new System.Windows.Forms.CheckBox();
            this._comboRating = new System.Windows.Forms.ComboBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtReaseYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(38, 53);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Run Length";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(155, 45);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(199, 23);
            this._txtName.TabIndex = 4;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(154, 99);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(200, 95);
            this._txtDescription.TabIndex = 5;
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(153, 221);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(59, 23);
            this._txtRunLength.TabIndex = 6;
            // 
            // _chkClassic
            // 
            this._chkClassic.AutoSize = true;
            this._chkClassic.Location = new System.Drawing.Point(154, 275);
            this._chkClassic.Name = "_chkClassic";
            this._chkClassic.Size = new System.Drawing.Size(78, 19);
            this._chkClassic.TabIndex = 7;
            this._chkClassic.Text = "Is Classic?";
            this._chkClassic.UseVisualStyleBackColor = true;
            // 
            // _comboRating
            // 
            this._comboRating.FormattingEnabled = true;
            this._comboRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._comboRating.Location = new System.Drawing.Point(154, 322);
            this._comboRating.Name = "_comboRating";
            this._comboRating.Size = new System.Drawing.Size(121, 23);
            this._comboRating.TabIndex = 8;
            this._comboRating.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(539, 393);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(658, 393);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Release Year";
            // 
            // _txtReaseYear
            // 
            this._txtReaseYear.Location = new System.Drawing.Point(153, 377);
            this._txtReaseYear.Name = "_txtReaseYear";
            this._txtReaseYear.Size = new System.Drawing.Size(100, 23);
            this._txtReaseYear.TabIndex = 13;
            this._txtReaseYear.Text = "1900";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtReaseYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._comboRating);
            this.Controls.Add(this._chkClassic);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Name = "MovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.CheckBox _chkClassic;
        private System.Windows.Forms.ComboBox _comboRating;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtReaseYear;
    }
}