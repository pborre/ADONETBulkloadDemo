using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralBiztalkHelper
{
    [Serializable]
    public class ServiceLog
    {
        #region Fields
        private Int64 _Id;
        private string _LoggingWebserviceUrl;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the Logging Id
        /// </summary>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public Int64 Id
        {
            get { return _Id; }
            set { _Id= value; }
        }

        /// <summary>
        /// Gets or sets the LoggingWebserviceUrl
        /// </summary>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public string LoggingWebserviceUrl
        {
            get { return _LoggingWebserviceUrl == string.Empty ? "" : _LoggingWebserviceUrl; }
            set { _LoggingWebserviceUrl = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public ServiceLog() { }

        /// <summary>
        /// Constructor: Fill in the properties with the given values
        /// </summary>
        /// <param name="webserviceUrl"></param>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public ServiceLog(string webserviceUrl)
        {
            this.LoggingWebserviceUrl = webserviceUrl;
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Create a new logging in the central logging system
        /// </summary>
        /// <param name="applicationName">String: Name of the Application</param>
        /// <param name="serviceName">String: Name of the Service within the Application</param>
        /// <param name="serviceName">String: Type used when tranferring data (FTP, FILE, ...)</param>
        /// <param name="serviceName">String: Name of the file transfered</param>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public void CreateLogging(string applicationName, string serviceName, string serviceType, string serviceFileName)
        {
            //-- Initiate the webservice
            riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging ws = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging();
            ws.Url = this.LoggingWebserviceUrl;
            ws.UseDefaultCredentials = true;

            riziv_inami.fgov.be.logging.LogInfo _logInfo = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.LogInfo();
            _logInfo.ServiceLogID = "0";
            _logInfo.ApplicationName = applicationName;
            _logInfo.ServiceName = serviceName;
            _logInfo.ServiceType = serviceType;
            _logInfo.ServiceState = "Started";
            _logInfo.ServiceFileName = serviceFileName;

            string result = ws.SaveServiceLogging(_logInfo);
            this.Id = result == string.Empty ? 0 : Convert.ToInt64(result);
        }

        /// <summary>
        /// Upates the status of the current logging
        /// </summary>
        /// <param name="newStatus">String : New status</param>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public void UpdateStatus(string newStatus)
        {
            //-- Initiate the webservice
            riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging ws = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging();
            ws.Url = this.LoggingWebserviceUrl;
            ws.UseDefaultCredentials = true;

            riziv_inami.fgov.be.logging.LogInfo _logInfo = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.LogInfo();
            _logInfo.ServiceLogID = this.Id.ToString();
            _logInfo.ApplicationName = "";
            _logInfo.ServiceName = "";
            _logInfo.ServiceType = "";
            _logInfo.ServiceState = newStatus;
            _logInfo.ServiceFileName = "";

            string result = ws.SaveServiceLogging(_logInfo);
            this.Id = result == string.Empty ? 0 : Convert.ToInt64(result);
        }
        #endregion
    }
}
