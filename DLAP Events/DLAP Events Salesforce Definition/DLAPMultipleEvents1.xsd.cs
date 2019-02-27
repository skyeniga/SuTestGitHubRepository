namespace DLAPEventsSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://soap.sforce.com/2005/09/outbound",@"Notification")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Notification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.DLAPMultipleEvents2", typeof(global::DLAPEventsSalesforceDefinition.DLAPMultipleEvents2))]
    public sealed class DLAPMultipleEvents1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://soap.sforce.com/2005/09/outbound"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://soap.sforce.com/2005/09/outbound"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""DLAPEventsSalesforceDefinition.DLAPMultipleEvents2"" namespace=""urn:sobject.enterprise.soap.sforce.com"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Notification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element name=""sObject"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q1=""urn:sobject.enterprise.soap.sforce.com"" maxOccurs=""unbounded"" ref=""q1:fieldsToNull"" />
              <xs:element xmlns:q2=""urn:sobject.enterprise.soap.sforce.com"" ref=""q2:Id"" />
              <xs:element xmlns:q3=""urn:sobject.enterprise.soap.sforce.com"" ref=""q3:Application_Number__c"" />
              <xs:element xmlns:q4=""urn:sobject.enterprise.soap.sforce.com"" ref=""q4:Log_Message__c"" />
              <xs:element xmlns:q5=""urn:sobject.enterprise.soap.sforce.com"" ref=""q5:SObject_ID__c"" />
              <xs:element xmlns:q6=""urn:sobject.enterprise.soap.sforce.com"" ref=""q6:SObject_Name__c"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DLAPMultipleEvents1() {
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
