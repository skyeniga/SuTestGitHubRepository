namespace Salesforce_Application_Import_Definition.Event_Request__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"QueryResult"})]
    public sealed class RestEventRequestQuery : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPApplicationImport/REST/Query/EventRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPApplicationImport/REST/Query/EventRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SOQL_EventRequest_QUERY"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QueryResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""records"">
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
            <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""totalSize"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestEventRequestQuery() {
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
                _RootElements[1] = "QueryResult";
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
        
        [Schema(@"http://SBA.gov/DLAPApplicationImport/REST/Query/EventRequest",@"Request")]
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
        
        [Schema(@"http://SBA.gov/DLAPApplicationImport/REST/Query/EventRequest",@"QueryResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryResult"})]
        public sealed class QueryResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryResult";
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
