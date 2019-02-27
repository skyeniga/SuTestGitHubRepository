namespace DLAPEventsSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DLAPEventsSalesforceDefinition/SingleNotificationEvent",@"Notifications")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Notifications"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.DLAPMultipleEvents1", typeof(global::DLAPEventsSalesforceDefinition.DLAPMultipleEvents1))]
    public sealed class SingleNotificationEvent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns1=""urn:sobject.enterprise.soap.sforce.com"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""DLAPEventsSalesforceDefinition.DLAPMultipleEvents1"" namespace=""http://soap.sforce.com/2005/09/outbound"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://soap.sforce.com/2005/09/outbound"" />
        <b:reference targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Notifications"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://soap.sforce.com/2005/09/outbound"" maxOccurs=""unbounded"" ref=""q1:Notification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SingleNotificationEvent() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Notifications";
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
