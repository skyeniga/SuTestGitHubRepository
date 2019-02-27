namespace DocumentRetrievalDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse",@"RetrievalResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"RetrievalResponse"})]
    public sealed class DocumentRetrievalResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""RetrievalResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Document_content"" type=""xs:base64Binary"" />
        <xs:element name=""Doc_content_type"" type=""xs:string"" />
        <xs:element name=""Doc_retrieve_status"" type=""xs:string"" />
        <xs:element name=""Doc_retrieve_status_details"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DocumentRetrievalResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "RetrievalResponse";
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
