
#pragma warning disable 162

namespace MedegaImport.GuardsImportService.GuardsImportService_
{

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_2.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.String' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='string' nillable='true' type='xs:string' />
</xs:schema>",
        @"string",
        null,
        typeof(System.String),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_String__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_String__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.String); } }
        public System.String TypedValue { get { return (System.String) this.RetrieveAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        public System.String WriteableTypedValue { get { return (System.String) this.RetrieveForWriteAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.String); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "MedegaImport.GuardsImportService.GuardsImportService.ImportMedegaXml",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any),
            typeof(System.String)
        },
        new string[]{
            "medegaXml",
            "xmlFileName"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__),
            typeof(__System_String__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class ImportMedegaXml_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ medegaXml;
        public __System_String__ xmlFileName;

        private void __CreatePartWrappers()
        {
            medegaXml = new __Microsoft_XLANGs_BaseTypes_Any__(this, "medegaXml", 0);
            this.AddPart("medegaXml", 0, medegaXml);
            xmlFileName = new __System_String__(this, "xmlFileName", 1);
            this.AddPart("xmlFileName", 1, xmlFileName);
        }

        public ImportMedegaXml_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_2.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.Guid' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:import schemaLocation='System.Guid.1' namespace='http://microsoft.com/wsdl/types/' />
  <xs:element name='guid' xmlns:q1='http://microsoft.com/wsdl/types/' type='q1:guid' />
</xs:schema>",
        @"guid",
        null,
        typeof(System.Guid),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_Guid__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_Guid__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.Guid); } }
        public System.Guid TypedValue { get { return (System.Guid) this.RetrieveAs(typeof(System.Guid)); } set { this.LoadFrom(value); } }
        public System.Guid WriteableTypedValue { get { return (System.Guid) this.RetrieveForWriteAs(typeof(System.Guid)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.Guid); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "MedegaImport.GuardsImportService.GuardsImportService.ImportMedegaXml",
        new System.Type[]{
            typeof(System.Guid)
        },
        new string[]{
            "ImportMedegaXmlResult"
        },
        new System.Type[]{
            typeof(__System_Guid__)
        },
        0,
        @"guid"
    )]
    [System.SerializableAttribute]
    sealed public class ImportMedegaXml_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_Guid__ ImportMedegaXmlResult;

        private void __CreatePartWrappers()
        {
            ImportMedegaXmlResult = new __System_Guid__(this, "ImportMedegaXmlResult", 0);
            this.AddPart("ImportMedegaXmlResult", 0, ImportMedegaXmlResult);
        }

        public ImportMedegaXml_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "MedegaImport.GuardsImportService.GuardsImportService.GetImportMedegaXmlResults",
        new System.Type[]{
            typeof(System.Guid)
        },
        new string[]{
            "trackingId"
        },
        new System.Type[]{
            typeof(__System_Guid__)
        },
        0,
        @"guid"
    )]
    [System.SerializableAttribute]
    sealed public class GetImportMedegaXmlResults_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_Guid__ trackingId;

        private void __CreatePartWrappers()
        {
            trackingId = new __System_Guid__(this, "trackingId", 0);
            this.AddPart("trackingId", 0, trackingId);
        }

        public GetImportMedegaXmlResults_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_2.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.Object' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='anyType' nillable='true' />
