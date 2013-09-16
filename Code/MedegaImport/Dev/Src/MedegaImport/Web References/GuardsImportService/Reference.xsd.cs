namespace MedegaImport.GuardsImportService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ImportMedegaGuardResult", @"GuardStates", @"ImportMedegaGuardRequest"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://riziv.fgov.be/GuardsImportService"" elementFormDefault=""qualified"" targetNamespace=""http://riziv.fgov.be/GuardsImportService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ImportMedegaGuardResult"" nillable=""true"" type=""tns:ImportMedegaGuardResult"" />
  <xs:complexType name=""ImportMedegaGuardResult"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PeriodId"" type=""xs:long"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""FileId"" type=""xs:long"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""GuardStatus"" type=""tns:GuardStates"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FailureDescription"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FailureCode"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:simpleType name=""GuardStates"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Imported"" />
      <xs:enumeration value=""Overlapping"" />
      <xs:enumeration value=""New"" />
      <xs:enumeration value=""Error"" />
      <xs:enumeration value=""Paid"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GuardStates"" type=""tns:GuardStates"" />
  <xs:element name=""ImportMedegaGuardRequest"" nillable=""true"" type=""tns:ImportMedegaGuardRequest"" />
  <xs:complexType name=""ImportMedegaGuardRequest"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PeriodId"" type=""xs:long"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""FileId"" type=""xs:long"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ImportXmlId"" type=""xs:long"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RizivNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LastName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FirstName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BankAccountNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GuardDate"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GuardStartTime"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GuardEndTime"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ZoneId"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZoneName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GeographicEntityName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NisCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZipCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ResponsableRizivNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ResponsableLastName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ResponsableFirstName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ValidationError"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Reference() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "ImportMedegaGuardResult";
                _RootElements[1] = "GuardStates";
                _RootElements[2] = "ImportMedegaGuardRequest";
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
        
        [Schema(@"http://riziv.fgov.be/GuardsImportService",@"ImportMedegaGuardResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ImportMedegaGuardResult"})]
        public sealed class ImportMedegaGuardResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ImportMedegaGuardResult() {
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
        
        [Schema(@"http://riziv.fgov.be/GuardsImportService",@"GuardStates")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GuardStates"})]
        public sealed class GuardStates : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GuardStates() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GuardStates";
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
        
        [Schema(@"http://riziv.fgov.be/GuardsImportService",@"ImportMedegaGuardRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ImportMedegaGuardRequest"})]
        public sealed class ImportMedegaGuardRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ImportMedegaGuardRequest() {
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
}
