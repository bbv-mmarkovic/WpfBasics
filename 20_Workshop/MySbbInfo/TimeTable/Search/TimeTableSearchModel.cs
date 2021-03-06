﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeTableSearchModel.cs" company="bbv Software Services AG">
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
//   Defines the TimeTableSearchModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MySbbInfo.TimeTable.Search
{
    using System;
    using System.ComponentModel;

    public class TimeTableSearchModel : INotifyPropertyChanged
    {
        private string to;

        public TimeTableSearchModel()
        {
            this.DepartureDateTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string From { get; set; }

        public string To
        {
            get
            {
                return this.to;
            }

            set
            {
                if (this.to != value)
                {
                    this.to = value;
                    this.OnPropertyChanged("To");
                }
            }
        }

        public DateTime DepartureDateTime { get; set; }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}