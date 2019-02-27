namespace Application_Import_Logic.Application__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup.table))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceApplication__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplication__c.parameters))]
    public sealed class MakeSalesForceApplication__cMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2 userCSharp"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://sba-oda/DLAP/DisasterLookup"" xmlns:s1=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Application__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_SBALOAN_IND/text()) , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v3"" select=""string(InputMessagePart_0/s1:Application/Final_Questions/FQS_SBALOAN_IND/text())"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;N&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_912_IND/text()) , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v8"" select=""string(InputMessagePart_0/s1:Application/Final_Questions/FQS_912_IND/text())"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;N&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_DEBAR_IND/text()) , &quot;N&quot;)"" />
    <xsl:variable name=""var:v13"" select=""string(InputMessagePart_0/s1:Application/Final_Questions/FQS_DEBAR_IND/text())"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:LogicalEq($var:v13 , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_ADDRESS1/text()))"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_ADDRESS2/text()))"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_CITY/text()))"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_STATE_CD/text()))"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_ZIP/text()))"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringTrimRight(string(InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_COUNTY/text()))"" />
    <xsl:variable name=""var:v22"" select=""userCSharp:StringConcat(string($var:v16) , &quot;&quot; , string($var:v17) , &quot; &quot; , string($var:v18) , &quot; &quot; , string($var:v19) , &quot; &quot; , string($var:v20) , &quot; &quot; , string($var:v21))"" />
    <xsl:variable name=""var:v23"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/APP_DPO_EXTFAM_IND/text()) , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v25"" select=""string(InputMessagePart_0/s1:Application/APP_DPO_EXTFAM_IND/text())"" />
    <xsl:variable name=""var:v26"" select=""userCSharp:LogicalEq($var:v25 , &quot;N&quot;)"" />
    <xsl:variable name=""var:v29"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/PaperApplication/text()) , &quot;true&quot;)"" />
    <xsl:variable name=""var:v31"" select=""string(InputMessagePart_0/s1:Application/PaperApplication/text())"" />
    <xsl:variable name=""var:v32"" select=""userCSharp:LogicalEq($var:v31 , &quot;false&quot;)"" />
    <xsl:variable name=""var:v34"" select=""string(InputMessagePart_0/s1:Application/APP_BUS_EIDL/text())"" />
    <xsl:variable name=""var:v36"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_AGREE_IND/text()) , &quot;true&quot;)"" />
    <xsl:variable name=""var:v37"" select=""userCSharp:DateCurrentDate()"" />
    <xsl:variable name=""var:v39"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_EMP_IND/text()) , &quot;N&quot;)"" />
    <xsl:variable name=""var:v41"" select=""string(InputMessagePart_0/s1:Application/Final_Questions/FQS_EMP_IND/text())"" />
    <xsl:variable name=""var:v42"" select=""userCSharp:LogicalEq($var:v41 , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v44"" select=""InputMessagePart_0/s1:Application/ApplicantColl/Applicants/APL_DATE_ESTD/text()"" />
    <xsl:variable name=""var:v45"" select=""userCSharp:StringSize(string($var:v44))"" />
    <xsl:variable name=""var:v46"" select=""userCSharp:LogicalGt(string($var:v45) , &quot;3&quot;)"" />
    <xsl:variable name=""var:v48"" select=""userCSharp:StringSize(string(InputMessagePart_0/s1:Application/APP_SUMMARY_DECLINE_CODE/text()))"" />
    <xsl:variable name=""var:v49"" select=""userCSharp:LogicalGt(string($var:v48) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v50"" select=""string(InputMessagePart_0/s1:Application/APP_SUMMARY_DECLINE_CODE/text())"" />
    <xsl:variable name=""var:v51"" select=""userCSharp:LogicalNe($var:v50 , &quot;PASS&quot;)"" />
    <xsl:variable name=""var:v52"" select=""userCSharp:LogicalAnd(string($var:v49) , string($var:v51))"" />
    <xsl:variable name=""var:v54"" select=""userCSharp:StringConcat(&quot;9030&quot;)"" />
    <xsl:variable name=""var:v55"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s1:Application/Final_Questions/FQS_FELONY_IND/text()) , &quot;Y&quot;)"" />
    <xsl:variable name=""var:v57"" select=""string(InputMessagePart_0/s1:Application/Final_Questions/FQS_FELONY_IND/text())"" />
    <xsl:variable name=""var:v58"" select=""userCSharp:LogicalEq($var:v57 , &quot;N&quot;)"" />
    <ns0:parameters>
      <ns0:sync>
        <ns0:after>
          <ns0:Application__c>
            <xsl:attribute name=""Name"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_ELA_REFERENCE_NBR/text()"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v1)='true'"">
              <xsl:variable name=""var:v2"" select=""&quot;Y&quot;"" />
              <xsl:attribute name=""Previous_SBA_Loans__c"">
                <xsl:value-of select=""$var:v2"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""&quot;N&quot;"" />
              <xsl:attribute name=""Previous_SBA_Loans__c"">
                <xsl:value-of select=""$var:v5"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:attribute name=""SBA_Office_Location__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_SBA_LOCATION/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""SBA_Account_Number__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_SBA_ACC_NBR/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Previous_Federal_Loans__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FEDLOAN_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Federal_Agency_Name__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FED_AGENCY_NAME/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Federal_Agency_Location__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FED_LOCATION/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Federal_Loan_Account_Number__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FED_ACC_NBR/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Delinquencies__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FEDDEL_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Agency_Name_Delinquent__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_DEL_AGENCY_NAME/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Agency_Location_Deliquent__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_DEL_LOCATION/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Account_Number_Delinquent__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_DEL_ACC_NBR/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Bankruptcy__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_BKRPY_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Bankruptcy_Details__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_BKRPY_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Previous_Judgments_Lawsuits__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_JDGMT_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Judgments_Lawsuits_Details__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_JDGMT_COMMENTS/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Previous_Felonies__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FELONY_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Previous_Felonies_Details__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_FELONY_DETAILS/text()"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v6)='true'"">
              <xsl:variable name=""var:v7"" select=""&quot;Yes&quot;"" />
              <xsl:attribute name=""Previous_Convictions__c"">
                <xsl:value-of select=""$var:v7"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v9)='true'"">
              <xsl:variable name=""var:v10"" select=""&quot;No&quot;"" />
              <xsl:attribute name=""Previous_Convictions__c"">
                <xsl:value-of select=""$var:v10"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:attribute name=""Previous_Convictions_Details__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_912_DTLS/text()"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v11)='true'"">
              <xsl:variable name=""var:v12"" select=""&quot;No&quot;"" />
              <xsl:attribute name=""Suspended_Debarred__c"">
                <xsl:value-of select=""$var:v12"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v14)='true'"">
              <xsl:variable name=""var:v15"" select=""&quot;Yes&quot;"" />
              <xsl:attribute name=""Suspended_Debarred__c"">
                <xsl:value-of select=""$var:v15"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:attribute name=""Suspended_Debarred_Details__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_DEBAR_DESC/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Mitigation_Disclosure__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_DISCUSS_MIT_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Legal_Representative_Name__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_LR_NAME/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Legal_Representative_Company__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_LR_COMPANY/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Legal_Representative_Company_Phone__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_LR_PHONE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Legal_Representative_Company_Address_Typ__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/MailingAddress/MAR_ADDR_TYPE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""LR_Company_Mailing_Address__c"">
              <xsl:value-of select=""$var:v22"" />
            </xsl:attribute>
            <xsl:attribute name=""Legal_Representative_Fee__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/Final_Questions/FQS_LR_FEE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Original_Create_Date__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_CREATE_DATE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Original_Submission_Date__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_SUBMIT_DATE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""FEMA_Registration_Number__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_FEMA_REGIS_NBR/text()"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v23)='true'"">
              <xsl:variable name=""var:v24"" select=""&quot;true&quot;"" />
              <xsl:attribute name=""Extended_Family_Indicator__c"">
                <xsl:value-of select=""$var:v24"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v26)='true'"">
              <xsl:variable name=""var:v27"" select=""&quot;false&quot;"" />
              <xsl:attribute name=""Extended_Family_Indicator__c"">
                <xsl:value-of select=""$var:v27"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:variable name=""v201"" select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='ApplicantColl' and namespace-uri()='']/*[local-name()='Applicants' and namespace-uri()=''][*[local-name()='ApplicantType' and namespace-uri()=''][text() = 'Primary']]/*[local-name()='APL_FAMILY_SIZE' and namespace-uri()='']/text()"" />
            <xsl:if test=""$v201"">
