namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails", typeof(global::DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsDefinition.EventDocumentListResponse", typeof(global::DLAPEventsDefinition.EventDocumentListResponse))]
    public sealed class MakeDocumentListResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s3 s2 s0 s4 userCSharp"" version=""1.0"" xmlns:s1=""http://SBA.gov/DLAPEventsDocument/Checklist_Item__c"" xmlns:s3=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s2=""http://SBA.gov/DLAPEvents/ChecklistItemDocumentList"" xmlns:s0=""http://SBA.gov/DLAPEvents/Application_Info__c"" xmlns:s4=""http://SBA.gov/DLAPEvents/ContentVersion__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s3:Root"" />
  </xsl:template>
  <xsl:template match=""/s3:Root"">
    <DOCUMENT>
      <AppData>
        <xsl:if test=""InputMessagePart_1/s0:Response/s0:row/s0:ApplicationName"">
          <App_Nbr>
            <xsl:value-of select=""InputMessagePart_1/s0:Response/s0:row/s0:ApplicationName/text()"" />
          </App_Nbr>
        </xsl:if>
        <xsl:if test=""InputMessagePart_1/s0:Response/s0:row/s0:ApplicationLoanType"">
          <Loan_Type>
            <xsl:value-of select=""InputMessagePart_1/s0:Response/s0:row/s0:ApplicationLoanType/text()"" />
          </Loan_Type>
        </xsl:if>
        <xsl:if test=""InputMessagePart_1/s0:Response/s0:row/s0:Disaster_Name"">
          <Disaster_Name>
            <xsl:value-of select=""InputMessagePart_1/s0:Response/s0:row/s0:Disaster_Name/text()"" />
          </Disaster_Name>
        </xsl:if>
        <xsl:element name=""Requested_Document_Count"">
