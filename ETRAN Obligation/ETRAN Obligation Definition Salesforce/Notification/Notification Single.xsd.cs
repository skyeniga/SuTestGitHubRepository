namespace SBA.ETRANObligation.Definition.Salesforce.Notification {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/",@"Notification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sObject.Application_Number__c", XPath = @"/*[local-name()='Notification' and namespace-uri()='http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Application_Number__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "sObject.SObject_ID__c", XPath = @"/*[local-name()='Notification' and namespace-uri()='http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='SObject_ID__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Notification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound))]
    public sealed class NotificationSingle : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://soap.sforce.com/2005/09/outbound"" targetNamespace=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound"" namespace=""http://soap.sforce.com/2005/09/outbound"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://soap.sforce.com/2005/09/outbound"" />
        <b:reference targetNamespace=""urn:enterprise.soap.sforce.com"" />
        <b:reference targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Notification"" type=""ns0:Event_Request__cNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Notification' and namespace-uri()='http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='Application_Number__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Notification' and namespace-uri()='http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/']/*[local-name()='sObject' and namespace-uri()='http://soap.sforce.com/2005/09/outbound']/*[local-name()='SObject_ID__c' and namespace-uri()='urn:sobject.enterprise.soap.sforce.com']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public NotificationSingle() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Notification";
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
