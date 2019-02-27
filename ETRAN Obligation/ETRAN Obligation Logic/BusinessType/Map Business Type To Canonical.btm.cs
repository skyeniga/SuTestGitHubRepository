namespace SBA.ETRANObligation.Logic.BusinessType {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping", typeof(global::SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Business_Type_To_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:ns4=""urn:enterprise.soap.sforce.com"" xmlns:etran=""http://ws.elend"" xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(&quot;true&quot;)"" />
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
      <ns0:BorrowerBusinessTypes>
        <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:BorrowerBusinessTypes"">
          <xsl:for-each select=""bbt:BorrowerBusinessType"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(ns2:LegalOrgTypeMapping/ns2:SalesforceBusinessType/text()) , string(../../../../InputMessagePart_1/ns2:LegalOrgTypeMapping/ns2:SalesforceBusinessType/text()))"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalNot(string($var:v1))"" />
            <bbt:BorrowerBusinessType>
              <bbt:ApplicantId>
                <xsl:value-of select=""bbt:ApplicantId/text()"" />
              </bbt:ApplicantId>
              <ns2:LegalOrgTypeMapping>
                <ns2:SalesforceBusinessType>
                  <xsl:value-of select=""ns2:LegalOrgTypeMapping/ns2:SalesforceBusinessType/text()"" />
                </ns2:SalesforceBusinessType>
                <xsl:if test=""string($var:v2)='true'"">
                  <xsl:variable name=""var:v3"" select=""ns2:LegalOrgTypeMapping/ns2:ETranLegalOrgTypeCode/text()"" />
                  <ns2:ETranLegalOrgTypeCode>
                    <xsl:value-of select=""$var:v3"" />
                  </ns2:ETranLegalOrgTypeCode>
                </xsl:if>
                <xsl:if test=""string($var:v1)='true'"">
                  <xsl:variable name=""var:v4"" select=""../../../../InputMessagePart_1/ns2:LegalOrgTypeMapping/ns2:ETranLegalOrgTypeCode/text()"" />
                  <ns2:ETranLegalOrgTypeCode>
                    <xsl:value-of select=""$var:v4"" />
                  </ns2:ETranLegalOrgTypeCode>
                </xsl:if>
                <xsl:value-of select=""ns2:LegalOrgTypeMapping/text()"" />
              </ns2:LegalOrgTypeMapping>
            </bbt:BorrowerBusinessType>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:BorrowerBusinessTypes>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:ETRAN_Originate_App_Defaults"">
        <ns0:ETRAN_Originate_App_Defaults>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:ETRAN_Originate_App_Defaults>
      </xsl:for-each>
      <xsl:if test=""$var:v5"">
        <ns0:SBA_ETran_Response />
      </xsl:if>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Event_Request__c"">
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


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
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
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping";
        
        private const global::SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping _srcSchemaTypeReference1 = null;
        
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
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.Rules.LegalOrgTypeMapping";
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
