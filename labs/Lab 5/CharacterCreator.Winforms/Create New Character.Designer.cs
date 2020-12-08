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
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Profession = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.Strength = new System.Windows.Forms.Label();
            this._numUpDownStr = new System.Windows.Forms.NumericUpDown();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Charisma = new System.Windows.Forms.Label();
            this._numUpDownInt = new System.Windows.Forms.NumericUpDown();
            this._numUpDownAgi = new System.Windows.Forms.NumericUpDown();
            this._numUpDownCon = new System.Windows.Forms.NumericUpDown();
            this._numUpDownCha = new System.Windows.Forms.NumericUpDown();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCha)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Profession
            // 
            this.Profession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profession.AutoSize = true;
            this.Profession.Location = new System.Drawing.Point(12, 65);
            this.Profession.Name = "Profession";
            this.Profession.Size = new System.Drawing.Size(62, 15);
            this.Profession.TabIndex = 1;
            this.Profession.Text = "Profession";
            // 
            // Race
            // 
            this.Race.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Race.AutoSize = true;
            this.Race.Location = new System.Drawing.Point(12, 115);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(32, 15);
            this.Race.TabIndex = 2;
            this.Race.Text = "Race";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 153);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(67, 15);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(85, 22);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(220, 23);
            this._txtName.TabIndex = 7;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _comboProfession
            // 
            this._comboProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(85, 65);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(132, 23);
            this._comboProfession.TabIndex = 8;
            this._comboProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProfession);
            // 
            // _comboRace
            // 
            this._comboRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(85, 110);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(132, 23);
            this._comboRace.TabIndex = 9;
            this._comboRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(85, 153);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(220, 82);
            this._txtDescription.TabIndex = 11;
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // Strength
            // 
            this.Strength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(12, 249);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(52, 15);
            this.Strength.TabIndex = 12;
            this.Strength.Text = "Strength";
            // 
            // _numUpDownStr
            // 
            this._numUpDownStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._numUpDownStr.Location = new System.Drawing.Point(85, 249);
            this._numUpDownStr.Name = "_numUpDownStr";
            this._numUpDownStr.Size = new System.Drawing.Size(46, 23);
            this._numUpDownStr.TabIndex = 13;
            this._numUpDownStr.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateStr);
            // 
            // Intelligence
            // 
            this.Intelligence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Intelligence.AutoSize = true;
            this.Intelligence.Location = new System.Drawing.Point(12, 284);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(68, 15);
            this.Intelligence.TabIndex = 14;
            this.Intelligence.Text = "Intelligence";
            // 
            // Agility
            // 
            this.Agility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Agility.AutoSize = true;
            this.Agility.Location = new System.Drawing.Point(12, 321);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(41, 15);
            this.Agility.TabIndex = 15;
            this.Agility.Text = "Agility";
            // 
            // Constitution
            // 
            this.Constitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(12, 350);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(73, 15);
            this.Constitution.TabIndex = 16;
            this.Constitution.Text = "Constitution";
            // 
            // Charisma
            // 
            this.Charisma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Charisma.AutoSize = true;
            this.Charisma.Location = new System.Drawing.Point(12, 379);
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(57, 15);
            this.Charisma.TabIndex = 17;
            this.Charisma.Text = "Charisma";
            // 
            // _numUpDownInt
            // 
            this._numUpDownInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._numUpDownInt.Location = new System.Drawing.Point(85, 284);
            this._numUpDownInt.Name = "_numUpDownInt";
            this._numUpDownInt.Size = new System.Drawing.Size(46, 23);
            this._numUpDownInt.TabIndex = 18;
            this._numUpDownInt.ValueChanged += new System.EventHandler(this._numUpDownInt_ValueChanged);
            this._numUpDownInt.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateInt);
            // 
            // _numUpDownAgi
            // 
            this._numUpDownAgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._numUpDownAgi.Location = new System.Drawing.Point(85, 319);
            this._numUpDownAgi.Name = "_numUpDownAgi";
            this._numUpDownAgi.Size = new System.Drawing.Size(46, 23);
            this._numUpDownAgi.TabIndex = 19;
            this._numUpDownAgi.ValueChanged += new System.EventHandler(this._numUpDownAgi_ValueChanged);
            this._numUpDownAgi.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAgi);
            // 
            // _numUpDownCon
            // 
            this._numUpDownCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._numUpDownCon.Location = new System.Drawing.Point(85, 350);
            this._numUpDownCon.Name = "_numUpDownCon";
            this._numUpDownCon.Size = new System.Drawing.Size(46, 23);
            this._numUpDownCon.TabIndex = 20;
            this._numUpDownCon.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCon);
            // 
            // _numUpDownCha
            // 
            this._numUpDownCha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._numUpDownCha.Location = new System.Drawing.Point(85, 379);
            this._numUpDownCha.Name = "_numUpDownCha";
            this._numUpDownCha.Size = new System.Drawing.Size(46, 23);
            this._numUpDownCha.TabIndex = 21;
            this._numUpDownCha.ValueChanged += new System.EventHandler(this._numUpDownCha_ValueChanged);
            this._numUpDownCha.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCha);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(192, 416);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 22;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(273, 416);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 23;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(360, 451);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._numUpDownCha);
            this.Controls.Add(this._numUpDownCon);
            this.Controls.Add(this._numUpDownAgi);
            this.Controls.Add(this._numUpDownInt);
            this.Controls.Add(this.Charisma);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this._numUpDownStr);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Profession);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewCharacter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateNewCharacter";
            this.Load += new System.EventHandler(this.CreateNewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private new System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Profession;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.NumericUpDown _numUpDownCha;
        private System.Windows.Forms.NumericUpDown _numUpDownCon;
        private System.Windows.Forms.NumericUpDown _numUpDownAgi;
        private System.Windows.Forms.NumericUpDown _numUpDownInt;
        private System.Windows.Forms.Label Charisma;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.NumericUpDown _numUpDownStr;
        private System.Windows.Forms.Label Strength;
    }
}