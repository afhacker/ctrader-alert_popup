﻿using cAlgo.API.Alert.Models;
using System.Collections.Generic;
using System.Configuration;

namespace cAlgo.API.Alert.Settings
{
    public class DataGridSettings : ApplicationSettingsBase
    {
        public DataGridSettings()
        {
        }

        public DataGridSettings(string settingsKey) : base(settingsKey)
        {
        }

        [UserScopedSetting]
        public List<DataGridColumnSettingsModel> ColumnsSetting
        {
            get => (List<DataGridColumnSettingsModel>)this["ColumnsSetting"];
            set => this["ColumnsSetting"] = value;
        }
    }
}