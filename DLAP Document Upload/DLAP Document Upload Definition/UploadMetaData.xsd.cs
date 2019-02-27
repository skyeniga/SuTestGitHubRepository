namespace DLAPDocumentUploadDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"ReceiptMetaData")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReceiptMetaData"})]
    public sealed class UploadMetaData : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""ReceiptMetaData"">
    <xsd:complexType>
      <xsd:sequence>
        <xsd:element name=""DamagedPropertyAddress"" type=""xsd:unsignedShort"" />
        <xsd:element name=""DocumentType"" type=""xsd:string"" />
        <xsd:element name=""UseOfProceeds"" type=""xsd:string"" />
        <xsd:element name=""ServiceProviderName"" type=""xsd:string"" />
        <xsd:element name=""DocumentDate"" type=""xsd:string"" />
        <xsd:element name=""DocumentNumber"" type=""xsd:unsignedShort"" />
        <xsd:element name=""TotalAmount"" type=""xsd:decimal"" />
        <xsd:element name=""IsDocumentScanned"" type=""xsd:boolean"" />
        <xsd:element name=""UploadDocumentName"" type=""xsd:string"" />
        <xsd:element name=""UploadSuccess"" type=""xsd:boolean"" />
        <xsd:element name=""LoanNumber"" type=""xsd:string"" />
      </xsd:sequence>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>";
        
        public UploadMetaData() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ReceiptMetaData";
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
