namespace MedegaImportSchema.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.riziv.fgov.be/medega/v2.0",@"ROWSET")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ROWSET"})]
    public sealed class Medega_Guard : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ROWSET"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ROW"" type=""ROW"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""ROW"">
    <xs:sequence>
      <xs:element name=""MEMBER_INAMI_NUMBER"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""14"" />
            <xs:pattern value=""[0-9]-[0-9]{5}-[0-9]{2}-[0-9]{3}"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""MEMBER_LASTNAME"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""48"" />
            <xs:pattern value=""[^\d]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""MEMBER_FIRSTNAME"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""12"" />
            <xs:pattern value=""[^\d]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""FEE_DATE"">
        <xs:simpleType>
          <xs:restriction base=""xs:date"" />
        </xs:simpleType>
      </xs:element>
      <xs:element name=""ASSOCIATION_ID"">
        <xs:simpleType>
          <xs:restriction base=""xs:integer"" />
        </xs:simpleType>
      </xs:element>
      <xs:element name=""ASSOCIATION_NAME"" type=""xs:string"" />
      <xs:element name=""GEOGRAPHIC_ENTITY_NAME"" type=""xs:string"" />
      <xs:element name=""NIS_CODE"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:minLength value=""5"" />
            <xs:maxLength value=""6"" />
            <xs:pattern value=""[0-9A-Za-z]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""ZIP_CODE"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
            <xs:pattern value=""[0-9]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""MANAGER_LASTNAME"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""48"" />
            <xs:pattern value=""[^\d]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""MANAGER_FIRSTNAME"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""12"" />
            <xs:pattern value=""[^\d]*"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""MANAGER_INAMI_NUMBER"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""14"" />
            <xs:pattern value=""[0-9]-[0-9]{5}-[0-9]{2}-[0-9]{3}"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element name=""PERIOD_START_TIME"">
        <xs:simpleType>
          <xs:restriction base=""xs:time"" />
        </xs:simpleType>
      </xs:element>
      <xs:element name=""PERIOD_END_TIME"">
        <xs:simpleType>
          <xs:restriction base=""xs:time"" />
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Medega_Guard() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ROWSET";
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
