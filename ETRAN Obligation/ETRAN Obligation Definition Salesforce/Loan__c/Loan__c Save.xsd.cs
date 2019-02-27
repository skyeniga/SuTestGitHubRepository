namespace SBA.ETRANObligation.Definition.Salesforce.Loan__c {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "allOrNone", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='allOrNone' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"boolean")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.type", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/@*[local-name()='type' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Id", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Obligated_Date__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Obligated_Date__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.ETRAN_Loan_Number__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='ETRAN_Loan_Number__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.errors.message", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.errors.statusCode", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.warnings.message", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.warnings.statusCode", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.id", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "result.success", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='success' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaveRequest", @"results"})]
    public sealed class Loan__c_Save : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SaveRequest"" type=""SaveRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='allOrNone' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/@*[local-name()='type' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Obligated_Date__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='ETRAN_Loan_Number__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""SaveRequest"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""false"" name=""allOrNone"" type=""xs:boolean"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""records"" type=""Loan__c"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""results"" type=""results"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='success' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""results"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""result"" type=""result"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""result"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""errors"" nillable=""true"" type=""errorwarning"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""warnings"" type=""errorwarning"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""id"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" default=""false"" name=""success"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""Loan__c"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Id"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Obligated_Date__c"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ETRAN_Loan_Number__c"" type=""xs:string"" />
    </xs:sequence>
    <xs:attribute default=""Loan__c"" name=""type"" type=""xs:string"" />
  </xs:complexType>
  <xs:complexType name=""errorwarning"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""message"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""statusCode"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Loan__c_Save() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SaveRequest";
                _RootElements[1] = "results";
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
        
        [Schema(@"http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/",@"SaveRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "allOrNone", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='allOrNone' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"boolean")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.type", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/@*[local-name()='type' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Id", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.Obligated_Date__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='Obligated_Date__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "records.ETRAN_Loan_Number__c", XPath = @"/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='records' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='ETRAN_Loan_Number__c' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaveRequest"})]
        public sealed class SaveRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaveRequest() {
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
        
        [Schema(@"http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/",@"results")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.errors.message", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.errors.statusCode", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.warnings.message", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='message' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.warnings.statusCode", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='warnings' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='statusCode' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "result.id", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='id' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "result.success", XPath = @"/*[local-name()='results' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='result' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']/*[local-name()='success' and namespace-uri()='http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/']", XsdType = @"boolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"results"})]
        public sealed class results : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public results() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "results";
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
}
