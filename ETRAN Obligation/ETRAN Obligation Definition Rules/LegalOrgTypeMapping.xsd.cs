namespace SBA.ETRANObligation.Definition.Rules {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/",@"LegalOrgTypeMapping")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SalesforceBusinessType", XPath = @"/*[local-name()='LegalOrgTypeMapping' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']/*[local-name()='SalesforceBusinessType' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Decimal), "ETranLegalOrgTypeCode", XPath = @"/*[local-name()='LegalOrgTypeMapping' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']/*[local-name()='ETranLegalOrgTypeCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']", XsdType = @"integer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LegalOrgTypeMapping"})]
    public sealed class LegalOrgTypeMapping : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""LegalOrgTypeMapping"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='LegalOrgTypeMapping' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']/*[local-name()='SalesforceBusinessType' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='LegalOrgTypeMapping' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']/*[local-name()='ETranLegalOrgTypeCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""SalesforceBusinessType"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" default=""0"" name=""ETranLegalOrgTypeCode"" nillable=""true"" type=""xs:integer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public LegalOrgTypeMapping() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "LegalOrgTypeMapping";
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
