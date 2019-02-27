namespace Application_Import_Logic.Account {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+parameters", typeof(global::Salesforce_Application_Import_Definition.Account.CDataServiceAccount.parameters))]
    public sealed class MakeSalesForceAccountMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Account"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(../../APP_PRD_PRODUCT/text()) , &quot;Home&quot;)"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(ApplicantType/text()) , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalAnd(string($var:v1) , string($var:v2))"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNot(string($var:v1))"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNe(string(APL_ORG_TYPE_CD/text()) , &quot;IND&quot;)"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalAnd(string($var:v4) , string($var:v5))"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalOr(string($var:v3) , string($var:v6))"" />
            <xsl:if test=""$var:v7"">
              <xsl:variable name=""var:v8"" select=""string(../../APP_PRD_PRODUCT/text())"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;Home&quot;)"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(string(APL_FIRST_NAME/text()) , &quot; &quot; , string(APL_LAST_NAME/text()) , &quot; &quot; , &quot;Household&quot;)"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:LogicalNot(string($var:v9))"" />
              <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(string(MailingAddress/MAR_ADDRESS1/text()) , &quot; &quot; , string(MailingAddress/MAR_ADDRESS2/text()))"" />
              <xsl:variable name=""var:v22"" select=""userCSharp:StringLeft(string($var:v21) , &quot;255&quot;)"" />
              <xsl:variable name=""var:v23"" select=""userCSharp:LogicalExistence(string($var:v22))"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:StringTrimLeft(string($var:v22))"" />
              <xsl:variable name=""var:v28"" select=""string(APL_ORG_TYPE_CD/text())"" />
              <xsl:variable name=""var:v30"" select=""userCSharp:LogicalExistence(boolean(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_RE))"" />
              <xsl:variable name=""var:v31"" select=""userCSharp:LogicalEq(string(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_RE/text()) , &quot;true&quot;)"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:LogicalAnd(string($var:v30) , string($var:v31))"" />
              <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq(string(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_PP/text()) , &quot;true&quot;)"" />
              <xsl:variable name=""var:v35"" select=""userCSharp:LogicalExistence(boolean(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_PP))"" />
              <xsl:variable name=""var:v36"" select=""userCSharp:LogicalAnd(string($var:v34) , string($var:v35))"" />
              <xsl:variable name=""var:v38"" select=""userCSharp:LogicalEq(string(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_AUTO/text()) , &quot;true&quot;)"" />
              <xsl:variable name=""var:v39"" select=""userCSharp:LogicalExistence(boolean(../../DmgPropertyColl/Dmg_Properties/DPO_HOME_AUTO))"" />
              <xsl:variable name=""var:v40"" select=""userCSharp:LogicalAnd(string($var:v38) , string($var:v39))"" />
              <xsl:variable name=""var:v42"" select=""userCSharp:StringSize(string(APL_DATE_CURR_MGMT/text()))"" />
              <xsl:variable name=""var:v43"" select=""userCSharp:LogicalGt(string($var:v42) , &quot;4&quot;)"" />
              <xsl:variable name=""var:v45"" select=""userCSharp:StringSize(string(APL_DATE_ESTD/text()))"" />
              <xsl:variable name=""var:v46"" select=""userCSharp:LogicalGt(string($var:v45) , &quot;4&quot;)"" />
              <xsl:variable name=""var:v48"" select=""userCSharp:LogicalEq(string(../../DmgPropertyColl/Dmg_Properties/DPO_OWN_IND/text()) , &quot;HOME_OWNER_ODA&quot;)"" />
              <xsl:variable name=""var:v50"" select=""string(../../DmgPropertyColl/Dmg_Properties/DPO_OWN_IND/text())"" />
              <xsl:variable name=""var:v51"" select=""userCSharp:LogicalEq($var:v50 , &quot;HOME_RENTER_ODA&quot;)"" />
              <xsl:variable name=""var:v53"" select=""userCSharp:LogicalEq(string(../../DmgPropertyColl/Dmg_Properties/DPO_PRIMARY_IND/text()) , &quot;Y&quot;)"" />
              <xsl:variable name=""var:v55"" select=""string(../../DmgPropertyColl/Dmg_Properties/DPO_PRIMARY_IND/text())"" />
              <xsl:variable name=""var:v56"" select=""userCSharp:LogicalEq($var:v55 , &quot;N&quot;)"" />
              <ns0:after>
                <ns0:Account>
                  <xsl:if test=""string($var:v9)='true'"">
                    <xsl:variable name=""var:v11"" select=""string($var:v10)"" />
                    <xsl:attribute name=""Name"">
                      <xsl:value-of select=""$var:v11"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v12)='true'"">
                    <xsl:variable name=""var:v13"" select=""APL_LEGAL_NAME/text()"" />
                    <xsl:attribute name=""Name"">
                      <xsl:value-of select=""$var:v13"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v12)='true'"">
                    <xsl:variable name=""var:v14"" select=""APL_LEGAL_NAME/text()"" />
                    <xsl:variable name=""var:v15"" select=""userCSharp:StringSize(string($var:v14))"" />
                    <xsl:variable name=""var:v16"" select=""userCSharp:LogicalEq(string($var:v15) , &quot;0&quot;)"" />
                    <xsl:variable name=""var:v17"" select=""string(APL_FIRST_NAME/text())"" />
                    <xsl:variable name=""var:v18"" select=""string(APL_LAST_NAME/text())"" />
                    <xsl:variable name=""var:v19"" select=""userCSharp:StringConcat($var:v17 , &quot; &quot; , $var:v18 , &quot; &quot; , &quot;Household&quot;)"" />
                    <xsl:if test=""string($var:v16)='true'"">
                      <xsl:variable name=""var:v20"" select=""string($var:v19)"" />
                      <xsl:attribute name=""Name"">
                        <xsl:value-of select=""$var:v20"" />
                      </xsl:attribute>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""string($var:v23)='true'"">
                    <xsl:variable name=""var:v25"" select=""string($var:v24)"" />
                    <xsl:attribute name=""ShippingStreet"">
                      <xsl:value-of select=""$var:v25"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""ShippingCity"">
                    <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""ShippingState"">
                    <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""ShippingPostalCode"">
                    <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                  </xsl:attribute>
                  <xsl:variable name=""var:v26"" select=""userCSharp:PhoneNumber(string(APL_CONTACT_METHOD/text()) , string(APL_PRIM_PHONE/text()) , string(APL_WORK_PHONE/text()) , string(APL_ALT_PHONE/text()))"" />
                  <xsl:attribute name=""Phone"">
                    <xsl:value-of select=""$var:v26"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v12)='true'"">
                    <xsl:variable name=""var:v27"" select=""string($var:v26)"" />
                    <xsl:attribute name=""Phone"">
                      <xsl:value-of select=""$var:v27"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""NumberOfEmployees"">
                    <xsl:value-of select=""APL_NO_EMPL/text()"" />
                  </xsl:attribute>
                  <xsl:variable name=""var:v29"" select=""userCSharp:BusinessTypeValues($var:v28)"" />
                  <xsl:attribute name=""Business_Type__c"">
                    <xsl:value-of select=""$var:v29"" />
                  </xsl:attribute>
                  <xsl:attribute name=""County__c"">
                    <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Business_Activity__c"">
                    <xsl:value-of select=""APL_BUS_ACTIVITY/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v32)='true'"">
                    <xsl:variable name=""var:v33"" select=""&quot;Real Estate&quot;"" />
                    <xsl:attribute name=""Damage_Type__c"">
                      <xsl:value-of select=""$var:v33"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v36)='true'"">
                    <xsl:variable name=""var:v37"" select=""&quot;Personal Property&quot;"" />
                    <xsl:attribute name=""Damage_Type__c"">
                      <xsl:value-of select=""$var:v37"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v40)='true'"">
                    <xsl:variable name=""var:v41"" select=""&quot;Auto&quot;"" />
                    <xsl:attribute name=""Damage_Type__c"">
                      <xsl:value-of select=""$var:v41"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v43)='true'"">
                    <xsl:variable name=""var:v44"" select=""APL_DATE_CURR_MGMT/text()"" />
                    <xsl:attribute name=""Date_Current_Management__c"">
                      <xsl:value-of select=""$var:v44"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v46)='true'"">
                    <xsl:variable name=""var:v47"" select=""APL_DATE_ESTD/text()"" />
                    <xsl:attribute name=""Date_Established__c"">
                      <xsl:value-of select=""$var:v47"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""EIN__c"">
                    <xsl:value-of select=""APL_EIN_NBR/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v48)='true'"">
                    <xsl:variable name=""var:v49"" select=""&quot;Yes&quot;"" />
                    <xsl:attribute name=""Primary_Resi_Owned__c"">
                      <xsl:value-of select=""$var:v49"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v51)='true'"">
                    <xsl:variable name=""var:v52"" select=""&quot;No&quot;"" />
                    <xsl:attribute name=""Primary_Resi_Owned__c"">
                      <xsl:value-of select=""$var:v52"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v53)='true'"">
                    <xsl:variable name=""var:v54"" select=""&quot;Yes&quot;"" />
                    <xsl:attribute name=""Primary_Resi__c"">
                      <xsl:value-of select=""$var:v54"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v56)='true'"">
                    <xsl:variable name=""var:v57"" select=""&quot;No&quot;"" />
                    <xsl:attribute name=""Primary_Resi__c"">
                      <xsl:value-of select=""$var:v57"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""Trade_Name__c"">
                    <xsl:value-of select=""APL_BUS_TRADE_NAME/text()"" />
                  </xsl:attribute>
                </ns0:Account>
              </ns0:after>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
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


