/*
 * ITSE 1430
 * Kiet Vo
 * Lab 2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            Character character;
            character = new Character();

            character.Name =  "Karthus";
            character.Profession = "Wizard";
            character.Race = "Gnome";
            character.Intelligence = 90;
            character.Strength = 20;
            character.Agility = 40;
            character.Charisma = 20;
            character.Constitution = 50;
            character.Description = "Undead Wizard";

            toolStripMenuItem2.Click += OnExit;
            toolStripMenuItem4.Click += OnHelpAbout;
            toolStripMenuItem6.Click += OnCharacterNew;
            toolStripMenuItem10.Click += OnCharacterDelete;
            toolStripMenuItem9.Click += OnCharacterEdit;
        }

        private CharacterDatabase _characters = new CharacterDatabase();

        private void AddCharacter ( Character character )
        {
            var newMovie = _characters.Add(character, out var message);
            if (newMovie == null)
            {
                MessageBox.Show(this, message, "Add Failed", MessageBoxButtons.OK);
                return;
            };

            RefreshUI();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CreateNewCharacter();

            var result = form.ShowDialog(this);  
            if (result == DialogResult.Cancel)
                return;

            AddCharacter(form.Character);

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        private void OnExit ( object sender, EventArgs e )
        {
            Close();
        }

        private Character GetSelectedCharacter ()
        {
            return _lstCharacters.SelectedItem as Character;
        }

        private void RefreshUI ()
        {
            _lstCharacters.DataSource = null;
            _lstCharacters.DataSource = _characters.GetAll();

        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            switch (MessageBox.Show(this, $"Are you sure you want to delete '{character.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            };

            DeleteCharacter(character.Id);
            RefreshUI();
        }

        private void DeleteCharacter ( int id )
        {
            _characters.Delete(id);
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;
            var form = new CreateNewCharacter(character, "Edit Character");

            var result = form.ShowDialog(this);  
            if (result == DialogResult.Cancel)
                return;

            EditCharacter(character.Id, form.Character);
        }

        private void EditCharacter ( int id, Character character )
        {
            var error = _characters.Update(id, character);
            if (String.IsNullOrEmpty(error))
            {
                RefreshUI();
                return;
            };

            MessageBox.Show(this, error, "Edit Character", MessageBoxButtons.OK);
        }
    }
}