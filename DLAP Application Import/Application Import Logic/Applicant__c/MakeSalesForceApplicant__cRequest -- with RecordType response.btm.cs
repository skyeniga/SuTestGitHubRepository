namespace Application_Import_Logic.Applicant__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c.parameters))]
    public sealed class MakeSalesForceApplicant__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/Applicant__c"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(string(APL_FIRST_NAME/text()))"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string($var:v1) , &quot; &quot; , string(APL_LAST_NAME/text()))"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(ApplicantType/text()) , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v5"" select=""string(ApplicantType/text())"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNe($var:v5 , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v8"" select=""userCSharp:LogicalEq(string(APL_SBA_EMPLOYEE/text()) , &quot;N&quot;)"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:LogicalNot(string($var:v8))"" />
            <xsl:variable name=""var:v12"" select=""userCSharp:LogicalEq(string(APL_CITIZEN_IND/text()) , &quot;Y&quot;)"" />
            <xsl:variable name=""var:v14"" select=""string(APL_CITIZEN_IND/text())"" />
            <xsl:variable name=""var:v15"" select=""userCSharp:LogicalEq($var:v14 , &quot;N&quot;)"" />
            <ns0:after>
              <ns0:Applicant__c>
                <xsl:attribute name=""Name"">
                  <xsl:value-of select=""$var:v2"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v3)='true'"">
                  <xsl:variable name=""var:v4"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""Primary_Applicant__c"">
                    <xsl:value-of select=""$var:v4"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v6)='true'"">
                  <xsl:variable name=""var:v7"" select=""&quot;false&quot;"" />
                  <xsl:attribute name=""Primary_Applicant__c"">
                    <xsl:value-of select=""$var:v7"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v8)='true'"">
                  <xsl:variable name=""var:v9"" select=""&quot;False&quot;"" />
                  <xsl:attribute name=""SBA_Employee__c"">
                    <xsl:value-of select=""$var:v9"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v10)='true'"">
                  <xsl:variable name=""var:v11"" select=""&quot;True&quot;"" />
                  <xsl:attribute name=""SBA_Employee__c"">
                    <xsl:value-of select=""$var:v11"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:attribute name=""External_ID__c"">
                  <xsl:value-of select=""ApplicantId/text()"" />
                </xsl:attribute>
                <xsl:if test=""SalesForceContactID"">
                  <xsl:attribute name=""Contact__c"">
                    <xsl:value-of select=""SalesForceContactID/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Account__c"">
                  <xsl:value-of select=""../../SalesForceAccountID/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Entity_Type"">
                  <xsl:value-of select=""APL_ORG_TYPE_CD/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Trade_Name__c"">
                  <xsl:value-of select=""APL_BUS_TRADE_NAME/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Title__c"">
                  <xsl:value-of select=""APL_TITLEOFFICE/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Ownership_Percent__c"">
                  <xsl:value-of select=""APL_PER_OWNERSHIP/text()"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v12)='true'"">
                  <xsl:variable name=""var:v13"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""U_S_Citizen__c"">
                    <xsl:value-of select=""$var:v13"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v15)='true'"">
                  <xsl:variable name=""var:v16"" select=""&quot;false&quot;"" />
                  <xsl:attribute name=""U_S_Citizen__c"">
                    <xsl:value-of select=""$var:v16"" />
                  </xsl:attribute>
                </xsl:if>
              </ns0:Applicant__c>
            </ns0:after>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
