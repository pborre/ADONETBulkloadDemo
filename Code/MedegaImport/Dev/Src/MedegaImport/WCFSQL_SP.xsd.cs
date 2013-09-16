namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InsertGuard", @"InsertGuardResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.WCFSQL_dbo", typeof(global::MedegaImport.WCFSQL_dbo))]
    public sealed class WCFSQL_SP : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://sp"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" targetNamespace=""http://sp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MedegaImport.WCFSQL_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""InsertGuard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:sp_CreateMedegaXmlNode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InsertGuardResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:sp_CreateMedegaXmlNodeResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public WCFSQL_SP() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "InsertGuard";
                _RootElements[1] = "InsertGuardResponse";
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
        
        [Schema(@"http://sp",@"InsertGuard")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertGuard"})]
        public sealed class InsertGuard : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertGuard() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertGuard";
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
        
        [Schema(@"http://sp",@"InsertGuardResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertGuardResponse"})]
        public sealed class InsertGuardResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertGuardResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertGuardResponse";
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
