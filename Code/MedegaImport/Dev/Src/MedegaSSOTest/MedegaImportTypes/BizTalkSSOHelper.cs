using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.BizTalk.SSOClient.Interop;

namespace MedegaImportTypes
{
    [Serializable]
    public static class BizTalkSSOHelper
    {
        public static string IssueSelfTicket(){
            ISSOTicket sso = new ISSOTicket();
            return sso.IssueTicket(0);
        }
    }
}
