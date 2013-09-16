using System;
using System.Collections.Generic;
using System.Text;

namespace MedegaImport.MedegaImportTypes
{
    public enum MedegaFileStatusEnum : int
    {
        ImportStarted = 1,
        Pending = 2,
        InError = 3,
        NotValid = 4,
        ImportDone = 5,
        Paid = 6
    }

    public enum MedegaNodeStatus : int
    {
        ImportStarted = 1,
        InError = 2,
        NotValid = 3,
        ImportDone = 4
    }

    public class NodeStatus
    {
        public string ImportStartedStringValue()
        {
            return System.Convert.ToInt32(MedegaNodeStatus.ImportStarted).ToString();
        }
    }
}
