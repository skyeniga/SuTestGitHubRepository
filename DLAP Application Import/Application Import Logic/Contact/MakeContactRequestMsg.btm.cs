namespace Application_Import_Logic.Contact {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceContact+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceContact.parameters))]
    public sealed class MakeContactRequestMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Contact"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
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
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(APL_ORG_TYPE_CD/text()) , &quot;IND&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalOr(string($var:v1) , string($var:v2))"" />
            <xsl:if test=""$var:v3"">
              <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;false&quot;)"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:LogicalIsString(string(MailingAddress/MAR_ADDRESS2/text()))"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:LogicalExistence(boolean(MailingAddress/MAR_ADDRESS2))"" />
              <xsl:variable name=""var:v7"" select=""userCSharp:LogicalAnd(string($var:v5) , string($var:v6))"" />
              <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
              <xsl:variable name=""var:v14"" select=""userCSharp:StringSize(string(APL_DOB/text()))"" />
              <xsl:variable name=""var:v15"" select=""userCSharp:LogicalGt(string($var:v14) , &quot;4&quot;)"" />
              <xsl:variable name=""var:v17"" select=""userCSharp:LogicalEq(string(APL_MARITAL_STATUS/text()) , &quot;UNMARRIED_ODA&quot;)"" />
              <xsl:variable name=""var:v19"" select=""string(APL_MARITAL_STATUS/text())"" />
              <xsl:variable name=""var:v20"" select=""userCSharp:LogicalEq($var:v19 , &quot;MARRIED&quot;)"" />
              <xsl:variable name=""var:v22"" select=""userCSharp:LogicalEq($var:v19 , &quot;SINGLE&quot;)"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq(string(APL_SELF_EMPLOYED/text()) , &quot;Y&quot;)"" />
              <xsl:variable name=""var:v26"" select=""string(APL_SELF_EMPLOYED/text())"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:LogicalEq($var:v26 , &quot;N&quot;)"" />
              <xsl:variable name=""var:v29"" select=""userCSharp:StringConcat(&quot;Social_Security_Number__c&quot;)"" />
              <xsl:variable name=""var:v30"" select=""string(APL_ORG_TYPE_CD/text())"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:LogicalEq(string(APL_CITIZEN_IND/text()) , &quot;Y&quot;)"" />
              <xsl:variable name=""var:v34"" select=""string(APL_CITIZEN_IND/text())"" />
              <xsl:variable name=""var:v35"" select=""userCSharp:LogicalEq($var:v34 , &quot;N&quot;)"" />
              <xsl:variable name=""var:v37"" select=""../Applicants[1]/APL_SalesForceAccountID/text()"" />
              <xsl:variable name=""var:v38"" select=""string(../../APP_PRD_PRODUCT/text())"" />
              <xsl:variable name=""var:v43"" select=""userCSharp:LogicalEq(string(APL_SBA_EMPLOYEE/text()) , &quot;Y&quot;)"" />
              <xsl:variable name=""var:v45"" select=""string(APL_SBA_EMPLOYEE/text())"" />
              <xsl:variable name=""var:v46"" select=""userCSharp:LogicalEq($var:v45 , &quot;N&quot;)"" />
              <xsl:variable name=""var:v48"" select=""position()"" />
              <xsl:variable name=""var:v49"" select=""../Applicants[number($var:v48)]/ApplicantId/text()"" />
              <xsl:variable name=""var:v50"" select=""userCSharp:LogicalNe(string(../../Final_Questions/FQS_EMP_NAME1_ID/text()) , &quot;0&quot;)"" />
              <xsl:variable name=""var:v61"" select=""userCSharp:StringSize(string(APL_DATE_ESTD/text()))"" />
              <xsl:variable name=""var:v62"" select=""userCSharp:LogicalGt(string($var:v61) , &quot;0&quot;)"" />
              <ns0:after>
                <xsl:attribute name=""IsUpsert"">
                  <xsl:value-of select=""$var:v4"" />
                </xsl:attribute>
                <ns0:Contact>
                  <xsl:attribute name=""LastName"">
                    <xsl:value-of select=""APL_LAST_NAME/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""FirstName"">
                    <xsl:value-of select=""APL_FIRST_NAME/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""MiddleName"">
                    <xsl:value-of select=""APL_MIDDLE_NAME/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Suffix"">
                    <xsl:value-of select=""APL_SUFFIX/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v8)='true'"">
                    <xsl:variable name=""var:v9"" select=""MailingAddress/MAR_ADDRESS1/text()"" />
                    <xsl:variable name=""var:v10"" select=""userCSharp:StringLeft(string($var:v9) , &quot;255&quot;)"" />
                    <xsl:attribute name=""MailingStreet"">
                      <xsl:value-of select=""$var:v10"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v7)='true'"">
                    <xsl:variable name=""var:v11"" select=""MailingAddress/MAR_ADDRESS2/text()"" />
                    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(string(MailingAddress/MAR_ADDRESS1/text()) , &quot; &quot; , string($var:v11))"" />
                    <xsl:variable name=""var:v13"" select=""userCSharp:StringLeft(string($var:v12) , &quot;255&quot;)"" />
                    <xsl:attribute name=""MailingStreet"">
                      <xsl:value-of select=""$var:v13"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""MailingCity"">
                    <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""MailingState"">
                    <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""MailingPostalCode"">
                    <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Fax"">
                    <xsl:value-of select=""APL_FAX/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""MobilePhone"">
                    <xsl:value-of select=""APL_ALT_PHONE/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Email"">
                    <xsl:value-of select=""APL_EMAIL/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v15)='true'"">
                    <xsl:variable name=""var:v16"" select=""APL_DOB/text()"" />
                    <xsl:attribute name=""Birthdate"">
                      <xsl:value-of select=""$var:v16"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""Social_Security_Number__c"">
                    <xsl:value-of select=""APL_SSN/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v17)='true'"">
                    <xsl:variable name=""var:v18"" select=""&quot;Unmarried(Single, Divorced, Widowed)&quot;"" />
                    <xsl:attribute name=""Marital_Status__c"">
                      <xsl:value-of select=""$var:v18"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v20)='true'"">
                    <xsl:variable name=""var:v21"" select=""&quot;Married&quot;"" />
                    <xsl:attribute name=""Marital_Status__c"">
                      <xsl:value-of select=""$var:v21"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v22)='true'"">
                    <xsl:variable name=""var:v23"" select=""&quot;Single&quot;"" />
                    <xsl:attribute name=""Marital_Status__c"">
                      <xsl:value-of select=""$var:v23"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v24)='true'"">
                    <xsl:variable name=""var:v25"" select=""&quot;Yes&quot;"" />
                    <xsl:attribute name=""Self_Employed__c"">
                      <xsl:value-of select=""$var:v25"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v27)='true'"">
                    <xsl:variable name=""var:v28"" select=""&quot;No&quot;"" />
                    <xsl:attribute name=""Self_Employed__c"">
                      <xsl:value-of select=""$var:v28"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""Work_Phone__c"">
                    <xsl:value-of select=""APL_WORK_PHONE/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Applicant_Relative_Name__c"">
                    <xsl:value-of select=""APL_REL_NAME/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Applicant_Relative_Phone_Number__c"">
                    <xsl:value-of select=""APL_REL_PHONE/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""ExternalIdColumn"">
                    <xsl:value-of select=""$var:v29"" />
                  </xsl:attribute>
                  <xsl:variable name=""var:v31"" select=""userCSharp:OrganizationTypeValues($var:v30)"" />
                  <xsl:attribute name=""Organization_Type__c"">
                    <xsl:value-of select=""$var:v31"" />
                  </xsl:attribute>
                  <xsl:attribute name=""Title"">
                    <xsl:value-of select=""APL_TITLEOFFICE/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v32)='true'"">
                    <xsl:variable name=""var:v33"" select=""&quot;true&quot;"" />
                    <xsl:attribute name=""U_S_Citizen__c"">
                      <xsl:value-of select=""$var:v33"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v35)='true'"">
                    <xsl:variable name=""var:v36"" select=""&quot;false&quot;"" />
                    <xsl:attribute name=""U_S_Citizen__c"">
                      <xsl:value-of select=""$var:v36"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:variable name=""var:v39"" select=""userCSharp:ContactAccount($var:v38 , string($var:v37))"" />
                  <xsl:variable name=""var:v40"" select=""userCSharp:StringSize(string($var:v39))"" />
                  <xsl:variable name=""var:v41"" select=""userCSharp:LogicalGt(string($var:v40) , &quot;4&quot;)"" />
                  <xsl:if test=""string($var:v41)='true'"">
                    <xsl:variable name=""var:v42"" select=""string($var:v39)"" />
                    <xsl:attribute name=""AccountId"">
                      <xsl:value-of select=""$var:v42"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v43)='true'"">
                    <xsl:variable name=""var:v44"" select=""&quot;true&quot;"" />
                    <xsl:attribute name=""SBA_Employee__c"">
                      <xsl:value-of select=""$var:v44"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v46)='true'"">
                    <xsl:variable name=""var:v47"" select=""&quot;false&quot;"" />
                    <xsl:attribute name=""SBA_Employee__c"">
                      <xsl:value-of select=""$var:v47"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v50)='true'"">
                    <xsl:variable name=""var:v51"" select=""../../Final_Questions/FQS_EMP_NAME1_ID/text()"" />
                    <xsl:variable name=""var:v52"" select=""userCSharp:LogicalEq(string($var:v49) , string($var:v51))"" />
                    <xsl:if test=""string($var:v52)='true'"">
                      <xsl:variable name=""var:v53"" select=""../../Final_Questions/FQS_EMP_IND/text()"" />
                      <xsl:variable name=""var:v54"" select=""userCSharp:LogicalEq(string($var:v53) , &quot;N&quot;)"" />
                      <xsl:if test=""string($var:v54)='true'"">
                        <xsl:variable name=""var:v55"" select=""&quot;false&quot;"" />
                        <xsl:attribute name=""SBA_Employee__c"">
                          <xsl:value-of select=""$var:v55"" />
                        </xsl:attribute>
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""string($var:v50)='true'"">
                    <xsl:variable name=""var:v56"" select=""../../Final_Questions/FQS_EMP_NAME1_ID/text()"" />
                    <xsl:variable name=""var:v57"" select=""userCSharp:LogicalEq(string($var:v49) , string($var:v56))"" />
                    <xsl:if test=""string($var:v57)='true'"">
                      <xsl:variable name=""var:v58"" select=""../../Final_Questions/FQS_EMP_IND/text()"" />
                      <xsl:variable name=""var:v59"" select=""userCSharp:LogicalEq(string($var:v58) , &quot;Y&quot;)"" />
                      <xsl:if test=""string($var:v59)='true'"">
                        <xsl:variable name=""var:v60"" select=""&quot;true&quot;"" />
                        <xsl:attribute name=""SBA_Employee__c"">
                          <xsl:value-of select=""$var:v60"" />
                        </xsl:attribute>
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""string($var:v62)='true'"">
                    <xsl:variable name=""var:v63"" select=""APL_DATE_ESTD/text()"" />
                    <xsl:attribute name=""Date_Business_Established__c"">
                      <xsl:value-of select=""$var:v63"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:attribute name=""Preferred_Phone_Type__c"">
                    <xsl:value-of select=""APL_CONTACT_METHOD/text()"" />
                  </xsl:attribute>
                  <xsl:attribute name=""HomePhone"">
                    <xsl:value-of select=""APL_PRIM_PHONE/text()"" />
                  </xsl:attribute>
                </ns0:Contact>
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


public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
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


public string StringConcat(string param0)
{
   return param0;
}


public string OrganizationTypeValues(string APL_ORG_TYPE_CD)
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


public string ContactAccount(string APP_PRD_PRODUCT,string AccountSFID)
{ 
    if (APP_PRD_PRODUCT == ""Home"")
     { return AccountSFID; }              
				
    else
    { return """"; }
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
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceContact+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceContact.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceContact+parameters";
                return _TrgSchemas;
            }
        }
    }
}
