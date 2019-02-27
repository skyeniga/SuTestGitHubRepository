namespace Salesforce_Application_Import_Definition.Application__c.RestApplication__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SOQL_APPLICATION_INFO_QUERY", @"SOQL_EVENTREQUEST_INFO_QUERY"})]
    public sealed class RestApplicationQueryPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQueryPropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema"" targetNamespace=""https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SOQL_APPLICATION_INFO_QUERY"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""aff0c7b5-3b70-4fec-84e8-408bd6c13182"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SOQL_EVENTREQUEST_INFO_QUERY"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""ae67f66d-359a-437c-a526-ddc0592cc4e8"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public RestApplicationQueryPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SOQL_APPLICATION_INFO_QUERY";
                _RootElements[1] = "SOQL_EVENTREQUEST_INFO_QUERY";
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
    [PropertyType(@"SOQL_APPLICATION_INFO_QUERY",@"https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"aff0c7b5-3b70-4fec-84e8-408bd6c13182")]
    public sealed class SOQL_APPLICATION_INFO_QUERY : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SOQL_APPLICATION_INFO_QUERY", @"https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema");
        
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
    [PropertyType(@"SOQL_EVENTREQUEST_INFO_QUERY",@"https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"ae67f66d-359a-437c-a526-ddc0592cc4e8")]
    public sealed class SOQL_EVENTREQUEST_INFO_QUERY : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SOQL_EVENTREQUEST_INFO_QUERY", @"https://SBA.gov/DLAPApplicationImport/REST/Query/ApplicationQueryPropertySchema");
        
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
