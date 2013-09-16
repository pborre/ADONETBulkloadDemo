using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.BizTalk.SSOClient.Interop;

namespace CODit.BizTalkHelpers
{
    [Serializable]
    public class BizTalkSSOHelper
    {
        public string IssueSelfTicket(){
            ISSOTicket sso = new ISSOTicket();
            return sso.IssueTicket(0);
        }
    }
}
