namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MedegaXmlNode", @"ArrayOfMedegaXmlNode"})]
    public sealed class sqlBinding_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Table.dbo</fileNameHint>
    </appinfo>
  </annotation>
  <complexType name=""MedegaXmlNode_136325"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""1"" name=""id"" nillable=""true"" type=""long"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""MedegaFileId"" nillable=""true"" type=""long"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""ReasonOfFailure"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""Status"" nillable=""true"" type=""int"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""MEMBER_INAMI_NUMBER"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MEMBER_LASTNAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MEMBER_FIRSTNAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MEMBER_BANK_ACCOUNT"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MEMBER_BANK_ACCOUNT_OWNER"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""FEE_DATE"" nillable=""true"" type=""dateTime"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""ASSOCIATION_ID"" nillable=""true"" type=""int"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""ASSOCIATION_NAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""GEOGRAPHIC_ENTITY_NAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""NIS_CODE"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""ZIP_CODE"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MANAGER_LASTNAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MANAGER_FIRSTNAME"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MANAGER_INAMI_NUMBER"" nillable=""true"">
        <simpleType>
          <restriction base=""string"">
            <maxLength value=""255"" />
          </restriction>
        </simpleType>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""PERIOD_START_TIME"" nillable=""true"" type=""dateTime"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""PERIOD_END_TIME"" nillable=""true"" type=""dateTime"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""ProcessTime"" nillable=""true"" type=""dateTime"" />
    </sequence>
  </complexType>
  <element name=""MedegaXmlNode"" nillable=""true"" type=""ns3:MedegaXmlNode_136325"" />
  <complexType name=""ArrayOfMedegaXmlNode_136325"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""unbounded"" name=""MedegaXmlNode"" type=""ns3:MedegaXmlNode_136325"" />
    </sequence>
  </complexType>
  <element name=""ArrayOfMedegaXmlNode"" nillable=""true"" type=""ns3:ArrayOfMedegaXmlNode_136325"" />
</schema>";
        
        public sqlBinding_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "MedegaXmlNode";
                _RootElements[1] = "ArrayOfMedegaXmlNode";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo",@"MedegaXmlNode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MedegaXmlNode"})]
        public sealed class MedegaXmlNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MedegaXmlNode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MedegaXmlNode";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo",@"ArrayOfMedegaXmlNode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfMedegaXmlNode"})]
        public sealed class ArrayOfMedegaXmlNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfMedegaXmlNode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfMedegaXmlNode";
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
