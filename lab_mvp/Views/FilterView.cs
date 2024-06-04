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
    public partial class FilterView : Form
    {
        public bool TypeFilterEnabled { get =>checkBoxType.Checked; }
        public bool PriorityFilterEnabled { get => checkBoxPriority.Checked; }
        public bool DateFilterEnabled { get => checkBoxDate.Checked; }
        public string TypeFilter { get => comboBoxFilterType.Text; }
        public string PriorityFilter { get => comboBoxFilterPriority.Text; }
        public DateTime DateFilter { get => dateTimePickerFilter.Value.Date; }

        public event EventHandler AcceptEvent;

        public FilterView()
        {
            InitializeComponent();
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonAccept.DialogResult = DialogResult.OK;
            comboBoxFilterType.Text = "Praca";
            comboBoxFilterPriority.Text = "Niski";
            _associateAndRaiseViewEvents();
        }

        private void FilterView_Load(object sender, EventArgs e)
        {

        }

        private void _associateAndRaiseViewEvents()
        {
            buttonAccept.Click += (sender, e) =>
            {
                AcceptEvent?.Invoke(this, EventArgs.Empty);
            };

        }
    }
}
