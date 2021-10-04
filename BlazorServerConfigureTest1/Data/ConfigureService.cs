using BlazorServerConfigureTest1.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerConfigureTest1.Data
{
    public class ConfigureService
    {
        private readonly IConfiguration _configuration;

        public ConfigureService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<string> GetConfigValue(string sectionName)
        {
            return Task.Factory.StartNew(() => 
                _configuration.GetSection("appSettings").GetSection(sectionName).Value); 
        }
    }
}
