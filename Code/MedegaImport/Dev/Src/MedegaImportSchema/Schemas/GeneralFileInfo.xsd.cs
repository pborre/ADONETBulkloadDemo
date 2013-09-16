namespace MedegaImportSchema.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.riziv.fgov.be/medega/v1.0",@"FileInfo")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodFromDay", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromDay' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodFromMonth", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromMonth' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodFromYear", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromYear' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodToDay", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToDay' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodToMonth", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToMonth' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PeriodToYear", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToYear' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FileName", XPath = @"/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='FileName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FileInfo"})]
    public sealed class GeneralFileInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.riziv.fgov.be/medega/v1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.riziv.fgov.be/medega/v1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""FileInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromDay' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromMonth' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodFromYear' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToDay' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToMonth' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='PeriodToYear' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FileInfo' and namespace-uri()='http://www.riziv.fgov.be/medega/v1.0']/*[local-name()='FileName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PeriodFromDay"" type=""xs:string"" />
        <xs:element name=""PeriodFromMonth"" type=""xs:string"" />
        <xs:element name=""PeriodFromYear"" type=""xs:string"" />
        <xs:element name=""PeriodToDay"" type=""xs:string"" />
        <xs:element name=""PeriodToMonth"" type=""xs:string"" />
        <xs:element name=""PeriodToYear"" type=""xs:string"" />
        <xs:element name=""FileName"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GeneralFileInfo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FileInfo";
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
