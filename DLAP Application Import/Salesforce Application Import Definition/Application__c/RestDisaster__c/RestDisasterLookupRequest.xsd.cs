namespace Salesforce_Application_Import_Definition.Application__c.RestDisaster__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequest",@"RestDisasterLookupRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"RestDisasterLookupRequest"})]
    public sealed class RestDisasterLookupRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""RestDisasterLookupRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""External_Id_DMS_Number__cQuery"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestDisasterLookupRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "RestDisasterLookupRequest";
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
