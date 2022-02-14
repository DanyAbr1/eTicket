using EticketApp.Data;
using EticketApp.Models;
using EticketApp.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;

namespace EticketApp.ViewModels
{
    public class GeneralInformationViewModel : ViewModelBase
    {
        ObservableCollection<Country> _countries;
        ObservableCollection<State> _states;
        ObservableCollection<City> _cities;



        public GeneralInformationViewModel()
        {
            LoadContries();
        }

        public ObservableCollection<Country> Countries
        {
            get { return _countries; }
            set
            {
                _countries = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<State> States
        {
            get { return _states; }
            set
            {
                _states = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                OnPropertyChanged();
            }
        }

        private City _citySelected;
        public City CitySelected
        {
            get { return _citySelected; }
            set
            {
                _citySelected = value;
                OnPropertyChanged();
            }
        }

        private State _stateSelected;
        public State StateSelected
        {
            get { return _stateSelected; }
            set
            {
                _stateSelected = value;
                OnPropertyChanged();
            }
        }

        private Country _countrySelected;
        public Country CountrySelected
        {
            get { return _countrySelected; }
            set
            {
                _countrySelected = value;
                OnPropertyChanged();
            }
        }


        public void LoadContries()
        {
            Countries = new ObservableCollection<Country>();
            var lista = new LocationData();
            lista.ListOfContries.ForEach(c => Countries.Add(c));
        }

        public void LoadStateByCountry()
        {
            States = new ObservableCollection<State>();
            if (CountrySelected != null)
            {
                var lista = new LocationData();
                var state = lista.ListOfState.Where(o => o.Id_country == CountrySelected.Id);
                state.ToList().ForEach(s => States.Add(s));                
            }
        }


        //public async void LoadCityByState()
        //{
        //    if (StateSelected != null)
        //    {
        //        Cities = new ObservableCollection<City>();
        //        var lista = new LocationData();
        //        var cities = await lista.ListOfCities.Where(o => o.Id_state == StateSelected.Id);
        //        cities.ToList().ForEach(c => Cities.Add(c));
        //    }
        //}
    }
}

