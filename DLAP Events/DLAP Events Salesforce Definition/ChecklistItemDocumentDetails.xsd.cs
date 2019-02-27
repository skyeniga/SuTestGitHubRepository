namespace DLAPEventsSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPEvents/ChecklistItemDocumentList",@"ChecklistItemDocumentList")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ChecklistItemDocumentList"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c))]
    public sealed class ChecklistItemDocumentDetails : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://SBA.gov/DLAPEvents/ChecklistItemDocumentList"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPEvents/ChecklistItemDocumentList"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c"" namespace=""http://SBA.gov/DLAPEvents/ContentVersion__c"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://SBA.gov/DLAPEvents/ContentVersion__c"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ChecklistItemDocumentList"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Responses"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q1=""http://SBA.gov/DLAPEvents/ContentVersion__c"" minOccurs=""0"" maxOccurs=""1"" ref=""q1:Response"" />
              <xs:element name=""ClosingDocumentApplicantId"" type=""xs:string"" />
              <xs:element name=""DocumentChecklist_Item_Status__c"" type=""xs:string"" />
              <xs:element name=""DocumentMasterCheckListName"" type=""xs:string"" />
              <xs:element name=""DocumentMasterChecklist_Description__c"" type=""xs:string"" />
              <xs:element name=""Type"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ChecklistItemDocumentDetails() {
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
