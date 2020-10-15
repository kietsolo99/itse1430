using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CreateNewCharacter : Form
    {
        public CreateNewCharacter ()
        {
            InitializeComponent();
        }

        public virtual Character Character { get; set; }

        protected override void OnLoad ( EventArgs e )
        {

            base.OnLoad(e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                _comboProfession.SelectedText = Character.Profession;
                _comboRace.SelectedText = Character.Race;
                _numUpDownStr.Text = Character.Strength.ToString();
                _numUpDownInt.Text = Character.Intelligence.ToString();
                _numUpDownAgi.Text = Character.Agility.ToString();
                _numUpDownCon.Text = Character.Constitution.ToString();
                _numUpDownCha.Text = Character.Charisma.ToString();

            };

            ValidateChildren();
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };

            var button = sender as Button;
            if (button == null)
                return;

            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _comboProfession.SelectedText;
            character.Race = _comboRace.SelectedText;
            character.Strength = ReadAsInt32(_numUpDownStr);
            character.Intelligence = ReadAsInt32(_numUpDownInt);
            character.Agility = ReadAsInt32(_numUpDownAgi);
            character.Constitution = ReadAsInt32(_numUpDownCon);
            character.Charisma = ReadAsInt32(_numUpDownCha);
            character.Description = _txtDescription.Text;

            var descriptionLength = character.MaximumDescriptionLength;

            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(this, error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            };

            Character = character;
            Close();
        }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required");
                e.Cancel = true; 
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateAttribute ( object sender, CancelEventArgs e )
        {

        }

        private void CreateNewCharacter_Load ( object sender, EventArgs e )
        {

        }


        private void OnValidateStr ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var value = ReadAsInt32(control);

            if (value <= 0 && value > 100)
            {
                _errors.SetError(control, "Values must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateInt ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var value = ReadAsInt32(control);

            if (value <= 0 && value > 100)
            {
                _errors.SetError(control, "Values must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void _numUpDownInt_ValueChanged ( object sender, EventArgs e )
        {

        }

        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }

        private void OnValidateAgi ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var value = ReadAsInt32(control);

            if (value <= 0 && value > 100)
            {
                _errors.SetError(control, "Values must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateCon ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var value = ReadAsInt32(control);

            if (value <= 0 && value > 100)
            {
                _errors.SetError(control, "Values must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateCha ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var value = ReadAsInt32(control);

            if (value <= 0 && value > 100)
            {
                _errors.SetError(control, "Values must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void _numUpDownCha_ValueChanged ( object sender, EventArgs e )
        {

        }
    }
}
