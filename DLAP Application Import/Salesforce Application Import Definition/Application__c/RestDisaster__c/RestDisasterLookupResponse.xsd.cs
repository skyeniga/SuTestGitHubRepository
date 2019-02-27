namespace Salesforce_Application_Import_Definition.Application__c.RestDisaster__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupResponse",@"QueryResult")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"QueryResult"})]
    public sealed class RestDisasterLookupResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""QueryResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:boolean"" />
        <xs:element maxOccurs=""unbounded"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""External_Id_DMS_Number__c"" type=""xs:string"" />
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
        
        public RestDisasterLookupResponse() {
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