</xs:schema>",
        @"anyType",
        null,
        typeof(System.Object),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_Object__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_Object__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.Object); } }
        public System.Object TypedValue { get { return (System.Object) this.RetrieveAs(typeof(System.Object)); } set { this.LoadFrom(value); } }
        public System.Object WriteableTypedValue { get { return (System.Object) this.RetrieveForWriteAs(typeof(System.Object)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.Object); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "MedegaImport.GuardsImportService.GuardsImportService.GetImportMedegaXmlResults",
        new System.Type[]{
            typeof(System.Object)
        },
        new string[]{
            "GetImportMedegaXmlResultsResult"
        },
        new System.Type[]{
            typeof(__System_Object__)
        },
        0,
        @"anyType"
    )]
    [System.SerializableAttribute]
    sealed public class GetImportMedegaXmlResults_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_Object__ GetImportMedegaXmlResultsResult;

        private void __CreatePartWrappers()
        {
            GetImportMedegaXmlResultsResult = new __System_Object__(this, "GetImportMedegaXmlResultsResult", 0);
            this.AddPart("GetImportMedegaXmlResultsResult", 0, GetImportMedegaXmlResultsResult);
        }

        public GetImportMedegaXmlResults_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.GuardsImportService.Reference.ImportMedegaGuardRequest _schema = new MedegaImport.GuardsImportService.Reference.ImportMedegaGuardRequest();

        public __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "MedegaImport.GuardsImportService.GuardsImportService.ImportMedegaGuard",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.Reference.ImportMedegaGuardRequest)
        },
        new string[]{
            "medegaGuardRequest"
        },
        new System.Type[]{
            typeof(__MedegaImport_GuardsImportService_Reference_ImportMedegaGuardRequest__)
        },
        0,
        @"http://riziv.fgov.be/GuardsImportService#ImportMedegaGuardRequest"
    )]
    [System.SerializableAttribute]
    sealed public class ImportMedegaGuard_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardRequest__ medegaGuardRequest;

        private void __CreatePartWrappers()
        {
            medegaGuardRequest = new __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardRequest__(this, "medegaGuardRequest", 0);
            this.AddPart("medegaGuardRequest", 0, medegaGuardRequest);
        }

        public ImportMedegaGuard_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.GuardsImportService.Reference.ImportMedegaGuardResult _schema = new MedegaImport.GuardsImportService.Reference.ImportMedegaGuardResult();

        public __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "MedegaImport.GuardsImportService.GuardsImportService.ImportMedegaGuard",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.Reference.ImportMedegaGuardResult)
        },
        new string[]{
            "ImportMedegaGuardResult"
        },
        new System.Type[]{
            typeof(__MedegaImport_GuardsImportService_Reference_ImportMedegaGuardResult__)
        },
        0,
        @"http://riziv.fgov.be/GuardsImportService#ImportMedegaGuardResult"
    )]
    [System.SerializableAttribute]
    sealed public class ImportMedegaGuard_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardResult__ ImportMedegaGuardResult;

        private void __CreatePartWrappers()
        {
            ImportMedegaGuardResult = new __MedegaImport_GuardsImportService_Reference_ImportMedegaGuardResult__(this, "ImportMedegaGuardResult", 0);
            this.AddPart("ImportMedegaGuardResult", 0, ImportMedegaGuardResult);
        }

        public ImportMedegaGuard_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "MedegaImport.GuardsImportService.GuardsImportService.test",
        new System.Type[]{
        },
        new string[]{
        },
        new System.Type[]{
        },
        -1,
        ""
    )]
    [System.SerializableAttribute]
    sealed public class test_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {

        private void __CreatePartWrappers()
        {
        }

        public test_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_2.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.Boolean' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='boolean' type='xs:boolean' />
</xs:schema>",
        @"boolean",
        null,
        typeof(System.Boolean),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_Boolean__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_Boolean__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.Boolean); } }
        public System.Boolean TypedValue { get { return (System.Boolean) this.RetrieveAs(typeof(System.Boolean)); } set { this.LoadFrom(value); } }
        public System.Boolean WriteableTypedValue { get { return (System.Boolean) this.RetrieveForWriteAs(typeof(System.Boolean)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.Boolean); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "MedegaImport.GuardsImportService.GuardsImportService.test",
        new System.Type[]{
            typeof(System.Boolean)
        },
        new string[]{
            "testResult"
        },
        new System.Type[]{
            typeof(__System_Boolean__)
        },
        0,
        @"boolean"
    )]
    [System.SerializableAttribute]
    sealed public class test_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_Boolean__ testResult;

        private void __CreatePartWrappers()
        {
            testResult = new __System_Boolean__(this, "testResult", 0);
            this.AddPart("testResult", 0, testResult);
        }

        public test_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ImportMedegaGuard",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_request), 
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ImportMedegaXml",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaXml_request), 
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaXml_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "GetImportMedegaXmlResults",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.GetImportMedegaXmlResults_request), 
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.GetImportMedegaXmlResults_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "test",
        new System.Type[]{
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.test_request), 
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.test_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(MedegaImport.GuardsImportService.GuardsImportService))]
    [System.SerializableAttribute]
    sealed public class GuardsImportService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public GuardsImportService(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public GuardsImportService(GuardsImportService p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            GuardsImportService p = new GuardsImportService(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ImportMedegaGuard = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ImportMedegaGuard",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(GuardsImportService),
            typeof(ImportMedegaGuard_request),
            typeof(ImportMedegaGuard_response),
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo ImportMedegaXml = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ImportMedegaXml",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(GuardsImportService),
            typeof(ImportMedegaXml_request),
            typeof(ImportMedegaXml_response),
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo GetImportMedegaXmlResults = new Microsoft.XLANGs.Core.OperationInfo
        (
            "GetImportMedegaXmlResults",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(GuardsImportService),
            typeof(GetImportMedegaXmlResults_request),
            typeof(GetImportMedegaXmlResults_response),
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo test = new Microsoft.XLANGs.Core.OperationInfo
        (
            "test",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(GuardsImportService),
            typeof(test_request),
            typeof(test_response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ImportMedegaGuard" ] = ImportMedegaGuard;
                h[ "ImportMedegaXml" ] = ImportMedegaXml;
                h[ "GetImportMedegaXmlResults" ] = GetImportMedegaXmlResults;
                h[ "test" ] = test;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(true)]
    [Microsoft.XLANGs.BaseTypes.TargetXmlNamespaceAttribute("http://riziv.fgov.be/GuardsImportService")]
    sealed public class _MODULE_PROXY_ { }
}
