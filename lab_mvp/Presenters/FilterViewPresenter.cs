using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mvp.Presenters
{
    internal class FilterViewPresenter
    {
        public bool IsFilteredByType { get; set; }
        public bool IsFilteredByPriority { get; set; }
        public bool IsFilteredByDate { get; set; }
        public string TypeFilter { get; set; }
        public int PriorityFilter { get; set; }
        public DateTime DateFilter { get; set; }

        private Views.FilterView _view;

        public FilterViewPresenter(Views.FilterView view)
        {
            IsFilteredByType = false;
            IsFilteredByPriority = false;
            IsFilteredByDate = false;
            _view = view;
            _view.AcceptEvent += SetFilters;
        }

        private void SetFilters(object sender, EventArgs e)
        {
            IsFilteredByType = _view.TypeFilterEnabled;
            IsFilteredByPriority = _view.PriorityFilterEnabled;
            IsFilteredByDate = _view.DateFilterEnabled;
            TypeFilter = _view.TypeFilter;
            if(_view.PriorityFilter=="Niski")
            {
                PriorityFilter = 0;
            }
            else if(_view.PriorityFilter=="Średni")
            {
                PriorityFilter = 1;
            }
            else if(_view.PriorityFilter=="Wysoki")
            {
                PriorityFilter = 2;
            }
            DateFilter = _view.DateFilter;

        }
    }
}
