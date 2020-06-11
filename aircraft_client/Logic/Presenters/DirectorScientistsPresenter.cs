using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Data.BaseModel;

namespace aircraft_client.Logic.Presenters
{
    class DirectorScientistsPresenter:BaseDataPresenter<IDirectorScientistsView>
    {
        public DirectorScientistsPresenter
            (IApplicationController controller, IDirectorScientistsView view, IModel model)
        : base(controller, view, model)
        {
            View.LabsList += GetLabsByProduct;
            View.ProdsByLab += GetProductsByLab;
            View.ScientistListByProd += GetScientists;
        }

        private void GetLabsByProduct()
        {
            Controller.Run<ChoosePresenter<DirectorScientistsPresenter, IDirectorScientistsView>
                ,string,string>(Query.GetProductsNames(),"Выберите название изделия");
        }

        private void GetProductsByLab()
        {
            Controller.Run<ChooseLaboratoryPresenter
                , string, string>(Query.GetLaboratories(), "Выберите название изделия");
        }

        private void GetScientists()
        {
            Controller.Run<ChooseScientistPresenter
                , string>(Query.GetProductsNames());
        }

    }
}
