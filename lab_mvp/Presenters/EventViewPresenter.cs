using lab_mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_mvp.Presenters
{
    internal class EventViewPresenter
    {
        private Models.IEventRepository _repository;
        private Views.EventView _view;
        private BindingSource _bindingSource;
        private IEnumerable<Models.Event> _eventsList;

        private List<Models.Event> _filteredList;

        private bool _isFilteredByType;
        private bool _isFilteredByPriority;
        private bool _isFilteredByDate;
        private string _typeFilter;
        private int _priorityFilter;
        private DateTime _dateFilter;

        public EventViewPresenter(Views.EventView view, Models.IEventRepository repository)
        {
            _view = view;
            _repository = repository;
            _bindingSource = new BindingSource();

            _view.AddEventEvent += Add;
            _view.RemoveEventEvent += Remove;
            _view.SaveEvent += Save;
            _view.LoadEvent += Load;
            _view.SortEvent += Sort;
            _view.ShowDetailsEvent += ShowDetails;
            _view.FilterEvent += Filter;
            _view.CancelFilterEvent += ResetFilterClick;
            _view.SetEventListBindingSource(_bindingSource);

            ResetFilter();

            LoadList();
        }

        public void Add(object sender, EventArgs e)
        {
            Views.AddEventView addView = new Views.AddEventView();
            Presenters.AddEventViewPresenter presenter = new Presenters.AddEventViewPresenter(addView);
            addView.ShowDialog();
            if(addView.DialogResult==DialogResult.OK)
            {
                _repository.Add(presenter.NewEvent);
            }
            LoadList();
        }

        public void Remove(object sender, EventArgs e)
        {
            if (_filteredList.Count()>0)
            {
                _repository.Remove(_view.SelectedEvent);
                 LoadList();
            }
        }

        private void LoadList()
        {
            // pobranie wszystkich osó
            _eventsList = _repository.GetAll();

            _filteredList = new List<Event>();
            foreach (var e in _eventsList)
            {
                _filteredList.Add(e);
            }

            //foreach (var e in _eventsList)
            //{
            //    if(_isFilteredByDate && e.Type==_typeFilter)
            //        _filteredList.Add(e);
            //}

            foreach (var e in _eventsList)
            {
                if (_isFilteredByType == true && e.Type != _typeFilter)
                {
                    _filteredList.Remove(e);
                }
                else if (_isFilteredByPriority == true && e.Priority != _priorityFilter)
                {
                    _filteredList.Remove(e);
                }
                else if (_isFilteredByDate == true && e.Date.Date != _dateFilter.Date)
                {
                    _filteredList.Remove(e);
                }
            }
            //_eventsList = _filteredList;
            // załadowanie źródła danych pobraną listą
            _bindingSource.DataSource = _filteredList;
            //_bindingSource.DataSource = _filteredList;
        }

        private void Save(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML file|*.xml";
            sfd.RestoreDirectory = true;
            sfd.FileName = "events";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveState Save = new SaveState();
                Save.SaveToXMLFile((List<Event>)_repository.GetAll(), sfd.FileName);
            }
        }

        private void Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML file|*.xml";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadState Load = new LoadState();
                    _repository.SetList(Load.LoadFromFile(ofd.FileName));
                    LoadList();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Wystąpił błąd: " + exc.Message);
                }
            }
        }

        private void Sort(object sender, EventArgs e)
        {
            _repository.Sort(_view.SortAttribute);
            LoadList();
        }

        private void ShowDetails(object sender, EventArgs e)
        {
            if (_repository.GetAll().Count() > 0)
            {
                Views.ShowDetailsView detView = new Views.ShowDetailsView(_view.SelectedEvent);
                detView.ShowDialog();
            }
        }

        private void Filter(object sender, EventArgs e)
        {
            Views.FilterView filterView = new Views.FilterView();
            Presenters.FilterViewPresenter filterPresenter = new Presenters.FilterViewPresenter(filterView);
            filterView.ShowDialog();
            if (filterView.DialogResult == DialogResult.OK)
            {
                _isFilteredByType = filterPresenter.IsFilteredByType;
                _isFilteredByPriority = filterPresenter.IsFilteredByPriority;
                _isFilteredByDate = filterPresenter.IsFilteredByDate;
                _typeFilter = filterPresenter.TypeFilter;
                _priorityFilter = filterPresenter.PriorityFilter;
                _dateFilter = filterPresenter.DateFilter;
            }
            LoadList();
        }

        private void ResetFilter()
        {
            _isFilteredByType = false;
            _isFilteredByPriority = false;
            _isFilteredByDate = false;
            _typeFilter = "";
            _priorityFilter = 0;
            _dateFilter = DateTime.MinValue.Date;
        }

        private void ResetFilterClick(object sender, EventArgs e)
        {
            ResetFilter();
            LoadList();
        }
    }

}
