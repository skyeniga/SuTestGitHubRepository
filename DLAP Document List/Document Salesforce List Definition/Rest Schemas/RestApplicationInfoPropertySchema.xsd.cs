namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [Schema(@"https://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfoPropertySchema",@"APPLICATION_INFO_SOQL_QUERY")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"APPLICATION_INFO_SOQL_QUERY"})]
    public sealed class RestApplicationInfoPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoPropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfoPropertySchema"" targetNamespace=""https://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfoPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""APPLICATION_INFO_SOQL_QUERY"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""52232d5e-74d7-4af4-8d16-7e5480889577"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public RestApplicationInfoPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "APPLICATION_INFO_SOQL_QUERY";
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
    [PropertyType(@"APPLICATION_INFO_SOQL_QUERY",@"https://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfoPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"52232d5e-74d7-4af4-8d16-7e5480889577")]
    public sealed class APPLICATION_INFO_SOQL_QUERY : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"APPLICATION_INFO_SOQL_QUERY", @"https://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfoPropertySchema");
        
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