<xsl:attribute name=""Family_Size__c"">
<xsl:value-of select=""$v201"" />
</xsl:attribute>
</xsl:if>
            <xsl:attribute name=""Disaster_Declaration__c"">
              <xsl:value-of select=""InputMessagePart_1/s0:table/s0:row/s0:Id/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""External_Id__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_ID/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Decline_Reason_Code__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_SUMMARY_DECLINE_CODE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Loan_Type__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_PRD_PRODUCT/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Applicant_Consent__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_CONSENT_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Applicant_Acknowledgment__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_ACKNOWLEDGE_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Applicant_Certification__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_CERTIFY_IND/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""App_Processing_Contact__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_CONTACT_NAME/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""App_Processing_Contact_Phone__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_CONTACT_NBR/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Loss_Verification_Contact__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_INSP_NAME/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Loss_Verification_Contact_Phone__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/APP_INSP_NBR/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Est_Loss_Equipment__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/EST_LOSS_EQUIP/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Est_Loss_Inventory__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/EST_LOSS_INV/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Est_Loss_Real_Estate__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/EST_LOSS_RE/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Est_Loss_Improvements__c"">
              <xsl:value-of select=""InputMessagePart_0/s1:Application/EST_LOSS_IMPROVE/text()"" />
            </xsl:attribute>
            <xsl:variable name=""var:v28"" select=""userCSharp:RecordType(string(InputMessagePart_0/s1:Application/APP_PRD_PRODUCT/text()) , string(InputMessagePart_0/s1:Application/APP_BUS_EIDL/text()) , string(InputMessagePart_0/s1:Application/Record_SF_Business_Loan_Application/text()) , string(InputMessagePart_0/s1:Application/Record_SF_EIDL_Application/text()) , string(InputMessagePart_0/s1:Application/Record_SF_Home_Loan_Application/text()) , string(InputMessagePart_0/s1:Application/Record_SF_New_Read_Only_Application/text()))"" />
            <xsl:attribute name=""RecordTypeId"">
              <xsl:value-of select=""$var:v28"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v29)='true'"">
              <xsl:variable name=""var:v30"" select=""&quot;false&quot;"" />
              <xsl:attribute name=""ELA_Application__c"">
                <xsl:value-of select=""$var:v30"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v32)='true'"">
              <xsl:variable name=""var:v33"" select=""&quot;true&quot;"" />
              <xsl:attribute name=""ELA_Application__c"">
                <xsl:value-of select=""$var:v33"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:variable name=""var:v35"" select=""userCSharp:LossType(string(InputMessagePart_0/s1:Application/APP_BUS_RE/text()) , string(InputMessagePart_0/s1:Application/APP_BUS_CONT/text()) , $var:v34 , string(InputMessagePart_0/s1:Application/APP_BUS_MREIDL/text()))"" />
            <xsl:attribute name=""Loss_Type__c"">
              <xsl:value-of select=""$var:v35"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v36)='true'"">
              <xsl:variable name=""var:v38"" select=""string($var:v37)"" />
              <xsl:attribute name=""Agree_to_Terms__c"">
                <xsl:value-of select=""$var:v38"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:variable name=""v101"" select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='ApplicantColl' and namespace-uri()='']/*[local-name()='Applicants' and namespace-uri()=''][*[local-name()='ApplicantType' and namespace-uri()=''][text() = 'Primary']]/*[local-name()='APL_ORG_TYPE_CD' and namespace-uri()='']/text()"" />
            <xsl:if test=""$v101"">
