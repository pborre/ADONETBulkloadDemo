namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CreateMedegaFileRequest", @"CreateMedegaFileResponse"})]
    public sealed class SQLCreateMedegaFile : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_BTSCreateMedegaFile] @FileName=&quot; &quot;, @FileStatus=&quot; &quot;"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CreateMedegaFileRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sp_BTSCreateMedegaFile"">
          <xs:complexType>
            <xs:attribute name=""FileName"" type=""xs:string"" />
            <xs:attribute name=""FileStatus"" type=""xs:int"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateMedegaFileResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SQLCreateMedegaFile() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "CreateMedegaFileRequest";
                _RootElements[1] = "CreateMedegaFileResponse";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"CreateMedegaFileRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateMedegaFileRequest"})]
        public sealed class CreateMedegaFileRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateMedegaFileRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateMedegaFileRequest";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"CreateMedegaFileResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateMedegaFileResponse"})]
        public sealed class CreateMedegaFileResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateMedegaFileResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateMedegaFileResponse";
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
