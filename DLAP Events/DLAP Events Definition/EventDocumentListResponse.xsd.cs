namespace DLAPEventsDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"DOCUMENT")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DOCUMENT"})]
    public sealed class EventDocumentListResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DOCUMENT"">
    <xs:complexType>
      <xs:sequence minOccurs=""1"" maxOccurs=""1"">
        <xs:element name=""AppData"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""App_Nbr"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Loan_Type"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Disaster_Name"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Requested_Document_Count"" type=""xs:integer"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Disaster_Deadline_Date"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccountInformation"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Loan_Nbr"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ApplicantList"">
          <xs:complexType>
            <xs:sequence minOccurs=""1"" maxOccurs=""1"">
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Applicants"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ApplicantId"" type=""xs:integer"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""APL_ORG_TYPE_CD"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LegalName"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APL_FIRST_NAME"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APL_MIDDLE_NAME"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APL_LAST_NAME"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APL_SUFFIX"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""APL_RELATION_TYPE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""AplAffiliateColl"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Apl_Affiliates"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""AffiliateId"" type=""xs:integer"" />
                                <xs:element name=""AFI_NAME"" type=""xs:string"" />
                                <xs:element name=""AFI_ORG_TYPE"" type=""xs:string"" />
                                <xs:element name=""AFI_PER_OWNERSHIP"" type=""xs:string"" />
                              </xs:sequence>
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
        <xs:element name=""DocumentList"">
          <xs:complexType>
            <xs:sequence minOccurs=""1"" maxOccurs=""1"">
              <xs:element name=""DocumentDetails"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ChecklistType"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ActionID"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Status"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ApplicantId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AffiliateId"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ReceiveDate"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RequestDate"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeadlineDate"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ScanDocumentID"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DocumentType"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DocumentTitle"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DocumentDescription"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DocumentPath"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EventDocumentListResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DOCUMENT";
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
