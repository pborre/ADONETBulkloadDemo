
#pragma warning disable 162

namespace MedegaImport
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

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any),
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "Context",
            "ErrMsg"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__),
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed internal class ExceptionType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ Context;
        public __Microsoft_XLANGs_BaseTypes_Any__ ErrMsg;

        private void __CreatePartWrappers()
        {
            Context = new __Microsoft_XLANGs_BaseTypes_Any__(this, "Context", 0);
            this.AddPart("Context", 0, Context);
            ErrMsg = new __Microsoft_XLANGs_BaseTypes_Any__(this, "ErrMsg", 1);
            this.AddPart("ErrMsg", 1, ErrMsg);
        }

        public ExceptionType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Send",
        new System.Type[]{
            typeof(MedegaImport.ExceptionType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ErrContextType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ErrContextType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ErrContextType(ErrContextType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ErrContextType p = new ErrContextType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Send = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Send",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ErrContextType),
            typeof(ExceptionType),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Send" ] = Send;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImportSchema_Schemas_Medega_Guard__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImportSchema.Schemas.Medega_Guard _schema = new MedegaImportSchema.Schemas.Medega_Guard();

        public __MedegaImportSchema_Schemas_Medega_Guard__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImportSchema.Schemas.Medega_Guard",
        new System.Type[]{
            typeof(MedegaImportSchema.Schemas.Medega_Guard)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImportSchema_Schemas_Medega_Guard__)
        },
        0,
        @"http://www.riziv.fgov.be/medega/v1.0#ROWSET"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImportSchema_Schemas_Medega_Guard : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImportSchema_Schemas_Medega_Guard__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImportSchema_Schemas_Medega_Guard__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImportSchema_Schemas_Medega_Guard(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest _schema = new MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest();

        public __MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#ImportFileRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse _schema = new MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse();

        public __MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#ImportFileResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Send",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ErrMsgType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ErrMsgType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ErrMsgType(ErrMsgType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ErrMsgType p = new ErrMsgType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Send = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Send",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ErrMsgType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Send" ] = Send;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest _schema = new MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest();

        public __MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#ImportXmlRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse _schema = new MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse();

        public __MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#ImportXmlResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Import",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImportSchema_Schemas_Medega_Guard)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveGuardsType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveGuardsType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveGuardsType(ReceiveGuardsType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveGuardsType p = new ReceiveGuardsType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Import = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Import",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveGuardsType),
            typeof(__messagetype_MedegaImportSchema_Schemas_Medega_Guard),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Import" ] = Import;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ImportFile",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest), 
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DB2ImportFileType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DB2ImportFileType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DB2ImportFileType(DB2ImportFileType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DB2ImportFileType p = new DB2ImportFileType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ImportFile = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ImportFile",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(DB2ImportFileType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ImportFile" ] = ImportFile;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ImportGuardLogType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ImportGuardLogType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ImportGuardLogType(ImportGuardLogType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ImportGuardLogType p = new ImportGuardLogType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ImportGuardLogType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest _schema = new MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest();

        public __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#UpdateFileStatusRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse _schema = new MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse();

        public __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse",
        new System.Type[]{
            typeof(MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#UpdateFileStatusResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ImportXml",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest), 
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DB2ImportXmlType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DB2ImportXmlType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DB2ImportXmlType(DB2ImportXmlType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DB2ImportXmlType p = new DB2ImportXmlType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ImportXml = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ImportXml",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(DB2ImportXmlType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ImportXml" ] = ImportXml;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DB2ImportXmlLogType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DB2ImportXmlLogType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DB2ImportXmlLogType(DB2ImportXmlLogType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DB2ImportXmlLogType p = new DB2ImportXmlLogType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DB2ImportXmlLogType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Mail",
        new System.Type[]{
            typeof(MedegaImport.ExceptionType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MailBusinessExceptionType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MailBusinessExceptionType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MailBusinessExceptionType(MailBusinessExceptionType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MailBusinessExceptionType p = new MailBusinessExceptionType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Mail = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Mail",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(MailBusinessExceptionType),
            typeof(ExceptionType),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Mail" ] = Mail;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "MailDoneWithExceptions",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MailOkPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MailOkPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MailOkPortType(MailOkPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MailOkPortType p = new MailOkPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo MailDoneWithExceptions = new Microsoft.XLANGs.Core.OperationInfo
        (
            "MailDoneWithExceptions",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(MailOkPortType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "MailDoneWithExceptions" ] = MailDoneWithExceptions;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "UpdateFileStatus",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest), 
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DB2UpdateFileStatusType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DB2UpdateFileStatusType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DB2UpdateFileStatusType(DB2UpdateFileStatusType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DB2UpdateFileStatusType p = new DB2UpdateFileStatusType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo UpdateFileStatus = new Microsoft.XLANGs.Core.OperationInfo
        (
            "UpdateFileStatus",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(DB2UpdateFileStatusType),
            typeof(__messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest),
            typeof(__messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "UpdateFileStatus" ] = UpdateFileStatus;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 221 "D:\Data\Visual Studio 2005\Projects\MedegaImport\MedegaSSOTest\MedegaImport\Orchestrations\HandleException.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.ErrContextType),
            typeof(MedegaImport.ErrMsgType)
        },
        new System.String[] {
            "SendErrContext",
            "SendErrMsg"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class HandleException : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] ref System.Int32 errorCode,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.Xml.XmlDocument Context,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.Xml.XmlDocument ErrMsg,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String ExceptionDescription,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String InnerExceptionDescription)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(HandleException));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static HandleException()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __HandleException_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public HandleException(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "HandleException", tracker)
        {
            ConstructorHelper();
        }

        public HandleException(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "HandleException")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>41e9d1bf-b0b5-4dc3-b278-5fed999673f7</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>1d34d6a9-4e62-4300-96ab-2cd725044d8b</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>errorCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>8b9e317d-8f2e-4044-9caa-b21e8cd8027a</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>82dc527c-c001-4767-a397-c47ebda69dfa</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>b7ee5052-a137-4d2f-a005-2955f69bb3e4</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>1d34d833-dc03-4b86-92cb-a180eea13cdf</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>72a4140b-919a-4105-a6b9-145bb198ac83</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>5500dde3-20d4-43f3-bb45-a965a593a7d1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Assign Mail message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>da3f2308-d68f-402e-9fd2-1655c572fc52</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a9e0f9da-7909-4012-a4ec-d240bbfa20af</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign Mail message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>75f3e358-6b7a-4321-9ebe-7ae237c7bfc5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>06a1de23-c34a-43ec-bbb3-0f5e3f62882c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'HandleException'</ActionName><IsAtomic>0</IsAtomic><Line>221</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>231</Line><Position>51</Position><ShapeID>'72a4140b-919a-4105-a6b9-145bb198ac83'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>233</Line><Position>13</Position><ShapeID>'5500dde3-20d4-43f3-bb45-a965a593a7d1'</ShapeID>
<Messages>
	<MsgInfo><name>MailError</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailError</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>240</Line><Position>13</Position><ShapeID>'75f3e358-6b7a-4321-9ebe-7ae237c7bfc5'</ShapeID>
<Messages>
	<MsgInfo><name>MailError</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailError</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>242</Line><Position>13</Position><ShapeID>'06a1de23-c34a-43ec-bbb3-0f5e3f62882c'</ShapeID>
<Messages>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='404be20e-9c29-477b-9ba6-3ea7761c0b81' LowerBound='1.1' HigherBound='49.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='cd3f17ca-29f8-4921-9fe0-361bb659d05c' ParentLink='Module_PortType' LowerBound='9.1' HigherBound='16.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrContextType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5d66122d-1ee9-4081-a72b-c1680b89f5f6' ParentLink='PortType_OperationDeclaration' LowerBound='11.1' HigherBound='15.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='765d8d78-922b-4f94-a5d5-4c34e6f56883' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='13.13' HigherBound='13.26'>
                    <om:Property Name='Ref' Value='MedegaImport.ExceptionType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='b1f59e34-3574-4e44-b533-187577c7c52e' ParentLink='Module_PortType' LowerBound='16.1' HigherBound='23.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrMsgType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='578ab68b-7274-42ca-8ee5-7bca42879a70' ParentLink='PortType_OperationDeclaration' LowerBound='18.1' HigherBound='22.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='c7d0cfc8-b0dd-4581-bd02-54d542f16682' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='20.13' HigherBound='20.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1eacb16b-62f9-495d-a40d-8db9afc54f87' ParentLink='Module_ServiceDeclaration' LowerBound='23.1' HigherBound='48.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='HandleException' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='48316d0e-55dd-41e4-bc37-829c64b5e51e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='Type' Value='MedegaImport.ExceptionType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailError' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='41e9d1bf-b0b5-4dc3-b278-5fed999673f7' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='1d34d6a9-4e62-4300-96ab-2cd725044d8b' ParentLink='ServiceBody_Declaration' LowerBound='31.15' HigherBound='31.41'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Ref' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='errorCode' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='8b9e317d-8f2e-4044-9caa-b21e8cd8027a' ParentLink='ServiceBody_Declaration' LowerBound='31.43' HigherBound='31.81'>
                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Context' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='82dc527c-c001-4767-a397-c47ebda69dfa' ParentLink='ServiceBody_Declaration' LowerBound='31.83' HigherBound='31.120'>
                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ErrMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='b7ee5052-a137-4d2f-a005-2955f69bb3e4' ParentLink='ServiceBody_Declaration' LowerBound='31.122' HigherBound='31.156'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ExceptionDescription' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='1d34d833-dc03-4b86-92cb-a180eea13cdf' ParentLink='ServiceBody_Declaration' LowerBound='31.158' HigherBound='31.197'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='False' />
                    <om:Property Name='Name' Value='InnerExceptionDescription' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='72a4140b-919a-4105-a6b9-145bb198ac83' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;RIZIV-INAMI.MedegaImport&quot;, System.String.Format(&quot;An error occured! Error code returned : {0}\r\nDescription: {1}\r\nInnerException: {2}&quot; ,errorCode, ExceptionDescription, InnerExceptionDescription));&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='5500dde3-20d4-43f3-bb45-a965a593a7d1' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Assign Mail message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='da3f2308-d68f-402e-9fd2-1655c572fc52' ParentLink='Construct_MessageRef' LowerBound='36.23' HigherBound='36.32'>
                        <om:Property Name='Ref' Value='MailError' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='a9e0f9da-7909-4012-a4ec-d240bbfa20af' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='MailError.Context = Context;&#xD;&#xA;MailError.ErrMsg = ErrMsg;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Assign Mail message' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='75f3e358-6b7a-4321-9ebe-7ae237c7bfc5' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='PortName' Value='SendErrContext' />
                    <om:Property Name='MessageName' Value='MailError' />
                    <om:Property Name='OperationName' Value='Send' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Context' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='06a1de23-c34a-43ec-bbb3-0f5e3f62882c' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='46.1'>
                    <om:Property Name='PortName' Value='SendErrMsg' />
                    <om:Property Name='MessageName' Value='ErrMsg' />
                    <om:Property Name='OperationName' Value='Send' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Exception' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c55ed462-66b4-46ee-a975-52f7cbc7664a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='26.1' HigherBound='28.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.ErrMsgType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendErrMsg' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7e74c7a8-2b2d-4a1f-9096-79f83794c76b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='26.1' HigherBound='27.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0ee18aeb-622d-496c-a22d-72b9bd5369a1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='9' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.ErrContextType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendErrContext' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='47e466ad-0fe5-4d20-b7a5-f430bc25365f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='fe2063b2-a3a2-4b3f-b668-1c3283513615' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='9.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ExceptionType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='4895bd87-cfb6-47d1-b38d-4ba46080849f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='System.Xml.XmlDocument' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='PartDeclaration' OID='8dd531b8-4c27-4d8c-9cc1-6ab87d3e380a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='7.1' HigherBound='8.1'>
                <om:Property Name='ClassName' Value='System.Xml.XmlDocument' />
                <om:Property Name='IsBodyPart' Value='False' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __HandleException_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __HandleException_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "HandleException")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                HandleException __svc__ = (HandleException)_service;
                __HandleException_root_0 __ctx0__ = (__HandleException_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendErrMsg != null)
                {
                    __svc__.SendErrMsg.Close(this, null);
                    __svc__.SendErrMsg = null;
                }
                if (__svc__.SendErrContext != null)
                {
                    __svc__.SendErrContext.Close(this, null);
                    __svc__.SendErrContext = null;
                }
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __HandleException_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __HandleException_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "HandleException")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                HandleException __svc__ = (HandleException)_service;
                __HandleException_1 __ctx1__ = (__HandleException_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__MailError != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MailError);
                    __ctx1__.__MailError = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MailError")]
            internal ExceptionType __MailError;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrMsg")]
            public __messagetype_System_Xml_XmlDocument __ErrMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("errorCode")]
            internal System.Int32 __errorCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendErrContext")]
        internal ErrContextType SendErrContext;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendErrMsg")]
        internal ErrMsgType SendErrMsg;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ErrContextType.Send},
                                               typeof(HandleException).GetField("SendErrContext", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(HandleException), "SendErrContext"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ErrMsgType.Send},
                                               typeof(HandleException).GetField("SendErrMsg", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(HandleException), "SendErrMsg"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "72a4140b-919a-4105-a6b9-145bb198ac83", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "72a4140b-919a-4105-a6b9-145bb198ac83", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "5500dde3-20d4-43f3-bb45-a965a593a7d1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "5500dde3-20d4-43f3-bb45-a965a593a7d1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "75f3e358-6b7a-4321-9ebe-7ae237c7bfc5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "75f3e358-6b7a-4321-9ebe-7ae237c7bfc5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "06a1de23-c34a-43ec-bbb3-0f5e3f62882c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "06a1de23-c34a-43ec-bbb3-0f5e3f62882c", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,2,2,3,4,4,5,6,6,6,7,8,8,8,9,1,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __HandleException_root_0 __ctx0__ = (__HandleException_root_0)_stateMgrs[0];
            __HandleException_1 __ctx1__ = (__HandleException_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                SendErrMsg = new ErrMsgType(1, this);
                SendErrContext = new ErrContextType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __HandleException_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __HandleException_root_0 __ctx0__ = (__HandleException_root_0)_stateMgrs[0];
            __HandleException_1 __ctx1__ = (__HandleException_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__errorCode = (System.Int32)Args[0];
                __ctx1__.__ExceptionDescription = (System.String)Args[3];
                __ctx1__.__InnerExceptionDescription = (System.String)Args[4];
                __ctx1__.__Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                __ctx1__.__Context.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[1]);
                __ctx1__.RefMessage(__ctx1__.__Context);
                __ctx1__.__Context.ConstructionCompleteEvent();
                __ctx1__.__ErrMsg = new __messagetype_System_Xml_XmlDocument("ErrMsg", __ctx1__);
                __ctx1__.__ErrMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[2]);
                __ctx1__.RefMessage(__ctx1__.__ErrMsg);
                __ctx1__.__ErrMsg.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                System.Diagnostics.EventLog.WriteEntry("RIZIV-INAMI.MedegaImport", System.String.Format("An error occured! Error code returned : {0}\r\nDescription: {1}\r\nInnerException: {2}", __ctx1__.__errorCode, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription));
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    ExceptionType __MailError = new ExceptionType("MailError", __ctx1__);

                    __MailError.Context.CopyFrom(__ctx1__.__Context.part);
                    __MailError.ErrMsg.CopyFrom(__ctx1__.__ErrMsg.part);

                    if (__ctx1__.__MailError != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MailError);
                    __ctx1__.__MailError = __MailError;
                    __ctx1__.RefMessage(__ctx1__.__MailError);
                }
                __ctx1__.__MailError.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MailError);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendErrContext.SendMessage(0, __ctx1__.__MailError, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (SendErrContext != null)
                {
                    SendErrContext.Close(__ctx1__, __seg__);
                    SendErrContext = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MailError);
                    __edata.PortName = @"SendErrContext";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MailError != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MailError);
                    __ctx1__.__MailError = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendErrMsg.SendMessage(0, __ctx1__.__ErrMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendErrMsg != null)
                {
                    SendErrMsg.Close(__ctx1__, __seg__);
                    SendErrMsg = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    __edata.PortName = @"SendErrMsg";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 20;
            case 20:
                Args[0] = __ctx1__.__errorCode;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 238 "D:\Data\Visual Studio 2005\Projects\MedegaImport\MedegaSSOTest\MedegaImport\Orchestrations\ImportGuards.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveGuards", "Import", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(MedegaImport.ReceiveGuardsType)
        },
        new System.String[] {
            "ReceiveGuards"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(MedegaImport.subImportFile),
            typeof(MedegaImport.subUpdateFileStatus),
            typeof(MedegaImport.subImportGuardRecord)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ImportGuards : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
                "MedegaImport.subImportFile",
                "MedegaImport.subUpdateFileStatus",
                "MedegaImport.subImportGuardRecord"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ImportGuards));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ImportGuards()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __ImportGuards_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[5];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ImportGuards(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ImportGuards", tracker)
        {
            ConstructorHelper();
        }

        public ImportGuards(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ImportGuards")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>fdae6ed7-b4c2-429b-9844-6ff895ed1a85</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b1eba16b-ce54-465d-89ea-0bdcccbbf213</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Guards</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>93d77076-9f32-4db9-9a81-1271a4f685f5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ImportFile</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>43a93c6e-1309-4581-a1dd-ce1dee853931</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>bf8c29fc-aea9-4635-8574-4bc9200624f0</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>17119f27-218e-428c-8970-d03ae2929565</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>GuardsFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d4c3757a-5c3e-431d-86ec-19aa7ff8aeb7</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DB2ImportFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Verify Status</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>fa041359-cc74-4aa4-988b-81e93d753551</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>New</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5769510a-a0c1-452d-8383-f5ac62e167a0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>eaddda75-a016-4afc-ab05-c3280ff558e7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallUpdateStatusId</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c32c2a06-0cc8-4765-a9e4-a419135650e8</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b426c6b1-2c34-44bc-9fe9-60f5434eb614</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>NewFileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>7fcfe072-fbbb-4b34-a738-6f41fa0d2057</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ImportRecords</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>acf8561a-67df-4d3e-b977-89369cc06925</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>GuardsFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>2713946b-2377-4de9-837c-13f481900d2f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>DB2ImportFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d04d6762-7f56-4c62-b1db-8c1f42f0fafa</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>f41c35f1-1f66-4dce-afca-7092097af540</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>296dd146-6079-4b1f-84d6-b2fdfe61ffab</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'ImportGuards'</ActionName><IsAtomic>0</IsAtomic><Line>238</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>252</Line><Position>22</Position><ShapeID>'b1eba16b-ce54-465d-89ea-0bdcccbbf213'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>256</Line><Position>45</Position><ShapeID>'93d77076-9f32-4db9-9a81-1271a4f685f5'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DB2ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>258</Line><Position>13</Position><ShapeID>'de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>261</Line><Position>33</Position><ShapeID>'5769510a-a0c1-452d-8383-f5ac62e167a0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>263</Line><Position>55</Position><ShapeID>'eaddda75-a016-4afc-ab05-c3280ff558e7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>56</Position><ShapeID>'7fcfe072-fbbb-4b34-a738-6f41fa0d2057'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DB2ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>17</Position><ShapeID>'296dd146-6079-4b1f-84d6-b2fdfe61ffab'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='8960eb66-2104-4284-aba7-f9e9c44dafae' LowerBound='1.1' HigherBound='49.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8c944f78-7ce4-4aed-9df7-a941d5e62ee7' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveGuardsType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dd41b2df-5793-41f4-b8cd-f8531cbf2844' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Import' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ab6f55db-b05f-4db3-bd94-7957c9278912' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.52'>
                    <om:Property Name='Ref' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='bc8c92f4-7a54-413c-a3e5-d80cfa9508b6' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='48.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ImportGuards' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='4549667d-1542-4f73-bc9b-62d2da59c0fb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileStatusID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8f267d80-fa5e-4308-868b-469897bdfee1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xpathString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fbcaebb1-73cb-49f6-ba8c-5912d9bc34c6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xpathResult' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='df921866-f2da-4d3e-adee-6d3f905a36f9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='81bd8524-e237-46c7-a2d7-b374fb1a4225' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewFileStatusID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='285fc959-77d2-4b5a-abe9-f52e2f4dc6e1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GuardsFile' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6121a6fd-8e2f-4443-ad7f-26945ec5c873' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2ImportFileResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='fdae6ed7-b4c2-429b-9844-6ff895ed1a85' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b1eba16b-ce54-465d-89ea-0bdcccbbf213' ParentLink='ServiceBody_Statement' LowerBound='25.1' HigherBound='29.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveGuards' />
                    <om:Property Name='MessageName' Value='GuardsFile' />
                    <om:Property Name='OperationName' Value='Import' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Guards' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Call' OID='93d77076-9f32-4db9-9a81-1271a4f685f5' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Identifier' Value='ImportFile' />
                    <om:Property Name='Invokee' Value='MedegaImport.subImportFile' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportFile' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Parameter' OID='43a93c6e-1309-4581-a1dd-ce1dee853931' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='FileID' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='bf8c29fc-aea9-4635-8574-4bc9200624f0' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='FileStatusID' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='17119f27-218e-428c-8970-d03ae2929565' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='GuardsFile' />
                        <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='d4c3757a-5c3e-431d-86ec-19aa7ff8aeb7' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='DB2ImportFileResponse' />
                        <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='46.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Verify Status' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='fa041359-cc74-4aa4-988b-81e93d753551' ParentLink='ReallyComplexStatement_Branch' LowerBound='32.13' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='FileStatusID != System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending)' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='New' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='5769510a-a0c1-452d-8383-f5ac62e167a0' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                            <om:Property Name='Expression' Value='NewFileStatusID = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending );&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set status' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Call' OID='eaddda75-a016-4afc-ab05-c3280ff558e7' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='38.1'>
                            <om:Property Name='Identifier' Value='CallUpdateStatusId' />
                            <om:Property Name='Invokee' Value='MedegaImport.subUpdateFileStatus' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CallUpdateStatusId' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='c32c2a06-0cc8-4765-a9e4-a419135650e8' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='FileStatusID' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b426c6b1-2c34-44bc-9fe9-60f5434eb614' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='NewFileStatusID' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Call' OID='7fcfe072-fbbb-4b34-a738-6f41fa0d2057' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='40.1'>
                            <om:Property Name='Identifier' Value='ImportRecords' />
                            <om:Property Name='Invokee' Value='MedegaImport.subImportGuardRecord' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ImportRecords' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='acf8561a-67df-4d3e-b977-89369cc06925' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='GuardsFile' />
                                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='2713946b-2377-4de9-837c-13f481900d2f' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='DB2ImportFileResponse' />
                                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='d04d6762-7f56-4c62-b1db-8c1f42f0fafa' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='FileID' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='f41c35f1-1f66-4dce-afca-7092097af540' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Terminate' OID='296dd146-6079-4b1f-84d6-b2fdfe61ffab' ParentLink='ComplexStatement_Statement' LowerBound='43.1' HigherBound='45.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;The file status after ImportFile is not correct to continue&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8aca5fc8-dabf-4acf-b143-aca6efa34ddc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.ReceiveGuardsType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveGuards' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d8090902-4f8e-464a-ac5b-de6d5f0d3fe6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ImportGuards_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ImportGuards_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ImportGuards")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ImportGuards __svc__ = (ImportGuards)_service;
                __ImportGuards_root_0 __ctx0__ = (__ImportGuards_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveGuards != null)
                {
                    __svc__.ReceiveGuards.Close(this, null);
                    __svc__.ReceiveGuards = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ImportGuards_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ImportGuards_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ImportGuards")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ImportGuards __svc__ = (ImportGuards)_service;
                __ImportGuards_1 __ctx1__ = (__ImportGuards_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xpathResult = null;
                if (__ctx1__ != null)
                    __ctx1__.__xpathString = null;
                if (__ctx1__ != null && __ctx1__.__DB2ImportFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileResponse);
                    __ctx1__.__DB2ImportFileResponse = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("GuardsFile")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __GuardsFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2ImportFileResponse")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse __DB2ImportFileResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileStatusID")]
            internal System.Int32 __FileStatusID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xpathString")]
            internal System.String __xpathString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xpathResult")]
            internal System.String __xpathResult;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileID")]
            internal System.Int32 __FileID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NewFileStatusID")]
            internal System.Int32 __NewFileStatusID;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveGuards")]
        internal ReceiveGuardsType ReceiveGuards;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveGuardsType.Import},
                                               typeof(ImportGuards).GetField("ReceiveGuards", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ImportGuards), "ReceiveGuards"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(MedegaImport.subImportFile),
                    typeof(MedegaImport.subImportGuardRecord),
                    typeof(MedegaImport.subUpdateFileStatus)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b1eba16b-ce54-465d-89ea-0bdcccbbf213", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b1eba16b-ce54-465d-89ea-0bdcccbbf213", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "93d77076-9f32-4db9-9a81-1271a4f685f5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "93d77076-9f32-4db9-9a81-1271a4f685f5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "5769510a-a0c1-452d-8383-f5ac62e167a0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "5769510a-a0c1-452d-8383-f5ac62e167a0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "eaddda75-a016-4afc-ab05-c3280ff558e7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "eaddda75-a016-4afc-ab05-c3280ff558e7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "7fcfe072-fbbb-4b34-a738-6f41fa0d2057", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "7fcfe072-fbbb-4b34-a738-6f41fa0d2057", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "296dd146-6079-4b1f-84d6-b2fdfe61ffab", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,6,6,7,7,8,9,9,10,11,11,12,6,13,13,14,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ImportGuards_1 __ctx1__ = (__ImportGuards_1)_stateMgrs[1];
            __ImportGuards_root_0 __ctx0__ = (__ImportGuards_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveGuards = new ReceiveGuardsType(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveGuards, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ImportGuards_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ImportGuards_1 __ctx1__ = (__ImportGuards_1)_stateMgrs[1];
            __ImportGuards_root_0 __ctx0__ = (__ImportGuards_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileStatusID = default(System.Int32);
                __ctx1__.__xpathString = default(System.String);
                __ctx1__.__xpathResult = default(System.String);
                __ctx1__.__FileID = default(System.Int32);
                __ctx1__.__NewFileStatusID = default(System.Int32);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveGuards.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__GuardsFile != null)
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                __ctx1__.__GuardsFile = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard("GuardsFile", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__GuardsFile);
                ReceiveGuards.ReceiveMessage(0, __msgEnv__, __ctx1__.__GuardsFile, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveGuards != null)
                {
                    ReceiveGuards.Close(__ctx1__, __seg__);
                    ReceiveGuards = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.PortName = @"ReceiveGuards";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__xpathString = "";
                if (__ctx1__ != null)
                    __ctx1__.__xpathString = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__xpathResult = "";
                if (__ctx1__ != null)
                    __ctx1__.__xpathResult = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subImportFile(2, InstanceId, this);
                    _stateMgrs[2] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[4],new object[] {null, null, __ctx1__.__GuardsFile, new Microsoft.XLANGs.Core.MessageTuple((Microsoft.XLANGs.Core.Context)_stateMgrs[1], null)});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[2]).Args;
                    __ctx1__.__FileID = (System.Int32)args[0];
                    __ctx1__.__FileStatusID = (System.Int32)args[1];
                    __ctx1__.__DB2ImportFileResponse = (__messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse)((Microsoft.XLANGs.Core.MessageTuple)(args[3])).message;
                    __ctx1__.__DB2ImportFileResponse.MessageName = "DB2ImportFileResponse";
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __condition__ = __ctx1__.__FileStatusID != System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 22;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__NewFileStatusID = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subUpdateFileStatus(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[9],new object[] {__ctx1__.__FileStatusID, __ctx1__.__NewFileStatusID});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                }
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subImportGuardRecord(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[11],new object[] {__ctx1__.__GuardsFile, __ctx1__.__DB2ImportFileResponse, __ctx1__.__FileID});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                RequestTerminate(__ctx1__,"The file status after ImportFile is not correct to continue");
                __seg__.SegmentDone();
                break;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__DB2ImportFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileResponse);
                    __ctx1__.__DB2ImportFileResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 28;
            case 28:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 468 "D:\Data\Visual Studio 2005\Projects\MedegaImport\MedegaSSOTest\MedegaImport\Orchestrations\subImportFile.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.DB2ImportFileType)
        },
        new System.String[] {
            "DB2_ImportFile"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(MedegaImport.HandleException)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class subImportFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "MedegaImport.HandleException"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] out System.Int32 FileID,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] out System.Int32 FileStatusID,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] MedegaImportSchema.Schemas.Medega_Guard GuardsFile,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] out MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse DB2ImportFileResponse)
        {
            FileID = default(System.Int32);
            FileStatusID = default(System.Int32);
            DB2ImportFileResponse = default(MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(subImportFile));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static subImportFile()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 3, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __subImportFile_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[5];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public subImportFile(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "subImportFile", tracker)
        {
            ConstructorHelper();
        }

        public subImportFile(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "subImportFile")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e4824caf-d6f5-4aa4-9de8-52ee0c079fb6</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>98226dca-319a-4163-a226-8fd3679b1da0</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>3b03b120-2390-43b6-b4b9-a1c01ec2f745</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>FileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>8ab48bb4-b73a-4659-a727-da3b19711dd1</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>GuardsFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>71905094-9123-4c8f-a9c7-020b73bd54a1</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>DB2ImportFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>53e7f6e2-c5d1-4696-89e3-119e2e28d223</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1abf846a-a48e-4308-a515-5f13e8005f28</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e77cc2c4-4728-4120-8a1d-496746033bfa</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b40d4d2f-5a95-45a5-824f-8d3767af3ab1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>71b548d6-b77b-4fd6-8a8d-3430e07fc959</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0653e2f2-df5d-4298-8480-722b7f32c7a6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>a4b0227b-7516-432b-a3c8-c63cb123a2fe</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>20530756-8b0f-4640-ba42-d2dec9fbba08</ShapeID>      <ParentLink>Scope_VariableDeclaration</ParentLink>                <shapeText>xpathString</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5e695e8c-5e2d-4f29-8763-5e4a8200d56e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get Filename</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>cd368a80-c25a-49c6-aba4-e107d82c06c2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructFileInfo</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e4d5090a-7a5f-4309-95bc-33363ab02154</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>690299cc-2b83-4770-bb1e-bdd05d9dc3b5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>246572e6-6bbf-4603-8a4a-b018cf86bd9e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4ff0c0fb-f96d-41d3-8ec4-5caa870237c0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>b7557708-b486-4b17-b9f4-6b764755badd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Import FileRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>053fcab6-56d4-4360-8c8d-64585c526c9f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1f63a2ad-5bdf-47e8-a68b-94b2bec266c4</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>cd666881-215a-406b-a8a0-08c7d3951323</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7734464f-462e-4eb8-bf5b-558000752492</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send ImportFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b4a94870-d466-454d-abd6-2c38d63d4509</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive DB2 Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>cf213b83-cf5c-4018-929b-35177a02dc19</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7b5bb6f9-4ed3-4753-8d09-8b96052c949a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d78c787d-76b8-4598-9f15-7e8cfab99534</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>56792c53-3155-4f54-b974-4392b5cadb98</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c6b8fda0-17ea-4f71-8911-9650121a5744</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set err msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>0e12c1a0-4a7a-4a90-abda-ee7805c16038</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set err msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0461dd2c-9aeb-4eb5-91e9-5170af9f6c19</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>a5252301-f00a-4355-bba9-370566c2eab7</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Throw</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>70822a75-fe3f-4390-864a-58f6273d4cdc</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5efb35b0-e793-416b-959a-99c26916c919</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set Error message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>e2059a03-6b78-4471-80ad-6888053eb662</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4ef66a10-64bf-4da7-877e-535f2fc2f752</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>aada57c0-32ab-48de-9f80-904955d97fe4</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e95bac22-338b-47a8-bb22-f2defac2f3a7</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9eeff43f-b19e-4a07-9b85-4d39539cd979</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9fdd98b6-5778-4170-98fc-20d6bd72dd2e</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'subImportFile'</ActionName><IsAtomic>0</IsAtomic><Line>468</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DB2ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>499</Line><Position>13</Position><ShapeID>'53e7f6e2-c5d1-4696-89e3-119e2e28d223'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DB2ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>510</Line><Position>20</Position><ShapeID>'0653e2f2-df5d-4298-8480-722b7f32c7a6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>514</Line><Position>13</Position><ShapeID>'a4b0227b-7516-432b-a3c8-c63cb123a2fe'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>521</Line><Position>21</Position><ShapeID>'5e695e8c-5e2d-4f29-8763-5e4a8200d56e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>537</Line><Position>21</Position><ShapeID>'cd368a80-c25a-49c6-aba4-e107d82c06c2'</ShapeID>
<Messages>
	<MsgInfo><name>FileInfo</name><part>part</part><schema>MedegaImportSchema.Schemas.GeneralFileInfo</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DB2ImportFileRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>FileInfo</name><part>part</part><schema>MedegaImportSchema.Schemas.GeneralFileInfo</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>561</Line><Position>21</Position><ShapeID>'7734464f-462e-4eb8-bf5b-558000752492'</ShapeID>
<Messages>
	<MsgInfo><name>DB2ImportFileRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>563</Line><Position>21</Position><ShapeID>'b4a94870-d466-454d-abd6-2c38d63d4509'</ShapeID>
<Messages>
	<MsgInfo><name>DB2ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope36'</ActionName><IsAtomic>0</IsAtomic><Line>565</Line><Position>21</Position><ShapeID>'cf213b83-cf5c-4018-929b-35177a02dc19'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>570</Line><Position>41</Position><ShapeID>'7b5bb6f9-4ed3-4753-8d09-8b96052c949a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>579</Line><Position>36</Position><ShapeID>'d78c787d-76b8-4598-9f15-7e8cfab99534'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>584</Line><Position>29</Position><ShapeID>'56792c53-3155-4f54-b974-4392b5cadb98'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>587</Line><Position>33</Position><ShapeID>'c6b8fda0-17ea-4f71-8911-9650121a5744'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>593</Line><Position>33</Position><ShapeID>'a5252301-f00a-4355-bba9-370566c2eab7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>601</Line><Position>21</Position><ShapeID>'70822a75-fe3f-4390-864a-58f6273d4cdc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>604</Line><Position>46</Position><ShapeID>'5efb35b0-e793-416b-959a-99c26916c919'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>607</Line><Position>59</Position><ShapeID>'e2059a03-6b78-4471-80ad-6888053eb662'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='10a5b02c-e77c-4357-8f72-edd3694334cb' LowerBound='1.1' HigherBound='165.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='c85a053a-a1bd-414a-89fb-a0804887a545' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DB2ImportFileType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='4e2a0a31-0b00-4f70-9398-f5a45f032e35' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportFile' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='1d83aa07-4986-4e3d-bc8e-fbc25f515a45' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.53'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='2010786b-280e-4c36-a7c8-986a81044362' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.55' HigherBound='8.96'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='22845039-cb60-43e3-8776-2674cd88e3e2' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ImportGuardLogType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b4bb69a1-04f8-4a58-b79a-f90e0d437403' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ba6f54d7-e32c-4451-83c0-201291831a79' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.54'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5834d121-39f4-4f6d-9d52-5cfffa8c777e' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='164.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subImportFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='723e05c9-1f0e-4948-9773-19d27f383dd4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3c7f1c00-ca9e-4ad3-9d52-4d7576a86280' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3f82ccda-79c8-44c5-b6ad-3664d276e9f7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportFileException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='17f0cbc3-8b02-46a3-9bfd-3f2fa51b4f99' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='36e9b88c-eab1-4675-aae8-ec4621709103' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='receivedFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a44c60dd-f84a-4a22-8788-3d004a45815a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmpString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3161a0b6-7eb2-4af6-a2ef-1abdd9a032bd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='GeneralBiztalkHelper.SplitString' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='splittedFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='efe8f4e1-1508-45eb-9d97-d0cebd43d579' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Variable_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1f37756a-fdc4-47a4-a22b-01af481c8ff9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PeriodID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6fbdf073-6c8e-4f6a-aa9c-7e95de76c3a1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='23fb96b8-e5ec-4597-b688-6def63b6ac21' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='CODit.BizTalkHelpers.BizTalkSSOHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SSOHelper' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='28f5fd3a-7969-44e6-aea2-c33986775425' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.GeneralFileInfo' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileInfo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b20f9e42-b76e-4f33-bfb4-3609ea0bb4f4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2ImportFileRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='29d7020a-2fb7-416a-a83b-fc03e1aea2c1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='16376ad5-2184-4d27-8525-8ba570e04c5d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e4824caf-d6f5-4aa4-9de8-52ee0c079fb6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='98226dca-319a-4163-a226-8fd3679b1da0' ParentLink='ServiceBody_Declaration' LowerBound='38.15' HigherBound='38.38'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileID' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='3b03b120-2390-43b6-b4b9-a1c01ec2f745' ParentLink='ServiceBody_Declaration' LowerBound='38.40' HigherBound='38.69'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileStatusID' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='8ab48bb4-b73a-4659-a727-da3b19711dd1' ParentLink='ServiceBody_Declaration' LowerBound='38.71' HigherBound='38.129'>
                    <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GuardsFile' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='71905094-9123-4c8f-a9c7-020b73bd54a1' ParentLink='ServiceBody_Declaration' LowerBound='38.131' HigherBound='38.206'>
                    <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DB2ImportFileResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='53e7f6e2-c5d1-4696-89e3-119e2e28d223' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='60.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='1abf846a-a48e-4308-a515-5f13e8005f28' ParentLink='Construct_MessageRef' LowerBound='50.23' HigherBound='50.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='e77cc2c4-4728-4120-8a1d-496746033bfa' ParentLink='Construct_MessageRef' LowerBound='50.32' HigherBound='50.44'>
                        <om:Property Name='Ref' Value='ExceptionMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='b40d4d2f-5a95-45a5-824f-8d3767af3ab1' ParentLink='Construct_MessageRef' LowerBound='50.46' HigherBound='50.67'>
                        <om:Property Name='Ref' Value='DB2ImportFileResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='71b548d6-b77b-4fd6-8a8d-3430e07fc959' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='59.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ExceptionMsg = tempXmlDoc;&#xD;&#xA;DB2ImportFileResponse = tempXmlDoc;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='0653e2f2-df5d-4298-8480-722b7f32c7a6' ParentLink='ServiceBody_Statement' LowerBound='60.1' HigherBound='64.1'>
                    <om:Property Name='Expression' Value='status = -99;&#xD;&#xA;FileStatusID = -1;&#xD;&#xA;FileID = 0;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Status' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='a4b0227b-7516-432b-a3c8-c63cb123a2fe' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='162.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableDeclaration' OID='20530756-8b0f-4640-ba42-d2dec9fbba08' ParentLink='Scope_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                        <om:Property Name='UseDefaultConstructor' Value='False' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='ParamDirection' Value='In' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='xpathString' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='5e695e8c-5e2d-4f29-8763-5e4a8200d56e' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='87.1'>
                        <om:Property Name='Expression' Value='if(FILE.ReceivedFileName exists GuardsFile)&#xD;&#xA;{&#xD;&#xA;    receivedFileName=GuardsFile(FILE.ReceivedFileName);&#xD;&#xA;}&#xD;&#xA;else if(FTP.ReceivedFileName exists GuardsFile)&#xD;&#xA;{&#xD;&#xA;    receivedFileName=GuardsFile(FTP.ReceivedFileName);&#xD;&#xA;}&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;    receivedFileName = &quot;&quot;;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;tmpString = receivedFileName.Substring(0,receivedFileName.LastIndexOf(&apos;.&apos;));&#xD;&#xA;splittedFileName = new GeneralBiztalkHelper.SplitString(tmpString,&apos;_&apos;);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Get Filename' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='cd368a80-c25a-49c6-aba4-e107d82c06c2' ParentLink='ComplexStatement_Statement' LowerBound='87.1' HigherBound='111.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructFileInfo' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='e4d5090a-7a5f-4309-95bc-33363ab02154' ParentLink='Construct_MessageRef' LowerBound='88.31' HigherBound='88.39'>
                            <om:Property Name='Ref' Value='FileInfo' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='690299cc-2b83-4770-bb1e-bdd05d9dc3b5' ParentLink='Construct_MessageRef' LowerBound='88.41' HigherBound='88.61'>
                            <om:Property Name='Ref' Value='DB2ImportFileRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='246572e6-6bbf-4603-8a4a-b018cf86bd9e' ParentLink='Construct_MessageRef' LowerBound='88.63' HigherBound='88.70'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='4ff0c0fb-f96d-41d3-8ec4-5caa870237c0' ParentLink='ComplexStatement_Statement' LowerBound='90.1' HigherBound='105.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;ns0:FileInfo xmlns:ns0=&apos;http://www.riziv.fgov.be/medega/v1.0&apos;&gt;&lt;PeriodFromDay&gt;&lt;/PeriodFromDay&gt;&lt;PeriodFromMonth&gt;&lt;/PeriodFromMonth&gt;&lt;PeriodFromYear&gt;&lt;/PeriodFromYear&gt;&lt;PeriodToDay&gt;&lt;/PeriodToDay&gt;&lt;PeriodToMonth&gt;&lt;/PeriodToMonth&gt;&lt;PeriodToYear&gt;&lt;/PeriodToYear&gt;&lt;FileName&gt;&lt;/FileName&gt;&lt;/ns0:FileInfo&gt;&quot;);&#xD;&#xA;&#xD;&#xA;FileInfo = tempXmlDoc;&#xD;&#xA;&#xD;&#xA;FileInfo.PeriodFromDay = splittedFileName.Elements[2];&#xD;&#xA;FileInfo.PeriodFromMonth = splittedFileName.Elements[3];&#xD;&#xA;FileInfo.PeriodFromYear = splittedFileName.Elements[4];&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;FileInfo.PeriodToDay = splittedFileName.Elements[5];&#xD;&#xA;FileInfo.PeriodToMonth = splittedFileName.Elements[6];&#xD;&#xA;FileInfo.PeriodToYear = splittedFileName.Elements[7];&#xD;&#xA;FileInfo.FileName = receivedFileName;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='b7557708-b486-4b17-b9f4-6b764755badd' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='107.1'>
                            <om:Property Name='ClassName' Value='MedegaImport.Mappings.CreateDB2ImportFileRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Create Import FileRequest' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='053fcab6-56d4-4360-8c8d-64585c526c9f' ParentLink='Transform_InputMessagePartRef' LowerBound='106.110' HigherBound='106.118'>
                                <om:Property Name='MessageRef' Value='FileInfo' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='1f63a2ad-5bdf-47e8-a68b-94b2bec266c4' ParentLink='Transform_OutputMessagePartRef' LowerBound='106.36' HigherBound='106.56'>
                                <om:Property Name='MessageRef' Value='DB2ImportFileRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='cd666881-215a-406b-a8a0-08c7d3951323' ParentLink='ComplexStatement_Statement' LowerBound='107.1' HigherBound='110.1'>
                            <om:Property Name='Expression' Value='Context = DB2ImportFileRequest;&#xD;&#xA;//DB2ImportFileRequest(BTS.SSOTicket) = SSOHelper.IssueSelfTicket();' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='Set Context' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='7734464f-462e-4eb8-bf5b-558000752492' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='113.1'>
                        <om:Property Name='PortName' Value='DB2_ImportFile' />
                        <om:Property Name='MessageName' Value='DB2ImportFileRequest' />
                        <om:Property Name='OperationName' Value='ImportFile' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send ImportFile' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='b4a94870-d466-454d-abd6-2c38d63d4509' ParentLink='ComplexStatement_Statement' LowerBound='113.1' HigherBound='115.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='DB2_ImportFile' />
                        <om:Property Name='MessageName' Value='DB2ImportFileResponse' />
                        <om:Property Name='OperationName' Value='ImportFile' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive DB2 Response' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Scope' OID='cf213b83-cf5c-4018-929b-35177a02dc19' ParentLink='ComplexStatement_Statement' LowerBound='115.1' HigherBound='148.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Try' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='7b5bb6f9-4ed3-4753-8d09-8b96052c949a' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='129.1'>
                            <om:Property Name='Expression' Value='xpathString = &quot;number(/*[local-name()=&apos;ImportFileResponse&apos;]/*[local-name()=&apos;Success&apos;]/*[local-name()=&apos;IMPORT_FILE&apos;]/@*[local-name()=&apos;FILEID&apos;])&quot;;&#xD;&#xA;FileID = System.Convert.ToInt32(xpath(DB2ImportFileResponse, xpathString));&#xD;&#xA;&#xD;&#xA;xpathString = &quot;number(/*[local-name()=&apos;ImportFileResponse&apos;]/*[local-name()=&apos;Success&apos;]/*[local-name()=&apos;IMPORT_FILE&apos;]/@*[local-name()=&apos;FILESTATUSID&apos;])&quot;;&#xD;&#xA;FileStatusID = System.Convert.ToInt32(xpath(DB2ImportFileResponse, xpathString));&#xD;&#xA;&#xD;&#xA;xpathString = &quot;number(/*[local-name()=&apos;ImportFileResponse&apos;]/*[local-name()=&apos;Success&apos;]/*[local-name()=&apos;IMPORT_FILE&apos;]/@*[local-name()=&apos;PERIODID&apos;])&quot;;&#xD;&#xA;PeriodID = System.Convert.ToInt32(xpath(DB2ImportFileResponse, xpathString));&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get returncode' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='d78c787d-76b8-4598-9f15-7e8cfab99534' ParentLink='ComplexStatement_Statement' LowerBound='129.1' HigherBound='131.1'>
                            <om:Property Name='Expression' Value='status = 0;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get returncode' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='56792c53-3155-4f54-b974-4392b5cadb98' ParentLink='Scope_Catch' LowerBound='134.1' HigherBound='146.1'>
                            <om:Property Name='ExceptionType' Value='General Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Catch' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='c6b8fda0-17ea-4f71-8911-9650121a5744' ParentLink='Catch_Statement' LowerBound='137.1' HigherBound='143.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Set err msg' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='0e12c1a0-4a7a-4a90-abda-ee7805c16038' ParentLink='ComplexStatement_Statement' LowerBound='140.1' HigherBound='142.1'>
                                    <om:Property Name='Expression' Value='ExceptionMsg = DB2ImportFileResponse;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='Set err msg' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='0461dd2c-9aeb-4eb5-91e9-5170af9f6c19' ParentLink='Construct_MessageRef' LowerBound='138.43' HigherBound='138.55'>
                                    <om:Property Name='Ref' Value='ExceptionMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Throw' OID='a5252301-f00a-4355-bba9-370566c2eab7' ParentLink='Catch_Statement' LowerBound='143.1' HigherBound='145.1'>
                                <om:Property Name='ThrownReference' Value='ImportFileException' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Throw' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='70822a75-fe3f-4390-864a-58f6273d4cdc' ParentLink='Scope_Catch' LowerBound='151.1' HigherBound='160.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='5efb35b0-e793-416b-959a-99c26916c919' ParentLink='Catch_Statement' LowerBound='154.1' HigherBound='157.1'>
                            <om:Property Name='Expression' Value='ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error message' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='e2059a03-6b78-4471-80ad-6888053eb662' ParentLink='Catch_Statement' LowerBound='157.1' HigherBound='159.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_1' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CallOrchestration_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='4ef66a10-64bf-4da7-877e-535f2fc2f752' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='status' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='aada57c0-32ab-48de-9f80-904955d97fe4' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='e95bac22-338b-47a8-bb22-f2defac2f3a7' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9eeff43f-b19e-4a07-9b85-4d39539cd979' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9fdd98b6-5778-4170-98fc-20d6bd72dd2e' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='28c995f2-f067-4d81-a5f7-a9e698f4725d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='45' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.DB2ImportFileType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2_ImportFile' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='3356931b-451c-4cc5-b394-a06909953694' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __subImportFile_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __subImportFile_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subImportFile")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportFile __svc__ = (subImportFile)_service;
                __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.DB2_ImportFile != null)
                {
                    __svc__.DB2_ImportFile.Close(this, null);
                    __svc__.DB2_ImportFile = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __subImportFile_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __subImportFile_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subImportFile")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportFile __svc__ = (subImportFile)_service;
                __subImportFile_1 __ctx1__ = (__subImportFile_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__splittedFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__receivedFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportFileException = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tmpString = null;
                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("FileInfo")]
            public __messagetype_MedegaImportSchema_Schemas_GeneralFileInfo __FileInfo;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2ImportFileRequest")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest __DB2ImportFileRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMsg")]
            public __messagetype_System_Xml_XmlDocument __ExceptionMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("GuardsFile")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __GuardsFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2ImportFileResponse")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse __DB2ImportFileResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportFileException")]
            internal System.Exception __ImportFileException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("receivedFileName")]
            internal System.String __receivedFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmpString")]
            internal System.String __tmpString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("splittedFileName")]
            internal GeneralBiztalkHelper.SplitString __splittedFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Variable_1")]
            internal System.String __Variable_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("PeriodID")]
            internal System.Int32 __PeriodID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("status")]
            internal System.Int32 __status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SSOHelper")]
            internal CODit.BizTalkHelpers.BizTalkSSOHelper __SSOHelper;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileID")]
            internal System.Int32 __FileID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileStatusID")]
            internal System.Int32 __FileStatusID;
        }


        [System.SerializableAttribute]
        public class ____scope35_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope35_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope35")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[5];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportFile __svc__ = (subImportFile)_service;
                __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)(__svc__._stateMgrs[0]);
                ____scope35_2 __ctx2__ = (____scope35_2)(__svc__._stateMgrs[2]);
                __subImportFile_1 __ctx1__ = (__subImportFile_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2ImportFileRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileRequest);
                    __ctx1__.__DB2ImportFileRequest = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx2__ != null)
                    __ctx2__.__xpathString = null;
                if (__ctx1__ != null && __ctx1__.__FileInfo != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FileInfo);
                    __ctx1__.__FileInfo = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("xpathString")]
            internal System.String __xpathString;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope36_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope36_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope36")
            {
            }

            public override int Index { get { return 3; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;

                __seg__ = _service._segments[4];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                subImportFile __svc__ = (subImportFile)_service;
                __subImportFile_1 __ctx1__ = (__subImportFile_1)(__svc__._stateMgrs[1]);

                base.Finally();
            }

        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DB2_ImportFile")]
        internal DB2ImportFileType DB2_ImportFile;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DB2ImportFileType.ImportFile},
                                               typeof(subImportFile).GetField("DB2_ImportFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportFile), "DB2_ImportFile"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(MedegaImport.HandleException)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "53e7f6e2-c5d1-4696-89e3-119e2e28d223", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "53e7f6e2-c5d1-4696-89e3-119e2e28d223", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "0653e2f2-df5d-4298-8480-722b7f32c7a6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "0653e2f2-df5d-4298-8480-722b7f32c7a6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "a4b0227b-7516-432b-a3c8-c63cb123a2fe", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "5e695e8c-5e2d-4f29-8763-5e4a8200d56e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "5e695e8c-5e2d-4f29-8763-5e4a8200d56e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "cd368a80-c25a-49c6-aba4-e107d82c06c2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "cd368a80-c25a-49c6-aba4-e107d82c06c2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "7734464f-462e-4eb8-bf5b-558000752492", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "7734464f-462e-4eb8-bf5b-558000752492", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "b4a94870-d466-454d-abd6-2c38d63d4509", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "b4a94870-d466-454d-abd6-2c38d63d4509", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "cf213b83-cf5c-4018-929b-35177a02dc19", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "7b5bb6f9-4ed3-4753-8d09-8b96052c949a", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "7b5bb6f9-4ed3-4753-8d09-8b96052c949a", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "d78c787d-76b8-4598-9f15-7e8cfab99534", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "d78c787d-76b8-4598-9f15-7e8cfab99534", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "56792c53-3155-4f54-b974-4392b5cadb98", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "c6b8fda0-17ea-4f71-8911-9650121a5744", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "c6b8fda0-17ea-4f71-8911-9650121a5744", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "a5252301-f00a-4355-bba9-370566c2eab7", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "56792c53-3155-4f54-b974-4392b5cadb98", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "cf213b83-cf5c-4018-929b-35177a02dc19", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "70822a75-fe3f-4390-864a-58f6273d4cdc", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "5efb35b0-e793-416b-959a-99c26916c919", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "5efb35b0-e793-416b-959a-99c26916c919", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "e2059a03-6b78-4471-80ad-6888053eb662", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "e2059a03-6b78-4471-80ad-6888053eb662", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "70822a75-fe3f-4390-864a-58f6273d4cdc", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "a4b0227b-7516-432b-a3c8-c63cb123a2fe", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,1,1,2,2,3,4,4,5,5,5,6,6,6,38,1,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 9,9,9,9,9,9,9,9,9,9,9,9,10,10,10,11,11,12,13,13,13,14,15,15,16,17,17,17,29,29,29,29,};
        public static int[] __progressLocation3 = new int[] { 19,19,19,20,20,20,20,20,20,22,22,23,23,23,23,};
        public static int[] __progressLocation4 = new int[] { 24,24,25,25,26,27,27,28,28,};
        public static int[] __progressLocation5 = new int[] { 30,30,31,31,32,32,35,35,36,37,37,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                DB2_ImportFile = new DB2ImportFileType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __subImportFile_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__GuardsFile = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard("GuardsFile", __ctx1__);
                __ctx1__.__GuardsFile.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[2]);
                __ctx1__.RefMessage(__ctx1__.__GuardsFile);
                __ctx1__.__GuardsFile.ConstructionCompleteEvent();
                __ctx1__.__DB2ImportFileResponse = null;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__ImportFileException = default(System.Exception);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__receivedFileName = default(System.String);
                __ctx1__.__tmpString = default(System.String);
                __ctx1__.__splittedFileName = default(GeneralBiztalkHelper.SplitString);
                __ctx1__.__Variable_1 = default(System.String);
                __ctx1__.__PeriodID = default(System.Int32);
                __ctx1__.__status = default(System.Int32);
                __ctx1__.__SSOHelper = default(CODit.BizTalkHelpers.BizTalkSSOHelper);
                __ctx1__.__FileID = default(System.Int32);
                __ctx1__.__FileStatusID = default(System.Int32);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__ExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__ImportFileException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__receivedFileName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__tmpString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__splittedFileName = new GeneralBiztalkHelper.SplitString();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__Variable_1 = "";
                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__SSOHelper = new CODit.BizTalkHelpers.BizTalkSSOHelper();
                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);
                    __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse __DB2ImportFileResponse = new __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse("DB2ImportFileResponse", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ExceptionMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __DB2ImportFileResponse.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                    if (__ctx1__.__DB2ImportFileResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileResponse);
                    __ctx1__.__DB2ImportFileResponse = __DB2ImportFileResponse;
                    __ctx1__.RefMessage(__ctx1__.__DB2ImportFileResponse);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                __ctx1__.__DB2ImportFileResponse.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __ctx1__.__status = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                __ctx1__.__FileStatusID = -1;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__FileID = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __ctx2__ = new ____scope35_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__splittedFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmpString = null;
                if (__ctx1__ != null)
                    __ctx1__.__receivedFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportFileException = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (DB2_ImportFile != null)
                {
                    DB2_ImportFile.Close(__ctx1__, __seg__);
                    DB2_ImportFile = null;
                }
                Tracker.FireEvent(__eventLocations[38],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 27;
            case 27:
                Args[0] = __ctx1__.__FileID;
                Args[1] = __ctx1__.__FileStatusID;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[3])).message = __ctx1__.__DB2ImportFileResponse;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[3])).context.RefMessage(__ctx1__.__DB2ImportFileResponse);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__xpathString = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx2__.__xpathString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __condition__ = (__ctx1__.__GuardsFile.GetPropertyValueNoThrow(typeof(FILE.ReceivedFileName)) != null);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 6;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__receivedFileName = (System.String)__ctx1__.__GuardsFile.GetPropertyValueThrows(typeof(FILE.ReceivedFileName));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = (__ctx1__.__GuardsFile.GetPropertyValueNoThrow(typeof(FTP.ReceivedFileName)) != null);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 10;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__receivedFileName = (System.String)__ctx1__.__GuardsFile.GetPropertyValueThrows(typeof(FTP.ReceivedFileName));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 10:
                __ctx1__.__receivedFileName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__tmpString = __ctx1__.__receivedFileName.Substring(0, __ctx1__.__receivedFileName.LastIndexOf('.'));
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__splittedFileName = new GeneralBiztalkHelper.SplitString(__ctx1__.__tmpString, '_');
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                {
                    __messagetype_MedegaImportSchema_Schemas_GeneralFileInfo __FileInfo = new __messagetype_MedegaImportSchema_Schemas_GeneralFileInfo("FileInfo", __ctx1__);
                    __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest __DB2ImportFileRequest = new __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileRequest("DB2ImportFileRequest", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<ns0:FileInfo xmlns:ns0='http://www.riziv.fgov.be/medega/v1.0'><PeriodFromDay></PeriodFromDay><PeriodFromMonth></PeriodFromMonth><PeriodFromYear></PeriodFromYear><PeriodToDay></PeriodToDay><PeriodToMonth></PeriodToMonth><PeriodToYear></PeriodToYear><FileName></FileName></ns0:FileInfo>");
                    __FileInfo.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __FileInfo.part.SetDistinguishedField("PeriodFromDay", __ctx1__.__splittedFileName.Elements[2]);
                    __FileInfo.part.SetDistinguishedField("PeriodFromMonth", __ctx1__.__splittedFileName.Elements[3]);
                    __FileInfo.part.SetDistinguishedField("PeriodFromYear", __ctx1__.__splittedFileName.Elements[4]);
                    __FileInfo.part.SetDistinguishedField("PeriodToDay", __ctx1__.__splittedFileName.Elements[5]);
                    __FileInfo.part.SetDistinguishedField("PeriodToMonth", __ctx1__.__splittedFileName.Elements[6]);
                    __FileInfo.part.SetDistinguishedField("PeriodToYear", __ctx1__.__splittedFileName.Elements[7]);
                    __FileInfo.part.SetDistinguishedField("FileName", __ctx1__.__receivedFileName);
                    ApplyTransform(typeof(MedegaImport.Mappings.CreateDB2ImportFileRequest), new object[] {__DB2ImportFileRequest.part}, new object[] {__FileInfo.part});
                    __Context.CopyFrom(__DB2ImportFileRequest);

                    if (__ctx1__.__FileInfo != null)
                        __ctx1__.UnrefMessage(__ctx1__.__FileInfo);
                    __ctx1__.__FileInfo = __FileInfo;
                    __ctx1__.RefMessage(__ctx1__.__FileInfo);
                    if (__ctx1__.__DB2ImportFileRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileRequest);
                    __ctx1__.__DB2ImportFileRequest = __DB2ImportFileRequest;
                    __ctx1__.RefMessage(__ctx1__.__DB2ImportFileRequest);
                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                }
                __ctx1__.__FileInfo.ConstructionCompleteEvent(true);
                __ctx1__.__DB2ImportFileRequest.ConstructionCompleteEvent(true);
                __ctx1__.__Context.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__FileInfo);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileRequest);
                    __edata.Messages.Add(__ctx1__.__Context);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__FileInfo != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FileInfo);
                    __ctx1__.__FileInfo = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DB2_ImportFile.SendMessage(0, __ctx1__.__DB2ImportFileRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileRequest);
                    __edata.PortName = @"DB2_ImportFile";
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DB2ImportFileRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileRequest);
                    __ctx1__.__DB2ImportFileRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!DB2_ImportFile.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__DB2ImportFileResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportFileResponse);
                __ctx1__.__DB2ImportFileResponse = new __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse("DB2ImportFileResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DB2ImportFileResponse);
                DB2_ImportFile.ReceiveMessage(0, __msgEnv__, __ctx1__.__DB2ImportFileResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DB2ImportFileResponse);
                    __edata.PortName = @"DB2_ImportFile";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx3__ = new ____scope36_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__xpathString = null;
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 31;
            case 31:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx2__.__xpathString = "number(/*[local-name()='ImportFileResponse']/*[local-name()='Success']/*[local-name()='IMPORT_FILE']/@*[local-name()='FILEID'])";
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__FileID = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DB2ImportFileResponse.part, __ctx2__.__xpathString, typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx2__.__xpathString = "number(/*[local-name()='ImportFileResponse']/*[local-name()='Success']/*[local-name()='IMPORT_FILE']/@*[local-name()='FILESTATUSID'])";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__FileStatusID = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DB2ImportFileResponse.part, __ctx2__.__xpathString, typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx2__.__xpathString = "number(/*[local-name()='ImportFileResponse']/*[local-name()='Success']/*[local-name()='IMPORT_FILE']/@*[local-name()='PERIODID'])";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__PeriodID = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DB2ImportFileResponse.part, __ctx2__.__xpathString, typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__status = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 14;
            case 14:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(3);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[10],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);

                    __ExceptionMsg.CopyFrom(__ctx1__.__DB2ImportFileResponse);

                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                }
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[26],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[11],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                throw __ctx1__.__ImportFileException;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[12],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__ExceptionDescription = __ctx2__.__ex_0.Message;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[35],new object[] {__ctx1__.__status, __ctx1__.__Context, __ctx1__.__ExceptionMsg, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                    __ctx1__.__status = (System.Int32)args[0];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[36],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{B6CE5469-7A28-4B9B-AF49-7B9AB2C9E224}"))
        };

    }
    //#line 880 "D:\Data\Visual Studio 2005\Projects\MedegaImport\MedegaSSOTest\MedegaImport\Orchestrations\subImportGuardRecord.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.DB2ImportXmlType),
            typeof(MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService),
            typeof(MedegaImport.MailBusinessExceptionType),
            typeof(MedegaImport.MailOkPortType),
            typeof(MedegaImport.MailOkPortType)
        },
        new System.String[] {
            "DB2_ImportXml",
            "GuardsImportWS",
            "MailBusinessException",
            "MailOK",
            "MailDoneWithExceptions"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(MedegaImport.HandleException),
            typeof(MedegaImport.subUpdateFileStatus)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class subImportGuardRecord : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "MedegaImport.HandleException",
                "MedegaImport.subUpdateFileStatus"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] MedegaImportSchema.Schemas.Medega_Guard ImportGuard,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse ImportFileResponse,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 FileId)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(subImportGuardRecord));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static subImportGuardRecord()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 3, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __subImportGuardRecord_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[6];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public subImportGuardRecord(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "subImportGuardRecord", tracker)
        {
            ConstructorHelper();
        }

        public subImportGuardRecord(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "subImportGuardRecord")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>d3be70c8-4233-4b51-9b50-6dae7f0d8c25</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>059c68bb-220c-4d26-b80a-f5efc1c97b7e</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ImportGuard</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>0b282359-8a65-43c2-8914-7ceefb1640b2</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ImportFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>1dfd46af-829b-4648-b031-1c701699592f</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>FileId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>369ca3bc-9cd1-446c-a5bd-88122b72bc98</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Count Records</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>aef16134-31de-424e-aabd-2c24deffd52a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>15b42f18-5b6d-4785-adf4-836936a0f9b5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9558519a-50fc-472d-bbe8-7c01938ed28f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0c1bb6dd-b21b-4f8b-be6f-5ead1e1caa4c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3e40810a-26ec-41bb-98c2-d402eca2fe2a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>30184323-b447-4bd6-95a6-a2b3ac1ea8b5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>82aec7a2-7d68-46cc-aebf-626eeb4a35a8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>784c178b-1daf-4cc6-b912-d15a9f465809</ShapeID>      <ParentLink>Scope_VariableDeclaration</ParentLink>                <shapeText>tempString</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>40f06818-78e9-444f-ada7-9b2e163447be</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create DB2 Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0a6b7919-35f9-49e6-87b7-2e89c55b714f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>be355212-8a24-4571-83dd-36e810e7e590</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6c61b459-653c-49db-8fe3-7a23a18458c6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7e2ddd49-869b-4bc0-8c31-501e6bbe9c52</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6fe9aa5d-7e8f-45b2-9518-af28d864d441</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CreateDB2ImportXmlRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>970ab402-fcfb-49df-b724-91b6e640baf7</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>842bd5e6-ead0-402f-b91c-a7c2c8aa01f3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1b67667e-f6bf-4f91-9d23-eaf9e54f072d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3f37263f-6c08-41c0-b33a-79ad1add5edf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>041690f0-eb6d-4eba-a982-fecf91beadd5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send DB2 ImportXml</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>39f023cc-c654-4b56-9eb7-7c10707af64e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive DB2 Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>884698c6-7f38-4e84-9d27-0dc2dc1a55da</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5c3a2318-d7b5-4910-a5ea-011a644e27cb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>f80337f9-c7e5-4aed-bb89-c3e2b5f89072</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>69845107-d276-44a6-81c5-9b7a50456412</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>2297d5b0-b4ec-4d1a-af59-fc8bd6728147</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check sql return value</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1ed998b4-1a1e-458f-a731-8ab7e818cfca</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error status returned</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>91fdcb34-385a-455b-a682-4e6fef31a207</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct err msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>330081ff-3a65-4641-a093-24aecfe96f23</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>edcb588d-4740-4828-a855-39dc8a29c68f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>e771b8e5-309d-4fc0-8962-629696718736</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Throw CreateInvoice exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>7c6445cf-abaf-408f-8779-61d556fc77c9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4c7e4e6a-6bf1-44d2-83fd-c67e13b7f789</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CreateWSGuardsImportRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>110b1278-35dd-4aa4-a268-751e4366393f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CreateWSGuardsImportRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>aec1bc3a-4865-4ebf-b26d-81b54cafb4e1</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>600e612c-23f9-4f89-8b8f-b4214c603d9c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9631cae4-164a-4794-a91a-a4354a7ae4ec</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>f50e9cfe-8191-4a21-a3b6-8d217b917ab2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e0765328-8fda-47e9-affc-606c3b3ff5e4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>afe94e04-658a-4bd8-b913-9bd4bd567dcf</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0fe87d05-270a-44f1-adf2-d80d3662d5f6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Reset returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d6bfe0de-f8ba-4089-bb77-3091d573b827</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ImportGuardsCall</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>7a960a87-ae7c-42bd-ad8f-274640053490</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive WS Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>940d6c24-5f4f-4286-a787-bfb92cd51489</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check business error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>42c76a74-0630-4beb-bc33-7a1419349ec2</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Business error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>785a6b0f-f188-4b9d-9f01-bdc56ffd6bbc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>79ac4bd6-055c-4c8a-834b-cae6f8f0018a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct error mail</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5336f8e0-c53b-45b4-9304-3f7032b03616</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>31999107-67ba-4a10-9961-e8462d4bd8ad</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct error mail</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2a002491-197a-416f-9605-019379f339d6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Mail</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5c017909-b098-4939-846a-9e6c26c9ae35</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>133d0cc5-234b-4b78-8831-f201cf7639cd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Log WS response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>16ce49b6-1968-4f1d-a7a3-f31d548e2b05</ShapeID>      <ParentLink>Scope_MessageDeclaration</ParentLink>                <shapeText>MailErrorMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>01aa9c17-f2a5-4328-b8ca-9fe99a1b9606</ShapeID>      <ParentLink>Scope_MessageDeclaration</ParentLink>                <shapeText>WSGuardsImportRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>457a6529-6307-41d9-b211-04ccb51f9a30</ShapeID>      <ParentLink>Scope_MessageDeclaration</ParentLink>                <shapeText>WSGuardsImportResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>b2ea331a-e9d2-44f4-944b-3321453be73d</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a93df797-5a08-4464-8ad8-363d55855fc4</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set ex</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>a268394c-2b67-4da0-952d-8efcd3c77e26</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>HandleXmlException</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8539744e-d2b9-4f51-be4a-545cfc2c68c9</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>88fb2e80-3e6b-4777-814d-ee2e407fe90f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f546ac9a-ded7-4ade-8fd6-51cbfaa59ac4</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a203277f-2e5e-4e50-84de-c670577ca8bc</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>5fcea51a-7900-4ba8-9588-f05ac50a9109</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>016f0e01-3ded-4ed5-b49e-c42f8d3a5c40</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increment Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>fbcfb504-208b-4021-8858-808f00aec876</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Technical error occured</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>0663aeb3-4edd-410b-9e0d-3e961bdf01c5</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Yes</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>baeab7ca-620f-4156-96ff-c4aff3e345a9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status Error</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5034e9f9-1ce0-4154-9094-538192d4ffd7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>e68491d5-76ef-430e-92cf-8e4c6658b75d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Business error occured</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>37fb3878-f107-4e75-a513-99cf1c1207cf</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Yes</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>515a3691-081e-4e4f-bf88-4d61bbc468e7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status Business error</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>a5c183ad-7eba-40fc-873a-aa75f279ff2d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f795c151-6826-4583-b286-0cf73fef6d50</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status Done</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>1dd17bd0-64fd-4690-8e81-1b0b51609438</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CallUpdateFileStatusId</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d5931e11-3c11-4025-b36d-ff7d1fb96823</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f85ad6cf-6288-44c9-8463-db0f1b1f70ae</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>NewFileStatusId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>d3d7dc48-6dab-4257-9a45-707e896b7a09</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Mail OK?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9b7b4874-a382-42fb-800d-29bf26a88b21</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>YES</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>24d09e9f-b066-4b83-97cf-862538d9daa8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send OK mail</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>77daa0be-bfef-4122-aeb7-68ac24bc11a9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7364d6fa-c48f-4738-9f65-dcdeaf2f67ef</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Done with errors</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'subImportGuardRecord'</ActionName><IsAtomic>0</IsAtomic><Line>880</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>ImportGuard</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>921</Line><Position>21</Position><ShapeID>'369ca3bc-9cd1-446c-a5bd-88122b72bc98'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>930</Line><Position>13</Position><ShapeID>'aef16134-31de-424e-aabd-2c24deffd52a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>933</Line><Position>28</Position><ShapeID>'15b42f18-5b6d-4785-adf4-836936a0f9b5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>936</Line><Position>17</Position><ShapeID>'9558519a-50fc-472d-bbe8-7c01938ed28f'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope37'</ActionName><IsAtomic>0</IsAtomic><Line>946</Line><Position>17</Position><ShapeID>'82aec7a2-7d68-46cc-aebf-626eeb4a35a8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>956</Line><Position>25</Position><ShapeID>'40f06818-78e9-444f-ada7-9b2e163447be'</ShapeID>
