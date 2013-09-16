namespace MedegaImport.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://inami-riziv.fgov.be.medega",@"Node")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int64), "FileID", XPath = @"/*[local-name()='Node' and namespace-uri()='http://inami-riziv.fgov.be.medega']/@*[local-name()='FileID' and namespace-uri()='']", XsdType = @"long")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int64), "NodeId", XPath = @"/*[local-name()='Node' and namespace-uri()='http://inami-riziv.fgov.be.medega']/@*[local-name()='NodeId' and namespace-uri()='']", XsdType = @"long")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Node"})]
    public sealed class CreateGuardNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://inami-riziv.fgov.be.medega"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element xmlns:q1=""http://inami-riziv.fgov.be.medega"" name=""Node"" type=""q1:NodeType"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Node' and namespace-uri()='http://inami-riziv.fgov.be.medega']/@*[local-name()='FileID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Node' and namespace-uri()='http://inami-riziv.fgov.be.medega']/@*[local-name()='NodeId' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""NodeType"">
    <xs:attribute name=""FileID"" type=""xs:long"" />
    <xs:attribute name=""NodeId"" type=""xs:long"" />
  </xs:complexType>
</xs:schema>";
        
        public CreateGuardNode() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Node";
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
