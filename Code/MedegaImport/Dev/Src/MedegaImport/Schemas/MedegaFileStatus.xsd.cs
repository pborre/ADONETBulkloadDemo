namespace MedegaImport.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://inami-riziv.fgov.be.medega",@"F")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MedegaImport.PropertySchema.FileName), XPath = @"/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='FileName' and namespace-uri()='http://inami-riziv.fgov.be.medega']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MedegaImport.PropertySchema.ReceivedOn), XPath = @"/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='ReceivedOn' and namespace-uri()='http://inami-riziv.fgov.be.medega']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MedegaImport.PropertySchema.Status), XPath = @"/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='Status' and namespace-uri()='http://inami-riziv.fgov.be.medega']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MedegaImport.PropertySchema.Fileld), XPath = @"/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='FileId' and namespace-uri()='http://inami-riziv.fgov.be.medega']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"F"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.PropertySchema.MedegaPropertySchema", typeof(global::MedegaImport.PropertySchema.MedegaPropertySchema))]
    public sealed class MedegaFileStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://inami-riziv.fgov.be.medega"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://MedegaImport.PropertySchema.PropertySchema"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_BTSDonePolling]"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://MedegaImport.PropertySchema.PropertySchema"" location=""MedegaImport.PropertySchema.MedegaPropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element xmlns:q1=""http://inami-riziv.fgov.be.medega"" name=""F"" type=""q1:FType"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:FileName"" xpath=""/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='FileName' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" />
          <b:property name=""ns0:ReceivedOn"" xpath=""/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='ReceivedOn' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" />
          <b:property name=""ns0:Status"" xpath=""/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='Status' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" />
          <b:property name=""ns0:Fileld"" xpath=""/*[local-name()='F' and namespace-uri()='http://inami-riziv.fgov.be.medega']/*[local-name()='FileId' and namespace-uri()='http://inami-riziv.fgov.be.medega']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""FType"">
    <xs:sequence minOccurs=""0"">
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
        
        public MedegaFileStatus() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "F";
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
