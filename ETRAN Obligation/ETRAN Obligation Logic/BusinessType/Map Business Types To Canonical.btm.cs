namespace SBA.ETRANObligation.Logic.BusinessType {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Borrower.BusinessTypeMapping", typeof(global::SBA.ETRANObligation.Definition.Borrower.BusinessTypeMapping))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class MapBusinessTypesToCanonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:dis=""http://SBA.gov/ETRANObligation/Salesforce/Query/Disaster__c/"" xmlns:bus=""http://SBA.gov/ETRANObligation/Borrower/BusinessTypeMapping/"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:event=""http://SBA.gov/ETRANObligation/Salesforce/Insert/Event_Request__c/"" xmlns:ns1=""urn:enterprise.soap.sforce.com"" xmlns:apl=""http://SBA.gov/ETRANObligation/Salesforce/Applicant__c/Query/"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Salesforce/Errors/"" xmlns:app=""http://SBA.gov/ETRANObligation/Salesforce/Query/Application__c/"" xmlns:ns3=""http://soap.sforce.com/2005/09/outbound"" xmlns:prop=""http://SBA.gov/ETRANObligation/Salesforce/Query/Property__c/"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:loan=""http://SBA.gov/ETRANObligation/Salesforce/Query/Loan__c/"" xmlns:etran=""http://ws.elend"" xmlns:ns4=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNot(&quot;true&quot;)"" />
    <ns0:Canonical>
      <ns0:BusinessTypeMapping>
        <xsl:for-each select=""InputMessagePart_0/bus:BusinessTypeMapping/bus:BusinessType"">
          <bus:BusinessType>
            <xsl:if test=""bus:SalesforceValue"">
              <bus:SalesforceValue>
                <xsl:value-of select=""bus:SalesforceValue/text()"" />
              </bus:SalesforceValue>
            </xsl:if>
            <bus:ETranTextValue>
              <xsl:value-of select=""bus:ETranTextValue/text()"" />
            </bus:ETranTextValue>
            <bus:ETranCodeValue>
              <xsl:value-of select=""bus:ETranCodeValue/text()"" />
            </bus:ETranCodeValue>
          </bus:BusinessType>
        </xsl:for-each>
      </ns0:BusinessTypeMapping>
      <xsl:for-each select=""InputMessagePart_1/ns0:Canonical/notify1:Notification"">
        <notify1:Notification>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </notify1:Notification>
      </xsl:for-each>
      <xsl:if test=""$var:v1"">
        <ns0:Application__c />
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:Properties />
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:Applicants />
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:Loan__c />
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:Disaster__c />
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:ETRAN_Originate_App_Defaults>
          <def:LoanApplication>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:InterestStructureCd>
              <xsl:text>F</xsl:text>
            </def:InterestStructureCd>
            <def:NetEarningsClause>
              <xsl:text>N</xsl:text>
            </def:NetEarningsClause>
            <def:RevolvingInd>
              <xsl:text>N</xsl:text>
            </def:RevolvingInd>
          </def:LoanApplication>
          <def:Interest>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:BaseRateSourcTypCd>
              <xsl:text>DSR</xsl:text>
            </def:BaseRateSourcTypCd>
            <def:IntrstTypInd>
              <xsl:text>F</xsl:text>
            </def:IntrstTypInd>
            <def:Phase>
              <xsl:text>1</xsl:text>
            </def:Phase>
          </def:Interest>
          <def:Borrower>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:CreditScorSourcCd>
              <xsl:text>13</xsl:text>
            </def:CreditScorSourcCd>
            <def:PhysCountryCd>
              <xsl:text>US</xsl:text>
            </def:PhysCountryCd>
          </def:Borrower>
          <def:BorrowerRace>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:RaceCd>
              <xsl:text>6</xsl:text>
            </def:RaceCd>
          </def:BorrowerRace>
          <def:Principal>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:EthnicCd>
              <xsl:text>UN</xsl:text>
            </def:EthnicCd>
            <def:ExtrnlCreditScorInd>
              <xsl:text>N</xsl:text>
            </def:ExtrnlCreditScorInd>
            <def:GndrCd>
              <xsl:text>U</xsl:text>
            </def:GndrCd>
            <def:GntyInd>
              <xsl:text>N</xsl:text>
            </def:GntyInd>
            <def:VetCd>
              <xsl:text>5</xsl:text>
            </def:VetCd>
          </def:Principal>
          <def:PrincipalRace>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:RaceCd>
              <xsl:text>6</xsl:text>
            </def:RaceCd>
          </def:PrincipalRace>
          <def:SpecialPurpose>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
          </def:SpecialPurpose>
          <def:UseOfProceeds_Physical>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:LoanProceedTypCd>
              <xsl:text>05</xsl:text>
            </def:LoanProceedTypCd>
            <def:ProceedTypCd>
              <xsl:text>D</xsl:text>
            </def:ProceedTypCd>
          </def:UseOfProceeds_Physical>
          <def:UseOfProceeds_EIDL>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:LoanProceedTypCd>
              <xsl:text>04</xsl:text>
            </def:LoanProceedTypCd>
            <def:ProceedTypCd>
              <xsl:text>D</xsl:text>
            </def:ProceedTypCd>
          </def:UseOfProceeds_EIDL>
        </ns0:ETRAN_Originate_App_Defaults>
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:SBA_ETran_Response />
      </xsl:if>
      <xsl:for-each select=""InputMessagePart_1/ns0:Canonical/ns0:Event_Request__c"">
        <ns0:Event_Request__c>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:Event_Request__c>
      </xsl:for-each>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Borrower.BusinessTypeMapping";
        
        private const global::SBA.ETRANObligation.Definition.Borrower.BusinessTypeMapping _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference1 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Borrower.BusinessTypeMapping";
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
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
