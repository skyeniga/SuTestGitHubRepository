namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse", typeof(global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsDefinition.EventStatusResponse", typeof(global::DLAPEventsDefinition.EventStatusResponse))]
    public sealed class MakeRestDLAPEventsStatusResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <STATUS>
      <xsl:for-each select=""s0:records"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(s0:Disaster_Declaration__r/s0:Name/text()))"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
        <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(s0:Disaster_Declaration__r/s0:Disaster_Description__c/text()))"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;0&quot;)"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v4))"" />
        <xsl:variable name=""var:v6"" select=""string(s0:Disaster_Declaration__r/s0:Name/text())"" />
        <xsl:variable name=""var:v7"" select=""string(s0:Disaster_Declaration__r/s0:Disaster_Description__c/text())"" />
        <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat($var:v6 , &quot; - &quot; , $var:v7)"" />
        <xsl:variable name=""var:v10"" select=""userCSharp:LogicalNot(string($var:v5))"" />
        <xsl:variable name=""var:v12"" select=""count(/s0:QueryResult/s0:records/s0:Checklist_Items__r/s0:records/s0:Id)"" />
        <xsl:variable name=""var:v13"" select=""s0:Loans__r/s0:records[1]/s0:Name/text()"" />
        <AppData>
          <App_Nbr>
            <xsl:value-of select=""s0:Name/text()"" />
          </App_Nbr>
          <xsl:if test=""s0:Loan_Type__c"">
            <Loan_Type>
              <xsl:value-of select=""s0:Loan_Type__c/text()"" />
            </Loan_Type>
          </xsl:if>
          <xsl:if test=""string($var:v5)='true'"">
            <xsl:variable name=""var:v9"" select=""string($var:v8)"" />
            <Disaster_Name>
              <xsl:value-of select=""$var:v9"" />
            </Disaster_Name>
          </xsl:if>
          <xsl:if test=""string($var:v10)='true'"">
            <xsl:variable name=""var:v11"" select=""s0:Disaster_Declaration__r/s0:Name/text()"" />
            <Disaster_Name>
              <xsl:value-of select=""$var:v11"" />
            </Disaster_Name>
          </xsl:if>
          <Requested_Document_Count>
            <xsl:value-of select=""$var:v12"" />
          </Requested_Document_Count>
          <xsl:if test=""s0:Disaster_Declaration__r/s0:Disaster_Deadline_Date__c"">
            <Disaster_Deadline_Date>
              <xsl:value-of select=""s0:Disaster_Declaration__r/s0:Disaster_Deadline_Date__c/text()"" />
            </Disaster_Deadline_Date>
          </xsl:if>
          <AccountInformation>
            <Loan_Nbr>
              <xsl:value-of select=""$var:v13"" />
            </Loan_Nbr>
          </AccountInformation>
        </AppData>
      </xsl:for-each>
      <xsl:for-each select=""s0:records"">
        <xsl:variable name=""var:v14"" select=""userCSharp:DateCurrentDate()"" />
        <StatusData>
          <xsl:if test=""s0:DLAP_Status__c"">
            <Short_Description>
              <xsl:value-of select=""s0:DLAP_Status__c/text()"" />
            </Short_Description>
          </xsl:if>
          <xsl:if test=""s0:DLAP_Status_Description__c"">
            <Long_Description>
              <xsl:value-of select=""s0:DLAP_Status_Description__c/text()"" />
            </Long_Description>
          </xsl:if>
          <Status_Date>
            <xsl:value-of select=""$var:v14"" />
          </Status_Date>
        </StatusData>
      </xsl:for-each>
    </STATUS>
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


public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse";
        
        private const global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsDefinition.EventStatusResponse";
        
        private const global::DLAPEventsDefinition.EventStatusResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsDefinition.EventStatusResponse";
                return _TrgSchemas;
            }
        }
    }
}
