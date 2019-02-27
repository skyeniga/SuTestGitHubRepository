namespace DLAPDocumentRetrievalSalesforceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaveRequest", @"results"})]
    public sealed class RestEvent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SaveRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""true"" name=""allOrNone"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""OwnerId"" type=""xs:string"" />
              <xs:element name=""IsDeleted"" type=""xs:boolean"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Application_Number__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Request_Date__c"" type=""xs:dateTime"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""SObject_ID__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Log_Message__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""SObject_Name__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""Stage__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Status__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""Auto_Decline_Reason__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""GUID__c"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute default=""Event_Request__c"" name=""type"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""results"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""errors"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""warnings"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""id"" type=""xs:string"" />
              <xs:element name=""success"" type=""xs:boolean"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestEvent() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SaveRequest";
                _RootElements[1] = "results";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest",@"SaveRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaveRequest"})]
        public sealed class SaveRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaveRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SaveRequest";
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/REST/INSERT/EventRequest",@"results")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"results"})]
        public sealed class results : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public results() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "results";
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
