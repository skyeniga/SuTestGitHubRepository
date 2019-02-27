namespace DLAPDocumentUploadSalesForceDefinition.Rest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest",@"SaveRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Application_Number__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Application_Number__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.SObject_ID__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='SObject_ID__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Log_Message__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Log_Message__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.SObject_Name__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='SObject_Name__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Stage__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Stage__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Status__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Status__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Auto_Decline_Reason__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Auto_Decline_Reason__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.GUID__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='GUID__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaveRequest"})]
    public sealed class RestEventRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SaveRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Application_Number__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='SObject_ID__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Log_Message__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='SObject_Name__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Stage__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Status__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='Auto_Decline_Reason__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']/*[local-name()='GUID__c' and namespace-uri()='http://SBA.gov/DLAPDocumentUpload/REST/INSERT/EventRequest']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""true"" name=""allOrNone"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""OwnerId"" type=""xs:string"" />
              <xs:element name=""IsDeleted"" type=""xs:boolean"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Application_Number__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Request_Date__c"" type=""xs:dateTime"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""SObject_ID__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Log_Message__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""SObject_Name__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""Stage__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" default=""&lt;empty&gt;"" name=""Status__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""Auto_Decline_Reason__c"" type=""xs:string"" />
              <xs:element default=""&lt;empty&gt;"" name=""GUID__c"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute default=""Event_Request__c"" name=""type"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestEventRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SaveRequest";
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
