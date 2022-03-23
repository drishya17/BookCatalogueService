using Common.Logging;
using Microsoft.Extensions.Configuration;

namespace BookCatalogueService.Services
{
    public class ProducerScopeFactory : IProducerScopeFactory
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogManager _logManager;


        /// <summary>
        /// The Configuration
        /// </summary>
        private IConfigurationRoot _configuration { get; }

        /// <summary>
        /// Initializes a new instance of ProducerScopeFactory
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="momService"></param>
        /// <param name="logManager"></param>
        public ProducerScopeFactory(IConfiguration configuration, ILogManager logManager)
        {
            _logManager = logManager;
            _configuration = (IConfigurationRoot)configuration;

        }

        ///// <summary>
        ///// Get new producer scope.
        ///// </summary>
        ///// <returns></returns>
        //public IProducerScope Get()
        //{
        //    //return new IProducerScope();
        //}

        /// <summary>
        /// RabbitMQ Connection SettingsRabbitMQ Connection Settings
        /// </summary>
        private ConnectionSettings RabbitMQConnectionSettings
        {
            get
            {
                var rabbitConfigurationSection = _configuration.GetSection("rabbitMqConnectionSettings");
                var rabbitMqServerUrl = rabbitConfigurationSection.GetValue<string>("serverUrl");
                var rabbitMqUserName = rabbitConfigurationSection.GetValue<string>("userName");
                var rabbitMqPassword = rabbitConfigurationSection.GetValue<string>("password");
                var rabbitMqEnvironment = rabbitConfigurationSection.GetValue<string>("environment");
                var xpoConfigurationSection = _configuration.GetSection("xpo");
                var environment = xpoConfigurationSection.GetValue<string>("environment");
                var applicationName = xpoConfigurationSection.GetValue<string>("applicationName");

                return ConnectionSettings.FromValues(rabbitMqServerUrl, applicationName, rabbitMqEnvironment ?? environment, rabbitMqUserName, rabbitMqPassword);
            }
        }
    }

    internal class ConnectionSettings
    {
        internal static ConnectionSettings FromValues(string rabbitMqServerUrl, string applicationName, string v, string rabbitMqUserName, string rabbitMqPassword)
        {
            throw new System.NotImplementedException();
        }
    }
}
