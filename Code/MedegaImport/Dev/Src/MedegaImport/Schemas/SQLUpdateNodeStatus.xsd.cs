namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UpdateNodeStatusRequest", @"UpdateNodeStatusResponse"})]
    public sealed class SQLUpdateNodeStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_UpdateMedegaXmlNodeStatus] @NodeId=NULL, @NodeStatus=NULL, @ReasonOfFailure=NULL"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""UpdateNodeStatusRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sp_UpdateMedegaXmlNodeStatus"">
          <xs:complexType>
            <xs:attribute name=""NodeId"" type=""xs:int"" />
            <xs:attribute name=""NodeStatus"" type=""xs:int"" />
            <xs:attribute name=""ReasonOfFailure"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UpdateNodeStatusResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SQLUpdateNodeStatus() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "UpdateNodeStatusRequest";
                _RootElements[1] = "UpdateNodeStatusResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"UpdateNodeStatusRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UpdateNodeStatusRequest"})]
        public sealed class UpdateNodeStatusRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UpdateNodeStatusRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UpdateNodeStatusRequest";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"UpdateNodeStatusResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UpdateNodeStatusResponse"})]
        public sealed class UpdateNodeStatusResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UpdateNodeStatusResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UpdateNodeStatusResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
