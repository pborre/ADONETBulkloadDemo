namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://inami-riziv.fgov.be.medega",@"MedegaFileDone")]
    [BodyXPath(@"/*[local-name()='MedegaFileDone' and namespace-uri()='http://inami-riziv.fgov.be.medega']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MedegaFileDone"})]
    public sealed class SQLMedegaFileDonePolling : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_BTSDonePolling]"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""MedegaFileDone"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='MedegaFileDone' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://inami-riziv.fgov.be.medega"" minOccurs=""0"" maxOccurs=""unbounded"" name=""F"" type=""q1:FType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""FType"">
    <xs:sequence minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element xmlns:q2=""http://inami-riziv.fgov.be.medega"" name=""FileId"" type=""q2:FileId"" />
      <xs:element xmlns:q3=""http://inami-riziv.fgov.be.medega"" name=""FileName"" type=""q3:FileNameType"" />
      <xs:element xmlns:q4=""http://inami-riziv.fgov.be.medega"" name=""ReceivedOn"" type=""q4:ReceivedOnType"" />
      <xs:element xmlns:q5=""http://inami-riziv.fgov.be.medega"" name=""Status"" type=""q5:StatusType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FileNameType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ReceivedOnType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""StatusType"">
    <xs:simpleContent>
      <xs:extension base=""xs:int"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""FileId"">
    <xs:simpleContent>
      <xs:extension base=""xs:int"" />
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public SQLMedegaFileDonePolling() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MedegaFileDone";
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
