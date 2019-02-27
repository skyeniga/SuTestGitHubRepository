namespace DLAPEventsSalesforceDefinition.RestCheckStatus {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse",@"QueryResult")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"QueryResult"})]
    public sealed class RestCheckStatusSalesforceResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""QueryResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Loan_Type__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DLAP_Status_Description__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DLAP_Status__c"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
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
              <xs:element name=""Applicants__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""done"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element name=""External_ID__c"" type=""xs:unsignedShort"" />
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""Trade_Name__c"" type=""xs:string"" />
                          <xs:element name=""Applicant_Relation_Type__c"" type=""xs:string"" />
                          <xs:element name=""Contact__r"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LastName"" type=""xs:string"" />
                                <xs:element name=""FirstName"" type=""xs:string"" />
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
              <xs:element name=""Checklist_Items__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""done"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""Case__c"" type=""xs:string"" />
                          <xs:element name=""Applicant__c"" type=""xs:string"" />
                          <xs:element name=""Application__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Status__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Text__c"" type=""xs:string"" />
                          <xs:element name=""Type__c"" type=""xs:string"" />
                          <xs:element name=""CreatedDate"" type=""xs:dateTime"" />
                          <xs:element name=""Verified_Date__c"" type=""xs:dateTime"" />
                          <xs:element name=""DocumentType__c"" type=""xs:string"" />
                          <xs:element name=""Checklist_Item_Due_Date__c"" type=""xs:dateTime"" />
                          <xs:element name=""Applicant__r"">
                            <xs:complexType>
                              <xs:sequence>
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
              <xs:element minOccurs=""0"" name=""Loans__r"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""done"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element name=""Name"" type=""xs:string"" />
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
        
        public RestCheckStatusSalesforceResponse() {
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
