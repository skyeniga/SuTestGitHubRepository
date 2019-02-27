namespace DLAPDocumentUploadSalesForceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.ReceiptDocument__c.Loan__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='ReceiptDocument__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/@*[local-name()='Loan__c' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"Response"})]
    public sealed class SalesforceQuery_ReceiptDocument__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentUpload/ReceiptDocument"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/ReceiptDocument"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='ReceiptDocument__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/@*[local-name()='Loan__c' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ReceiptDocument__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastViewedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastReferencedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""Audited__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Eligible_Receipt__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Invoice__c"" type=""xs:string"" />
                        <xs:attribute name=""Item__c"" type=""xs:string"" />
                        <xs:attribute name=""Receipt_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Receipt_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""Use_of_Proceeds__c"" type=""xs:string"" />
                        <xs:attribute name=""Vendor__c"" type=""xs:string"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""Inspection__c"" type=""xs:string"" />
                        <xs:attribute name=""Property_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Document_Date__c"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Record"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"">
                <xs:complexType>
                  <xs:simpleContent>
                    <xs:extension base=""xs:string"">
                      <xs:attribute name=""IsNull"" type=""xs:boolean"" />
                    </xs:extension>
                  </xs:simpleContent>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""AffectedRows"" type=""xs:int"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SalesforceQuery_ReceiptDocument__c() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Request";
                _RootElements[1] = "Response";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/ReceiptDocument",@"Request")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.ReceiptDocument__c.Loan__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/*[local-name()='ReceiptDocument__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/ReceiptDocument']/@*[local-name()='Loan__c' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Request"})]
        public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Request() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Request";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/ReceiptDocument",@"Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Response"})]
        public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Response";
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
