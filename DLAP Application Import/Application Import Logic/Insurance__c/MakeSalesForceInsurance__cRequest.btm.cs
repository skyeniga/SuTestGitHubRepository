namespace Application_Import_Logic.Insurance__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceInsurance__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceInsurance__c.parameters))]
    public sealed class MakeSalesForceInsurance__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/Insurance__c"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""DmgPropertyColl"">
          <xsl:for-each select=""Dmg_Properties"">
            <xsl:variable name=""var:v1"" select=""position()"" />
            <xsl:for-each select=""DpoInsuranceColl/Dpo_Insurances"">
              <xsl:variable name=""var:v2"" select=""userCSharp:StringSize(string(DPI_TYPE/text()))"" />
              <xsl:variable name=""var:v3"" select=""userCSharp:LogicalGt(string($var:v2) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:StringSize(string(DPI_INS_COMPANYNAME/text()))"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:LogicalGt(string($var:v4) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:StringSize(string(DPI_INS_AGENTNAME/text()))"" />
              <xsl:variable name=""var:v7"" select=""userCSharp:LogicalGt(string($var:v6) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v8"" select=""userCSharp:StringSize(string(DPI_AGENT_PHONE/text()))"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:LogicalGt(string($var:v8) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:StringSize(string(DPI_POLICY_NBR/text()))"" />
              <xsl:variable name=""var:v11"" select=""userCSharp:LogicalGt(string($var:v10) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:StringSize(string(DPI_AMT_RECVD/text()))"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:LogicalGt(string($var:v12) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v14"" select=""userCSharp:LogicalOr(string($var:v3) , string($var:v5) , string($var:v7) , string($var:v9) , string($var:v11) , string($var:v13))"" />
              <xsl:if test=""$var:v14"">
                <xsl:variable name=""var:v15"" select=""string(DPI_TYPE/text())"" />
                <xsl:variable name=""var:v16"" select=""userCSharp:StringSize($var:v15)"" />
                <xsl:variable name=""var:v17"" select=""userCSharp:LogicalGt(string($var:v16) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v18"" select=""string(DPI_INS_COMPANYNAME/text())"" />
                <xsl:variable name=""var:v19"" select=""userCSharp:StringSize($var:v18)"" />
                <xsl:variable name=""var:v20"" select=""userCSharp:LogicalGt(string($var:v19) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v21"" select=""string(DPI_INS_AGENTNAME/text())"" />
                <xsl:variable name=""var:v22"" select=""userCSharp:StringSize($var:v21)"" />
                <xsl:variable name=""var:v23"" select=""userCSharp:LogicalGt(string($var:v22) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v24"" select=""string(DPI_AGENT_PHONE/text())"" />
                <xsl:variable name=""var:v25"" select=""userCSharp:StringSize($var:v24)"" />
                <xsl:variable name=""var:v26"" select=""userCSharp:LogicalGt(string($var:v25) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v27"" select=""string(DPI_POLICY_NBR/text())"" />
                <xsl:variable name=""var:v28"" select=""userCSharp:StringSize($var:v27)"" />
                <xsl:variable name=""var:v29"" select=""userCSharp:LogicalGt(string($var:v28) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v30"" select=""string(DPI_AMT_RECVD/text())"" />
                <xsl:variable name=""var:v31"" select=""userCSharp:StringSize($var:v30)"" />
                <xsl:variable name=""var:v32"" select=""userCSharp:LogicalGt(string($var:v31) , &quot;0&quot;)"" />
                <xsl:variable name=""var:v33"" select=""userCSharp:LogicalOr(string($var:v17) , string($var:v20) , string($var:v23) , string($var:v26) , string($var:v29) , string($var:v32))"" />
                <xsl:variable name=""var:v34"" select=""../../../Dmg_Properties[number($var:v1)]/SalesForcePropertyID/text()"" />
                <ns0:after>
                  <ns0:Insurance__c>
                    <xsl:attribute name=""Application__c"">
                      <xsl:value-of select=""../../../../SalesForceApplication__cID/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Type_of_Insurance_Coverage__c"">
                      <xsl:value-of select=""DPI_TYPE/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Insurance_Company_Name__c"">
                      <xsl:value-of select=""DPI_INS_COMPANYNAME/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Insurance_Agent_Name__c"">
                      <xsl:value-of select=""DPI_INS_AGENTNAME/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Insurance_Agent_Phone_Number__c"">
                      <xsl:value-of select=""DPI_AGENT_PHONE/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Insurance_Policy_Number__c"">
                      <xsl:value-of select=""DPI_POLICY_NBR/text()"" />
                    </xsl:attribute>
                    <xsl:attribute name=""Insurance_Recovery_Amount__c"">
                      <xsl:value-of select=""DPI_AMT_RECVD/text()"" />
                    </xsl:attribute>
                    <xsl:if test=""string($var:v33)='true'"">
                      <xsl:variable name=""var:v35"" select=""string($var:v34)"" />
                      <xsl:attribute name=""Property__c"">
                        <xsl:value-of select=""$var:v35"" />
                      </xsl:attribute>
                    </xsl:if>
                  </ns0:Insurance__c>
                </ns0:after>
              </xsl:if>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
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


public bool LogicalOr(string param0, string param1, string param2, string param3, string param4, string param5)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2) || ValToBool(param3) || ValToBool(param4) || ValToBool(param5);
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceInsurance__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceInsurance__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceInsurance__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
