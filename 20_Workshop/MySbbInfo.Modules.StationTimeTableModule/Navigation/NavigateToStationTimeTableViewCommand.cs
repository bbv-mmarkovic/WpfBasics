﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigateToStationTimeTableViewCommand.cs" company="bbv Software Services AG">
//   Copyright (c) 2013
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MySbbInfo.Modules.StationTimeTableModule.Navigation
{
    using System;
    using System.ComponentModel.Composition;

    using Microsoft.Practices.Prism.Regions;

    using MySbbInfo.Infrastructure;
    using MySbbInfo.Modules.StationTimeTableModule.Content;

    [Export(typeof(INavigateToStationTimeTableViewCommand))]
    public class NavigateToStationTimeTableViewCommand : INavigateToStationTimeTableViewCommand
    {
        private static readonly Uri StationTimeTableViewUri = new Uri(typeof(StationTimeTableView).Name, UriKind.Relative);

        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public NavigateToStationTimeTableViewCommand(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public event EventHandler CanExecuteChanged = (sender, args) => { };

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.regionManager.RequestNavigate(Regions.ContentRegion, StationTimeTableViewUri);
        }
    }
}