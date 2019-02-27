namespace SBA.ETRANObligation.Logic.ETRANOriginate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_ETRAN_Originate_Response_to_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:ns4=""urn:enterprise.soap.sforce.com"" xmlns:etran=""http://ws.elend"" xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Canonical>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/notify1:Notification"">
        <notify1:Notification>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </notify1:Notification>
      </xsl:for-each>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Multi"">
        <ns0:Multi>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:Multi>
      </xsl:for-each>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:BorrowerBusinessTypes"">
        <ns0:BorrowerBusinessTypes>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:BorrowerBusinessTypes>
      </xsl:for-each>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:ETRAN_Originate_App_Defaults"">
        <ns0:ETRAN_Originate_App_Defaults>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:ETRAN_Originate_App_Defaults>
      </xsl:for-each>
      <ns0:SBA_ETran_Response>
        <etran:AuthErrorNmb>
          <xsl:value-of select=""InputMessagePart_1/etran:SBA_Etran_Response/etran:AuthErrorNmb/text()"" />
        </etran:AuthErrorNmb>
        <etran:AuthErrorText>
          <xsl:value-of select=""InputMessagePart_1/etran:SBA_Etran_Response/etran:AuthErrorText/text()"" />
        </etran:AuthErrorText>
        <xsl:for-each select=""InputMessagePart_1/etran:SBA_Etran_Response/etran:Synopsis"">
          <etran:Synopsis>
            <xsl:value-of select=""./text()"" />
          </etran:Synopsis>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/etran:SBA_Etran_Response/etran:App"">
          <etran:App>
            <xsl:if test=""@LoanAppNmb"">
              <xsl:attribute name=""LoanAppNmb"">
                <xsl:value-of select=""@LoanAppNmb"" />
              </xsl:attribute>
            </xsl:if>
            <etran:Results>
              <xsl:if test=""etran:Results/etran:LoanAppNm"">
                <etran:LoanAppNm>
                  <xsl:value-of select=""etran:Results/etran:LoanAppNm/text()"" />
                </etran:LoanAppNm>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppRqstAmt"">
                <etran:LoanAppRqstAmt>
                  <xsl:value-of select=""etran:Results/etran:LoanAppRqstAmt/text()"" />
                </etran:LoanAppRqstAmt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppPrtLoanNmb"">
                <etran:LoanAppPrtLoanNmb>
                  <xsl:value-of select=""etran:Results/etran:LoanAppPrtLoanNmb/text()"" />
                </etran:LoanAppPrtLoanNmb>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppPrtAppNmb"">
                <etran:LoanAppPrtAppNmb>
                  <xsl:value-of select=""etran:Results/etran:LoanAppPrtAppNmb/text()"" />
                </etran:LoanAppPrtAppNmb>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppRecvDt"">
                <etran:LoanAppRecvDt>
                  <xsl:value-of select=""etran:Results/etran:LoanAppRecvDt/text()"" />
                </etran:LoanAppRecvDt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppEtranEmailAdr"">
                <etran:LoanAppEtranEmailAdr>
                  <xsl:value-of select=""etran:Results/etran:LoanAppEtranEmailAdr/text()"" />
                </etran:LoanAppEtranEmailAdr>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppAppvDt"">
                <etran:LoanAppAppvDt>
                  <xsl:value-of select=""etran:Results/etran:LoanAppAppvDt/text()"" />
                </etran:LoanAppAppvDt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppSBAAppvAmt"">
                <etran:LoanAppSBAAppvAmt>
                  <xsl:value-of select=""etran:Results/etran:LoanAppSBAAppvAmt/text()"" />
                </etran:LoanAppSBAAppvAmt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanNmb"">
                <etran:LoanNmb>
                  <xsl:value-of select=""etran:Results/etran:LoanNmb/text()"" />
                </etran:LoanNmb>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanGntyFeeAmt"">
                <etran:LoanGntyFeeAmt>
                  <xsl:value-of select=""etran:Results/etran:LoanGntyFeeAmt/text()"" />
                </etran:LoanGntyFeeAmt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanGntyFeeExplainTxt"">
                <etran:LoanGntyFeeExplainTxt>
                  <xsl:value-of select=""etran:Results/etran:LoanGntyFeeExplainTxt/text()"" />
                </etran:LoanGntyFeeExplainTxt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppFundDt"">
                <etran:LoanAppFundDt>
                  <xsl:value-of select=""etran:Results/etran:LoanAppFundDt/text()"" />
                </etran:LoanAppFundDt>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LoanAppStatCd"">
                <etran:LoanAppStatCd>
                  <xsl:value-of select=""etran:Results/etran:LoanAppStatCd/text()"" />
                </etran:LoanAppStatCd>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:BusDUNSNmb"">
                <etran:BusDUNSNmb>
                  <xsl:value-of select=""etran:Results/etran:BusDUNSNmb/text()"" />
                </etran:BusDUNSNmb>
              </xsl:if>
              <xsl:if test=""etran:Results/etran:LiquidCreditScore"">
                <etran:LiquidCreditScore>
                  <xsl:value-of select=""etran:Results/etran:LiquidCreditScore/text()"" />
                </etran:LiquidCreditScore>
              </xsl:if>
              <xsl:value-of select=""etran:Results/text()"" />
            </etran:Results>
            <xsl:for-each select=""etran:Errors"">
              <etran:Errors>
                <xsl:value-of select=""./text()"" />
              </etran:Errors>
            </xsl:for-each>
            <xsl:for-each select=""etran:Warnings"">
              <etran:Warnings>
                <xsl:value-of select=""./text()"" />
              </etran:Warnings>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </etran:App>
        </xsl:for-each>
      </ns0:SBA_ETran_Response>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Event_Request__c"">
        <ns0:Event_Request__c>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:Event_Request__c>
      </xsl:for-each>
    </ns0:Canonical>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _TrgSchemas;
            }
        }
    }
}
