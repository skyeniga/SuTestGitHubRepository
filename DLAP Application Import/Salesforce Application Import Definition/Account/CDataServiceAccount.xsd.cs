namespace Salesforce_Application_Import_Definition.Account {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceAccount : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Account"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Account"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""MasterRecordId"" type=""xs:string"" />
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""Type"" type=""xs:string"" />
                        <xs:attribute name=""ParentId"" type=""xs:string"" />
                        <xs:attribute name=""BillingStreet"" type=""xs:string"" />
                        <xs:attribute name=""BillingCity"" type=""xs:string"" />
                        <xs:attribute name=""BillingState"" type=""xs:string"" />
                        <xs:attribute name=""BillingPostalCode"" type=""xs:string"" />
                        <xs:attribute name=""BillingCountry"" type=""xs:string"" />
                        <xs:attribute name=""BillingLatitude"" type=""xs:double"" />
                        <xs:attribute name=""BillingLongitude"" type=""xs:double"" />
                        <xs:attribute name=""BillingGeocodeAccuracy"" type=""xs:string"" />
                        <xs:attribute name=""ShippingStreet"" type=""xs:string"" />
                        <xs:attribute name=""ShippingCity"" type=""xs:string"" />
                        <xs:attribute name=""ShippingState"" type=""xs:string"" />
                        <xs:attribute name=""ShippingPostalCode"" type=""xs:string"" />
                        <xs:attribute name=""ShippingCountry"" type=""xs:string"" />
                        <xs:attribute name=""ShippingLatitude"" type=""xs:double"" />
                        <xs:attribute name=""ShippingLongitude"" type=""xs:double"" />
                        <xs:attribute name=""ShippingGeocodeAccuracy"" type=""xs:string"" />
                        <xs:attribute name=""Phone"" type=""xs:string"" />
                        <xs:attribute name=""Website"" type=""xs:string"" />
                        <xs:attribute name=""PhotoUrl"" type=""xs:string"" />
                        <xs:attribute name=""Industry"" type=""xs:string"" />
                        <xs:attribute name=""NumberOfEmployees"" type=""xs:int"" />
                        <xs:attribute name=""Description"" type=""xs:string"" />
                        <xs:attribute name=""OwnerId"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastActivityDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastViewedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastReferencedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""IsCustomerPortal"" type=""xs:boolean"" />
                        <xs:attribute name=""Jigsaw"" type=""xs:string"" />
                        <xs:attribute name=""JigsawCompanyId"" type=""xs:string"" />
                        <xs:attribute name=""AccountSource"" type=""xs:string"" />
                        <xs:attribute name=""SicDesc"" type=""xs:string"" />
                        <xs:attribute name=""Business_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""County__c"" type=""xs:string"" />
                        <xs:attribute name=""Business_Activity__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Residence__c"" type=""xs:boolean"" />
                        <xs:attribute name=""Primary_Residence_Owned__c"" type=""xs:string"" />
                        <xs:attribute name=""Damage_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Contact__c"" type=""xs:string"" />
                        <xs:attribute name=""Date_Current_Management__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Date_Established__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""EIN__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Resi_Owned__c"" type=""xs:string"" />
                        <xs:attribute name=""Primary_Resi__c"" type=""xs:string"" />
                        <xs:attribute name=""Trade_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Email_Address__c"" type=""xs:string"" />
                        <xs:attribute name=""Phone_Number__c"" type=""xs:string"" />
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
        
        public CDataServiceAccount() {
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
        
        [Schema(@"http://sba-oda/DLAP/Account",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Account",@"table")]
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