<Messages>
	<MsgInfo><name>DB2ImportXmlRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportXml+ImportXmlRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ImportGuardRecord</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard_Record</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ImportGuardRecord</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard_Record</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>968</Line><Position>25</Position><ShapeID>'041690f0-eb6d-4eba-a982-fecf91beadd5'</ShapeID>
<Messages>
	<MsgInfo><name>DB2ImportXmlRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportXml+ImportXmlRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>970</Line><Position>25</Position><ShapeID>'39f023cc-c654-4b56-9eb7-7c10707af64e'</ShapeID>
<Messages>
	<MsgInfo><name>DB2ImportXmlResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportXml+ImportXmlResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope38'</ActionName><IsAtomic>0</IsAtomic><Line>972</Line><Position>25</Position><ShapeID>'884698c6-7f38-4e84-9d27-0dc2dc1a55da'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>977</Line><Position>44</Position><ShapeID>'5c3a2318-d7b5-4910-a5ea-011a644e27cb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>984</Line><Position>33</Position><ShapeID>'f80337f9-c7e5-4aed-bb89-c3e2b5f89072'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>987</Line><Position>48</Position><ShapeID>'69845107-d276-44a6-81c5-9b7a50456412'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>992</Line><Position>25</Position><ShapeID>'2297d5b0-b4ec-4d1a-af59-fc8bd6728147'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>995</Line><Position>29</Position><ShapeID>'91fdcb34-385a-455b-a682-4e6fef31a207'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1001</Line><Position>29</Position><ShapeID>'e771b8e5-309d-4fc0-8962-629696718736'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1006</Line><Position>29</Position><ShapeID>'4c7e4e6a-6bf1-44d2-83fd-c67e13b7f789'</ShapeID>
