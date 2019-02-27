namespace DLAPEventsSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.Event_Request__c.GUID__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='GUID__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.Event_Request__c.Log_Message__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='Log_Message__c' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"Response"})]
    public sealed class Salesforce_EventRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPEvents/Event_Request__c"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPEvents/Event_Request__c"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='GUID__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='Log_Message__c' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""before"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Event_Request__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""OwnerId"" type=""xs:string"" />
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
                        <xs:attribute name=""Application_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Auto_Decline_Reason__c"" type=""xs:string"" />
                        <xs:attribute name=""GUID__c"" type=""xs:string"" />
                        <xs:attribute name=""Log_Message__c"" type=""xs:string"" />
                        <xs:attribute name=""Request_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""SObject_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""SObject_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Stage__c"" type=""xs:string"" />
                        <xs:attribute name=""Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Drawloop_Next__c"" type=""xs:string"" />
                        <xs:attribute name=""Created_By_Manual_Rerun__c"" type=""xs:boolean"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Event_Request__c"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""OwnerId"" type=""xs:string"" />
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
                        <xs:attribute name=""Application_Number__c"" type=""xs:string"" />
                        <xs:attribute name=""Auto_Decline_Reason__c"" type=""xs:string"" />
                        <xs:attribute name=""GUID__c"" type=""xs:string"" />
                        <xs:attribute name=""Log_Message__c"" type=""xs:string"" />
                        <xs:attribute name=""Request_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""SObject_ID__c"" type=""xs:string"" />
                        <xs:attribute name=""SObject_Name__c"" type=""xs:string"" />
                        <xs:attribute name=""Stage__c"" type=""xs:string"" />
                        <xs:attribute name=""Status__c"" type=""xs:string"" />
                        <xs:attribute name=""Drawloop_Next__c"" type=""xs:string"" />
                        <xs:attribute name=""Created_By_Manual_Rerun__c"" type=""xs:boolean"" />
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
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:attribute name=""AffectedRows"" type=""xs:int"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Salesforce_EventRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Request";
                _RootElements[1] = "Response";
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
        
        [Schema(@"http://SBA.gov/DLAPEvents/Event_Request__c",@"Request")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.Event_Request__c.GUID__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='GUID__c' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sync.after.Event_Request__c.Log_Message__c", XPath = @"/*[local-name()='Request' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='sync' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='after' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/DLAPEvents/Event_Request__c']/@*[local-name()='Log_Message__c' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Request"})]
        public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Request() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Request";
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
        
        [Schema(@"http://SBA.gov/DLAPEvents/Event_Request__c",@"Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Response"})]
        public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Response";
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
