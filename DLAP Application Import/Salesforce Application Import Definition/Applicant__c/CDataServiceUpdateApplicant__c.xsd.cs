namespace Salesforce_Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceUpdateApplicant__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/UpdateApplicant__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""before"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Applicant__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""RecordTypeId"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastActivityDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastViewedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastReferencedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Account__c"" type=""xs:string"" />
                        <xs:attribute name=""Allowable_MAFD__c"" type=""xs:double"" />
                        <xs:attribute name=""App_Processing_Variables__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Relation_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Character_Issues__c"" type=""xs:boolean"" />
                        <xs:attribute name=""City__c"" type=""xs:string"" />
                        <xs:attribute name=""Contact__c"" type=""xs:string"" />
                        <xs:attribute name=""County__c"" type=""xs:string"" />
                        <xs:attribute name=""Credit_Score__c"" type=""xs:double"" />
                        <xs:attribute name=""Employer_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""Employer_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Exceeds_Standard_Calculation__c"" type=""xs:double"" />
                        <xs:attribute name=""External_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""Gross_Annual_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Gross_Monthly_Income2__c"" type=""xs:double"" />
                        <xs:attribute name=""Gross_Monthly_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""MAFD_P__c"" type=""xs:double"" />
                        <xs:attribute name=""MAFD__c"" type=""xs:double"" />
                        <xs:attribute name=""Monthly_Fixed_Debt__c"" type=""xs:double"" />
                        <xs:attribute name=""Months_Employed__c"" type=""xs:double"" />
                        <xs:attribute name=""New_Debt_Load__c"" type=""xs:double"" />
                        <xs:attribute name=""Occupation__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Income_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Income_Source_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Income_Source__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Applicant__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Primary_Wage_Earner__c"" type=""xs:boolean"" />
                        <xs:attribute name=""ACH_Account_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Standard_Cash_Available__c"" type=""xs:double"" />
                        <xs:attribute name=""State__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Tax_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""US_Citizen_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""U_S_Citizen__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Years_Employed__c"" type=""xs:double"" />
                        <xs:attribute name=""Zip_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""Total_SBA_Loans__c"" type=""xs:double"" />
                        <xs:attribute name=""Age__c"" type=""xs:double"" />
                        <xs:attribute name=""SBA_Employee__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Manual_CBR_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""ACH_Account_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""ACH_Routing_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Borrower_Guarantor__c"" type=""xs:string"" />
                        <xs:attribute name=""Entity_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Manual_IRS_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Manual_SBA_History_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Ownership_Percent__c"" type=""xs:double"" />
                        <xs:attribute name=""Parent__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Employee_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Title__c"" type=""xs:string"" />
                        <xs:attribute name=""Trade_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Date_of_Birth__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""EIN__c"" type=""xs:string"" />
                        <xs:attribute name=""Related_Parent__c"" type=""xs:string"" />
                        <xs:attribute name=""SSN__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Annual_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Stated_Gross_Monthly_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Date_Established__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Family_Size__c"" type=""xs:double"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Applicant__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""RecordTypeId"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastActivityDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastViewedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastReferencedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Account__c"" type=""xs:string"" />
                        <xs:attribute name=""Allowable_MAFD__c"" type=""xs:double"" />
                        <xs:attribute name=""App_Processing_Variables__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Relation_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Character_Issues__c"" type=""xs:boolean"" />
                        <xs:attribute name=""City__c"" type=""xs:string"" />
                        <xs:attribute name=""Contact__c"" type=""xs:string"" />
                        <xs:attribute name=""County__c"" type=""xs:string"" />
                        <xs:attribute name=""Credit_Score__c"" type=""xs:double"" />
                        <xs:attribute name=""Employer_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""Employer_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Exceeds_Standard_Calculation__c"" type=""xs:double"" />
                        <xs:attribute name=""External_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""Gross_Annual_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Gross_Monthly_Income2__c"" type=""xs:double"" />
                        <xs:attribute name=""Gross_Monthly_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""MAFD_P__c"" type=""xs:double"" />
                        <xs:attribute name=""MAFD__c"" type=""xs:double"" />
                        <xs:attribute name=""Monthly_Fixed_Debt__c"" type=""xs:double"" />
                        <xs:attribute name=""Months_Employed__c"" type=""xs:double"" />
                        <xs:attribute name=""New_Debt_Load__c"" type=""xs:double"" />
                        <xs:attribute name=""Occupation__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Income_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Income_Source_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Other_Income_Source__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Applicant__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Primary_Wage_Earner__c"" type=""xs:boolean"" />
                        <xs:attribute name=""ACH_Account_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Standard_Cash_Available__c"" type=""xs:double"" />
                        <xs:attribute name=""State__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Tax_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""US_Citizen_Details__c"" type=""xs:string"" />
                        <xs:attribute name=""U_S_Citizen__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Years_Employed__c"" type=""xs:double"" />
                        <xs:attribute name=""Zip_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""Total_SBA_Loans__c"" type=""xs:double"" />
                        <xs:attribute name=""Age__c"" type=""xs:double"" />
                        <xs:attribute name=""SBA_Employee__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Manual_CBR_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""ACH_Account_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""ACH_Routing_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Borrower_Guarantor__c"" type=""xs:string"" />
                        <xs:attribute name=""Entity_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Legal_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Manual_IRS_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Manual_SBA_History_Pull__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Ownership_Percent__c"" type=""xs:double"" />
                        <xs:attribute name=""Parent__c"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Employee_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Title__c"" type=""xs:string"" />
                        <xs:attribute name=""Trade_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Date_of_Birth__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""EIN__c"" type=""xs:string"" />
                        <xs:attribute name=""Related_Parent__c"" type=""xs:string"" />
                        <xs:attribute name=""SSN__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Annual_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Stated_Gross_Monthly_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Date_Established__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Family_Size__c"" type=""xs:double"" />
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
      <xs:attribute name=""AffectedRows"" type=""xs:int"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CDataServiceUpdateApplicant__c() {
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
        
        [Schema(@"http://sba-oda/DLAP/UpdateApplicant__c",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/UpdateApplicant__c",@"table")]
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
