namespace SBA.DLAPDocumentUpload.SalesForceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request", @"Response"})]
    public sealed class Salesforce_ContentVersion : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentUpload/ContentVersion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/ContentVersion"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ContentVersion"">
                      <xs:complexType>
                        <xs:attribute name=""Id"" type=""xs:string"" />
                        <xs:attribute name=""ContentDocumentId"" type=""xs:string"" />
                        <xs:attribute name=""IsLatest"" type=""xs:boolean"" />
                        <xs:attribute name=""ContentUrl"" type=""xs:string"" />
                        <xs:attribute name=""ContentBodyId"" type=""xs:string"" />
                        <xs:attribute name=""VersionNumber"" type=""xs:string"" />
                        <xs:attribute name=""Title"" type=""xs:string"" />
                        <xs:attribute name=""Description"" type=""xs:string"" />
                        <xs:attribute name=""ReasonForChange"" type=""xs:string"" />
                        <xs:attribute name=""SharingOption"" type=""xs:string"" />
                        <xs:attribute name=""SharingPrivacy"" type=""xs:string"" />
                        <xs:attribute name=""PathOnClient"" type=""xs:string"" />
                        <xs:attribute name=""RatingCount"" type=""xs:int"" />
                        <xs:attribute name=""IsDeleted"" type=""xs:boolean"" />
                        <xs:attribute name=""ContentModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""ContentModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""PositiveRatingCount"" type=""xs:int"" />
                        <xs:attribute name=""NegativeRatingCount"" type=""xs:int"" />
                        <xs:attribute name=""FeaturedContentBoost"" type=""xs:int"" />
                        <xs:attribute name=""FeaturedContentDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""OwnerId"" type=""xs:string"" />
                        <xs:attribute name=""CreatedById"" type=""xs:string"" />
                        <xs:attribute name=""CreatedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""LastModifiedById"" type=""xs:string"" />
                        <xs:attribute name=""LastModifiedDate"" type=""xs:dateTime"" />
                        <xs:attribute name=""SystemModstamp"" type=""xs:dateTime"" />
                        <xs:attribute name=""TagCsv"" type=""xs:string"" />
                        <xs:attribute name=""FileType"" type=""xs:string"" />
                        <xs:attribute name=""PublishStatus"" type=""xs:string"" />
                        <xs:attribute name=""VersionData"" type=""xs:string"" />
                        <xs:attribute name=""ContentSize"" type=""xs:int"" />
                        <xs:attribute name=""FileExtension"" type=""xs:string"" />
                        <xs:attribute name=""FirstPublishLocationId"" type=""xs:string"" />
                        <xs:attribute name=""Origin"" type=""xs:string"" />
                        <xs:attribute name=""NetworkId"" type=""xs:string"" />
                        <xs:attribute name=""ContentLocation"" type=""xs:string"" />
                        <xs:attribute name=""TextPreview"" type=""xs:string"" />
                        <xs:attribute name=""ExternalDocumentInfo1"" type=""xs:string"" />
                        <xs:attribute name=""ExternalDocumentInfo2"" type=""xs:string"" />
                        <xs:attribute name=""ExternalDataSourceId"" type=""xs:string"" />
                        <xs:attribute name=""Checksum"" type=""xs:string"" />
                        <xs:attribute name=""IsMajorVersion"" type=""xs:boolean"" />
                        <xs:attribute name=""IsAssetEnabled"" type=""xs:boolean"" />
                        <xs:attribute name=""New_Parent_Application_No__c"" type=""xs:string"" />
                        <xs:attribute name=""Document_Type__c"" type=""xs:string"" />
                        <xs:attribute name=""Verified_Date__c"" type=""xs:dateTime"" />
                        <xs:attribute name=""DLAPUserID__c"" type=""xs:string"" />
                        <xs:attribute name=""DLAP_Document_Type__c"" type=""xs:string"" />
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
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Record"">
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
        
        public Salesforce_ContentVersion() {
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/ContentVersion",@"Request")]
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
        
        [Schema(@"http://SBA.gov/DLAPDocumentUpload/ContentVersion",@"Response")]
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
