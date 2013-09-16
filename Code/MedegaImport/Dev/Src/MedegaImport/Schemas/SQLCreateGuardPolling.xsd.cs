namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://inami-riziv.fgov.be.medega",@"CreateGuardPolling")]
    [BodyXPath(@"/*[local-name()='CreateGuardPolling' and namespace-uri()='http://inami-riziv.fgov.be.medega']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CreateGuardPolling"})]
    public sealed class SQLCreateGuardPolling : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_BTSCreateGuardPolling]"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
      <schemaInfo is_envelope=""yes"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CreateGuardPolling"">
    <xs:annotation>
      <xs:appinfo>
        <recordInfo body_xpath=""/*[local-name()='CreateGuardPolling' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://inami-riziv.fgov.be.medega"" minOccurs=""0"" maxOccurs=""unbounded"" name=""Node"" type=""q1:NodeType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""NodeType"">
    <xs:attribute name=""FileID"" type=""xs:long"" />
    <xs:attribute name=""NodeId"" type=""xs:long"" />
  </xs:complexType>
</xs:schema>";
        
        public SQLCreateGuardPolling() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CreateGuardPolling";
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
