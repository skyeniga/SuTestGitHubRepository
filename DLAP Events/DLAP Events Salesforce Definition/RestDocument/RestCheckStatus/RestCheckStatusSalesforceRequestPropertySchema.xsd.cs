namespace DLAPEventsSalesforceDefinition.RestCheckStatus {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [Schema(@"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusSalesforceRequestPropertySchema",@"SF_APPLICATION_QUERY")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SF_APPLICATION_QUERY"})]
    public sealed class RestCheckStatusSalesforceRequestPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequestPropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusSalesforceRequestPropertySchema"" targetNamespace=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusSalesforceRequestPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SF_APPLICATION_QUERY"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""235467d0-279c-43f7-bcf1-7a62107dc67c"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public RestCheckStatusSalesforceRequestPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SF_APPLICATION_QUERY";
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
    [PropertyType(@"SF_APPLICATION_QUERY",@"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusSalesforceRequestPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"235467d0-279c-43f7-bcf1-7a62107dc67c")]
    public sealed class SF_APPLICATION_QUERY : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SF_APPLICATION_QUERY", @"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusSalesforceRequestPropertySchema");
        
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
