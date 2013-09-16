
#pragma warning disable 162

namespace MedegaImport
{

    [System.SerializableAttribute]
    sealed public class __MedegaImport_GuardService_tempuri_org_CreateGuard__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.GuardService_tempuri_org.CreateGuard _schema = new MedegaImport.GuardService_tempuri_org.CreateGuard();

        public __MedegaImport_GuardService_tempuri_org_CreateGuard__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.GuardService_tempuri_org.CreateGuard)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_GuardService_tempuri_org_CreateGuard__)
        },
        0,
        @"http://tempuri.org/#CreateGuard"
    )]
    [System.SerializableAttribute]
    sealed internal class IGuardService_CreateGuard_InputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_GuardService_tempuri_org_CreateGuard__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_GuardService_tempuri_org_CreateGuard__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IGuardService_CreateGuard_InputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_GuardService_tempuri_org_CreateGuardResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.GuardService_tempuri_org.CreateGuardResponse _schema = new MedegaImport.GuardService_tempuri_org.CreateGuardResponse();

        public __MedegaImport_GuardService_tempuri_org_CreateGuardResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.GuardService_tempuri_org.CreateGuardResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_GuardService_tempuri_org_CreateGuardResponse__)
        },
        0,
        @"http://tempuri.org/#CreateGuardResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class IGuardService_CreateGuard_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_GuardService_tempuri_org_CreateGuardResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_GuardService_tempuri_org_CreateGuardResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IGuardService_CreateGuard_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLCreateGuardPolling__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLCreateGuardPolling _schema = new MedegaImport.SQLCreateGuardPolling();

        public __MedegaImport_SQLCreateGuardPolling__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLCreateGuardPolling)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLCreateGuardPolling__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#CreateGuardPolling"
    )]
    [System.SerializableAttribute]
    sealed internal class CreateGuardPollResult : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLCreateGuardPolling__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLCreateGuardPolling__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public CreateGuardPollResult(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any),
            typeof(Microsoft.XLANGs.BaseTypes.Any),
            typeof(System.String)
        },
        new string[]{
            "Context",
            "ErrMsg",
            "ErrText"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__),
            typeof(__Microsoft_XLANGs_BaseTypes_Any__),
            typeof(__System_String__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed internal class ExceptionType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ Context;
        public __Microsoft_XLANGs_BaseTypes_Any__ ErrMsg;
        public __System_String__ ErrText;

        private void __CreatePartWrappers()
        {
            Context = new __Microsoft_XLANGs_BaseTypes_Any__(this, "Context", 0);
            this.AddPart("Context", 0, Context);
            ErrMsg = new __Microsoft_XLANGs_BaseTypes_Any__(this, "ErrMsg", 1);
            this.AddPart("ErrMsg", 1, ErrMsg);
            ErrText = new __System_String__(this, "ErrText", 2);
            this.AddPart("ErrText", 2, ErrText);
        }

        public ExceptionType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_MedegaFileStatus__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.MedegaFileStatus _schema = new MedegaImport.Schemas.MedegaFileStatus();

        public __MedegaImport_Schemas_MedegaFileStatus__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.Schemas.MedegaFileStatus)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_MedegaFileStatus__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#F"
    )]
    [System.SerializableAttribute]
    sealed internal class MedegaFileDonePolling : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_MedegaFileStatus__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_Schemas_MedegaFileStatus__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public MedegaFileDonePolling(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse _schema = new MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse();

        public __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLCreateMedegaFile_CreateMedegaFileResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#CreateMedegaFileResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class CreateMedegaFileResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public CreateMedegaFileResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLCreateMedegaFile.CreateMedegaFileRequest _schema = new MedegaImport.SQLCreateMedegaFile.CreateMedegaFileRequest();

        public __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLCreateMedegaFile.CreateMedegaFileRequest)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLCreateMedegaFile_CreateMedegaFileRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#CreateMedegaFileRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class CreateMedegaFileRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileRequest__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLCreateMedegaFile_CreateMedegaFileRequest__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public CreateMedegaFileRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeResponse _schema = new MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeResponse();

        public __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#CreateMedegaXmlNodeResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class CreateMedegaXmlNodeResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public CreateMedegaXmlNodeResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest _schema = new MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest();

        public __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#CreateMedegaXmlNodeRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class CreateMedegaXmlNodeRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeRequest__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLCreateMedegaXmlNode_CreateMedegaXmlNodeRequest__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public CreateMedegaXmlNodeRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(System.String),
            typeof(System.String)
        },
        new string[]{
            "FileId",
            "BusinessErrorMessages"
        },
        new System.Type[]{
            typeof(__System_String__),
            typeof(__System_String__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed internal class BusinessValidationErrors : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ FileId;
        public __System_String__ BusinessErrorMessages;

        private void __CreatePartWrappers()
        {
            FileId = new __System_String__(this, "FileId", 0);
            this.AddPart("FileId", 0, FileId);
            BusinessErrorMessages = new __System_String__(this, "BusinessErrorMessages", 1);
            this.AddPart("BusinessErrorMessages", 1, BusinessErrorMessages);
        }

        public BusinessValidationErrors(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusResponse _schema = new MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusResponse();

        public __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#SQLUpdateFileStatusResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class UpdateFileStatusResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public UpdateFileStatusResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusRequest _schema = new MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusRequest();

        public __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusRequest)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#SQLUpdateFileStatusRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class UpdateFileStatusRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusRequest__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLUpdateFileStatus_SQLUpdateFileStatusRequest__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public UpdateFileStatusRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusResponse _schema = new MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusResponse();

        public __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusResponse__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#UpdateNodeStatusResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class UpdateNodeStatusResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public UpdateNodeStatusResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusRequest _schema = new MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusRequest();

        public __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusRequest)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusRequest__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#UpdateNodeStatusRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class UpdateNodeStatusRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusRequest__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MedegaImport_SQLUpdateNodeStatus_UpdateNodeStatusRequest__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public UpdateNodeStatusRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BTS_soap_envelope_1__1_Fault__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BTS.soap_envelope_1__1.Fault _schema = new BTS.soap_envelope_1__1.Fault();

        public __BTS_soap_envelope_1__1_Fault__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BTS.soap_envelope_1__1.Fault",
        new System.Type[]{
            typeof(BTS.soap_envelope_1__1.Fault)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BTS_soap_envelope_1__1_Fault__)
        },
        0,
        @"http://schemas.xmlsoap.org/soap/envelope/#Fault"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BTS_soap_envelope_1__1_Fault : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BTS_soap_envelope_1__1_Fault__ part;

        private void __CreatePartWrappers()
        {
            part = new __BTS_soap_envelope_1__1_Fault__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BTS_soap_envelope_1__1_Fault(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CreateGuard",
        new System.Type[]{
            typeof(MedegaImport.IGuardService_CreateGuard_InputMessage), 
            typeof(MedegaImport.IGuardService_CreateGuard_OutputMessage), 
            typeof(MedegaImport.__messagetype_BTS_soap_envelope_1__1_Fault)
        },
        new string[]{
            "Fault"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class IGuardService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public IGuardService(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public IGuardService(IGuardService p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            IGuardService p = new IGuardService(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo CreateGuard = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CreateGuard",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(IGuardService),
            typeof(IGuardService_CreateGuard_InputMessage),
            typeof(IGuardService_CreateGuard_OutputMessage),
            new System.Type[]{
                typeof(__messagetype_BTS_soap_envelope_1__1_Fault)
            },
            new string[]{
                "Fault"
            }
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "CreateGuard" ] = CreateGuard;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __MedegaImport_Schemas_CreateGuardNode__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MedegaImport.Schemas.CreateGuardNode _schema = new MedegaImport.Schemas.CreateGuardNode();

        public __MedegaImport_Schemas_CreateGuardNode__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MedegaImport.Schemas.CreateGuardNode",
        new System.Type[]{
            typeof(MedegaImport.Schemas.CreateGuardNode)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MedegaImport_Schemas_CreateGuardNode__)
        },
        0,
        @"http://inami-riziv.fgov.be.medega#Node"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MedegaImport_Schemas_CreateGuardNode : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MedegaImport_Schemas_CreateGuardNode__ part;

        private void __CreatePartWrappers()
        {
            part = new __MedegaImport_Schemas_CreateGuardNode__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MedegaImport_Schemas_CreateGuardNode(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.CreateGuardPollResult)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLCreateGuardPT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLCreateGuardPT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLCreateGuardPT(SQLCreateGuardPT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLCreateGuardPT p = new SQLCreateGuardPT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SQLCreateGuardPT),
            typeof(CreateGuardPollResult),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CreateGuard",
        new System.Type[]{
            typeof(MedegaImport.__messagetype_MedegaImport_Schemas_CreateGuardNode)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RcvCreateGuardNodePT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvCreateGuardNodePT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvCreateGuardNodePT(RcvCreateGuardNodePT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvCreateGuardNodePT p = new RcvCreateGuardNodePT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo CreateGuard = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CreateGuard",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvCreateGuardNodePT),
            typeof(__messagetype_MedegaImport_Schemas_CreateGuardNode),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "CreateGuard" ] = CreateGuard;
                return h;
            }
        }
        #endregion // port reflection support
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
        @"http://www.riziv.fgov.be/medega/v2.0#ROWSET"
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.MedegaFileDonePolling)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLMedegaFileDonePollingPT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLMedegaFileDonePollingPT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLMedegaFileDonePollingPT(SQLMedegaFileDonePollingPT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLMedegaFileDonePollingPT p = new SQLMedegaFileDonePollingPT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SQLMedegaFileDonePollingPT),
            typeof(MedegaFileDonePolling),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
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
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.CreateMedegaFileRequest), 
            typeof(MedegaImport.CreateMedegaFileResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLCreateMedegaFilePT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLCreateMedegaFilePT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLCreateMedegaFilePT(SQLCreateMedegaFilePT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLCreateMedegaFilePT p = new SQLCreateMedegaFilePT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLCreateMedegaFilePT),
            typeof(CreateMedegaFileRequest),
            typeof(CreateMedegaFileResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(MedegaImport.CreateMedegaFileResponse)
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
            typeof(CreateMedegaFileResponse),
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
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.CreateMedegaXmlNodeRequest), 
            typeof(MedegaImport.CreateMedegaXmlNodeResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLCreateMedegaXmlNodePT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLCreateMedegaXmlNodePT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLCreateMedegaXmlNodePT(SQLCreateMedegaXmlNodePT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLCreateMedegaXmlNodePT p = new SQLCreateMedegaXmlNodePT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLCreateMedegaXmlNodePT),
            typeof(CreateMedegaXmlNodeRequest),
            typeof(CreateMedegaXmlNodeResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Mail",
        new System.Type[]{
            typeof(MedegaImport.BusinessValidationErrors)
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
            typeof(BusinessValidationErrors),
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
            typeof(MedegaImport.BusinessValidationErrors)
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
            typeof(BusinessValidationErrors),
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
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.UpdateFileStatusRequest), 
            typeof(MedegaImport.UpdateFileStatusResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLUpdateFileStatusPT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLUpdateFileStatusPT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLUpdateFileStatusPT(SQLUpdateFileStatusPT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLUpdateFileStatusPT p = new SQLUpdateFileStatusPT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLUpdateFileStatusPT),
            typeof(UpdateFileStatusRequest),
            typeof(UpdateFileStatusResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "procedure",
        new System.Type[]{
            typeof(MedegaImport.UpdateNodeStatusRequest), 
            typeof(MedegaImport.UpdateNodeStatusResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLUpdateNodeStatusPT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLUpdateNodeStatusPT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLUpdateNodeStatusPT(SQLUpdateNodeStatusPT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLUpdateNodeStatusPT p = new SQLUpdateNodeStatusPT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLUpdateNodeStatusPT),
            typeof(UpdateNodeStatusRequest),
            typeof(UpdateNodeStatusResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 507 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\CreateGuard.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvGuardNode", "CreateGuard", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.RcvCreateGuardNodePT),
            typeof(MedegaImport.IGuardService)
        },
        new System.String[] {
            "RcvGuardNode",
            "CreateGuardService"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(MedegaImport.HandleException),
            typeof(MedegaImport.subUpdateNodeStatus)
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
    sealed internal class CreateGuard : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "MedegaImport.HandleException",
                "MedegaImport.subUpdateNodeStatus"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CreateGuard));
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

        static CreateGuard()
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
            _rootContext = new __CreateGuard_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[6];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CreateGuard(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CreateGuard", tracker)
        {
            ConstructorHelper();
        }

        public CreateGuard(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CreateGuard")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>f289a3ba-f840-4e2e-8cb8-5dcd90f486db</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>57e07653-eae5-4775-b759-fc1835e3e0b3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>RcvGuardNode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c3415c46-b36f-4739-9876-755d35d1c500</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ec289974-75c6-47c5-981e-554c9d13e2a5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a12e5dde-3853-4d49-aceb-915ea2340d77</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>2b3e66b9-fb9c-4d61-abfd-7dcaaa050fb3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>143011b5-f318-456e-82bd-9907be480c48</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>cdf80c02-c5f4-46bd-ae04-b61c2da63b6b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Create Guard</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3d8b0ef7-b740-4d1b-9f10-0aadc7929d5e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e877699e-2524-4169-b9a3-e994f20e6477</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>772c28da-4598-4786-88ae-40d7b76d91f6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MapCreateGuard</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>49aaa470-3f98-4442-8395-e98c48e5de21</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>225a5bc1-c386-457d-a58a-ade07a60d254</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>84caf992-b4d6-461c-84af-5439522425d9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>01176e6d-6c53-47fd-9f9b-3292f764eb27</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>fa0fcf45-cb55-44f4-954d-925a6574bd55</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send CreateGuard</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>21a8f133-5452-41c5-b71a-b1dcb0ec261f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>909ee54c-6df4-49c8-b396-7efe7bd767b7</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch Soap Fault</shapeText>                      <ExceptionType>CreateGuardService.CreateGuard.Fault</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7a98ed2d-28f8-4c8f-b24b-559d3648ff97</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Create exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>c0ac0fd9-adbb-4d28-933c-c3b9e26ee89f</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Throw</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>b6588860-02c9-45e5-9a66-3f926ae34fd2</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch System.Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1deddb07-6c07-4c65-8bbc-7f4b7a3bce47</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set variables</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>9d699ace-27d3-4b68-9014-6b10c9c87d09</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Handle Exeption</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4509ad6a-4844-406e-9a8e-5e0009fa2dd8</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>2295f5fb-f5d0-4cef-ab15-566b9c8f8247</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a10c2ce5-7cc8-471f-974f-de38e525dc8c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4ed83b49-881f-4b00-ae16-8f691578dcb3</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>26cdbf3c-cfd8-4784-89af-8da589bcf4f2</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>d8d32391-627f-489f-8bc8-371b7c6c27b7</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Update Node Status</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f89c07df-dda8-41fe-b27d-5688846fe9e1</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>NodeId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9151e1f4-3620-4a3d-9fc0-5586b59806e0</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>StatusId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e15c6d5c-d361-410a-b715-d154d39884fd</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ReasonOfFailure</shapeText>                  
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
<ActionName>'CreateGuard'</ActionName><IsAtomic>0</IsAtomic><Line>507</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>529</Line><Position>22</Position><ShapeID>'57e07653-eae5-4775-b759-fc1835e3e0b3'</ShapeID>
<Messages>
	<MsgInfo><name>CreateGuardNodeMsg</name><part>part</part><schema>MedegaImport.Schemas.CreateGuardNode</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>536</Line><Position>13</Position><ShapeID>'c3415c46-b36f-4739-9876-755d35d1c500'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CreateGuardResponse</name><part>parameters</part><schema>MedegaImport.GuardService_tempuri_org+CreateGuardResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>551</Line><Position>13</Position><ShapeID>'143011b5-f318-456e-82bd-9907be480c48'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>556</Line><Position>21</Position><ShapeID>'cdf80c02-c5f4-46bd-ae04-b61c2da63b6b'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CreateGuardRequest</name><part>parameters</part><schema>MedegaImport.GuardService_tempuri_org+CreateGuard</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CreateGuardNodeMsg</name><part>part</part><schema>MedegaImport.Schemas.CreateGuardNode</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope36'</ActionName><IsAtomic>0</IsAtomic><Line>567</Line><Position>21</Position><ShapeID>'01176e6d-6c53-47fd-9f9b-3292f764eb27'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>572</Line><Position>29</Position><ShapeID>'fa0fcf45-cb55-44f4-954d-925a6574bd55'</ShapeID>
<Messages>
	<MsgInfo><name>CreateGuardRequest</name><part>parameters</part><schema>MedegaImport.GuardService_tempuri_org+CreateGuard</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>574</Line><Position>29</Position><ShapeID>'21a8f133-5452-41c5-b71a-b1dcb0ec261f'</ShapeID>
<Messages>
	<MsgInfo><name>CreateGuardResponse</name><part>parameters</part><schema>MedegaImport.GuardService_tempuri_org+CreateGuardResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>579</Line><Position>29</Position><ShapeID>'909ee54c-6df4-49c8-b396-7efe7bd767b7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>582</Line><Position>44</Position><ShapeID>'7a98ed2d-28f8-4c8f-b24b-559d3648ff97'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>589</Line><Position>33</Position><ShapeID>'c0ac0fd9-adbb-4d28-933c-c3b9e26ee89f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>597</Line><Position>21</Position><ShapeID>'b6588860-02c9-45e5-9a66-3f926ae34fd2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>600</Line><Position>32</Position><ShapeID>'1deddb07-6c07-4c65-8bbc-7f4b7a3bce47'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>611</Line><Position>59</Position><ShapeID>'9d699ace-27d3-4b68-9014-6b10c9c87d09'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>613</Line><Position>63</Position><ShapeID>'d8d32391-627f-489f-8bc8-371b7c6c27b7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='85ddcdba-0bf3-4817-ac3e-8ebbc76655b5' LowerBound='1.1' HigherBound='151.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='fee2308b-7a5d-46df-ac81-b9144d47877a' ParentLink='Module_PortType' LowerBound='16.1' HigherBound='23.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;IGuardService&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IGuardService' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ecdd4e94-42e0-4dff-af0d-025770da91e6' ParentLink='PortType_OperationDeclaration' LowerBound='18.1' HigherBound='22.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;CreateGuard&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='CreateGuard' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='20c505bc-b8d1-42ee-bd79-c8561db83ef5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='20.13' HigherBound='20.51'>
                    <om:Property Name='Ref' Value='MedegaImport.IGuardService_CreateGuard_InputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://tempuri.org/:IGuardService_CreateGuard_InputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IGuardService/CreateGuard&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='90ef13b2-176b-4947-b68e-bb4b24ab323c' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='20.53' HigherBound='20.92'>
                    <om:Property Name='Ref' Value='MedegaImport.IGuardService_CreateGuard_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://tempuri.org/:IGuardService_CreateGuard_OutputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IGuardService/CreateGuardResponse&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='8c7b1dd6-796e-4614-a6b0-e73c29d1cb17' ParentLink='OperationDeclaration_FaultMessageRef' LowerBound='20.94' HigherBound='20.130'>
                    <om:Property Name='Ref' Value='BTS.soap_envelope_1__1.Fault' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Fault' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='09dbfc1a-f9ea-4aee-9938-c4e81ef82fb1' ParentLink='Module_PortType' LowerBound='23.1' HigherBound='30.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLCreateGuardPT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='ed901bb4-58a7-497f-8bf5-7233cfa5c8d1' ParentLink='PortType_OperationDeclaration' LowerBound='25.1' HigherBound='29.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4540f7bc-52a5-45a0-89e0-ec05e5a656b1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='27.13' HigherBound='27.34'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateGuardPollResult' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='289fefaa-9aab-4831-8576-148072b1f540' ParentLink='Module_PortType' LowerBound='30.1' HigherBound='37.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvCreateGuardNodePT' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b5ea3327-8d52-4f93-a2d7-240179c17193' ParentLink='PortType_OperationDeclaration' LowerBound='32.1' HigherBound='36.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuard' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ad71de24-594a-496d-b25f-c51c683cb1a9' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='34.13' HigherBound='34.36'>
                    <om:Property Name='Ref' Value='MedegaImport.Schemas.CreateGuardNode' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GuardNode' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='388baee1-555f-4c6a-93e0-ce436c6b410c' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IGuardService_CreateGuard_InputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IGuardService_CreateGuard_InputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='fa035d5e-d706-480f-813f-3eda4fd2951f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.GuardService_tempuri_org.CreateGuard' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='683d196a-3138-4276-8a8b-8d4a331096ee' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IGuardService_CreateGuard_OutputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IGuardService_CreateGuard_OutputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='00114392-0c65-48b4-8d6e-8a8d9ad70477' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MedegaImport.GuardService_tempuri_org.CreateGuardResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='6ccd07f1-ab19-4bf3-a7e8-1586a8faa6d0' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='CreateGuardPollResult' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='a595e753-2768-43af-906e-56efb94e7858' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLCreateGuardPolling' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fb8753fc-bd02-4a64-9ded-d4bb9c17120c' ParentLink='Module_ServiceDeclaration' LowerBound='37.1' HigherBound='150.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CreateGuard' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='1cf021cd-7045-4347-ad4b-b22512479511' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuardException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e5ad6a99-dd5f-4326-a433-ddde8b86bad2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NodeId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f616023a-5243-4276-95cb-38848008e4bf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StatusId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d0722ba5-7f54-4f93-9145-2675a8c74094' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReasonOfFailure' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a9f617b9-4227-4d04-806d-1c98cee4784f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='InitialValue' Value='&quot;&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='04eabe4f-0392-4c50-886c-3fbd59ff3bb8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='InitialValue' Value='&quot;&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ae28598e-4969-4520-8e50-4b88eb1a2aa1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='670172cf-b9ec-4420-ba21-849f1507800a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d5cbc42b-8fbd-4d71-92a5-b43652ecf596' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c79a983b-5fe6-4687-949d-72081b88d2ab' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='MedegaImport.Schemas.CreateGuardNode' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuardNodeMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='32dcb6e8-cb57-488f-ba64-95d2ef4badd8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='MedegaImport.IGuardService_CreateGuard_InputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuardRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a31c9842-a137-49a0-b5e4-e5e6b328084a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='MedegaImport.IGuardService_CreateGuard_OutputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuardResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='f289a3ba-f840-4e2e-8cb8-5dcd90f486db' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='57e07653-eae5-4775-b759-fc1835e3e0b3' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='66.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvGuardNode' />
                    <om:Property Name='MessageName' Value='CreateGuardNodeMsg' />
                    <om:Property Name='OperationName' Value='CreateGuard' />
                    <om:Property Name='OperationMessageName' Value='GuardNode' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='RcvGuardNode' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='c3415c46-b36f-4739-9876-755d35d1c500' ParentLink='ServiceBody_Statement' LowerBound='66.1' HigherBound='81.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='ec289974-75c6-47c5-981e-554c9d13e2a5' ParentLink='Construct_MessageRef' LowerBound='67.23' HigherBound='67.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='a12e5dde-3853-4d49-aceb-915ea2340d77' ParentLink='Construct_MessageRef' LowerBound='67.32' HigherBound='67.51'>
                        <om:Property Name='Ref' Value='CreateGuardResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='2b3e66b9-fb9c-4d61-abfd-7dcaaa050fb3' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='80.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;CreateGuardResponse.parameters = tempXmlDoc;&#xD;&#xA;returnCode = 0;&#xD;&#xA;ExceptionDescription=&quot;&quot;;&#xD;&#xA;ReasonOfFailure=&quot;&quot;;&#xD;&#xA;tempXmlDoc = CreateGuardNodeMsg;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;MedegaImport&quot;, tempXmlDoc.OuterXml);' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='143011b5-f318-456e-82bd-9907be480c48' ParentLink='ServiceBody_Statement' LowerBound='81.1' HigherBound='148.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='cdf80c02-c5f4-46bd-ae04-b61c2da63b6b' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='97.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Construct Create Guard' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='3d8b0ef7-b740-4d1b-9f10-0aadc7929d5e' ParentLink='Construct_MessageRef' LowerBound='87.31' HigherBound='87.38'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='e877699e-2524-4169-b9a3-e994f20e6477' ParentLink='Construct_MessageRef' LowerBound='87.40' HigherBound='87.58'>
                            <om:Property Name='Ref' Value='CreateGuardRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='772c28da-4598-4786-88ae-40d7b76d91f6' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='91.1'>
                            <om:Property Name='ClassName' Value='MedegaImport.MapCreateGuardRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MapCreateGuard' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='49aaa470-3f98-4442-8395-e98c48e5de21' ParentLink='Transform_InputMessagePartRef' LowerBound='90.105' HigherBound='90.123'>
                                <om:Property Name='MessageRef' Value='CreateGuardNodeMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='225a5bc1-c386-457d-a58a-ade07a60d254' ParentLink='Transform_OutputMessagePartRef' LowerBound='90.36' HigherBound='90.65'>
                                <om:Property Name='MessageRef' Value='CreateGuardRequest' />
                                <om:Property Name='PartRef' Value='parameters' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='84caf992-b4d6-461c-84af-5439522425d9' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='96.1'>
                            <om:Property Name='Expression' Value='Context = CreateGuardRequest.parameters;&#xD;&#xA;&#xD;&#xA;tempXmlDoc = CreateGuardRequest.parameters;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;MedegaImport&quot;,tempXmlDoc.OuterXml);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='Assign context' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='01176e6d-6c53-47fd-9f9b-3292f764eb27' ParentLink='ComplexStatement_Statement' LowerBound='97.1' HigherBound='124.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Try' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Send' OID='fa0fcf45-cb55-44f4-954d-925a6574bd55' ParentLink='ComplexStatement_Statement' LowerBound='102.1' HigherBound='104.1'>
                            <om:Property Name='PortName' Value='CreateGuardService' />
                            <om:Property Name='MessageName' Value='CreateGuardRequest' />
                            <om:Property Name='OperationName' Value='CreateGuard' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send CreateGuard' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='21a8f133-5452-41c5-b71a-b1dcb0ec261f' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='106.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='CreateGuardService' />
                            <om:Property Name='MessageName' Value='CreateGuardResponse' />
                            <om:Property Name='OperationName' Value='CreateGuard' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='909ee54c-6df4-49c8-b396-7efe7bd767b7' ParentLink='Scope_Catch' LowerBound='109.1' HigherBound='122.1'>
                            <om:Property Name='ExceptionName' Value='faultException' />
                            <om:Property Name='ExceptionType' Value='CreateGuardService.CreateGuard.Fault' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Catch Soap Fault' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='7a98ed2d-28f8-4c8f-b24b-559d3648ff97' ParentLink='Catch_Statement' LowerBound='112.1' HigherBound='119.1'>
                                <om:Property Name='Expression' Value='tempXmlDoc = xpath(faultException, &quot;//*[local-name()=&apos;faultcode&apos;]&quot;);&#xD;&#xA;ExceptionDescription = System.Convert.ToString(tempXmlDoc.OuterXml);&#xD;&#xA;tempXmlDoc = xpath(faultException, &quot;//*[local-name()=&apos;faultstring&apos;]&quot;);&#xD;&#xA;InnerExceptionDescription = System.Convert.ToString(tempXmlDoc.OuterXml);&#xD;&#xA;CreateGuardException = new System.Exception(&quot;Error while calling the CreateGuard Webservice\n&quot;,&#xD;&#xA;    new System.Exception(ExceptionDescription + &quot;\n&quot; + InnerExceptionDescription));&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Create exception' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Throw' OID='c0ac0fd9-adbb-4d28-933c-c3b9e26ee89f' ParentLink='Catch_Statement' LowerBound='119.1' HigherBound='121.1'>
                                <om:Property Name='ThrownReference' Value='CreateGuardException' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Throw' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='b6588860-02c9-45e5-9a66-3f926ae34fd2' ParentLink='Scope_Catch' LowerBound='127.1' HigherBound='146.1'>
                        <om:Property Name='ExceptionName' Value='exc' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch System.Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='1deddb07-6c07-4c65-8bbc-7f4b7a3bce47' ParentLink='Catch_Statement' LowerBound='130.1' HigherBound='141.1'>
                            <om:Property Name='Expression' Value='NodeId = CreateGuardNodeMsg.NodeId;&#xD;&#xA;StatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaNodeStatus.InError );&#xD;&#xA;ReasonOfFailure = exc.Message;&#xD;&#xA;&#xD;&#xA;ExceptionDescription = exc.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;&#xD;&#xA;if(exc.InnerException != null)&#xD;&#xA;{&#xD;&#xA;    InnerExceptionDescription = exc.InnerException.Message;&#xD;&#xA;}&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set variables' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='9d699ace-27d3-4b68-9014-6b10c9c87d09' ParentLink='Catch_Statement' LowerBound='141.1' HigherBound='143.1'>
                            <om:Property Name='Identifier' Value='HandleExeption' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Handle Exeption' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='4509ad6a-4844-406e-9a8e-5e0009fa2dd8' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='returnCode' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='2295f5fb-f5d0-4cef-ab15-566b9c8f8247' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='a10c2ce5-7cc8-471f-974f-de38e525dc8c' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='4ed83b49-881f-4b00-ae16-8f691578dcb3' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='26cdbf3c-cfd8-4784-89af-8da589bcf4f2' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Call' OID='d8d32391-627f-489f-8bc8-371b7c6c27b7' ParentLink='Catch_Statement' LowerBound='143.1' HigherBound='145.1'>
                            <om:Property Name='Identifier' Value='CallUpdateNodeStatus' />
                            <om:Property Name='Invokee' Value='MedegaImport.subUpdateNodeStatus' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Update Node Status' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='f89c07df-dda8-41fe-b27d-5688846fe9e1' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='NodeId' />
                                <om:Property Name='Type' Value='System.Int64' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9151e1f4-3620-4a3d-9fc0-5586b59806e0' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='StatusId' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='e15c6d5c-d361-410a-b715-d154d39884fd' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ReasonOfFailure' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='77d77858-4438-401c-81a3-b18e7d99055d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='0' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.RcvCreateGuardNodePT' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvGuardNode' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8dee0ba1-4dd3-43e3-881a-a889e762655b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5e24945a-1270-44bc-b7da-dfc62bf7b73e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='45.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='46' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='MedegaImport.IGuardService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateGuardService' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='4f32c9bd-e8ce-4966-9389-c1a6af75193e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CreateGuard_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CreateGuard_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CreateGuard")
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
                CreateGuard __svc__ = (CreateGuard)_service;
                __CreateGuard_root_0 __ctx0__ = (__CreateGuard_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CreateGuardService != null)
                {
                    __svc__.CreateGuardService.Close(this, null);
                    __svc__.CreateGuardService = null;
                }
                if (__svc__.RcvGuardNode != null)
                {
                    __svc__.RcvGuardNode.Close(this, null);
                    __svc__.RcvGuardNode = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __CreateGuard_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CreateGuard_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CreateGuard")
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
                CreateGuard __svc__ = (CreateGuard)_service;
                __CreateGuard_1 __ctx1__ = (__CreateGuard_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__CreateGuardResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardResponse);
                    __ctx1__.__CreateGuardResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__CreateGuardException = null;
                if (__ctx1__ != null && __ctx1__.__CreateGuardNodeMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardNodeMsg);
                    __ctx1__.__CreateGuardNodeMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ReasonOfFailure = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CreateGuardNodeMsg")]
            public __messagetype_MedegaImport_Schemas_CreateGuardNode __CreateGuardNodeMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CreateGuardRequest")]
            internal IGuardService_CreateGuard_InputMessage __CreateGuardRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CreateGuardResponse")]
            internal IGuardService_CreateGuard_OutputMessage __CreateGuardResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CreateGuardException")]
            internal System.Exception __CreateGuardException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NodeId")]
            internal System.Int64 __NodeId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusId")]
            internal System.Int32 __StatusId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ReasonOfFailure")]
            internal System.String __ReasonOfFailure;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
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
                CreateGuard __svc__ = (CreateGuard)_service;
                __CreateGuard_1 __ctx1__ = (__CreateGuard_1)(__svc__._stateMgrs[1]);
                ____scope35_2 __ctx2__ = (____scope35_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__exc_0 = null;
                if (__ctx1__ != null && __ctx1__.__CreateGuardRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardRequest);
                    __ctx1__.__CreateGuardRequest = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __exc_0
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
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if (__fault__ != null && __fault__.Match("CreateGuardService", 0, 0))
                    {
                        __messagetype_BTS_soap_envelope_1__1_Fault __msg__ = new __messagetype_BTS_soap_envelope_1__1_Fault("faultException", this);
                        RefMessage(__msg__);
                        IGuardService.ReceiveFault(__fault__.Env, __msg__, this);
                        __exv__ = __msg__;
                        __seg__ = _service._segments[4];
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
                CreateGuard __svc__ = (CreateGuard)_service;
                __CreateGuard_root_0 __ctx0__ = (__CreateGuard_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal __messagetype_BTS_soap_envelope_1__1_Fault __faultException_0
            {
                get { return (__messagetype_BTS_soap_envelope_1__1_Fault)__exv__; }
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
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvGuardNode")]
        internal RcvCreateGuardNodePT RcvGuardNode;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CreateGuardService")]
        internal IGuardService CreateGuardService;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvCreateGuardNodePT.CreateGuard},
                                               typeof(CreateGuard).GetField("RcvGuardNode", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CreateGuard), "RcvGuardNode"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {IGuardService.CreateGuard},
                                               typeof(CreateGuard).GetField("CreateGuardService", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CreateGuard), "CreateGuardService"),
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
                    typeof(MedegaImport.HandleException),
                    typeof(MedegaImport.subUpdateNodeStatus)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "57e07653-eae5-4775-b759-fc1835e3e0b3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "57e07653-eae5-4775-b759-fc1835e3e0b3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "c3415c46-b36f-4739-9876-755d35d1c500", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "c3415c46-b36f-4739-9876-755d35d1c500", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "143011b5-f318-456e-82bd-9907be480c48", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "cdf80c02-c5f4-46bd-ae04-b61c2da63b6b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "cdf80c02-c5f4-46bd-ae04-b61c2da63b6b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "01176e6d-6c53-47fd-9f9b-3292f764eb27", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "fa0fcf45-cb55-44f4-954d-925a6574bd55", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "fa0fcf45-cb55-44f4-954d-925a6574bd55", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "21a8f133-5452-41c5-b71a-b1dcb0ec261f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "21a8f133-5452-41c5-b71a-b1dcb0ec261f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "909ee54c-6df4-49c8-b396-7efe7bd767b7", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "7a98ed2d-28f8-4c8f-b24b-559d3648ff97", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "7a98ed2d-28f8-4c8f-b24b-559d3648ff97", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "00000000-0000-0000-0000-000000000000", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "c0ac0fd9-adbb-4d28-933c-c3b9e26ee89f", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "909ee54c-6df4-49c8-b396-7efe7bd767b7", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "01176e6d-6c53-47fd-9f9b-3292f764eb27", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "b6588860-02c9-45e5-9a66-3f926ae34fd2", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "1deddb07-6c07-4c65-8bbc-7f4b7a3bce47", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "1deddb07-6c07-4c65-8bbc-7f4b7a3bce47", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "9d699ace-27d3-4b68-9014-6b10c9c87d09", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "9d699ace-27d3-4b68-9014-6b10c9c87d09", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "d8d32391-627f-489f-8bc8-371b7c6c27b7", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "d8d32391-627f-489f-8bc8-371b7c6c27b7", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "b6588860-02c9-45e5-9a66-3f926ae34fd2", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "143011b5-f318-456e-82bd-9907be480c48", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,4,4,5,6,6,6,34,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 8,8,8,9,10,10,10,23,23,23,23,};
        public static int[] __progressLocation3 = new int[] { 12,12,12,12,13,14,14,15,15,15,15,};
        public static int[] __progressLocation4 = new int[] { 16,16,17,17,18,18,18,18,18,21,21,22,22,};
        public static int[] __progressLocation5 = new int[] { 24,24,25,25,26,26,26,26,26,26,26,26,26,29,29,30,31,31,32,33,33,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            __CreateGuard_root_0 __ctx0__ = (__CreateGuard_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RcvGuardNode = new RcvCreateGuardNodePT(0, this);
                CreateGuardService = new IGuardService(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvGuardNode, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CreateGuard_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __CreateGuard_root_0 __ctx0__ = (__CreateGuard_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__CreateGuardException = default(System.Exception);
                __ctx1__.__NodeId = default(System.Int64);
                __ctx1__.__StatusId = default(System.Int32);
                __ctx1__.__ReasonOfFailure = default(System.String);
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__returnCode = default(System.Int32);
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
                if (!RcvGuardNode.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__CreateGuardNodeMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardNodeMsg);
                __ctx1__.__CreateGuardNodeMsg = new __messagetype_MedegaImport_Schemas_CreateGuardNode("CreateGuardNodeMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CreateGuardNodeMsg);
                RcvGuardNode.ReceiveMessage(0, __msgEnv__, __ctx1__.__CreateGuardNodeMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvGuardNode != null)
                {
                    RcvGuardNode.Close(__ctx1__, __seg__);
                    RcvGuardNode = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CreateGuardNodeMsg);
                    __edata.PortName = @"RcvGuardNode";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__CreateGuardException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ReasonOfFailure = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    IGuardService_CreateGuard_OutputMessage __CreateGuardResponse = new IGuardService_CreateGuard_OutputMessage("CreateGuardResponse", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __CreateGuardResponse.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ctx1__.__returnCode = 0;
                    __ctx1__.__ExceptionDescription = "";
                    __ctx1__.__ReasonOfFailure = "";
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = __ctx1__.__CreateGuardNodeMsg.part.TypedValue;

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__CreateGuardResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CreateGuardResponse);
                    __ctx1__.__CreateGuardResponse = __CreateGuardResponse;
                    __ctx1__.RefMessage(__ctx1__.__CreateGuardResponse);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__CreateGuardResponse.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__CreateGuardResponse);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx2__ = new ____scope35_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ReasonOfFailure = null;
                if (__ctx1__ != null)
                    __ctx1__.__CreateGuardException = null;
                if (__ctx1__ != null && __ctx1__.__CreateGuardResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardResponse);
                    __ctx1__.__CreateGuardResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__CreateGuardNodeMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardNodeMsg);
                    __ctx1__.__CreateGuardNodeMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (CreateGuardService != null)
                {
                    CreateGuardService.Close(__ctx1__, __seg__);
                    CreateGuardService = null;
                }
                Tracker.FireEvent(__eventLocations[34],__eventData[10],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
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
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    IGuardService_CreateGuard_InputMessage __CreateGuardRequest = new IGuardService_CreateGuard_InputMessage("CreateGuardRequest", __ctx1__);

                    ApplyTransform(typeof(MedegaImport.MapCreateGuardRequest), new object[] {__CreateGuardRequest.parameters}, new object[] {__ctx1__.__CreateGuardNodeMsg.part});
                    __Context.part.CopyFrom(__CreateGuardRequest.parameters);
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = __CreateGuardRequest.parameters.TypedValue;

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__CreateGuardRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CreateGuardRequest);
                    __ctx1__.__CreateGuardRequest = __CreateGuardRequest;
                    __ctx1__.RefMessage(__ctx1__.__CreateGuardRequest);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(true);
                __ctx1__.__CreateGuardRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__CreateGuardRequest);
                    __edata.Messages.Add(__ctx1__.__CreateGuardNodeMsg);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx3__ = new ____scope36_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__CreateGuardRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardRequest);
                    __ctx1__.__CreateGuardRequest = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[10],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 10;
            case 10:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];
            __CreateGuard_root_0 __ctx0__ = (__CreateGuard_root_0)_stateMgrs[0];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CreateGuardService.SendMessage(0, __ctx1__.__CreateGuardRequest, null, null, out __ctx0__.__subWrapper1, __ctx3__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CreateGuardRequest);
                    __edata.PortName = @"CreateGuardService";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[1],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!CreateGuardService.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__CreateGuardResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CreateGuardResponse);
                __ctx1__.__CreateGuardResponse = new IGuardService_CreateGuard_OutputMessage("CreateGuardResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CreateGuardResponse);
                CreateGuardService.ReceiveMessage(0, __msgEnv__, __ctx1__.__CreateGuardResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[3], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CreateGuardResponse);
                    __edata.PortName = @"CreateGuardService";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 10;
            case 10:
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
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            ____scope36_3 __ctx3__ = (____scope36_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[16],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = (System.Xml.XmlDocument)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx3__.__faultException_0.part, "//*[local-name()='faultcode']", typeof(System.Xml.XmlDocument));
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[7],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__ExceptionDescription = System.Convert.ToString(__ctx1__.__tempXmlDoc.UnderlyingXmlDocument.OuterXml);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = (System.Xml.XmlDocument)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx3__.__faultException_0.part, "//*[local-name()='faultstring']", typeof(System.Xml.XmlDocument));
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__InnerExceptionDescription = System.Convert.ToString(__ctx1__.__tempXmlDoc.UnderlyingXmlDocument.OuterXml);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__CreateGuardException = new System.Exception("Error while calling the CreateGuard Webservice\n", new System.Exception(__ctx1__.__ExceptionDescription + "\n" + __ctx1__.__InnerExceptionDescription));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                throw __ctx1__.__CreateGuardException;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx3__.__exv__ = null;
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __CreateGuard_1 __ctx1__ = (__CreateGuard_1)_stateMgrs[1];
            ____scope35_2 __ctx2__ = (____scope35_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[24],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__NodeId = (System.Int64)__ctx1__.__CreateGuardNodeMsg.part.GetDistinguishedField("NodeId");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__StatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaNodeStatus.InError);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ReasonOfFailure = __ctx2__.__exc_0.Message;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ExceptionDescription = __ctx2__.__exc_0.Message;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = __ctx2__.__exc_0.InnerException != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 12;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__InnerExceptionDescription = __ctx2__.__exc_0.InnerException.Message;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__exc_0 = null;
                Tracker.FireEvent(__eventLocations[28],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[29],new object[] {__ctx1__.__returnCode, __ctx1__.__Context, __ctx1__.__Context, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                    __ctx1__.__returnCode = (System.Int32)args[0];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__Context);
                    Tracker.FireEvent(__eventLocations[30],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subUpdateNodeStatus(5, InstanceId, this);
                    _stateMgrs[5] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[31],new object[] {__ctx1__.__NodeId, __ctx1__.__StatusId, __ctx1__.__ReasonOfFailure});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[5]).Args;
                }
                Tracker.FireEvent(__eventLocations[32],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{C601FABA-A6D4-451A-93E8-B26C87BEEDDA}"))
        };

    }
    //#line 229 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\HandleException.odx"
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
<ActionName>'HandleException'</ActionName><IsAtomic>0</IsAtomic><Line>229</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>239</Line><Position>51</Position><ShapeID>'72a4140b-919a-4105-a6b9-145bb198ac83'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>241</Line><Position>13</Position><ShapeID>'5500dde3-20d4-43f3-bb45-a965a593a7d1'</ShapeID>
<Messages>
	<MsgInfo><name>MailError</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailError</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>249</Line><Position>13</Position><ShapeID>'75f3e358-6b7a-4321-9ebe-7ae237c7bfc5'</ShapeID>
<Messages>
	<MsgInfo><name>MailError</name><part>Context</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MailError</name><part>ErrMsg</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>251</Line><Position>13</Position><ShapeID>'06a1de23-c34a-43ec-bbb3-0f5e3f62882c'</ShapeID>
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
    <om:Element Type='Module' OID='404be20e-9c29-477b-9ba6-3ea7761c0b81' LowerBound='1.1' HigherBound='51.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='cd3f17ca-29f8-4921-9fe0-361bb659d05c' ParentLink='Module_PortType' LowerBound='10.1' HigherBound='17.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrContextType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5d66122d-1ee9-4081-a72b-c1680b89f5f6' ParentLink='PortType_OperationDeclaration' LowerBound='12.1' HigherBound='16.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='765d8d78-922b-4f94-a5d5-4c34e6f56883' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='14.13' HigherBound='14.26'>
                    <om:Property Name='Ref' Value='MedegaImport.ExceptionType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='b1f59e34-3574-4e44-b533-187577c7c52e' ParentLink='Module_PortType' LowerBound='17.1' HigherBound='24.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrMsgType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='578ab68b-7274-42ca-8ee5-7bca42879a70' ParentLink='PortType_OperationDeclaration' LowerBound='19.1' HigherBound='23.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='c7d0cfc8-b0dd-4581-bd02-54d542f16682' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='21.13' HigherBound='21.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1eacb16b-62f9-495d-a40d-8db9afc54f87' ParentLink='Module_ServiceDeclaration' LowerBound='24.1' HigherBound='50.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='HandleException' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='48316d0e-55dd-41e4-bc37-829c64b5e51e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='Type' Value='MedegaImport.ExceptionType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailError' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='41e9d1bf-b0b5-4dc3-b278-5fed999673f7' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='1d34d6a9-4e62-4300-96ab-2cd725044d8b' ParentLink='ServiceBody_Declaration' LowerBound='32.15' HigherBound='32.41'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Ref' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='errorCode' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='8b9e317d-8f2e-4044-9caa-b21e8cd8027a' ParentLink='ServiceBody_Declaration' LowerBound='32.43' HigherBound='32.81'>
                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Context' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='82dc527c-c001-4767-a397-c47ebda69dfa' ParentLink='ServiceBody_Declaration' LowerBound='32.83' HigherBound='32.120'>
                    <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ErrMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='b7ee5052-a137-4d2f-a005-2955f69bb3e4' ParentLink='ServiceBody_Declaration' LowerBound='32.122' HigherBound='32.156'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ExceptionDescription' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='1d34d833-dc03-4b86-92cb-a180eea13cdf' ParentLink='ServiceBody_Declaration' LowerBound='32.158' HigherBound='32.197'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='False' />
                    <om:Property Name='Name' Value='InnerExceptionDescription' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='72a4140b-919a-4105-a6b9-145bb198ac83' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='36.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;RIZIV-INAMI.MedegaImport&quot;, System.String.Format(&quot;An error occured! Error code returned : {0}\r\nDescription: {1}\r\nInnerException: {2}&quot; ,errorCode, ExceptionDescription, InnerExceptionDescription), System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='5500dde3-20d4-43f3-bb45-a965a593a7d1' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='44.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Assign Mail message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='da3f2308-d68f-402e-9fd2-1655c572fc52' ParentLink='Construct_MessageRef' LowerBound='37.23' HigherBound='37.32'>
                        <om:Property Name='Ref' Value='MailError' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='a9e0f9da-7909-4012-a4ec-d240bbfa20af' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='43.1'>
                        <om:Property Name='Expression' Value='MailError.Context = Context;&#xD;&#xA;MailError.ErrMsg = ErrMsg;&#xD;&#xA;MailError.ErrText = &quot;Error: &quot; + ExceptionDescription + &quot;\n&quot; + InnerExceptionDescription;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Assign Mail message' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='75f3e358-6b7a-4321-9ebe-7ae237c7bfc5' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='46.1'>
                    <om:Property Name='PortName' Value='SendErrContext' />
                    <om:Property Name='MessageName' Value='MailError' />
                    <om:Property Name='OperationName' Value='Send' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Context' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='06a1de23-c34a-43ec-bbb3-0f5e3f62882c' ParentLink='ServiceBody_Statement' LowerBound='46.1' HigherBound='48.1'>
                    <om:Property Name='PortName' Value='SendErrMsg' />
                    <om:Property Name='MessageName' Value='ErrMsg' />
                    <om:Property Name='OperationName' Value='Send' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Exception' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c55ed462-66b4-46ee-a975-52f7cbc7664a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='27.1' HigherBound='29.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='7e74c7a8-2b2d-4a1f-9096-79f83794c76b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='27.1' HigherBound='28.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0ee18aeb-622d-496c-a22d-72b9bd5369a1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='29.1' HigherBound='31.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='47e466ad-0fe5-4d20-b7a5-f430bc25365f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='29.1' HigherBound='30.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='fe2063b2-a3a2-4b3f-b668-1c3283513615' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='10.1'>
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
            <om:Element Type='PartDeclaration' OID='bc9c4ff0-aeed-4fa9-8b41-283a9ff4ae23' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='8.1' HigherBound='9.1'>
                <om:Property Name='ClassName' Value='System.String' />
                <om:Property Name='IsBodyPart' Value='False' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrText' />
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
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__MailError != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MailError);
                    __ctx1__.__MailError = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
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
            __HandleException_1 __ctx1__ = (__HandleException_1)_stateMgrs[1];
            __HandleException_root_0 __ctx0__ = (__HandleException_root_0)_stateMgrs[0];

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
            __HandleException_1 __ctx1__ = (__HandleException_1)_stateMgrs[1];
            __HandleException_root_0 __ctx0__ = (__HandleException_root_0)_stateMgrs[0];

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
                System.Diagnostics.EventLog.WriteEntry("RIZIV-INAMI.MedegaImport", System.String.Format("An error occured! Error code returned : {0}\r\nDescription: {1}\r\nInnerException: {2}", __ctx1__.__errorCode, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription), System.Diagnostics.EventLogEntryType.Error);
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
                    __MailError.ErrText.LoadFrom("Error: " + __ctx1__.__ExceptionDescription + "\n" + __ctx1__.__InnerExceptionDescription);
                    if (__ctx1__ != null)
                        __ctx1__.__InnerExceptionDescription = null;
                    if (__ctx1__ != null)
                        __ctx1__.__ExceptionDescription = null;

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
    //#line 275 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\ImportGuards.odx"
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
            typeof(MedegaImport.subImportGuardRecord),
            typeof(MedegaImport.subUpdateFileStatus)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
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
                "MedegaImport.subImportGuardRecord",
                "MedegaImport.subUpdateFileStatus"
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
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>56cd6bf1-c6a0-4c6c-bb72-1bdc0dff05f4</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1009bd4e-f55d-466f-93e3-ef93f6ab35d8</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e67d3649-1afd-4187-85a8-f0b7f781e154</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>GuardsFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d1c49b6d-bb3b-494c-85ac-e54a08f2452d</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SQLCreateMedegaFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Verify Status</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>fa041359-cc74-4aa4-988b-81e93d753551</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>New</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>7fcfe072-fbbb-4b34-a738-6f41fa0d2057</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ImportRecords</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8ac20ae3-8a15-4fcf-b27c-7d1657e22624</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>GuardsFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>976b7904-4f9a-4ff4-aab7-74d86e1fb669</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SQLCreateMedegaFileResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b6f94de9-6897-40a1-a881-6851a43eec7f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>f41c35f1-1f66-4dce-afca-7092097af540</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a902e844-d594-4875-b11a-460e4b4d0b9c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status Error</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>ce0e031d-ba91-4543-b9a9-4a7f1dd962b7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1a06f1e4-45be-4588-93b7-cfb7dd97ca95</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>d2997bd9-eef1-4869-bc93-3e4881189ad8</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>NewFileStatusID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
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
<ActionName>'ImportGuards'</ActionName><IsAtomic>0</IsAtomic><Line>275</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>287</Line><Position>22</Position><ShapeID>'b1eba16b-ce54-465d-89ea-0bdcccbbf213'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>289</Line><Position>45</Position><ShapeID>'93d77076-9f32-4db9-9a81-1271a4f685f5'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>291</Line><Position>13</Position><ShapeID>'de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>295</Line><Position>56</Position><ShapeID>'7fcfe072-fbbb-4b34-a738-6f41fa0d2057'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>300</Line><Position>33</Position><ShapeID>'a902e844-d594-4875-b11a-460e4b4d0b9c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>302</Line><Position>55</Position><ShapeID>'ce0e031d-ba91-4543-b9a9-4a7f1dd962b7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>304</Line><Position>17</Position><ShapeID>'296dd146-6079-4b1f-84d6-b2fdfe61ffab'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='8960eb66-2104-4284-aba7-f9e9c44dafae' LowerBound='1.1' HigherBound='57.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='78c91ce6-8b84-40fb-8bd0-d1ce15e04c36' ParentLink='Module_PortType' LowerBound='8.1' HigherBound='15.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLMedegaFileDonePollingPT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='c31e4084-7113-4a6f-af12-4de7235289b8' ParentLink='PortType_OperationDeclaration' LowerBound='10.1' HigherBound='14.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3834d0f2-5165-4715-9fd8-aac14aa828fb' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='12.13' HigherBound='12.34'>
                    <om:Property Name='Ref' Value='MedegaImport.MedegaFileDonePolling' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8c944f78-7ce4-4aed-9df7-a941d5e62ee7' ParentLink='Module_PortType' LowerBound='15.1' HigherBound='22.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveGuardsType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dd41b2df-5793-41f4-b8cd-f8531cbf2844' ParentLink='PortType_OperationDeclaration' LowerBound='17.1' HigherBound='21.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Import' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ab6f55db-b05f-4db3-bd94-7957c9278912' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='19.13' HigherBound='19.52'>
                    <om:Property Name='Ref' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='bc8c92f4-7a54-413c-a3e5-d80cfa9508b6' ParentLink='Module_ServiceDeclaration' LowerBound='22.1' HigherBound='56.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ImportGuards' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='4549667d-1542-4f73-bc9b-62d2da59c0fb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileStatusID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='df921866-f2da-4d3e-adee-6d3f905a36f9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='81bd8524-e237-46c7-a2d7-b374fb1a4225' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewFileStatusID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='576b3c40-e1c6-471e-a9a9-0369a66f3f4d' ParentLink='ServiceDeclaration_Transaction' LowerBound='23.21' HigherBound='23.58'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='285fc959-77d2-4b5a-abe9-f52e2f4dc6e1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GuardsFile' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6121a6fd-8e2f-4443-ad7f-26945ec5c873' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLCreateMedegaFileResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='fdae6ed7-b4c2-429b-9844-6ff895ed1a85' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b1eba16b-ce54-465d-89ea-0bdcccbbf213' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveGuards' />
                    <om:Property Name='MessageName' Value='GuardsFile' />
                    <om:Property Name='OperationName' Value='Import' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Guards' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Call' OID='93d77076-9f32-4db9-9a81-1271a4f685f5' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='38.1'>
                    <om:Property Name='Identifier' Value='ImportFile' />
                    <om:Property Name='Invokee' Value='MedegaImport.subImportFile' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportFile' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Parameter' OID='56cd6bf1-c6a0-4c6c-bb72-1bdc0dff05f4' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='FileID' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='1009bd4e-f55d-466f-93e3-ef93f6ab35d8' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='FileStatusID' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='e67d3649-1afd-4187-85a8-f0b7f781e154' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='GuardsFile' />
                        <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='d1c49b6d-bb3b-494c-85ac-e54a08f2452d' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='SQLCreateMedegaFileResponse' />
                        <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileResponse' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='54.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Verify Status' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='fa041359-cc74-4aa4-988b-81e93d753551' ParentLink='ReallyComplexStatement_Branch' LowerBound='39.13' HigherBound='45.1'>
                        <om:Property Name='Expression' Value='FileStatusID == System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.ImportStarted) &amp;&amp;&#xD;&#xA;FileStatusID != -99' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='New' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Call' OID='7fcfe072-fbbb-4b34-a738-6f41fa0d2057' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='44.1'>
                            <om:Property Name='Identifier' Value='ImportRecords' />
                            <om:Property Name='Invokee' Value='MedegaImport.subImportGuardRecord' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ImportRecords' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='8ac20ae3-8a15-4fcf-b27c-7d1657e22624' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='GuardsFile' />
                                <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='976b7904-4f9a-4ff4-aab7-74d86e1fb669' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SQLCreateMedegaFileResponse' />
                                <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileResponse' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b6f94de9-6897-40a1-a881-6851a43eec7f' ParentLink='InvokeStatement_Parameter'>
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
                        <om:Element Type='VariableAssignment' OID='a902e844-d594-4875-b11a-460e4b4d0b9c' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                            <om:Property Name='Expression' Value='NewFileStatusID = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.InError );&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Status Error' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='ce0e031d-ba91-4543-b9a9-4a7f1dd962b7' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='51.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_1' />
                            <om:Property Name='Invokee' Value='MedegaImport.subUpdateFileStatus' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CallOrchestration_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='1a06f1e4-45be-4588-93b7-cfb7dd97ca95' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='FileID' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='d2997bd9-eef1-4869-bc93-3e4881189ad8' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='NewFileStatusID' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Terminate' OID='296dd146-6079-4b1f-84d6-b2fdfe61ffab' ParentLink='ComplexStatement_Statement' LowerBound='51.1' HigherBound='53.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;The file status after ImportFile is not correct to continue&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8aca5fc8-dabf-4acf-b143-aca6efa34ddc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='25.1' HigherBound='27.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='d8090902-4f8e-464a-ac5b-de6d5f0d3fe6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='25.1' HigherBound='26.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='86156780-35c2-4ec9-8e64-3377f5792392' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='MedegaFileDonePolling' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='ca705ded-f5f1-4bbb-a37f-a25617c715e4' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.Schemas.MedegaFileStatus' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
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
        public class __ImportGuards_1 : Microsoft.XLANGs.Core.LongRunningTransaction
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

                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                    __ctx1__.__SQLCreateMedegaFileResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("GuardsFile")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __GuardsFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLCreateMedegaFileResponse")]
            internal CreateMedegaFileResponse __SQLCreateMedegaFileResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileStatusID")]
            internal System.Int32 __FileStatusID;
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
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "93d77076-9f32-4db9-9a81-1271a4f685f5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "93d77076-9f32-4db9-9a81-1271a4f685f5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7fcfe072-fbbb-4b34-a738-6f41fa0d2057", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "7fcfe072-fbbb-4b34-a738-6f41fa0d2057", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "a902e844-d594-4875-b11a-460e4b4d0b9c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "a902e844-d594-4875-b11a-460e4b4d0b9c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "ce0e031d-ba91-4543-b9a9-4a7f1dd962b7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ce0e031d-ba91-4543-b9a9-4a7f1dd962b7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "296dd146-6079-4b1f-84d6-b2fdfe61ffab", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "de53e2c1-cfa0-47f4-98dc-7dc08e8b9eb4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "00000000-0000-0000-0000-000000000000", 1, false)
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

        public static int[] __progressLocation0 = new int[] { 0,0,0,14,14,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,6,6,7,5,8,8,9,10,10,11,12,12,13,14,14,14,14,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ImportGuards_root_0 __ctx0__ = (__ImportGuards_root_0)_stateMgrs[0];
            __ImportGuards_1 __ctx1__ = (__ImportGuards_1)_stateMgrs[1];

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
            __ImportGuards_root_0 __ctx0__ = (__ImportGuards_root_0)_stateMgrs[0];
            __ImportGuards_1 __ctx1__ = (__ImportGuards_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileStatusID = default(System.Int32);
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
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subImportFile(2, InstanceId, this);
                    _stateMgrs[2] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[3],new object[] {null, null, __ctx1__.__GuardsFile, new Microsoft.XLANGs.Core.MessageTuple((Microsoft.XLANGs.Core.Context)_stateMgrs[1], null)});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[2]).Args;
                    __ctx1__.__FileID = (System.Int32)args[0];
                    __ctx1__.__FileStatusID = (System.Int32)args[1];
                    __ctx1__.__SQLCreateMedegaFileResponse = (CreateMedegaFileResponse)((Microsoft.XLANGs.Core.MessageTuple)(args[3])).message;
                    __ctx1__.__SQLCreateMedegaFileResponse.MessageName = "SQLCreateMedegaFileResponse";
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileResponse);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __condition__ = __ctx1__.__FileStatusID == System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.ImportStarted) && __ctx1__.__FileStatusID != -99;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 14;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subImportGuardRecord(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[6],new object[] {__ctx1__.__GuardsFile, __ctx1__.__SQLCreateMedegaFileResponse, __ctx1__.__FileID});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileResponse);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__NewFileStatusID = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.InError);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subUpdateFileStatus(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[10],new object[] {__ctx1__.__FileID, __ctx1__.__NewFileStatusID});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                }
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                RequestTerminate(__ctx1__,"The file status after ImportFile is not correct to continue");
                __seg__.SegmentDone();
                break;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaFileResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                    __ctx1__.__SQLCreateMedegaFileResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 26;
            case 26:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 448 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\subImportFile.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.SQLCreateMedegaFilePT)
        },
        new System.String[] {
            "CreateMedegaFile"
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
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] out MedegaImport.CreateMedegaFileResponse SQLCreateMedegaFileResponse)
        {
            FileID = default(System.Int32);
            FileStatusID = default(System.Int32);
            SQLCreateMedegaFileResponse = default(MedegaImport.CreateMedegaFileResponse);
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
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>cdbc502a-542e-420c-8ca2-9a1a7fb1a98d</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SQLCreateMedegaFileResponse</shapeText>                  
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
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e7c14941-983f-409c-9d11-dd2f04d8fc99</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
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
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>246572e6-6bbf-4603-8a4a-b018cf86bd9e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e8a9ede3-4150-494b-9696-a3b19b4b6d0a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4ff0c0fb-f96d-41d3-8ec4-5caa870237c0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>cd666881-215a-406b-a8a0-08c7d3951323</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>cf213b83-cf5c-4018-929b-35177a02dc19</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7734464f-462e-4eb8-bf5b-558000752492</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send ImportFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b4a94870-d466-454d-abd6-2c38d63d4509</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive DB2 Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
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
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>14bff5db-7dd7-41b6-aa5e-fc1af0ffff76</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>808fab83-206e-4a0c-b766-412f9be4f051</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>06a58f9e-e289-4013-8f0d-d98cd2780b95</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c1c1e7dc-40a6-4509-9e43-c730375eab48</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>376f0513-4e13-4e75-ae8d-240bfe0f5f48</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
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
<ActionName>'subImportFile'</ActionName><IsAtomic>0</IsAtomic><Line>448</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>GuardsFile</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>472</Line><Position>13</Position><ShapeID>'53e7f6e2-c5d1-4696-89e3-119e2e28d223'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>483</Line><Position>20</Position><ShapeID>'0653e2f2-df5d-4298-8480-722b7f32c7a6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope37'</ActionName><IsAtomic>0</IsAtomic><Line>487</Line><Position>13</Position><ShapeID>'a4b0227b-7516-432b-a3c8-c63cb123a2fe'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>494</Line><Position>21</Position><ShapeID>'5e695e8c-5e2d-4f29-8763-5e4a8200d56e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>507</Line><Position>21</Position><ShapeID>'cd368a80-c25a-49c6-aba4-e107d82c06c2'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaFileRequest</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope38'</ActionName><IsAtomic>0</IsAtomic><Line>521</Line><Position>21</Position><ShapeID>'cf213b83-cf5c-4018-929b-35177a02dc19'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>526</Line><Position>29</Position><ShapeID>'7734464f-462e-4eb8-bf5b-558000752492'</ShapeID>
<Messages>
	<MsgInfo><name>SQLCreateMedegaFileRequest</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>528</Line><Position>29</Position><ShapeID>'b4a94870-d466-454d-abd6-2c38d63d4509'</ShapeID>
<Messages>
	<MsgInfo><name>SQLCreateMedegaFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>530</Line><Position>41</Position><ShapeID>'7b5bb6f9-4ed3-4753-8d09-8b96052c949a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>534</Line><Position>36</Position><ShapeID>'d78c787d-76b8-4598-9f15-7e8cfab99534'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>539</Line><Position>29</Position><ShapeID>'56792c53-3155-4f54-b974-4392b5cadb98'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>542</Line><Position>33</Position><ShapeID>'c6b8fda0-17ea-4f71-8911-9650121a5744'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>548</Line><Position>33</Position><ShapeID>'a5252301-f00a-4355-bba9-370566c2eab7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>556</Line><Position>21</Position><ShapeID>'70822a75-fe3f-4390-864a-58f6273d4cdc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>559</Line><Position>46</Position><ShapeID>'5efb35b0-e793-416b-959a-99c26916c919'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>563</Line><Position>59</Position><ShapeID>'e2059a03-6b78-4471-80ad-6888053eb662'</ShapeID>
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
    <om:Element Type='Module' OID='10a5b02c-e77c-4357-8f72-edd3694334cb' LowerBound='1.1' HigherBound='149.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='1dc0420b-5d76-4ca6-a672-eb286deca397' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLCreateMedegaFilePT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='e90fe8ad-4f10-44ad-8938-8f673a9607fb' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='866ece5f-2b5e-47f8-baa8-8a5458cbb279' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.38' HigherBound='16.62'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateMedegaFileResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='3e184d63-f29e-4f3a-92fc-eebb3a1c6fa8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.36'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateMedegaFileRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='22845039-cb60-43e3-8776-2674cd88e3e2' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ImportGuardLogType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b4bb69a1-04f8-4a58-b79a-f90e0d437403' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ba6f54d7-e32c-4451-83c0-201291831a79' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.37'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateMedegaFileResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5834d121-39f4-4f6d-9d52-5cfffa8c777e' ParentLink='Module_ServiceDeclaration' LowerBound='26.1' HigherBound='148.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subImportFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='723e05c9-1f0e-4948-9773-19d27f383dd4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3c7f1c00-ca9e-4ad3-9d52-4d7576a86280' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3f82ccda-79c8-44c5-b6ad-3664d276e9f7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportFileException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='17f0cbc3-8b02-46a3-9bfd-3f2fa51b4f99' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='36e9b88c-eab1-4675-aae8-ec4621709103' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='receivedFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a44c60dd-f84a-4a22-8788-3d004a45815a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmpString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6fbdf073-6c8e-4f6a-aa9c-7e95de76c3a1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='29d7020a-2fb7-416a-a83b-fc03e1aea2c1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='16376ad5-2184-4d27-8525-8ba570e04c5d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fa21f8b2-78c7-464c-bc82-d3ed62dd4be1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLCreateMedegaFileRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e4824caf-d6f5-4aa4-9de8-52ee0c079fb6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='98226dca-319a-4163-a226-8fd3679b1da0' ParentLink='ServiceBody_Declaration' LowerBound='42.15' HigherBound='42.38'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileID' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='3b03b120-2390-43b6-b4b9-a1c01ec2f745' ParentLink='ServiceBody_Declaration' LowerBound='42.40' HigherBound='42.69'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileStatusID' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='8ab48bb4-b73a-4659-a727-da3b19711dd1' ParentLink='ServiceBody_Declaration' LowerBound='42.71' HigherBound='42.129'>
                    <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GuardsFile' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='cdbc502a-542e-420c-8ca2-9a1a7fb1a98d' ParentLink='ServiceBody_Declaration' LowerBound='42.131' HigherBound='42.195'>
                    <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileResponse' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SQLCreateMedegaFileResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='53e7f6e2-c5d1-4696-89e3-119e2e28d223' ParentLink='ServiceBody_Statement' LowerBound='50.1' HigherBound='61.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='1abf846a-a48e-4308-a515-5f13e8005f28' ParentLink='Construct_MessageRef' LowerBound='51.23' HigherBound='51.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='e77cc2c4-4728-4120-8a1d-496746033bfa' ParentLink='Construct_MessageRef' LowerBound='51.32' HigherBound='51.44'>
                        <om:Property Name='Ref' Value='ExceptionMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='e7c14941-983f-409c-9d11-dd2f04d8fc99' ParentLink='Construct_MessageRef' LowerBound='51.46' HigherBound='51.73'>
                        <om:Property Name='Ref' Value='SQLCreateMedegaFileResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='71b548d6-b77b-4fd6-8a8d-3430e07fc959' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='60.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ExceptionMsg = tempXmlDoc;&#xD;&#xA;SQLCreateMedegaFileResponse.parameters = tempXmlDoc;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='0653e2f2-df5d-4298-8480-722b7f32c7a6' ParentLink='ServiceBody_Statement' LowerBound='61.1' HigherBound='65.1'>
                    <om:Property Name='Expression' Value='status = -99;&#xD;&#xA;FileStatusID = -1;&#xD;&#xA;FileID = 0;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Status' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='a4b0227b-7516-432b-a3c8-c63cb123a2fe' ParentLink='ServiceBody_Statement' LowerBound='65.1' HigherBound='146.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableDeclaration' OID='20530756-8b0f-4640-ba42-d2dec9fbba08' ParentLink='Scope_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                        <om:Property Name='UseDefaultConstructor' Value='False' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='ParamDirection' Value='In' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='xpathString' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='5e695e8c-5e2d-4f29-8763-5e4a8200d56e' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='85.1'>
                        <om:Property Name='Expression' Value='if(FILE.ReceivedFileName exists GuardsFile)&#xD;&#xA;{&#xD;&#xA;    receivedFileName=GuardsFile(FILE.ReceivedFileName);&#xD;&#xA;}&#xD;&#xA;else if(FTP.ReceivedFileName exists GuardsFile)&#xD;&#xA;{&#xD;&#xA;    receivedFileName=GuardsFile(FTP.ReceivedFileName);&#xD;&#xA;}&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;    receivedFileName = &quot;&quot;;&#xD;&#xA;}&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Get Filename' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='cd368a80-c25a-49c6-aba4-e107d82c06c2' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='99.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructFileInfo' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='246572e6-6bbf-4603-8a4a-b018cf86bd9e' ParentLink='Construct_MessageRef' LowerBound='86.31' HigherBound='86.38'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='e8a9ede3-4150-494b-9696-a3b19b4b6d0a' ParentLink='Construct_MessageRef' LowerBound='86.40' HigherBound='86.66'>
                            <om:Property Name='Ref' Value='SQLCreateMedegaFileRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='4ff0c0fb-f96d-41d3-8ec4-5caa870237c0' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='96.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;status = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.ImportStarted);&#xD;&#xA;tmpString = &quot;&lt;ns0:CreateMedegaFileRequest xmlns:ns0=&apos;http://inami-riziv.fgov.be.medega&apos;&gt;&lt;ns0:sp_BTSCreateMedegaFile FileName=&apos;&quot; + receivedFileName + &quot;&apos; FileStatus=&apos;&quot; + System.Convert.ToString(status) + &quot;&apos; /&gt;&lt;/ns0:CreateMedegaFileRequest&gt;&quot;;&#xD;&#xA;tempXmlDoc.LoadXml(tmpString);&#xD;&#xA;&#xD;&#xA;SQLCreateMedegaFileRequest.parameters = tempXmlDoc;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='cd666881-215a-406b-a8a0-08c7d3951323' ParentLink='ComplexStatement_Statement' LowerBound='96.1' HigherBound='98.1'>
                            <om:Property Name='Expression' Value='Context = SQLCreateMedegaFileRequest.parameters;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='Set Context' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='cf213b83-cf5c-4018-929b-35177a02dc19' ParentLink='ComplexStatement_Statement' LowerBound='99.1' HigherBound='131.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Try' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Send' OID='7734464f-462e-4eb8-bf5b-558000752492' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='106.1'>
                            <om:Property Name='PortName' Value='CreateMedegaFile' />
                            <om:Property Name='MessageName' Value='SQLCreateMedegaFileRequest' />
                            <om:Property Name='OperationName' Value='procedure' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send ImportFile' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='b4a94870-d466-454d-abd6-2c38d63d4509' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='108.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='CreateMedegaFile' />
                            <om:Property Name='MessageName' Value='SQLCreateMedegaFileResponse' />
                            <om:Property Name='OperationName' Value='procedure' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive DB2 Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='7b5bb6f9-4ed3-4753-8d09-8b96052c949a' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='112.1'>
                            <om:Property Name='Expression' Value='xpathString = &quot;number(//*[local-name()=&apos;FileId&apos;])&quot;;&#xD;&#xA;FileID = System.Convert.ToInt32(xpath(SQLCreateMedegaFileResponse.parameters, xpathString));&#xD;&#xA;FileStatusID = status;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get returncode' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='d78c787d-76b8-4598-9f15-7e8cfab99534' ParentLink='ComplexStatement_Statement' LowerBound='112.1' HigherBound='114.1'>
                            <om:Property Name='Expression' Value='status = 0;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get returncode' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='56792c53-3155-4f54-b974-4392b5cadb98' ParentLink='Scope_Catch' LowerBound='117.1' HigherBound='129.1'>
                            <om:Property Name='ExceptionType' Value='General Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Catch' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='c6b8fda0-17ea-4f71-8911-9650121a5744' ParentLink='Catch_Statement' LowerBound='120.1' HigherBound='126.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Set err msg' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='0e12c1a0-4a7a-4a90-abda-ee7805c16038' ParentLink='ComplexStatement_Statement' LowerBound='123.1' HigherBound='125.1'>
                                    <om:Property Name='Expression' Value='ExceptionMsg = SQLCreateMedegaFileResponse.parameters;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='Set err msg' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='0461dd2c-9aeb-4eb5-91e9-5170af9f6c19' ParentLink='Construct_MessageRef' LowerBound='121.43' HigherBound='121.55'>
                                    <om:Property Name='Ref' Value='ExceptionMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Throw' OID='a5252301-f00a-4355-bba9-370566c2eab7' ParentLink='Catch_Statement' LowerBound='126.1' HigherBound='128.1'>
                                <om:Property Name='ThrownReference' Value='ImportFileException' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Throw' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='70822a75-fe3f-4390-864a-58f6273d4cdc' ParentLink='Scope_Catch' LowerBound='134.1' HigherBound='144.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='5efb35b0-e793-416b-959a-99c26916c919' ParentLink='Catch_Statement' LowerBound='137.1' HigherBound='141.1'>
                            <om:Property Name='Expression' Value='ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;&#xD;&#xA;FileStatusID = -99; //to stop processing in the main (calling) orchestration' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error message' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='e2059a03-6b78-4471-80ad-6888053eb662' ParentLink='Catch_Statement' LowerBound='141.1' HigherBound='143.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_1' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CallOrchestration_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='14bff5db-7dd7-41b6-aa5e-fc1af0ffff76' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='status' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='808fab83-206e-4a0c-b766-412f9be4f051' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='06a58f9e-e289-4013-8f0d-d98cd2780b95' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='c1c1e7dc-40a6-4509-9e43-c730375eab48' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='376f0513-4e13-4e75-ae8d-240bfe0f5f48' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='849304cd-46a1-432e-8ddf-84c011530c6c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='29.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='44' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='MedegaImport.SQLCreateMedegaFilePT' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CreateMedegaFile' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='3e651e40-d5bf-49a0-9695-6da4c55dcc54' ParentLink='PortDeclaration_CLRAttribute' LowerBound='29.1' HigherBound='30.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ec401890-b344-4487-b715-c5bcac7415b8' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='CreateMedegaFileResponse' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='fdd9a197-869e-4772-8d18-688a1ab6fc0f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='7aee4967-6ec7-4000-bf19-22924bc2aad2' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='CreateMedegaFileRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='65326f86-9752-437f-b4aa-9b221c439a99' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLCreateMedegaFile.CreateMedegaFileRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
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

                if (__svc__.CreateMedegaFile != null)
                {
                    __svc__.CreateMedegaFile.Close(this, null);
                    __svc__.CreateMedegaFile = null;
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
                    __ctx1__.__receivedFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportFileException = null;
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tmpString = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMsg")]
            public __messagetype_System_Xml_XmlDocument __ExceptionMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLCreateMedegaFileRequest")]
            internal CreateMedegaFileRequest __SQLCreateMedegaFileRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("GuardsFile")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __GuardsFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLCreateMedegaFileResponse")]
            internal CreateMedegaFileResponse __SQLCreateMedegaFileResponse;
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
            [Microsoft.XLANGs.Core.UserVariableAttribute("status")]
            internal System.Int32 __status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileID")]
            internal System.Int32 __FileID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileStatusID")]
            internal System.Int32 __FileStatusID;
        }


        [System.SerializableAttribute]
        public class ____scope37_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope37_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope37")
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
                ____scope37_2 __ctx2__ = (____scope37_2)(__svc__._stateMgrs[2]);
                __subImportFile_1 __ctx1__ = (__subImportFile_1)(__svc__._stateMgrs[1]);

                if (__ctx2__ != null)
                    __ctx2__.__xpathString = null;
                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaFileRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileRequest);
                    __ctx1__.__SQLCreateMedegaFileRequest = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
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
        public class ____scope38_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope38_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope38")
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
                __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
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
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CreateMedegaFile")]
        internal SQLCreateMedegaFilePT CreateMedegaFile;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLCreateMedegaFilePT.procedure},
                                               typeof(subImportFile).GetField("CreateMedegaFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportFile), "CreateMedegaFile"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "cf213b83-cf5c-4018-929b-35177a02dc19", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "7734464f-462e-4eb8-bf5b-558000752492", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "7734464f-462e-4eb8-bf5b-558000752492", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "b4a94870-d466-454d-abd6-2c38d63d4509", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "b4a94870-d466-454d-abd6-2c38d63d4509", 3, false),
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,2,2,3,4,4,5,5,5,6,6,6,38,1,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 9,9,9,9,9,9,9,9,9,9,9,9,10,11,11,12,13,13,13,29,29,29,29,};
        public static int[] __progressLocation3 = new int[] { 15,15,15,15,16,17,17,18,19,19,20,20,20,22,22,23,23,23,23,};
        public static int[] __progressLocation4 = new int[] { 24,24,25,25,26,27,27,28,28,};
        public static int[] __progressLocation5 = new int[] { 30,30,31,31,32,32,32,35,35,36,37,37,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                CreateMedegaFile = new SQLCreateMedegaFilePT(0, this);
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
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__GuardsFile = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard("GuardsFile", __ctx1__);
                __ctx1__.__GuardsFile.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[2]);
                __ctx1__.RefMessage(__ctx1__.__GuardsFile);
                __ctx1__.__GuardsFile.ConstructionCompleteEvent();
                __ctx1__.__SQLCreateMedegaFileResponse = null;
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
                __ctx1__.__status = default(System.Int32);
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
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);
                    CreateMedegaFileResponse __SQLCreateMedegaFileResponse = new CreateMedegaFileResponse("SQLCreateMedegaFileResponse", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ExceptionMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __SQLCreateMedegaFileResponse.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                    if (__ctx1__.__SQLCreateMedegaFileResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                    __ctx1__.__SQLCreateMedegaFileResponse = __SQLCreateMedegaFileResponse;
                    __ctx1__.RefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                __ctx1__.__SQLCreateMedegaFileResponse.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileResponse);
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
                __ctx1__.__status = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__FileStatusID = -1;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__FileID = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                __ctx2__ = new ____scope37_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
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
                if (CreateMedegaFile != null)
                {
                    CreateMedegaFile.Close(__ctx1__, __seg__);
                    CreateMedegaFile = null;
                }
                Tracker.FireEvent(__eventLocations[38],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__GuardsFile);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileResponse);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__GuardsFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__GuardsFile);
                    __ctx1__.__GuardsFile = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 24;
            case 24:
                Args[0] = __ctx1__.__FileID;
                Args[1] = __ctx1__.__FileStatusID;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[3])).message = __ctx1__.__SQLCreateMedegaFileResponse;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[3])).context.RefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];

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
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    CreateMedegaFileRequest __SQLCreateMedegaFileRequest = new CreateMedegaFileRequest("SQLCreateMedegaFileRequest", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__status = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.ImportStarted);
                    __ctx1__.__tmpString = "<ns0:CreateMedegaFileRequest xmlns:ns0='http://inami-riziv.fgov.be.medega'><ns0:sp_BTSCreateMedegaFile FileName='" + __ctx1__.__receivedFileName + "' FileStatus='" + System.Convert.ToString(__ctx1__.__status) + "' /></ns0:CreateMedegaFileRequest>";
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml(__ctx1__.__tmpString);
                    __SQLCreateMedegaFileRequest.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __Context.part.CopyFrom(__SQLCreateMedegaFileRequest.parameters);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__SQLCreateMedegaFileRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileRequest);
                    __ctx1__.__SQLCreateMedegaFileRequest = __SQLCreateMedegaFileRequest;
                    __ctx1__.RefMessage(__ctx1__.__SQLCreateMedegaFileRequest);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__SQLCreateMedegaFileRequest.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileRequest);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx3__ = new ____scope38_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__xpathString = null;
                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaFileRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileRequest);
                    __ctx1__.__SQLCreateMedegaFileRequest = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];
            __subImportFile_root_0 __ctx0__ = (__subImportFile_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[15],__eventData[8],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CreateMedegaFile.SendMessage(0, __ctx1__.__SQLCreateMedegaFileRequest, null, null, out __ctx0__.__subWrapper0, __ctx3__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileRequest);
                    __edata.PortName = @"CreateMedegaFile";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[9],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!CreateMedegaFile.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__SQLCreateMedegaFileResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                __ctx1__.__SQLCreateMedegaFileResponse = new CreateMedegaFileResponse("SQLCreateMedegaFileResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SQLCreateMedegaFileResponse);
                CreateMedegaFile.ReceiveMessage(0, __msgEnv__, __ctx1__.__SQLCreateMedegaFileResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[3], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaFileResponse);
                    __edata.PortName = @"CreateMedegaFile";
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx2__.__xpathString = "number(//*[local-name()='FileId'])";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx1__.__FileID = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__SQLCreateMedegaFileResponse.parameters, __ctx2__.__xpathString, typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__FileStatusID = __ctx1__.__status;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__status = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 18;
            case 18:
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
            __subImportFile_1 __ctx1__ = (__subImportFile_1)_stateMgrs[1];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];

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

                    __ExceptionMsg.part.CopyFrom(__ctx1__.__SQLCreateMedegaFileResponse.parameters);

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
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
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
                __ctx1__.__FileStatusID = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[35],new object[] {__ctx1__.__status, __ctx1__.__Context, __ctx1__.__ExceptionMsg, __ctx1__.__ExceptionDescription, __ctx1__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
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
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[12],_stateMgrs[2].TrackDataStream );
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{B66D9ACE-3A50-4AB1-82BE-2ECE05FD9918}"))
        };

    }
    //#line 638 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\subImportGuardRecord.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.MailBusinessExceptionType)
        },
        new System.String[] {
            "SendBusinessErrors"
        },
        new System.Type[] {
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class subImportGuardRecord : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
                "MedegaImport.HandleException",
                "MedegaImport.subUpdateFileStatus"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] MedegaImportSchema.Schemas.Medega_Guard ImportGuard,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] MedegaImport.CreateMedegaFileResponse ImportFileResponse,
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 4, 5),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment6), 1, 2, 6)
            };

            _Locks = 4;
            _rootContext = new __subImportGuardRecord_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[7];
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
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>369ca3bc-9cd1-446c-a5bd-88122b72bc98</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9558519a-50fc-472d-bbe8-7c01938ed28f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0c1bb6dd-b21b-4f8b-be6f-5ead1e1caa4c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3e40810a-26ec-41bb-98c2-d402eca2fe2a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>be4fb6b3-3f12-4f71-86c9-e75fe8d223a4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9eda0749-661b-47d0-85b0-794b30ed9ba9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>30184323-b447-4bd6-95a6-a2b3ac1ea8b5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Initialize</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>82aec7a2-7d68-46cc-aebf-626eeb4a35a8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>f05771e9-9635-4f3c-8571-be849b67e5e9</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>884698c6-7f38-4e84-9d27-0dc2dc1a55da</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Try</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5c3a2318-d7b5-4910-a5ea-011a644e27cb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>f80337f9-c7e5-4aed-bb89-c3e2b5f89072</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8b3f99c5-bde2-4219-8971-d718f4933614</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct err msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1efdba0c-f7d9-4de4-b975-ab212a4bcde6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>9b791e97-65db-48f6-a132-cbbc2f951f64</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>69845107-d276-44a6-81c5-9b7a50456412</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Get returncode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>2f27fc93-d01f-40eb-8c64-6f654ef26ab5</ShapeID>      <ParentLink>Scope_VariableDeclaration</ParentLink>                <shapeText>MedegaBulkLoader</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>2297d5b0-b4ec-4d1a-af59-fc8bd6728147</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check sql return value</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1ed998b4-1a1e-458f-a731-8ab7e818cfca</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error status returned</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>e771b8e5-309d-4fc0-8962-629696718736</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Throw CreateInvoice exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>7c6445cf-abaf-408f-8779-61d556fc77c9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>623c4eea-90d0-4799-b340-4ec4f8e661dc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Call busines rules</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>65e69d42-e83a-489f-b572-052301418f5d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Validate Business Rules</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ad5ebc88-8741-4f26-8332-0dc131767959</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Business Err Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>bcd6dab7-3991-45db-8d81-ffc83a0dd96e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign business error</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3d3b6d01-8e44-4b7b-9e1c-55cd1d6ca134</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>AtomicTransactionShape</shapeType>      <ShapeID>334789eb-e441-41e1-9421-9cf0e0b01a46</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_Rules</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransactionAttributeShape</shapeType>      <ShapeID>334b2c10-2979-4f4a-a61c-bd2f0d936109</ShapeID>      <ParentLink>Statement_CLRAttribute</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>ae6adb5b-4103-471d-ae42-b80592a2df81</ShapeID>      <ParentLink>Scope_VariableDeclaration</ParentLink>                <shapeText>nodeValidator</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>b2ea331a-e9d2-44f4-944b-3321453be73d</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a93df797-5a08-4464-8ad8-363d55855fc4</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set ex</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>a268394c-2b67-4da0-952d-8efcd3c77e26</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>HandleXmlException</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>44615251-74e2-4aa8-94ca-73c79d531dab</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a0db44c2-cbf0-47cb-b697-b873cbba3c63</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8d3fe94f-3a37-4bf8-b087-54b3f85e01da</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>749f90f6-5557-4c41-906d-1d8fcb6a7ebb</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>6e86a05b-3abe-4605-b9e5-0b57424d323f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
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
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2bddfa94-0af7-4be2-907c-3c81f8d9f9ba</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Business Errors</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>a5c183ad-7eba-40fc-873a-aa75f279ff2d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f795c151-6826-4583-b286-0cf73fef6d50</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Status Pending</shapeText>                  
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
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>49622025-865b-4914-aab3-a75a296e5202</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>FileId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>023ec6cd-3244-4117-a28c-278661f2287f</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>NewFileStatusId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'subImportGuardRecord'</ActionName><IsAtomic>0</IsAtomic><Line>638</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>ImportGuard</name><part>part</part><schema>MedegaImportSchema.Schemas.Medega_Guard</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ImportFileResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>666</Line><Position>24</Position><ShapeID>'369ca3bc-9cd1-446c-a5bd-88122b72bc98'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>674</Line><Position>13</Position><ShapeID>'9558519a-50fc-472d-bbe8-7c01938ed28f'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SQLCreateMedegaXmlNodeResponse</name><part>parameters</part><schema>MedegaImport.SQLCreateMedegaXmlNode+CreateMedegaXmlNodeResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>687</Line><Position>13</Position><ShapeID>'82aec7a2-7d68-46cc-aebf-626eeb4a35a8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope39'</ActionName><IsAtomic>0</IsAtomic><Line>692</Line><Position>21</Position><ShapeID>'884698c6-7f38-4e84-9d27-0dc2dc1a55da'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>699</Line><Position>46</Position><ShapeID>'5c3a2318-d7b5-4910-a5ea-011a644e27cb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>709</Line><Position>29</Position><ShapeID>'f80337f9-c7e5-4aed-bb89-c3e2b5f89072'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>712</Line><Position>33</Position><ShapeID>'8b3f99c5-bde2-4219-8971-d718f4933614'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>721</Line><Position>52</Position><ShapeID>'69845107-d276-44a6-81c5-9b7a50456412'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>728</Line><Position>21</Position><ShapeID>'2297d5b0-b4ec-4d1a-af59-fc8bd6728147'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>731</Line><Position>25</Position><ShapeID>'e771b8e5-309d-4fc0-8962-629696718736'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_Rules'</ActionName><IsAtomic>1</IsAtomic><Line>735</Line><Position>21</Position><ShapeID>'623c4eea-90d0-4799-b340-4ec4f8e661dc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>742</Line><Position>43</Position><ShapeID>'65e69d42-e83a-489f-b572-052301418f5d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>747</Line><Position>29</Position><ShapeID>'ad5ebc88-8741-4f26-8332-0dc131767959'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>759</Line><Position>21</Position><ShapeID>'b2ea331a-e9d2-44f4-944b-3321453be73d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>762</Line><Position>46</Position><ShapeID>'a93df797-5a08-4464-8ad8-363d55855fc4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>775</Line><Position>59</Position><ShapeID>'a268394c-2b67-4da0-952d-8efcd3c77e26'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>ExceptionMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>780</Line><Position>13</Position><ShapeID>'fbcfb504-208b-4021-8858-808f00aec876'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>783</Line><Position>33</Position><ShapeID>'baeab7ca-620f-4156-96ff-c4aff3e345a9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>788</Line><Position>17</Position><ShapeID>'e68491d5-76ef-430e-92cf-8e4c6658b75d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>791</Line><Position>37</Position><ShapeID>'515a3691-081e-4e4f-bf88-4d61bbc468e7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>793</Line><Position>21</Position><ShapeID>'2bddfa94-0af7-4be2-907c-3c81f8d9f9ba'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>798</Line><Position>37</Position><ShapeID>'f795c151-6826-4583-b286-0cf73fef6d50'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>802</Line><Position>51</Position><ShapeID>'1dd17bd0-64fd-4690-8e81-1b0b51609438'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ee79c801-66b2-4a2a-a53d-7ae2f7cdfbaa' LowerBound='1.1' HigherBound='207.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='1e9a4c06-cfde-4b70-9fd3-0fb26b6a68ec' ParentLink='Module_PortType' LowerBound='17.1' HigherBound='24.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLCreateMedegaXmlNodePT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='6f14f578-7ba8-4a55-a3d6-ce1fa440cbba' ParentLink='PortType_OperationDeclaration' LowerBound='19.1' HigherBound='23.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='a339ed27-0b81-4dc0-b30b-1ccafd0d1bcc' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='21.41' HigherBound='21.68'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateMedegaXmlNodeResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='5da4b876-e035-450c-aa7f-46efb5ca71a9' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='21.13' HigherBound='21.39'>
                    <om:Property Name='Ref' Value='MedegaImport.CreateMedegaXmlNodeRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ac97c4da-e645-40a6-b4f5-71e6a8bc7145' ParentLink='Module_PortType' LowerBound='24.1' HigherBound='31.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MailBusinessExceptionType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cd605d53-49a5-44dd-93ae-7873e1b49828' ParentLink='PortType_OperationDeclaration' LowerBound='26.1' HigherBound='30.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Mail' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ae18eaf7-f3f2-4d82-aca6-62d74b44e8c6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='28.13' HigherBound='28.37'>
                    <om:Property Name='Ref' Value='MedegaImport.BusinessValidationErrors' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0b230262-3cf7-4c0d-b197-da547866545c' ParentLink='Module_PortType' LowerBound='31.1' HigherBound='38.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MailOkPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f57fa769-135f-4728-a4fa-404ae5ec774e' ParentLink='PortType_OperationDeclaration' LowerBound='33.1' HigherBound='37.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MailDoneWithExceptions' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='5a233e4b-b630-4aa1-871f-d790f9ea61dc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='35.13' HigherBound='35.37'>
                    <om:Property Name='Ref' Value='MedegaImport.BusinessValidationErrors' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fa4e8bba-5104-4134-9303-0ba52fa65b29' ParentLink='Module_ServiceDeclaration' LowerBound='38.1' HigherBound='206.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subImportGuardRecord' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='167416d5-a090-4417-a407-568654c250ff' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ImportXmlException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8fe4c01d-a5d5-4f0c-bc7d-6d55c7f3d5da' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3d4b196a-611b-494c-b82e-9767b487c03c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0de52249-a2aa-46f3-8032-7c3cd18b5bce' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='InitialValue' Value='&quot;&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ce5e8013-6bd7-40a2-8ea9-09410d4fe133' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='InitialValue' Value='&quot;&quot;' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='49b655b8-bedf-49d2-8330-2a723995bf0f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewFileStatusId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ce8a3e5-5ac3-4c62-9dac-f7f3461ac9ff' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TechnicalErrorOccured' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fea021e9-1a37-4398-952e-68e96ae10f2d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='validationResult' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='df2101b6-8a41-4948-96f6-22389b70094c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='businessRulesOK' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='7f038b94-b9c7-4171-b133-94b9e3a43101' ParentLink='ServiceDeclaration_Transaction' LowerBound='39.21' HigherBound='39.66'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fa4b3f01-7fcf-4486-a20a-ac5e28bf2712' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0d7f5b14-d450-4e47-8fa1-f73ce95eb82f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='00982905-cbdc-42db-b799-20e3aa372ecd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='MedegaImport.CreateMedegaXmlNodeRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLCreateMedegaXmlNodeRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cf4c4415-1b2f-428c-b142-b1b467394384' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='MedegaImport.CreateMedegaXmlNodeResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLCreateMedegaXmlNodeResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c0fcb6c3-2deb-4cad-9ed8-e1147d6141f1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='MedegaImport.BusinessValidationErrors' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='BusinessValidationErrorsMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='d3be70c8-4233-4b51-9b50-6dae7f0d8c25' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='059c68bb-220c-4d26-b80a-f5efc1c97b7e' ParentLink='ServiceBody_Declaration' LowerBound='57.15' HigherBound='57.74'>
                    <om:Property Name='Type' Value='MedegaImportSchema.Schemas.Medega_Guard' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportGuard' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='0b282359-8a65-43c2-8914-7ceefb1640b2' ParentLink='ServiceBody_Declaration' LowerBound='57.76' HigherBound='57.127'>
                    <om:Property Name='Type' Value='MedegaImport.CreateMedegaFileResponse' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ImportFileResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='1dfd46af-829b-4648-b031-1c701699592f' ParentLink='ServiceBody_Declaration' LowerBound='57.129' HigherBound='57.148'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='369ca3bc-9cd1-446c-a5bd-88122b72bc98' ParentLink='ServiceBody_Statement' LowerBound='66.1' HigherBound='74.1'>
                    <om:Property Name='Expression' Value='returnCode = -99;&#xD;&#xA;&#xD;&#xA;businessRulesOK = true;&#xD;&#xA;TechnicalErrorOccured = false;&#xD;&#xA;&#xD;&#xA;tempXmlDoc = ImportFileResponse.parameters;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;Medega&quot;, tempXmlDoc.OuterXml);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='9558519a-50fc-472d-bbe8-7c01938ed28f' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='87.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='0c1bb6dd-b21b-4f8b-be6f-5ead1e1caa4c' ParentLink='Construct_MessageRef' LowerBound='75.23' HigherBound='75.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='3e40810a-26ec-41bb-98c2-d402eca2fe2a' ParentLink='Construct_MessageRef' LowerBound='75.32' HigherBound='75.44'>
                        <om:Property Name='Ref' Value='ExceptionMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='be4fb6b3-3f12-4f71-86c9-e75fe8d223a4' ParentLink='Construct_MessageRef' LowerBound='75.46' HigherBound='75.76'>
                        <om:Property Name='Ref' Value='SQLCreateMedegaXmlNodeResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='9eda0749-661b-47d0-85b0-794b30ed9ba9' ParentLink='Construct_MessageRef' LowerBound='75.78' HigherBound='75.105'>
                        <om:Property Name='Ref' Value='BusinessValidationErrorsMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='30184323-b447-4bd6-95a6-a2b3ac1ea8b5' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='86.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ExceptionMsg = tempXmlDoc;&#xD;&#xA;SQLCreateMedegaXmlNodeResponse.parameters = tempXmlDoc;&#xD;&#xA;BusinessValidationErrorsMsg.BusinessErrorMessages = &quot;&quot;;&#xD;&#xA;BusinessValidationErrorsMsg.FileId = &quot;FileId = &quot; + System.Convert.ToString(FileId);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='82aec7a2-7d68-46cc-aebf-626eeb4a35a8' ParentLink='ServiceBody_Statement' LowerBound='87.1' HigherBound='180.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='f05771e9-9635-4f3c-8571-be849b67e5e9' ParentLink='Scope_Transaction' LowerBound='88.18' HigherBound='88.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Scope' OID='884698c6-7f38-4e84-9d27-0dc2dc1a55da' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='128.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Try' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='5c3a2318-d7b5-4910-a5ea-011a644e27cb' ParentLink='ComplexStatement_Statement' LowerBound='99.1' HigherBound='106.1'>
                            <om:Property Name='Expression' Value='MedegaBulkLoader = new Riziv.MedegaImport.Bulkloader.MedegaBulkloader();&#xD;&#xA;MedegaBulkLoader.LoadGuardNodes(ImportGuard, FileId, System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaNodeStatus.ImportStarted ));&#xD;&#xA;&#xD;&#xA;returnCode = 0;&#xD;&#xA;//tempXmlDoc = SQLCreateMedegaXmlNodeResponse.parameters;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;CreateXmlNode&quot;, tempXmlDoc.OuterXml );&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get returncode' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Catch' OID='f80337f9-c7e5-4aed-bb89-c3e2b5f89072' ParentLink='Scope_Catch' LowerBound='109.1' HigherBound='126.1'>
                            <om:Property Name='ExceptionName' Value='exc' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Catch' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='8b3f99c5-bde2-4219-8971-d718f4933614' ParentLink='Catch_Statement' LowerBound='112.1' HigherBound='121.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct err msg' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='1efdba0c-f7d9-4de4-b975-ab212a4bcde6' ParentLink='Construct_MessageRef' LowerBound='113.43' HigherBound='113.55'>
                                    <om:Property Name='Ref' Value='ExceptionMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='9b791e97-65db-48f6-a132-cbbc2f951f64' ParentLink='ComplexStatement_Statement' LowerBound='115.1' HigherBound='120.1'>
                                    <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;exc&gt;&quot; + exc.Message + &quot;&lt;/exc&gt;&quot;);&#xD;&#xA;&#xD;&#xA;ExceptionMsg = tempXmlDoc;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='Assign ErrMsg' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='69845107-d276-44a6-81c5-9b7a50456412' ParentLink='Catch_Statement' LowerBound='121.1' HigherBound='125.1'>
                                <om:Property Name='Expression' Value='ImportXmlException = exc;&#xD;&#xA;returnCode = -99;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Get returncode' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='VariableDeclaration' OID='2f27fc93-d01f-40eb-8c64-6f654ef26ab5' ParentLink='Scope_VariableDeclaration' LowerBound='95.1' HigherBound='96.1'>
                            <om:Property Name='UseDefaultConstructor' Value='True' />
                            <om:Property Name='Type' Value='Riziv.MedegaImport.Bulkloader.MedegaBulkloader' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MedegaBulkLoader' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Decision' OID='2297d5b0-b4ec-4d1a-af59-fc8bd6728147' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='134.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Check sql return value' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='DecisionBranch' OID='1ed998b4-1a1e-458f-a731-8ab7e818cfca' ParentLink='ReallyComplexStatement_Branch' LowerBound='129.21' HigherBound='134.1'>
                            <om:Property Name='Expression' Value='returnCode &lt; 0' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Error status returned' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Throw' OID='e771b8e5-309d-4fc0-8962-629696718736' ParentLink='ComplexStatement_Statement' LowerBound='131.1' HigherBound='133.1'>
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
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='623c4eea-90d0-4799-b340-4ec4f8e661dc' ParentLink='ComplexStatement_Statement' LowerBound='134.1' HigherBound='156.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Call busines rules' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='65e69d42-e83a-489f-b572-052301418f5d' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='147.1'>
                            <om:Property Name='Expression' Value='nodeValidator = new Riziv.HODMedega.Validator.MedegaNodeValidator(RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString(&quot;MedegaImport&quot;, &quot;Medega.StrConn.Validator&quot;));&#xD;&#xA;businessRulesOK = nodeValidator.ValidateNodesOf(FileId, ref validationResult);&#xD;&#xA;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;MedegaImport&quot;, validationResult);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Validate Business Rules' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='ad5ebc88-8741-4f26-8332-0dc131767959' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='154.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Business Err Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='bcd6dab7-3991-45db-8d81-ffc83a0dd96e' ParentLink='ComplexStatement_Statement' LowerBound='150.1' HigherBound='153.1'>
                                <om:Property Name='Expression' Value='BusinessValidationErrorsMsg.FileId = &quot;FileId = &quot; + System.Convert.ToString(FileId);&#xD;&#xA;BusinessValidationErrorsMsg.BusinessErrorMessages = validationResult;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Assign business error' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='3d3b6d01-8e44-4b7b-9e1c-55cd1d6ca134' ParentLink='Construct_MessageRef' LowerBound='148.39' HigherBound='148.66'>
                                <om:Property Name='Ref' Value='BusinessValidationErrorsMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='AtomicTransaction' OID='334789eb-e441-41e1-9421-9cf0e0b01a46' ParentLink='Scope_Transaction' LowerBound='136.26' HigherBound='136.63'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transaction_Rules' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='TransactionAttribute' OID='334b2c10-2979-4f4a-a61c-bd2f0d936109' ParentLink='Statement_CLRAttribute' LowerBound='135.1' HigherBound='136.1'>
                            <om:Property Name='Batch' Value='True' />
                            <om:Property Name='Retry' Value='True' />
                            <om:Property Name='Timeout' Value='60' />
                            <om:Property Name='Isolation' Value='Serializable' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='VariableDeclaration' OID='ae6adb5b-4103-471d-ae42-b80592a2df81' ParentLink='Scope_VariableDeclaration' LowerBound='138.1' HigherBound='139.1'>
                            <om:Property Name='UseDefaultConstructor' Value='True' />
                            <om:Property Name='Type' Value='Riziv.HODMedega.Validator.MedegaNodeValidator' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='nodeValidator' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='b2ea331a-e9d2-44f4-944b-3321453be73d' ParentLink='Scope_Catch' LowerBound='159.1' HigherBound='178.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='a93df797-5a08-4464-8ad8-363d55855fc4' ParentLink='Catch_Statement' LowerBound='162.1' HigherBound='175.1'>
                            <om:Property Name='Expression' Value='ExceptionDescription = ex.Message;&#xD;&#xA;TechnicalErrorOccured = true;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;&#xD;&#xA;if(ex.InnerException != null)&#xD;&#xA;{&#xD;&#xA;    InnerExceptionDescription = ex.InnerException.Message;&#xD;&#xA;}&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;    InnerExceptionDescription = &quot;&quot;;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set ex' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Call' OID='a268394c-2b67-4da0-952d-8efcd3c77e26' ParentLink='Catch_Statement' LowerBound='175.1' HigherBound='177.1'>
                            <om:Property Name='Identifier' Value='HandleXmlException' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='HandleXmlException' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Parameter' OID='44615251-74e2-4aa8-94ca-73c79d531dab' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='returnCode' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='a0db44c2-cbf0-47cb-b697-b873cbba3c63' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='8d3fe94f-3a37-4bf8-b087-54b3f85e01da' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='749f90f6-5557-4c41-906d-1d8fcb6a7ebb' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='6e86a05b-3abe-4605-b9e5-0b57424d323f' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='fbcfb504-208b-4021-8858-808f00aec876' ParentLink='ServiceBody_Statement' LowerBound='180.1' HigherBound='202.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Technical error occured' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='0663aeb3-4edd-410b-9e0d-3e961bdf01c5' ParentLink='ReallyComplexStatement_Branch' LowerBound='181.13' HigherBound='186.1'>
                        <om:Property Name='Expression' Value='TechnicalErrorOccured == true' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Yes' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='baeab7ca-620f-4156-96ff-c4aff3e345a9' ParentLink='ComplexStatement_Statement' LowerBound='183.1' HigherBound='185.1'>
                            <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.InError );&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Status Error' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='5034e9f9-1ce0-4154-9094-538192d4ffd7' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Decision' OID='e68491d5-76ef-430e-92cf-8e4c6658b75d' ParentLink='ComplexStatement_Statement' LowerBound='188.1' HigherBound='201.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Business error occured' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='37fb3878-f107-4e75-a513-99cf1c1207cf' ParentLink='ReallyComplexStatement_Branch' LowerBound='189.17' HigherBound='196.1'>
                                <om:Property Name='Expression' Value='businessRulesOK == false' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Yes' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='515a3691-081e-4e4f-bf88-4d61bbc468e7' ParentLink='ComplexStatement_Statement' LowerBound='191.1' HigherBound='193.1'>
                                    <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.NotValid );&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Status Business error' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Send' OID='2bddfa94-0af7-4be2-907c-3c81f8d9f9ba' ParentLink='ComplexStatement_Statement' LowerBound='193.1' HigherBound='195.1'>
                                    <om:Property Name='PortName' Value='SendBusinessErrors' />
                                    <om:Property Name='MessageName' Value='BusinessValidationErrorsMsg' />
                                    <om:Property Name='OperationName' Value='Mail' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send Business Errors' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='a5c183ad-7eba-40fc-873a-aa75f279ff2d' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='f795c151-6826-4583-b286-0cf73fef6d50' ParentLink='ComplexStatement_Statement' LowerBound='198.1' HigherBound='200.1'>
                                    <om:Property Name='Expression' Value='NewFileStatusId = System.Convert.ToInt32( MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending );&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Status Pending' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Call' OID='1dd17bd0-64fd-4690-8e81-1b0b51609438' ParentLink='ServiceBody_Statement' LowerBound='202.1' HigherBound='204.1'>
                    <om:Property Name='Identifier' Value='CallUpdateFileStatusId' />
                    <om:Property Name='Invokee' Value='MedegaImport.subUpdateFileStatus' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallUpdateFileStatusId' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Parameter' OID='49622025-865b-4914-aab3-a75a296e5202' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='FileId' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='023ec6cd-3244-4117-a28c-278661f2287f' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='NewFileStatusId' />
                        <om:Property Name='Type' Value='System.Int32' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4d5db6f5-c6bd-4ae0-93b2-a0744dffaef0' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='165' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.MailBusinessExceptionType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendBusinessErrors' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b948f616-5b2f-4128-a543-0e13524572d3' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='bb984213-9d7c-4978-9711-6c4dc026bb35' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='CreateMedegaXmlNodeResponse' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e1e7f6fa-bb8b-43f2-a356-e0833904a28e' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1bd6ae66-1511-4850-aad4-7081ee648c9a' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='CreateMedegaXmlNodeRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='db726070-5a82-493e-920b-f1df497f8507' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='53449a22-d519-4174-a761-508d9c6f1947' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='17.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BusinessValidationErrors' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='d917a56e-6c4f-4450-a4b6-505abeec615a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='System.String' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='PartDeclaration' OID='cc972677-e6a8-4d0b-9f66-7f633928ea76' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='15.1' HigherBound='16.1'>
                <om:Property Name='ClassName' Value='System.String' />
                <om:Property Name='IsBodyPart' Value='False' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='BusinessErrorMessages' />
                <om:Property Name='Signal' Value='True' />
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

                if (__svc__.SendBusinessErrors != null)
                {
                    __svc__.SendBusinessErrors.Close(this, null);
                    __svc__.SendBusinessErrors = null;
                }
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __subImportGuardRecord_1 : Microsoft.XLANGs.Core.LongRunningTransaction
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
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ImportXmlException = null;
                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaXmlNodeResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaXmlNodeResponse);
                    __ctx1__.__SQLCreateMedegaXmlNodeResponse = null;
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
                if (__ctx2__ != null)
                    __ctx2__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__validationResult = null;
                if (__ctx2__ != null)
                    __ctx2__.__ImportXmlException = null;
                if (__ctx2__ != null && __ctx2__.__ExceptionMsg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__ExceptionMsg);
                    __ctx2__.__ExceptionMsg = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__BusinessValidationErrorsMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                    __ctx1__.__BusinessValidationErrorsMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMsg")]
            public __messagetype_System_Xml_XmlDocument __ExceptionMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLCreateMedegaXmlNodeResponse")]
            internal CreateMedegaXmlNodeResponse __SQLCreateMedegaXmlNodeResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("BusinessValidationErrorsMsg")]
            internal BusinessValidationErrors __BusinessValidationErrorsMsg;  // lock index = 3
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportGuard")]
            public __messagetype_MedegaImportSchema_Schemas_Medega_Guard __ImportGuard;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportFileResponse")]
            internal CreateMedegaFileResponse __ImportFileResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportXmlException")]
            internal System.Exception __ImportXmlException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NewFileStatusId")]
            internal System.Int32 __NewFileStatusId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TechnicalErrorOccured")]
            internal System.Boolean __TechnicalErrorOccured;
            [Microsoft.XLANGs.Core.UserVariableAttribute("validationResult")]
            internal System.String __validationResult;  // lock index = 1
            [Microsoft.XLANGs.Core.UserVariableAttribute("businessRulesOK")]
            internal System.Boolean __businessRulesOK;  // lock index = 2
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileId")]
            internal System.Int32 __FileId;  // lock index = 0
        }


        [System.SerializableAttribute]
        public class __Transaction_2_2 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Transaction_2_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_2")
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
                        __seg__ = _service._segments[6];
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
                __Transaction_Rules_4 __ctx4__ = (__Transaction_Rules_4)(__svc__._stateMgrs[4]);
                __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)(__svc__._stateMgrs[1]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                __ctx1__.__returnCode = __ctx2__.__returnCode;
                if (__ctx1__.__ExceptionMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                __ctx1__.__ExceptionMsg = __ctx2__.__ExceptionMsg;
                if (__ctx2__.__ExceptionMsg != null)
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                __ctx1__.__ImportXmlException = __ctx2__.__ImportXmlException;
                __ctx1__.__ExceptionDescription = __ctx2__.__ExceptionDescription;
                __ctx1__.__TechnicalErrorOccured = __ctx2__.__TechnicalErrorOccured;
                __ctx1__.__InnerExceptionDescription = __ctx2__.__InnerExceptionDescription;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx4__ != null && __ctx4__.__BusinessValidationErrorsMsg != null)
                {
                    __ctx4__.UnrefMessage(__ctx4__.__BusinessValidationErrorsMsg);
                    __ctx4__.__BusinessValidationErrorsMsg = null;
                }
                if (__ctx4__ != null)
                    __ctx4__.__validationResult = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMsg")]
            public __messagetype_System_Xml_XmlDocument __ExceptionMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ImportXmlException")]
            internal System.Exception __ImportXmlException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TechnicalErrorOccured")]
            internal System.Boolean __TechnicalErrorOccured;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope39_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope39_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope39")
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
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[4];
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
                ____scope39_3 __ctx3__ = (____scope39_3)(__svc__._stateMgrs[3]);

                if (__ctx3__ != null)
                    __ctx3__.__exc_0 = null;
                if (__ctx3__ != null)
                    __ctx3__.__MedegaBulkLoader = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MedegaBulkLoader")]
            internal Riziv.MedegaImport.Bulkloader.MedegaBulkloader __MedegaBulkLoader;
            internal object __exv__;
            internal System.Exception __exc_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class __Transaction_Rules_4 : Microsoft.XLANGs.Core.AtomicTransaction
        {
            public __Transaction_Rules_4(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_Rules")
            {
                Retry = true;
                Batch = true;
                Timeout = 60;
                TranIsolationLevel = System.Data.IsolationLevel.Serializable;
            }

            public override int Index { get { return 4; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[5]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[5]; }
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
                __Transaction_Rules_4 __ctx4__ = (__Transaction_Rules_4)(__svc__._stateMgrs[4]);
                __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)(__svc__._stateMgrs[1]);

                if (this.Succeeded)
                {
                    __ctx1__.__validationResult = __ctx4__.__validationResult;
                    __ctx1__.__businessRulesOK = __ctx4__.__businessRulesOK;
                    if (__ctx1__.__BusinessValidationErrorsMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                    __ctx1__.__BusinessValidationErrorsMsg = __ctx4__.__BusinessValidationErrorsMsg;
                    if (__ctx4__.__BusinessValidationErrorsMsg != null)
                        __ctx1__.RefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                }
                else if (_PrologueCompleted)
                {
                    __ctx1__.__validationResult = (System.String)__ctx4__.RestoreObject(__ctx4__.__validationResult, 0);
                }
                if (__ctx4__ != null)
                    __ctx4__.__nodeValidator = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("BusinessValidationErrorsMsg")]
            internal BusinessValidationErrors __BusinessValidationErrorsMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("validationResult")]
            internal System.String __validationResult;
            [Microsoft.XLANGs.Core.UserVariableAttribute("businessRulesOK")]
            internal System.Boolean __businessRulesOK;
            [System.NonSerializedAttribute]
            [Microsoft.XLANGs.Core.UserVariableAttribute("nodeValidator")]
            internal Riziv.HODMedega.Validator.MedegaNodeValidator __nodeValidator;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendBusinessErrors")]
        internal MailBusinessExceptionType SendBusinessErrors;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MailBusinessExceptionType.Mail},
                                               typeof(subImportGuardRecord).GetField("SendBusinessErrors", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subImportGuardRecord), "SendBusinessErrors"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "9558519a-50fc-472d-bbe8-7c01938ed28f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "9558519a-50fc-472d-bbe8-7c01938ed28f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "82aec7a2-7d68-46cc-aebf-626eeb4a35a8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "884698c6-7f38-4e84-9d27-0dc2dc1a55da", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "5c3a2318-d7b5-4910-a5ea-011a644e27cb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "5c3a2318-d7b5-4910-a5ea-011a644e27cb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "f80337f9-c7e5-4aed-bb89-c3e2b5f89072", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "8b3f99c5-bde2-4219-8971-d718f4933614", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "8b3f99c5-bde2-4219-8971-d718f4933614", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "69845107-d276-44a6-81c5-9b7a50456412", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "69845107-d276-44a6-81c5-9b7a50456412", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "f80337f9-c7e5-4aed-bb89-c3e2b5f89072", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "884698c6-7f38-4e84-9d27-0dc2dc1a55da", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "2297d5b0-b4ec-4d1a-af59-fc8bd6728147", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "e771b8e5-309d-4fc0-8962-629696718736", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "2297d5b0-b4ec-4d1a-af59-fc8bd6728147", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "623c4eea-90d0-4799-b340-4ec4f8e661dc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "65e69d42-e83a-489f-b572-052301418f5d", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "65e69d42-e83a-489f-b572-052301418f5d", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "ad5ebc88-8741-4f26-8332-0dc131767959", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "ad5ebc88-8741-4f26-8332-0dc131767959", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "623c4eea-90d0-4799-b340-4ec4f8e661dc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "b2ea331a-e9d2-44f4-944b-3321453be73d", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "a93df797-5a08-4464-8ad8-363d55855fc4", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "a93df797-5a08-4464-8ad8-363d55855fc4", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "00000000-0000-0000-0000-000000000000", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "00000000-0000-0000-0000-000000000000", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "a268394c-2b67-4da0-952d-8efcd3c77e26", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "a268394c-2b67-4da0-952d-8efcd3c77e26", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "b2ea331a-e9d2-44f4-944b-3321453be73d", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "82aec7a2-7d68-46cc-aebf-626eeb4a35a8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "fbcfb504-208b-4021-8858-808f00aec876", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "baeab7ca-620f-4156-96ff-c4aff3e345a9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "baeab7ca-620f-4156-96ff-c4aff3e345a9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "e68491d5-76ef-430e-92cf-8e4c6658b75d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "515a3691-081e-4e4f-bf88-4d61bbc468e7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "515a3691-081e-4e4f-bf88-4d61bbc468e7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "2bddfa94-0af7-4be2-907c-3c81f8d9f9ba", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "2bddfa94-0af7-4be2-907c-3c81f8d9f9ba", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "f795c151-6826-4583-b286-0cf73fef6d50", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "f795c151-6826-4583-b286-0cf73fef6d50", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "e68491d5-76ef-430e-92cf-8e4c6658b75d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "fbcfb504-208b-4021-8858-808f00aec876", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "1dd17bd0-64fd-4690-8e81-1b0b51609438", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "1dd17bd0-64fd-4690-8e81-1b0b51609438", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,2,2,3,3,3,3,4,4,5,6,6,6,41,42,42,43,43,44,42,45,45,46,46,47,48,48,48,49,45,50,50,51,52,53,54,54,55,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 8,8,8,8,21,22,22,23,23,24,25,25,25,32,32,32,32,};
        public static int[] __progressLocation3 = new int[] { 11,11,11,11,12,12,12,12,12,12,};
        public static int[] __progressLocation4 = new int[] { 13,13,14,14,15,16,16,17,17,20,20,};
        public static int[] __progressLocation5 = new int[] { 28,28,28,28,28,28,28,28,29,29,30,30,31,31,31,31,};
        public static int[] __progressLocation6 = new int[] { 33,33,34,34,35,35,35,35,35,35,35,35,35,38,38,39,40,40,};

        public static int[][] __progressLocations = new int[7] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5,__progressLocation6};
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
                SendBusinessErrors = new MailBusinessExceptionType(0, this);
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
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __subImportGuardRecord_root_0 __ctx0__ = (__subImportGuardRecord_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileId = (System.Int32)Args[2];
                __ctx1__.__ImportGuard = new __messagetype_MedegaImportSchema_Schemas_Medega_Guard("ImportGuard", __ctx1__);
                __ctx1__.__ImportGuard.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__ImportGuard);
                __ctx1__.__ImportGuard.ConstructionCompleteEvent();
                __ctx1__.__ImportFileResponse = new CreateMedegaFileResponse("ImportFileResponse", __ctx1__);
                __ctx1__.__ImportFileResponse.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[1]);
                __ctx1__.RefMessage(__ctx1__.__ImportFileResponse);
                __ctx1__.__ImportFileResponse.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__ImportXmlException = default(System.Exception);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__returnCode = default(System.Int32);
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__NewFileStatusId = default(System.Int32);
                __ctx1__.__TechnicalErrorOccured = default(System.Boolean);
                __ctx1__.__validationResult = default(System.String);
                __ctx1__.__businessRulesOK = default(System.Boolean);
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
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__ExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__TechnicalErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__validationResult = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__businessRulesOK = true;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx1__.__returnCode = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__businessRulesOK = true;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__TechnicalErrorOccured = false;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = __ctx1__.__ImportFileResponse.parameters.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx1__);
                    CreateMedegaXmlNodeResponse __SQLCreateMedegaXmlNodeResponse = new CreateMedegaXmlNodeResponse("SQLCreateMedegaXmlNodeResponse", __ctx1__);
                    BusinessValidationErrors __BusinessValidationErrorsMsg = new BusinessValidationErrors("BusinessValidationErrorsMsg", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<empty/>");
                    __Context.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __ExceptionMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __SQLCreateMedegaXmlNodeResponse.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __BusinessValidationErrorsMsg.BusinessErrorMessages.LoadFrom("");
                    __BusinessValidationErrorsMsg.FileId.LoadFrom("FileId = " + System.Convert.ToString(__ctx1__.__FileId));

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__ExceptionMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = __ExceptionMsg;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMsg);
                    if (__ctx1__.__SQLCreateMedegaXmlNodeResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaXmlNodeResponse);
                    __ctx1__.__SQLCreateMedegaXmlNodeResponse = __SQLCreateMedegaXmlNodeResponse;
                    __ctx1__.RefMessage(__ctx1__.__SQLCreateMedegaXmlNodeResponse);
                    if (__ctx1__.__BusinessValidationErrorsMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                    __ctx1__.__BusinessValidationErrorsMsg = __BusinessValidationErrorsMsg;
                    __ctx1__.RefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__ExceptionMsg.ConstructionCompleteEvent(false);
                __ctx1__.__SQLCreateMedegaXmlNodeResponse.ConstructionCompleteEvent(false);
                __ctx1__.__BusinessValidationErrorsMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ExceptionMsg);
                    __edata.Messages.Add(__ctx1__.__SQLCreateMedegaXmlNodeResponse);
                    __edata.Messages.Add(__ctx1__.__BusinessValidationErrorsMsg);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SQLCreateMedegaXmlNodeResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLCreateMedegaXmlNodeResponse);
                    __ctx1__.__SQLCreateMedegaXmlNodeResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__validationResult = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                Tracker.FireEvent(__eventLocations[41],__eventData[8],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null)
                    __ctx2__.__InnerExceptionDescription = null;
                if (__ctx2__ != null)
                    __ctx2__.__ExceptionDescription = null;
                if (__ctx2__ != null)
                    __ctx2__.__ImportXmlException = null;
                if (__ctx2__ != null && __ctx2__.__ExceptionMsg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__ExceptionMsg);
                    __ctx2__.__ExceptionMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__ImportXmlException = null;
                if (__ctx1__ != null && __ctx1__.__ExceptionMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMsg);
                    __ctx1__.__ExceptionMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __condition__ = __ctx1__.__TechnicalErrorOccured;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 29;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.InError);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __condition__ = !__ctx1__.__businessRulesOK;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 39;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.NotValid);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[48],__eventData[14],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendBusinessErrors.SendMessage(0, __ctx1__.__BusinessValidationErrorsMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__BusinessValidationErrorsMsg);
                    __edata.PortName = @"SendBusinessErrors";
                    Tracker.FireEvent(__eventLocations[49],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __ctx1__.__NewFileStatusId = System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaFileStatusEnum.Pending);
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                Tracker.FireEvent(__eventLocations[51],__eventData[3],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__BusinessValidationErrorsMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__BusinessValidationErrorsMsg);
                    __ctx1__.__BusinessValidationErrorsMsg = null;
                }
                if (SendBusinessErrors != null)
                {
                    SendBusinessErrors.Close(__ctx1__, __seg__);
                    SendBusinessErrors = null;
                }
                Tracker.FireEvent(__eventLocations[53],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[54],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.subUpdateFileStatus(6, InstanceId, this);
                    _stateMgrs[6] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[54],new object[] {__ctx1__.__FileId, __ctx1__.__NewFileStatusId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[6]).Args;
                }
                Tracker.FireEvent(__eventLocations[55],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
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
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 50;
            case 50:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Transaction_Rules_4 __ctx4__ = (__Transaction_Rules_4)_stateMgrs[4];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            ____scope39_3 __ctx3__ = (____scope39_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__returnCode = __ctx1__.__returnCode;
                __ctx2__.__ExceptionMsg = __ctx1__.__ExceptionMsg;
                if (__ctx2__.__ExceptionMsg != null)
                    __ctx2__.RefMessage(__ctx2__.__ExceptionMsg);
                __ctx2__.__ImportXmlException = __ctx1__.__ImportXmlException;
                __ctx2__.__ExceptionDescription = __ctx1__.__ExceptionDescription;
                __ctx2__.__TechnicalErrorOccured = __ctx1__.__TechnicalErrorOccured;
                __ctx2__.__InnerExceptionDescription = __ctx1__.__InnerExceptionDescription;
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx3__ = new ____scope39_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __condition__ = __ctx2__.__returnCode < 0;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 9;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                throw __ctx2__.__ImportXmlException;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx4__ = new __Transaction_Rules_4(this);
                _stateMgrs[4] = __ctx4__;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx2__.StartContext(__seg__, __ctx4__);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[8],_stateMgrs[2].TrackDataStream );
                __ctx4__.Finally();
                if (__ctx4__ != null)
                    __ctx4__.__validationResult = null;
                if (__ctx4__ != null && __ctx4__.__BusinessValidationErrorsMsg != null)
                {
                    __ctx4__.UnrefMessage(__ctx4__.__BusinessValidationErrorsMsg);
                    __ctx4__.__BusinessValidationErrorsMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 16;
            case 16:
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
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            ____scope39_3 __ctx3__ = (____scope39_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx3__.__MedegaBulkLoader = default(Riziv.MedegaImport.Bulkloader.MedegaBulkloader);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx3__.__MedegaBulkLoader = new Riziv.MedegaImport.Bulkloader.MedegaBulkloader();
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx3__.__MedegaBulkLoader = new Riziv.MedegaImport.Bulkloader.MedegaBulkloader();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx3__.__MedegaBulkLoader.LoadGuardNodes(CreateMessageWrapperForUserCode(__ctx1__.__ImportGuard), __ctx1__.__FileId, System.Convert.ToInt32(MedegaImport.MedegaImportTypes.MedegaNodeStatus.ImportStarted));
                if (__ctx3__ != null)
                    __ctx3__.__MedegaBulkLoader = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx2__.__returnCode = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 9;
            case 9:
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
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            ____scope39_3 __ctx3__ = (____scope39_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_System_Xml_XmlDocument __ExceptionMsg = new __messagetype_System_Xml_XmlDocument("ExceptionMsg", __ctx2__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml("<exc>" + __ctx3__.__exc_0.Message + "</exc>");
                    __ExceptionMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);

                    if (__ctx2__.__ExceptionMsg != null)
                        __ctx2__.UnrefMessage(__ctx2__.__ExceptionMsg);
                    __ctx2__.__ExceptionMsg = __ExceptionMsg;
                    __ctx2__.RefMessage(__ctx2__.__ExceptionMsg);
                }
                __ctx2__.__ExceptionMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx2__.__ImportXmlException = __ctx3__.__exc_0;
                if (__ctx3__ != null)
                    __ctx3__.__exc_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx2__.__returnCode = -99;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx3__.__exv__ = null;
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[4];
            __Transaction_Rules_4 __ctx4__ = (__Transaction_Rules_4)_stateMgrs[4];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                if (__ctx4__.LockRead(0, _segments[5]) == false)  // __subImportGuardRecord_1.__FileId
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if (__ctx4__.LockWrite(1, _segments[5]) == false)  // __subImportGuardRecord_1.__validationResult
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if (__ctx4__.LockWrite(2, _segments[5]) == false)  // __subImportGuardRecord_1.__businessRulesOK
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if (__ctx4__.LockWrite(3, _segments[5]) == false)  // __subImportGuardRecord_1.__BusinessValidationErrorsMsg
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx4__.__nodeValidator = default(Riziv.HODMedega.Validator.MedegaNodeValidator);
                __ctx4__.__validationResult = (System.String)__ctx4__.SaveObject(__ctx1__.__validationResult, 0);
                __ctx4__.__businessRulesOK = __ctx1__.__businessRulesOK;
                __ctx4__.__BusinessValidationErrorsMsg = __ctx1__.__BusinessValidationErrorsMsg;
                if (__ctx4__.__BusinessValidationErrorsMsg != null)
                    __ctx4__.RefMessage(__ctx4__.__BusinessValidationErrorsMsg);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx4__.__nodeValidator = new Riziv.HODMedega.Validator.MedegaNodeValidator();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[2],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx4__.__nodeValidator = new Riziv.HODMedega.Validator.MedegaNodeValidator(RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.StrConn.Validator"));
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[3],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx4__.__businessRulesOK = __ctx4__.__nodeValidator.ValidateNodesOf(__ctx1__.__FileId, ref __ctx4__.__validationResult);
                if (__ctx4__ != null)
                    __ctx4__.__nodeValidator = null;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[4],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                {
                    BusinessValidationErrors __BusinessValidationErrorsMsg = new BusinessValidationErrors("BusinessValidationErrorsMsg", __ctx4__);

                    __BusinessValidationErrorsMsg.FileId.LoadFrom("FileId = " + System.Convert.ToString(__ctx1__.__FileId));
                    __BusinessValidationErrorsMsg.BusinessErrorMessages.LoadFrom(__ctx4__.__validationResult);

                    if (__ctx4__.__BusinessValidationErrorsMsg != null)
                        __ctx4__.UnrefMessage(__ctx4__.__BusinessValidationErrorsMsg);
                    __ctx4__.__BusinessValidationErrorsMsg = __BusinessValidationErrorsMsg;
                    __ctx4__.RefMessage(__ctx4__.__BusinessValidationErrorsMsg);
                }
                __ctx4__.__BusinessValidationErrorsMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx4__.__BusinessValidationErrorsMsg);
                    Tracker.FireEvent(__eventLocations[31],__edata,_stateMgrs[4].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx4__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx4__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment6(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[6];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __subImportGuardRecord_1 __ctx1__ = (__subImportGuardRecord_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[33],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx2__.__ExceptionDescription = __ctx2__.__ex_0.Message;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx2__.__TechnicalErrorOccured = true;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx2__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __condition__ = __ctx2__.__ex_0.InnerException != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 11;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx2__.__InnerExceptionDescription = __ctx2__.__ex_0.InnerException.Message;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 11:
                __ctx2__.__InnerExceptionDescription = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                Tracker.FireEvent(__eventLocations[37],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    Microsoft.XLANGs.Core.Service svc = new MedegaImport.HandleException(5, InstanceId, this);
                    _stateMgrs[5] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[38],new object[] {__ctx2__.__returnCode, __ctx1__.__Context, __ctx2__.__ExceptionMsg, __ctx2__.__ExceptionDescription, __ctx2__.__InnerExceptionDescription});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[5]).Args;
                    __ctx2__.__returnCode = (System.Int32)args[0];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx2__.__ExceptionMsg);
                    Tracker.FireEvent(__eventLocations[39],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 320 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\subUpdateFileStatus.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.SQLUpdateFileStatusPT)
        },
        new System.String[] {
            "SQLUpdateFileStatusPort"
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
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3fc4317f-1da1-40d5-9fae-26ac30649e2c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9dc52afc-c81e-4498-b06c-2d7973b06549</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
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
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8e725f7f-e30b-4176-8218-e5ae5460fdb1</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>826938a7-e710-4c57-aaba-d6e3da861d58</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9d510a57-ad17-481d-878f-9034cf97ca3a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b97f1e10-96d3-4be2-9e5b-4a7ab9ee30b6</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1eb838a1-fa23-48af-be6c-8b51da9f4526</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
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
<ActionName>'subUpdateFileStatus'</ActionName><IsAtomic>0</IsAtomic><Line>320</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>341</Line><Position>13</Position><ShapeID>'d03854a6-7efe-4636-8fd8-3d600361a80a'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope40'</ActionName><IsAtomic>0</IsAtomic><Line>351</Line><Position>13</Position><ShapeID>'fcf10cc0-d8ee-420a-b487-be7923b17d67'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>356</Line><Position>21</Position><ShapeID>'e8c4a390-66e8-4eb7-ba0f-ad8130b741da'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SQLUpdateFileStatusRequest</name><part>parameters</part><schema>MedegaImport.SQLUpdateFileStatus+SQLUpdateFileStatusRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>370</Line><Position>21</Position><ShapeID>'b2b09c60-85e6-4b6f-949e-1989c739e963'</ShapeID>
<Messages>
	<MsgInfo><name>SQLUpdateFileStatusRequest</name><part>parameters</part><schema>MedegaImport.SQLUpdateFileStatus+SQLUpdateFileStatusRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>372</Line><Position>21</Position><ShapeID>'362debb6-d721-448e-948a-29210b15133b'</ShapeID>
<Messages>
	<MsgInfo><name>SQLUpdateFileStatusResponse</name><part>parameters</part><schema>MedegaImport.SQLUpdateFileStatus+SQLUpdateFileStatusResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>377</Line><Position>21</Position><ShapeID>'40675d6c-ca14-4d89-80b8-49659e5065db'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>380</Line><Position>36</Position><ShapeID>'ce50523b-5571-46c0-ac17-8d85ea6090bc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>384</Line><Position>59</Position><ShapeID>'6cdf8d35-94be-4cff-9bce-5ad180fd4b13'</ShapeID>
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
    <om:Element Type='Module' OID='0c6ab1af-2c04-46a0-927a-37acfc98a931' LowerBound='1.1' HigherBound='91.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='9b7ed906-ebc5-438f-8274-7815c30466ae' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLUpdateFileStatusPT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='7c35e210-560e-4253-902b-ca0775357bfe' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0a08b423-8ab1-4ddd-a89d-beabc9d29a22' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.36'>
                    <om:Property Name='Ref' Value='MedegaImport.UpdateFileStatusRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='3341da8e-2cc0-4147-83bd-fe91d4bd9913' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.38' HigherBound='16.62'>
                    <om:Property Name='Ref' Value='MedegaImport.UpdateFileStatusResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='0472e4cc-8098-43d2-b82e-756edc6defa6' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='90.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subUpdateFileStatus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='793fc1e5-de1b-4dfc-907e-263591fbda86' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c800e7d9-53d5-4940-8f02-24952aeb2f34' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8a150708-59c5-478c-bb62-d9d7ca81329b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4b996d87-4345-4c3e-9c34-ddf7d5b19b13' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='47123ce7-424b-4170-a193-5015db6ba9a3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa835780-75be-44d0-837d-fd617b367106' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f3957024-f33b-4c71-82fa-f172f2b58feb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='2ec0deaa-8cc3-4462-a837-800d28c173e4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='MedegaImport.UpdateFileStatusRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateFileStatusRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d11b0cb4-6a2e-40e6-96e5-929819d0bb29' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='MedegaImport.UpdateFileStatusResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateFileStatusResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='257b4299-1b27-4ff2-bc6d-2776b9fc19aa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='f1e7b04c-bd8d-4b68-a278-522aed583db6' ParentLink='ServiceBody_Declaration' LowerBound='34.15' HigherBound='34.34'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FileId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='34e2f361-a03c-475f-acb8-e550e60427ed' ParentLink='ServiceBody_Declaration' LowerBound='34.36' HigherBound='34.57'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatusId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d03854a6-7efe-4636-8fd8-3d600361a80a' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='50.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='f6c5147b-21b1-429b-9aaa-544631c7d8f5' ParentLink='Construct_MessageRef' LowerBound='41.23' HigherBound='41.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='aec8b1f3-7b53-4a27-bf1f-d6285d596e55' ParentLink='Construct_MessageRef' LowerBound='41.32' HigherBound='41.38'>
                        <om:Property Name='Ref' Value='ErrMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='864fcc0d-cc9f-4dd0-b428-b511453636b7' ParentLink='ComplexStatement_Statement' LowerBound='43.1' HigherBound='49.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ErrMsg = tempXmlDoc;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='fcf10cc0-d8ee-420a-b487-be7923b17d67' ParentLink='ServiceBody_Statement' LowerBound='50.1' HigherBound='88.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='e8c4a390-66e8-4eb7-ba0f-ad8130b741da' ParentLink='ComplexStatement_Statement' LowerBound='55.1' HigherBound='69.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Create UpdateFileStatusRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='3fc4317f-1da1-40d5-9fae-26ac30649e2c' ParentLink='Construct_MessageRef' LowerBound='56.31' HigherBound='56.38'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='9dc52afc-c81e-4498-b06c-2d7973b06549' ParentLink='Construct_MessageRef' LowerBound='56.40' HigherBound='56.66'>
                            <om:Property Name='Ref' Value='SQLUpdateFileStatusRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='cc1d86cf-45f2-4401-b8dd-03d45b5cc268' ParentLink='ComplexStatement_Statement' LowerBound='58.1' HigherBound='68.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempString = System.String.Format(&quot;&lt;ns0:SQLUpdateFileStatusRequest xmlns:ns0=\&quot;http://inami-riziv.fgov.be.medega\&quot;&gt;&lt;ns0:sp_UpdateMedegaFileStatus FileId=\&quot;{0}\&quot; FileStatus=\&quot;{1}\&quot; /&gt;&lt;/ns0:SQLUpdateFileStatusRequest&gt;&quot;&#xD;&#xA;    , FileId, StatusId);&#xD;&#xA;&#xD;&#xA;tempXmlDoc.LoadXml(tempString);&#xD;&#xA;SQLUpdateFileStatusRequest.parameters = tempXmlDoc;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;Context = SQLUpdateFileStatusRequest.parameters;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='b2b09c60-85e6-4b6f-949e-1989c739e963' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                        <om:Property Name='PortName' Value='SQLUpdateFileStatusPort' />
                        <om:Property Name='MessageName' Value='SQLUpdateFileStatusRequest' />
                        <om:Property Name='OperationName' Value='procedure' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='UpdateFileStatus' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='362debb6-d721-448e-948a-29210b15133b' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='SQLUpdateFileStatusPort' />
                        <om:Property Name='MessageName' Value='SQLUpdateFileStatusResponse' />
                        <om:Property Name='OperationName' Value='procedure' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive DB2 Response' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='40675d6c-ca14-4d89-80b8-49659e5065db' ParentLink='Scope_Catch' LowerBound='76.1' HigherBound='86.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='ce50523b-5571-46c0-ac17-8d85ea6090bc' ParentLink='Catch_Statement' LowerBound='79.1' HigherBound='83.1'>
                            <om:Property Name='Expression' Value='returnCode = -1;&#xD;&#xA;ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set ex' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='6cdf8d35-94be-4cff-9bce-5ad180fd4b13' ParentLink='Catch_Statement' LowerBound='83.1' HigherBound='85.1'>
                            <om:Property Name='Identifier' Value='HandleXmlException' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='HandleXmlException' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='8e725f7f-e30b-4176-8218-e5ae5460fdb1' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='returnCode' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='826938a7-e710-4c57-aaba-d6e3da861d58' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9d510a57-ad17-481d-878f-9034cf97ca3a' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ErrMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b97f1e10-96d3-4be2-9e5b-4a7ab9ee30b6' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='1eb838a1-fa23-48af-be6c-8b51da9f4526' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d483f726-4335-4141-8150-424c7df99162' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='29' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='MedegaImport.SQLUpdateFileStatusPT' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateFileStatusPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='a172bbba-4127-49dc-9262-460e451351fd' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d86ac5e2-f334-4090-aad2-72f045110eab' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='UpdateFileStatusResponse' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='bf96a2ae-d3b5-4c19-bb39-53faf642a6b1' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='147b7128-da90-4c5c-bdec-cace0e01ba65' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='UpdateFileStatusRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='29981fad-78af-4f3c-8cab-c9243ac9528b' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLUpdateFileStatus.SQLUpdateFileStatusRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
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

                if (__svc__.SQLUpdateFileStatusPort != null)
                {
                    __svc__.SQLUpdateFileStatusPort.Close(this, null);
                    __svc__.SQLUpdateFileStatusPort = null;
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
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tempString = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrMsg")]
            public __messagetype_System_Xml_XmlDocument __ErrMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateFileStatusRequest")]
            internal UpdateFileStatusRequest __SQLUpdateFileStatusRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateFileStatusResponse")]
            internal UpdateFileStatusResponse __SQLUpdateFileStatusResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempString")]
            internal System.String __tempString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileId")]
            internal System.Int32 __FileId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusId")]
            internal System.Int32 __StatusId;
        }


        [System.SerializableAttribute]
        public class ____scope40_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope40_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope40")
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
                ____scope40_2 __ctx2__ = (____scope40_2)(__svc__._stateMgrs[2]);
                __subUpdateFileStatus_1 __ctx1__ = (__subUpdateFileStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__SQLUpdateFileStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusResponse);
                    __ctx1__.__SQLUpdateFileStatusResponse = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateFileStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusRequest);
                    __ctx1__.__SQLUpdateFileStatusRequest = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
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
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateFileStatusPort")]
        internal SQLUpdateFileStatusPT SQLUpdateFileStatusPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLUpdateFileStatusPT.procedure},
                                               typeof(subUpdateFileStatus).GetField("SQLUpdateFileStatusPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subUpdateFileStatus), "SQLUpdateFileStatusPort"),
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,2,2,3,4,4,4,20,1,1,1,1,};
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
                SQLUpdateFileStatusPort = new SQLUpdateFileStatusPT(0, this);
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
            ____scope40_2 __ctx2__ = (____scope40_2)_stateMgrs[2];
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
                __ctx1__.__tempString = default(System.String);
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
                __ctx1__.__tempString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
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
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__ = new ____scope40_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
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
                if (SQLUpdateFileStatusPort != null)
                {
                    SQLUpdateFileStatusPort.Close(__ctx1__, __seg__);
                    SQLUpdateFileStatusPort = null;
                }
                Tracker.FireEvent(__eventLocations[20],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 17;
            case 17:
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
            ____scope40_2 __ctx2__ = (____scope40_2)_stateMgrs[2];
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
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    UpdateFileStatusRequest __SQLUpdateFileStatusRequest = new UpdateFileStatusRequest("SQLUpdateFileStatusRequest", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempString = System.String.Format("<ns0:SQLUpdateFileStatusRequest xmlns:ns0=\"http://inami-riziv.fgov.be.medega\"><ns0:sp_UpdateMedegaFileStatus FileId=\"{0}\" FileStatus=\"{1}\" /></ns0:SQLUpdateFileStatusRequest>", __ctx1__.__FileId, __ctx1__.__StatusId);
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml(__ctx1__.__tempString);
                    __SQLUpdateFileStatusRequest.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __Context.part.CopyFrom(__SQLUpdateFileStatusRequest.parameters);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__SQLUpdateFileStatusRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusRequest);
                    __ctx1__.__SQLUpdateFileStatusRequest = __SQLUpdateFileStatusRequest;
                    __ctx1__.RefMessage(__ctx1__.__SQLUpdateFileStatusRequest);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__SQLUpdateFileStatusRequest.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateFileStatusRequest);
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
                SQLUpdateFileStatusPort.SendMessage(0, __ctx1__.__SQLUpdateFileStatusRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateFileStatusRequest);
                    __edata.PortName = @"SQLUpdateFileStatusPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateFileStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusRequest);
                    __ctx1__.__SQLUpdateFileStatusRequest = null;
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
                if (!SQLUpdateFileStatusPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__SQLUpdateFileStatusResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusResponse);
                __ctx1__.__SQLUpdateFileStatusResponse = new UpdateFileStatusResponse("SQLUpdateFileStatusResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SQLUpdateFileStatusResponse);
                SQLUpdateFileStatusPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__SQLUpdateFileStatusResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateFileStatusResponse);
                    __edata.PortName = @"SQLUpdateFileStatusPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateFileStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateFileStatusResponse);
                    __ctx1__.__SQLUpdateFileStatusResponse = null;
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
            ____scope40_2 __ctx2__ = (____scope40_2)_stateMgrs[2];
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{E84ADCD1-40BC-42C3-BBC6-2130B94707C8}"))
        };

    }
    //#line 328 "D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\MedegaImport\Orchestrations\subUpdateNodeStatus.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MedegaImport.SQLUpdateNodeStatusPT)
        },
        new System.String[] {
            "SQLUpdateNodeStatusPort"
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
    sealed internal class subUpdateNodeStatus : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int64 NodeId,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 StatusId,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String ReasonOfFailure)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(subUpdateNodeStatus));
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

        static subUpdateNodeStatus()
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
            _rootContext = new __subUpdateNodeStatus_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public subUpdateNodeStatus(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "subUpdateNodeStatus", tracker)
        {
            ConstructorHelper();
        }

        public subUpdateNodeStatus(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "subUpdateNodeStatus")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>257b4299-1b27-4ff2-bc6d-2776b9fc19aa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>f1e7b04c-bd8d-4b68-a278-522aed583db6</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>NodeId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>34e2f361-a03c-475f-acb8-e550e60427ed</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>StatusId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>172fdb53-36f6-4888-ab24-143b3f62805c</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ReasonOfFailure</shapeText>                  
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
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3fc4317f-1da1-40d5-9fae-26ac30649e2c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9dc52afc-c81e-4498-b06c-2d7973b06549</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
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
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>40675d6c-ca14-4d89-80b8-49659e5065db</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>Catch System.Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ce50523b-5571-46c0-ac17-8d85ea6090bc</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set ex</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>6cdf8d35-94be-4cff-9bce-5ad180fd4b13</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>HandleXmlException</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8e725f7f-e30b-4176-8218-e5ae5460fdb1</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>returnCode</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>826938a7-e710-4c57-aaba-d6e3da861d58</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Context</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9d510a57-ad17-481d-878f-9034cf97ca3a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ErrMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b97f1e10-96d3-4be2-9e5b-4a7ab9ee30b6</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ExceptionDescription</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1eb838a1-fa23-48af-be6c-8b51da9f4526</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>InnerExceptionDescription</shapeText>                  
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
<ActionName>'subUpdateNodeStatus'</ActionName><IsAtomic>0</IsAtomic><Line>328</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>348</Line><Position>13</Position><ShapeID>'d03854a6-7efe-4636-8fd8-3d600361a80a'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ErrMsg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope41'</ActionName><IsAtomic>0</IsAtomic><Line>358</Line><Position>13</Position><ShapeID>'fcf10cc0-d8ee-420a-b487-be7923b17d67'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>363</Line><Position>21</Position><ShapeID>'e8c4a390-66e8-4eb7-ba0f-ad8130b741da'</ShapeID>
<Messages>
	<MsgInfo><name>Context</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>SQLUpdateNodeStatusRequest</name><part>parameters</part><schema>MedegaImport.SQLUpdateNodeStatus+UpdateNodeStatusRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>376</Line><Position>21</Position><ShapeID>'b2b09c60-85e6-4b6f-949e-1989c739e963'</ShapeID>