<Messages>
	<MsgInfo><name>WSGuardsImportRequest</name><part>medegaGuardRequest</part><schema>MedegaImport.GuardsImportService.Reference+ImportMedegaGuardRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DB2ImportXmlRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportXml+ImportXmlRequest</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DB2ImportXmlResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportXml+ImportXmlResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1014</Line><Position>40</Position><ShapeID>'0fe87d05-270a-44f1-adf2-d80d3662d5f6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1017</Line><Position>29</Position><ShapeID>'d6bfe0de-f8ba-4089-bb77-3091d573b827'</ShapeID>
<Messages>
	<MsgInfo><name>WSGuardsImportRequest</name><part>medegaGuardRequest</part><schema>MedegaImport.GuardsImportService.Reference+ImportMedegaGuardRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1019</Line><Position>29</Position><ShapeID>'7a960a87-ae7c-42bd-ad8f-274640053490'</ShapeID>
<Messages>
	<MsgInfo><name>WSGuardsImportResponse</name><part>ImportMedegaGuardResult</part><schema>MedegaImport.GuardsImportService.Reference+ImportMedegaGuardResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1021</Line><Position>29</Position><ShapeID>'940d6c24-5f4f-4286-a787-bfb92cd51489'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1024</Line><Position>54</Position><ShapeID>'785a6b0f-f188-4b9d-9f01-bdc56ffd6bbc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1026</Line><Position>33</Position><ShapeID>'79ac4bd6-055c-4c8a-834b-cae6f8f0018a'</ShapeID>
