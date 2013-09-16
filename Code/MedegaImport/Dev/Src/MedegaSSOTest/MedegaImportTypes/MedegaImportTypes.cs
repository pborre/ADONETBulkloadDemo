using System;
using System.Collections.Generic;
using System.Text;

namespace MedegaImport.MedegaImportTypes
{
    public enum MedegaFileStatusEnum : int
    {
        Pending = 1,
        Done = 2,
        BusinessRuleFailed = 3,
        Error = 4,
        New = 5
    }

}
