namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.CDataServiceOther_Assistance__c+parameters", typeof(global::Salesforce_Application_Import_Definition.CDataServiceOther_Assistance__c.parameters))]
    public sealed class MakeOtherAssistanceRequestMessage : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Other_Assistance__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""DpoDupBenefitColl"">
          <xsl:for-each select=""Dpo_DupBenefits"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(DOB_AGENCY_NAME/text()))"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(DOB_AMT_RECVD/text()))"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:StringSize(string(DOB_OTHER_DESC/text()))"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4) , string($var:v6))"" />
            <xsl:if test=""$var:v7"">
              <xsl:variable name=""var:v8"" select=""string(DOB_OTHER_DESC/text())"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;STATE&quot;)"" />
              <xsl:variable name=""var:v11"" select=""string(DOB_AGENCY_NAME/text())"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:StringSize($var:v11)"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:LogicalGt(string($var:v12) , &quot;1&quot;)"" />
              <xsl:variable name=""var:v14"" select=""string(DOB_AMT_RECVD/text())"" />
              <xsl:variable name=""var:v15"" select=""userCSharp:StringSize($var:v14)"" />
              <xsl:variable name=""var:v16"" select=""userCSharp:LogicalGt(string($var:v15) , &quot;1&quot;)"" />
              <xsl:variable name=""var:v17"" select=""userCSharp:StringSize($var:v8)"" />
              <xsl:variable name=""var:v18"" select=""userCSharp:LogicalGt(string($var:v17) , &quot;1&quot;)"" />
              <xsl:variable name=""var:v19"" select=""userCSharp:LogicalOr(string($var:v13) , string($var:v16) , string($var:v18))"" />
              <xsl:variable name=""var:v21"" select=""userCSharp:LogicalEq(string(../../APP_PRD_PRODUCT/text()) , &quot;Home&quot;)"" />
              <xsl:variable name=""var:v22"" select=""../../DmgPropertyColl/Dmg_Properties[1]/SalesForcePropertyID/text()"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq($var:v8 , &quot;FEMA&quot;)"" />
              <xsl:variable name=""var:v26"" select=""userCSharp:LogicalNot(string($var:v24))"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:LogicalNot(string($var:v9))"" />
              <xsl:variable name=""var:v28"" select=""userCSharp:LogicalAnd(string($var:v26) , string($var:v27))"" />
              <ns0:after>
                <ns0:Other_Assistance__c>
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""DOB_AGENCY_NAME/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Application__c"">
                    <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v9)='true'"">
                    <xsl:variable name=""var:v10"" select=""DOB_AMT_RECVD/text()"" />
                    <xsl:attribute name=""State_Grant__c"">
                      <xsl:value-of select=""$var:v10"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v19)='true'"">
                    <xsl:variable name=""var:v20"" select=""&quot;true&quot;"" />
                    <xsl:attribute name=""Active__c"">
                      <xsl:value-of select=""$var:v20"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v21)='true'"">
                    <xsl:variable name=""var:v23"" select=""string($var:v22)"" />
                    <xsl:attribute name=""Property__c"">
                      <xsl:value-of select=""$var:v23"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v24)='true'"">
                    <xsl:variable name=""var:v25"" select=""DOB_AMT_RECVD/text()"" />
                    <xsl:attribute name=""FEMA_Grant__c"">
                      <xsl:value-of select=""$var:v25"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v28)='true'"">
                    <xsl:variable name=""var:v29"" select=""DOB_AMT_RECVD/text()"" />
                    <xsl:attribute name=""Other_Grant__c"">
                      <xsl:value-of select=""$var:v29"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""Other_Grant_Description__c"">
                    <xsl:value-of select=""DOB_OTHER_DESC/text()"" />
                  </xsl:attribute>
                </ns0:Other_Assistance__c>
              </ns0:after>
            </xsl:if>
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.CDataServiceOther_Assistance__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition.CDataServiceOther_Assistance__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.CDataServiceOther_Assistance__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
