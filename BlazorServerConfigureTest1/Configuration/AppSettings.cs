using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlazorServerConfigureTest1.Configuration
{
    public class AppSettings
    {
        public AppSettings()
        {
            string fileName = "BlazorServerConfigureTest1.appsettings.json";
            var stream = Assembly.GetExecutingAssembly()
                                 .GetManifestResourceStream(fileName);

            var configuration = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();

            IConfigurationSection appSettings = configuration.GetSection("appSettings");

            AdminEMail = appSettings.GetSection("AdminEMail").Value;
            UserChtName = appSettings.GetSection("UserChtName").Value;
            Title = appSettings.GetSection("Title").Value;

        }
        public string AdminEMail { get; private set; }
        public string UserChtName { get; private set; }
        public string Title { get; private set; }
    }
}
