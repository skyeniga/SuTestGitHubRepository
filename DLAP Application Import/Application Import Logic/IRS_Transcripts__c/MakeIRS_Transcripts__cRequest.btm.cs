namespace Application_Import_Logic.IRS_Transcripts__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceIRS_Transcripts__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceIRS_Transcripts__c.parameters))]
    public sealed class MakeIRS_Transcripts__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/IRS_Transcripts__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:for-each select=""TaxTranscriptRequest/EndOfFiscalYear/string"">
              <xsl:variable name=""var:v1"" select=""userCSharp:LogicalIsString(string(./text()))"" />
              <xsl:if test=""$var:v1"">
                <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Initial&quot;)"" />
                <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(../../../APL_EIN_NBR/text()))"" />
                <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;1&quot;)"" />
                <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNot(string($var:v4))"" />
                <xsl:variable name=""var:v7"" select=""userCSharp:StringSize(string(../../../APL_SSN/text()))"" />
                <xsl:variable name=""var:v8"" select=""userCSharp:LogicalGt(string($var:v7) , &quot;1&quot;)"" />
                <xsl:variable name=""var:v9"" select=""userCSharp:LogicalAnd(string($var:v6) , string($var:v8))"" />
                <ns0:after>
                  <ns0:IRS_Transcripts__c>
                    <xsl:attribute name=""FTR_Year__c"">
                      <xsl:value-of select=""./text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""IRS_Request_Status__c"">
                      <xsl:value-of select=""$var:v2"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Form_Type__c"">
                      <xsl:value-of select=""../../TaxForm/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Application__c"">
                      <xsl:value-of select=""../../../../../SalesForceApplication__cID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Applicant_Name__c"">
                      <xsl:value-of select=""../../../SalesForceApplicantID/text()"" />
                    </xsl:attribute>
                    <xsl:if test=""string($var:v4)='true'"">
                      <xsl:variable name=""var:v5"" select=""../../../APL_EIN_NBR/text()"" />
                      <xsl:attribute name=""SSN_EIN__c"">
                        <xsl:value-of select=""$var:v5"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""string($var:v9)='true'"">
                      <xsl:variable name=""var:v10"" select=""../../../APL_SSN/text()"" />
                      <xsl:attribute name=""SSN_EIN__c"">
                        <xsl:value-of select=""$var:v10"" />
                      </xsl:attribute>
                    </xsl:if>
                  </ns0:IRS_Transcripts__c>
                </ns0:after>
              </xsl:if>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceIRS_Transcripts__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceIRS_Transcripts__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceIRS_Transcripts__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
