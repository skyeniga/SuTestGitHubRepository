namespace Salesforce_Application_Import_Definition_XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"parameters", @"table"})]
    public sealed class CDataServiceInsurance__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://sba-oda/DLAP/Insurance__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""parameters"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Insurance__c"">
                      <xs:complexType>
                        <xs:attribute name=""Application__c"" type=""xs:string"" />
                        <xs:attribute name=""Type_of_Insurance_Coverage__c"" type=""xs:string"" />
                        <xs:attribute name=""Insurance_Company_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Insurance_Agent_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Insurance_Agent_Phone_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Insurance_Policy_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Insurance_Recovery_Amount__c"" type=""xs:double"" />
                        <xs:attribute name=""Property__c"" type=""xs:string"" />
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
        
        public CDataServiceInsurance__c() {
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
        
        [Schema(@"http://sba-oda/DLAP/Insurance__c",@"parameters")]
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
        
        [Schema(@"http://sba-oda/DLAP/Insurance__c",@"table")]
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
