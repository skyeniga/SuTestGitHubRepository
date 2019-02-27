namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.CDataService_Additional_Contact__c+parameters", typeof(global::Salesforce_Application_Import_Definition.CDataService_Additional_Contact__c.parameters))]
    public sealed class MakeAddtionalConatct : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Additional_Contact__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <ns0:parameters>
      <ns0:sync>
        <xsl:for-each select=""ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(../../APP_CONTACT_NAME/text()))"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGte(string($var:v1) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(../../APP_CONTACT_NBR/text()))"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGte(string($var:v3) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4))"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:StringSize(string(../../APP_INSP_NAME/text()))"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalGte(string($var:v6) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
            <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq(string(ApplicantType/text()) , &quot;Primary&quot;)"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(string(APL_FIRST_NAME/text()) , &quot; &quot; , string(APL_LAST_NAME/text()))"" />
            <xsl:if test=""string($var:v9)='true'"">
              <xsl:variable name=""var:v11"" select=""string($var:v10)"" />
              <xsl:variable name=""var:v12"" select=""string(ApplicantType/text())"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq($var:v12 , &quot;Primary&quot;)"" />
              <xsl:if test=""string($var:v13)='true'"">
                <xsl:variable name=""var:v14"" select=""APL_PRIM_PHONE/text()"" />
                <xsl:if test=""$var:v5"">
                  <xsl:variable name=""var:v15"" select=""string(../../APP_CONTACT_NAME/text())"" />
                  <xsl:variable name=""var:v16"" select=""userCSharp:StringSize($var:v15)"" />
                  <xsl:variable name=""var:v17"" select=""userCSharp:LogicalGte(string($var:v16) , &quot;1&quot;)"" />
                  <xsl:variable name=""var:v18"" select=""string(../../APP_CONTACT_NBR/text())"" />
                  <xsl:variable name=""var:v19"" select=""userCSharp:StringSize($var:v18)"" />
                  <xsl:variable name=""var:v20"" select=""userCSharp:LogicalGte(string($var:v19) , &quot;1&quot;)"" />
                  <xsl:variable name=""var:v21"" select=""userCSharp:LogicalOr(string($var:v17) , string($var:v20))"" />
                  <xsl:variable name=""var:v22"" select=""string(../../APP_INSP_NAME/text())"" />
                  <xsl:variable name=""var:v23"" select=""userCSharp:StringSize($var:v22)"" />
                  <xsl:variable name=""var:v24"" select=""userCSharp:LogicalGte(string($var:v23) , &quot;1&quot;)"" />
                  <xsl:variable name=""var:v25"" select=""userCSharp:LogicalNot(string($var:v24))"" />
                  <xsl:variable name=""var:v26"" select=""string(APL_FIRST_NAME/text())"" />
                  <xsl:variable name=""var:v27"" select=""string(APL_LAST_NAME/text())"" />
                  <xsl:variable name=""var:v28"" select=""userCSharp:StringConcat($var:v26 , &quot; &quot; , $var:v27)"" />
                  <ns0:after>
                    <ns0:Additional_Contact__c>
                      <xsl:if test=""string($var:v13)='true'"">
                        <xsl:variable name=""var:v29"" select=""string($var:v28)"" />
                        <xsl:if test=""string($var:v13)='true'"">
                          <xsl:variable name=""var:v30"" select=""../../APP_CONTACT_NAME"" />
                          <xsl:attribute name=""Name"">
                            <xsl:value-of select=""$var:v30"" />
                          </xsl:attribute>
                        </xsl:if>
                      </xsl:if>
                      <xsl:if test=""string($var:v13)='true'"">
                        <xsl:variable name=""var:v31"" select=""string($var:v28)"" />
                        <xsl:if test=""string($var:v13)='true'"">
                          <xsl:variable name=""var:v32"" select=""../../SalesForceApplication__cID"" />
                          <xsl:attribute name=""Application__c"">
                            <xsl:value-of select=""$var:v32"" />
                          </xsl:attribute>
                        </xsl:if>
                      </xsl:if>
                      <xsl:if test=""string($var:v13)='true'"">
                        <xsl:variable name=""var:v33"" select=""string($var:v28)"" />
                        <xsl:if test=""string($var:v13)='true'"">
                          <xsl:variable name=""var:v34"" select=""../../APP_CONTACT_NBR"" />
                          <xsl:attribute name=""Primary_Phone_Number__c"">
                            <xsl:value-of select=""$var:v34"" />
                          </xsl:attribute>
                        </xsl:if>
                      </xsl:if>
                      <xsl:if test=""string($var:v13)='true'"">
                        <xsl:variable name=""var:v35"" select=""string($var:v28)"" />
                        <xsl:if test=""string($var:v13)='true'"">
                          <xsl:variable name=""var:v36"" select=""'App. Processing Contact'"" />
                          <xsl:attribute name=""Role__c"">
                            <xsl:value-of select=""$var:v36"" />
                          </xsl:attribute>
                        </xsl:if>
                      </xsl:if>
                    </ns0:Additional_Contact__c>
                    <xsl:if test=""string($var:v13)='true'"">
                      <xsl:variable name=""var:v37"" select=""string($var:v28)"" />
                      <xsl:if test=""string($var:v13)='true'"" />
                    </xsl:if>
                  </ns0:after>
                </xsl:if>
                <xsl:variable name=""var:v38"" select=""string(../../APP_CONTACT_NAME/text())"" />
                <xsl:variable name=""var:v39"" select=""userCSharp:StringSize($var:v38)"" />
                <xsl:variable name=""var:v40"" select=""userCSharp:LogicalGte(string($var:v39) , &quot;1&quot;)"" />
                <xsl:variable name=""var:v41"" select=""string(../../APP_CONTACT_NBR/text())"" />
                <xsl:variable name=""var:v42"" select=""userCSharp:StringSize($var:v41)"" />
                <xsl:variable name=""var:v43"" select=""userCSharp:LogicalGte(string($var:v42) , &quot;1&quot;)"" />
                <xsl:variable name=""var:v44"" select=""userCSharp:LogicalOr(string($var:v40) , string($var:v43))"" />
                <xsl:variable name=""var:v45"" select=""string(../../APP_INSP_NAME/text())"" />
                <xsl:variable name=""var:v46"" select=""userCSharp:StringSize($var:v45)"" />
                <xsl:variable name=""var:v47"" select=""userCSharp:LogicalGte(string($var:v46) , &quot;1&quot;)"" />
                <xsl:variable name=""var:v48"" select=""userCSharp:LogicalNot(string($var:v47))"" />
                <xsl:variable name=""var:v49"" select=""string(APL_FIRST_NAME/text())"" />
                <xsl:variable name=""var:v50"" select=""string(APL_LAST_NAME/text())"" />
                <xsl:variable name=""var:v51"" select=""userCSharp:StringConcat($var:v49 , &quot; &quot; , $var:v50)"" />
                <xsl:if test=""string($var:v13)='true'"">
                  <xsl:variable name=""var:v52"" select=""string($var:v51)"" />
                  <xsl:if test=""string($var:v13)='true'"">
                    <xsl:if test=""$var:v47"">
                      <ns0:after>
                        <ns0:Additional_Contact__c>
                          <xsl:if test=""string($var:v13)='true'"">
                            <xsl:if test=""string($var:v13)='true'"">
                              <xsl:variable name=""var:v53"" select=""../../APP_INSP_NAME"" />
                              <xsl:attribute name=""Name"">
                                <xsl:value-of select=""$var:v53"" />
                              </xsl:attribute>
                            </xsl:if>
                          </xsl:if>
                          <xsl:if test=""string($var:v13)='true'"">
                            <xsl:if test=""string($var:v13)='true'"">
                              <xsl:variable name=""var:v54"" select=""../../SalesForceApplication__cID"" />
                              <xsl:attribute name=""Application__c"">
                                <xsl:value-of select=""$var:v54"" />
                              </xsl:attribute>
                            </xsl:if>
                          </xsl:if>
                          <xsl:if test=""string($var:v13)='true'"">
                            <xsl:if test=""string($var:v13)='true'"">
                              <xsl:variable name=""var:v55"" select=""../../APP_INSP_NBR"" />
                              <xsl:attribute name=""Primary_Phone_Number__c"">
                                <xsl:value-of select=""$var:v55"" />
                              </xsl:attribute>
                            </xsl:if>
                          </xsl:if>
                          <xsl:if test=""string($var:v13)='true'"">
                            <xsl:if test=""string($var:v13)='true'"">
                              <xsl:variable name=""var:v56"" select=""'Loss Verification Contact'"" />
                              <xsl:attribute name=""Role__c"">
                                <xsl:value-of select=""$var:v56"" />
                              </xsl:attribute>
                            </xsl:if>
                          </xsl:if>
                        </ns0:Additional_Contact__c>
                        <xsl:if test=""string($var:v13)='true'"">
                          <xsl:if test=""string($var:v13)='true'"" />
                        </xsl:if>
                      </ns0:after>
                    </xsl:if>
                    <xsl:if test=""string($var:v13)='true'"">
                      <xsl:if test=""string($var:v13)='true'"">
                        <xsl:if test=""$var:v48"">
                          <ns0:after>
                            <ns0:Additional_Contact__c>
                              <xsl:if test=""string($var:v13)='true'"">
                                <xsl:if test=""string($var:v13)='true'"">
                                  <xsl:variable name=""var:v57"" select=""$var:v52"" />
                                  <xsl:attribute name=""Name"">
                                    <xsl:value-of select=""$var:v57"" />
                                  </xsl:attribute>
                                </xsl:if>
                              </xsl:if>
                              <xsl:if test=""string($var:v13)='true'"">
                                <xsl:if test=""string($var:v13)='true'"">
                                  <xsl:variable name=""var:v58"" select=""../../SalesForceApplication__cID"" />
                                  <xsl:attribute name=""Application__c"">
                                    <xsl:value-of select=""$var:v58"" />
                                  </xsl:attribute>
                                </xsl:if>
                              </xsl:if>
                              <xsl:if test=""string($var:v13)='true'"">
                                <xsl:if test=""string($var:v13)='true'"">
                                  <xsl:variable name=""var:v59"" select=""$var:v14"" />
                                  <xsl:attribute name=""Primary_Phone_Number__c"">
                                    <xsl:value-of select=""$var:v59"" />
                                  </xsl:attribute>
                                </xsl:if>
                              </xsl:if>
                              <xsl:if test=""string($var:v13)='true'"">
                                <xsl:if test=""string($var:v13)='true'"">
                                  <xsl:variable name=""var:v60"" select=""'Loss Verification Contact'"" />
                                  <xsl:attribute name=""Role__c"">
                                    <xsl:value-of select=""$var:v60"" />
                                  </xsl:attribute>
                                </xsl:if>
                              </xsl:if>
                            </ns0:Additional_Contact__c>
                            <xsl:if test=""string($var:v13)='true'"">
                              <xsl:if test=""string($var:v13)='true'"" />
                            </xsl:if>
                          </ns0:after>
                        </xsl:if>
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                </xsl:if>
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.CDataService_Additional_Contact__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition.CDataService_Additional_Contact__c.parameters _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.CDataService_Additional_Contact__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