<xsl:value-of select=""count(/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_2' and namespace-uri()='']/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c'][*[local-name()='Checklist_Item_Status__c' and namespace-uri()='http://SBA.gov/DLAPEventsDocument/Checklist_Item__c']/text() != 'Finalized'])"" />
        </xsl:element>
        <xsl:if test=""InputMessagePart_1/s0:Response/s0:row/s0:DisasterDeadlineDate"">
          <Disaster_Deadline_Date>
            <xsl:value-of select=""InputMessagePart_1/s0:Response/s0:row/s0:DisasterDeadlineDate/text()"" />
          </Disaster_Deadline_Date>
        </xsl:if>
      </AppData>
      <ApplicantList>
        <xsl:for-each select=""InputMessagePart_1/s0:Response/s0:row"">
          <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s0:ApplicantId))"" />
          <xsl:if test=""$var:v1"">
            <xsl:variable name=""var:v5"" select=""userCSharp:StringSize(string(s0:ApplicantTradeName/text()))"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v8"" select=""string(s0:ApplicantTradeName/text())"" />
            <xsl:variable name=""var:v9"" select=""userCSharp:StringSize($var:v8)"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:LogicalGt(string($var:v9) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v11"" select=""userCSharp:LogicalNot(string($var:v10))"" />
            <Applicants>
              <xsl:if test=""s0:ApplicantExternalID"">
                <ApplicantId>
                  <xsl:value-of select=""s0:ApplicantExternalID/text()"" />
                </ApplicantId>
              </xsl:if>
              <xsl:variable name=""var:v2"" select=""userCSharp:ContactTypeValues(string(s0:ContactOrganizationType/text()))"" />
              <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence(string($var:v2))"" />
              <xsl:if test=""string($var:v3)='true'"">
                <xsl:variable name=""var:v4"" select=""string($var:v2)"" />
                <APL_ORG_TYPE_CD>
                  <xsl:value-of select=""$var:v4"" />
                </APL_ORG_TYPE_CD>
              </xsl:if>
              <xsl:if test=""string($var:v6)='true'"">
                <xsl:variable name=""var:v7"" select=""s0:ApplicantTradeName/text()"" />
                <LegalName>
                  <xsl:value-of select=""$var:v7"" />
                </LegalName>
              </xsl:if>
              <xsl:if test=""string($var:v11)='true'"">
                <xsl:variable name=""var:v12"" select=""s0:ContactFirstName/text()"" />
                <APL_FIRST_NAME>
                  <xsl:value-of select=""$var:v12"" />
                </APL_FIRST_NAME>
              </xsl:if>
              <xsl:if test=""string($var:v11)='true'"">
                <xsl:variable name=""var:v13"" select=""s0:ContactLastName/text()"" />
                <APL_LAST_NAME>
                  <xsl:value-of select=""$var:v13"" />
                </APL_LAST_NAME>
              </xsl:if>
              <xsl:if test=""s0:ApplicantRelationType"">
                <APL_RELATION_TYPE>
                  <xsl:value-of select=""s0:ApplicantRelationType/text()"" />
                </APL_RELATION_TYPE>
              </xsl:if>
            </Applicants>
          </xsl:if>
        </xsl:for-each>
      </ApplicantList>
      <DocumentList>
        <xsl:for-each select=""InputMessagePart_0/s2:ChecklistItemDocumentList/s2:Responses"">
          <xsl:for-each select=""s4:Response"">
            <xsl:for-each select=""s4:row"">
              <xsl:variable name=""var:v14"" select=""userCSharp:LogicalExistence(boolean(s4:Id))"" />
              <xsl:variable name=""var:v15"" select=""boolean(s4:Id)"" />
              <xsl:variable name=""var:v16"" select=""userCSharp:LogicalExistence($var:v15)"" />
              <xsl:variable name=""var:v17"" select=""userCSharp:LogicalEq(string(../../s2:Type/text()) , &quot;Closing Documents&quot;)"" />
              <xsl:variable name=""var:v18"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v17))"" />
              <xsl:variable name=""var:v20"" select=""userCSharp:LogicalNot(string($var:v17))"" />
              <xsl:variable name=""var:v21"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v20))"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq(string(../../s2:DocumentChecklist_Item_Status__c/text()) , &quot;Invalid&quot;)"" />
              <xsl:variable name=""var:v25"" select=""userCSharp:LogicalNot(string($var:v24))"" />
              <xsl:variable name=""var:v26"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v25))"" />
              <xsl:variable name=""var:v28"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v24))"" />
              <xsl:variable name=""var:v30"" select=""userCSharp:StringSize(string(../../s2:ClosingDocumentApplicantId/text()))"" />
              <xsl:variable name=""var:v31"" select=""userCSharp:LogicalGt(string($var:v30) , &quot;3&quot;)"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v31))"" />
              <xsl:variable name=""var:v35"" select=""string(../../s2:Type/text())"" />
              <xsl:variable name=""var:v36"" select=""userCSharp:LogicalEq($var:v35 , &quot;Closing Documents&quot;)"" />
              <xsl:variable name=""var:v37"" select=""userCSharp:LogicalAnd(string($var:v16) , string($var:v36))"" />
              <xsl:variable name=""var:v39"" select=""userCSharp:LogicalNot(string($var:v36))"" />
              <DocumentDetails>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v19"" select=""&quot;CLOSING_DOCS&quot;"" />
                  <ChecklistType>
                    <xsl:value-of select=""$var:v19"" />
                  </ChecklistType>
                </xsl:if>
                <xsl:if test=""string($var:v21)='true'"">
                  <xsl:variable name=""var:v22"" select=""&quot;NONE&quot;"" />
                  <ChecklistType>
                    <xsl:value-of select=""$var:v22"" />
                  </ChecklistType>
                </xsl:if>
                <xsl:if test=""string($var:v16)='true'"">
                  <xsl:variable name=""var:v23"" select=""&quot;0&quot;"" />
                  <ActionID>
                    <xsl:value-of select=""$var:v23"" />
                  </ActionID>
                </xsl:if>
                <xsl:if test=""string($var:v26)='true'"">
                  <xsl:variable name=""var:v27"" select=""&quot;RECEIVED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v27"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v28)='true'"">
                  <xsl:variable name=""var:v29"" select=""&quot;REJECTED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v29"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v32)='true'"">
                  <xsl:variable name=""var:v33"" select=""../../s2:ClosingDocumentApplicantId/text()"" />
                  <ApplicantId>
                    <xsl:value-of select=""$var:v33"" />
                  </ApplicantId>
                </xsl:if>
                <xsl:if test=""s4:CreatedDate"">
                  <ReceiveDate>
                    <xsl:value-of select=""s4:CreatedDate/text()"" />
                  </ReceiveDate>
                </xsl:if>
                <xsl:if test=""s4:CreatedDate"">
                  <RequestDate>
                    <xsl:value-of select=""s4:CreatedDate/text()"" />
                  </RequestDate>
                </xsl:if>
                <xsl:if test=""string($var:v16)='true'"">
                  <xsl:variable name=""var:v34"" select=""s4:Id/text()"" />
                  <ScanDocumentID>
                    <xsl:value-of select=""$var:v34"" />
                  </ScanDocumentID>
                </xsl:if>
                <xsl:if test=""string($var:v37)='true'"">
                  <xsl:variable name=""var:v38"" select=""&quot;99&quot;"" />
                  <DocumentType>
                    <xsl:value-of select=""$var:v38"" />
                  </DocumentType>
                </xsl:if>
                <xsl:if test=""string($var:v39)='true'"">
                  <xsl:variable name=""var:v40"" select=""s4:DLAP_Document_Type__c/text()"" />
                  <DocumentType>
                    <xsl:value-of select=""$var:v40"" />
                  </DocumentType>
                </xsl:if>
                <xsl:if test=""string($var:v16)='true'"">
                  <xsl:variable name=""var:v41"" select=""../../s2:DocumentMasterCheckListName/text()"" />
                  <DocumentTitle>
                    <xsl:value-of select=""$var:v41"" />
                  </DocumentTitle>
                </xsl:if>
                <xsl:if test=""string($var:v16)='true'"">
                  <xsl:variable name=""var:v42"" select=""../../s2:DocumentMasterChecklist_Description__c/text()"" />
                  <DocumentDescription>
                    <xsl:value-of select=""$var:v42"" />
                  </DocumentDescription>
                </xsl:if>
              </DocumentDetails>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_2/s1:Response/s1:row"">
          <xsl:variable name=""var:v43"" select=""userCSharp:LogicalNe(string(s1:Checklist_Item_Status__c/text()) , &quot;Finalized&quot;)"" />
          <xsl:if test=""$var:v43"">
            <xsl:variable name=""var:v45"" select=""userCSharp:LogicalExistence(boolean(s1:Id))"" />
            <xsl:variable name=""var:v47"" select=""boolean(s1:Id)"" />
            <xsl:variable name=""var:v48"" select=""userCSharp:LogicalExistence($var:v47)"" />
            <xsl:variable name=""var:v50"" select=""userCSharp:LogicalExistence(boolean(s1:ApplicantExternalId))"" />
            <xsl:variable name=""var:v52"" select=""userCSharp:LogicalExistence(boolean(s1:Verified_Date__c))"" />
            <xsl:variable name=""var:v54"" select=""userCSharp:LogicalExistence(boolean(s1:CreatedDate))"" />
            <xsl:variable name=""var:v56"" select=""userCSharp:LogicalExistence(boolean(s1:Checklist_Item_Due_Date__c))"" />
            <xsl:variable name=""var:v63"" select=""userCSharp:LogicalEq(string(../../../InputMessagePart_0/s2:ChecklistItemDocumentList/s2:Responses/s2:Type/text()) , &quot;Closing Documents&quot;)"" />
            <xsl:variable name=""var:v64"" select=""userCSharp:LogicalNot(string($var:v63))"" />
            <DocumentDetails>
              <xsl:variable name=""var:v44"" select=""userCSharp:TypeValues(string(s1:Type__c/text()))"" />
              <ChecklistType>
                <xsl:value-of select=""$var:v44"" />
              </ChecklistType>
              <xsl:if test=""string($var:v45)='true'"">
                <xsl:variable name=""var:v46"" select=""s1:Id/text()"" />
                <ActionID>
                  <xsl:value-of select=""$var:v46"" />
                </ActionID>
              </xsl:if>
              <xsl:if test=""string($var:v48)='true'"">
                <xsl:variable name=""var:v49"" select=""&quot;REQUESTED&quot;"" />
                <Status>
                  <xsl:value-of select=""$var:v49"" />
                </Status>
              </xsl:if>
              <xsl:if test=""string($var:v50)='true'"">
                <xsl:variable name=""var:v51"" select=""s1:ApplicantExternalId/text()"" />
                <ApplicantId>
                  <xsl:value-of select=""$var:v51"" />
                </ApplicantId>
              </xsl:if>
              <xsl:if test=""string($var:v52)='true'"">
                <xsl:variable name=""var:v53"" select=""s1:Verified_Date__c/text()"" />
                <ReceiveDate>
                  <xsl:value-of select=""$var:v53"" />
                </ReceiveDate>
              </xsl:if>
              <xsl:if test=""string($var:v54)='true'"">
                <xsl:variable name=""var:v55"" select=""s1:CreatedDate/text()"" />
                <RequestDate>
                  <xsl:value-of select=""$var:v55"" />
                </RequestDate>
              </xsl:if>
              <xsl:if test=""string($var:v56)='true'"">
                <xsl:variable name=""var:v57"" select=""s1:Checklist_Item_Due_Date__c/text()"" />
                <DeadlineDate>
                  <xsl:value-of select=""$var:v57"" />
                </DeadlineDate>
              </xsl:if>
              <xsl:if test=""string($var:v48)='true'"">
                <xsl:variable name=""var:v58"" select=""&quot;0&quot;"" />
                <ScanDocumentID>
                  <xsl:value-of select=""$var:v58"" />
                </ScanDocumentID>
              </xsl:if>
              <xsl:variable name=""var:v59"" select=""userCSharp:DOCTypeValues(string(s1:DocumentType__c/text()))"" />
              <xsl:variable name=""var:v60"" select=""userCSharp:StringSize(string($var:v59))"" />
              <xsl:variable name=""var:v61"" select=""userCSharp:LogicalGt(string($var:v60) , &quot;2&quot;)"" />
              <xsl:if test=""string($var:v61)='true'"">
                <xsl:variable name=""var:v62"" select=""string($var:v59)"" />
                <DocumentType>
                  <xsl:value-of select=""$var:v62"" />
                </DocumentType>
              </xsl:if>
              <xsl:if test=""string($var:v48)='true'"">
                <xsl:variable name=""var:v65"" select=""s1:MasterCheckListName/text()"" />
                <DocumentTitle>
                  <xsl:value-of select=""$var:v65"" />
                </DocumentTitle>
              </xsl:if>
              <xsl:if test=""string($var:v48)='true'"">
                <xsl:variable name=""var:v66"" select=""s1:MasterCheckListDescription/text()"" />
                <DocumentDescription>
                  <xsl:value-of select=""$var:v66"" />
                </DocumentDescription>
              </xsl:if>
            </DocumentDetails>
          </xsl:if>
        </xsl:for-each>
      </DocumentList>
    </DOCUMENT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string ContactTypeValues(string APL_ORG_TYPE_CD)
{
  if (!string.IsNullOrEmpty(APL_ORG_TYPE_CD))
  {             
	if (APL_ORG_TYPE_CD == ""Individual_Sole_Prop"")
	{ return ""IND""; }

	else if (APL_ORG_TYPE_CD == ""Corporation"")
	{ return ""CP""; }
				
	else if (APL_ORG_TYPE_CD == ""Partnership"")
	{ return ""PS""; }

	else if (APL_ORG_TYPE_CD == ""Non-Profit"")
	{ return ""NO""; }

	else if (APL_ORG_TYPE_CD == ""Limited Partnership"")
	{ return ""LP""; }

	else if (APL_ORG_TYPE_CD == ""Trust"")
	{ return ""TRUST""; }

	else{ return """"; }
   }
	else{ return """"; }
}


    public string TypeValues(string TypeV)
    {
        if (!string.IsNullOrWhiteSpace(TypeV))

    {
            if (TypeV == ""Application Processing Documents"")
            { return ""PRE_PROCESSING_DOCS_HOME_ODA""; }

            else if (TypeV == ""Commitment Documents"")
            { return ""LP_DOCS_ODA""; }

            else if (TypeV == ""Closing Documents"")
            { return ""CLOSING_DOCS""; }

            else
            { return TypeV; }

        }
        else
        { return """"; }


    }

public string DOCTypeValues(string DocType)
    {
        if (!string.IsNullOrWhiteSpace(DocType))

        {
            if (DocType == ""4506T"")
            { return ""525""; }

            else if (DocType == ""Personal Financial Statement (413)"")
            { return ""544""; }

            else if (DocType == ""Schedule of Liabilities (2202)"")
            { return ""542""; }

            else
            { return ""Other""; }

        }
        else
        { return """"; }
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
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
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails";
        
        private const global::DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response _srcSchemaTypeReference1 = null;
        
        private const string _strSrcSchemasList2 = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response _srcSchemaTypeReference2 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsDefinition.EventDocumentListResponse";
        
        private const global::DLAPEventsDefinition.EventDocumentListResponse _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [3];
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.ChecklistItemDocumentDetails";
                _SrcSchemas[1] = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response";
                _SrcSchemas[2] = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsDefinition.EventDocumentListResponse";
                return _TrgSchemas;
            }
        }
    }
}
