namespace Salesforce_Application_Import_Definition.Application__c.RestDisaster__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [Schema(@"https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequestPropertySchema",@"External_Id_DMS_Number__c")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"External_Id_DMS_Number__c"})]
    public sealed class RestDisasterLookupRequestPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupRequestPropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequestPropertySchema"" targetNamespace=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequestPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""External_Id_DMS_Number__c"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""3bc1e2a5-839d-40f6-bf71-f0b8bfe255f8"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public RestDisasterLookupRequestPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "External_Id_DMS_Number__c";
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
    [PropertyType(@"External_Id_DMS_Number__c",@"https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequestPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"3bc1e2a5-839d-40f6-bf71-f0b8bfe255f8")]
    public sealed class External_Id_DMS_Number__c : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"External_Id_DMS_Number__c", @"https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequestPropertySchema");
        
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
