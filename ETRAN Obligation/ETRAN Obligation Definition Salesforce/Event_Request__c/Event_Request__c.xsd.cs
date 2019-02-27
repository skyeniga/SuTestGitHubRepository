namespace SBA.ETRANObligation.Definition.Salesforce.Event_Request__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/",@"Event_Request__c")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Id", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Id' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "GUID__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='GUID__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Application_Number__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Application_Number__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Log_Message__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Log_Message__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SObject_ID__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='SObject_ID__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SObject_Name__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='SObject_Name__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Stage__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Stage__c' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status__c", XPath = @"/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Status__c' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Event_Request__c"})]
    public sealed class Event_Request__c : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""Event_Request__c"">
    <xs:attribute name=""Id"" type=""xs:string"" />
    <xs:attribute name=""GUID__c"" type=""xs:string"" />
    <xs:attribute name=""Application_Number__c"" type=""xs:string"" />
    <xs:attribute name=""Log_Message__c"" type=""xs:string"" />
    <xs:attribute name=""SObject_ID__c"" type=""xs:string"" />
    <xs:attribute name=""SObject_Name__c"" type=""xs:string"" />
    <xs:attribute name=""Stage__c"" type=""xs:string"" />
    <xs:attribute name=""Status__c"" type=""xs:string"" />
  </xs:complexType>
  <xs:element name=""Event_Request__c"" type=""Event_Request__c"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Id' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='GUID__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Application_Number__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Log_Message__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='SObject_ID__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='SObject_Name__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Stage__c' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Event_Request__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/']/@*[local-name()='Status__c' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public Event_Request__c() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Event_Request__c";
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
