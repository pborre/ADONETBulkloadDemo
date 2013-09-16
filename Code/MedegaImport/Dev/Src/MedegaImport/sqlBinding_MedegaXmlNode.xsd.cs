namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Insert", @"InsertResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.sqlBinding_dbo", typeof(global::MedegaImport.sqlBinding_dbo))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.sqlBinding_Arrays", typeof(global::MedegaImport.sqlBinding_Arrays))]
    public sealed class sqlBinding_MedegaXmlNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/MedegaXmlNode"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""MedegaImport.sqlBinding_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" />
  <import schemaLocation=""MedegaImport.sqlBinding_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TableOperation.dbo.MedegaXmlNode</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" />
      </b:references>
    </appinfo>
  </annotation>
  <element name=""Insert"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TableOp/Insert/dbo/MedegaXmlNode</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""Rows"" nillable=""true"" type=""ns3:ArrayOfMedegaXmlNode_136325"" />
      </sequence>
    </complexType>
  </element>
  <element name=""InsertResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TableOp/Insert/dbo/MedegaXmlNode/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""InsertResult"" nillable=""true"" type=""array:ArrayOflong_136325"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public sqlBinding_MedegaXmlNode() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Insert";
                _RootElements[1] = "InsertResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/MedegaXmlNode",@"Insert")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Insert"})]
        public sealed class Insert : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Insert() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Insert";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/MedegaXmlNode",@"InsertResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertResponse"})]
        public sealed class InsertResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertResponse";
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
