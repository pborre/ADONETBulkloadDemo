namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://riziv.fgov.be/hodmedega/importmedegaguardresult",@"ImportMedegaGuardResult")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ImportMedegaGuardResult"})]
    public sealed class GuardService_riziv_fgov_be_hodmedega_importmedegaguardresult : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" elementFormDefault=""qualified"" targetNamespace=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ImportMedegaGuardResult"">
    <xs:sequence>
      <xs:element name=""FailureCode"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""FailureDescription"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""FileId"" type=""xs:long"" />
      <xs:element name=""GuardStatus"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ImportMedegaGuardResult"" nillable=""true"" type=""tns:ImportMedegaGuardResult"" />
</xs:schema>";
        
        public GuardService_riziv_fgov_be_hodmedega_importmedegaguardresult() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ImportMedegaGuardResult";
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
