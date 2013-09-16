namespace MedegaImport.PropertySchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FileName", @"ReceivedOn", @"Status", @"Fileld"})]
    public sealed class MedegaPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MedegaImport.PropertySchema.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MedegaImport.PropertySchema.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FileName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""d7657887-58b9-47fc-8ec8-e2fa29039dcd"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ReceivedOn"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""55541d7d-949b-4ab4-8279-1a603b1793e9"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Status"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""8e8cd882-f60b-4181-a80f-adb16f3ce055"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Fileld"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""69dad8bb-d4d0-46a7-930f-881a343c56ba"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public MedegaPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "FileName";
                _RootElements[1] = "ReceivedOn";
                _RootElements[2] = "Status";
                _RootElements[3] = "Fileld";
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
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"FileName",@"http://MedegaImport.PropertySchema.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"d7657887-58b9-47fc-8ec8-e2fa29039dcd")]
    public sealed class FileName : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"FileName", @"http://MedegaImport.PropertySchema.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ReceivedOn",@"http://MedegaImport.PropertySchema.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"55541d7d-949b-4ab4-8279-1a603b1793e9")]
    public sealed class ReceivedOn : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ReceivedOn", @"http://MedegaImport.PropertySchema.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Status",@"http://MedegaImport.PropertySchema.PropertySchema","int","System.Int32")]
    [PropertyGuidAttribute(@"8e8cd882-f60b-4181-a80f-adb16f3ce055")]
    public sealed class Status : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Status", @"http://MedegaImport.PropertySchema.PropertySchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Fileld",@"http://MedegaImport.PropertySchema.PropertySchema","int","System.Int32")]
    [PropertyGuidAttribute(@"69dad8bb-d4d0-46a7-930f-881a343c56ba")]
    public sealed class Fileld : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Fileld", @"http://MedegaImport.PropertySchema.PropertySchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
}
