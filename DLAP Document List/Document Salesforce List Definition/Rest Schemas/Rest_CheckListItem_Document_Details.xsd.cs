namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"QueryResult"})]
    public sealed class Rest_CheckListItem_Document_Details : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/REST/ClosingDocumentsDocumentList"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SalesforceDefintion.PropertySchema"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/REST/ClosingDocumentsDocumentList"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo />
  </xs:annotation>
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RequestSOQLQuery"" type=""xs:string"" />
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
              <xs:element name=""ContentDocument"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LatestPublishedVersion"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Id"" type=""xs:string"" />
                          <xs:element name=""DLAP_Document_Type__c"" type=""xs:unsignedShort"" />
                          <xs:element name=""Title"" type=""xs:string"" />
                          <xs:element name=""Description"" type=""xs:unsignedInt"" />
                          <xs:element name=""CreatedDate"" type=""xs:dateTime"" />
                          <xs:element name=""Document_Type__c"" type=""xs:string"" />
                          <xs:element name=""Document_Validity__c"" type=""xs:string"" />
                        </xs:sequence>
                        <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                        <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""url"" type=""xs:string"" use=""required"" />
                </xs:complexType>
              </xs:element>
              <xs:element name=""LinkedEntityId"" type=""xs:string"" />
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
        
        public Rest_CheckListItem_Document_Details() {
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
        
        [Schema(@"http://SBA.gov/REST/ClosingDocumentsDocumentList",@"Request")]
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
        
        [Schema(@"http://SBA.gov/REST/ClosingDocumentsDocumentList",@"QueryResult")]
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
