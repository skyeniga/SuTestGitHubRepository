namespace Application_Import_Logic.Property__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceDamaged_Property__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceDamaged_Property__c.parameters))]
    public sealed class MakeProperty__cMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/DamagedProperty__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""DmgPropertyColl"">
          <xsl:for-each select=""Dmg_Properties"">
            <xsl:variable name=""var:v1"" select=""../../ApplicantColl/Applicants[1]/APL_FIRST_NAME/text()"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:StringSize(string($var:v1))"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalGt(string($var:v2) , &quot;2&quot;)"" />
            <xsl:variable name=""var:v4"" select=""../../ApplicantColl/Applicants[1]/APL_LAST_NAME/text()"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:StringSize(string($var:v4))"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;2&quot;)"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalOr(string($var:v3) , string($var:v6))"" />
            <xsl:variable name=""var:v11"" select=""userCSharp:StringSize(string(../../ApplicantColl/Applicants/APL_BUS_TRADE_NAME/text()))"" />
            <xsl:variable name=""var:v12"" select=""userCSharp:LogicalGt(string($var:v11) , &quot;2&quot;)"" />
            <xsl:variable name=""var:v13"" select=""userCSharp:LogicalNot(string($var:v7))"" />
            <xsl:variable name=""var:v14"" select=""userCSharp:LogicalAnd(string($var:v12) , string($var:v13))"" />
            <xsl:variable name=""var:v17"" select=""userCSharp:LogicalNot(string($var:v12))"" />
            <xsl:variable name=""var:v18"" select=""userCSharp:LogicalAnd(string($var:v13) , string($var:v17))"" />
            <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimRight(string(MailingAddress/MAR_ADDRESS1/text()))"" />
            <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(string($var:v20) , &quot; &quot; , string(MailingAddress/MAR_ADDRESS2/text()))"" />
            <xsl:variable name=""var:v22"" select=""userCSharp:StringConcat(&quot;true&quot;)"" />
            <xsl:variable name=""var:v23"" select=""userCSharp:StringConcat(string(../../APP_ELA_REFERENCE_NBR/text()) , &quot;_&quot; , string(DmgPropertyId/text()))"" />
            <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq(string(DPO_PRIMARY_IND/text()) , &quot;Y&quot;)"" />
            <xsl:variable name=""var:v26"" select=""string(DPO_PRIMARY_IND/text())"" />
            <xsl:variable name=""var:v27"" select=""userCSharp:LogicalEq($var:v26 , &quot;N&quot;)"" />
            <xsl:variable name=""var:v29"" select=""userCSharp:LogicalEq(string(DPO_OWN_IND/text()) , &quot;HOME_OWNER_ODA&quot;)"" />
            <xsl:variable name=""var:v31"" select=""string(DPO_OWN_IND/text())"" />
            <xsl:variable name=""var:v32"" select=""userCSharp:LogicalEq($var:v31 , &quot;HOME_RENTER_ODA&quot;)"" />
            <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq(string(DPO_HOME_RE/text()) , &quot;true&quot;)"" />
            <xsl:variable name=""var:v36"" select=""userCSharp:LogicalEq(string(DPO_HOME_PP/text()) , &quot;true&quot;)"" />
            <xsl:variable name=""var:v38"" select=""userCSharp:LogicalEq(string(DPO_HOME_AUTO/text()) , &quot;true&quot;)"" />
            <ns0:after>
              <ns0:Property__c>
                <xsl:if test=""string($var:v7)='true'"">
                  <xsl:variable name=""var:v8"" select=""userCSharp:StringTrimRight(string($var:v1))"" />
                  <xsl:variable name=""var:v9"" select=""userCSharp:StringTrimRight(string($var:v4))"" />
                  <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(string($var:v8) , &quot; &quot; , string($var:v9) , &quot; &quot; , &quot;Property&quot;)"" />
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""$var:v10"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v14)='true'"">
                  <xsl:variable name=""var:v15"" select=""../../ApplicantColl/Applicants[1]/APL_BUS_TRADE_NAME/text()"" />
                  <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(string($var:v15) , &quot;  &quot; , &quot;Property&quot;)"" />
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""$var:v16"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v19"" select=""&quot;Property&quot;"" />
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""$var:v19"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""City__c"">
                  <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""County__c"">
                  <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""State__c"">
                  <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Property_Address__c"">
                  <xsl:value-of select=""$var:v21"" />
                </xsl:attribute>
                <xsl:attribute name=""Zip_Code__c"">
                  <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Damaged_Property__c"">
                  <xsl:value-of select=""$var:v22"" />
                </xsl:attribute>
                <xsl:attribute name=""External_ID__c"">
                  <xsl:value-of select=""$var:v23"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v24)='true'"">
                  <xsl:variable name=""var:v25"" select=""&quot;Yes&quot;"" />
                  <xsl:attribute name=""Primary_Residence__c"">
                    <xsl:value-of select=""$var:v25"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v28"" select=""&quot;No&quot;"" />
                  <xsl:attribute name=""Primary_Residence__c"">
                    <xsl:value-of select=""$var:v28"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v29)='true'"">
                  <xsl:variable name=""var:v30"" select=""&quot;Yes&quot;"" />
                  <xsl:attribute name=""Owned_By_Applicant__c"">
                    <xsl:value-of select=""$var:v30"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v32)='true'"">
                  <xsl:variable name=""var:v33"" select=""&quot;No&quot;"" />
                  <xsl:attribute name=""Owned_By_Applicant__c"">
                    <xsl:value-of select=""$var:v33"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v34)='true'"">
                  <xsl:variable name=""var:v35"" select=""&quot;Real Estate&quot;"" />
                  <xsl:attribute name=""Damage_Type__c"">
                    <xsl:value-of select=""$var:v35"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v36)='true'"">
                  <xsl:variable name=""var:v37"" select=""&quot;Personal Property&quot;"" />
                  <xsl:attribute name=""Damage_Type__c"">
                    <xsl:value-of select=""$var:v37"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v38)='true'"">
                  <xsl:variable name=""var:v39"" select=""&quot;Auto&quot;"" />
                  <xsl:attribute name=""Damage_Type__c"">
                    <xsl:value-of select=""$var:v39"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v40"" select=""&quot;Property&quot;"" />
                  <xsl:attribute name=""Trade_Name__c"">
                    <xsl:value-of select=""$var:v40"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v14)='true'"">
                  <xsl:variable name=""var:v41"" select=""../../ApplicantColl/Applicants[1]/APL_BUS_TRADE_NAME/text()"" />
                  <xsl:variable name=""var:v42"" select=""userCSharp:StringConcat(string($var:v41) , &quot;  &quot; , &quot;Property&quot;)"" />
                  <xsl:attribute name=""Trade_Name__c"">
                    <xsl:value-of select=""$var:v42"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v7)='true'"">
                  <xsl:variable name=""var:v43"" select=""userCSharp:StringTrimRight(string($var:v1))"" />
                  <xsl:variable name=""var:v44"" select=""userCSharp:StringTrimRight(string($var:v4))"" />
                  <xsl:variable name=""var:v45"" select=""userCSharp:StringConcat(string($var:v43) , &quot; &quot; , string($var:v44) , &quot; &quot; , &quot;Property&quot;)"" />
                  <xsl:attribute name=""Trade_Name__c"">
                    <xsl:value-of select=""$var:v45"" />
                  </xsl:attribute>
                </xsl:if>
              </ns0:Property__c>
            </ns0:after>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


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


public string StringConcat(string param0, string param1, string param2, string param3, string param4)
{
   return param0 + param1 + param2 + param3 + param4;
}


public string StringConcat(string param0)
{
   return param0;
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


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDamaged_Property__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceDamaged_Property__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDamaged_Property__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
