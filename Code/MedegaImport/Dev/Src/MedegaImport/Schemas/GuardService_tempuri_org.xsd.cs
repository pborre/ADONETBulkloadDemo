namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CreateGuard", @"CreateGuardResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardrequest", typeof(global::MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardrequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardresult", typeof(global::MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardresult))]
    public sealed class GuardService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardrequest"" namespace=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"" />
  <xs:import schemaLocation=""MedegaImport.GuardService_riziv_fgov_be_hodmedega_importmedegaguardresult"" namespace=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"" />
        <reference targetNamespace=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CreateGuard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"" minOccurs=""0"" name=""medegaGuardRequest"" nillable=""true"" type=""q1:ImportMedegaGuardRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateGuardResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" minOccurs=""0"" name=""CreateGuardResult"" nillable=""true"" type=""q2:ImportMedegaGuardResult"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GuardService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "CreateGuard";
                _RootElements[1] = "CreateGuardResponse";
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
        
        [Schema(@"http://tempuri.org/",@"CreateGuard")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateGuard"})]
        public sealed class CreateGuard : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateGuard() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateGuard";
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
        
        [Schema(@"http://tempuri.org/",@"CreateGuardResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateGuardResponse"})]
        public sealed class CreateGuardResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateGuardResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateGuardResponse";
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
