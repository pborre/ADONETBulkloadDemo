namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"sp_CreateMedegaXmlNode", @"sp_CreateMedegaXmlNodeResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.WCFSQL_System_x2eData", typeof(global::MedegaImport.WCFSQL_System_x2eData))]
    public sealed class WCFSQL_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""MedegaImport.WCFSQL_System_x2eData"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </appinfo>
  </annotation>
  <element name=""sp_CreateMedegaXmlNode"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/sp_CreateMedegaXmlNode</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence maxOccurs=""unbounded"">
        <element minOccurs=""0"" maxOccurs=""1"" name=""FileId"" nillable=""true"" type=""long"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""Status"" nillable=""true"" type=""int"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""MemberInamiNumber"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""14"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""MemberLastName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""48"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""MemberFirstName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""12"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""FeeDate"" nillable=""true"" type=""dateTime"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""AssociationId"" nillable=""true"" type=""int"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""AssociationName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""255"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""GeographicEntityName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""255"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""NisCode"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""6"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""ZipCode"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""4"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""ManagerLastName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""48"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""ManagerFirstName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""12"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""ManagerInamiNumber"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""14"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""PeriodStartTime"" nillable=""true"" type=""dateTime"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""PeriodEndTime"" nillable=""true"" type=""dateTime"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""NodeId"" nillable=""true"" type=""long"" />
      </sequence>
    </complexType>
  </element>
  <element name=""sp_CreateMedegaXmlNodeResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/sp_CreateMedegaXmlNode/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""sp_CreateMedegaXmlNodeResult"" nillable=""true"" type=""ns3:ArrayOfDataSet"" />
        <element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""int"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""NodeId"" nillable=""true"" type=""long"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public WCFSQL_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "sp_CreateMedegaXmlNode";
                _RootElements[1] = "sp_CreateMedegaXmlNodeResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"sp_CreateMedegaXmlNode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"sp_CreateMedegaXmlNode"})]
        public sealed class sp_CreateMedegaXmlNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public sp_CreateMedegaXmlNode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "sp_CreateMedegaXmlNode";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"sp_CreateMedegaXmlNodeResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"sp_CreateMedegaXmlNodeResponse"})]
        public sealed class sp_CreateMedegaXmlNodeResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public sp_CreateMedegaXmlNodeResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "sp_CreateMedegaXmlNodeResponse";
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