<Messages>
	<MsgInfo><name>MailErrorMsg</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailErrorMsg</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1033</Line><Position>33</Position><ShapeID>'2a002491-197a-416f-9605-019379f339d6'</ShapeID>
<Messages>
	<MsgInfo><name>MailErrorMsg</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailErrorMsg</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1036</Line><Position>40</Position><ShapeID>'133d0cc5-234b-4b78-8831-f201cf7639cd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1047</Line><Position>25</Position><ShapeID>'b2ea331a-e9d2-44f4-944b-3321453be73d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1050</Line><Position>50</Position><ShapeID>'a93df797-5a08-4464-8ad8-363d55855fc4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1054</Line><Position>63</Position><ShapeID>'a268394c-2b67-4da0-952d-8efcd3c77e26'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1059</Line><Position>25</Position><ShapeID>'016f0e01-3ded-4ed5-b49e-c42f8d3a5c40'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1062</Line><Position>13</Position><ShapeID>'fbcfb504-208b-4021-8858-808f00aec876'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1065</Line><Position>33</Position><ShapeID>'baeab7ca-620f-4156-96ff-c4aff3e345a9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1070</Line><Position>17</Position><ShapeID>'e68491d5-76ef-430e-92cf-8e4c6658b75d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1073</Line><Position>37</Position><ShapeID>'515a3691-081e-4e4f-bf88-4d61bbc468e7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1078</Line><Position>37</Position><ShapeID>'f795c151-6826-4583-b286-0cf73fef6d50'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1082</Line><Position>51</Position><ShapeID>'1dd17bd0-64fd-4690-8e81-1b0b51609438'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1084</Line><Position>13</Position><ShapeID>'d3d7dc48-6dab-4257-9a45-707e896b7a09'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1087</Line><Position>17</Position><ShapeID>'24d09e9f-b066-4b83-97cf-862538d9daa8'</ShapeID>
