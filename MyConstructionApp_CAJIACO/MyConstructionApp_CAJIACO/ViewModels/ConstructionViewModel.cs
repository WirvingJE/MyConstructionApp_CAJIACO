using MyConstructionApp_CAJIACO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MyConstructionApp_CAJIACO.ViewModels
{
    public class ConstructionViewModel : BaseViewModel
    {
        public Construction MyConstruction { get; set; }    

        public ConstructionViewModel()
        {
            MyConstruction = new Construction();    

        }

        public async Task<ObservableCollection<Construction>> GetConstructionsAsync(int pUserID)
        {
            if (IsBusy) return null;
            IsBusy = true;

            try
            {
                ObservableCollection<Construction> construction = new ObservableCollection<Construction>();

                MyConstruction.UserId = pUserID;

                construction = await MyConstruction.GetConstructionListByUser();

                if (construction == null)
                {
                    return null;
                }
                return construction;

            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }


    }
}
