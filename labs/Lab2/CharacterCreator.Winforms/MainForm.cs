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

        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CreateNewCharacter();

            form.ShowDialog();

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
    }
}