<Messages>
	<MsgInfo><name>ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1092</Line><Position>17</Position><ShapeID>'7364d6fa-c48f-4738-9f65-dcdeaf2f67ef'</ShapeID>
<Messages>
	<MsgInfo><name>ImportFileResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_ImportFile+ImportFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ee79c801-66b2-4a2a-a53d-7ae2f7cdfbaa' LowerBound='1.1' HigherBound='250.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='6e7af749-f96f-496d-b45f-9094dd252b2a' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DB2ImportXmlType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bd8365a7-20d0-4554-953e-082669f3c9f5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportXml' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='7603ab97-4687-4b77-a78a-dfb6ad7f809d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.51'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='48e17447-df39-4f8f-8562-521a0b2326d0' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.53' HigherBound='8.92'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='74f4315c-0f8e-4c86-8755-1616acb1e37f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DB2ImportXmlLogType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f2fd88b7-fb20-4a5f-a168-4ee7c6689cb2' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='7bb9962f-5c73-4258-8ec8-028988fd9946' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.52'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ac97c4da-e645-40a6-b4f5-71e6a8bc7145' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MailBusinessExceptionType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cd605d53-49a5-44dd-93ae-7873e1b49828' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Mail' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ae18eaf7-f3f2-4d82-aca6-62d74b44e8c6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.26'>
                    <om:Property Name='Ref' Value='MedegaImport.ExceptionType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0b230262-3cf7-4c0d-b197-da547866545c' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MailOkPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f57fa769-135f-4728-a4fa-404ae5ec774e' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailDoneWithExceptions' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='5a233e4b-b630-4aa1-871f-d790f9ea61dc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.54'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fa4e8bba-5104-4134-9303-0ba52fa65b29' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='249.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subImportGuardRecord' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='167416d5-a090-4417-a407-568654c250ff' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportXmlException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c837edaf-cea3-41a6-854a-f2c981f00e3b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xpathString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8fe4c01d-a5d5-4f0c-bc7d-6d55c7f3d5da' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3ec3c803-3e8e-478f-95ec-56d9f43da312' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='totalRecords' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ab280f77-b0de-4455-abd0-51db31d0eed5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='counter' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3d4b196a-611b-494c-b82e-9767b487c03c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0de52249-a2aa-46f3-8032-7c3cd18b5bce' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ce5e8013-6bd7-40a2-8ea9-09410d4fe133' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='49b655b8-bedf-49d2-8330-2a723995bf0f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewFileStatusId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d5d10907-51a6-469a-a3fe-713ad45d0f6d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='BusinessErrorOccured' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ce8a3e5-5ac3-4c62-9dac-f7f3461ac9ff' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TechnicalErrorOccured' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e43e2022-3171-4e88-88df-5b4daf77ec54' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='CODit.BizTalkHelpers.BizTalkSSOHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SSOHelper' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fa4b3f01-7fcf-4486-a20a-ac5e28bf2712' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0d7f5b14-d450-4e47-8fa1-f73ce95eb82f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b0de8939-4096-4d84-b97c-2aee47039b6a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard_Record' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportGuardRecord' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f4b0f9fa-1328-4786-8362-ebfb49312696' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportXml.ImportXmlRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2ImportXmlRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='81100e84-2b73-4df2-be78-dcc90d024265' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportXml.ImportXmlResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2ImportXmlResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='d3be70c8-4233-4b51-9b50-6dae7f0d8c25' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='059c68bb-220c-4d26-b80a-f5efc1c97b7e' ParentLink='ServiceBody_Declaration' LowerBound='63.15' HigherBound='63.74'>
                    <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportGuard' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='0b282359-8a65-43c2-8914-7ceefb1640b2' ParentLink='ServiceBody_Declaration' LowerBound='63.76' HigherBound='63.144'>
                    <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_ImportFile.ImportFileResponse' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportFileResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='1dfd46af-829b-4648-b031-1c701699592f' ParentLink='ServiceBody_Declaration' LowerBound='63.146' HigherBound='63.165'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='369ca3bc-9cd1-446c-a5bd-88122b72bc98' ParentLink='ServiceBody_Statement' LowerBound='73.1' HigherBound='82.1'>
                    <om:Property Name='Expression' Value='counter = 1;&#xD;&#xA;totalRecords = System.Convert.ToInt32(xpath(ImportGuard, &quot;count(/*[local-name()=&apos;ROWSET&apos;]/*[local-name()=&apos;ROW&apos;])&quot;));&#xD;&#xA;NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending );&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;BusinessErrorOccured = false;&#xD;&#xA;TechnicalErrorOccured = false;&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Count Records' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='While' OID='aef16134-31de-424e-aabd-2c24deffd52a' ParentLink='ServiceBody_Statement' LowerBound='82.1' HigherBound='214.1'>
                    <om:Property Name='Expression' Value='counter &lt;= totalRecords' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='VariableAssignment' OID='15b42f18-5b6d-4785-adf4-836936a0f9b5' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='88.1'>
                        <om:Property Name='Expression' Value='returnCode = -99;&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='9558519a-50fc-472d-bbe8-7c01938ed28f' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='98.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='0c1bb6dd-b21b-4f8b-be6f-5ead1e1caa4c' ParentLink='Construct_MessageRef' LowerBound='89.27' HigherBound='89.34'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='3e40810a-26ec-41bb-98c2-d402eca2fe2a' ParentLink='Construct_MessageRef' LowerBound='89.36' HigherBound='89.48'>
                            <om:Property Name='Ref' Value='ExceptionMsg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='30184323-b447-4bd6-95a6-a2b3ac1ea8b5' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='97.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ExceptionMsg = tempXmlDoc;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='Initialize' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='82aec7a2-7d68-46cc-aebf-626eeb4a35a8' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='211.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Try' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableDeclaration' OID='784c178b-1daf-4cc6-b912-d15a9f465809' ParentLink='Scope_VariableDeclaration' LowerBound='104.1' HigherBound='105.1'>
                            <om:Property Name='UseDefaultConstructor' Value='False' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='tempString' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='40f06818-78e9-444f-ada7-9b2e163447be' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='120.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Create DB2 Request' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='0a6b7919-35f9-49e6-87b7-2e89c55b714f' ParentLink='Construct_MessageRef' LowerBound='109.35' HigherBound='109.54'>
                                <om:Property Name='Ref' Value='DB2ImportXmlRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='be355212-8a24-4571-83dd-36e810e7e590' ParentLink='Construct_MessageRef' LowerBound='109.56' HigherBound='109.73'>
                                <om:Property Name='Ref' Value='ImportGuardRecord' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='6c61b459-653c-49db-8fe3-7a23a18458c6' ParentLink='Construct_MessageRef' LowerBound='109.75' HigherBound='109.82'>
                                <om:Property Name='Ref' Value='Context' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='7e2ddd49-869b-4bc0-8c31-501e6bbe9c52' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='114.1'>
                                <om:Property Name='Expression' Value='xpathString = System.String.Format(&quot;/*[local-name()=&apos;ROWSET&apos;]/*[local-name()=&apos;ROW&apos;][{0}]&quot;,counter);&#xD;&#xA;ImportGuardRecord = xpath(ImportGuard, xpathString);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='6fe9aa5d-7e8f-45b2-9518-af28d864d441' ParentLink='ComplexStatement_Statement' LowerBound='114.1' HigherBound='116.1'>
                                <om:Property Name='ClassName' Value='MedegaImport.Mappings.CreateDB2ImportXmlRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='CreateDB2ImportXmlRequest' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='970ab402-fcfb-49df-b724-91b6e640baf7' ParentLink='Transform_InputMessagePartRef' LowerBound='115.112' HigherBound='115.129'>
                                    <om:Property Name='MessageRef' Value='ImportGuardRecord' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='842bd5e6-ead0-402f-b91c-a7c2c8aa01f3' ParentLink='Transform_InputMessagePartRef' LowerBound='115.131' HigherBound='115.149'>
                                    <om:Property Name='MessageRef' Value='ImportFileResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='1b67667e-f6bf-4f91-9d23-eaf9e54f072d' ParentLink='Transform_OutputMessagePartRef' LowerBound='115.40' HigherBound='115.59'>
                                    <om:Property Name='MessageRef' Value='DB2ImportXmlRequest' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='3f37263f-6c08-41c0-b33a-79ad1add5edf' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='119.1'>
                                <om:Property Name='Expression' Value='Context = DB2ImportXmlRequest;&#xD;&#xA;DB2ImportXmlRequest(BTS.SSOTicket) = SSOHelper.IssueSelfTicket();' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Assign context' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='041690f0-eb6d-4eba-a982-fecf91beadd5' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='122.1'>
                            <om:Property Name='PortName' Value='DB2_ImportXml' />
                            <om:Property Name='MessageName' Value='DB2ImportXmlRequest' />
                            <om:Property Name='OperationName' Value='ImportXml' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send DB2 ImportXml' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='39f023cc-c654-4b56-9eb7-7c10707af64e' ParentLink='ComplexStatement_Statement' LowerBound='122.1' HigherBound='124.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='DB2_ImportXml' />
                            <om:Property Name='MessageName' Value='DB2ImportXmlResponse' />
                            <om:Property Name='OperationName' Value='ImportXml' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive DB2 Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Scope' OID='884698c6-7f38-4e84-9d27-0dc2dc1a55da' ParentLink='ComplexStatement_Statement' LowerBound='124.1' HigherBound='144.1'>
                            <om:Property Name='InitializedTransactionType' Value='True' />
                            <om:Property Name='IsSynchronized' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Try' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='5c3a2318-d7b5-4910-a5ea-011a644e27cb' ParentLink='ComplexStatement_Statement' LowerBound='129.1' HigherBound='133.1'>
                                <om:Property Name='Expression' Value='returnCode = System.Convert.ToInt32(xpath(DB2ImportXmlResponse, &quot;number(/*[local-name()=&apos;ImportXmlResponse&apos;]/*[local-name()=&apos;Success&apos;]/*[local-name()=&apos;IMPORTXML&apos;]/@*[local-name()=&apos;IMPORTGUARDID&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;CIIV&quot;, returnCode.ToString());&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Get returncode' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Catch' OID='f80337f9-c7e5-4aed-bb89-c3e2b5f89072' ParentLink='Scope_Catch' LowerBound='136.1' HigherBound='142.1'>
                                <om:Property Name='ExceptionType' Value='General Exception' />
                                <om:Property Name='IsFaultMessage' Value='False' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Catch' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='69845107-d276-44a6-81c5-9b7a50456412' ParentLink='Catch_Statement' LowerBound='139.1' HigherBound='141.1'>
                                    <om:Property Name='Expression' Value='returnCode = -99;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Get returncode' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Decision' OID='2297d5b0-b4ec-4d1a-af59-fc8bd6728147' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='196.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Check sql return value' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='1ed998b4-1a1e-458f-a731-8ab7e818cfca' ParentLink='ReallyComplexStatement_Branch' LowerBound='145.25' HigherBound='156.1'>
                                <om:Property Name='Expression' Value='returnCode &lt;= 0' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Error status returned' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='91fdcb34-385a-455b-a682-4e6fef31a207' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='153.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct err msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='330081ff-3a65-4641-a093-24aecfe96f23' ParentLink='Construct_MessageRef' LowerBound='148.39' HigherBound='148.51'>
                                        <om:Property Name='Ref' Value='ExceptionMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='edcb588d-4740-4828-a855-39dc8a29c68f' ParentLink='ComplexStatement_Statement' LowerBound='150.1' HigherBound='152.1'>
                                        <om:Property Name='Expression' Value='ExceptionMsg = DB2ImportXmlResponse;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Assign ErrMsg' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Throw' OID='e771b8e5-309d-4fc0-8962-629696718736' ParentLink='ComplexStatement_Statement' LowerBound='153.1' HigherBound='155.1'>
                                    <om:Property Name='ThrownReference' Value='ImportXmlException' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Throw CreateInvoice exception' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='7c6445cf-abaf-408f-8779-61d556fc77c9' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='4c7e4e6a-6bf1-44d2-83fd-c67e13b7f789' ParentLink='ComplexStatement_Statement' LowerBound='158.1' HigherBound='166.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='CreateWSGuardsImportRequest' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='110b1278-35dd-4aa4-a268-751e4366393f' ParentLink='ComplexStatement_Statement' LowerBound='161.1' HigherBound='163.1'>
                                        <om:Property Name='ClassName' Value='MedegaImport.Mappings.DB2ImportXMLtoImportGuardRequest' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='CreateWSGuardsImportRequest' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='aec1bc3a-4865-4ebf-b26d-81b54cafb4e1' ParentLink='Transform_InputMessagePartRef' LowerBound='162.144' HigherBound='162.163'>
                                            <om:Property Name='MessageRef' Value='DB2ImportXmlRequest' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='600e612c-23f9-4f89-8b8f-b4214c603d9c' ParentLink='Transform_InputMessagePartRef' LowerBound='162.165' HigherBound='162.185'>
                                            <om:Property Name='MessageRef' Value='DB2ImportXmlResponse' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='9631cae4-164a-4794-a91a-a4354a7ae4ec' ParentLink='Transform_OutputMessagePartRef' LowerBound='162.44' HigherBound='162.84'>
                                            <om:Property Name='MessageRef' Value='WSGuardsImportRequest' />
                                            <om:Property Name='PartRef' Value='medegaGuardRequest' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_6' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='f50e9cfe-8191-4a21-a3b6-8d217b917ab2' ParentLink='ComplexStatement_Statement' LowerBound='163.1' HigherBound='165.1'>
                                        <om:Property Name='Expression' Value='Context = WSGuardsImportRequest.medegaGuardRequest;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Assign Context' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='e0765328-8fda-47e9-affc-606c3b3ff5e4' ParentLink='Construct_MessageRef' LowerBound='159.39' HigherBound='159.60'>
                                        <om:Property Name='Ref' Value='WSGuardsImportRequest' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='afe94e04-658a-4bd8-b913-9bd4bd567dcf' ParentLink='Construct_MessageRef' LowerBound='159.62' HigherBound='159.69'>
                                        <om:Property Name='Ref' Value='Context' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='0fe87d05-270a-44f1-adf2-d80d3662d5f6' ParentLink='ComplexStatement_Statement' LowerBound='166.1' HigherBound='169.1'>
                                    <om:Property Name='Expression' Value='returnCode = -1;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;RIZIV-INAMI.MedegaImport&quot;,&quot;Calling GuardsImport WS...&quot;);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Reset returnCode' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Send' OID='d6bfe0de-f8ba-4089-bb77-3091d573b827' ParentLink='ComplexStatement_Statement' LowerBound='169.1' HigherBound='171.1'>
                                    <om:Property Name='PortName' Value='GuardsImportWS' />
                                    <om:Property Name='MessageName' Value='WSGuardsImportRequest' />
                                    <om:Property Name='OperationName' Value='ImportMedegaGuard' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ImportGuardsCall' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Receive' OID='7a960a87-ae7c-42bd-ad8f-274640053490' ParentLink='ComplexStatement_Statement' LowerBound='171.1' HigherBound='173.1'>
                                    <om:Property Name='Activate' Value='False' />
                                    <om:Property Name='PortName' Value='GuardsImportWS' />
                                    <om:Property Name='MessageName' Value='WSGuardsImportResponse' />
                                    <om:Property Name='OperationName' Value='ImportMedegaGuard' />
                                    <om:Property Name='OperationMessageName' Value='Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Receive WS Response' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Decision' OID='940d6c24-5f4f-4286-a787-bfb92cd51489' ParentLink='ComplexStatement_Statement' LowerBound='173.1' HigherBound='188.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Check business error' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='DecisionBranch' OID='42c76a74-0630-4beb-bc33-7a1419349ec2' ParentLink='ReallyComplexStatement_Branch' LowerBound='174.29' HigherBound='188.1'>
                                        <om:Property Name='Expression' Value='WSGuardsImportResponse.ImportMedegaGuardResult.GuardStatus == &quot;Error&quot;' />
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Business error' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='VariableAssignment' OID='785a6b0f-f188-4b9d-9f01-bdc56ffd6bbc' ParentLink='ComplexStatement_Statement' LowerBound='176.1' HigherBound='178.1'>
                                            <om:Property Name='Expression' Value='BusinessErrorOccured = true;&#xD;&#xA;' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Set Status' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Construct' OID='79ac4bd6-055c-4c8a-834b-cae6f8f0018a' ParentLink='ComplexStatement_Statement' LowerBound='178.1' HigherBound='185.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Construct error mail' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessageRef' OID='5336f8e0-c53b-45b4-9304-3f7032b03616' ParentLink='Construct_MessageRef' LowerBound='179.43' HigherBound='179.55'>
                                                <om:Property Name='Ref' Value='MailErrorMsg' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='MessageAssignment' OID='31999107-67ba-4a10-9961-e8462d4bd8ad' ParentLink='ComplexStatement_Statement' LowerBound='181.1' HigherBound='184.1'>
                                                <om:Property Name='Expression' Value='MailErrorMsg.Context = Context;&#xD;&#xA;MailErrorMsg.ErrMsg = WSGuardsImportResponse.ImportMedegaGuardResult;' />
                                                <om:Property Name='ReportToAnalyst' Value='False' />
                                                <om:Property Name='Name' Value='Construct error mail' />
                                                <om:Property Name='Signal' Value='True' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='Send' OID='2a002491-197a-416f-9605-019379f339d6' ParentLink='ComplexStatement_Statement' LowerBound='185.1' HigherBound='187.1'>
                                            <om:Property Name='PortName' Value='MailBusinessException' />
                                            <om:Property Name='MessageName' Value='MailErrorMsg' />
                                            <om:Property Name='OperationName' Value='Mail' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Mail' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='DecisionBranch' OID='5c017909-b098-4939-846a-9e6c26c9ae35' ParentLink='ReallyComplexStatement_Branch'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Else' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='133d0cc5-234b-4b78-8831-f201cf7639cd' ParentLink='ComplexStatement_Statement' LowerBound='188.1' HigherBound='195.1'>
                                    <om:Property Name='Expression' Value='tempString = System.String.Format(&quot;GaurdStatus= {0}, FailureDesc= {1}, FailureCode= {2} &quot;&#xD;&#xA;, WSGuardsImportResponse.ImportMedegaGuardResult.GuardStatus&#xD;&#xA;, WSGuardsImportResponse.ImportMedegaGuardResult.FailureDescription&#xD;&#xA;, WSGuardsImportResponse.ImportMedegaGuardResult.FailureCode);&#xD;&#xA;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;RIZIV-INAMI.MedegaImport&quot;, tempString);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Log WS response' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageDeclaration' OID='16ce49b6-1968-4f1d-a7a3-f31d548e2b05' ParentLink='Scope_MessageDeclaration' LowerBound='101.1' HigherBound='102.1'>
                            <om:Property Name='Type' Value='MedegaImport.ExceptionType' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MailErrorMsg' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageDeclaration' OID='01aa9c17-f2a5-4328-b8ca-9fe99a1b9606' ParentLink='Scope_MessageDeclaration' LowerBound='102.1' HigherBound='103.1'>
                            <om:Property Name='Type' Value='MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_request' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='WSGuardsImportRequest' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageDeclaration' OID='457a6529-6307-41d9-b211-04ccb51f9a30' ParentLink='Scope_MessageDeclaration' LowerBound='103.1' HigherBound='104.1'>
                            <om:Property Name='Type' Value='MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_response' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='WSGuardsImportResponse' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='b2ea331a-e9d2-44f4-944b-3321453be73d' ParentLink='Scope_Catch' LowerBound='199.1' HigherBound='209.1'>
                            <om:Property Name='ExceptionName' Value='ex' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Catch' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='a93df797-5a08-4464-8ad8-363d55855fc4' ParentLink='Catch_Statement' LowerBound='202.1' HigherBound='206.1'>
                                <om:Property Name='Expression' Value='ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;&#xD;&#xA;TechnicalErrorOccured = true;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Set ex' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Call' OID='a268394c-2b67-4da0-952d-8efcd3c77e26' ParentLink='Catch_Statement' LowerBound='206.1' HigherBound='208.1'>
                                <om:Property Name='Identifier' Value='HandleXmlException' />
                                <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='HandleXmlException' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Parameter' OID='8539744e-d2b9-4f51-be4a-545cfc2c68c9' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='Ref' />
                                    <om:Property Name='Name' Value='returnCode' />
                                    <om:Property Name='Type' Value='System.Int32' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='88fb2e80-3e6b-4777-814d-ee2e407fe90f' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='Context' />
                                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='f546ac9a-ded7-4ade-8fd6-51cbfaa59ac4' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='ExceptionMsg' />
                                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='a203277f-2e5e-4e50-84de-c670577ca8bc' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='ExceptionDescription' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='5fcea51a-7900-4ba8-9588-f05ac50a9109' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='InnerExceptionDescription' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='016f0e01-3ded-4ed5-b49e-c42f8d3a5c40' ParentLink='ComplexStatement_Statement' LowerBound='211.1' HigherBound='213.1'>
                        <om:Property Name='Expression' Value='counter = counter + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increment Count' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='fbcfb504-208b-4021-8858-808f00aec876' ParentLink='ServiceBody_Statement' LowerBound='214.1' HigherBound='234.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Technical error occured' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='0663aeb3-4edd-410b-9e0d-3e961bdf01c5' ParentLink='ReallyComplexStatement_Branch' LowerBound='215.13' HigherBound='220.1'>
                        <om:Property Name='Expression' Value='TechnicalErrorOccured == true' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Yes' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='baeab7ca-620f-4156-96ff-c4aff3e345a9' ParentLink='ComplexStatement_Statement' LowerBound='217.1' HigherBound='219.1'>
                            <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Error );&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Status Error' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='5034e9f9-1ce0-4154-9094-538192d4ffd7' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Decision' OID='e68491d5-76ef-430e-92cf-8e4c6658b75d' ParentLink='ComplexStatement_Statement' LowerBound='222.1' HigherBound='233.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Business error occured' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='37fb3878-f107-4e75-a513-99cf1c1207cf' ParentLink='ReallyComplexStatement_Branch' LowerBound='223.17' HigherBound='228.1'>
                                <om:Property Name='Expression' Value='BusinessErrorOccured == true' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Yes' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='515a3691-081e-4e4f-bf88-4d61bbc468e7' ParentLink='ComplexStatement_Statement' LowerBound='225.1' HigherBound='227.1'>
                                    <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.BusinessRuleFailed );&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Status Business error' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='a5c183ad-7eba-40fc-873a-aa75f279ff2d' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='f795c151-6826-4583-b286-0cf73fef6d50' ParentLink='ComplexStatement_Statement' LowerBound='230.1' HigherBound='232.1'>
                                    <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Done );&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Status Done' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Call' OID='1dd17bd0-64fd-4690-8e81-1b0b51609438' ParentLink='ServiceBody_Statement' LowerBound='234.1' HigherBound='236.1'>
                    <om:Property Name='Identifier' Value='CallUpdateFileStatusId' />
                    <om:Property Name='Invokee' Value='MedegaImport.subUpdateFileStatus' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallUpdateFileStatusId' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Parameter' OID='d5931e11-3c11-4025-b36d-ff7d1fb96823' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='FileId' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='f85ad6cf-6288-44c9-8463-db0f1b1f70ae' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='NewFileStatusId' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='d3d7dc48-6dab-4257-9a45-707e896b7a09' ParentLink='ServiceBody_Statement' LowerBound='236.1' HigherBound='247.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Mail OK?' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='9b7b4874-a382-42fb-800d-29bf26a88b21' ParentLink='ReallyComplexStatement_Branch' LowerBound='237.13' HigherBound='242.1'>
                        <om:Property Name='Expression' Value='NewFileStatusId == System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Done )' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='YES' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Send' OID='24d09e9f-b066-4b83-97cf-862538d9daa8' ParentLink='ComplexStatement_Statement' LowerBound='239.1' HigherBound='241.1'>
                            <om:Property Name='PortName' Value='MailOK' />
                            <om:Property Name='MessageName' Value='ImportFileResponse' />
                            <om:Property Name='OperationName' Value='MailDoneWithExceptions' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send OK mail' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='77daa0be-bfef-4122-aeb7-68ac24bc11a9' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='7364d6fa-c48f-4738-9f65-dcdeaf2f67ef' ParentLink='ComplexStatement_Statement' LowerBound='244.1' HigherBound='246.1'>
                            <om:Property Name='PortName' Value='MailDoneWithExceptions' />
                            <om:Property Name='MessageName' Value='ImportFileResponse' />
                            <om:Property Name='OperationName' Value='MailDoneWithExceptions' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Done with errors' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='eb405d40-55a9-4026-a213-1c8cf742a5ae' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='53' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.DB2ImportXmlType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2_ImportXml' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='36427d47-6a51-4e32-993c-22e06dc3d10e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='31422a9f-5773-4c32-b6e5-cb91a86084af' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='82' />
                <om:Property Name='IsWebPort' Value='True' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GuardsImportWS' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='d50aee54-ed22-4299-b481-ba56e69ef282' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8da02e95-76ad-4d93-92ce-d7585aacc3d5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='86' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.MailBusinessExceptionType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailBusinessException' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='11c273f6-1fa7-419b-b2dc-99a9ffeba8ae' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7d5824a6-1b55-4bf9-9eb8-178e93179185' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='44.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='191' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.MailOkPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailOK' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a8e39dc7-249d-446b-aa98-073440bc6a13' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='37212951-af52-4c0d-bde4-7843c3123f7a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='44.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='160' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.MailOkPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailDoneWithExceptions' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='23bcaf90-012f-44b2-b441-3e73f6a7c16a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='44.1' HigherBound='45.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __subImportGuardRecord_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __subImportGuardRecord_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subImportGuardRecord")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportGuardRecord __svc__ = (subImportGuardRecord)_service;
                __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.MailOK != null)
                {
                    __svc__.MailOK.Close(this, null);
                    __svc__.MailOK = null;
                }
                if (__svc__.MailBusinessException != null)
                {
                    __svc__.MailBusinessException.Close(this, null);
                    __svc__.MailBusinessException = null;
                }
                if (__svc__.GuardsImportWS != null)
                {
                    __svc__.GuardsImportWS.Close(this, null);
                    __svc__.GuardsImportWS = null;
                }
                if (__svc__.MailDoneWithExceptions != null)
                {
                    __svc__.MailDoneWithExceptions.Close(this, null);
                    __svc__.MailDoneWithExceptions = null;
                }
                if (__svc__.DB2_ImportXml != null)
                {
                    __svc__.DB2_ImportXml.Close(this, null);
                    __svc__.DB2_ImportXml = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __subImportGuardRecord_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __subImportGuardRecord_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subImportGuardRecord")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportGuardRecord __svc__ = (subImportGuardRecord)_service;
                __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if (__ctx1__ != null && __ctx1__.__ImportGuard != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportGuard);
                    __ctx1__.__ImportGuard = null;
                }
                if (__ctx1__ != null && __ctx1__.__ImportFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportFileResponse);
                    __ctx1__.__ImportFileResponse = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xpathString = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportXmlException = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMsg")]
            public __messagetype_System_Xml_XmlDocument __ExceptionMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportGuardRecord")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard_Record __ImportGuardRecord;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2ImportXmlRequest")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest __DB2ImportXmlRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2ImportXmlResponse")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse __DB2ImportXmlResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportGuard")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __ImportGuard;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportFileResponse")]
            public __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse __ImportFileResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportXmlException")]
            internal System.Exception __ImportXmlException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xpathString")]
            internal System.String __xpathString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("totalRecords")]
            internal System.Int32 __totalRecords;
            [Microsoft.XLANGs.Core.UserVariableAttribute("counter")]
            internal System.Int32 __counter;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NewFileStatusId")]
            internal System.Int32 __NewFileStatusId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("BusinessErrorOccured")]
            internal System.Boolean __BusinessErrorOccured;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TechnicalErrorOccured")]
            internal System.Boolean __TechnicalErrorOccured;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SSOHelper")]
            internal CODit.BizTalkHelpers.BizTalkSSOHelper __SSOHelper;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileId")]
            internal System.Int32 __FileId;
        }


        [System.SerializableAttribute]
        public class ____scope37_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope37_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope37")
            {
            }

            public override int Index { get { return 2; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[5];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                subImportGuardRecord __svc__ = (subImportGuardRecord)_service;
                __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)(__svc__._stateMgrs[1]);
                __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)(__svc__._stateMgrs[0]);
                ____scope37_2 __ctx2__ = (____scope37_2)(__svc__._stateMgrs[2]);

                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__tempString = null;
                if (__ctx2__ != null && __ctx2__.__WSGuardsImportResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportResponse);
                    __ctx2__.__WSGuardsImportResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2ImportXmlRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlRequest);
                    __ctx1__.__DB2ImportXmlRequest = null;
                }
                if (__ctx2__ != null && __ctx2__.__WSGuardsImportRequest != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportRequest);
                    __ctx2__.__WSGuardsImportRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2ImportXmlResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlResponse);
                    __ctx1__.__DB2ImportXmlResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__ImportGuardRecord != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportGuardRecord);
                    __ctx1__.__ImportGuardRecord = null;
                }
                if (__ctx2__ != null && __ctx2__.__MailErrorMsg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__MailErrorMsg);
                    __ctx2__.__MailErrorMsg = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MailErrorMsg")]
            internal ExceptionType __MailErrorMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("WSGuardsImportRequest")]
            internal MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_request __WSGuardsImportRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("WSGuardsImportResponse")]
            internal MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_response __WSGuardsImportResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempString")]
            internal System.String __tempString;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope38_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope38_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope38")
            {
            }

            public override int Index { get { return 3; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;

                __seg__ = _service._segments[4];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                subImportGuardRecord __svc__ = (subImportGuardRecord)_service;
                base.Finally();
            }

        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DB2_ImportXml")]
        internal DB2ImportXmlType DB2_ImportXml;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(MedegaImport.GuardsImportService.GuardsImportService))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("GuardsImportWS")]
        internal MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService GuardsImportWS;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MailBusinessException")]
        internal MailBusinessExceptionType MailBusinessException;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MailOK")]
        internal MailOkPortType MailOK;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MailDoneWithExceptions")]
        internal MailOkPortType MailDoneWithExceptions;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DB2ImportXmlType.ImportXml},
                                               typeof(subImportGuardRecord).GetField("DB2_ImportXml", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "DB2_ImportXml"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService.ImportMedegaGuard, MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService.ImportMedegaXml, MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService.GetImportMedegaXmlResults, MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService.test},
                                               typeof(subImportGuardRecord).GetField("GuardsImportWS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "GuardsImportWS"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MailBusinessExceptionType.Mail},
                                               typeof(subImportGuardRecord).GetField("MailBusinessException", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "MailBusinessException"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MailOkPortType.MailDoneWithExceptions},
                                               typeof(subImportGuardRecord).GetField("MailOK", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "MailOK"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MailOkPortType.MailDoneWithExceptions},
                                               typeof(subImportGuardRecord).GetField("MailDoneWithExceptions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "MailDoneWithExceptions"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(MedegaImport.HandleException),
                    typeof(MedegaImport.subUpdateFileStatus)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "369ca3bc-9cd1-446c-a5bd-88122b72bc98", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "369ca3bc-9cd1-446c-a5bd-88122b72bc98", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "aef16134-31de-424e-aabd-2c24deffd52a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "15b42f18-5b6d-4785-adf4-836936a0f9b5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "15b42f18-5b6d-4785-adf4-836936a0f9b5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "9558519a-50fc-472d-bbe8-7c01938ed28f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9558519a-50fc-472d-bbe8-7c01938ed28f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "82aec7a2-7d68-46cc-aebf-626eeb4a35a8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "40f06818-78e9-444f-ada7-9b2e163447be", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "40f06818-78e9-444f-ada7-9b2e163447be", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "041690f0-eb6d-4eba-a982-fecf91beadd5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "041690f0-eb6d-4eba-a982-fecf91beadd5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "39f023cc-c654-4b56-9eb7-7c10707af64e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "39f023cc-c654-4b56-9eb7-7c10707af64e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "884698c6-7f38-4e84-9d27-0dc2dc1a55da", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "5c3a2318-d7b5-4910-a5ea-011a644e27cb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "5c3a2318-d7b5-4910-a5ea-011a644e27cb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "f80337f9-c7e5-4aed-bb89-c3e2b5f89072", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "69845107-d276-44a6-81c5-9b7a50456412", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "69845107-d276-44a6-81c5-9b7a50456412", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "f80337f9-c7e5-4aed-bb89-c3e2b5f89072", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "884698c6-7f38-4e84-9d27-0dc2dc1a55da", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "2297d5b0-b4ec-4d1a-af59-fc8bd6728147", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "91fdcb34-385a-455b-a682-4e6fef31a207", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "91fdcb34-385a-455b-a682-4e6fef31a207", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "e771b8e5-309d-4fc0-8962-629696718736", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "4c7e4e6a-6bf1-44d2-83fd-c67e13b7f789", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "4c7e4e6a-6bf1-44d2-83fd-c67e13b7f789", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "0fe87d05-270a-44f1-adf2-d80d3662d5f6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "0fe87d05-270a-44f1-adf2-d80d3662d5f6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "d6bfe0de-f8ba-4089-bb77-3091d573b827", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "d6bfe0de-f8ba-4089-bb77-3091d573b827", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "7a960a87-ae7c-42bd-ad8f-274640053490", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "7a960a87-ae7c-42bd-ad8f-274640053490", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "940d6c24-5f4f-4286-a787-bfb92cd51489", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "785a6b0f-f188-4b9d-9f01-bdc56ffd6bbc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "785a6b0f-f188-4b9d-9f01-bdc56ffd6bbc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "79ac4bd6-055c-4c8a-834b-cae6f8f0018a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "79ac4bd6-055c-4c8a-834b-cae6f8f0018a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "2a002491-197a-416f-9605-019379f339d6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "2a002491-197a-416f-9605-019379f339d6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "940d6c24-5f4f-4286-a787-bfb92cd51489", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "133d0cc5-234b-4b78-8831-f201cf7639cd", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "133d0cc5-234b-4b78-8831-f201cf7639cd", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "2297d5b0-b4ec-4d1a-af59-fc8bd6728147", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "b2ea331a-e9d2-44f4-944b-3321453be73d", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "a93df797-5a08-4464-8ad8-363d55855fc4", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "a93df797-5a08-4464-8ad8-363d55855fc4", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "a268394c-2b67-4da0-952d-8efcd3c77e26", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "a268394c-2b67-4da0-952d-8efcd3c77e26", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "b2ea331a-e9d2-44f4-944b-3321453be73d", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "82aec7a2-7d68-46cc-aebf-626eeb4a35a8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "016f0e01-3ded-4ed5-b49e-c42f8d3a5c40", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "016f0e01-3ded-4ed5-b49e-c42f8d3a5c40", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "aef16134-31de-424e-aabd-2c24deffd52a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "fbcfb504-208b-4021-8858-808f00aec876", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "baeab7ca-620f-4156-96ff-c4aff3e345a9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "baeab7ca-620f-4156-96ff-c4aff3e345a9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "e68491d5-76ef-430e-92cf-8e4c6658b75d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(66, "515a3691-081e-4e4f-bf88-4d61bbc468e7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(67, "515a3691-081e-4e4f-bf88-4d61bbc468e7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(68, "f795c151-6826-4583-b286-0cf73fef6d50", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(69, "f795c151-6826-4583-b286-0cf73fef6d50", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(70, "e68491d5-76ef-430e-92cf-8e4c6658b75d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(71, "fbcfb504-208b-4021-8858-808f00aec876", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(72, "1dd17bd0-64fd-4690-8e81-1b0b51609438", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(73, "1dd17bd0-64fd-4690-8e81-1b0b51609438", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(74, "d3d7dc48-6dab-4257-9a45-707e896b7a09", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(75, "24d09e9f-b066-4b83-97cf-862538d9daa8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(76, "24d09e9f-b066-4b83-97cf-862538d9daa8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(77, "7364d6fa-c48f-4738-9f65-dcdeaf2f67ef", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(78, "7364d6fa-c48f-4738-9f65-dcdeaf2f67ef", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(79, "d3d7dc48-6dab-4257-9a45-707e896b7a09", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,1,2,2,3,3,3,3,3,4,4,4,5,5,6,7,7,8,9,9,9,58,59,59,60,61,61,61,62,62,63,63,64,62,65,65,66,66,67,65,68,68,69,70,71,72,72,73,74,74,75,75,75,76,74,77,77,77,78,79,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 12,12,12,12,13,14,14,14,15,16,16,17,18,18,18,26,27,27,28,28,29,30,30,27,31,31,32,33,33,34,35,35,35,36,37,37,38,39,39,40,40,41,42,42,43,44,44,44,45,46,47,47,48,49,49,49,49,};
        public static int[] __progressLocation3 = new int[] { 20,20,20,21,21,21,21,};
        public static int[] __progressLocation4 = new int[] { 22,22,23,23,24,25,25,};
        public static int[] __progressLocation5 = new int[] { 50,50,51,51,52,52,52,55,55,56,57,57,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                DB2_ImportXml = new DB2ImportXmlType(0, this);
                GuardsImportWS = new MedegaImport.GuardsImportService.GuardsImportService_.GuardsImportService(1, this);
                MailBusinessException = new MailBusinessExceptionType(2, this);
                MailOK = new MailOkPortType(3, this);
                MailDoneWithExceptions = new MailOkPortType(4, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __subImportGuardRecord_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)_stateMgrs[0];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileId = (System.Int32)Args[2];
                __ctx1__.__ImportGuard = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard("ImportGuard", __ctx1__);
                __ctx1__.__ImportGuard.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__ImportGuard);
                __ctx1__.__ImportGuard.ConstructionCompleteEvent();
                __ctx1__.__ImportFileResponse = new __messagetype_MedegaImport_Schemas_DB2_ImportFile_ImportFileResponse("ImportFileResponse", __ctx1__);
                __ctx1__.__ImportFileResponse.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[1]);
                __ctx1__.RefMessage(__ctx1__.__ImportFileResponse);
                __ctx1__.__ImportFileResponse.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__ImportXmlException = default(System.Exception);
                __ctx1__.__xpathString = default(System.String);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__totalRecords = default(System.Int32);
                __ctx1__.__counter = default(System.Int32);
                __ctx1__.__returnCode = default(System.Int32);
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__NewFileStatusId = default(System.Int32);
                __ctx1__.__BusinessErrorOccured = default(System.Boolean);
                __ctx1__.__TechnicalErrorOccured = default(System.Boolean);
                __ctx1__.__SSOHelper = default(CODit.BizTalkHelpers.BizTalkSSOHelper);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__ImportXmlException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__xpathString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__BusinessErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__TechnicalErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__SSOHelper = new CODit.BizTalkHelpers.BizTalkSSOHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__counter = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__totalRecords = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ImportGuard.part, "count(/*[local-name()='ROWSET']/*[local-name()='ROW'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__BusinessErrorOccured = false;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__TechnicalErrorOccured = false;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __condition__ = __ctx1__.__counter <= __ctx1__.__totalRecords;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 36;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                __ctx1__.__returnCode = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ExceptionMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx2__ = new ____scope37_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                Tracker.FireEvent(__eventLocations[58],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[59],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__counter = __ctx1__.__counter + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[60],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[61],__eventData[18],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__xpathString = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportXmlException = null;
                if (MailBusinessException != null)
                {
                    MailBusinessException.Close(__ctx1__, __seg__);
                    MailBusinessException = null;
                }
                if (GuardsImportWS != null)
                {
                    GuardsImportWS.Close(__ctx1__, __seg__);
                    GuardsImportWS = null;
                }
                if (DB2_ImportXml != null)
                {
                    DB2_ImportXml.Close(__ctx1__, __seg__);
                    DB2_ImportXml = null;
                }
                Tracker.FireEvent(__eventLocations[61],__eventData[19],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[62],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __condition__ = __ctx1__.__TechnicalErrorOccured;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 43;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[63],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Error);
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[64],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[65],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                __condition__ = __ctx1__.__BusinessErrorOccured;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 49;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[66],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.BusinessRuleFailed);
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[67],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[68],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Done);
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                Tracker.FireEvent(__eventLocations[69],__eventData[3],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[70],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[71],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[72],__eventData[16],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subUpdateFileStatus(5, InstanceId, this);
                    _stateMgrs[5] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[72],new object[] {__ctx1__.__FileId, __ctx1__.__NewFileStatusId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[5]).Args;
                }
                Tracker.FireEvent(__eventLocations[73],__eventData[17],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[74],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                __condition__ = __ctx1__.__NewFileStatusId == System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Done);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 64;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[75],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                if ( !PreProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MailOK.SendMessage(0, __ctx1__.__ImportFileResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ImportFileResponse);
                    __edata.PortName = @"MailOK";
                    Tracker.FireEvent(__eventLocations[76],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[77],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 65;
            case 65:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MailDoneWithExceptions.SendMessage(0, __ctx1__.__ImportFileResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 67;
            case 67:
                if ( !PreProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ImportFileResponse);
                    __edata.PortName = @"MailDoneWithExceptions";
                    Tracker.FireEvent(__eventLocations[78],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 68;
            case 68:
                if ( !PreProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (MailDoneWithExceptions != null)
                {
                    MailDoneWithExceptions.Close(__ctx1__, __seg__);
                    MailDoneWithExceptions = null;
                }
                if (MailOK != null)
                {
                    MailOK.Close(__ctx1__, __seg__);
                    MailOK = null;
                }
                Tracker.FireEvent(__eventLocations[79],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 69;
            case 69:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__ImportGuard);
                    __edata.Messages.Add(__ctx1__.__ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ImportFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportFileResponse);
                    __ctx1__.__ImportFileResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__ImportGuard != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportGuard);
                    __ctx1__.__ImportGuard = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 71;
            case 71:
                if ( !PreProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 72;
            case 72:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)_stateMgrs[0];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__tempString = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx2__.__tempString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest __DB2ImportXmlRequest = new __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlRequest("DB2ImportXmlRequest", __ctx1__);
                    __messagetype_MedegaImportSchema_Schemas_Medega_Guard_Record __ImportGuardRecord = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard_Record("ImportGuardRecord", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);

                    __ctx1__.__xpathString = System.String.Format("/*[local-name()='ROWSET']/*[local-name()='ROW'][{0}]", __ctx1__.__counter);
                    __ImportGuardRecord.part.XPathAssign(__ctx1__.__ImportGuard.part, __ctx1__.__xpathString);
                    ApplyTransform(typeof(MedegaImport.Mappings.CreateDB2ImportXmlRequest), new object[] {__DB2ImportXmlRequest.part}, new object[] {__ImportGuardRecord.part, __ctx1__.__ImportFileResponse.part});
                    __Context.CopyFrom(__DB2ImportXmlRequest);
                    __DB2ImportXmlRequest.SetPropertyValue(typeof(BTS.SSOTicket), __ctx1__.__SSOHelper.IssueSelfTicket());

                    if (__ctx1__.__DB2ImportXmlRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlRequest);
                    __ctx1__.__DB2ImportXmlRequest = __DB2ImportXmlRequest;
                    __ctx1__.RefMessage(__ctx1__.__DB2ImportXmlRequest);
                    if (__ctx1__.__ImportGuardRecord != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ImportGuardRecord);
                    __ctx1__.__ImportGuardRecord = __ImportGuardRecord;
                    __ctx1__.RefMessage(__ctx1__.__ImportGuardRecord);
                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                }
                __ctx1__.__DB2ImportXmlRequest.ConstructionCompleteEvent(true);
                __ctx1__.__ImportGuardRecord.ConstructionCompleteEvent(true);
                __ctx1__.__Context.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DB2ImportXmlRequest);
                    __edata.Messages.Add(__ctx1__.__ImportGuardRecord);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ImportFileResponse);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ImportGuardRecord != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ImportGuardRecord);
                    __ctx1__.__ImportGuardRecord = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DB2_ImportXml.SendMessage(0, __ctx1__.__DB2ImportXmlRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DB2ImportXmlRequest);
                    __edata.PortName = @"DB2_ImportXml";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!DB2_ImportXml.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__DB2ImportXmlResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlResponse);
                __ctx1__.__DB2ImportXmlResponse = new __messagetype_MedegaImport_Schemas_DB2_ImportXml_ImportXmlResponse("DB2ImportXmlResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DB2ImportXmlResponse);
                DB2_ImportXml.ReceiveMessage(0, __msgEnv__, __ctx1__.__DB2ImportXmlResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DB2ImportXmlResponse);
                    __edata.PortName = @"DB2_ImportXml";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx3__ = new ____scope38_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[12],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __condition__ = __ctx1__.__returnCode <= 0;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 24;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);

                    __ExceptionMsg.CopyFrom(__ctx1__.__DB2ImportXmlResponse);

                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                }
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[29],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                throw __ctx1__.__ImportXmlException;
            case 23:
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_request __WSGuardsImportRequest = new MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_request("WSGuardsImportRequest", __ctx2__);
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);

                    ApplyTransform(typeof(MedegaImport.Mappings.DB2ImportXMLtoImportGuardRequest), new object[] {__WSGuardsImportRequest.medegaGuardRequest}, new object[] {__ctx1__.__DB2ImportXmlRequest.part, __ctx1__.__DB2ImportXmlResponse.part});
                    __Context.part.CopyFrom(__WSGuardsImportRequest.medegaGuardRequest);

                    if (__ctx2__.__WSGuardsImportRequest != null)
                        __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportRequest);
                    __ctx2__.__WSGuardsImportRequest = __WSGuardsImportRequest;
                    __ctx2__.RefMessage(__ctx2__.__WSGuardsImportRequest);
                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                }
                __ctx2__.__WSGuardsImportRequest.ConstructionCompleteEvent(true);
                __ctx1__.__Context.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__WSGuardsImportRequest);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__DB2ImportXmlRequest);
                    __edata.Messages.Add(__ctx1__.__DB2ImportXmlResponse);
                    Tracker.FireEvent(__eventLocations[32],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__returnCode = -1;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                GuardsImportWS.SendMessage(0, __ctx2__.__WSGuardsImportRequest, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__WSGuardsImportRequest);
                    __edata.PortName = @"GuardsImportWS";
                    Tracker.FireEvent(__eventLocations[36],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx2__ != null && __ctx2__.__WSGuardsImportRequest != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportRequest);
                    __ctx2__.__WSGuardsImportRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!GuardsImportWS.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx2__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx2__.__WSGuardsImportResponse != null)
                    __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportResponse);
                __ctx2__.__WSGuardsImportResponse = new MedegaImport.GuardsImportService.GuardsImportService_.ImportMedegaGuard_response("WSGuardsImportResponse", __ctx2__);
                __ctx2__.RefMessage(__ctx2__.__WSGuardsImportResponse);
                GuardsImportWS.ReceiveMessage(0, __msgEnv__, __ctx2__.__WSGuardsImportResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx2__.__WSGuardsImportResponse);
                    __edata.PortName = @"GuardsImportWS";
                    Tracker.FireEvent(__eventLocations[38],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __condition__ = (System.String)__ctx2__.__WSGuardsImportResponse.ImportMedegaGuardResult.GetDistinguishedField("GuardStatus") == "Error";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 49;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __ctx1__.__BusinessErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                {
                    ExceptionType __MailErrorMsg = new ExceptionType("MailErrorMsg", __ctx2__);

                    __MailErrorMsg.Context.CopyFrom(__ctx1__.__Context.part);
                    __MailErrorMsg.ErrMsg.CopyFrom(__ctx2__.__WSGuardsImportResponse.ImportMedegaGuardResult);

                    if (__ctx2__.__MailErrorMsg != null)
                        __ctx2__.UnrefMessage(__ctx2__.__MailErrorMsg);
                    __ctx2__.__MailErrorMsg = __MailErrorMsg;
                    __ctx2__.RefMessage(__ctx2__.__MailErrorMsg);
                }
                __ctx2__.__MailErrorMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__MailErrorMsg);
                    Tracker.FireEvent(__eventLocations[43],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MailBusinessException.SendMessage(0, __ctx2__.__MailErrorMsg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__MailErrorMsg);
                    __edata.PortName = @"MailBusinessException";
                    Tracker.FireEvent(__eventLocations[45],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx2__ != null && __ctx2__.__MailErrorMsg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__MailErrorMsg);
                    __ctx2__.__MailErrorMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[15],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                __ctx2__.__tempString = System.String.Format("GaurdStatus= {0}, FailureDesc= {1}, FailureCode= {2} ", (System.String)__ctx2__.__WSGuardsImportResponse.ImportMedegaGuardResult.GetDistinguishedField("GuardStatus"), (System.String)__ctx2__.__WSGuardsImportResponse.ImportMedegaGuardResult.GetDistinguishedField("FailureDescription"), (System.String)__ctx2__.__WSGuardsImportResponse.ImportMedegaGuardResult.GetDistinguishedField("FailureCode"));
                if (__ctx2__ != null && __ctx2__.__WSGuardsImportResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__WSGuardsImportResponse);
                    __ctx2__.__WSGuardsImportResponse = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                Tracker.FireEvent(__eventLocations[48],__eventData[3],_stateMgrs[2].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__tempString = null;
                if (__ctx1__ != null && __ctx1__.__DB2ImportXmlResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlResponse);
                    __ctx1__.__DB2ImportXmlResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2ImportXmlRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2ImportXmlRequest);
                    __ctx1__.__DB2ImportXmlRequest = null;
                }
                Tracker.FireEvent(__eventLocations[49],__eventData[15],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 56;
            case 56:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__returnCode = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__DB2ImportXmlResponse.part, "number(/*[local-name()='ImportXmlResponse']/*[local-name()='Success']/*[local-name()='IMPORTXML']/@*[local-name()='IMPORTGUARDID'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 6;
            case 6:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(3);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[10],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__returnCode = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[11],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__ExceptionDescription = __ctx2__.__ex_0.Message;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__TechnicalErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[16],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[55],new object[] {__ctx1__.__returnCode, __ctx1__.__Context, __ctx1__.__ExceptionMsg, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                    __ctx1__.__returnCode = (System.Int32)args[0];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[56],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[57],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{F2C7671D-67C9-488D-A39B-F9D59CC8E52F}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{FDC8BEEB-A3B8-456F-A91F-74AF075E8644}"))
        };

    }
    //#line 294 "D:\Data\Visual Studio 2005\Projects\MedegaImport\MedegaSSOTest\MedegaImport\Orchestrations\subUpdateFileStatus.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.DB2UpdateFileStatusType)
        },
        new System.String[] {
            "DB2UpdateFileStatus"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(MedegaImport.HandleException)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class subUpdateFileStatus : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "MedegaImport.HandleException"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 FileId,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 StatusId)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(subUpdateFileStatus));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static subUpdateFileStatus()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __subUpdateFileStatus_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public subUpdateFileStatus(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "subUpdateFileStatus", tracker)
        {
            ConstructorHelper();
        }

        public subUpdateFileStatus(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "subUpdateFileStatus")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>257b4299-1b27-4ff2-bc6d-2776b9fc19aa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>f1e7b04c-bd8d-4b68-a278-522aed583db6</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>FileId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>34e2f361-a03c-475f-acb8-e550e60427ed</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>StatusId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d03854a6-7efe-4636-8fd8-3d600361a80a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f6c5147b-21b1-429b-9aaa-544631c7d8f5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>aec8b1f3-7b53-4a27-bf1f-d6285d596e55</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>864fcc0d-cc9f-4dd0-b428-b511453636b7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>fcf10cc0-d8ee-420a-b487-be7923b17d67</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e8c4a390-66e8-4eb7-ba0f-ad8130b741da</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create UpdateFileStatusRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6ab43805-e868-4740-84a3-32e54c23a701</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3fc4317f-1da1-40d5-9fae-26ac30649e2c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>cc1d86cf-45f2-4401-b8dd-03d45b5cc268</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b2b09c60-85e6-4b6f-949e-1989c739e963</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>UpdateFileStatus</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>362debb6-d721-448e-948a-29210b15133b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive DB2 Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>40675d6c-ca14-4d89-80b8-49659e5065db</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ce50523b-5571-46c0-ac17-8d85ea6090bc</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set ex</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>6cdf8d35-94be-4cff-9bce-5ad180fd4b13</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>HandleXmlException</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f67b8086-4aac-4faa-997a-b3ad3d813ec2</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>17d519f8-afef-47c8-96b2-93afcb19dac7</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1d55befa-3381-4e5c-b0c6-30300fac4fc7</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9d150bfa-6dd0-4779-8abd-4f7b851a77ab</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a8b5c1a1-2dca-420e-8291-97571a55c34b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'subUpdateFileStatus'</ActionName><IsAtomic>0</IsAtomic><Line>294</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>318</Line><Position>13</Position><ShapeID>'d03854a6-7efe-4636-8fd8-3d600361a80a'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope39'</ActionName><IsAtomic>0</IsAtomic><Line>328</Line><Position>13</Position><ShapeID>'fcf10cc0-d8ee-420a-b487-be7923b17d67'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>333</Line><Position>21</Position><ShapeID>'e8c4a390-66e8-4eb7-ba0f-ad8130b741da'</ShapeID>
