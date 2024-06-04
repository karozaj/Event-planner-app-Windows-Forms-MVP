using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_mvp.Views
{
    public partial class ShowDetailsView : Form
    {
        public ShowDetailsView(Models.Event e)
        {
            InitializeComponent();
            textBoxName.Text = e.Name;
            dateTimePicker.Value = e.Date;
            comboBoxType.Text = e.Type;

            string Priority = "Niski";
            if (e.Priority == 1)
                Priority = "Średni";
            else if (e.Priority == 2)
                Priority = "Wysoki";
            comboBoxPriority.Text = Priority;
            richTextBoxDescription.Text = e.Description;
        }

        private void ShowDetailsView_Load(object sender, EventArgs e)
        {

        }
    }
}
