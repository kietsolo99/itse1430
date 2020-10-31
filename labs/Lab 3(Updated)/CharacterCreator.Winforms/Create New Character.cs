using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CreateNewCharacter : Form
    {
        public CreateNewCharacter ()
        {
            InitializeComponent();

            _btnSave.Click += OnSave;
            _btnCancel.Click += OnCancel;
        }

        public CreateNewCharacter ( Character character, string title ) : this()
        {
            Character = character;
            Text = title ?? "Add Character";
        }

        public virtual Character Character { get; set; }

        public Character SelectedCharacter { get; set; }


        protected override void OnLoad ( EventArgs e )
        {

            base.OnLoad(e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                _comboProfession.Text = Character.Profession;
                _comboRace.Text = Character.Race;
                _numUpDownStr.Text = Character.Strength.ToString();
                _numUpDownInt.Text = Character.Intelligence.ToString();
                _numUpDownAgi.Text = Character.Agility.ToString();
                _numUpDownCon.Text = Character.Constitution.ToString();
                _numUpDownCha.Text = Character.Charisma.ToString();

            };

            ValidateChildren();
        }

        private void SelectProfession ( Profession desiredItem )
        {
            foreach (var item in _comboProfession.Items)
            {
                if ((item as Profession).Name == desiredItem.Name)
                {
                    _comboProfession.SelectedItem = item;
                    return;
                };
            };
        }

        private void SelectRace ( Race desiredItem )
        {
            foreach (var item in _comboRace.Items)
            {
                if ((item as Race).Name == desiredItem.Name)
                {
                    _comboRace.SelectedItem = item;
                    return;
                };
            };
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

            var validationResults = new ObjectValidator().TryValidateFullObject(character);
            if (validationResults.Count() > 0)
            {
                //TODO: Fix this later using String.Join
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };

                MessageBox.Show(this, builder.ToString(), "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OnValidateRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Race is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Profession is required");
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

            if (value <= 0)
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

            if (value <= 0)
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

            if (value <= 0)
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

            if (value <= 0 )
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

            if (value <= 0)
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

        private void _numUpDownAgi_ValueChanged ( object sender, EventArgs e )
        {

        }
    }
}
