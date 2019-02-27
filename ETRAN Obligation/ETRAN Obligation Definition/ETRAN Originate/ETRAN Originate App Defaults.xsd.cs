namespace SBA.ETRANObligation.Definition.ETRAN_Originate {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/",@"ETRAN_Originate_App_Defaults")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LoanApplication.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LoanApplication.InterestStructureCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='InterestStructureCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LoanApplication.NetEarningsClause", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='NetEarningsClause' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LoanApplication.RevolvingInd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RevolvingInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Interest.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Interest.BaseRateSourcTypCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BaseRateSourcTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Interest.IntrstTypInd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='IntrstTypInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Interest.Phase", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Phase' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Borrower.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Borrower.CreditScorSourcCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='CreditScorSourcCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Borrower.PhysCountryCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PhysCountryCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BorrowerRace.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BorrowerRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BorrowerRace.RaceCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BorrowerRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RaceCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.EthnicCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='EthnicCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.ExtrnlCreditScorInd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ExtrnlCreditScorInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.GndrCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='GndrCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.GntyInd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='GntyInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Principal.VetCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='VetCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PrincipalRace.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PrincipalRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PrincipalRace.RaceCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PrincipalRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RaceCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_Physical.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_Physical.LoanProceedTypCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_Physical.ProceedTypCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_EIDL.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_EIDL.LoanProceedTypCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "UseOfProceeds_EIDL.ProceedTypCd", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SpecialPurpose.action", XPath = @"/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='SpecialPurpose' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ETRAN_Originate_App_Defaults"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes))]
    public sealed class ETRANOriginateAppDefaults : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes"" />
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes"" />
  <xs:element name=""ETRAN_Originate_App_Defaults"" type=""ETRAN_Originate_App_Defaults"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='InterestStructureCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='NetEarningsClause' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanApplication' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RevolvingInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BaseRateSourcTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='IntrstTypInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Interest' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Phase' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='CreditScorSourcCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Borrower' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PhysCountryCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BorrowerRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='BorrowerRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RaceCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='EthnicCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ExtrnlCreditScorInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='GndrCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='GntyInd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='Principal' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='VetCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PrincipalRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='PrincipalRace' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='RaceCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_Physical' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='LoanProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='UseOfProceeds_EIDL' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='ProceedTypCd' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ETRAN_Originate_App_Defaults' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/*[local-name()='SpecialPurpose' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']/@*[local-name()='action' and namespace-uri()='http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""ETRAN_Originate_App_Defaults"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""LoanApplication"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""F"" name=""InterestStructureCd"" type=""SBA_Str2"" />
            <xs:element default=""N"" name=""NetEarningsClause"" type=""SBA_YesNoInd"" />
            <xs:element default=""N"" name=""RevolvingInd"" type=""SBA_YesNoInd"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertOrUpdateIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Interest"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""DSR"" name=""BaseRateSourcTypCd"" type=""SBA_Str3"" />
            <xs:element default=""F"" name=""IntrstTypInd"" type=""SBA_FixVarInd"" />
            <xs:element default=""1"" name=""Phase"" type=""SBA_Num1"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertOrUpdateIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Borrower"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""13"" name=""CreditScorSourcCd"" type=""SBA_Num3"" />
            <xs:element default=""US"" name=""PhysCountryCd"" type=""SBA_Str2"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertOrUpdateIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""BorrowerRace"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""6"" name=""RaceCd"" type=""SBA_MandNum3"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Principal"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""UN"" name=""EthnicCd"" type=""SBA_Str2"" />
            <xs:element default=""N"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
            <xs:element default=""U"" name=""GndrCd"" type=""SBA_Str1"" />
            <xs:element default=""N"" name=""GntyInd"" type=""SBA_YesNoInd"" />
            <xs:element default=""5"" name=""VetCd"" type=""SBA_Num3"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PrincipalRace"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""6"" name=""RaceCd"" type=""SBA_MandNum3"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""SpecialPurpose"">
        <xs:complexType>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""UseOfProceeds_Physical"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""05"" name=""LoanProceedTypCd"" type=""SBA_Str2"" />
            <xs:element default=""D"" name=""ProceedTypCd"" type=""SBA_Str1"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""UseOfProceeds_EIDL"">
        <xs:complexType>
          <xs:sequence>
            <xs:element default=""04"" name=""LoanProceedTypCd"" type=""SBA_Str2"" />
            <xs:element default=""D"" name=""ProceedTypCd"" type=""SBA_Str1"" />
          </xs:sequence>
          <xs:attribute default=""insert"" name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes  __DummyVar0 = null;
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes  __DummyVar1 = null;
        
        public ETRANOriginateAppDefaults() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ETRAN_Originate_App_Defaults";
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
