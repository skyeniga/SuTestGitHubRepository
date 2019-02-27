namespace DLAPDocumentUploadSalesForceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaveRequest", @"results"})]
    public sealed class RestReceiptDocument : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestReceiptDocument"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestReceiptDocument"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SaveRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""true"" name=""allOrNone"" type=""xs:boolean"" />
        <xs:element maxOccurs=""unbounded"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""IsDeleted"" type=""xs:boolean"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""CreatedDate"" type=""xs:dateTime"" />
              <xs:element name=""CreatedById"" type=""xs:string"" />
              <xs:element name=""LastModifiedDate"" type=""xs:dateTime"" />
              <xs:element name=""LastModifiedById"" type=""xs:string"" />
              <xs:element name=""SystemModstamp"" type=""xs:dateTime"" />
              <xs:element name=""LastViewedDate"" type=""xs:dateTime"" />
              <xs:element name=""LastReferencedDate"" type=""xs:dateTime"" />
              <xs:element name=""Audited__c"" type=""xs:boolean"" />
              <xs:element name=""Amount__c"" type=""xs:double"" />
              <xs:element name=""Eligible_Receipt__c"" type=""xs:boolean"" />
              <xs:element name=""Invoice__c"" type=""xs:string"" />
              <xs:element name=""Item__c"" type=""xs:string"" />
              <xs:element name=""Receipt_Date__c"" type=""xs:dateTime"" />
              <xs:element name=""Receipt_ID__c"" type=""xs:string"" />
              <xs:element name=""Use_of_Proceeds__c"" type=""xs:string"" />
              <xs:element name=""Vendor__c"" type=""xs:string"" />
              <xs:element name=""Loan__c"" type=""xs:string"" />
              <xs:element name=""Inspection__c"" type=""xs:string"" />
              <xs:element name=""Property_Name__c"" type=""xs:string"" />
              <xs:element name=""Status__c"" type=""xs:string"" />
              <xs:element name=""Type__c"" type=""xs:string"" />
              <xs:element name=""Document_Date__c"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute default=""ReceiptDocument__c"" name=""type"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""results"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""errors"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""warnings"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""id"" type=""xs:string"" />
              <xs:element name=""success"" type=""xs:boolean"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestReceiptDocument() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SaveRequest";
                _RootElements[1] = "results";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestReceiptDocument",@"SaveRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaveRequest"})]
        public sealed class SaveRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaveRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SaveRequest";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestReceiptDocument",@"results")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"results"})]
        public sealed class results : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public results() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "results";
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
