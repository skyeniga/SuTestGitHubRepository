namespace Salesforce_Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataService_Asset_Incomes__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Asset_Incomes__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Asset_Incomes__c"">
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
                        <xs:attribute name=""Alimony__c"" type=""xs:double"" />
                        <xs:attribute name=""Business__c"" type=""xs:double"" />
                        <xs:attribute name=""Cash_Available_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Household_Goods_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""IRA_Retirement_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Loan__c"" type=""xs:string"" />
                        <xs:attribute name=""Pension__c"" type=""xs:double"" />
                        <xs:attribute name=""Primary_Residence_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Residence_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""Retirement_Accounts__c"" type=""xs:double"" />
                        <xs:attribute name=""SS_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Stocks_and_securities_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Trust__c"" type=""xs:double"" />
                        <xs:attribute name=""Wages__c"" type=""xs:double"" />
                        <xs:attribute name=""X1_Interests_Dividends__c"" type=""xs:double"" />
                        <xs:attribute name=""X1_Other_Assets_Description__c"" type=""xs:string"" />
                        <xs:attribute name=""X1_Other_Assets_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""X1_Other_Real_Estate_Owned_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""X1_Other_Real_Estate_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""X2_Interests_Dividends__c"" type=""xs:double"" />
                        <xs:attribute name=""X2_Other_Assets_Description__c"" type=""xs:string"" />
                        <xs:attribute name=""X2_Other_Assets_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""X2_Other_Real_Estate_Owned_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""X2_Other_Real_Estate_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""X3_Interests_Dividends__c"" type=""xs:double"" />
                        <xs:attribute name=""X3_Other_Real_Estate_Owned_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""X3_Other_Real_Estate_Value__c"" type=""xs:double"" />
                        <xs:attribute name=""Applicant__c"" type=""xs:string"" />
                        <xs:attribute name=""Gross_Income_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Child_Support__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Income_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Other_Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Gross_Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Active__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Interest_Dividends__c"" type=""xs:double"" />
                        <xs:attribute name=""Other__c"" type=""xs:double"" />
                        <xs:attribute name=""Partnerships_and_S_Corporations__c"" type=""xs:double"" />
                        <xs:attribute name=""Stated_Gross_Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Stated_Gross_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Annual_Income__c"" type=""xs:double"" />
                        <xs:attribute name=""Income_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Type__c"" type=""xs:string"" />
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
        
        public CDataService_Asset_Incomes__c() {
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
        
        [Schema(@"http://sba-oda/DLAP/Asset_Incomes__c",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Asset_Incomes__c",@"table")]
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
