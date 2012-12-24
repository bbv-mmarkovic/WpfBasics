﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="bbv Software Services AG">
//   Copyright (c) 2012
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
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MySbbInfo
{
    using System.Text;
    using System.Windows;

    using SbbApi;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly TransportApi transportApi;

        public MainWindow()
        {
            InitializeComponent();

            this.transportApi = new TransportApi();
            this.TimeTable.Initialize(this.transportApi);
        }

        private void LoadStationboardClick(object sender, RoutedEventArgs e)
        {
            var strb = new StringBuilder();

            var stationboard = this.transportApi.GetStationBoard(this.txtStation.Text);
            foreach (var stop in stationboard)
            {
                var part = string.Format("Ziel: {0}, Abfahrt: {1}, mittels: {2}", stop.To, stop.Stop.Departure, stop.Name);
                strb.Append(part);

                if (!string.IsNullOrEmpty(stop.Stop.Delay))
                {
                    part = string.Format(", Verspätung: {0}", stop.Stop.Delay);
                    strb.Append(part);
                }

                this.stationBoardResult.Items.Add(strb.ToString());
                strb.Clear();
            }
        }

        private void SearchStationClick(object sender, RoutedEventArgs e)
        {
            var locations = this.transportApi.GetLocations(this.txtStationQuery.Text);

            foreach (var location in locations)
            {
                this.stationResult.Items.Add(location.Name);
            }
        }
    }
}
