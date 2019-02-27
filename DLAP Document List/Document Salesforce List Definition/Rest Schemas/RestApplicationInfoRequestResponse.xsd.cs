namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"QueryResult"})]
    public sealed class RestApplicationInfoRequestResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ApplicationNumber"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QueryResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:boolean"" />
        <xs:element maxOccurs=""unbounded"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Loan_Type__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DLAP_Status_Description__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DLAP_Status__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Disaster_Declaration__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Disaster_Description__c"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Disaster_Deadline_Date__c"" type=""xs:date"" />
                  </xs:sequence>
                  <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""Applicants__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""done"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""External_ID__c"" type=""xs:unsignedInt"" />
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""Applicant_Relation_Type__c"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""Trade_Name__c"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""Contact__r"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LastName"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""FirstName"" type=""xs:string"" />
                                <xs:element name=""Organization_Type__c"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                              <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""Account__r"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""Business_Type__c"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                              <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                        <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                        <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""totalSize"" type=""xs:unsignedByte"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""Checklist_Items__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""done"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""Case__c"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""Applicant__c"" type=""xs:string"" />
                          <xs:element name=""Application__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Status__c"" type=""xs:string"" />
                          <xs:element name=""Case__c"" type=""xs:string"" />
                          <xs:element name=""Applicant__c"" type=""xs:string"" />
                          <xs:element name=""Application__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Text__c"" type=""xs:string"" />
                          <xs:element name=""DocumentType__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Due_Date__c"" type=""xs:dateTime"" />
                          <xs:element name=""Type__c"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""Verified_Date__c"" type=""xs:dateTime"" />
                          <xs:element name=""CreatedDate"" type=""xs:dateTime"" />
                          <xs:element minOccurs=""0"" name=""Applicant__r"">
                            <xs:complexType>
                              <xs:sequence minOccurs=""0"">
                                <xs:element name=""External_ID__c"" type=""xs:unsignedShort"" />
                              </xs:sequence>
                              <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                              <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""Master_Checklist__r"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                                <xs:element name=""Checklist_Description__c"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                              <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                        <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                        <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""totalSize"" type=""xs:unsignedByte"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""totalSize"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestApplicationInfoRequestResponse() {
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
                _RootElements[1] = "QueryResult";
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
        
        [Schema(@"http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo",@"Request")]
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
        
        [Schema(@"http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo",@"QueryResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryResult"})]
        public sealed class QueryResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryResult";
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
