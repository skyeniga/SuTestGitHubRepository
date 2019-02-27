namespace DLAPDocumentUploadSalesForceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [Schema(@"https://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestLoanQueryPropertySchema",@"SOQL_Loan_Query")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SOQL_Loan_Query"})]
    public sealed class RestLoanQueryPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DLAPDocumentUploadSalesForceDefinition.Rest.RestLoanQueryPropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestLoanQueryPropertySchema"" targetNamespace=""https://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestLoanQueryPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SOQL_Loan_Query"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""53c4cf72-5aa8-4f95-98c0-fa8c9fff23d9"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public RestLoanQueryPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SOQL_Loan_Query";
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
    [PropertyType(@"SOQL_Loan_Query",@"https://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestLoanQueryPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"53c4cf72-5aa8-4f95-98c0-fa8c9fff23d9")]
    public sealed class SOQL_Loan_Query : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SOQL_Loan_Query", @"https://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestLoanQueryPropertySchema");
        
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
