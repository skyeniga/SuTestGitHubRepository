namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DLAPDocumentListDefinition.ClosingDocsSFID",@"SFIDValues")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SFIDValues"})]
    public sealed class Checklistitem_ClosingDocs_SFID : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DLAPDocumentListDefinition.ClosingDocsSFID"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://DLAPDocumentListDefinition.ClosingDocsSFID"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SFIDValues"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Multiple_Checklistitem_SFID_Values"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Checklistitem_ClosingDocs_SFID() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SFIDValues";
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
