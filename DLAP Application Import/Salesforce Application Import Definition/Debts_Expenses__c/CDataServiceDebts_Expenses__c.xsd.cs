namespace Salesforce_Application_Import_Definition_XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceDebts_Expenses__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://sba-oda/DLAP/Debts_Expenses__c"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Debts_Expenses__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Debts_Expenses__c"">
                      <xs:complexType>
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""No_Debts__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Landlord_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Rental_Property_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""City__c"" type=""xs:string"" />
                        <xs:attribute name=""State__c"" type=""xs:string"" />
                        <xs:attribute name=""Zip_Code__c"" type=""xs:string"" />
                        <xs:attribute name=""County__c"" type=""xs:string"" />
                        <xs:attribute name=""Real_Estate_Taxes__c"" type=""xs:string"" />
                        <xs:attribute name=""Real_Estate_Taxes_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Hazard_Insurance__c"" type=""xs:string"" />
                        <xs:attribute name=""Hazard_Insurance_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Condo_HOA_Fees__c"" type=""xs:string"" />
                        <xs:attribute name=""Condo_HOA_Fees_Frequency__c"" type=""xs:string"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""Monthly_Payment__c"" type=""xs:double"" />
                        <xs:attribute name=""Balance__c"" type=""xs:double"" />
                        <xs:attribute name=""How_Secured__c"" type=""xs:string"" />
                        <xs:attribute name=""Extraordinary_Expense_Monthly_Payment__c"" type=""xs:double"" />
                        <xs:attribute name=""Extraordinary_Expense_Description__c"" type=""xs:string"" />
                        <xs:attribute name=""Type_of_Debt__c"" type=""xs:string"" />
                        <xs:attribute name=""Active__c"" type=""xs:string"" />
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
        
        public CDataServiceDebts_Expenses__c() {
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
        
        [Schema(@"http://sba-oda/DLAP/Debts_Expenses__c",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Debts_Expenses__c",@"table")]
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
