namespace Application_Import_Logic.Account {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+table", typeof(global::Salesforce_Application_Import_Definition.Account.CDataServiceAccount.table))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    public sealed class MakeCanonicalWithAccountSalesForceIDs : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 userCSharp"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:s0=""http://sba-oda/DLAP/Account"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:Application>
      <VERSION>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/VERSION/text()"" />
      </VERSION>
      <APP_ID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_ID/text()"" />
      </APP_ID>
      <APP_ELA_REFERENCE_NBR>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_ELA_REFERENCE_NBR/text()"" />
      </APP_ELA_REFERENCE_NBR>
      <SalesForceAccountID>
        <xsl:text />
      </SalesForceAccountID>
      <SalesForceApplication__cID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/SalesForceApplication__cID/text()"" />
      </SalesForceApplication__cID>
      <OrchestrationID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/OrchestrationID/text()"" />
      </OrchestrationID>
      <SFEvent_ID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/SFEvent_ID/text()"" />
      </SFEvent_ID>
      <APP_CREATE_DATE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_CREATE_DATE/text()"" />
      </APP_CREATE_DATE>
      <APP_SUBMIT_DATE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_SUBMIT_DATE/text()"" />
      </APP_SUBMIT_DATE>
      <APP_PRD_PRODUCT>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_PRD_PRODUCT/text()"" />
      </APP_PRD_PRODUCT>
      <APP_DPO_OWN_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DPO_OWN_IND/text()"" />
      </APP_DPO_OWN_IND>
      <APP_DPO_PRIMARY_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DPO_PRIMARY_IND/text()"" />
      </APP_DPO_PRIMARY_IND>
      <APP_DPO_SECONDARY_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DPO_SECONDARY_IND/text()"" />
      </APP_DPO_SECONDARY_IND>
      <APP_DPO_RENTAL_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DPO_RENTAL_IND/text()"" />
      </APP_DPO_RENTAL_IND>
      <APP_DPO_EXTFAM_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DPO_EXTFAM_IND/text()"" />
      </APP_DPO_EXTFAM_IND>
      <APP_BUS_RE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_BUS_RE/text()"" />
      </APP_BUS_RE>
      <APP_BUS_CONT>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_BUS_CONT/text()"" />
      </APP_BUS_CONT>
      <APP_BUS_EIDL>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_BUS_EIDL/text()"" />
      </APP_BUS_EIDL>
      <APP_BUS_MREIDL>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_BUS_MREIDL/text()"" />
      </APP_BUS_MREIDL>
      <APP_PRO_ID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_PRO_ID/text()"" />
      </APP_PRO_ID>
      <APP_DMG_STATE_CD>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DMG_STATE_CD/text()"" />
      </APP_DMG_STATE_CD>
      <APP_DMG_COUNTY>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_DMG_COUNTY/text()"" />
      </APP_DMG_COUNTY>
      <APP_FEMA_REGIS_NBR>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_FEMA_REGIS_NBR/text()"" />
      </APP_FEMA_REGIS_NBR>
      <FemaReferralTrackingId>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/FemaReferralTrackingId/text()"" />
      </FemaReferralTrackingId>
      <PrepopulatedWithFemaData>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/PrepopulatedWithFemaData/text()"" />
      </PrepopulatedWithFemaData>
      <APP_CONSENT_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_CONSENT_IND/text()"" />
      </APP_CONSENT_IND>
      <APP_ACKNOWLEDGE_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_ACKNOWLEDGE_IND/text()"" />
      </APP_ACKNOWLEDGE_IND>
      <APP_CERTIFY_IND>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_CERTIFY_IND/text()"" />
      </APP_CERTIFY_IND>
      <LateFilingJustification>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/LateFilingJustification/text()"" />
      </LateFilingJustification>
      <APP_CONTACT_NAME>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_CONTACT_NAME/text()"" />
      </APP_CONTACT_NAME>
      <APP_CONTACT_NBR>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_CONTACT_NBR/text()"" />
      </APP_CONTACT_NBR>
      <APP_INSP_NAME>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_INSP_NAME/text()"" />
      </APP_INSP_NAME>
      <APP_INSP_NBR>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_INSP_NBR/text()"" />
      </APP_INSP_NBR>
      <APP_SUMMARY_DECLINE_CODE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/APP_SUMMARY_DECLINE_CODE/text()"" />
      </APP_SUMMARY_DECLINE_CODE>
      <EST_LOSS_RE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/EST_LOSS_RE/text()"" />
      </EST_LOSS_RE>
      <EST_LOSS_INV>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/EST_LOSS_INV/text()"" />
      </EST_LOSS_INV>
      <EST_LOSS_EQUIP>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/EST_LOSS_EQUIP/text()"" />
      </EST_LOSS_EQUIP>
      <EST_LOSS_IMPROVE>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/EST_LOSS_IMPROVE/text()"" />
      </EST_LOSS_IMPROVE>
      <NoIndividualOwner>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/NoIndividualOwner/text()"" />
      </NoIndividualOwner>
      <NoEntityOwner>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/NoEntityOwner/text()"" />
      </NoEntityOwner>
      <PackageId>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/PackageId/text()"" />
      </PackageId>
      <ApplicantColl>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/ApplicantColl"">
          <xsl:for-each select=""Applicants"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(../../APP_PRD_PRODUCT/text()) , &quot;Business&quot;)"" />
            <xsl:variable name=""var:v3"" select=""position()"" />
            <xsl:variable name=""var:v4"" select=""../Applicants[number($var:v3)]/APL_ORG_TYPE_CD/text()"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq(string($var:v4) , &quot;IND&quot;)"" />
            <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNot(string($var:v5))"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v6))"" />
            <xsl:variable name=""var:v8"" select=""string(../../APP_PRD_PRODUCT/text())"" />
            <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;Home&quot;)"" />
            <Applicants>
              <SalesForceContactID>
                <xsl:value-of select=""$var:v1"" />
              </SalesForceContactID>
              <AppId>
                <xsl:value-of select=""AppId/text()"" />
              </AppId>
              <ApplicantId>
                <xsl:value-of select=""ApplicantId/text()"" />
              </ApplicantId>
              <SalesForceApplicantID>
                <xsl:value-of select=""$var:v1"" />
              </SalesForceApplicantID>
              <ApplicantType>
                <xsl:value-of select=""ApplicantType/text()"" />
              </ApplicantType>
              <APL_FIRST_NAME>
                <xsl:value-of select=""APL_FIRST_NAME/text()"" />
              </APL_FIRST_NAME>
              <APL_MIDDLE_NAME>
                <xsl:value-of select=""APL_MIDDLE_NAME/text()"" />
              </APL_MIDDLE_NAME>
              <APL_LAST_NAME>
                <xsl:value-of select=""APL_LAST_NAME/text()"" />
              </APL_LAST_NAME>
              <APL_SUFFIX>
                <xsl:value-of select=""APL_SUFFIX/text()"" />
              </APL_SUFFIX>
              <APL_SSN>
                <xsl:value-of select=""APL_SSN/text()"" />
              </APL_SSN>
              <APL_DOB>
                <xsl:value-of select=""APL_DOB/text()"" />
              </APL_DOB>
              <APL_BIRTH_PLACE>
                <xsl:value-of select=""APL_BIRTH_PLACE/text()"" />
              </APL_BIRTH_PLACE>
              <APL_MARITAL_STATUS>
                <xsl:value-of select=""APL_MARITAL_STATUS/text()"" />
              </APL_MARITAL_STATUS>
              <APL_RELATION_TYPE>
                <xsl:value-of select=""APL_RELATION_TYPE/text()"" />
              </APL_RELATION_TYPE>
              <APL_RELATION_OTHER>
                <xsl:value-of select=""APL_RELATION_OTHER/text()"" />
              </APL_RELATION_OTHER>
              <APL_FAMILY_SIZE>
                <xsl:value-of select=""APL_FAMILY_SIZE/text()"" />
              </APL_FAMILY_SIZE>
              <APL_SBA_EMPLOYEE>
                <xsl:value-of select=""APL_SBA_EMPLOYEE/text()"" />
              </APL_SBA_EMPLOYEE>
              <APL_SELF_EMPLOYED>
                <xsl:value-of select=""APL_SELF_EMPLOYED/text()"" />
              </APL_SELF_EMPLOYED>
              <MailingAddress>
                <MAR_ADDR_TYPE>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_TYPE/text()"" />
                </MAR_ADDR_TYPE>
                <MAR_ADDR_OTHER_DESC>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
                </MAR_ADDR_OTHER_DESC>
                <MAR_ADDRESS1>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS1/text()"" />
                </MAR_ADDRESS1>
                <MAR_ADDRESS2>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS2/text()"" />
                </MAR_ADDRESS2>
                <MAR_CITY>
                  <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                </MAR_CITY>
                <MAR_STATE_CD>
                  <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                </MAR_STATE_CD>
                <MAR_ZIP>
                  <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                </MAR_ZIP>
                <MAR_COUNTY>
                  <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                </MAR_COUNTY>
                <xsl:value-of select=""MailingAddress/text()"" />
              </MailingAddress>
              <APL_CONTACT_METHOD>
                <xsl:value-of select=""APL_CONTACT_METHOD/text()"" />
              </APL_CONTACT_METHOD>
              <APL_PRIM_PHONE>
                <xsl:value-of select=""APL_PRIM_PHONE/text()"" />
              </APL_PRIM_PHONE>
              <APL_WORK_PHONE>
                <xsl:value-of select=""APL_WORK_PHONE/text()"" />
              </APL_WORK_PHONE>
              <APL_ALT_PHONE>
                <xsl:value-of select=""APL_ALT_PHONE/text()"" />
              </APL_ALT_PHONE>
              <APL_FAX>
                <xsl:value-of select=""APL_FAX/text()"" />
              </APL_FAX>
              <APL_EMAIL>
                <xsl:value-of select=""APL_EMAIL/text()"" />
              </APL_EMAIL>
              <APL_OTHER_CONTACT>
                <xsl:value-of select=""APL_OTHER_CONTACT/text()"" />
              </APL_OTHER_CONTACT>
              <APL_REL_NAME>
                <xsl:value-of select=""APL_REL_NAME/text()"" />
              </APL_REL_NAME>
              <APL_REL_PHONE>
                <xsl:value-of select=""APL_REL_PHONE/text()"" />
              </APL_REL_PHONE>
              <APL_ORG_TYPE_CD>
                <xsl:value-of select=""APL_ORG_TYPE_CD/text()"" />
              </APL_ORG_TYPE_CD>
              <APL_LEGAL_NAME>
                <xsl:value-of select=""APL_LEGAL_NAME/text()"" />
              </APL_LEGAL_NAME>
              <APL_EIN_NBR>
                <xsl:value-of select=""APL_EIN_NBR/text()"" />
              </APL_EIN_NBR>
              <APL_BUS_TRADE_NAME>
                <xsl:value-of select=""APL_BUS_TRADE_NAME/text()"" />
              </APL_BUS_TRADE_NAME>
              <APL_BUS_ACTIVITY>
                <xsl:value-of select=""APL_BUS_ACTIVITY/text()"" />
              </APL_BUS_ACTIVITY>
              <APL_NO_EMPL>
                <xsl:value-of select=""APL_NO_EMPL/text()"" />
              </APL_NO_EMPL>
              <APL_DATE_ESTD>
                <xsl:value-of select=""APL_DATE_ESTD/text()"" />
              </APL_DATE_ESTD>
              <APL_DATE_CURR_MGMT>
                <xsl:value-of select=""APL_DATE_CURR_MGMT/text()"" />
              </APL_DATE_CURR_MGMT>
              <APL_TITLEOFFICE>
                <xsl:value-of select=""APL_TITLEOFFICE/text()"" />
              </APL_TITLEOFFICE>
              <APL_PER_OWNERSHIP>
                <xsl:value-of select=""APL_PER_OWNERSHIP/text()"" />
              </APL_PER_OWNERSHIP>
              <APL_CITIZEN_IND>
                <xsl:value-of select=""APL_CITIZEN_IND/text()"" />
              </APL_CITIZEN_IND>
              <NotEmployed>
                <xsl:value-of select=""NotEmployed/text()"" />
              </NotEmployed>
              <AplWageColl>
                <xsl:for-each select=""AplWageColl"">
                  <xsl:for-each select=""Apl_Wages"">
                    <Apl_Wages>
                      <ApplicantId>
                        <xsl:value-of select=""ApplicantId/text()"" />
                      </ApplicantId>
                      <WageId>
                        <xsl:value-of select=""WageId/text()"" />
                      </WageId>
                      <APW_EMPL_NAME>
                        <xsl:value-of select=""APW_EMPL_NAME/text()"" />
                      </APW_EMPL_NAME>
                      <MailingAddress>
                        <MAR_ADDR_TYPE>
                          <xsl:value-of select=""MailingAddress/MAR_ADDR_TYPE/text()"" />
                        </MAR_ADDR_TYPE>
                        <MAR_ADDR_OTHER_DESC>
                          <xsl:value-of select=""MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
                        </MAR_ADDR_OTHER_DESC>
                        <MAR_ADDRESS1>
                          <xsl:value-of select=""MailingAddress/MAR_ADDRESS1/text()"" />
                        </MAR_ADDRESS1>
                        <MAR_ADDRESS2>
                          <xsl:value-of select=""MailingAddress/MAR_ADDRESS2/text()"" />
                        </MAR_ADDRESS2>
                        <MAR_CITY>
                          <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                        </MAR_CITY>
                        <MAR_STATE_CD>
                          <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                        </MAR_STATE_CD>
                        <MAR_ZIP>
                          <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                        </MAR_ZIP>
                        <MAR_COUNTY>
                          <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                        </MAR_COUNTY>
                        <xsl:value-of select=""MailingAddress/text()"" />
                      </MailingAddress>
                      <APW_EMPL_YRS>
                        <xsl:value-of select=""APW_EMPL_YRS/text()"" />
                      </APW_EMPL_YRS>
                      <APW_EMPL_MNTHS>
                        <xsl:value-of select=""APW_EMPL_MNTHS/text()"" />
                      </APW_EMPL_MNTHS>
                      <APW_GROSS_INC_AMT>
                        <xsl:value-of select=""APW_GROSS_INC_AMT/text()"" />
                      </APW_GROSS_INC_AMT>
                      <APW_GROSS_INC_FREQ>
                        <xsl:value-of select=""APW_GROSS_INC_FREQ/text()"" />
                      </APW_GROSS_INC_FREQ>
                      <APW_OCCUPATION>
                        <xsl:value-of select=""APW_OCCUPATION/text()"" />
                      </APW_OCCUPATION>
                      <APW_SELF_WAGE>
                        <xsl:value-of select=""APW_SELF_WAGE/text()"" />
                      </APW_SELF_WAGE>
                    </Apl_Wages>
                  </xsl:for-each>
                </xsl:for-each>
              </AplWageColl>
              <NoOtherIncome>
                <xsl:value-of select=""NoOtherIncome/text()"" />
              </NoOtherIncome>
              <AplOtherIncomeColl>
                <xsl:for-each select=""AplOtherIncomeColl"">
                  <xsl:for-each select=""Apl_Other_Income"">
                    <Apl_Other_Income>
                      <ApplicantId>
                        <xsl:value-of select=""ApplicantId/text()"" />
                      </ApplicantId>
                      <OtherIncomeId>
                        <xsl:value-of select=""OtherIncomeId/text()"" />
                      </OtherIncomeId>
                      <API_INCOME_SOURCE>
                        <xsl:value-of select=""API_INCOME_SOURCE/text()"" />
                      </API_INCOME_SOURCE>
                      <API_INCOME_AMOUNT>
                        <xsl:value-of select=""API_INCOME_AMOUNT/text()"" />
                      </API_INCOME_AMOUNT>
                      <API_INCOME_FREQ>
                        <xsl:value-of select=""API_INCOME_FREQ/text()"" />
                      </API_INCOME_FREQ>
                    </Apl_Other_Income>
                  </xsl:for-each>
                </xsl:for-each>
              </AplOtherIncomeColl>
              <APL_AFFILIATE_IND>
                <xsl:value-of select=""APL_AFFILIATE_IND/text()"" />
              </APL_AFFILIATE_IND>
              <AplAffiliateColl>
                <xsl:value-of select=""AplAffiliateColl/text()"" />
              </AplAffiliateColl>
              <TaxTranscriptRequest>
                <PreviousAddress>
                  <MAR_ADDR_TYPE>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_ADDR_TYPE/text()"" />
                  </MAR_ADDR_TYPE>
                  <MAR_ADDR_OTHER_DESC>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_ADDR_OTHER_DESC/text()"" />
                  </MAR_ADDR_OTHER_DESC>
                  <MAR_ADDRESS1>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_ADDRESS1/text()"" />
                  </MAR_ADDRESS1>
                  <MAR_ADDRESS2>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_ADDRESS2/text()"" />
                  </MAR_ADDRESS2>
                  <MAR_CITY>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_CITY/text()"" />
                  </MAR_CITY>
                  <MAR_STATE_CD>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_STATE_CD/text()"" />
                  </MAR_STATE_CD>
                  <MAR_ZIP>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_ZIP/text()"" />
                  </MAR_ZIP>
                  <MAR_COUNTY>
                    <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/MAR_COUNTY/text()"" />
                  </MAR_COUNTY>
                  <xsl:value-of select=""TaxTranscriptRequest/PreviousAddress/text()"" />
                </PreviousAddress>
                <TaxForm>
                  <xsl:value-of select=""TaxTranscriptRequest/TaxForm/text()"" />
                </TaxForm>
                <EndOfFiscalYear>
                  <xsl:copy-of select=""TaxTranscriptRequest/EndOfFiscalYear/@*"" />
                  <xsl:copy-of select=""TaxTranscriptRequest/EndOfFiscalYear/*"" />
                </EndOfFiscalYear>
                <SignerTitle>
                  <xsl:value-of select=""TaxTranscriptRequest/SignerTitle/text()"" />
                </SignerTitle>
                <Attestation>
                  <xsl:value-of select=""TaxTranscriptRequest/Attestation/text()"" />
                </Attestation>
                <IncludeSpouse>
                  <xsl:value-of select=""TaxTranscriptRequest/IncludeSpouse/text()"" />
                </IncludeSpouse>
                <SwitchedEntityOrder>
                  <xsl:value-of select=""TaxTranscriptRequest/SwitchedEntityOrder/text()"" />
                </SwitchedEntityOrder>
                <DataEntryRequired>
                  <xsl:value-of select=""TaxTranscriptRequest/DataEntryRequired/text()"" />
                </DataEntryRequired>
                <DownloadRequired>
                  <xsl:value-of select=""TaxTranscriptRequest/DownloadRequired/text()"" />
                </DownloadRequired>
                <FileUploaded>
                  <xsl:value-of select=""TaxTranscriptRequest/FileUploaded/text()"" />
                </FileUploaded>
                <SubmitOffline>
                  <xsl:value-of select=""TaxTranscriptRequest/SubmitOffline/text()"" />
                </SubmitOffline>
                <SignatureRequired>
                  <xsl:value-of select=""TaxTranscriptRequest/SignatureRequired/text()"" />
                </SignatureRequired>
                <FileName>
                  <xsl:value-of select=""TaxTranscriptRequest/FileName/text()"" />
                </FileName>
              </TaxTranscriptRequest>
              <xsl:variable name=""var:v10"" select=""userCSharp:AccountIndexV(string($var:v7) , string($var:v9))"" />
              <xsl:call-template name=""PopulateAccountSalesForceID"">
                <xsl:with-param name=""SalesForceResponseRow2"" select=""string($var:v10)"" />
              </xsl:call-template>
            </Applicants>
          </xsl:for-each>
        </xsl:for-each>
      </ApplicantColl>
      <DmgPropertyColl>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/DmgPropertyColl"">
          <xsl:for-each select=""Dmg_Properties"">
            <xsl:variable name=""var:v11"" select=""position()"" />
            <Dmg_Properties>
              <AppId>
                <xsl:value-of select=""AppId/text()"" />
              </AppId>
              <DmgPropertyId>
                <xsl:value-of select=""DmgPropertyId/text()"" />
              </DmgPropertyId>
              <MailingAddress>
                <MAR_ADDR_TYPE>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_TYPE/text()"" />
                </MAR_ADDR_TYPE>
                <MAR_ADDR_OTHER_DESC>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
                </MAR_ADDR_OTHER_DESC>
                <MAR_ADDRESS1>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS1/text()"" />
                </MAR_ADDRESS1>
                <MAR_ADDRESS2>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS2/text()"" />
                </MAR_ADDRESS2>
                <MAR_CITY>
                  <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                </MAR_CITY>
                <MAR_STATE_CD>
                  <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                </MAR_STATE_CD>
                <MAR_ZIP>
                  <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                </MAR_ZIP>
                <MAR_COUNTY>
                  <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                </MAR_COUNTY>
              </MailingAddress>
              <DPO_PRIMARY_IND>
                <xsl:value-of select=""DPO_PRIMARY_IND/text()"" />
              </DPO_PRIMARY_IND>
              <DPO_OWN_IND>
                <xsl:value-of select=""DPO_OWN_IND/text()"" />
              </DPO_OWN_IND>
              <DPO_HOME_RE>
                <xsl:value-of select=""DPO_HOME_RE/text()"" />
              </DPO_HOME_RE>
              <DPO_HOME_PP>
                <xsl:value-of select=""DPO_HOME_PP/text()"" />
              </DPO_HOME_PP>
              <DPO_HOME_AUTO>
                <xsl:value-of select=""DPO_HOME_AUTO/text()"" />
              </DPO_HOME_AUTO>
              <DPO_NO_INSURANCE_IND>
                <xsl:value-of select=""DPO_NO_INSURANCE_IND/text()"" />
              </DPO_NO_INSURANCE_IND>
              <DpoInsuranceColl>
                <xsl:for-each select=""DpoInsuranceColl/Dpo_Insurances"">
                  <Dpo_Insurances>
                    <DmgPropertyId>
                      <xsl:value-of select=""DmgPropertyId/text()"" />
                    </DmgPropertyId>
                    <InsuranceId>
                      <xsl:value-of select=""InsuranceId/text()"" />
                    </InsuranceId>
                    <DPI_TYPE>
                      <xsl:value-of select=""DPI_TYPE/text()"" />
                    </DPI_TYPE>
                    <DPI_INS_COMPANYNAME>
                      <xsl:value-of select=""DPI_INS_COMPANYNAME/text()"" />
                    </DPI_INS_COMPANYNAME>
                    <DPI_INS_AGENTNAME>
                      <xsl:value-of select=""DPI_INS_AGENTNAME/text()"" />
                    </DPI_INS_AGENTNAME>
                    <DPI_AGENT_PHONE>
                      <xsl:value-of select=""DPI_AGENT_PHONE/text()"" />
                    </DPI_AGENT_PHONE>
                    <DPI_POLICY_NBR>
                      <xsl:value-of select=""DPI_POLICY_NBR/text()"" />
                    </DPI_POLICY_NBR>
                    <DPI_AMT_RECVD>
                      <xsl:value-of select=""DPI_AMT_RECVD/text()"" />
                    </DPI_AMT_RECVD>
                  </Dpo_Insurances>
                </xsl:for-each>
              </DpoInsuranceColl>
              <xsl:call-template name=""PropertySalesForceID"">
                <xsl:with-param name=""SFPropRows"" select=""string($var:v11)"" />
              </xsl:call-template>
            </Dmg_Properties>
          </xsl:for-each>
        </xsl:for-each>
      </DmgPropertyColl>
      <xsl:for-each select=""InputMessagePart_1/ns0:Application/DpoDupBenefitColl"">
        <DpoDupBenefitColl>
          <xsl:for-each select=""Dpo_DupBenefits"">
            <Dpo_DupBenefits>
              <DupBenefitsId>
                <xsl:value-of select=""DupBenefitsId/text()"" />
              </DupBenefitsId>
              <DOB_AGENCY_NAME>
                <xsl:value-of select=""DOB_AGENCY_NAME/text()"" />
              </DOB_AGENCY_NAME>
              <DOB_AMT_RECVD>
                <xsl:value-of select=""DOB_AMT_RECVD/text()"" />
              </DOB_AMT_RECVD>
              <DOB_OTHER_DESC>
                <xsl:value-of select=""DOB_OTHER_DESC/text()"" />
              </DOB_OTHER_DESC>
              <xsl:value-of select=""./text()"" />
            </Dpo_DupBenefits>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </DpoDupBenefitColl>
      </xsl:for-each>
      <Assets>
        <APO_CASH_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_CASH_AMT/text()"" />
        </APO_CASH_AMT>
        <APO_IRA_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_IRA_AMT/text()"" />
        </APO_IRA_AMT>
        <APO_STOCK_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_STOCK_AMT/text()"" />
        </APO_STOCK_AMT>
        <APO_GOODS_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_GOODS_AMT/text()"" />
        </APO_GOODS_AMT>
        <APO_PRIMARY_RE_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_PRIMARY_RE_DESC/text()"" />
        </APO_PRIMARY_RE_DESC>
        <APO_PRIMARY_RE_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_PRIMARY_RE_AMT/text()"" />
        </APO_PRIMARY_RE_AMT>
        <APO_OTHER_RE1_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE1_DESC/text()"" />
        </APO_OTHER_RE1_DESC>
        <APO_OTHER_RE1_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE1_AMT/text()"" />
        </APO_OTHER_RE1_AMT>
        <APO_OTHER_RE2_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE2_DESC/text()"" />
        </APO_OTHER_RE2_DESC>
        <APO_OTHER_RE2_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE2_AMT/text()"" />
        </APO_OTHER_RE2_AMT>
        <APO_OTHER_RE3_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE3_DESC/text()"" />
        </APO_OTHER_RE3_DESC>
        <APO_OTHER_RE3_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER_RE3_AMT/text()"" />
        </APO_OTHER_RE3_AMT>
        <APO_OTHER1_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER1_DESC/text()"" />
        </APO_OTHER1_DESC>
        <APO_OTHER1_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER1_AMT/text()"" />
        </APO_OTHER1_AMT>
        <APO_OTHER2_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER2_DESC/text()"" />
        </APO_OTHER2_DESC>
        <APO_OTHER2_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/APO_OTHER2_AMT/text()"" />
        </APO_OTHER2_AMT>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Assets/text()"" />
      </Assets>
      <Debts>
        <NoDebts>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/NoDebts/text()"" />
        </NoDebts>
        <RentedProperty>
          <ARE_LANDLORD_NAME>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/ARE_LANDLORD_NAME/text()"" />
          </ARE_LANDLORD_NAME>
          <MailingAddress>
            <MAR_ADDR_TYPE>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_ADDR_TYPE/text()"" />
            </MAR_ADDR_TYPE>
            <MAR_ADDR_OTHER_DESC>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
            </MAR_ADDR_OTHER_DESC>
            <MAR_ADDRESS1>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_ADDRESS1/text()"" />
            </MAR_ADDRESS1>
            <MAR_ADDRESS2>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_ADDRESS2/text()"" />
            </MAR_ADDRESS2>
            <MAR_CITY>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_CITY/text()"" />
            </MAR_CITY>
            <MAR_STATE_CD>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_STATE_CD/text()"" />
            </MAR_STATE_CD>
            <MAR_ZIP>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_ZIP/text()"" />
            </MAR_ZIP>
            <MAR_COUNTY>
              <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/MAR_COUNTY/text()"" />
            </MAR_COUNTY>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/MailingAddress/text()"" />
          </MailingAddress>
          <ARE_RENTLEASE_AMT>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/ARE_RENTLEASE_AMT/text()"" />
          </ARE_RENTLEASE_AMT>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/RentedProperty/text()"" />
        </RentedProperty>
        <MortgageColl>
          <xsl:for-each select=""InputMessagePart_1/ns0:Application/Debts/MortgageColl/ARE_Mortgages"">
            <ARE_Mortgages>
              <MortgageId>
                <xsl:value-of select=""MortgageId/text()"" />
              </MortgageId>
              <ARM_HOLDER_NAME>
                <xsl:value-of select=""ARM_HOLDER_NAME/text()"" />
              </ARM_HOLDER_NAME>
              <MailingAddress>
                <MAR_ADDR_TYPE>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_TYPE/text()"" />
                </MAR_ADDR_TYPE>
                <MAR_ADDR_OTHER_DESC>
                  <xsl:value-of select=""MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
                </MAR_ADDR_OTHER_DESC>
                <MAR_ADDRESS1>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS1/text()"" />
                </MAR_ADDRESS1>
                <MAR_ADDRESS2>
                  <xsl:value-of select=""MailingAddress/MAR_ADDRESS2/text()"" />
                </MAR_ADDRESS2>
                <MAR_CITY>
                  <xsl:value-of select=""MailingAddress/MAR_CITY/text()"" />
                </MAR_CITY>
                <MAR_STATE_CD>
                  <xsl:value-of select=""MailingAddress/MAR_STATE_CD/text()"" />
                </MAR_STATE_CD>
                <MAR_ZIP>
                  <xsl:value-of select=""MailingAddress/MAR_ZIP/text()"" />
                </MAR_ZIP>
                <MAR_COUNTY>
                  <xsl:value-of select=""MailingAddress/MAR_COUNTY/text()"" />
                </MAR_COUNTY>
                <xsl:value-of select=""MailingAddress/text()"" />
              </MailingAddress>
              <ARM_PAY_AMT>
                <xsl:value-of select=""ARM_PAY_AMT/text()"" />
              </ARM_PAY_AMT>
              <ARM_BALANCE_AMT>
                <xsl:value-of select=""ARM_BALANCE_AMT/text()"" />
              </ARM_BALANCE_AMT>
            </ARE_Mortgages>
          </xsl:for-each>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/MortgageColl/text()"" />
        </MortgageColl>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/Debts/RealEstateTax"">
          <RealEstateTax>
            <Amount>
              <xsl:value-of select=""Amount/text()"" />
            </Amount>
            <Frequency>
              <xsl:value-of select=""Frequency/text()"" />
            </Frequency>
            <xsl:value-of select=""./text()"" />
          </RealEstateTax>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/Debts/HazardInsurance"">
          <HazardInsurance>
            <Amount>
              <xsl:value-of select=""Amount/text()"" />
            </Amount>
            <Frequency>
              <xsl:value-of select=""Frequency/text()"" />
            </Frequency>
            <xsl:value-of select=""./text()"" />
          </HazardInsurance>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/Debts/CondoHoaFee"">
          <CondoHoaFee>
            <Amount>
              <xsl:value-of select=""Amount/text()"" />
            </Amount>
            <Frequency>
              <xsl:value-of select=""Frequency/text()"" />
            </Frequency>
            <xsl:value-of select=""./text()"" />
          </CondoHoaFee>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/Debts/OtherDebtColl"">
          <OtherDebtColl>
            <xsl:for-each select=""OtherDebt"">
              <OtherDebt>
                <OtherDebtId>
                  <xsl:value-of select=""OtherDebtId/text()"" />
                </OtherDebtId>
                <APB_CREDITOR_NAME>
                  <xsl:value-of select=""APB_CREDITOR_NAME/text()"" />
                </APB_CREDITOR_NAME>
                <APB_LIABILITY_TYPE_CD>
                  <xsl:value-of select=""APB_LIABILITY_TYPE_CD/text()"" />
                </APB_LIABILITY_TYPE_CD>
                <APB_PMT_AMT>
                  <xsl:value-of select=""APB_PMT_AMT/text()"" />
                </APB_PMT_AMT>
                <APB_BALANCE_AMT>
                  <xsl:value-of select=""APB_BALANCE_AMT/text()"" />
                </APB_BALANCE_AMT>
                <APB_SECURED_INFO>
                  <xsl:value-of select=""APB_SECURED_INFO/text()"" />
                </APB_SECURED_INFO>
                <xsl:value-of select=""./text()"" />
              </OtherDebt>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </OtherDebtColl>
        </xsl:for-each>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Debts/text()"" />
      </Debts>
      <xsl:for-each select=""InputMessagePart_1/ns0:Application/ExtraExpenseColl"">
        <ExtraExpenseColl>
          <xsl:for-each select=""Apl_Ext_Expense"">
            <Apl_Ext_Expense>
              <ExtraOrdExpenseId>
                <xsl:value-of select=""ExtraOrdExpenseId/text()"" />
              </ExtraOrdExpenseId>
              <AEE_AMOUNT>
                <xsl:value-of select=""AEE_AMOUNT/text()"" />
              </AEE_AMOUNT>
              <AEE_DESCRIPTION>
                <xsl:value-of select=""AEE_DESCRIPTION/text()"" />
              </AEE_DESCRIPTION>
              <xsl:value-of select=""./text()"" />
            </Apl_Ext_Expense>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </ExtraExpenseColl>
      </xsl:for-each>
      <Final_Questions>
        <FQS_SBALOAN_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_SBALOAN_IND/text()"" />
        </FQS_SBALOAN_IND>
        <FQS_SBA_LOCATION>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_SBA_LOCATION/text()"" />
        </FQS_SBA_LOCATION>
        <FQS_SBA_ACC_NBR>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_SBA_ACC_NBR/text()"" />
        </FQS_SBA_ACC_NBR>
        <FQS_FEDLOAN_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FEDLOAN_IND/text()"" />
        </FQS_FEDLOAN_IND>
        <FQS_FED_AGENCY_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FED_AGENCY_NAME/text()"" />
        </FQS_FED_AGENCY_NAME>
        <FQS_FED_LOCATION>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FED_LOCATION/text()"" />
        </FQS_FED_LOCATION>
        <FQS_FED_ACC_NBR>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FED_ACC_NBR/text()"" />
        </FQS_FED_ACC_NBR>
        <FQS_FEDDEL_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FEDDEL_IND/text()"" />
        </FQS_FEDDEL_IND>
        <FQS_DEL_AGENCY_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DEL_AGENCY_NAME/text()"" />
        </FQS_DEL_AGENCY_NAME>
        <FQS_DEL_LOCATION>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DEL_LOCATION/text()"" />
        </FQS_DEL_LOCATION>
        <FQS_DEL_ACC_NBR>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DEL_ACC_NBR/text()"" />
        </FQS_DEL_ACC_NBR>
        <FQS_BKRPY_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_BKRPY_IND/text()"" />
        </FQS_BKRPY_IND>
        <FQS_BKRPY_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_BKRPY_DESC/text()"" />
        </FQS_BKRPY_DESC>
        <FQS_JDGMT_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_JDGMT_IND/text()"" />
        </FQS_JDGMT_IND>
        <FQS_JDGMT_COMMENTS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_JDGMT_COMMENTS/text()"" />
        </FQS_JDGMT_COMMENTS>
        <FQS_FELONY_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FELONY_IND/text()"" />
        </FQS_FELONY_IND>
        <FQS_FELONY_ID>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FELONY_ID/text()"" />
        </FQS_FELONY_ID>
        <FQS_FELONY_DETAILS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FELONY_DETAILS/text()"" />
        </FQS_FELONY_DETAILS>
        <FQS_912_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_912_IND/text()"" />
        </FQS_912_IND>
        <FQS_912_NAME1_ID>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_912_NAME1_ID/text()"" />
        </FQS_912_NAME1_ID>
        <FQS_912_DTLS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_912_DTLS/text()"" />
        </FQS_912_DTLS>
        <FQS_DEBAR_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DEBAR_IND/text()"" />
        </FQS_DEBAR_IND>
        <FQS_DEBAR_DESC>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DEBAR_DESC/text()"" />
        </FQS_DEBAR_DESC>
        <FQS_CITIZEN_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_CITIZEN_IND/text()"" />
        </FQS_CITIZEN_IND>
        <FQS_CITIZEN_DTLS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_CITIZEN_DTLS/text()"" />
        </FQS_CITIZEN_DTLS>
        <FQS_DISCUSS_MIT_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_DISCUSS_MIT_IND/text()"" />
        </FQS_DISCUSS_MIT_IND>
        <FQS_LR_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_IND/text()"" />
        </FQS_LR_IND>
        <FQS_LR_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_NAME/text()"" />
        </FQS_LR_NAME>
        <FQS_LR_COMPANY>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_COMPANY/text()"" />
        </FQS_LR_COMPANY>
        <FQS_LR_PHONE>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_PHONE/text()"" />
        </FQS_LR_PHONE>
        <MailingAddress>
          <MAR_ADDR_TYPE>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_ADDR_TYPE/text()"" />
          </MAR_ADDR_TYPE>
          <MAR_ADDR_OTHER_DESC>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_ADDR_OTHER_DESC/text()"" />
          </MAR_ADDR_OTHER_DESC>
          <MAR_ADDRESS1>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_ADDRESS1/text()"" />
          </MAR_ADDRESS1>
          <MAR_ADDRESS2>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_ADDRESS2/text()"" />
          </MAR_ADDRESS2>
          <MAR_CITY>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_CITY/text()"" />
          </MAR_CITY>
          <MAR_STATE_CD>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_STATE_CD/text()"" />
          </MAR_STATE_CD>
          <MAR_ZIP>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_ZIP/text()"" />
          </MAR_ZIP>
          <MAR_COUNTY>
            <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/MAR_COUNTY/text()"" />
          </MAR_COUNTY>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/MailingAddress/text()"" />
        </MailingAddress>
        <FQS_LR_FEE>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_FEE/text()"" />
        </FQS_LR_FEE>
        <FQS_LR_DISCUSS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_LR_DISCUSS/text()"" />
        </FQS_LR_DISCUSS>
        <FQS_EMP_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_EMP_IND/text()"" />
        </FQS_EMP_IND>
        <FQS_EMP_NAME1_ID>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_EMP_NAME1_ID/text()"" />
        </FQS_EMP_NAME1_ID>
        <FQS_AGREE_IND>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_AGREE_IND/text()"" />
        </FQS_AGREE_IND>
        <FQS_FINALCOMMENTS>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/FQS_FINALCOMMENTS/text()"" />
        </FQS_FINALCOMMENTS>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Final_Questions/text()"" />
      </Final_Questions>
      <RegUser>
        <USR_USER_ID>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_USER_ID/text()"" />
        </USR_USER_ID>
        <USR_USER_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_USER_NAME/text()"" />
        </USR_USER_NAME>
        <USR_FIRST_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_FIRST_NAME/text()"" />
        </USR_FIRST_NAME>
        <USR_LAST_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_LAST_NAME/text()"" />
        </USR_LAST_NAME>
        <USR_MIDDLE_NAME>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_MIDDLE_NAME/text()"" />
        </USR_MIDDLE_NAME>
        <USR_SUFFIX>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_SUFFIX/text()"" />
        </USR_SUFFIX>
        <USR_SSN>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_SSN/text()"" />
        </USR_SSN>
        <USR_ADDRESS1>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_ADDRESS1/text()"" />
        </USR_ADDRESS1>
        <USR_ADDRESS2>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_ADDRESS2/text()"" />
        </USR_ADDRESS2>
        <USR_CITY>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_CITY/text()"" />
        </USR_CITY>
        <USR_STATE_CD>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_STATE_CD/text()"" />
        </USR_STATE_CD>
        <USR_ZIP>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_ZIP/text()"" />
        </USR_ZIP>
        <USR_COUNTY>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_COUNTY/text()"" />
        </USR_COUNTY>
        <USR_PRIM_PHONE>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_PRIM_PHONE/text()"" />
        </USR_PRIM_PHONE>
        <USR_ALT_PHONE>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_ALT_PHONE/text()"" />
        </USR_ALT_PHONE>
        <USR_EMAIL>
          <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/USR_EMAIL/text()"" />
        </USR_EMAIL>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/RegUser/text()"" />
      </RegUser>
      <Disaster_Declaration__c>
        <xsl:value-of select=""$var:v12"" />
      </Disaster_Declaration__c>
      <Record_SF_Business_Loan_Application>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Business_Loan_Application/text()"" />
      </Record_SF_Business_Loan_Application>
      <Record_SF_Default_Applicant>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Default_Applicant/text()"" />
      </Record_SF_Default_Applicant>
      <Record_SF_EIDL_Application>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_EIDL_Application/text()"" />
      </Record_SF_EIDL_Application>
      <Record_SF_Home_Loan_Application>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Home_Loan_Application/text()"" />
      </Record_SF_Home_Loan_Application>
      <Record_SF_New_Read_Only_Application>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_New_Read_Only_Application/text()"" />
      </Record_SF_New_Read_Only_Application>
      <Record_SF_New_Read_Only_Applicant>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_New_Read_Only_Applicant/text()"" />
      </Record_SF_New_Read_Only_Applicant>
      <Record_SF_Affiliate_Applicant>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Affiliate_Applicant/text()"" />
      </Record_SF_Affiliate_Applicant>
      <Record_SF_Business_Entity_Applicant>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Business_Entity_Applicant/text()"" />
      </Record_SF_Business_Entity_Applicant>
      <Record_SF_Business_Owner_Applicant>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/Record_SF_Business_Owner_Applicant/text()"" />
      </Record_SF_Business_Owner_Applicant>
      <xsl:variable name=""var:v13"" select=""userCSharp:Iniatalize()"" />
      <xsl:value-of select=""$var:v13"" />
    </ns0:Application>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public int Num = 0;
public int Iniatalize()
{ 
	Num = 0;
	return Num;		
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


public string AccountIndexV(string BusinessIND, string Homev)
{ 
    if ((BusinessIND == ""true""))
     { 	  
            Num = Num+1;
            return System.Convert.ToString(Num);	 }              
				
    else if((Homev == ""true"")) 
    { 
	 return ""1""; } 
	 
	else
    { return """"; }	 
	 
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
  <xsl:template name=""PropertySalesForceID"">
<xsl:param name=""SFPropRows"" />
<xsl:element name=""SalesForcePropertyID"">
<xsl:value-of select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='table' and namespace-uri()='http://sba-oda/DLAP/DamagedProperty__c']/*[local-name()='row' and namespace-uri()='http://sba-oda/DLAP/DamagedProperty__c'][number($SFPropRows)]/*[local-name()='Id' and namespace-uri()='http://sba-oda/DLAP/DamagedProperty__c']/text()"" />
</xsl:element>
</xsl:template>
  <xsl:template name=""PopulateAccountSalesForceID"">
<xsl:param name=""SalesForceResponseRow2"" />
<xsl:element name=""APL_SalesForceAccountID"">
<xsl:value-of select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='table' and namespace-uri()='http://sba-oda/DLAP/Account']/*[local-name()='row' and namespace-uri()='http://sba-oda/DLAP/Account'][number($SalesForceResponseRow2)]/*[local-name()='Id' and namespace-uri()='http://sba-oda/DLAP/Account']/text()"" />
</xsl:element>
</xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+table";
        
        private const global::Salesforce_Application_Import_Definition.Account.CDataServiceAccount.table _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Salesforce_Application_Import_Definition.Account.CDataServiceAccount+table";
                _SrcSchemas[1] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                return _TrgSchemas;
            }
        }
    }
}