<Messages>
	<MsgInfo><name>SQLUpdateNodeStatusRequest</name><part>parameters</part><schema>MedegaImport.SQLUpdateNodeStatus+UpdateNodeStatusRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>378</Line><Position>21</Position><ShapeID>'362debb6-d721-448e-948a-29210b15133b'</ShapeID>
<Messages>
	<MsgInfo><name>SQLUpdateNodeStatusResponse</name><part>parameters</part><schema>MedegaImport.SQLUpdateNodeStatus+UpdateNodeStatusResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>383</Line><Position>21</Position><ShapeID>'40675d6c-ca14-4d89-80b8-49659e5065db'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>386</Line><Position>36</Position><ShapeID>'ce50523b-5571-46c0-ac17-8d85ea6090bc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>390</Line><Position>59</Position><ShapeID>'6cdf8d35-94be-4cff-9bce-5ad180fd4b13'</ShapeID>
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
    <om:Element Type='Module' OID='0c6ab1af-2c04-46a0-927a-37acfc98a931' LowerBound='1.1' HigherBound='89.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MedegaImport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='07d52c78-cb1b-475b-9e8e-11d9c41c769a' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLUpdateNodeStatusPT' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='1484546d-f97f-4fec-a1fb-55a8bdc54608' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='494a55d1-3ac2-4767-a98f-27c877decc79' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.38' HigherBound='16.62'>
                    <om:Property Name='Ref' Value='MedegaImport.UpdateNodeStatusResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='529587fb-24eb-4177-b65e-cd48a8e80f0f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.36'>
                    <om:Property Name='Ref' Value='MedegaImport.UpdateNodeStatusRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='0472e4cc-8098-43d2-b82e-756edc6defa6' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='88.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='subUpdateNodeStatus' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='793fc1e5-de1b-4dfc-907e-263591fbda86' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InnerExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c800e7d9-53d5-4940-8f02-24952aeb2f34' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionDescription' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8a150708-59c5-478c-bb62-d9d7ca81329b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempXmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4b996d87-4345-4c3e-9c34-ddf7d5b19b13' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='returnCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='47123ce7-424b-4170-a193-5015db6ba9a3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tempString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa835780-75be-44d0-837d-fd617b367106' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Context' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f3957024-f33b-4c71-82fa-f172f2b58feb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='2ec0deaa-8cc3-4462-a837-800d28c173e4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='MedegaImport.UpdateNodeStatusRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateNodeStatusRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d11b0cb4-6a2e-40e6-96e5-929819d0bb29' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='MedegaImport.UpdateNodeStatusResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateNodeStatusResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='257b4299-1b27-4ff2-bc6d-2776b9fc19aa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='f1e7b04c-bd8d-4b68-a278-522aed583db6' ParentLink='ServiceBody_Declaration' LowerBound='33.15' HigherBound='33.34'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int64' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='NodeId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='34e2f361-a03c-475f-acb8-e550e60427ed' ParentLink='ServiceBody_Declaration' LowerBound='33.36' HigherBound='33.57'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatusId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='172fdb53-36f6-4888-ab24-143b3f62805c' ParentLink='ServiceBody_Declaration' LowerBound='33.59' HigherBound='33.88'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReasonOfFailure' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d03854a6-7efe-4636-8fd8-3d600361a80a' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='49.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Initialize' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='f6c5147b-21b1-429b-9aaa-544631c7d8f5' ParentLink='Construct_MessageRef' LowerBound='40.23' HigherBound='40.30'>
                        <om:Property Name='Ref' Value='Context' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='aec8b1f3-7b53-4a27-bf1f-d6285d596e55' ParentLink='Construct_MessageRef' LowerBound='40.32' HigherBound='40.38'>
                        <om:Property Name='Ref' Value='ErrMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='864fcc0d-cc9f-4dd0-b428-b511453636b7' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='48.1'>
                        <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempXmlDoc.LoadXml(&quot;&lt;empty/&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Context = tempXmlDoc;&#xD;&#xA;ErrMsg = tempXmlDoc;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Initialize' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='fcf10cc0-d8ee-420a-b487-be7923b17d67' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='86.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Try' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='e8c4a390-66e8-4eb7-ba0f-ad8130b741da' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='67.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Create UpdateFileStatusRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='3fc4317f-1da1-40d5-9fae-26ac30649e2c' ParentLink='Construct_MessageRef' LowerBound='55.31' HigherBound='55.38'>
                            <om:Property Name='Ref' Value='Context' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='9dc52afc-c81e-4498-b06c-2d7973b06549' ParentLink='Construct_MessageRef' LowerBound='55.40' HigherBound='55.66'>
                            <om:Property Name='Ref' Value='SQLUpdateNodeStatusRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='cc1d86cf-45f2-4401-b8dd-03d45b5cc268' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='66.1'>
                            <om:Property Name='Expression' Value='tempXmlDoc= new System.Xml.XmlDocument();&#xD;&#xA;tempString = System.String.Format(&quot;&lt;ns0:UpdateNodeStatusRequest xmlns:ns0=\&quot;http://inami-riziv.fgov.be.medega\&quot;&gt;&lt;ns0:sp_UpdateMedegaXmlNodeStatus NodeId=\&quot;{0}\&quot; NodeStatus=\&quot;{1}\&quot; ReasonOfFailure=\&quot;{2}\&quot; /&gt;&lt;/ns0:UpdateNodeStatusRequest&gt;&quot;, NodeId, StatusId, ReasonOfFailure);&#xD;&#xA;&#xD;&#xA;tempXmlDoc.LoadXml(tempString);&#xD;&#xA;SQLUpdateNodeStatusRequest.parameters = tempXmlDoc;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;Context = SQLUpdateNodeStatusRequest.parameters;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='b2b09c60-85e6-4b6f-949e-1989c739e963' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='69.1'>
                        <om:Property Name='PortName' Value='SQLUpdateNodeStatusPort' />
                        <om:Property Name='MessageName' Value='SQLUpdateNodeStatusRequest' />
                        <om:Property Name='OperationName' Value='procedure' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='UpdateFileStatus' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='362debb6-d721-448e-948a-29210b15133b' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='SQLUpdateNodeStatusPort' />
                        <om:Property Name='MessageName' Value='SQLUpdateNodeStatusResponse' />
                        <om:Property Name='OperationName' Value='procedure' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive DB2 Response' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='40675d6c-ca14-4d89-80b8-49659e5065db' ParentLink='Scope_Catch' LowerBound='74.1' HigherBound='84.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Catch System.Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='ce50523b-5571-46c0-ac17-8d85ea6090bc' ParentLink='Catch_Statement' LowerBound='77.1' HigherBound='81.1'>
                            <om:Property Name='Expression' Value='returnCode = -1;&#xD;&#xA;ExceptionDescription = ex.Message;&#xD;&#xA;InnerExceptionDescription = &quot;&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set ex' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='6cdf8d35-94be-4cff-9bce-5ad180fd4b13' ParentLink='Catch_Statement' LowerBound='81.1' HigherBound='83.1'>
                            <om:Property Name='Identifier' Value='HandleXmlException' />
                            <om:Property Name='Invokee' Value='MedegaImport.HandleException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='HandleXmlException' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='8e725f7f-e30b-4176-8218-e5ae5460fdb1' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='Ref' />
                                <om:Property Name='Name' Value='returnCode' />
                                <om:Property Name='Type' Value='System.Int32' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='826938a7-e710-4c57-aaba-d6e3da861d58' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Context' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='9d510a57-ad17-481d-878f-9034cf97ca3a' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ErrMsg' />
                                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b97f1e10-96d3-4be2-9e5b-4a7ab9ee30b6' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='1eb838a1-fa23-48af-be6c-8b51da9f4526' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='InnerExceptionDescription' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='db46605f-7dfa-4158-bb28-07f4382fa9ae' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='29' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MedegaImport.SQLUpdateNodeStatusPT' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLUpdateNodeStatusPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='013c4041-a20f-4846-8f28-2929cc430e3c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='c6943550-bd92-45f7-a228-c7821651762c' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='UpdateNodeStatusResponse' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='77e5fafe-347e-4055-be67-febef8745720' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='e6400555-2952-4f82-8071-9865d3fb36ac' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='UpdateNodeStatusRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='dc771119-563b-44e3-bbb6-d0446c8daae9' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MedegaImport.SQLUpdateNodeStatus.UpdateNodeStatusRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __subUpdateNodeStatus_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __subUpdateNodeStatus_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subUpdateNodeStatus")
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
                subUpdateNodeStatus __svc__ = (subUpdateNodeStatus)_service;
                __subUpdateNodeStatus_root_0 __ctx0__ = (__subUpdateNodeStatus_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SQLUpdateNodeStatusPort != null)
                {
                    __svc__.SQLUpdateNodeStatusPort.Close(this, null);
                    __svc__.SQLUpdateNodeStatusPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __subUpdateNodeStatus_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __subUpdateNodeStatus_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "subUpdateNodeStatus")
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
                subUpdateNodeStatus __svc__ = (subUpdateNodeStatus)_service;
                __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__ReasonOfFailure = null;
                if (__ctx1__ != null)
                    __ctx1__.__tempString = null;
                if (__ctx1__ != null)
                    __ctx1__.__InnerExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__Context != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tempXmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__ExceptionDescription = null;
                if (__ctx1__ != null && __ctx1__.__ErrMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrMsg);
                    __ctx1__.__ErrMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Context")]
            public __messagetype_System_Xml_XmlDocument __Context;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrMsg")]
            public __messagetype_System_Xml_XmlDocument __ErrMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateNodeStatusRequest")]
            internal UpdateNodeStatusRequest __SQLUpdateNodeStatusRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateNodeStatusResponse")]
            internal UpdateNodeStatusResponse __SQLUpdateNodeStatusResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InnerExceptionDescription")]
            internal System.String __InnerExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionDescription")]
            internal System.String __ExceptionDescription;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempXmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __tempXmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("returnCode")]
            internal System.Int32 __returnCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tempString")]
            internal System.String __tempString;
            [Microsoft.XLANGs.Core.UserVariableAttribute("NodeId")]
            internal System.Int64 __NodeId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusId")]
            internal System.Int32 __StatusId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ReasonOfFailure")]
            internal System.String __ReasonOfFailure;
        }


        [System.SerializableAttribute]
        public class ____scope41_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope41_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope41")
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
                subUpdateNodeStatus __svc__ = (subUpdateNodeStatus)_service;
                ____scope41_2 __ctx2__ = (____scope41_2)(__svc__._stateMgrs[2]);
                __subUpdateNodeStatus_root_0 __ctx0__ = (__subUpdateNodeStatus_root_0)(__svc__._stateMgrs[0]);
                __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateNodeStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusResponse);
                    __ctx1__.__SQLUpdateNodeStatusResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateNodeStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusRequest);
                    __ctx1__.__SQLUpdateNodeStatusRequest = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLUpdateNodeStatusPort")]
        internal SQLUpdateNodeStatusPT SQLUpdateNodeStatusPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLUpdateNodeStatusPT.procedure},
                                               typeof(subUpdateNodeStatus).GetField("SQLUpdateNodeStatusPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(subUpdateNodeStatus), "SQLUpdateNodeStatusPort"),
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,2,2,3,4,4,4,20,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,8,9,10,10,11,11,11,11,};
        public static int[] __progressLocation3 = new int[] { 12,12,13,13,14,14,14,17,17,18,19,19,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __subUpdateNodeStatus_root_0 __ctx0__ = (__subUpdateNodeStatus_root_0)_stateMgrs[0];
            __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                SQLUpdateNodeStatusPort = new SQLUpdateNodeStatusPT(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __subUpdateNodeStatus_1(this);
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
            ____scope41_2 __ctx2__ = (____scope41_2)_stateMgrs[2];
            __subUpdateNodeStatus_root_0 __ctx0__ = (__subUpdateNodeStatus_root_0)_stateMgrs[0];
            __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__NodeId = (System.Int64)Args[0];
                __ctx1__.__StatusId = (System.Int32)Args[1];
                __ctx1__.__ReasonOfFailure = (System.String)Args[2];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__InnerExceptionDescription = default(System.String);
                __ctx1__.__ExceptionDescription = default(System.String);
                __ctx1__.__tempXmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__returnCode = default(System.Int32);
                __ctx1__.__tempString = default(System.String);
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
                __ctx1__.__tempString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
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
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__ErrMsg);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__ = new ____scope41_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__ReasonOfFailure = null;
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
                if (SQLUpdateNodeStatusPort != null)
                {
                    SQLUpdateNodeStatusPort.Close(__ctx1__, __seg__);
                    SQLUpdateNodeStatusPort = null;
                }
                Tracker.FireEvent(__eventLocations[20],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 17;
            case 17:
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
            ____scope41_2 __ctx2__ = (____scope41_2)_stateMgrs[2];
            __subUpdateNodeStatus_root_0 __ctx0__ = (__subUpdateNodeStatus_root_0)_stateMgrs[0];
            __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)_stateMgrs[1];

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
                    __messagetype_System_Xml_XmlDocument __Context = new __messagetype_System_Xml_XmlDocument("Context", __ctx1__);
                    UpdateNodeStatusRequest __SQLUpdateNodeStatusRequest = new UpdateNodeStatusRequest("SQLUpdateNodeStatusRequest", __ctx1__);

                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__tempString = System.String.Format("<ns0:UpdateNodeStatusRequest xmlns:ns0=\"http://inami-riziv.fgov.be.medega\"><ns0:sp_UpdateMedegaXmlNodeStatus NodeId=\"{0}\" NodeStatus=\"{1}\" ReasonOfFailure=\"{2}\" /></ns0:UpdateNodeStatusRequest>", __ctx1__.__NodeId, __ctx1__.__StatusId, __ctx1__.__ReasonOfFailure);
                    __ctx1__.__tempXmlDoc.UnderlyingXmlDocument.LoadXml(__ctx1__.__tempString);
                    __SQLUpdateNodeStatusRequest.parameters.LoadFrom((System.Xml.XmlDocument)__ctx1__.__tempXmlDoc.UnderlyingXmlDocument);
                    __Context.part.CopyFrom(__SQLUpdateNodeStatusRequest.parameters);

                    if (__ctx1__.__Context != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Context);
                    __ctx1__.__Context = __Context;
                    __ctx1__.RefMessage(__ctx1__.__Context);
                    if (__ctx1__.__SQLUpdateNodeStatusRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusRequest);
                    __ctx1__.__SQLUpdateNodeStatusRequest = __SQLUpdateNodeStatusRequest;
                    __ctx1__.RefMessage(__ctx1__.__SQLUpdateNodeStatusRequest);
                }
                __ctx1__.__Context.ConstructionCompleteEvent(false);
                __ctx1__.__SQLUpdateNodeStatusRequest.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Context);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateNodeStatusRequest);
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
                SQLUpdateNodeStatusPort.SendMessage(0, __ctx1__.__SQLUpdateNodeStatusRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateNodeStatusRequest);
                    __edata.PortName = @"SQLUpdateNodeStatusPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateNodeStatusRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusRequest);
                    __ctx1__.__SQLUpdateNodeStatusRequest = null;
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
                if (!SQLUpdateNodeStatusPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__SQLUpdateNodeStatusResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusResponse);
                __ctx1__.__SQLUpdateNodeStatusResponse = new UpdateNodeStatusResponse("SQLUpdateNodeStatusResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__SQLUpdateNodeStatusResponse);
                SQLUpdateNodeStatusPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__SQLUpdateNodeStatusResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__SQLUpdateNodeStatusResponse);
                    __edata.PortName = @"SQLUpdateNodeStatusPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SQLUpdateNodeStatusResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SQLUpdateNodeStatusResponse);
                    __ctx1__.__SQLUpdateNodeStatusResponse = null;
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
            ____scope41_2 __ctx2__ = (____scope41_2)_stateMgrs[2];
            __subUpdateNodeStatus_1 __ctx1__ = (__subUpdateNodeStatus_1)_stateMgrs[1];

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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{637DFAE4-E288-44AB-A60A-1ACC57DEEA3F}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