<xsl:variable name=""v102"" select=""userCSharp:EntityTypeValues(string($v101))"" />
<xsl:attribute name=""Org_Type__c"">
<xsl:value-of select=""$v102"" />
</xsl:attribute>
</xsl:if>
            <xsl:if test=""string($var:v39)='true'"">
              <xsl:variable name=""var:v40"" select=""&quot;No&quot;"" />
              <xsl:attribute name=""SBA_Employee_Ind__c"">
                <xsl:value-of select=""$var:v40"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v42)='true'"">
              <xsl:variable name=""var:v43"" select=""&quot;Yes&quot;"" />
              <xsl:attribute name=""SBA_Employee_Ind__c"">
                <xsl:value-of select=""$var:v43"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v46)='true'"">
              <xsl:variable name=""var:v47"" select=""string($var:v44)"" />
              <xsl:attribute name=""Date_Business_Established__c"">
                <xsl:value-of select=""$var:v47"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v52)='true'"">
              <xsl:variable name=""var:v53"" select=""&quot;true&quot;"" />
              <xsl:attribute name=""Is_Summary_Declined__c"">
                <xsl:value-of select=""$var:v53"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:attribute name=""Servicing_Office__c"">
              <xsl:value-of select=""$var:v54"" />
            </xsl:attribute>
            <xsl:if test=""string($var:v55)='true'"">
              <xsl:variable name=""var:v56"" select=""&quot;Y&quot;"" />
              <xsl:attribute name=""Riot_Civil_Disorder_Other__c"">
                <xsl:value-of select=""$var:v56"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v58)='true'"">
              <xsl:variable name=""var:v59"" select=""&quot;N&quot;"" />
              <xsl:attribute name=""Riot_Civil_Disorder_Other__c"">
                <xsl:value-of select=""$var:v59"" />
              </xsl:attribute>
            </xsl:if>
          </ns0:Application__c>
        </ns0:after>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;
}