<Messages>
	<MsgInfo><name>DB2UpdateFileStatusRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_UpdateFileStatus+UpdateFileStatusRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>347</Line><Position>21</Position><ShapeID>'b2b09c60-85e6-4b6f-949e-1989c739e963'</ShapeID>
<Messages>
	<MsgInfo><name>DB2UpdateFileStatusRequest</name><part>part</part><schema>MedegaImport.Schemas.DB2_UpdateFileStatus+UpdateFileStatusRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>349</Line><Position>21</Position><ShapeID>'362debb6-d721-448e-948a-29210b15133b'</ShapeID>
<Messages>
	<MsgInfo><name>DB2UpdateFileStatusResponse</name><part>part</part><schema>MedegaImport.Schemas.DB2_UpdateFileStatus+UpdateFileStatusResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>354</Line><Position>21</Position><ShapeID>'40675d6c-ca14-4d89-80b8-49659e5065db'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>357</Line><Position>36</Position><ShapeID>'ce50523b-5571-46c0-ac17-8d85ea6090bc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>361</Line><Position>59</Position><ShapeID>'6cdf8d35-94be-4cff-9bce-5ad180fd4b13'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0c6ab1af-2c04-46a0-927a-37acfc98a931' LowerBound='1.1' HigherBound='86.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='42bce6e3-ce3f-4fbe-ab0b-1026cef7538d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DB2UpdateFileStatusType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c14375e1-4f8c-4f27-ba00-1c045081cad1' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateFileStatus' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='0001b183-b50a-401d-972e-b90354a4d26e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.65'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='44cbe465-5585-4a85-a3ad-1bcfd2d15094' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.67' HigherBound='8.120'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='0472e4cc-8098-43d2-b82e-756edc6defa6' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='85.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subUpdateFileStatus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='793fc1e5-de1b-4dfc-907e-263591fbda86' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c800e7d9-53d5-4940-8f02-24952aeb2f34' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8a150708-59c5-478c-bb62-d9d7ca81329b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4b996d87-4345-4c3e-9c34-ddf7d5b19b13' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5ad92776-acc8-4b1e-93ce-2485cc9042d8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateFileStatusExc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='47123ce7-424b-4170-a193-5015db6ba9a3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d77562f8-6cf5-43b3-be31-b80e78f17641' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='CODit.BizTalkHelpers.BizTalkSSOHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SSOHelper' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7490d2ad-9745-4085-95f4-c2049ccde9da' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2UpdateFileStatusRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e77dccb8-1681-440e-8475-a9e04f9e6423' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.DB2_UpdateFileStatus.UpdateFileStatusResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2UpdateFileStatusResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa835780-75be-44d0-837d-fd617b367106' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f3957024-f33b-4c71-82fa-f172f2b58feb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='257b4299-1b27-4ff2-bc6d-2776b9fc19aa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='f1e7b04c-bd8d-4b68-a278-522aed583db6' ParentLink='ServiceBody_Declaration' LowerBound='27.15' HigherBound='27.34'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='34e2f361-a03c-475f-acb8-e550e60427ed' ParentLink='ServiceBody_Declaration' LowerBound='27.36' HigherBound='27.57'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatusId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d03854a6-7efe-4636-8fd8-3d600361a80a' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='45.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='f6c5147b-21b1-429b-9aaa-544631c7d8f5' ParentLink='Construct_MessageRef' LowerBound='36.23' HigherBound='36.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='aec8b1f3-7b53-4a27-bf1f-d6285d596e55' ParentLink='Construct_MessageRef' LowerBound='36.32' HigherBound='36.38'>
                        <om:Property Name='Ref' Value='ErrMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='864fcc0d-cc9f-4dd0-b428-b511453636b7' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='44.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ErrMsg = tempXmlDoc;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='fcf10cc0-d8ee-420a-b487-be7923b17d67' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='83.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='e8c4a390-66e8-4eb7-ba0f-ad8130b741da' ParentLink='ComplexStatement_Statement' LowerBound='50.1' HigherBound='64.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Create UpdateFileStatusRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='6ab43805-e868-4740-84a3-32e54c23a701' ParentLink='Construct_MessageRef' LowerBound='51.31' HigherBound='51.57'>
                            <om:Property Name='Ref' Value='DB2UpdateFileStatusRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='3fc4317f-1da1-40d5-9fae-26ac30649e2c' ParentLink='Construct_MessageRef' LowerBound='51.59' HigherBound='51.66'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='cc1d86cf-45f2-4401-b8dd-03d45b5cc268' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='63.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempString = System.String.Format(&quot;&lt;ns0:UpdateFileStatusRequest xmlns:ns0=\&quot;http://inami-riziv.fgov.be.medega\&quot;&gt;&lt;sync&gt;&lt;StoredProcedure&gt;&lt;UPDATEFILESTATUS FILEID=\&quot;{0}\&quot; STATUSID=\&quot;{1}\&quot; /&gt;&lt;/StoredProcedure&gt;&lt;/sync&gt;&lt;/ns0:UpdateFileStatusRequest&gt;&quot;&#xD;&#xA;    , FileId, StatusId);&#xD;&#xA;&#xD;&#xA;tempXmlDoc.LoadXml(tempString);&#xD;&#xA;DB2UpdateFileStatusRequest = tempXmlDoc;&#xD;&#xA;DB2UpdateFileStatusRequest(BTS.SSOTicket) = SSOHelper.IssueSelfTicket();&#xD;&#xA;&#xD;&#xA;Context = DB2UpdateFileStatusRequest;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='b2b09c60-85e6-4b6f-949e-1989c739e963' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='66.1'>
                        <om:Property Name='PortName' Value='DB2UpdateFileStatus' />
                        <om:Property Name='MessageName' Value='DB2UpdateFileStatusRequest' />
                        <om:Property Name='OperationName' Value='UpdateFileStatus' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='UpdateFileStatus' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='362debb6-d721-448e-948a-29210b15133b' ParentLink='ComplexStatement_Statement' LowerBound='66.1' HigherBound='68.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='DB2UpdateFileStatus' />
                        <om:Property Name='MessageName' Value='DB2UpdateFileStatusResponse' />
                        <om:Property Name='OperationName' Value='UpdateFileStatus' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive DB2 Response' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='40675d6c-ca14-4d89-80b8-49659e5065db' ParentLink='Scope_Catch' LowerBound='71.1' HigherBound='81.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='ce50523b-5571-46c0-ac17-8d85ea6090bc' ParentLink='Catch_Statement' LowerBound='74.1' HigherBound='78.1'>
                            <om:Property Name='Expression' Value='returnCode = -1;&#xD;&#xA;ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set ex' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='6cdf8d35-94be-4cff-9bce-5ad180fd4b13' ParentLink='Catch_Statement' LowerBound='78.1' HigherBound='80.1'>
                            <om:Property Name='Identifier' Value='HandleXmlException' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='HandleXmlException' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='f67b8086-4aac-4faa-997a-b3ad3d813ec2' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='returnCode' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='17d519f8-afef-47c8-96b2-93afcb19dac7' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='1d55befa-3381-4e5c-b0c6-30300fac4fc7' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ErrMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9d150bfa-6dd0-4779-8abd-4f7b851a77ab' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='a8b5c1a1-2dca-420e-8291-97571a55c34b' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='11fea5c7-a917-442d-b9ad-c2435da186cd' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='30' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.DB2UpdateFileStatusType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DB2UpdateFileStatus' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2318306d-0dad-4a62-afe9-8d0853ffd5a5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __subUpdateFileStatus_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __subUpdateFileStatus_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subUpdateFileStatus")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subUpdateFileStatus __svc__ = (subUpdateFileStatus)_service;
                __subUpdateFileStatus_root_0 __ctx0__ = (__subUpdateFileStatus_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.DB2UpdateFileStatus != null)
                {
                    __svc__.DB2UpdateFileStatus.Close(this, null);
                    __svc__.DB2UpdateFileStatus = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __subUpdateFileStatus_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __subUpdateFileStatus_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subUpdateFileStatus")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                subUpdateFileStatus __svc__ = (subUpdateFileStatus)_service;
                __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__UpdateFileStatusExc = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempString = null;
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2UpdateFileStatusRequest")]
            public __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest __DB2UpdateFileStatusRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DB2UpdateFileStatusResponse")]
            public __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse __DB2UpdateFileStatusResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrMsg")]
            public __messagetype_System_Xml_XmlDocument __ErrMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("UpdateFileStatusExc")]
            internal System.Exception __UpdateFileStatusExc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempString")]
            internal System.String __tempString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SSOHelper")]
            internal CODit.BizTalkHelpers.BizTalkSSOHelper __SSOHelper;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileId")]
            internal System.Int32 __FileId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusId")]
            internal System.Int32 __StatusId;
        }


        [System.SerializableAttribute]
        public class ____scope39_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope39_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope39")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                subUpdateFileStatus __svc__ = (subUpdateFileStatus)_service;
                __subUpdateFileStatus_root_0 __ctx0__ = (__subUpdateFileStatus_root_0)(__svc__._stateMgrs[0]);
                ____scope39_2 __ctx2__ = (____scope39_2)(__svc__._stateMgrs[2]);
                __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2UpdateFileStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusResponse);
                    __ctx1__.__DB2UpdateFileStatusResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__DB2UpdateFileStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusRequest);
                    __ctx1__.__DB2UpdateFileStatusRequest = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DB2UpdateFileStatus")]
        internal DB2UpdateFileStatusType DB2UpdateFileStatus;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DB2UpdateFileStatusType.UpdateFileStatus},
                                               typeof(subUpdateFileStatus).GetField("DB2UpdateFileStatus", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subUpdateFileStatus), "DB2UpdateFileStatus"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(MedegaImport.HandleException)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d03854a6-7efe-4636-8fd8-3d600361a80a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "d03854a6-7efe-4636-8fd8-3d600361a80a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "fcf10cc0-d8ee-420a-b487-be7923b17d67", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "e8c4a390-66e8-4eb7-ba0f-ad8130b741da", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "e8c4a390-66e8-4eb7-ba0f-ad8130b741da", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "b2b09c60-85e6-4b6f-949e-1989c739e963", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "b2b09c60-85e6-4b6f-949e-1989c739e963", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "362debb6-d721-448e-948a-29210b15133b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "362debb6-d721-448e-948a-29210b15133b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "40675d6c-ca14-4d89-80b8-49659e5065db", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "ce50523b-5571-46c0-ac17-8d85ea6090bc", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "ce50523b-5571-46c0-ac17-8d85ea6090bc", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "6cdf8d35-94be-4cff-9bce-5ad180fd4b13", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "6cdf8d35-94be-4cff-9bce-5ad180fd4b13", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "40675d6c-ca14-4d89-80b8-49659e5065db", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "fcf10cc0-d8ee-420a-b487-be7923b17d67", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,2,2,3,4,4,4,20,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,8,9,10,10,11,11,11,11,};
        public static int[] __progressLocation3 = new int[] { 12,12,13,13,14,14,14,17,17,18,19,19,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __subUpdateFileStatus_root_0 __ctx0__ = (__subUpdateFileStatus_root_0)_stateMgrs[0];
            __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                DB2UpdateFileStatus = new DB2UpdateFileStatusType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __subUpdateFileStatus_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __subUpdateFileStatus_root_0 __ctx0__ = (__subUpdateFileStatus_root_0)_stateMgrs[0];
            ____scope39_2 __ctx2__ = (____scope39_2)_stateMgrs[2];
            __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileId = (System.Int32)Args[0];
                __ctx1__.__StatusId = (System.Int32)Args[1];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__returnCode = default(System.Int32);
                __ctx1__.__UpdateFileStatusExc = default(System.Exception);
                __ctx1__.__tempString = default(System.String);
                __ctx1__.__SSOHelper = default(CODit.BizTalkHelpers.BizTalkSSOHelper);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__ExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__UpdateFileStatusExc = new System.Exception();
                if (__ctx1__ != null)
                    __ctx1__.__UpdateFileStatusExc = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__tempString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__SSOHelper = new CODit.BizTalkHelpers.BizTalkSSOHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __ErrMsg = new __messagetype_System_Xml_XmlDocument("ErrMsg", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ErrMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__ErrMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = __ErrMsg;
                    __ctx1__.RefMessage(__ctx1__.__ErrMsg);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__ErrMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx2__ = new ____scope39_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__SSOHelper = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempString = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (DB2UpdateFileStatus != null)
                {
                    DB2UpdateFileStatus.Close(__ctx1__, __seg__);
                    DB2UpdateFileStatus = null;
                }
                Tracker.FireEvent(__eventLocations[20],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __subUpdateFileStatus_root_0 __ctx0__ = (__subUpdateFileStatus_root_0)_stateMgrs[0];
            ____scope39_2 __ctx2__ = (____scope39_2)_stateMgrs[2];
            __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest __DB2UpdateFileStatusRequest = new __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusRequest("DB2UpdateFileStatusRequest", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempString = System.String.Format("<ns0:UpdateFileStatusRequest xmlns:ns0=\"http://inami-riziv.fgov.be.medega\"><sync><StoredProcedure><UPDATEFILESTATUS FILEID=\"{0}\" STATUSID=\"{1}\" /></StoredProcedure></sync></ns0:UpdateFileStatusRequest>", __ctx1__.__FileId, __ctx1__.__StatusId);
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml(__ctx1__.__tempString);
                    __DB2UpdateFileStatusRequest.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __DB2UpdateFileStatusRequest.SetPropertyValue(typeof(BTS.SSOTicket), __ctx1__.__SSOHelper.IssueSelfTicket());
                    __Context.CopyFrom(__DB2UpdateFileStatusRequest);

                    if (__ctx1__.__DB2UpdateFileStatusRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusRequest);
                    __ctx1__.__DB2UpdateFileStatusRequest = __DB2UpdateFileStatusRequest;
                    __ctx1__.RefMessage(__ctx1__.__DB2UpdateFileStatusRequest);
                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                }
                __ctx1__.__DB2UpdateFileStatusRequest.ConstructionCompleteEvent(false);
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DB2UpdateFileStatusRequest);
                    __edata.Messages.Add(__ctx1__.__Context);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DB2UpdateFileStatus.SendMessage(0, __ctx1__.__DB2UpdateFileStatusRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DB2UpdateFileStatusRequest);
                    __edata.PortName = @"DB2UpdateFileStatus";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DB2UpdateFileStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusRequest);
                    __ctx1__.__DB2UpdateFileStatusRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!DB2UpdateFileStatus.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__DB2UpdateFileStatusResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusResponse);
                __ctx1__.__DB2UpdateFileStatusResponse = new __messagetype_MedegaImport_Schemas_DB2_UpdateFileStatus_UpdateFileStatusResponse("DB2UpdateFileStatusResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DB2UpdateFileStatusResponse);
                DB2UpdateFileStatus.ReceiveMessage(0, __msgEnv__, __ctx1__.__DB2UpdateFileStatusResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DB2UpdateFileStatusResponse);
                    __edata.PortName = @"DB2UpdateFileStatus";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DB2UpdateFileStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DB2UpdateFileStatusResponse);
                    __ctx1__.__DB2UpdateFileStatusResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope39_2 __ctx2__ = (____scope39_2)_stateMgrs[2];
            __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__returnCode = -1;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__ExceptionDescription = __ctx2__.__ex_0.Message;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[17],new object[] {__ctx1__.__returnCode, __ctx1__.__Context, __ctx1__.__ErrMsg, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                    __ctx1__.__returnCode = (System.Int32)args[0];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{7EEA3800-8F68-411D-B358-F330387917E2}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __MedegaImportSchema_Schemas_GeneralFileInfo__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImportSchema.Schemas.GeneralFileInfo _schema = new MedegaImportSchema.Schemas.GeneralFileInfo();

        public __MedegaImportSchema_Schemas_GeneralFileInfo__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImportSchema.Schemas.GeneralFileInfo",
        new System.Type[]{
            typeof(MedegaImportSchema.Schemas.GeneralFileInfo)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImportSchema_Schemas_GeneralFileInfo__)
        },
        0,
        @"http://www.riziv.fgov.be/medega/v1.0#FileInfo"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImportSchema_Schemas_GeneralFileInfo : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImportSchema_Schemas_GeneralFileInfo__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImportSchema_Schemas_GeneralFileInfo__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImportSchema_Schemas_GeneralFileInfo(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImportSchema_Schemas_Medega_Guard_Record__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImportSchema.Schemas.Medega_Guard_Record _schema = new MedegaImportSchema.Schemas.Medega_Guard_Record();

        public __MedegaImportSchema_Schemas_Medega_Guard_Record__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImportSchema.Schemas.Medega_Guard_Record",
        new System.Type[]{
            typeof(MedegaImportSchema.Schemas.Medega_Guard_Record)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImportSchema_Schemas_Medega_Guard_Record__)
        },
        0,
        @"http://www.riziv.fgov.be/medega/v1.0#ROW"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImportSchema_Schemas_Medega_Guard_Record : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImportSchema_Schemas_Medega_Guard_Record__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImportSchema_Schemas_Medega_Guard_Record__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImportSchema_Schemas_Medega_Guard_Record(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
