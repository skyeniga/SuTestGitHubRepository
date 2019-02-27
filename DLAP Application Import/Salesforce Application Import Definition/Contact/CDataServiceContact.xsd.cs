namespace Salesforce_Application_Import_Definition_XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceContact : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://sba-oda/DLAP/Contact"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Contact"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Contact"">
                      <xs:complexType>
                        <xs:attribute name=""Name"" type=""xs:string"" />
                        <xs:attribute name=""LastName"" type=""xs:string"" />
                        <xs:attribute name=""FirstName"" type=""xs:string"" />
                        <xs:attribute name=""MiddleName"" type=""xs:string"" />
                        <xs:attribute name=""Suffix"" type=""xs:string"" />
                        <xs:attribute name=""MailingStreet"" type=""xs:string"" />
                        <xs:attribute name=""MailingCity"" type=""xs:string"" />
                        <xs:attribute name=""MailingState"" type=""xs:string"" />
                        <xs:attribute name=""MailingPostalCode"" type=""xs:string"" />
                        <xs:attribute name=""MailingCountry"" type=""xs:string"" />
                        <xs:attribute name=""Phone"" type=""xs:string"" />
                        <xs:attribute name=""Fax"" type=""xs:string"" />
                        <xs:attribute name=""MobilePhone"" type=""xs:string"" />
                        <xs:attribute name=""Email"" type=""xs:string"" />
                        <xs:attribute name=""Birthdate"" type=""xs:dateTime"" />
                        <xs:attribute name=""Social_Security_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Marital_Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Family_Size__c"" type=""xs:double"" />
                        <xs:attribute name=""Self_Employed__c"" type=""xs:string"" />
                        <xs:attribute name=""Work_Phone__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Relative_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Applicant_Relative_Phone_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""ExternalIdColumn"" type=""xs:string"" />
                        <xs:attribute name=""Organization_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Title"" type=""xs:string"" />
                        <xs:attribute name=""U_S_Citizen__c"" type=""xs:string"" />
                        <xs:attribute name=""AccountId"" type=""xs:string"" />
                        <xs:attribute name=""SBA_Employee__c"" type=""xs:string"" />
                        <xs:attribute name=""Date_Business_Established__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""Preferred_Phone_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""HomePhone"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""IsUpsert"" type=""xs:string"" />
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
        
        public CDataServiceContact() {
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
        
        [Schema(@"http://sba-oda/DLAP/Contact",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Contact",@"table")]
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
