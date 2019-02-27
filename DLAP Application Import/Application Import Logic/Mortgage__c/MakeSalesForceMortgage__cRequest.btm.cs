namespace Application_Import_Logic.Mortgage__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceMortgage__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceMortgage__c.parameters))]
    public sealed class MakeSalesForceMortgage__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/Mortgage__c"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""Debts/MortgageColl/ARE_Mortgages"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(ARM_PAY_AMT/text()))"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(ARM_BALANCE_AMT/text()))"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:StringSize(string(ARM_HOLDER_NAME/text()))"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4) , string($var:v6))"" />
          <xsl:if test=""$var:v7"">
            <xsl:variable name=""var:v8"" select=""userCSharp:StringTrimRight(string(MailingAddress/MAR_ADDRESS1/text()))"" />
            <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(string($var:v8) , &quot; &quot; , string(MailingAddress/MAR_ADDRESS2/text()))"" />
            <ns0:after>
              <ns0:Mortgage__c>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Mortgage_Lender_Name__c"">
                  <xsl:value-of select=""ARM_HOLDER_NAME/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Street_Address__c"">
                  <xsl:value-of select=""$var:v9"" />
                </xsl:attribute>
                <xsl:attribute name=""City__c"">
                  <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""State__c"">
                  <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Zip_Code__c"">
                  <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Monthly_Payment__c"">
                  <xsl:value-of select=""ARM_PAY_AMT/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Present_Balance__c"">
                  <xsl:value-of select=""ARM_BALANCE_AMT/text()"" />
                </xsl:attribute>
              </ns0:Mortgage__c>
            </ns0:after>
          </xsl:if>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


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


public bool LogicalOr(string param0, string param1, string param2)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2);
	return false;
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceMortgage__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceMortgage__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceMortgage__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
