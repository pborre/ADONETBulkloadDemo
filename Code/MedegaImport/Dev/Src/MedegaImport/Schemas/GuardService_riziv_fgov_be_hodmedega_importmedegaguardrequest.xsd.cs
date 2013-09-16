namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://riziv.fgov.be/hodmedega/importmedegaguardrequest",@"ImportMedegaGuardRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ImportMedegaGuardRequest"})]
    public sealed class GuardService_riziv_fgov_be_hodmedega_importmedegaguardrequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"" elementFormDefault=""qualified"" targetNamespace=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ImportMedegaGuardRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BankAccountNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""FileId"" type=""xs:long"" />
      <xs:element minOccurs=""0"" name=""FirstName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GeographicEntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GuardDate"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GuardEndTime"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GuardStartTime"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LastName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""NisCode"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResponsableFirstName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResponsableLastName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResponsableRizivNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""RizivNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ValidationError"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""XmlNodeId"" type=""xs:long"" />
      <xs:element minOccurs=""0"" name=""ZipCode"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ZoneId"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ZoneName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ImportMedegaGuardRequest"" nillable=""true"" type=""tns:ImportMedegaGuardRequest"" />
</xs:schema>";
        
        public GuardService_riziv_fgov_be_hodmedega_importmedegaguardrequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ImportMedegaGuardRequest";
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
