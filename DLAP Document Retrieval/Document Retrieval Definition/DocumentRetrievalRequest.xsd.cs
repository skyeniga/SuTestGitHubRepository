namespace DocumentRetrievalDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest",@"RetrievalRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"RetrievalRequest"})]
    public sealed class DocumentRetrievalRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""RetrievalRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ApplicationNumber"" type=""xs:string"" />
        <xs:element name=""UserID"" type=""xs:string"" />
        <xs:element name=""ActionID"" type=""xs:string"" />
        <xs:element name=""SDCID"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DocumentRetrievalRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "RetrievalRequest";
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
