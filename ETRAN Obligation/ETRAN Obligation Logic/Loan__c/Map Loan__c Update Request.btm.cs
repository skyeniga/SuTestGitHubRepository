namespace SBA.ETRANObligation.Logic.Loan__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Loan__c.Loan__c_Save+SaveRequest", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Loan__c.Loan__c_Save.SaveRequest))]
    public sealed class Map_Loan__c_Update_Request : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s8 s0 s7 s6 s10 s1 s5 s2 s4 s3 s9 userCSharp"" version=""1.0"" xmlns:s8=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:s0=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:s7=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Loan__c/Save/"" xmlns:s10=""urn:enterprise.soap.sforce.com"" xmlns:s1=""http://ws.elend"" xmlns:s5=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s6=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:s2=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:s4=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:s3=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:s9=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s6:Canonical"" />
  </xsl:template>
  <xsl:template match=""/s6:Canonical"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;true&quot;)"" />
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:value-of select=""$var:v1"" />
      </ns0:allOrNone>
      <xsl:for-each select=""s6:SBA_ETran_Response"">
        <xsl:for-each select=""s1:App"">
          <ns0:records>
            <xsl:attribute name=""type"">
              <xsl:text>Loan__c</xsl:text>
            </xsl:attribute>
            <ns0:Id>
              <xsl:value-of select=""../../s6:Multi/s6:QueryResult/s4:records/s4:Loans__r/s4:records/s4:Id/text()"" />
            </ns0:Id>
            <xsl:if test=""s1:Results/s1:LoanAppFundDt"">
              <ns0:Obligated_Date__c>
                <xsl:value-of select=""s1:Results/s1:LoanAppFundDt/text()"" />
              </ns0:Obligated_Date__c>
            </xsl:if>
            <xsl:if test=""s1:Results/s1:LoanNmb"">
              <ns0:ETRAN_Loan_Number__c>
                <xsl:value-of select=""s1:Results/s1:LoanNmb/text()"" />
              </ns0:ETRAN_Loan_Number__c>
            </xsl:if>
          </ns0:records>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:SaveRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Salesforce.Loan__c.Loan__c_Save+SaveRequest";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Loan__c.Loan__c_Save.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Salesforce.Loan__c.Loan__c_Save+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
