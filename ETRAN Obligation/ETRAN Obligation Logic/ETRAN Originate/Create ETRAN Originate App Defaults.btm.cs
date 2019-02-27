namespace SBA.ETRANObligation.Logic.ETRANOriginate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults", typeof(global::SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults))]
    public sealed class Create_ETRAN_Originate_App_Defaults : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s7 s0 s6 s5 s9 s1 s2 s3 s4 s8"" version=""1.0"" xmlns:s7=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:s0=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:s6=""http://soap.sforce.com/2005/09/outbound"" xmlns:s5=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:s9=""urn:enterprise.soap.sforce.com"" xmlns:s1=""http://ws.elend"" xmlns:s4=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:ns0=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:s3=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:s2=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:s8=""urn:sobject.enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s5:Canonical"" />
  </xsl:template>
  <xsl:template match=""/s5:Canonical"">
    <ns0:ETRAN_Originate_App_Defaults>
      <ns0:LoanApplication>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:InterestStructureCd>
          <xsl:text>F</xsl:text>
        </ns0:InterestStructureCd>
        <ns0:NetEarningsClause>
          <xsl:text>N</xsl:text>
        </ns0:NetEarningsClause>
        <ns0:RevolvingInd>
          <xsl:text>N</xsl:text>
        </ns0:RevolvingInd>
      </ns0:LoanApplication>
      <ns0:Interest>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:BaseRateSourcTypCd>
          <xsl:text>DSR</xsl:text>
        </ns0:BaseRateSourcTypCd>
        <ns0:IntrstTypInd>
          <xsl:text>F</xsl:text>
        </ns0:IntrstTypInd>
        <ns0:Phase>
          <xsl:text>1</xsl:text>
        </ns0:Phase>
      </ns0:Interest>
      <ns0:Borrower>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:CreditScorSourcCd>
          <xsl:text>13</xsl:text>
        </ns0:CreditScorSourcCd>
        <ns0:PhysCountryCd>
          <xsl:text>US</xsl:text>
        </ns0:PhysCountryCd>
      </ns0:Borrower>
      <ns0:BorrowerRace>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:RaceCd>
          <xsl:text>6</xsl:text>
        </ns0:RaceCd>
      </ns0:BorrowerRace>
      <ns0:Principal>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:EthnicCd>
          <xsl:text>UN</xsl:text>
        </ns0:EthnicCd>
        <ns0:ExtrnlCreditScorInd>
          <xsl:text>N</xsl:text>
        </ns0:ExtrnlCreditScorInd>
        <ns0:GndrCd>
          <xsl:text>U</xsl:text>
        </ns0:GndrCd>
        <ns0:GntyInd>
          <xsl:text>N</xsl:text>
        </ns0:GntyInd>
        <ns0:VetCd>
          <xsl:text>5</xsl:text>
        </ns0:VetCd>
      </ns0:Principal>
      <ns0:PrincipalRace>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:RaceCd>
          <xsl:text>6</xsl:text>
        </ns0:RaceCd>
      </ns0:PrincipalRace>
      <ns0:SpecialPurpose>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
      </ns0:SpecialPurpose>
      <ns0:UseOfProceeds_Physical>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:LoanProceedTypCd>
          <xsl:text>05</xsl:text>
        </ns0:LoanProceedTypCd>
        <ns0:ProceedTypCd>
          <xsl:text>D</xsl:text>
        </ns0:ProceedTypCd>
      </ns0:UseOfProceeds_Physical>
      <ns0:UseOfProceeds_EIDL>
        <xsl:attribute name=""ns0:action"">
          <xsl:text>insert</xsl:text>
        </xsl:attribute>
        <ns0:LoanProceedTypCd>
          <xsl:text>04</xsl:text>
        </ns0:LoanProceedTypCd>
        <ns0:ProceedTypCd>
          <xsl:text>D</xsl:text>
        </ns0:ProceedTypCd>
      </ns0:UseOfProceeds_EIDL>
    </ns0:ETRAN_Originate_App_Defaults>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults";
                return _TrgSchemas;
            }
        }
    }
}
