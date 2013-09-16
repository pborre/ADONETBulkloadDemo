namespace MedegaImport {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CreateMedegaXmlNodeRequest", @"CreateMedegaXmlNodeResponse"})]
    public sealed class SQLCreateMedegaXmlNode : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://inami-riziv.fgov.be.medega"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [sp_CreateMedegaXmlNode] @AssociationId=&quot; &quot;, @AssociationName=&quot; &quot;, @FeeDate=&quot; &quot;, @FileId=&quot; &quot;, @GeographicEntityName=&quot; &quot;, @ManagerFirstName=&quot; &quot;, @ManagerInamiNumber=&quot; &quot;, @ManagerLastName=&quot; &quot;, @MemberBankAccount=&quot; &quot;, @MemberBankAccountOwner=&quot; &quot;, @MemberFirstName=&quot; &quot;, @MemberInamiNumber=&quot; &quot;, @MemberLastName=&quot; &quot;, @NisCode=&quot; &quot;, @PeriodEndTime=&quot; &quot;, @PeriodStartTime=&quot; &quot;, @Status=&quot; &quot;, @ZipCode=&quot; &quot;"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CreateMedegaXmlNodeRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sp_CreateMedegaXmlNode"">
          <xs:complexType>
            <xs:attribute name=""AssociationId"" type=""xs:int"" />
            <xs:attribute name=""AssociationName"" type=""xs:string"" />
            <xs:attribute name=""FeeDate"" type=""xs:string"" />
            <xs:attribute name=""FileId"" type=""xs:long"" />
            <xs:attribute name=""GeographicEntityName"" type=""xs:string"" />
            <xs:attribute name=""ManagerFirstName"" type=""xs:string"" />
            <xs:attribute name=""ManagerInamiNumber"" type=""xs:string"" />
            <xs:attribute name=""ManagerLastName"" type=""xs:string"" />
            <xs:attribute name=""MemberFirstName"" type=""xs:string"" />
            <xs:attribute name=""MemberInamiNumber"" type=""xs:string"" />
            <xs:attribute name=""MemberLastName"" type=""xs:string"" />
            <xs:attribute name=""NisCode"" type=""xs:string"" />
            <xs:attribute name=""PeriodEndTime"" type=""xs:string"" />
            <xs:attribute name=""PeriodStartTime"" type=""xs:string"" />
            <xs:attribute name=""Status"" type=""xs:int"" />
            <xs:attribute name=""ZipCode"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateMedegaXmlNodeResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SQLCreateMedegaXmlNode() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "CreateMedegaXmlNodeRequest";
                _RootElements[1] = "CreateMedegaXmlNodeResponse";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"CreateMedegaXmlNodeRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateMedegaXmlNodeRequest"})]
        public sealed class CreateMedegaXmlNodeRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateMedegaXmlNodeRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateMedegaXmlNodeRequest";
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
        
        [Schema(@"http://inami-riziv.fgov.be.medega",@"CreateMedegaXmlNodeResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateMedegaXmlNodeResponse"})]
        public sealed class CreateMedegaXmlNodeResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateMedegaXmlNodeResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateMedegaXmlNodeResponse";
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
