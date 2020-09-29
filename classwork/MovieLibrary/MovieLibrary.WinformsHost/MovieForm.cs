using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieLibrary.WinformsHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        private void label3_Click ( object sender, EventArgs e )
        {

        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            var movie = new Movie();
            movie.Name =_txtName.Text;
            movie.Description =_txtDescription.Text;
            movie.Rating =_comboRating.SelectedText;
            movie.IsClassic =_chkClassic.Checked;

            movie.RunLength =ReadAsInt32(_txtRunLength);
            movie.ReleaseYear=ReadAsInt32(_txtReaseYear);
            //TO DO: fix validation
            var error = movie.Validate();
            if(!String.IsNullOrEmpty(error))
            {
                //Show error message - use for standard messages
                MessageBox.Show(error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            };

            //TO DO: Return movie
            Close();
        }

        private int ReadAsInt32( Control control)
        {
            var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }
        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
    }
}
