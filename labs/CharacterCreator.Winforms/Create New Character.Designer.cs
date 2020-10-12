namespace CharacterCreator.Winforms
{
    partial class CreateNewCharacter
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Name = new System.Windows.Forms.Label();
            this.Profession = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Label();
            this.Attribute = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtName = new System.Windows.Forms.TextBox();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._liAttribute = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "&Character";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem2.Text = "&New";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(49, 50);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Profession
            // 
            this.Profession.AutoSize = true;
            this.Profession.Location = new System.Drawing.Point(49, 93);
            this.Profession.Name = "Profession";
            this.Profession.Size = new System.Drawing.Size(62, 15);
            this.Profession.TabIndex = 1;
            this.Profession.Text = "Profession";
            // 
            // Race
            // 
            this.Race.AutoSize = true;
            this.Race.Location = new System.Drawing.Point(49, 143);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(32, 15);
            this.Race.TabIndex = 2;
            this.Race.Text = "Race";
            // 
            // Attribute
            // 
            this.Attribute.AutoSize = true;
            this.Attribute.Location = new System.Drawing.Point(49, 178);
            this.Attribute.Name = "Attribute";
            this.Attribute.Size = new System.Drawing.Size(54, 15);
            this.Attribute.TabIndex = 3;
            this.Attribute.Text = "Attribute";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(49, 289);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(67, 15);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(546, 394);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 5;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(659, 394);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(131, 50);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(238, 23);
            this._txtName.TabIndex = 7;
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter ",
            "Hunter ",
            "Priest ",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(131, 90);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(121, 23);
            this._comboProfession.TabIndex = 8;
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(131, 135);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(121, 23);
            this._comboRace.TabIndex = 9;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(131, 286);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(238, 99);
            this._txtDescription.TabIndex = 11;
            // 
            // _liAttribute
            // 
            this._liAttribute.FormattingEnabled = true;
            this._liAttribute.ItemHeight = 15;
            this._liAttribute.Items.AddRange(new object[] {
            "Streng:",
            "Intelligence:",
            "Agility:",
            "Constitution:",
            "Charisma:"});
            this._liAttribute.Location = new System.Drawing.Point(131, 178);
            this._liAttribute.Name = "_liAttribute";
            this._liAttribute.Size = new System.Drawing.Size(238, 94);
            this._liAttribute.TabIndex = 12;
            // 
            // CreateNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._liAttribute);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Attribute);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Profession);
            this.Controls.Add(this.Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name.Text = "Name";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateNewCharacter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Profession;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.Label Attribute;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.ListBox _liAttribute;
    }
}