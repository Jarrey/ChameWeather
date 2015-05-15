using Chame.WebService.Helper.Models;
using Chame.WebService.Helper.Services;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChameWeather.WebService.Library.Services
{
    public class ChameWeatherImageService : IChameService
    {
        private readonly ILog logger;

        public ChameWeatherImageService(ILog logger)
        {
            this.logger = logger;
        }

        public void Dispose()
        {
            // Not implement, to clean up instance
        }

        #region Properties

        public string ServiceName
        {
            get { return "ChameWeather.Service"; }
        }

        #endregion

        public Task<IChameResponse> ProcessImage(string request)
        {
            throw new NotImplementedException();
        }

        public Task<IChameResponse> GetCache()
        {
            throw new NotImplementedException();
        }

        public Task<IChameResponse> CleanCache(string id)
        {
            throw new NotImplementedException();
        }
    }
}
