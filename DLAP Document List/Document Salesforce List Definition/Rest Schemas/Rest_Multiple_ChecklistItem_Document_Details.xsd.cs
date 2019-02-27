namespace DLAPDocumentListSalesforceDefinition.Rest_Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAP/DocumentList",@"ChecklistItemDocumentList")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ChecklistItemDocumentList"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details", typeof(global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details))]
    public sealed class Rest_Multiple_ChecklistItem_Document_Details : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://SBA.gov/DLAP/DocumentList"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAP/DocumentList"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details"" namespace=""http://SBA.gov/REST/ClosingDocumentsDocumentList"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://SBA.gov/REST/ClosingDocumentsDocumentList"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ChecklistItemDocumentList"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Responses"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q1=""http://SBA.gov/REST/ClosingDocumentsDocumentList"" minOccurs=""0"" maxOccurs=""1"" ref=""q1:QueryResult"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Rest_Multiple_ChecklistItem_Document_Details() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ChecklistItemDocumentList";
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
