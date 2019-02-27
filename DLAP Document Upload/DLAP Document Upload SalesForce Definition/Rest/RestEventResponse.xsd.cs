namespace DLAPDocumentUploadSalesForceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventResponse",@"results")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"results"})]
    public sealed class RestEventResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""results"" type=""results"" />
  <xs:complexType name=""results"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""result"" type=""result"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""result"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""errors"" type=""errors"" />
      <xs:element name=""warnings"" type=""warnings"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""id"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""false"" name=""success"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""errors"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""message"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""statusCode"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""warnings"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""message"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""statusCode"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public RestEventResponse() {
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
