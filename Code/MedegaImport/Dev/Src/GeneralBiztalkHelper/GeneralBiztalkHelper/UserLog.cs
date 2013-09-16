using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralBiztalkHelper
{
    [Serializable]
    public class UserLog
    {
        #region Fields
        private Guid _Id;
        private string _LoggingWebserviceUrl;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the Logging Id
        /// </summary>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        public UserLog() { }

        /// <summary>
        /// Constructor: Fill in the properties with the given values
        /// </summary>
        /// <param name="webserviceUrl"></param>
        /// <remarks>
        /// 14-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public UserLog(string webserviceUrl)
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
        public void CreateLogging(Guid id, string userId, string nationalRegistryNb, string application, string request, string requestString)
        {
            this.Id = id;
            //-- Initiate the webservice
            riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging ws = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging();
            ws.Url = this.LoggingWebserviceUrl;
            ws.UseDefaultCredentials = true;

            riziv_inami.fgov.be.logging.UserLogInfo _logInfo = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.UserLogInfo();
            _logInfo.ID=id.ToString();
            _logInfo.UserId = userId;
            _logInfo.NationalRegistryNb = nationalRegistryNb;
            _logInfo.Application = application;
            _logInfo.Status = "Request";
            _logInfo.Request = request;
            _logInfo.RequestString = requestString;

            ws.SaveUserLogging(_logInfo);
        }
        /// <summary>
        /// Updates the status of the logging information
        /// </summary>
        /// <param name="newStatus">String: The new status</param>
        /// <remarks>
        /// 2914-05-2008 : Created by Frederik Van Lierde
        /// </remarks>
        public void UpdateStatus(string newStatus)
        {
            //-- Initiate the webservice
            riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging ws = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.WebService_Riziv_Applications_BizTalk_Logging();
            ws.Url = this.LoggingWebserviceUrl;
            ws.UseDefaultCredentials = true;

            riziv_inami.fgov.be.logging.UserLogInfo _logInfo = new GeneralBiztalkHelper.riziv_inami.fgov.be.logging.UserLogInfo();
            _logInfo.ID = this.Id.ToString();
            _logInfo.UserId = "";
            _logInfo.NationalRegistryNb = "";
            _logInfo.Application = "";
            _logInfo.Status = newStatus;
            _logInfo.Request = "";
            _logInfo.RequestString = "";
            

            ws.SaveUserLogging(_logInfo);
        }
        #endregion
    }
}
