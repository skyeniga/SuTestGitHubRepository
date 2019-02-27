namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.CDataServiceUpdateApplicant__c+parameters", typeof(global::Salesforce_Application_Import_Definition.CDataServiceUpdateApplicant__c.parameters))]
    public sealed class MakeUpdateApplicantsRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/UpdateApplicant__c"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNe(string(ApplicantType/text()) , &quot;Primary&quot;)"" />
            <xsl:if test=""$var:v1"">
              <xsl:variable name=""var:v2"" select=""string(ApplicantType/text())"" />
              <xsl:variable name=""var:v3"" select=""userCSharp:LogicalNe($var:v2 , &quot;Primary&quot;)"" />
              <ns0:before>
                <ns0:Applicant__c>
                  <xsl:if test=""string($var:v3)='true'"">
                    <xsl:variable name=""var:v4"" select=""SalesForceApplicantID/text()"" />
                    <xsl:attribute name=""Id"">
                      <xsl:value-of select=""$var:v4"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v3)='true'"">
                    <xsl:variable name=""var:v5"" select=""&quot;false&quot;"" />
                    <xsl:attribute name=""Primary_Applicant__c"">
                      <xsl:value-of select=""$var:v5"" />
                    </xsl:attribute>
                  </xsl:if>
                </ns0:Applicant__c>
              </ns0:before>
              <xsl:variable name=""var:v6"" select=""string(ApplicantType/text())"" />
              <xsl:variable name=""var:v7"" select=""userCSharp:LogicalNe($var:v6 , &quot;Primary&quot;)"" />
              <xsl:if test=""$var:v7"">
                <ns0:after>
                  <ns0:Applicant__c>
                    <xsl:if test=""string($var:v7)='true'"">
                      <xsl:variable name=""var:v8"" select=""SalesForceApplicantID/text()"" />
                      <xsl:attribute name=""Id"">
                        <xsl:value-of select=""$var:v8"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:attribute name=""Related_Parent__c"">
                      <xsl:value-of select=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='ApplicantColl' and namespace-uri()='']/*[local-name()='Applicants' and namespace-uri()=''][*[local-name()='ApplicantType' and namespace-uri()=''][text() = 'Primary']]/*[local-name()='SalesForceApplicantID' and namespace-uri()='']"" />
                    </xsl:attribute>
                  </ns0:Applicant__c>
                </ns0:after>
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>

      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.CDataServiceUpdateApplicant__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition.CDataServiceUpdateApplicant__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.CDataServiceUpdateApplicant__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