public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
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

public string RecordType(string APP_PRD_PRODUCT, string APP_BUS_EIDL, string Record_SF_Business_Loan_Application, string Record_SF_EIDL_Application, string Record_SF_Home_Loan_Application, string Record_SF_New_Read_Only_Application)
        {          

                if (APP_PRD_PRODUCT== ""Home"")
                { return Record_SF_Home_Loan_Application; }

                else
                { return Record_SF_Business_Loan_Application; }
            }




public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public string LossType(string APP_BUS_RE, string APP_BUS_CONT,string APP_BUS_EIDL,string APP_BUS_MREIDL)
{ 
    if ((APP_BUS_RE == ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Real Property;Business Contents;Business EIDL;Military Reservist EIDL"";	 
	 return LossValue; }              
				
    else if((APP_BUS_RE == ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL != ""true"")) 
    { string LossValue = ""Real Property;Business Contents;Business EIDL"";	 
	 return LossValue; } 
	 
	else if((APP_BUS_RE == ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL != ""true"")) 
    { string LossValue = ""Real Property;Business Contents"";	 
	 return LossValue; } 
	 
	else if((APP_BUS_RE == ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL != ""true"")) 
    { string LossValue = ""Real Property"";	 
	 return LossValue; } 
	 
	else if((APP_BUS_RE != ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL != ""true"")) 
	{ string LossValue = ""Business Contents"";	 
	 return LossValue; }   
	 
	else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL != ""true""))
     { string LossValue = ""Business EIDL"";	 
	 return LossValue; } 

   	else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Military Reservist EIDL"";	 
	 return LossValue; }

    else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Business Contents;Business EIDL;Military Reservist EIDL"";	 
	 return LossValue; }	

    else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Business EIDL;Military Reservist EIDL"";	 
	 return LossValue; }		 
	 
	else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL != ""true""))
     { string LossValue = ""Business Contents;Business EIDL"";	 
	 return LossValue; }	
	 
	else if ((APP_BUS_RE == ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Real Property;Business EIDL;Military Reservist EIDL"";	 
	 return LossValue; }	
	 
	else if ((APP_BUS_RE == ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Real Property;Military Reservist EIDL"";	 
	 return LossValue; }

    else if ((APP_BUS_RE == ""true"")&&(APP_BUS_CONT != ""true"")&&(APP_BUS_EIDL == ""true"")&&(APP_BUS_MREIDL != ""true""))
     { string LossValue = ""Real Property;Business EIDL"";	 
	 return LossValue; } 	

    else if ((APP_BUS_RE != ""true"")&&(APP_BUS_CONT == ""true"")&&(APP_BUS_EIDL != ""true"")&&(APP_BUS_MREIDL == ""true""))
     { string LossValue = ""Business Contents;Military Reservist EIDL"";	 
	 return LossValue; } 	 
	 
	else
    { return """"; }
	 
	 
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string StringConcat(string param0)
{
   return param0;
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
        
        private const string _strSrcSchemasList1 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup.table _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplication__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplication__c.parameters _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                _SrcSchemas[1] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplication__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
