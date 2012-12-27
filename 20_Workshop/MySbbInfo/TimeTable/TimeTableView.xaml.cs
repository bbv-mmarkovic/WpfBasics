﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeTableView.cs" company="bbv Software Services AG">
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
//   Interaction logic for TimeTableControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MySbbInfo.TimeTable
{
    using System.Windows.Controls;

    using SbbApi;

    /// <summary>
    /// Interaction logic for TimeTableControl.xaml
    /// </summary>
    public partial class TimeTableView : UserControl
    {
        public TimeTableView()
        {
            this.InitializeComponent();
        }

        public void Initialize(ITransportService transportService)
        {
            this.DataContext = new TimeTableViewModel(transportService);
        }
    }
}