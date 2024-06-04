using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mvp.Presenters
{
    internal class AddEventViewPresenter
    {
        private Views.AddEventView _view;
        public Models.Event NewEvent;
        public AddEventViewPresenter(Views.AddEventView view)
        {
            _view = view;
            _view.AddButtonEvent += CreateEvent;
        }

        public void ShowView()
        {
            _view.ShowDialog();
        }
        private void CreateEvent(object sender, EventArgs e)
        {
            int Priority = 0;
            if(_view.Priority=="Średni")
            {
                Priority = 1;
            }
            else if(_view.Priority=="Wysoki")
            {
                Priority = 2;
            }
            NewEvent = new Models.Event(
                _view.Name,
                _view.Date,
                _view.Type,
                Priority,
                _view.Description);
        }
        


    }
}
