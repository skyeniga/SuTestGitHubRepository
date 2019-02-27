namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ws.elend",@"SBA_Etran_Response")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.SByte), "AuthErrorNmb", XPath = @"/*[local-name()='SBA_Etran_Response' and namespace-uri()='http://ws.elend']/*[local-name()='AuthErrorNmb' and namespace-uri()='http://ws.elend']", XsdType = @"byte")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "AuthErrorText", XPath = @"/*[local-name()='SBA_Etran_Response' and namespace-uri()='http://ws.elend']/*[local-name()='AuthErrorText' and namespace-uri()='http://ws.elend']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SBA_Etran_Response"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes))]
    public sealed class SBA_ETran_Response_orig : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://ws.elend"" elementFormDefault=""qualified"" targetNamespace=""http://ws.elend"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes"" />
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes"" />
  <xs:element name=""SBA_Etran_Response"" type=""ns0:SBA_Etran_Response"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_Etran_Response' and namespace-uri()='http://ws.elend']/*[local-name()='AuthErrorNmb' and namespace-uri()='http://ws.elend']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_Etran_Response' and namespace-uri()='http://ws.elend']/*[local-name()='AuthErrorText' and namespace-uri()='http://ws.elend']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""SBA_LoanApplication"">
    <xs:sequence>
      <xs:element name=""Results"" type=""ns0:SBA_Results"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Errors"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Warnings"" type=""xs:string"" />
    </xs:sequence>
    <xs:attribute name=""LoanAppNmb"" type=""ns0:SBA_Str10"" />
  </xs:complexType>
  <xs:simpleType name=""empty-string"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value="""" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_GntyFeeOrEmpty"">
    <xs:union memberTypes=""ns0:SBA_GntyFee ns0:empty-string"" />
  </xs:simpleType>
  <xs:simpleType name=""SBA_OrigStatCdOrEmpty"">
    <xs:union memberTypes=""ns0:SBA_OrigStatCd ns0:empty-string"" />
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num3OrEmpty"">
    <xs:union memberTypes=""ns0:SBA_Num3 ns0:empty-string"" />
  </xs:simpleType>
  <xs:simpleType name=""SBA_MoneyOrEmpty"">
    <xs:union memberTypes=""ns0:SBA_Money ns0:empty-string"" />
  </xs:simpleType>
  <xs:complexType name=""SBA_Results"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LoanAppNm"" type=""ns0:SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanAppRqstAmt"" type=""ns0:SBA_MoneyOrEmpty"" />
      <xs:element minOccurs=""0"" name=""LoanAppPrtLoanNmb"" type=""ns0:SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LoanAppPrtAppNmb"" type=""ns0:SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LoanAppRecvDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LoanAppEtranEmailAdr"" type=""ns0:SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""LoanAppAppvDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LoanAppSBAAppvAmt"" type=""ns0:SBA_MoneyOrEmpty"" />
      <xs:element minOccurs=""0"" name=""LoanNmb"" type=""ns0:SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""LoanGntyFeeAmt"" type=""ns0:SBA_GntyFeeOrEmpty"" />
      <xs:element minOccurs=""0"" name=""LoanGntyFeeExplainTxt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LoanAppFundDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LoanAppStatCd"" type=""ns0:SBA_OrigStatCdOrEmpty"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""ns0:SBA_Str9"" />
      <xs:element minOccurs=""0"" name=""LiquidCreditScore"" type=""ns0:SBA_Num3OrEmpty"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SBA_Etran_Response"">
    <xs:sequence>
      <xs:element name=""AuthErrorNmb"" type=""xs:byte"" />
      <xs:element name=""AuthErrorText"" type=""xs:string"" />
      <xs:element maxOccurs=""unbounded"" name=""Synopsis"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""App"" type=""ns0:SBA_LoanApplication"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public SBA_ETran_Response_orig() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SBA_Etran_Response";
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
