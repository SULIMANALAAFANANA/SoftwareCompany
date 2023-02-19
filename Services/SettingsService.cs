using SoftwareCompany.Models;
using SoftwareCompany.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SoftwareCompany.Models;
using Newtonsoft.Json;

namespace SoftwareCompany.Services
{
    public class SettingsService
    {
        private readonly ApplicationDbContext _context;
        private List<Setting> settingsList;

        public SettingsService(ApplicationDbContext context)
        {
            _context = context;

            settingsList = _context.Settings.ToList();
        }

        public Setting GetSetting()
        {
            var str = JsonConvert.SerializeObject(settingsList.ToDictionary(x => x.KKey, x => x.KVal));
            var data = JsonConvert.DeserializeObject<Setting>(str);

            return data;
        }


        public List<Setting> GetAllSettings()
        {
            return settingsList;
        }


        public string GetSetting(Models.SettingsKey key)
        {
            var setting = settingsList.FirstOrDefault(x => x.KKey == key.ToString());
            var value = setting == null ? null : string.IsNullOrEmpty(setting.KVal) ? setting.DefaultValue : setting.KVal;
            return value;
        }


        public string SetSetting(Models.SettingsKey key, string value)
        {

            return SetSetting(key.ToString(), value);
        }



        public string SetSetting(string key, string value)
        {
            var setting = _context.Settings.Find(key);

            if (setting == null)
            {
                setting = new Setting()
                {
                    KKey = key.ToString(),
                    Title = key.ToString(),
                    KVal = value,
                    DefaultValue = " ",
                    Group = "",
                };
                _context.Settings.Add(setting);
            }
            else
            {
                setting.KVal = value;
                _context.Settings.Update(setting);
            }

            //_context.SaveChanges();
            return setting.KVal;
        }

        public List<Setting> GetTaltelecomSetting()
        {
            var data = _context.Settings.Where(x => x.Group == "TalTelecom").ToList();
            return data;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}