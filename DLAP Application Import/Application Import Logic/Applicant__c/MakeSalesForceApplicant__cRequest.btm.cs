namespace Application_Import_Logic.Applicant__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c.parameters))]
    public sealed class MakeSalesForceApplicant_cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(../../APP_PRD_PRODUCT/text()) , &quot;Home&quot;)"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimRight(string(APL_FIRST_NAME/text()))"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string($var:v2) , &quot; &quot; , string(APL_LAST_NAME/text()))"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(string($var:v1))"" />
            <xsl:variable name=""var:v15"" select=""userCSharp:LogicalEq(string(ApplicantType/text()) , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v17"" select=""string(ApplicantType/text())"" />
            <xsl:variable name=""var:v18"" select=""userCSharp:LogicalNe($var:v17 , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v20"" select=""userCSharp:LogicalEq(string(APL_SBA_EMPLOYEE/text()) , &quot;N&quot;)"" />
            <xsl:variable name=""var:v22"" select=""string(APL_SBA_EMPLOYEE/text())"" />
            <xsl:variable name=""var:v23"" select=""userCSharp:LogicalEq($var:v22 , &quot;Y&quot;)"" />
            <xsl:variable name=""var:v25"" select=""position()"" />
            <xsl:variable name=""var:v26"" select=""../Applicants[number($var:v25)]/ApplicantId/text()"" />
            <xsl:variable name=""var:v27"" select=""userCSharp:LogicalNe(string(../../Final_Questions/FQS_EMP_NAME1_ID/text()) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v38"" select=""userCSharp:LogicalExistence(boolean(ApplicantId))"" />
            <xsl:variable name=""var:v40"" select=""../Applicants[number($var:v25)]/APL_ORG_TYPE_CD/text()"" />
            <xsl:variable name=""var:v41"" select=""../Applicants[number($var:v25)]/SalesForceContactID/text()"" />
            <xsl:variable name=""var:v42"" select=""string(../../APP_PRD_PRODUCT/text())"" />
            <xsl:variable name=""var:v44"" select=""../Applicants[number($var:v25)]/APL_SalesForceAccountID/text()"" />
            <xsl:variable name=""var:v46"" select=""userCSharp:LogicalEq(string(APL_CITIZEN_IND/text()) , &quot;Y&quot;)"" />
            <xsl:variable name=""var:v48"" select=""string(APL_CITIZEN_IND/text())"" />
            <xsl:variable name=""var:v49"" select=""userCSharp:LogicalEq($var:v48 , &quot;N&quot;)"" />
            <xsl:variable name=""var:v54"" select=""../Applicants[number($var:v25)]/APL_SSN/text()"" />
            <xsl:variable name=""var:v55"" select=""../Applicants[number($var:v25)]/APL_EIN_NBR/text()"" />
            <ns0:after>
              <ns0:Applicant__c>
                <xsl:if test=""string($var:v1)='true'"">
                  <xsl:variable name=""var:v4"" select=""string($var:v3)"" />
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""$var:v4"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v5)='true'"">
                  <xsl:variable name=""var:v6"" select=""APL_LEGAL_NAME/text()"" />
                  <xsl:attribute name=""Name"">
                    <xsl:value-of select=""$var:v6"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v5)='true'"">
                  <xsl:variable name=""var:v7"" select=""APL_LEGAL_NAME/text()"" />
                  <xsl:variable name=""var:v8"" select=""userCSharp:StringSize(string($var:v7))"" />
                  <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq(string($var:v8) , &quot;0&quot;)"" />
                  <xsl:variable name=""var:v10"" select=""string(APL_FIRST_NAME/text())"" />
                  <xsl:variable name=""var:v11"" select=""userCSharp:StringTrimRight($var:v10)"" />
                  <xsl:variable name=""var:v12"" select=""string(APL_LAST_NAME/text())"" />
                  <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(string($var:v11) , &quot; &quot; , $var:v12)"" />
                  <xsl:if test=""string($var:v9)='true'"">
                    <xsl:variable name=""var:v14"" select=""string($var:v13)"" />
                    <xsl:attribute name=""Name"">
                      <xsl:value-of select=""$var:v14"" />
                    </xsl:attribute>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""string($var:v15)='true'"">
                  <xsl:variable name=""var:v16"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""Primary_Applicant__c"">
                    <xsl:value-of select=""$var:v16"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v19"" select=""&quot;false&quot;"" />
                  <xsl:attribute name=""Primary_Applicant__c"">
                    <xsl:value-of select=""$var:v19"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v20)='true'"">
                  <xsl:variable name=""var:v21"" select=""&quot;false&quot;"" />
                  <xsl:attribute name=""SBA_Employee__c"">
                    <xsl:value-of select=""$var:v21"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v23)='true'"">
                  <xsl:variable name=""var:v24"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""SBA_Employee__c"">
                    <xsl:value-of select=""$var:v24"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v28"" select=""../../Final_Questions/FQS_EMP_NAME1_ID/text()"" />
                  <xsl:variable name=""var:v29"" select=""userCSharp:LogicalEq(string($var:v26) , string($var:v28))"" />
                  <xsl:if test=""string($var:v29)='true'"">
                    <xsl:variable name=""var:v30"" select=""../../Final_Questions/FQS_EMP_IND/text()"" />
                    <xsl:variable name=""var:v31"" select=""userCSharp:LogicalEq(string($var:v30) , &quot;N&quot;)"" />
                    <xsl:if test=""string($var:v31)='true'"">
                      <xsl:variable name=""var:v32"" select=""&quot;false&quot;"" />
                      <xsl:attribute name=""SBA_Employee__c"">
                        <xsl:value-of select=""$var:v32"" />
                      </xsl:attribute>
                    </xsl:if>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v33"" select=""../../Final_Questions/FQS_EMP_NAME1_ID/text()"" />
                  <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq(string($var:v26) , string($var:v33))"" />
                  <xsl:if test=""string($var:v34)='true'"">
                    <xsl:variable name=""var:v35"" select=""../../Final_Questions/FQS_EMP_IND/text()"" />
                    <xsl:variable name=""var:v36"" select=""userCSharp:LogicalEq(string($var:v35) , &quot;Y&quot;)"" />
                    <xsl:if test=""string($var:v36)='true'"">
                      <xsl:variable name=""var:v37"" select=""&quot;true&quot;"" />
                      <xsl:attribute name=""SBA_Employee__c"">
                        <xsl:value-of select=""$var:v37"" />
                      </xsl:attribute>
                    </xsl:if>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""string($var:v38)='true'"">
                  <xsl:variable name=""var:v39"" select=""ApplicantId/text()"" />
                  <xsl:attribute name=""External_ID__c"">
                    <xsl:value-of select=""$var:v39"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:variable name=""var:v43"" select=""userCSharp:ApplicantContact($var:v42 , string($var:v40) , string($var:v41))"" />
                <xsl:attribute name=""Contact__c"">
                  <xsl:value-of select=""$var:v43"" />
                </xsl:attribute>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:variable name=""var:v45"" select=""userCSharp:ApplicantAccount($var:v42 , string($var:v40) , string($var:v44))"" />
                <xsl:attribute name=""Account__c"">
                  <xsl:value-of select=""$var:v45"" />
                </xsl:attribute>
                <xsl:attribute name=""Title__c"">
                  <xsl:value-of select=""APL_TITLEOFFICE/text()"" />
                </xsl:attribute>
                <xsl:attribute name=""Ownership_Percent__c"">
                  <xsl:value-of select=""APL_PER_OWNERSHIP/text()"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v46)='true'"">
                  <xsl:variable name=""var:v47"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""U_S_Citizen__c"">
                    <xsl:value-of select=""$var:v47"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v49)='true'"">
                  <xsl:variable name=""var:v50"" select=""&quot;false&quot;"" />
                  <xsl:attribute name=""U_S_Citizen__c"">
                    <xsl:value-of select=""$var:v50"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:variable name=""var:v51"" select=""userCSharp:ApplicantRecordType($var:v42 , string($var:v40) , string(../../Record_SF_Default_Applicant/text()) , string(../../Record_SF_Business_Entity_Applicant/text()) , string(../../Record_SF_Business_Owner_Applicant/text()))"" />
                <xsl:attribute name=""RecordTypeId"">
                  <xsl:value-of select=""$var:v51"" />
                </xsl:attribute>
                <xsl:variable name=""var:v52"" select=""userCSharp:RelationTypeValues(string(APL_RELATION_TYPE/text()) , $var:v42)"" />
                <xsl:attribute name=""Applicant_Relation_Type__c"">
                  <xsl:value-of select=""$var:v52"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v15)='true'"">
                  <xsl:variable name=""var:v53"" select=""&quot;Borrower&quot;"" />
                  <xsl:attribute name=""Borrower_Guarantor__c"">
                    <xsl:value-of select=""$var:v53"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:variable name=""var:v56"" select=""userCSharp:TAXIDValue(string($var:v40) , string($var:v54) , string($var:v55))"" />
                <xsl:attribute name=""Tax_ID__c"">
                  <xsl:value-of select=""$var:v56"" />
                </xsl:attribute>
                <xsl:variable name=""var:v57"" select=""userCSharp:EntityTypeValues(string(APL_ORG_TYPE_CD/text()))"" />
                <xsl:variable name=""var:v58"" select=""userCSharp:StringSize(string($var:v57))"" />
                <xsl:variable name=""var:v59"" select=""userCSharp:LogicalGte(string($var:v58) , &quot;2&quot;)"" />
                <xsl:if test=""string($var:v59)='true'"">
                  <xsl:variable name=""var:v60"" select=""string($var:v57)"" />
                  <xsl:attribute name=""Entity_Type__c"">
                    <xsl:value-of select=""$var:v60"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:attribute name=""Family_Size__c"">
                  <xsl:value-of select=""APL_FAMILY_SIZE/text()"" />
                </xsl:attribute>
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


public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string ApplicantRecordType(string APP_PRD_PRODUCT, string APL_ORG_TYPE_CD, string Record_SF_Default_Applicant, string Record_SF_Business_Entity_Applicant, string Record_SF_Business_Owner_Applicant)
    {          

    if (APP_PRD_PRODUCT == ""Home"")
     { return Record_SF_Default_Applicant; }
           

     else if ((APP_PRD_PRODUCT != ""Home"")&&(APL_ORG_TYPE_CD == ""IND""))
     { return Record_SF_Business_Owner_Applicant; }              
				
    else
    { return Record_SF_Business_Entity_Applicant; }
    }


public string RelationTypeValues(string Relationship_Type,string APP_PRD_PRODUCT)
{
  if (!string.IsNullOrEmpty(Relationship_Type))
  {         

		if (APP_PRD_PRODUCT == ""Home"")
		{    
	
			if (Relationship_Type == ""SPOUSE"")
			{ return ""Spouse""; }

			else if (Relationship_Type == ""UNDEFINED"")
			{ return """"; }
			
			else{ return """"; }
		}
		
		else{	
			if (Relationship_Type == ""PRIM"")
			{ return ""Applicant""; }

			else if (Relationship_Type == ""OWNER"")
			{ return ""Owner""; }
	
			else if (Relationship_Type == ""SPOUSE"")
			{ return ""Spouse""; }
	
			else if (Relationship_Type == ""OTHER_ODA"")
			{ return """"; }
	
			else if (Relationship_Type == ""UNDEFINED"")
			{ return """"; }
			else{ return """"; }
			}
	}
else{ return """"; }

}

public string TAXIDValue(string APL_ORG_TYPE_CD,string APLSSNNumber,string APLEINNumber)        
{
  if ((!string.IsNullOrEmpty(APL_ORG_TYPE_CD))&&(!string.IsNullOrEmpty(APL_ORG_TYPE_CD)))
  { 
     if (APL_ORG_TYPE_CD == ""IND"")
     { return ""1""+APLSSNNumber; }                
				
    else
     { return ""0""+APLEINNumber; }
	 
   }
   else {return """";}   
}

public string EntityTypeValues(string APL_ORG_TYPE_CD)
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

public bool LogicalGte(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 >= d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) >= 0;
	}
	return ret;
}


public string ApplicantContact(string APP_PRD_PRODUCT, string APL_ORG_TYPE_CD,string ContactSFID)
{ 
    if ((APP_PRD_PRODUCT == ""Home"")||(APL_ORG_TYPE_CD == ""IND""))
     { return ContactSFID; }              
				
    else
    { return """"; }
}


public string ApplicantAccount(string APP_PRD_PRODUCT, string APL_ORG_TYPE_CD,string AccountSFID)
{ 
    if ((APP_PRD_PRODUCT != ""Home"")&&(APL_ORG_TYPE_CD != ""IND""))
     { return AccountSFID; }              
				
    else
    { return """"; }
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
