namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataService_Decline_Withdrawal_Code__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataService_Decline_Withdrawal_Code__c.parameters))]
    public sealed class MakeDeclineWithdrawalCodeRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/Decline_Withdrawal_Code__c"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(APP_SUMMARY_DECLINE_CODE/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v3"" select=""string(APP_SUMMARY_DECLINE_CODE/text())"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNe($var:v3 , &quot;PASS&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v4))"" />
    <ns0:parameters>
      <ns0:sync>
        <xsl:if test=""$var:v5"">
          <xsl:variable name=""var:v6"" select=""userCSharp:StringSize($var:v3)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:LogicalGt(string($var:v6) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v8"" select=""userCSharp:LogicalAnd(string($var:v7) , string($var:v4))"" />
          <ns0:after>
            <ns0:Decline_Withdrawal_Code__c>
              <xsl:attribute name=""Active__c"">
                <xsl:text>true</xsl:text>
              </xsl:attribute>
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v9"" select=""SalesForceApplication__cID/text()"" />
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""$var:v9"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v10"" select=""APP_SUMMARY_DECLINE_CODE/text()"" />
                <xsl:variable name=""var:v11"" select=""userCSharp:SUMMARYDECLINE(string($var:v10))"" />
                <xsl:attribute name=""Code_Type__c"">
                  <xsl:value-of select=""$var:v11"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:attribute name=""Code__c"">
                <xsl:text>Decline</xsl:text>
              </xsl:attribute>
              <xsl:attribute name=""Application_Stage__c"">
                <xsl:text>Original</xsl:text>
              </xsl:attribute>
            </ns0:Decline_Withdrawal_Code__c>
          </ns0:after>
        </xsl:if>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string SUMMARYDECLINE(string APP_SUMMARY_DECLINE_CODE)
    {          

    if (APP_SUMMARY_DECLINE_CODE == ""20"")
                { return ""20 Lack of repayment ability – Applicant’s income below minimum income level for the family size""; }
				
	else if (APP_SUMMARY_DECLINE_CODE == ""21"")
                { return ""21 Lack of repayment ability""; }
				
	else if (APP_SUMMARY_DECLINE_CODE == ""44I"")
                { return ""44I Lack of repayment ability – Below minimum income level for the family size based upon the applicant’s income alone""; }
				
	else if (APP_SUMMARY_DECLINE_CODE == ""44R"")
                { return ""44R Lack of ability to repay a disaster loan based on the applicant’s income alone""; }

    else
                { return """"; }
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
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataService_Decline_Withdrawal_Code__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataService_Decline_Withdrawal_Code__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataService_Decline_Withdrawal_Code__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