public string BusinessTypeValues(string APL_ORG_TYPE_CD)
{
  if (!string.IsNullOrEmpty(APL_ORG_TYPE_CD))
  {             
	if (APL_ORG_TYPE_CD == ""IND"")
	{ return ""Individual - Sole Prop""; }

	else if (APL_ORG_TYPE_CD == ""CP"")
	{ return ""Corporation""; }
				
	else if (APL_ORG_TYPE_CD == ""PS"")
	{ return ""Partnership""; }

	else if (APL_ORG_TYPE_CD == ""NO"")
	{ return ""Non-Profit""; }

	else if (APL_ORG_TYPE_CD == ""LP"")
	{ return ""Limited Partnership""; }

	else if (APL_ORG_TYPE_CD == ""TRUST"")
	{ return ""Trust""; }

	else if (APL_ORG_TYPE_CD == ""LLC"")
	{ return ""Limited Partnership""; }
	
	else{ return """"; }
   }
	else{ return """"; }
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
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


public string PhoneNumber(string CONTACT_METHOD,string APL_PRIM_PHONE,string APL_WORK_PHONE,string APL_ALT_PHONE)
{
   if(CONTACT_METHOD == ""HOME_PHONE"")
   {return APL_PRIM_PHONE;}
   
   else if(CONTACT_METHOD == ""WORK_PHONE"")
   {return APL_WORK_PHONE;}   
   
   else if(CONTACT_METHOD == ""ALT_PHONE"")
   {return APL_ALT_PHONE;}

   return APL_PRIM_PHONE;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public string StringTrimLeft(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimStart(null);
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+parameters";
        
        private const global::Salesforce_Application_Import_Definition.Account.CDataServiceAccount.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+parameters";
                return _TrgSchemas;
            }
        }
    }
}
