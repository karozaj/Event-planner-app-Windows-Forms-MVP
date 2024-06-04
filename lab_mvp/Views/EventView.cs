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
    public partial class EventView : Form
    {
        public event EventHandler AddEventEvent;
        public event EventHandler RemoveEventEvent;
        public event EventHandler SaveEvent;
        public event EventHandler LoadEvent;
        public event EventHandler SortEvent;
        public event EventHandler ShowDetailsEvent;
        public event EventHandler FilterEvent;
        public event EventHandler CancelFilterEvent;

        public string SortAttribute { get => comboBoxSort.Text; }
        public Models.Event SelectedEvent { get => (Models.Event)dataGridViewEvents.CurrentRow.DataBoundItem;}

        public EventView()
        {
            InitializeComponent();
            _associateAndRaiseViewEvents();
            dataGridViewEvents.AllowUserToAddRows = false;
        }

        public void SetEventListBindingSource(BindingSource eventList)
        {
            dataGridViewEvents.DataSource = eventList;
        }

        private void _associateAndRaiseViewEvents()
        {
            buttonAdd.Click += (sender, e) =>
            {
                AddEventEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonRemove.Click += (sender, e) =>
            {
                RemoveEventEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonSave.Click += (sender, e) =>
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonLoad.Click += (sender, e) =>
            {
                LoadEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonSort.Click += (sender, e) =>
            {
                SortEvent?.Invoke(this, EventArgs.Empty);
            };

            dataGridViewEvents.RowHeaderMouseDoubleClick += (sender, e) =>
            {
                ShowDetailsEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonFilter.Click += (sender, e) =>
            {
                FilterEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonFilterCancel.Click += (sender, e) =>
            {
                CancelFilterEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventView_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //AddEventView v2 = new AddEventView();
            //v2.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

           // dataGridViewEvents.Rows.Remove(dataGridViewEvents.CurrentRow);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            //List<Models.Event> list = dataGridViewEvents.DataSource;
           //BindingSource src =(BindingSource) dataGridViewEvents.DataSource;
            //src.Filter = "Typ='Rodzina'";
            //dataGridViewEvents.DataSource = src;
           
        }

        private void comboBoxFilterPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
