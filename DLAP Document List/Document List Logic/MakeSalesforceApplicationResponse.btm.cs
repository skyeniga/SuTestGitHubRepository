namespace DLAPDocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult", typeof(global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response))]
    public sealed class MakeSalesforceApplicationResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo"" xmlns:ns0=""http://SBA.gov/DLAPDocumentList/Application_Info__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:Response>
      <xsl:for-each select=""s0:records"">
        <xsl:for-each select=""s0:Applicants__r"">
          <xsl:for-each select=""s0:records"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(../../s0:Disaster_Declaration__r/s0:Name/text()))"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(../../s0:Disaster_Declaration__r/s0:Disaster_Description__c/text()))"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v4))"" />
            <xsl:variable name=""var:v6"" select=""string(../../s0:Disaster_Declaration__r/s0:Name/text())"" />
            <xsl:variable name=""var:v7"" select=""string(../../s0:Disaster_Declaration__r/s0:Disaster_Description__c/text())"" />
            <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat($var:v6 , &quot; - &quot; , $var:v7)"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:LogicalNot(string($var:v5))"" />
            <ns0:row>
              <ns0:ApplicantId>
                <xsl:value-of select=""s0:Id/text()"" />
              </ns0:ApplicantId>
              <ns0:ApplicantExternalID>
                <xsl:if test=""s0:External_ID__c"">
                  <xsl:value-of select=""s0:External_ID__c/text()"" />
                </xsl:if>
              </ns0:ApplicantExternalID>
              <ns0:ApplicantName>
                <xsl:value-of select=""s0:Name/text()"" />
              </ns0:ApplicantName>
              <ns0:ApplicantRelationType>
                <xsl:if test=""s0:Applicant_Relation_Type__c"">
                  <xsl:value-of select=""s0:Applicant_Relation_Type__c/text()"" />
                </xsl:if>
              </ns0:ApplicantRelationType>
              <ns0:ApplicantTradeName>
                <xsl:if test=""s0:Trade_Name__c"">
                  <xsl:value-of select=""s0:Trade_Name__c/text()"" />
                </xsl:if>
              </ns0:ApplicantTradeName>
              <ns0:ApplicationLoanType>
                <xsl:if test=""../../s0:Loan_Type__c"">
                  <xsl:value-of select=""../../s0:Loan_Type__c/text()"" />
                </xsl:if>
              </ns0:ApplicationLoanType>
              <ns0:ApplicationId>
                <xsl:value-of select=""../../s0:Id/text()"" />
              </ns0:ApplicationId>
              <ns0:ApplicationName>
                <xsl:value-of select=""../../s0:Name/text()"" />
              </ns0:ApplicationName>
              <ns0:Disaster_Name>
                <xsl:if test=""string($var:v5)='true'"">
                  <xsl:variable name=""var:v9"" select=""string($var:v8)"" />
                  <xsl:value-of select=""$var:v9"" />
                </xsl:if>
                <xsl:if test=""string($var:v10)='true'"">
                  <xsl:variable name=""var:v11"" select=""../../s0:Disaster_Declaration__r/s0:Name/text()"" />
                  <xsl:value-of select=""$var:v11"" />
                </xsl:if>
              </ns0:Disaster_Name>
              <ns0:DisasterDeadlineDate>
                <xsl:if test=""../../s0:Disaster_Declaration__r/s0:Disaster_Deadline_Date__c"">
                  <xsl:value-of select=""../../s0:Disaster_Declaration__r/s0:Disaster_Deadline_Date__c/text()"" />
                </xsl:if>
              </ns0:DisasterDeadlineDate>
              <ns0:ContactLastName>
                <xsl:value-of select=""s0:Contact__r/s0:LastName/text()"" />
              </ns0:ContactLastName>
              <ns0:ContactFirstName>
                <xsl:if test=""s0:Contact__r/s0:FirstName"">
                  <xsl:value-of select=""s0:Contact__r/s0:FirstName/text()"" />
                </xsl:if>
              </ns0:ContactFirstName>
              <ns0:ContactOrganizationType>
                <xsl:value-of select=""s0:Contact__r/s0:Organization_Type__c/text()"" />
              </ns0:ContactOrganizationType>
              <ns0:AccountName>
                <xsl:value-of select=""s0:Account__r/s0:Name/text()"" />
              </ns0:AccountName>
              <ns0:AccountBusinessType>
                <xsl:if test=""s0:Account__r/s0:Business_Type__c"">
                  <xsl:value-of select=""s0:Account__r/s0:Business_Type__c/text()"" />
                </xsl:if>
              </ns0:AccountBusinessType>
            </ns0:row>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Response>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


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
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult";
        
        private const global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.QueryResult _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+QueryResult";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
                return _TrgSchemas;
            }
        }
    }
}
