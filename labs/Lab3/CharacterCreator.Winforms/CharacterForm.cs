/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 3
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;

using CharacterCreator.Professions;

namespace CharacterCreator.Winforms
{
    /// <summary>Provides a UI for creating a character.</summary>
    public partial class CharacterForm : Form
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="CharacterForm"/> class.</summary>
        public CharacterForm ()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>Gets or sets the selected character.</summary>
        public Character SelectedCharacter { get; set; }

        //Called when the form loads
        protected override void OnLoad ( EventArgs e )
        {
            //Load the UI
            LoadUI();
        }

        #region Event Handlers

        //Called when the Save button is clicked
        private void OnSave ( object sender, EventArgs e )
        {            
            //Save the changes
            var character = SaveCharacter();
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };

            //Close the form
            SelectedCharacter = character;
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private Members

        private void LoadUI ()
        {
            LoadProfessions();
            LoadRaces();

            if (SelectedCharacter != null)
            {
                Text = "Edit Character";
                LoadCharacter(SelectedCharacter);
            };
        }

        private void LoadProfessions ()
        {
            //Bind to the standard professions 
            _cbProfession.DataSource = StandardProfessions.Professions;

            //Don't select anything by default
            _cbProfession.SelectedIndex = -1;
        }

        private void LoadRaces ()
        {
            //Bind to the standard races
            _cbRace.DataSource = StandardRaces.Races;

            //Don't select anything by default
            _cbRace.SelectedIndex = -1;
        }

        private void LoadCharacter ( Character character )
        {
            _txtName.Text = character.Name;
            SelectProfession(character.Profession);
            SelectRace(character.Race);
            _txtBiography.Text = character.Biography;

            _txtStrength.Value = character.Strength;
            _txtIntelligence.Value = character.Intelligence;
            _txtAgility.Value = character.Agility;
            _txtConstitution.Value = character.Constitution;
            _txtCharisma.Value = character.Charisma;
        }

        private Character SaveCharacter ( )
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _cbProfession.SelectedItem as Profession;
            character.Race = _cbRace.SelectedItem as Race;
            character.Biography = _txtBiography.Text;

            character.Strength = (int)_txtStrength.Value;
            character.Intelligence = (int)_txtIntelligence.Value;
            character.Agility = (int)_txtAgility.Value;
            character.Constitution = (int)_txtConstitution.Value;
            character.Charisma = (int)_txtCharisma.Value;

            return character;
        }

        private void SelectProfession ( Profession desiredItem )
        {
            foreach (var item in _cbProfession.Items)
            {
                if ((item as Profession).Name == desiredItem.Name)
                {
                    _cbProfession.SelectedItem = item;
                    return;
                };
            };
        }

        private void SelectRace ( Race desiredItem )
        {
            foreach (var item in _cbRace.Items)
            {
                if ((item as Race).Name == desiredItem.Name)
                {
                    _cbRace.SelectedItem = item;
                    return;
                };
            };
        }
        #endregion

        #region ErrorProvider
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

            if (value <= 0)
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

        #endregion
    }
}
