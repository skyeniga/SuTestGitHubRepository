namespace DLAPDocumentUploadSalesForceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"Response"})]
    public sealed class SalesforceUpdate_CheckList_Item__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/CheckList_Item__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""before"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Checklist_Item__c"">
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
                        <xs:attribute name=""Case__c"" type=""xs:string"" />
                        <xs:attribute name=""Master_Checklist__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant__c"" type=""xs:string"" />
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Borrower_s_Signature_Required__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Checklist_Item_Due_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Checklist_Item_Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Checklist_Item_Text__c"" type=""xs:string"" />
                        <xs:attribute name=""Drawloop_Next__c"" type=""xs:string"" />
                        <xs:attribute name=""Invalid_Reason_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""Last_Action_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Reason_Code_Description__c"" type=""xs:string"" />
                        <xs:attribute name=""Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Verified_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Loan_Condition__c"" type=""xs:string"" />
                        <xs:attribute name=""Verified_By__c"" type=""xs:string"" />
                        <xs:attribute name=""Generate_Document__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Property__c"" type=""xs:string"" />
                        <xs:attribute name=""DocumentType__c"" type=""xs:string"" />
                        <xs:attribute name=""Error_Message__c"" type=""xs:string"" />
                        <xs:attribute name=""Is_Re_run__c"" type=""xs:boolean"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Checklist_Item__c"">
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
                        <xs:attribute name=""Case__c"" type=""xs:string"" />
                        <xs:attribute name=""Master_Checklist__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant__c"" type=""xs:string"" />
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Borrower_s_Signature_Required__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Checklist_Item_Due_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Checklist_Item_Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Checklist_Item_Text__c"" type=""xs:string"" />
                        <xs:attribute name=""Drawloop_Next__c"" type=""xs:string"" />
                        <xs:attribute name=""Invalid_Reason_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""Last_Action_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Reason_Code_Description__c"" type=""xs:string"" />
                        <xs:attribute name=""Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Verified_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Loan_Condition__c"" type=""xs:string"" />
                        <xs:attribute name=""Verified_By__c"" type=""xs:string"" />
                        <xs:attribute name=""Generate_Document__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Property__c"" type=""xs:string"" />
                        <xs:attribute name=""DocumentType__c"" type=""xs:string"" />
                        <xs:attribute name=""Error_Message__c"" type=""xs:string"" />
                        <xs:attribute name=""Is_Re_run__c"" type=""xs:boolean"" />
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
      <xs:attribute name=""AffectedRows"" type=""xs:int"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SalesforceUpdate_CheckList_Item__c() {
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/CheckList_Item__c",@"Request")]
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/CheckList_Item__c",@"Response")]
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
