namespace DLAPDocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.MultipleDocumentDetails", typeof(global::DocumentSalesforceListDefinition.MultipleDocumentDetails))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails", typeof(global::DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentListDefinition.DocumentListResponse", typeof(global::DocumentListDefinition.DocumentListResponse))]
    public sealed class MakeDocumentListResponse_Copy_2_ : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s5 s2 s3 s4 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentList/Checklist_Item__c"" xmlns:ns0=""http://SBA.gov/DLAPDocumentList/DocumentListResponse"" xmlns:s1=""http://SBA.gov/DLAP/DocumentListClosingDocument"" xmlns:s5=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s2=""http://SBA.gov/DLAPDocumentList/ContentVersion__c"" xmlns:s3=""http://SBA.gov/DLAP/DocumentList"" xmlns:s4=""http://SBA.gov/DLAPDocumentList/Application_Info__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s5:Root"" />
  </xsl:template>
  <xsl:template match=""/s5:Root"">
    <ns0:DOCUMENT>
      <AppData>
        <xsl:if test=""InputMessagePart_2/s4:Response/s4:row/s4:ApplicationName"">
          <App_Nbr>
            <xsl:value-of select=""InputMessagePart_2/s4:Response/s4:row/s4:ApplicationName/text()"" />
          </App_Nbr>
        </xsl:if>
        <xsl:if test=""InputMessagePart_2/s4:Response/s4:row/s4:ApplicationLoanType"">
          <Loan_Type>
            <xsl:value-of select=""InputMessagePart_2/s4:Response/s4:row/s4:ApplicationLoanType/text()"" />
          </Loan_Type>
        </xsl:if>
        <xsl:if test=""InputMessagePart_2/s4:Response/s4:row/s4:Disaster_Name"">
          <Disaster_Name>
            <xsl:value-of select=""InputMessagePart_2/s4:Response/s4:row/s4:Disaster_Name/text()"" />
          </Disaster_Name>
        </xsl:if>
        <xsl:element name=""Requested_Document_Count"">
<xsl:value-of select=""count(/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_3' and namespace-uri()='']/*[local-name()='Response' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c']/*[local-name()='row' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c'][*[local-name()='Checklist_Item_Status__c' and namespace-uri()='http://SBA.gov/DLAPDocumentList/Checklist_Item__c']/text() != 'Finalized'])"" />
        </xsl:element>
        <xsl:if test=""InputMessagePart_2/s4:Response/s4:row/s4:DisasterDeadlineDate"">
          <Disaster_Deadline_Date>
            <xsl:value-of select=""InputMessagePart_2/s4:Response/s4:row/s4:DisasterDeadlineDate/text()"" />
          </Disaster_Deadline_Date>
        </xsl:if>
      </AppData>
      <ApplicantList>
        <xsl:for-each select=""InputMessagePart_2/s4:Response/s4:row"">
          <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s4:ApplicantId))"" />
          <xsl:if test=""$var:v1"">
            <xsl:variable name=""var:v2"" select=""userCSharp:StringSize(string(s4:ContactOrganizationType/text()))"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalGt(string($var:v2) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v3))"" />
            <xsl:variable name=""var:v13"" select=""userCSharp:StringSize(string(s4:ApplicantTradeName/text()))"" />
            <xsl:variable name=""var:v14"" select=""userCSharp:LogicalGt(string($var:v13) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v16"" select=""userCSharp:LogicalNot(string($var:v14))"" />
            <xsl:variable name=""var:v18"" select=""string(s4:ApplicantTradeName/text())"" />
            <xsl:variable name=""var:v19"" select=""userCSharp:StringSize($var:v18)"" />
            <xsl:variable name=""var:v20"" select=""userCSharp:LogicalGt(string($var:v19) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v21"" select=""userCSharp:LogicalNot(string($var:v20))"" />
            <Applicants>
              <xsl:if test=""s4:ApplicantExternalID"">
                <ApplicantId>
                  <xsl:value-of select=""s4:ApplicantExternalID/text()"" />
                </ApplicantId>
              </xsl:if>
              <xsl:if test=""string($var:v3)='true'"">
                <xsl:variable name=""var:v4"" select=""s4:ContactOrganizationType/text()"" />
                <xsl:variable name=""var:v5"" select=""userCSharp:ContactTypeValues(string($var:v4))"" />
                <xsl:variable name=""var:v6"" select=""userCSharp:LogicalExistence(string($var:v5))"" />
                <xsl:if test=""string($var:v6)='true'"">
                  <xsl:variable name=""var:v7"" select=""string($var:v5)"" />
                  <APL_ORG_TYPE_CD>
                    <xsl:value-of select=""$var:v7"" />
                  </APL_ORG_TYPE_CD>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v9"" select=""s4:AccountBusinessType/text()"" />
                <xsl:variable name=""var:v10"" select=""userCSharp:BusinessTypeValues(string($var:v9))"" />
                <xsl:variable name=""var:v11"" select=""userCSharp:LogicalExistence(string($var:v10))"" />
                <xsl:if test=""string($var:v11)='true'"">
                  <xsl:variable name=""var:v12"" select=""string($var:v10)"" />
                  <APL_ORG_TYPE_CD>
                    <xsl:value-of select=""$var:v12"" />
                  </APL_ORG_TYPE_CD>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""string($var:v14)='true'"">
                <xsl:variable name=""var:v15"" select=""s4:ApplicantTradeName/text()"" />
                <LegalName>
                  <xsl:value-of select=""$var:v15"" />
                </LegalName>
              </xsl:if>
              <xsl:if test=""string($var:v16)='true'"">
                <xsl:variable name=""var:v17"" select=""s4:AccountName/text()"" />
                <LegalName>
                  <xsl:value-of select=""$var:v17"" />
                </LegalName>
              </xsl:if>
              <xsl:if test=""string($var:v21)='true'"">
                <xsl:variable name=""var:v22"" select=""s4:ContactFirstName/text()"" />
                <APL_FIRST_NAME>
                  <xsl:value-of select=""$var:v22"" />
                </APL_FIRST_NAME>
              </xsl:if>
              <xsl:if test=""string($var:v21)='true'"">
                <xsl:variable name=""var:v23"" select=""s4:ContactLastName/text()"" />
                <APL_LAST_NAME>
                  <xsl:value-of select=""$var:v23"" />
                </APL_LAST_NAME>
              </xsl:if>
              <xsl:variable name=""var:v24"" select=""userCSharp:RelationTypeValues(string(s4:ApplicantRelationType/text()))"" />
              <APL_RELATION_TYPE>
                <xsl:value-of select=""$var:v24"" />
              </APL_RELATION_TYPE>
            </Applicants>
          </xsl:if>
        </xsl:for-each>
      </ApplicantList>
      <DocumentList>
        <xsl:for-each select=""InputMessagePart_0/s3:DocumentList/s3:Responses"">
          <xsl:for-each select=""s2:Response"">
            <xsl:for-each select=""s2:row"">
              <xsl:variable name=""var:v25"" select=""userCSharp:LogicalExistence(boolean(s2:Id))"" />
              <xsl:variable name=""var:v26"" select=""boolean(s2:Id)"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:LogicalExistence($var:v26)"" />
              <xsl:variable name=""var:v30"" select=""userCSharp:LogicalEq(string(s2:Document_Validity__c/text()) , &quot;Invalid&quot;)"" />
              <xsl:variable name=""var:v31"" select=""userCSharp:LogicalNot(string($var:v30))"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:LogicalAnd(string($var:v27) , string($var:v31))"" />
              <xsl:variable name=""var:v34"" select=""userCSharp:LogicalAnd(string($var:v27) , string($var:v30))"" />
              <xsl:variable name=""var:v36"" select=""userCSharp:LogicalExistence(boolean(../../s3:ApplicantID))"" />
              <xsl:variable name=""var:v37"" select=""userCSharp:LogicalAnd(string($var:v27) , string($var:v36))"" />
              <xsl:variable name=""var:v41"" select=""string(s2:DLAP_Document_Type__c/text())"" />
              <xsl:variable name=""var:v42"" select=""string(s2:Title/text())"" />
              <DocumentDetails>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v28"" select=""&quot;NONE&quot;"" />
                  <ChecklistType>
                    <xsl:value-of select=""$var:v28"" />
                  </ChecklistType>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v29"" select=""&quot;0&quot;"" />
                  <ActionID>
                    <xsl:value-of select=""$var:v29"" />
                  </ActionID>
                </xsl:if>
                <xsl:if test=""string($var:v32)='true'"">
                  <xsl:variable name=""var:v33"" select=""&quot;RECEIVED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v33"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v34)='true'"">
                  <xsl:variable name=""var:v35"" select=""&quot;REJECTED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v35"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v37)='true'"">
                  <xsl:variable name=""var:v38"" select=""../../s3:ApplicantID/text()"" />
                  <ApplicantId>
                    <xsl:value-of select=""$var:v38"" />
                  </ApplicantId>
                </xsl:if>
                <xsl:if test=""s2:CreatedDate"">
                  <ReceiveDate>
                    <xsl:value-of select=""s2:CreatedDate/text()"" />
                  </ReceiveDate>
                </xsl:if>
                <xsl:if test=""s2:CreatedDate"">
                  <RequestDate>
                    <xsl:value-of select=""s2:CreatedDate/text()"" />
                  </RequestDate>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v39"" select=""s2:Id/text()"" />
                  <ScanDocumentID>
                    <xsl:value-of select=""$var:v39"" />
                  </ScanDocumentID>
                </xsl:if>
                <xsl:if test=""s2:DLAP_Document_Type__c"">
                  <DocumentType>
                    <xsl:value-of select=""s2:DLAP_Document_Type__c/text()"" />
                  </DocumentType>
                </xsl:if>
                <xsl:variable name=""var:v40"" select=""userCSharp:DocumnetTypeDesc(string(s2:DLAP_Document_Type__c/text()) , string(s2:Title/text()))"" />
                <DocumentTitle>
                  <xsl:value-of select=""$var:v40"" />
                </DocumentTitle>
                <xsl:variable name=""var:v43"" select=""userCSharp:DocumnetTypeDesc($var:v41 , $var:v42)"" />
                <DocumentDescription>
                  <xsl:value-of select=""$var:v43"" />
                </DocumentDescription>
              </DocumentDetails>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/s2:Response/s2:row"">
          <xsl:variable name=""var:v44"" select=""boolean(s2:Id)"" />
          <xsl:variable name=""var:v45"" select=""userCSharp:LogicalExistence($var:v44)"" />
          <xsl:variable name=""var:v48"" select=""string(s2:Document_Validity__c/text())"" />
          <xsl:variable name=""var:v49"" select=""userCSharp:LogicalEq($var:v48 , &quot;Invalid&quot;)"" />
          <xsl:variable name=""var:v50"" select=""userCSharp:LogicalNot(string($var:v49))"" />
          <xsl:variable name=""var:v51"" select=""userCSharp:LogicalAnd(string($var:v45) , string($var:v50))"" />
          <xsl:variable name=""var:v53"" select=""userCSharp:LogicalAnd(string($var:v45) , string($var:v49))"" />
          <xsl:variable name=""var:v56"" select=""string(s2:DLAP_Document_Type__c/text())"" />
          <xsl:variable name=""var:v57"" select=""string(s2:Title/text())"" />
          <DocumentDetails>
            <xsl:if test=""string($var:v45)='true'"">
              <xsl:variable name=""var:v46"" select=""&quot;NONE&quot;"" />
              <ChecklistType>
                <xsl:value-of select=""$var:v46"" />
              </ChecklistType>
            </xsl:if>
            <xsl:if test=""string($var:v45)='true'"">
              <xsl:variable name=""var:v47"" select=""&quot;0&quot;"" />
              <ActionID>
                <xsl:value-of select=""$var:v47"" />
              </ActionID>
            </xsl:if>
            <xsl:if test=""string($var:v51)='true'"">
              <xsl:variable name=""var:v52"" select=""&quot;RECEIVED&quot;"" />
              <Status>
                <xsl:value-of select=""$var:v52"" />
              </Status>
            </xsl:if>
            <xsl:if test=""string($var:v53)='true'"">
              <xsl:variable name=""var:v54"" select=""&quot;REJECTED&quot;"" />
              <Status>
                <xsl:value-of select=""$var:v54"" />
              </Status>
            </xsl:if>
            <xsl:if test=""s2:CreatedDate"">
              <ReceiveDate>
                <xsl:value-of select=""s2:CreatedDate/text()"" />
              </ReceiveDate>
            </xsl:if>
            <xsl:if test=""s2:CreatedDate"">
              <RequestDate>
                <xsl:value-of select=""s2:CreatedDate/text()"" />
              </RequestDate>
            </xsl:if>
            <xsl:if test=""string($var:v45)='true'"">
              <xsl:variable name=""var:v55"" select=""s2:Id/text()"" />
              <ScanDocumentID>
                <xsl:value-of select=""$var:v55"" />
              </ScanDocumentID>
            </xsl:if>
            <xsl:if test=""s2:DLAP_Document_Type__c"">
              <DocumentType>
                <xsl:value-of select=""s2:DLAP_Document_Type__c/text()"" />
              </DocumentType>
            </xsl:if>
            <xsl:variable name=""var:v58"" select=""userCSharp:DocumnetTypeDesc($var:v56 , $var:v57)"" />
            <DocumentTitle>
              <xsl:value-of select=""$var:v58"" />
            </DocumentTitle>
            <xsl:variable name=""var:v59"" select=""userCSharp:DocumnetTypeDesc($var:v56 , $var:v57)"" />
            <DocumentDescription>
              <xsl:value-of select=""$var:v59"" />
            </DocumentDescription>
          </DocumentDetails>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_3/s0:Response/s0:row"">
          <xsl:variable name=""var:v60"" select=""userCSharp:LogicalNe(string(s0:Checklist_Item_Status__c/text()) , &quot;Finalized&quot;)"" />
          <xsl:if test=""$var:v60"">
            <xsl:variable name=""var:v62"" select=""userCSharp:LogicalExistence(boolean(s0:Id))"" />
            <xsl:variable name=""var:v64"" select=""boolean(s0:Id)"" />
            <xsl:variable name=""var:v65"" select=""userCSharp:LogicalExistence($var:v64)"" />
            <xsl:variable name=""var:v67"" select=""userCSharp:LogicalExistence(boolean(s0:ApplicantExternalId))"" />
            <xsl:variable name=""var:v69"" select=""userCSharp:LogicalExistence(boolean(s0:Verified_Date__c))"" />
            <xsl:variable name=""var:v76"" select=""string(s0:Type__c/text())"" />
            <xsl:variable name=""var:v77"" select=""userCSharp:LogicalEq($var:v76 , &quot;Closing Documents&quot;)"" />
            <xsl:variable name=""var:v78"" select=""userCSharp:LogicalNot(string($var:v77))"" />
            <DocumentDetails>
              <xsl:variable name=""var:v61"" select=""userCSharp:TypeValues(string(s0:Type__c/text()))"" />
              <ChecklistType>
                <xsl:value-of select=""$var:v61"" />
              </ChecklistType>
              <xsl:if test=""string($var:v62)='true'"">
                <xsl:variable name=""var:v63"" select=""s0:Id/text()"" />
                <ActionID>
                  <xsl:value-of select=""$var:v63"" />
                </ActionID>
              </xsl:if>
              <xsl:if test=""string($var:v65)='true'"">
                <xsl:variable name=""var:v66"" select=""&quot;REQUESTED&quot;"" />
                <Status>
                  <xsl:value-of select=""$var:v66"" />
                </Status>
              </xsl:if>
              <xsl:if test=""string($var:v67)='true'"">
                <xsl:variable name=""var:v68"" select=""s0:ApplicantExternalId/text()"" />
                <ApplicantId>
                  <xsl:value-of select=""$var:v68"" />
                </ApplicantId>
              </xsl:if>
              <xsl:if test=""string($var:v69)='true'"">
                <xsl:variable name=""var:v70"" select=""s0:Verified_Date__c/text()"" />
                <ReceiveDate>
                  <xsl:value-of select=""$var:v70"" />
                </ReceiveDate>
              </xsl:if>
              <xsl:if test=""s0:CreatedDate"">
                <RequestDate>
                  <xsl:value-of select=""s0:CreatedDate/text()"" />
                </RequestDate>
              </xsl:if>
              <xsl:if test=""s0:Checklist_Item_Due_Date__c"">
                <DeadlineDate>
                  <xsl:value-of select=""s0:Checklist_Item_Due_Date__c/text()"" />
                </DeadlineDate>
              </xsl:if>
              <xsl:if test=""string($var:v65)='true'"">
                <xsl:variable name=""var:v71"" select=""&quot;0&quot;"" />
                <ScanDocumentID>
                  <xsl:value-of select=""$var:v71"" />
                </ScanDocumentID>
              </xsl:if>
              <xsl:variable name=""var:v72"" select=""userCSharp:DOCTypeValues(string(s0:DocumentType__c/text()))"" />
              <xsl:variable name=""var:v73"" select=""userCSharp:StringSize(string($var:v72))"" />
              <xsl:variable name=""var:v74"" select=""userCSharp:LogicalGt(string($var:v73) , &quot;2&quot;)"" />
              <xsl:if test=""string($var:v74)='true'"">
                <xsl:variable name=""var:v75"" select=""string($var:v72)"" />
                <DocumentType>
                  <xsl:value-of select=""$var:v75"" />
                </DocumentType>
              </xsl:if>
              <xsl:if test=""s0:MasterCheckListName"">
                <DocumentTitle>
                  <xsl:value-of select=""s0:MasterCheckListName/text()"" />
                </DocumentTitle>
              </xsl:if>
              <xsl:if test=""string($var:v78)='true'"">
                <xsl:variable name=""var:v79"" select=""s0:Checklist_Item_Text__c/text()"" />
                <DocumentDescription>
                  <xsl:value-of select=""$var:v79"" />
                </DocumentDescription>
              </xsl:if>
              <xsl:if test=""string($var:v77)='true'"">
                <xsl:variable name=""var:v80"" select=""&quot;Closing Documents Signature Required&quot;"" />
                <DocumentDescription>
                  <xsl:value-of select=""$var:v80"" />
                </DocumentDescription>
              </xsl:if>
            </DocumentDetails>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_4/s1:ChecklistItemDocumentList/s1:Responses"">
          <xsl:for-each select=""s2:Response"">
            <xsl:for-each select=""s2:row"">
              <xsl:variable name=""var:v81"" select=""boolean(s2:Id)"" />
              <xsl:variable name=""var:v82"" select=""userCSharp:LogicalExistence($var:v81)"" />
              <xsl:variable name=""var:v85"" select=""userCSharp:LogicalEq(string(../../s1:DocumentChecklist_Item_Status__c/text()) , &quot;Invalid&quot;)"" />
              <xsl:variable name=""var:v86"" select=""userCSharp:LogicalNot(string($var:v85))"" />
              <xsl:variable name=""var:v87"" select=""userCSharp:LogicalAnd(string($var:v82) , string($var:v86))"" />
              <xsl:variable name=""var:v89"" select=""userCSharp:LogicalAnd(string($var:v82) , string($var:v85))"" />
              <DocumentDetails>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v83"" select=""&quot;CLOSING_DOCS&quot;"" />
                  <ChecklistType>
                    <xsl:value-of select=""$var:v83"" />
                  </ChecklistType>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v84"" select=""&quot;0&quot;"" />
                  <ActionID>
                    <xsl:value-of select=""$var:v84"" />
                  </ActionID>
                </xsl:if>
                <xsl:if test=""string($var:v87)='true'"">
                  <xsl:variable name=""var:v88"" select=""&quot;RECEIVED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v88"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v89)='true'"">
                  <xsl:variable name=""var:v90"" select=""&quot;REJECTED&quot;"" />
                  <Status>
                    <xsl:value-of select=""$var:v90"" />
                  </Status>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v91"" select=""../../s1:ClosingDocumentApplicantId/text()"" />
                  <ApplicantId>
                    <xsl:value-of select=""$var:v91"" />
                  </ApplicantId>
                </xsl:if>
                <xsl:if test=""s2:CreatedDate"">
                  <ReceiveDate>
                    <xsl:value-of select=""s2:CreatedDate/text()"" />
                  </ReceiveDate>
                </xsl:if>
                <xsl:if test=""s2:CreatedDate"">
                  <RequestDate>
                    <xsl:value-of select=""s2:CreatedDate/text()"" />
                  </RequestDate>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v92"" select=""s2:Id/text()"" />
                  <ScanDocumentID>
                    <xsl:value-of select=""$var:v92"" />
                  </ScanDocumentID>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v93"" select=""&quot;99&quot;"" />
                  <DocumentType>
                    <xsl:value-of select=""$var:v93"" />
                  </DocumentType>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v94"" select=""../../s1:DocumentMasterCheckListName/text()"" />
                  <DocumentTitle>
                    <xsl:value-of select=""$var:v94"" />
                  </DocumentTitle>
                </xsl:if>
                <xsl:if test=""string($var:v82)='true'"">
                  <xsl:variable name=""var:v95"" select=""../../s1:DocumentMasterChecklist_Description__c/text()"" />
                  <DocumentDescription>
                    <xsl:value-of select=""$var:v95"" />
                  </DocumentDescription>
                </xsl:if>
              </DocumentDetails>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </DocumentList>
    </ns0:DOCUMENT>
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
	if (APL_ORG_TYPE_CD == ""Individual - Sole Prop"")
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

public string BusinessTypeValues(string APL_ORG_TYPE_CD)
{
  if (!string.IsNullOrEmpty(APL_ORG_TYPE_CD))
  {             
	if (APL_ORG_TYPE_CD == ""Individual - Sole Prop"")
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

public string RelationTypeValues(string Relationship_Type)
{
  if (!string.IsNullOrEmpty(Relationship_Type))
  {         
	if (Relationship_Type == ""Applicant"")
			{ return ""PRIM""; }

	else if (Relationship_Type == ""Owner"")
			{ return ""OWNER""; }
	
	else if (Relationship_Type == ""Spouse"")
			{ return ""SPOUSE""; }	

	else{ return ""OTHER_ODA""; }
   }
else{ return ""UNDEFINED""; }

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


public string DocumnetTypeDesc(string DLAP_Document_Type__c, string Title)
    {

        if (DLAP_Document_Type__c == ""1"")
        { return ""ORIGINAL LAA SIGNED BY THE BORROWER(S).""; }

        else if (DLAP_Document_Type__c == ""3"")
        { return ""CHECK DISPOSITIONS""; }

        else if (DLAP_Document_Type__c == ""4"")
        { return ""EXECUTED NOTE SIGNED BY THE BORROWER(S) WITH DISCLOSURE NOTICE""; }

        else if (DLAP_Document_Type__c == ""5"")
        { return ""RECORDED MORTGAGE(S) AND/OR DEED(S) OF TRUST""; }

        else if (DLAP_Document_Type__c == ""6"")
        { return ""EXECUTED SBA UNRECORDED MORTGAGE/DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""8"")
        { return ""UNRECORDED SBA SECURITY INSTRUMENTS""; }

        else if (DLAP_Document_Type__c == ""9"")
        { return ""EXECUTED SBA GUARANTEE(S)""; }

        else if (DLAP_Document_Type__c == ""10"")
        { return ""OTHER EXECUTED COLLATERAL DOCUMENT(S)""; }

        else if (DLAP_Document_Type__c == ""12"")
        { return ""TITLE REPORTS AND TITLE INSURANCE POLICIES""; }

        else if (DLAP_Document_Type__c == ""13"")
        { return ""TITLE, LIENS, AND JUDGMENT INFORMATION""; }

        else if (DLAP_Document_Type__c == ""15"")
        { return ""AGREEMENTS OF PRIOR LIENHOLDERS""; }

        else if (DLAP_Document_Type__c == ""16"")
        { return ""EVIDENCE OF THE PURCHASE OF NATIONAL FLOOD INSURANCE - OR EQUIVALENT""; }

        else if (DLAP_Document_Type__c == ""17"")
        { return ""EVIDENCE THAT SBA IS NAMED AS LOSS PAYEE OR MORTGAGEE""; }

        else if (DLAP_Document_Type__c == ""18"")
        { return ""EVIDENCE OF THE PURCHASE OF HAZARD OR OTHER INSURANCE""; }

        else if (DLAP_Document_Type__c == ""19"")
        { return ""ASSIGNMENT OF INSURANCE PROCEEDS""; }

        else if (DLAP_Document_Type__c == ""20"")
        { return ""INSURANCE DOCUMENTATION - OTHER""; }

        else if (DLAP_Document_Type__c == ""21"")
        { return ""CERTIFICATE OF GOOD STANDING""; }

        else if (DLAP_Document_Type__c == ""22"")
        { return ""LLC/LLP DOCUMENTS (OPERATING AGREEMENT, CERTIFICATE OF EXISTENCE)""; }

        else if (DLAP_Document_Type__c == ""23"")
        { return ""CORPORATION DOCUMENTS (ARTICLES, BY-LAWS, CHARTER, ETC.)""; }

        else if (DLAP_Document_Type__c == ""24"")
        { return ""PARTNERSHIP DOCUMENTS (AGREEMENT ETC)""; }

        else if (DLAP_Document_Type__c == ""25"")
        { return ""EXECUTED AGREEMENT OF COMPLIANCE""; }

        else if (DLAP_Document_Type__c == ""26"")
        { return ""EXECUTED LOBBYING CERTIFICATES""; }

        else if (DLAP_Document_Type__c == ""27"")
        { return ""COMPENSATION AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""28"")
        { return ""CONSTRUCTION CONTRACTS AND OTHER RELATED DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""29"")
        { return ""SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""31"")
        { return ""PMQDS OBTAINED AFTER APPROVAL""; }

        else if (DLAP_Document_Type__c == ""32"")
        { return ""BORROWERS PROGRESS AND/OR RECEIPTS""; }

        else if (DLAP_Document_Type__c == ""33"")
        { return ""EFT AND VOIDED CHECKS""; }

        else if (DLAP_Document_Type__c == ""34"")
        { return ""MISCELLANEOUS DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""35"")
        { return ""CHRONOLOGICAL RECORD""; }

        else if (DLAP_Document_Type__c == ""36"")
        { return ""CORRESPONDENCE GENERATED BY SBA""; }

        else if (DLAP_Document_Type__c == ""37"")
        { return ""CORRESPONDENCE TO SBA""; }

        else if (DLAP_Document_Type__c == ""38"")
        { return ""CREDIT REPORT(S)""; }

        else if (DLAP_Document_Type__c == ""39"")
        { return ""GENERAL CREDIT INFORMATION""; }

        else if (DLAP_Document_Type__c == ""41"")
        { return ""DEEDS AND LEGAL DESCRIPTIONS OF PROPERTY""; }

        else if (DLAP_Document_Type__c == ""42"")
        { return ""NON SBA LEASES, SUBLEASES, ASSIGNMENTS ETC""; }

        else if (DLAP_Document_Type__c == ""44"")
        { return ""NEMIS DOB""; }

        else if (DLAP_Document_Type__c == ""45"")
        { return ""GRANT PROGRAM INFORMATION""; }

        else if (DLAP_Document_Type__c == ""46"")
        { return ""INSURANCE CLAIM, SETTLEMENT AND RECOVERY DOCUMENTATION""; }

        else if (DLAP_Document_Type__c == ""48"")
        { return ""SBA FORM 912 AND RELATED DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""49"")
        { return ""LICENSES, BIRTH, MARRIAGE, DIVORCE AND DEATH CERTIFICATES, ETC.""; }

        else if (DLAP_Document_Type__c == ""50"")
        { return ""PROFIT AND LOSS STATEMENTS,  BALANCE SHEETS""; }

        else if (DLAP_Document_Type__c == ""51"")
        { return ""SCHEDULE OF LIABILITIES""; }

        else if (DLAP_Document_Type__c == ""52"")
        { return ""FORECASTS AND PROJECTIONS""; }

        else if (DLAP_Document_Type__c == ""53"")
        { return ""PERSONAL FINANCIAL STATEMENTS""; }

        else if (DLAP_Document_Type__c == ""54"")
        { return ""PAYSTUBS OR OTHER PROOF OF INCOME""; }

        else if (DLAP_Document_Type__c == ""55"")
        { return ""ACCOUNTS RECEIVABLE / PAYABLE AGING""; }

        else if (DLAP_Document_Type__c == ""56"")
        { return ""REQUEST FOR TRANSCRIPT OF TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""57"")
        { return ""OTHER IRS INFORMATION""; }

        else if (DLAP_Document_Type__c == ""58"")
        { return ""APPLICATION ATTACHMENT""; }

        else if (DLAP_Document_Type__c == ""59"")
        { return ""APPLICATION""; }

        else if (DLAP_Document_Type__c == ""60"")
        { return ""MISCELLANEOUS FINANCIAL DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""61"")
        { return ""RECORDS OF CONTACT / (1 CARD)""; }

        else if (DLAP_Document_Type__c == ""62"")
        { return ""SCREENING SHEET""; }

        else if (DLAP_Document_Type__c == ""63"")
        { return ""CONGRESSIONAL & SIMILARLY RELATED CORRESPONDENCE""; }

        else if (DLAP_Document_Type__c == ""64"")
        { return ""EXPERIENCE ON GOV LOANS""; }

        else if (DLAP_Document_Type__c == ""65"")
        { return ""DUN AND BRADSTREET REPORTS""; }

        else if (DLAP_Document_Type__c == ""66"")
        { return ""AMENDED/MODIFIED NOTE""; }

        else if (DLAP_Document_Type__c == ""67"")
        { return ""MECHANICS AND MATERIALMAN'S CONTRACT""; }

        else if (DLAP_Document_Type__c == ""68"")
        { return ""MECHANIC'S LIEN NOTE""; }

        else if (DLAP_Document_Type__c == ""69"")
        { return ""AMENDED/MODIFIED DEED OF TRUST/MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""70"")
        { return ""PREFERRED SHIP MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""71"")
        { return ""NOTICE OF DISQUALIFICATION""; }

        else if (DLAP_Document_Type__c == ""72"")
        { return ""RECORDED UCC-1 FINANCING STATEMENTS AND OTHER SECURITY INSTRUMENTS""; }

        else if (DLAP_Document_Type__c == ""73"")
        { return ""ASSIGNMENT OF LAND SALE CONTRACT""; }

        else if (DLAP_Document_Type__c == ""74"")
        { return ""ASSIGNMENT OF PROPRIETARY LEASE""; }

        else if (DLAP_Document_Type__c == ""75"")
        { return ""ORIGINAL STOCK CERTIFICATE (CO-OP)""; }

        else if (DLAP_Document_Type__c == ""76"")
        { return ""RECOGNITION AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""78"")
        { return ""IRS WORKOUT AGREEMENT, STATUS, DETALS, ETC.""; }

        else if (DLAP_Document_Type__c == ""79"")
        { return ""VERIFICATION OF REAL PROPERTY (FORM 739)""; }

        else if (DLAP_Document_Type__c == ""80"")
        { return ""VERIFICATION OF BUSINESS PROPERTY (FORM 739A)""; }

        else if (DLAP_Document_Type__c == ""81"")
        { return ""990 -TAX EXEMPT ORGANIZATION INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""82"")
        { return ""1040 - INDIVIDUAL INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""83"")
        { return ""1041 - ESTATES AND TRUST INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""84"")
        { return ""1120(S) - CORPORATE INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""85"")
        { return ""MISCELLANEOUS ELIGIBILITY AND OWNERSHIP DOCUMENTS (VEHICLE REGISTRATION, ETC)""; }

        else if (DLAP_Document_Type__c == ""86"")
        { return ""1065 - PARTNERSHIP INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""87"")
        { return ""OTHER INCOME TAX RETURN""; }

        else if (DLAP_Document_Type__c == ""88"")
        { return ""TAX TRANSCRIPT - 990 (TAX EXEMPT ORGANIZATION)""; }

        else if (DLAP_Document_Type__c == ""89"")
        { return ""TAX TRANSCRIPT - 1040 (INDIVIDUAL)""; }

        else if (DLAP_Document_Type__c == ""90"")
        { return ""TAX TRANSCRIPT - 1041 (ESTATE AND TRUST)""; }

        else if (DLAP_Document_Type__c == ""91"")
        { return ""TAX TRANSCRIPT - 1120(S) (CORPORATE)""; }

        else if (DLAP_Document_Type__c == ""92"")
        { return ""OTHER TAX INFORMATION""; }

        else if (DLAP_Document_Type__c == ""93"")
        { return ""TAX TRANSCRIPT - 1065  (PARTNERSHIP)""; }

        else if (DLAP_Document_Type__c == ""94"")
        { return ""LEGAL DOCS TO BE REVIEWED""; }

        else if (DLAP_Document_Type__c == ""95"")
        { return ""BANK STATEMENTS AND MISC FINANCIAL DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""96"")
        { return ""LOAN PROCESSING DOCS TO BE REVIEWED""; }

        else if (DLAP_Document_Type__c == ""97"")
        { return ""LOSS VERIFICATION DOCS TO BE REVIEWED""; }

        else if (DLAP_Document_Type__c == ""98"")
        { return ""CORRESPONDENCE TO BE REVIEWED""; }

        else if (DLAP_Document_Type__c == ""99"")
        { return ""AMENDED SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""101"")
        { return ""FEDERAL REGISTER NOTIFICATION""; }

        else if (DLAP_Document_Type__c == ""102"")
        { return ""DAMAGE ASSESSMENT REPORT""; }

        else if (DLAP_Document_Type__c == ""103"")
        { return ""SBA FORM 605 (SIGNED AND CLEARED)""; }

        else if (DLAP_Document_Type__c == ""104"")
        { return ""FEDERAL REGISTER NOTIFICATION AMENDMENT""; }

        else if (DLAP_Document_Type__c == ""105"")
        { return ""FEMA PRESIDENTIAL DECLARATION""; }

        else if (DLAP_Document_Type__c == ""108"")
        { return ""SECAG DECLARATION MEMO""; }

        else if (DLAP_Document_Type__c == ""109"")
        { return ""SECAG DECLARATION AMENDMENT MEMO""; }

        else if (DLAP_Document_Type__c == ""110"")
        { return ""DISASTER DECLARATION MAP""; }

        else if (DLAP_Document_Type__c == ""112"")
        { return ""SUPPORTING DOCUMENTS (DISASTER/DECLARATION)""; }

        else if (DLAP_Document_Type__c == ""113"")
        { return ""DECLARATION RECOMMENDATION MEMO""; }

        else if (DLAP_Document_Type__c == ""114"")
        { return ""DECLARATION REQUEST LETTER""; }

        else if (DLAP_Document_Type__c == ""115"")
        { return ""DECLARATION REQUEST DECLINE LETTER""; }

        else if (DLAP_Document_Type__c == ""117"")
        { return ""OTHER DISASTER RELATED DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""118"")
        { return ""DISASTER CLOSEOUT REPORT""; }

        else if (DLAP_Document_Type__c == ""210"")
        { return ""CONDO, HOMEOWNERS OR OTHER COOPERATIVE ASSOCIATION INFORMATION""; }

        else if (DLAP_Document_Type__c == ""211"")
        { return ""CERTIFICATE OF ENTITIES (RES OF BOARD, CERT OF LIMITED LIABILITY ENTITES)""; }

        else if (DLAP_Document_Type__c == ""212"")
        { return ""PROBATE DOCUMENTS (JUDGMENT OF POSSESSION, ETC)""; }

        else if (DLAP_Document_Type__c == ""213"")
        { return ""POWER OF ATTORNEY""; }

        else if (DLAP_Document_Type__c == ""214"")
        { return ""APPRAISALS, ASSESSMENTS, ETC""; }

        else if (DLAP_Document_Type__c == ""215"")
        { return ""JUDGMENT AND LIEN INFORMATION""; }

        else if (DLAP_Document_Type__c == ""216"")
        { return ""BUILDING PERMIT""; }

        else if (DLAP_Document_Type__c == ""217"")
        { return ""BUILDERS RISK AND WORKMAN'S COMP INSURANCE""; }

        else if (DLAP_Document_Type__c == ""218"")
        { return ""LANDLORDS WAIVER""; }

        else if (DLAP_Document_Type__c == ""219"")
        { return ""NON EXECUTED SBA DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""220"")
        { return ""DOCUMENTS RELATED TO PROPERTY PURCHASE (HUD 1, PURCHASE AGREEMENT, ETC)""; }

        else if (DLAP_Document_Type__c == ""221"")
        { return ""MISCELLANEOUS INSURANCE DOCUMENTS""; }

        else if (DLAP_Document_Type__c == ""222"")
        { return ""DDR LETTER""; }

        else if (DLAP_Document_Type__c == ""223"")
        { return ""IN-TRUST LETTER""; }

        else if (DLAP_Document_Type__c == ""224"")
        { return ""ACTION LETTER""; }

        else if (DLAP_Document_Type__c == ""225"")
        { return ""EDP LETTER""; }

        else if (DLAP_Document_Type__c == ""226"")
        { return ""LOAN MODIFICATION LETTER""; }

        else if (DLAP_Document_Type__c == ""227"")
        { return ""LV PI REVIEW""; }

        else if (DLAP_Document_Type__c == ""228"")
        { return ""SPECIAL ASSESSMENT""; }

        else if (DLAP_Document_Type__c == ""229"")
        { return ""ASSESSMENT RESOLUTION - MEMBERSHIP VOTE (CS-20)""; }

        else if (DLAP_Document_Type__c == ""230"")
        { return ""AMENDED LAA""; }

        else if (DLAP_Document_Type__c == ""231"")
        { return ""SBA ASSIGNMENT OF LEASE""; }

        else if (DLAP_Document_Type__c == ""300"")
        { return ""NON-EXECUTED: NOTE""; }

        else if (DLAP_Document_Type__c == ""301"")
        { return ""NON-EXECUTED: LOAN AUTHORIZATION AND AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""302"")
        { return ""NON-EXECUTED: ASSIGNMENT OF INSURANCE PROCEEDS""; }

        else if (DLAP_Document_Type__c == ""303"")
        { return ""NON-EXECUTED: GUARANTEE(S)""; }

        else if (DLAP_Document_Type__c == ""304"")
        { return ""NON-EXECUTED: SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""305"")
        { return ""NON-EXECUTED: CERTIFICATION OF HAZARD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""306"")
        { return ""NON-EXECUTED: AGREEMENT OF COMPLIANCE""; }

        else if (DLAP_Document_Type__c == ""307"")
        { return ""NON-EXECUTED: BORROWERS PROGRESS""; }

        else if (DLAP_Document_Type__c == ""308"")
        { return ""NON-EXECUTED: RESOLUTION OF BOARD OF DIRECTORS""; }

        else if (DLAP_Document_Type__c == ""309"")
        { return ""NON-EXECUTED: ELECTRONIC FUNDS TRANSFER (EFT)""; }

        else if (DLAP_Document_Type__c == ""310"")
        { return ""NON-EXECUTED: LANDLORDS WAIVER""; }

        else if (DLAP_Document_Type__c == ""311"")
        { return ""NON-EXECUTED: MECHANICS LIEN NOTE (TX)""; }

        else if (DLAP_Document_Type__c == ""312"")
        { return ""NON-EXECUTED: CERTIFICATE REGARDING LOBBYING""; }

        else if (DLAP_Document_Type__c == ""313"")
        { return ""NON-EXECUTED: COMPENSATION AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""314"")
        { return ""NON-EXECUTED: AFFIDAVIT OF BORROWER AND CONTRACTOR (TX)""; }

        else if (DLAP_Document_Type__c == ""315"")
        { return ""NON-EXECUTED: CERTIFICATE AS TO MEMBERS""; }

        else if (DLAP_Document_Type__c == ""316"")
        { return ""NON-EXECUTED: CERTIFICATE AS TO PARTNERS""; }

        else if (DLAP_Document_Type__c == ""317"")
        { return ""NON-EXECUTED: CERTIFICATION OF BUILDING PERMIT""; }

        else if (DLAP_Document_Type__c == ""318"")
        { return ""NON-EXECUTED: CERTIFICATION OF FLOOD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""319"")
        { return ""NON-EXECUTED: NOTICE OF RIGHT TO CANCEL""; }

        else if (DLAP_Document_Type__c == ""320"")
        { return ""NON-EXECUTED: LAA SIGNATURE ACKNOWLEDGEMENT""; }

        else if (DLAP_Document_Type__c == ""321"")
        { return ""NON-EXECUTED: STANDBY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""322"")
        { return ""NON-EXECUTED: CERTIFICATE AS TO MANAGERS""; }

        else if (DLAP_Document_Type__c == ""323"")
        { return ""NON-EXECUTED: TRUTH IN LENDING ACT OF DISCLOSURE""; }

        else if (DLAP_Document_Type__c == ""324"")
        { return ""NON-EXECUTED: HAPPY LETTER""; }

        else if (DLAP_Document_Type__c == ""325"")
        { return ""NON-EXECUTED: ASSUMPTION OF MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""326"")
        { return ""NON-EXECUTED: OIG CERTIFICATION""; }

        else if (DLAP_Document_Type__c == ""327"")
        { return ""NON-EXECUTED: MECHANIC'S AND MATERIALMAN'S LIEN CONTRACT""; }

        else if (DLAP_Document_Type__c == ""328"")
        { return ""NON-EXECUTED: AFFIDAVIT OF BORROWER AND CONTRACTOR""; }

        else if (DLAP_Document_Type__c == ""329"")
        { return ""NON-EXECUTED: UCC""; }

        else if (DLAP_Document_Type__c == ""330"")
        { return ""NON-EXECUTED: AGREEMENT OF PRIOR LIENHOLDER""; }

        else if (DLAP_Document_Type__c == ""331"")
        { return ""NON-EXECUTED: CERTIFICATION OF HULL INSURANCE""; }

        else if (DLAP_Document_Type__c == ""332"")
        { return ""NON-EXECUTED: CERTIFICATION OF HAZARD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""333"")
        { return ""NON-EXECUTED: MULTIPLE INDEBTEDNESS MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""334"")
        { return ""NON-EXECUTED: WAIVER OF ELIGIBILITY""; }

        else if (DLAP_Document_Type__c == ""335"")
        { return ""NON-EXECUTED: MORTGAGE/TAX/CONVEYANCE CERTIFICATE""; }

        else if (DLAP_Document_Type__c == ""336"")
        { return ""NON-EXECUTED: TITLE REPORT SHEET""; }

        else if (DLAP_Document_Type__c == ""337"")
        { return ""NON-EXECUTED: TITLE POLICY SHEET""; }

        else if (DLAP_Document_Type__c == ""338"")
        { return ""NON-EXECUTED: ASSIGNMENT OF LIEN""; }

        else if (DLAP_Document_Type__c == ""339"")
        { return ""NON-EXECUTED: RELEASE OF LIEN""; }

        else if (DLAP_Document_Type__c == ""340"")
        { return ""NON-EXECUTED: ASSIGNMENT OF LAND SALES CONTRACT""; }

        else if (DLAP_Document_Type__c == ""341"")
        { return ""NON-EXECUTED: ASSIGNMENT OF LEASE""; }

        else if (DLAP_Document_Type__c == ""342"")
        { return ""NON-EXECUTED: PREFERRED SHIP MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""343"")
        { return ""NON-EXECUTED: COLLATERAL SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""344"")
        { return ""NON-EXECUTED: HOME OWNER ASSOCIATION (HOA)""; }

        else if (DLAP_Document_Type__c == ""345"")
        { return ""NON-EXECUTED: SPECIAL ASSESSMENT""; }

        else if (DLAP_Document_Type__c == ""346"")
        { return ""NON-EXECUTED: ASSIGNMENT OF LEASEHOLD IMPROVEMENTS""; }

        else if (DLAP_Document_Type__c == ""348"")
        { return ""NON-EXECUTED: MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""349"")
        { return ""NON-EXECUTED: DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""350"")
        { return ""NON-EXECUTED: TRUST INDENTURE""; }

        else if (DLAP_Document_Type__c == ""351"")
        { return ""NON-EXECUTED: LOAN CLOSING INSTRUCTION LETTER""; }

        else if (DLAP_Document_Type__c == ""352"")
        { return ""NON-EXECUTED: AMENDED LOAN AUTHORIZATION AND AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""353"")
        { return ""NON-EXECUTED: MODIFICATION OF NOTE""; }

        else if (DLAP_Document_Type__c == ""354"")
        { return ""NON-EXECUTED: LOBBYING CERTIFICATE""; }

        else if (DLAP_Document_Type__c == ""355"")
        { return ""NON-EXECUTED: AMENDED SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""356"")
        { return ""NON-EXECUTED: AMENDED GUARANTEE""; }

        else if (DLAP_Document_Type__c == ""357"")
        { return ""NON-EXECUTED: REQUEST FOR NOTICE""; }

        else if (DLAP_Document_Type__c == ""358"")
        { return ""NON-EXECUTED: REQUEST FOR NOTICE OF SALE""; }

        else if (DLAP_Document_Type__c == ""359"")
        { return ""NON-EXECUTED: MODIFIED DEED OF TRUST/MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""360"")
        { return ""NON-EXECUTED: STATEMENT OF ADDITIONAL ADVANCE""; }

        else if (DLAP_Document_Type__c == ""361"")
        { return ""NON-EXECUTED: ACT OF CORRECTION""; }

        else if (DLAP_Document_Type__c == ""362"")
        { return ""NON-EXECUTED: SUBORDINATION AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""363"")
        { return ""NON-EXECUTED: CANCELLATION (LA)""; }

        else if (DLAP_Document_Type__c == ""364"")
        { return ""NON-EXECUTED: ASSIGNMENT OF PROPRIETY LEASE (CO-OP)""; }

        else if (DLAP_Document_Type__c == ""365"")
        { return ""NON-EXECUTED: STOCK POWER (CO-OP)""; }

        else if (DLAP_Document_Type__c == ""366"")
        { return ""NON-EXECUTED: RECOGNITION AGREEMENT (CO-OP)""; }

        else if (DLAP_Document_Type__c == ""367"")
        { return ""NON-EXECUTED: NOTICE OF DISQUALIFICATION""; }

        else if (DLAP_Document_Type__c == ""368"")
        { return ""NON-EXECUTED: EFT""; }

        else if (DLAP_Document_Type__c == ""369"")
        { return ""NON-EXECUTED:  CERTIFICATE OF LIMITED LIABILITY""; }

        else if (DLAP_Document_Type__c == ""370"")
        { return ""NON-EXECUTED:  ASSIGNMENT OF PENDING LAWSUIT""; }

        else if (DLAP_Document_Type__c == ""371"")
        { return ""NON-EXECUTED:  AUTHORIZATION TO DISBURSE IHP FUNDS DIRECTLY TO FEMA""; }

        else if (DLAP_Document_Type__c == ""399"")
        { return ""NON-EXECUTED: MISCELLANEOUS DOCUMENT""; }

        else if (DLAP_Document_Type__c == ""500"")
        { return ""NOTE SIGNED BY BORROWER""; }

        else if (DLAP_Document_Type__c == ""501"")
        { return ""LOAN AUTHORIZATION AND AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""502"")
        { return ""ASSIGNMENT OF INSURANCE PROCEEDS""; }

        else if (DLAP_Document_Type__c == ""503"")
        { return ""GUARANTEE(S)""; }

        else if (DLAP_Document_Type__c == ""504"")
        { return ""SECURITY AGREEMENT, BARCODE""; }

        else if (DLAP_Document_Type__c == ""505"")
        { return ""CERTIFICATION OF HAZARD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""506"")
        { return ""AGREEMENT OF COMPLIANCE""; }

        else if (DLAP_Document_Type__c == ""507"")
        { return ""BORROWERS PROGRESS""; }

        else if (DLAP_Document_Type__c == ""508"")
        { return ""RESOLUTION OF BOARD OF DIRECTORS""; }

        else if (DLAP_Document_Type__c == ""509"")
        { return ""EFT""; }

        else if (DLAP_Document_Type__c == ""510"")
        { return ""LANDLORDS WAIVER""; }

        else if (DLAP_Document_Type__c == ""511"")
        { return ""MECHANICS LIEN NOTE (TX)""; }

        else if (DLAP_Document_Type__c == ""512"")
        { return ""CERTIFICATE REGARDING LOBBYING""; }

        else if (DLAP_Document_Type__c == ""513"")
        { return ""COMPENSATION AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""514"")
        { return ""AFFIDAVIT OF BORROWER AND CONTRACTOR (TX)""; }

        else if (DLAP_Document_Type__c == ""515"")
        { return ""CERTIFICATE AS TO MEMBERS""; }

        else if (DLAP_Document_Type__c == ""516"")
        { return ""CERTIFICATE AS TO PARTNERS""; }

        else if (DLAP_Document_Type__c == ""517"")
        { return ""CERTIFICATION OF BUILDING PERMIT""; }

        else if (DLAP_Document_Type__c == ""518"")
        { return ""CERTIFICATION OF FLOOD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""519"")
        { return ""NOTICE OF RIGHT TO CANCEL""; }

        else if (DLAP_Document_Type__c == ""520"")
        { return ""LA&A SIGNATURE ACKNOWLEDGEMENT""; }

        else if (DLAP_Document_Type__c == ""521"")
        { return ""STANDBY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""522"")
        { return ""CERTIFICATE AS TO MANAGERS""; }

        else if (DLAP_Document_Type__c == ""523"")
        { return ""TRUTH IN LENDING ACT OF DISCLOSURE""; }

        else if (DLAP_Document_Type__c == ""524"")
        { return ""APPROVAL LETTER""; }

        else if (DLAP_Document_Type__c == ""525"")
        { return ""REQUEST FOR TRANSCRIPT OF TAX RETURN (DLAP)""; }

        else if (DLAP_Document_Type__c == ""526"")
        { return ""ASSIGNMENT OF SPECIAL ASSESSMENT""; }

        else if (DLAP_Document_Type__c == ""527"")
        { return ""HOA/CONDO ASSIGNMENT OF INSURANCE (OC-18)""; }

        else if (DLAP_Document_Type__c == ""528"")
        { return ""ATTORNEY'S OPINION FROM HOA ATTORNEY CS-20""; }

        else if (DLAP_Document_Type__c == ""529"")
        { return ""MISTAKEN IDENTITY AFFIDAVIT""; }

        else if (DLAP_Document_Type__c == ""530"")
        { return ""VET CONSENT TO ENCUMBER (CA, OR) CS-06""; }

        else if (DLAP_Document_Type__c == ""531"")
        { return ""COLLATERAL SECURITY AGREEMENT CS-17""; }

        else if (DLAP_Document_Type__c == ""532"")
        { return ""AMENDED COLLATERAL SECURITY AGREEMENT CS-17""; }

        else if (DLAP_Document_Type__c == ""533"")
        { return ""PAYROLL DEDUCTION""; }

        else if (DLAP_Document_Type__c == ""534"")
        { return ""CAL VET LOSS PAYEE ENDORSEMENT (CA) CS-06""; }

        else if (DLAP_Document_Type__c == ""535"")
        { return ""AFFIDAVIT AS TO POA BEING IN FULL FORCE""; }

        else if (DLAP_Document_Type__c == ""536"")
        { return ""ASSIGNMENT OF LIFE INSURANCE""; }

        else if (DLAP_Document_Type__c == ""537"")
        { return ""ASSIGNMENT OF PROCEEDS FROM CLAIM FOR DAMAGES""; }

        else if (DLAP_Document_Type__c == ""538"")
        { return ""STOCK POWER CS-15,16""; }

        else if (DLAP_Document_Type__c == ""539"")
        { return ""SAME NAME AFFIDAVIT""; }

        else if (DLAP_Document_Type__c == ""540"")
        { return ""ELA P&L STATEMENT""; }

        else if (DLAP_Document_Type__c == ""541"")
        { return ""ELA BALANCE SHEET""; }

        else if (DLAP_Document_Type__c == ""542"")
        { return ""ELA SCHEDULE OF LIABILITIES (2202)""; }

        else if (DLAP_Document_Type__c == ""543"")
        { return ""ELA MONTHLY FIGURES (1368)""; }

        else if (DLAP_Document_Type__c == ""544"")
        { return ""ELA PERSONAL FINANCIAL STATEMENT (413)""; }

        else if (DLAP_Document_Type__c == ""545"")
        { return ""EFT AUTH AND ACCOUNT INFO""; }

        else if (DLAP_Document_Type__c == ""546"")
        { return ""ELA BUSINESS APPLICATION SBA FORM 5""; }

        else if (DLAP_Document_Type__c == ""547"")
        { return ""ELA HOME APPLICATION SBA FORM 5C""; }

        else if (DLAP_Document_Type__c == ""548"")
        { return ""CERTIFICATE OF LIMITED LIABILITY""; }

        else if (DLAP_Document_Type__c == ""549"")
        { return ""AUTHORIZATION TO DISBURSE IHP FUNDS DIRECTLY TO FEMA""; }

        else if (DLAP_Document_Type__c == ""550"")
        { return ""ASSIGNMENT OF PENDING LAWSUIT""; }

        else if (DLAP_Document_Type__c == ""600"")
        { return ""DAMAGE PHOTO""; }

        else if (DLAP_Document_Type__c == ""601"")
        { return ""PROPERTY SKETCH""; }

        else if (DLAP_Document_Type__c == ""700"")
        { return ""ALTERED NOTE""; }

        else if (DLAP_Document_Type__c == ""701"")
        { return ""ALTERED MOD NOTE""; }

        else if (DLAP_Document_Type__c == ""702"")
        { return ""ALTERED LAA""; }

        else if (DLAP_Document_Type__c == ""703"")
        { return ""ALTERED AMENDED LAA""; }

        else if (DLAP_Document_Type__c == ""704"")
        { return ""ALTERED MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""705"")
        { return ""ALTERED AMENDED MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""706"")
        { return ""ALTERED DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""707"")
        { return ""ALTERED AMENDED DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""708"")
        { return ""ALTERED ACT OF CORRECTIONS""; }

        else if (DLAP_Document_Type__c == ""709"")
        { return ""ALTERED TILA""; }

        else if (DLAP_Document_Type__c == ""710"")
        { return ""ALTERED UCC""; }

        else if (DLAP_Document_Type__c == ""711"")
        { return ""ALTERED SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""712"")
        { return ""ALTERED AMENDED SECURITY AGREEMENT""; }

        else if (DLAP_Document_Type__c == ""713"")
        { return ""ALTERED GUARANTEE""; }

        else if (DLAP_Document_Type__c == ""714"")
        { return ""ALTERED AMENDED GUARANTEE""; }

        else if (DLAP_Document_Type__c == ""715"")
        { return ""ALTERED RELEASE OF MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""716"")
        { return ""ALTERED PARTIAL RELEASE OF MORTGAGE""; }

        else if (DLAP_Document_Type__c == ""717"")
        { return ""ALTERED TITLE REPORT""; }

        else if (DLAP_Document_Type__c == ""718"")
        { return ""ALTERED TITLE POLICY""; }

        else if (DLAP_Document_Type__c == ""719"")
        { return ""ALTERED REQUEST FOR NOTICE OF SEIZURE""; }

        else if (DLAP_Document_Type__c == ""720"")
        { return ""ALTERED REQUEST FOR NOTICE OF DISQUALIFICATION""; }

        else if (DLAP_Document_Type__c == ""721"")
        { return ""ALTERED FLOOD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""722"")
        { return ""ALTERED HAZARD INSURANCE""; }

        else if (DLAP_Document_Type__c == ""723"")
        { return ""ALTERED AIP""; }

        else if (DLAP_Document_Type__c == ""724"")
        { return ""ALTERED STATEMENT OF ADDITIONAL ADVANCE (MORTGAGE)""; }

        else if (DLAP_Document_Type__c == ""725"")
        { return ""ALTERED STATEMENT OF ADDITIONAL ADVANCE (DEED OF TRUST)""; }

        else if (DLAP_Document_Type__c == ""726"")
        { return ""ALTERED SUBORDINATION AGREEMENT (IN FAVOR OF SBA)""; }

        else if (DLAP_Document_Type__c == ""727"")
        { return ""ALTERED SUBORDINATION AGREEMENT (SBA SUBORDINATING)""; }

        else if (DLAP_Document_Type__c == ""728"")
        { return ""ALTERED FULL RECONVEYANCE OF DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""729"")
        { return ""ALTERED PARTIAL RECONVEYANCE OF DEED OF TRUST""; }

        else if (DLAP_Document_Type__c == ""283"")
        { return ""Federal Tax Return (FTR)""; }

        else
        { return Title; }

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


public bool LogicalOr(string param0, string param1, string param2, string param3)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2) || ValToBool(param3);
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
        
        private const string _strSrcSchemasList0 = @"DocumentSalesforceListDefinition.MultipleDocumentDetails";
        
        private const global::DocumentSalesforceListDefinition.MultipleDocumentDetails _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c.Response _srcSchemaTypeReference1 = null;
        
        private const string _strSrcSchemasList2 = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response _srcSchemaTypeReference2 = null;
        
        private const string _strSrcSchemasList3 = @"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response _srcSchemaTypeReference3 = null;
        
        private const string _strSrcSchemasList4 = @"DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails";
        
        private const global::DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails _srcSchemaTypeReference4 = null;
        
        private const string _strTrgSchemasList0 = @"DocumentListDefinition.DocumentListResponse";
        
        private const global::DocumentListDefinition.DocumentListResponse _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [5];
                _SrcSchemas[0] = @"DocumentSalesforceListDefinition.MultipleDocumentDetails";
                _SrcSchemas[1] = @"DocumentSalesforceListDefinition.SalesforceQuery_ContentVersion__c+Response";
                _SrcSchemas[2] = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
                _SrcSchemas[3] = @"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response";
                _SrcSchemas[4] = @"DLAPDocumentListSalesforceDefinition.ChecklistItemDocumentDetails";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DocumentListDefinition.DocumentListResponse";
                return _TrgSchemas;
            }
        }
    }
}
