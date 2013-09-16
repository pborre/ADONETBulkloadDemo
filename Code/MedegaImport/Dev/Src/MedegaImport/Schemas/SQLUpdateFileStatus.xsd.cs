namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SQLUpdateFileStatusRequest", @"SQLUpdateFileStatusResponse"})]
    public sealed class SQLUpdateFileStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_UpdateMedegaFileStatus] @FileId=&quot; &quot;, @FileStatus=&quot; &quot;"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SQLUpdateFileStatusRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sp_UpdateMedegaFileStatus"">
          <xs:complexType>
            <xs:attribute name=""FileId"" type=""xs:int"" />
            <xs:attribute name=""FileStatus"" type=""xs:int"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SQLUpdateFileStatusResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SQLUpdateFileStatus() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SQLUpdateFileStatusRequest";
                _RootElements[1] = "SQLUpdateFileStatusResponse";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"SQLUpdateFileStatusRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SQLUpdateFileStatusRequest"})]
        public sealed class SQLUpdateFileStatusRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SQLUpdateFileStatusRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SQLUpdateFileStatusRequest";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"SQLUpdateFileStatusResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SQLUpdateFileStatusResponse"})]
        public sealed class SQLUpdateFileStatusResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SQLUpdateFileStatusResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SQLUpdateFileStatusResponse";
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
