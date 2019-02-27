namespace Salesforce_Application_Import_Definition_XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceApplication__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://sba-oda/DLAP/Application__c"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Application__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Application__c"">
                      <xs:complexType>
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""Previous_SBA_Loans__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Office_Location__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Account_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Federal_Loans__c"" type=""xs:string"" />
                        <xs:attribute name=""Federal_Agency_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Federal_Agency_Location__c"" type=""xs:string"" />
                        <xs:attribute name=""Federal_Loan_Account_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Delinquencies__c"" type=""xs:string"" />
                        <xs:attribute name=""Agency_Name_Delinquent__c"" type=""xs:string"" />
                        <xs:attribute name=""Agency_Location_Deliquent__c"" type=""xs:string"" />
                        <xs:attribute name=""Account_Number_Delinquent__c"" type=""xs:string"" />
                        <xs:attribute name=""Bankruptcy__c"" type=""xs:string"" />
                        <xs:attribute name=""Bankruptcy_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Judgments_Lawsuits__c"" type=""xs:string"" />
                        <xs:attribute name=""Judgments_Lawsuits_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Felonies__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Felonies_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Convictions__c"" type=""xs:string"" />
                        <xs:attribute name=""Previous_Convictions_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""Suspended_Debarred__c"" type=""xs:string"" />
                        <xs:attribute name=""Suspended_Debarred_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""U_S_Citizen__c"" type=""xs:string"" />
                        <xs:attribute name=""Mitigation_Disclosure__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Legal_Representative_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Representative_Company__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Representative_Company_Phone__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Representative_Company_Address_Typ__c"" type=""xs:string"" />
                        <xs:attribute name=""LR_Company_Mailing_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Representative_Fee__c"" type=""xs:double"" />
                        <xs:attribute name=""Original_Create_Date__c"" type=""xs:string"" />
                        <xs:attribute name=""Original_Submission_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""FEMA_Registration_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Extended_Family_Indicator__c"" type=""xs:string"" />
                        <xs:attribute name=""Family_Size__c"" type=""xs:string"" />
                        <xs:attribute name=""Disaster_Declaration__c"" type=""xs:string"" />
                        <xs:attribute name=""External_Id__c"" type=""xs:string"" />
                        <xs:attribute name=""Decline_Reason_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""Loan_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Application_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Consent__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Acknowledgment__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Certification__c"" type=""xs:string"" />
                        <xs:attribute name=""App_Processing_Contact__c"" type=""xs:string"" />
                        <xs:attribute name=""App_Processing_Contact_Phone__c"" type=""xs:string"" />
                        <xs:attribute name=""Loss_Verification_Contact__c"" type=""xs:string"" />
                        <xs:attribute name=""Loss_Verification_Contact_Phone__c"" type=""xs:string"" />
                        <xs:attribute name=""Est_Loss_Equipment__c"" type=""xs:string"" />
                        <xs:attribute name=""Est_Loss_Inventory__c"" type=""xs:string"" />
                        <xs:attribute name=""Est_Loss_Real_Estate__c"" type=""xs:string"" />
                        <xs:attribute name=""Est_Loss_Improvements__c"" type=""xs:string"" />
                        <xs:attribute name=""RecordTypeId"" type=""xs:string"" />
                        <xs:attribute name=""ELA_Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Loss_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Agree_to_Terms__c"" type=""xs:string"" />
                        <xs:attribute name=""Org_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Employee_Ind__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Employee__c"" type=""xs:string"" />
                        <xs:attribute name=""Date_Business_Established__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Is_Summary_Declined__c"" type=""xs:string"" />
                        <xs:attribute name=""Servicing_Office__c"" type=""xs:string"" />
                        <xs:attribute name=""Riot_Civil_Disorder_Other__c"" type=""xs:string"" />
                        <xs:attribute name=""Riot_Civil_Disorder_Other_Details__c"" type=""xs:string"" />
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
  <xs:element name=""table"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""row"">
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
        
        public CDataServiceApplication__c() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "parameters";
                _RootElements[1] = "table";
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
        
        [Schema(@"http://sba-oda/DLAP/Application__c",@"parameters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"parameters"})]
        public sealed class parameters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public parameters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "parameters";
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
        
        [Schema(@"http://sba-oda/DLAP/Application__c",@"table")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"table"})]
        public sealed class table : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public table() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "table";
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
