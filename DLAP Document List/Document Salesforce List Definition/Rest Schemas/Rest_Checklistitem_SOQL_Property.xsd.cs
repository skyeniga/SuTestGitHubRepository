namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [Schema(@"https://DLAPDocumentListSalesforceDefinition/RestSchemas/RestChecklistitemSOQLProperty",@"SF_CHECKLISTITEM_QUERY")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SF_CHECKLISTITEM_QUERY"})]
    public sealed class Rest_Checklistitem_SOQL_Property : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_Checklistitem_SOQL_Property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://DLAPDocumentListSalesforceDefinition/RestSchemas/RestChecklistitemSOQLProperty"" targetNamespace=""https://DLAPDocumentListSalesforceDefinition/RestSchemas/RestChecklistitemSOQLProperty"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SF_CHECKLISTITEM_QUERY"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a8a17ab2-c446-4cf8-a008-63a8544350fa"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public Rest_Checklistitem_SOQL_Property() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SF_CHECKLISTITEM_QUERY";
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
    [PropertyType(@"SF_CHECKLISTITEM_QUERY",@"https://DLAPDocumentListSalesforceDefinition/RestSchemas/RestChecklistitemSOQLProperty","string","System.String")]
    [PropertyGuidAttribute(@"a8a17ab2-c446-4cf8-a008-63a8544350fa")]
    public sealed class SF_CHECKLISTITEM_QUERY : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SF_CHECKLISTITEM_QUERY", @"https://DLAPDocumentListSalesforceDefinition/RestSchemas/RestChecklistitemSOQLProperty");
        
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
