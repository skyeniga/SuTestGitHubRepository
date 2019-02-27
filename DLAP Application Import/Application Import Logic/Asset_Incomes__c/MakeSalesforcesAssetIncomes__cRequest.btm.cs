namespace Application_Import_Logic.Asset_Incomes__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.CDataService_Asset_Incomes__c+parameters", typeof(global::Salesforce_Application_Import_Definition.CDataService_Asset_Incomes__c.parameters))]
    public sealed class MakeSalesforcesAssetIncomes__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Asset_Incomes__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalExistence(boolean(Assets))"" />
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:for-each select=""AplWageColl"">
              <xsl:for-each select=""Apl_Wages"">
                <xsl:variable name=""var:v2"" select=""userCSharp:LogicalExistence(boolean(APW_GROSS_INC_AMT))"" />
                <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence(boolean(APW_GROSS_INC_FREQ))"" />
                <xsl:variable name=""var:v4"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v3))"" />
                <ns0:after>
                  <ns0:Asset_Incomes__c>
                    <xsl:attribute name=""Application__c"">
                      <xsl:value-of select=""../../../../SalesForceApplication__cID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Applicant__c"">
                      <xsl:value-of select=""../../SalesForceApplicantID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Amount__c"">
                      <xsl:value-of select=""APW_GROSS_INC_AMT/text()"" />
                    </xsl:attribute>
                    <xsl:variable name=""var:v1"" select=""userCSharp:GFrqValues(string(APW_GROSS_INC_FREQ/text()))"" />
                    <xsl:attribute name=""Income_Frequency__c"">
                      <xsl:value-of select=""$var:v1"" />
                    </xsl:attribute>
                    <xsl:if test=""string($var:v4)='true'"">
                      <xsl:variable name=""var:v5"" select=""&quot;Wages&quot;"" />
                      <xsl:attribute name=""Type__c"">
                        <xsl:value-of select=""$var:v5"" />
                      </xsl:attribute>
                    </xsl:if>
                  </ns0:Asset_Incomes__c>
                </ns0:after>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:for-each select=""AplOtherIncomeColl"">
              <xsl:for-each select=""Apl_Other_Income"">
                <xsl:variable name=""var:v7"" select=""userCSharp:LogicalExistence(boolean(API_INCOME_SOURCE))"" />
                <xsl:variable name=""var:v8"" select=""userCSharp:LogicalExistence(boolean(API_INCOME_AMOUNT))"" />
                <xsl:variable name=""var:v9"" select=""userCSharp:LogicalExistence(boolean(API_INCOME_FREQ))"" />
                <xsl:variable name=""var:v10"" select=""userCSharp:LogicalOr(string($var:v7) , string($var:v8) , string($var:v9))"" />
                <ns0:after>
                  <ns0:Asset_Incomes__c>
                    <xsl:attribute name=""Name"">
                      <xsl:value-of select=""API_INCOME_SOURCE/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Application__c"">
                      <xsl:value-of select=""../../../../SalesForceApplication__cID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Applicant__c"">
                      <xsl:value-of select=""../../SalesForceApplicantID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Amount__c"">
                      <xsl:value-of select=""API_INCOME_AMOUNT/text()"" />
                    </xsl:attribute>
                    <xsl:variable name=""var:v6"" select=""userCSharp:OFrqValues(string(API_INCOME_FREQ/text()))"" />
                    <xsl:attribute name=""Income_Frequency__c"">
                      <xsl:value-of select=""$var:v6"" />
                    </xsl:attribute>
                    <xsl:if test=""string($var:v10)='true'"">
                      <xsl:variable name=""var:v11"" select=""&quot;Income&quot;"" />
                      <xsl:attribute name=""Type__c"">
                        <xsl:value-of select=""$var:v11"" />
                      </xsl:attribute>
                    </xsl:if>
                  </ns0:Asset_Incomes__c>
                </ns0:after>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
        <ns0:after>
          <ns0:Asset_Incomes__c>
            <xsl:attribute name=""Application__c"">
              <xsl:value-of select=""SalesForceApplication__cID/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Cash_Available_Amount__c"">
              <xsl:value-of select=""Assets/APO_CASH_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Household_Goods_Value__c"">
              <xsl:value-of select=""Assets/APO_GOODS_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""IRA_Retirement_Amount__c"">
              <xsl:value-of select=""Assets/APO_IRA_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Primary_Residence_Address__c"">
              <xsl:value-of select=""Assets/APO_PRIMARY_RE_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Primary_Residence_Value__c"">
              <xsl:value-of select=""Assets/APO_PRIMARY_RE_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Stocks_and_securities_Amount__c"">
              <xsl:value-of select=""Assets/APO_STOCK_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X1_Other_Assets_Description__c"">
              <xsl:value-of select=""Assets/APO_OTHER1_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X1_Other_Assets_Value__c"">
              <xsl:value-of select=""Assets/APO_OTHER1_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X1_Other_Real_Estate_Owned_Address__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE1_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X1_Other_Real_Estate_Value__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE1_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X2_Other_Assets_Description__c"">
              <xsl:value-of select=""Assets/APO_OTHER2_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X2_Other_Assets_Value__c"">
              <xsl:value-of select=""Assets/APO_OTHER2_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X2_Other_Real_Estate_Owned_Address__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE2_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X2_Other_Real_Estate_Value__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE2_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X3_Other_Real_Estate_Owned_Address__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE3_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""X3_Other_Real_Estate_Value__c"">
              <xsl:value-of select=""Assets/APO_OTHER_RE3_AMT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Applicant__c"">
              <xsl:value-of select=""ApplicantColl/Applicants/SalesForceApplicantID/text()"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v12)='true'"">
              <xsl:variable name=""var:v13"" select=""&quot;Asset&quot;"" />
              <xsl:attribute name=""Type__c"">
                <xsl:value-of select=""$var:v13"" />
              </xsl:attribute>
            </xsl:if>
          </ns0:Asset_Incomes__c>
        </ns0:after>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalOr(string param0, string param1, string param2)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2);
	return false;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
}


 public string GFrqValues(string GfqValues)
        {

            if (!string.IsNullOrEmpty(GfqValues))
            {               
                if(GfqValues == ""WEEKLY"")
                {return ""Weekly"";}

				 else if(GfqValues == ""BI_WEEKLY"")
                {return ""Bi-Weekly""; }

				 else if(GfqValues == ""MONTHLY"")
                {return ""Monthly""; }

				 else if (GfqValues == ""ANNUALLY"")
                {return ""Yearly""; }

				 else if(GfqValues == ""SEMI_MONTHLY"")
                {return ""Semi-Monthly""; }

				 else if(GfqValues == ""HOURLY"")
                {return ""Hourly""; }

				 else if(GfqValues == ""QUARTERLY"")
                {return ""Quarterly""; }

				 else if(GfqValues == ""SEMI_ANNUALLY"")
                {return ""Semi-Annual""; }

				else
				{return """";}
            }

          else{return """";}

        }


 public string OFrqValues(string OfqValues)
        {

            if (!string.IsNullOrEmpty(OfqValues))
            {               
                if(OfqValues == ""WEEKLY"")
                {return ""Weekly"";}
				
				 else if(OfqValues == ""BI_WEEKLY"")
                {return ""Bi-Weekly""; }
				
				 else if(OfqValues == ""MONTHLY"")
                {return ""Monthly""; }
				
				 else if (OfqValues == ""ANNUALLY"")
                {return ""Yearly""; }
				
				 else if(OfqValues == ""SEMI_MONTHLY"")
                {return ""Semi-Monthly""; }
				
				 else if(OfqValues == ""HOURLY"")
                {return ""Hourly""; }
				
				 else if(OfqValues == ""QUARTERLY"")
                {return ""Quarterly""; }
				
				 else if(OfqValues == ""SEMI_ANNUALLY"")
                {return ""Semi-Annual""; }
				
				else
				{return """";}
            }

          else{return """";}
          
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.CDataService_Asset_Incomes__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition.CDataService_Asset_Incomes__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.CDataService_Asset_Incomes__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
