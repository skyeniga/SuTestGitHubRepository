namespace Salesforce_Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceOther_Assistance__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Other_Assistance__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Other_Assistance__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastActivityDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastViewedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastReferencedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Active_NFIRA_Policy__c"" type=""xs:string"" />
                        <xs:attribute name=""Application_No__c"" type=""xs:string"" />
                        <xs:attribute name=""Applied_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Co_Reg_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Contents_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""County__c"" type=""xs:string"" />
                        <xs:attribute name=""Damaged_Property_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""FEMA_Reg_No__c"" type=""xs:string"" />
                        <xs:attribute name=""Interface_Date_Time__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Interface_Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Language__c"" type=""xs:string"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""Loss_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""NFIRA_Compliant__c"" type=""xs:string"" />
                        <xs:attribute name=""Name__c"" type=""xs:string"" />
                        <xs:attribute name=""O_R__c"" type=""xs:string"" />
                        <xs:attribute name=""Occupancy_Verification__c"" type=""xs:string"" />
                        <xs:attribute name=""Ownership_Verification__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Residence__c"" type=""xs:string"" />
                        <xs:attribute name=""Real_Estate_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""Request_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Requested_By__c"" type=""xs:string"" />
                        <xs:attribute name=""Required_to_Maintain__c"" type=""xs:string"" />
                        <xs:attribute name=""Residence_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Rqmt_from_Previous_Assistance__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_App_Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Size__c"" type=""xs:double"" />
                        <xs:attribute name=""State_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_FEMA_amount_for_Real_Estate__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_Grants_Other_amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_Amount_of_Housing_Assistance__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_Amount_of_Other_Assistance__c"" type=""xs:double"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Mitigation_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""Real_Estate_Content_Grants__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_FEMA_Assistance_for_Real_Estate__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_Amt_of_Disaster_Housing_Assistance__c"" type=""xs:double"" />
                        <xs:attribute name=""Total_Amt_of_Family_Grants_Assistance__c"" type=""xs:double"" />
                        <xs:attribute name=""Property__c"" type=""xs:string"" />
                        <xs:attribute name=""FEMA_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Grant__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Grant_Description__c"" type=""xs:string"" />
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
        
        public CDataServiceOther_Assistance__c() {
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
        
        [Schema(@"http://sba-oda/DLAP/Other_Assistance__c",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Other_Assistance__c",@"table")]
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
