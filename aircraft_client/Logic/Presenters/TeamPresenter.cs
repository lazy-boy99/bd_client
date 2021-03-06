﻿using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Formatter.QueryFormatter;

namespace aircraft_client.Logic.Presenters
{
    public class TeamPresenter : BaseDataPresenter<ITeamView>
    {
        public TeamPresenter(IApplicationController controller, ITeamView view, IModel model) : base(controller, view, model)
        {
            View.Squad += ChooseSquad;
            View.Back += Controller.Run<DirectorWorkersPresenter>;
        }

        private void ChooseSquad()
        {
            var queryListWs = SelectFormatter.Get("name", "workshops");
            var queryListSec = SelectFormatter.Get("name", "sectors");
            Controller.Run<TeamChoosePresenter, string, string>(queryListWs, queryListSec);
        }
    }
}
