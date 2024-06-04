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
    public partial class AddEventView : Form
    {
        public event EventHandler AddButtonEvent;

        public string Name { get => textBoxName.Text; set => textBoxName.Text = value; }
        public DateTime Date { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public string Type { get=> comboBoxType.Text; set=>comboBoxType.Text=value; }
        public string Priority { get=>comboBoxPriority.Text; set=>comboBoxPriority.Text=value; } //0-low 1-medium 2-high
        public string Description { get =>richTextBoxDescription.Text; set=>richTextBoxDescription.Text=value; }
        public AddEventView()
        {
            InitializeComponent();
            _associateAndRaiseViewEvents();
            buttonAdd.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            textBoxName.Text = "";
            comboBoxType.SelectedItem = "Praca";
            comboBoxPriority.SelectedItem = "Niski";

        }

        private void _associateAndRaiseViewEvents()
        {
            buttonAdd.Click += (sender, e) =>
            {
                AddButtonEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        private void AddEventView_Load(object sender, EventArgs e)
        {

        }
    }
}
