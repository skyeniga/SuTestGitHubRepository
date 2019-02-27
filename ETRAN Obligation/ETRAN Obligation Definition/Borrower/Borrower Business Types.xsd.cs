namespace SBA.ETRANObligation.Definition.Borrower {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/",@"BorrowerBusinessTypes")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BorrowerBusinessTypes"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping", typeof(global::SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping))]
    public sealed class BorrowerBusinessTypes : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:orgtype=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping"" namespace=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""BorrowerBusinessTypes"" type=""BorrowerBusinessTypes"" />
  <xs:complexType name=""BorrowerBusinessTypes"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""BorrowerBusinessType"" type=""BorrowerBusinessType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BorrowerBusinessType"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ApplicantId"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""orgtype:LegalOrgTypeMapping"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        private const global::SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping  __DummyVar0 = null;
        
        public BorrowerBusinessTypes() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "BorrowerBusinessTypes";
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
