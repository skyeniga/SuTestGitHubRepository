namespace Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DocumentUpload", @"APP_ID", @"APP_ELA_REFERENCE_NBR", @"APP_CREATE_DATE", @"APP_SUBMIT_DATE", @"APP_PRO_ID", @"APP_FEMA_REGIS_NBR", @"PackageId"})]
    public sealed class DLAP_Property_Schema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Application_Import_Definition.DLAP_Property_Schema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://Application_Import_Definition.DLAP_Property_Schema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""DocumentUpload"" type=""xs:boolean"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""4e0da739-ecf8-48aa-a52d-62da7e856f84"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_ID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""21fbb7aa-940e-4b8b-a745-c62c436f19d8"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_ELA_REFERENCE_NBR"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""680fd554-65b4-4ac6-8196-84cc11c2fe21"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_CREATE_DATE"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""6ae5fb42-cc12-4882-aaba-c59edc25d752"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_SUBMIT_DATE"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""73328390-e380-4f0d-801c-1459243372cc"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_PRO_ID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""c6f8b0a6-bf2e-41fe-beb6-ec52bef2e3fd"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""APP_FEMA_REGIS_NBR"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""6e518c56-3d7e-48a4-904f-d5cfaccd87f3"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PackageId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""745099f7-a5d9-410a-ab10-eb70a2d207eb"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public DLAP_Property_Schema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "DocumentUpload";
                _RootElements[1] = "APP_ID";
                _RootElements[2] = "APP_ELA_REFERENCE_NBR";
                _RootElements[3] = "APP_CREATE_DATE";
                _RootElements[4] = "APP_SUBMIT_DATE";
                _RootElements[5] = "APP_PRO_ID";
                _RootElements[6] = "APP_FEMA_REGIS_NBR";
                _RootElements[7] = "PackageId";
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
    [PropertyType(@"DocumentUpload",@"https://Application_Import_Definition.DLAP_Property_Schema","boolean","System.Boolean")]
    [PropertyGuidAttribute(@"4e0da739-ecf8-48aa-a52d-62da7e856f84")]
    public sealed class DocumentUpload : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"DocumentUpload", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
        private static bool PropertyValueType {
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
                return typeof(bool);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"APP_ID",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"21fbb7aa-940e-4b8b-a745-c62c436f19d8")]
    public sealed class APP_ID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_ID", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"APP_ELA_REFERENCE_NBR",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"680fd554-65b4-4ac6-8196-84cc11c2fe21")]
    public sealed class APP_ELA_REFERENCE_NBR : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_ELA_REFERENCE_NBR", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"APP_CREATE_DATE",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"6ae5fb42-cc12-4882-aaba-c59edc25d752")]
    public sealed class APP_CREATE_DATE : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_CREATE_DATE", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"APP_SUBMIT_DATE",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"73328390-e380-4f0d-801c-1459243372cc")]
    public sealed class APP_SUBMIT_DATE : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_SUBMIT_DATE", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"APP_PRO_ID",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"c6f8b0a6-bf2e-41fe-beb6-ec52bef2e3fd")]
    public sealed class APP_PRO_ID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_PRO_ID", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"APP_FEMA_REGIS_NBR",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"6e518c56-3d7e-48a4-904f-d5cfaccd87f3")]
    public sealed class APP_FEMA_REGIS_NBR : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APP_FEMA_REGIS_NBR", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
    [PropertyType(@"PackageId",@"https://Application_Import_Definition.DLAP_Property_Schema","string","System.String")]
    [PropertyGuidAttribute(@"745099f7-a5d9-410a-ab10-eb70a2d207eb")]
    public sealed class PackageId : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"PackageId", @"https://Application_Import_Definition.DLAP_Property_Schema");
        
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
}
