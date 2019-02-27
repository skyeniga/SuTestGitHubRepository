namespace DLAPDocumentRetrievalSalesforceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.LatestPublishedVersion.VersionData", XPath = @"/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='LatestPublishedVersion' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='VersionData' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"QueryResult"})]
    public sealed class RestContentDocument : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SOQL_ContentVersionId_Query"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QueryResult"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='LatestPublishedVersion' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='VersionData' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""LatestPublishedVersion"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Id"" type=""xs:string"" />
                    <xs:element name=""VersionData"" type=""xs:string"" />
                    <xs:element name=""FileType"" type=""xs:string"" />
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
        <xs:element name=""totalSize"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestContentDocument() {
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument",@"Request")]
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument",@"QueryResult")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.LatestPublishedVersion.VersionData", XPath = @"/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='LatestPublishedVersion' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']/*[local-name()='VersionData' and namespace-uri()='http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument']", XsdType = @"string")]
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
