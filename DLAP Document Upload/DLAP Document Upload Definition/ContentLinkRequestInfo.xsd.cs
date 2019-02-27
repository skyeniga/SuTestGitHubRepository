namespace SBA.DLAPDocumentUpload.Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DocumentUploadDefinition/ContentLinkRequestInfo",@"ContentLinkRequestInfo")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "APPLICATIONSFID", XPath = @"/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='APPLICATIONSFID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ACTION_ID", XPath = @"/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='ACTION_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RECEIPTDOCUMENT_ID", XPath = @"/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='RECEIPTDOCUMENT_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CONTENTVERSION_DOCUMENTID", XPath = @"/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='CONTENTVERSION_DOCUMENTID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RECEIPTLOAN_NUMBER", XPath = @"/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='RECEIPTLOAN_NUMBER' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ContentLinkRequestInfo"})]
    public sealed class ContentLinkRequestInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DocumentUploadDefinition/ContentLinkRequestInfo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://DocumentUploadDefinition/ContentLinkRequestInfo"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ContentLinkRequestInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='APPLICATIONSFID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='ACTION_ID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='RECEIPTDOCUMENT_ID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='CONTENTVERSION_DOCUMENTID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentLinkRequestInfo' and namespace-uri()='http://DocumentUploadDefinition/ContentLinkRequestInfo']/*[local-name()='RECEIPTLOAN_NUMBER' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""APPLICATIONSFID"" type=""xs:string"" />
        <xs:element name=""ACTION_ID"" type=""xs:string"" />
        <xs:element name=""RECEIPTDOCUMENT_ID"" type=""xs:string"" />
        <xs:element name=""CONTENTVERSION_DOCUMENTID"" type=""xs:string"" />
        <xs:element name=""RECEIPTLOAN_NUMBER"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ContentLinkRequestInfo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ContentLinkRequestInfo";
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
