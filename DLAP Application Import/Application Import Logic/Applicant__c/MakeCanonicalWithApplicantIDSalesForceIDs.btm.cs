namespace Application_Import_Logic.Applicant__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+table", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c.table))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    public sealed class MakeCanonicalWithApplicantIDSalesForceIDs : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:s0=""http://sba-oda/DLAP/Applicant__c"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
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
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/SalesForceAccountID/text()"" />
      </SalesForceAccountID>
      <SalesForceApplication__cID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/SalesForceApplication__cID/text()"" />
      </SalesForceApplication__cID>
      <OrchestrationID>
        <xsl:value-of select=""InputMessagePart_1/ns0:Application/OrchestrationID/text()"" />
      </OrchestrationID>
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
            <xsl:variable name=""var:v1"" select=""position()"" />
            <Applicants>
              <xsl:if test=""SalesForceContactID"">
                <xsl:variable name=""var:v2"" select=""string(SalesForceContactID/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v2)='true'"">
                  <SalesForceContactID>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </SalesForceContactID>
                </xsl:if>
                <xsl:if test=""string($var:v2)='false'"">
                  <SalesForceContactID>
                    <xsl:value-of select=""SalesForceContactID/text()"" />
                  </SalesForceContactID>
                </xsl:if>
              </xsl:if>
              <AppId>
                <xsl:value-of select=""AppId/text()"" />
              </AppId>
              <ApplicantId>
                <xsl:value-of select=""ApplicantId/text()"" />
              </ApplicantId>
              <xsl:call-template name=""PopulateSalesForceID"">
                <xsl:with-param name=""SalesForceResponseRow"" select=""string($var:v1)"" />
              </xsl:call-template>
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
                <xsl:if test=""AplWageColl"">
                  <xsl:value-of select=""AplWageColl/text()"" />
                </xsl:if>
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
                <xsl:value-of select=""TaxTranscriptRequest/text()"" />
              </TaxTranscriptRequest>
            </Applicants>
          </xsl:for-each>
        </xsl:for-each>
      </ApplicantColl>
      <xsl:for-each select=""InputMessagePart_1/ns0:Application/DmgPropertyColl"">
        <DmgPropertyColl>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </DmgPropertyColl>
      </xsl:for-each>
      <DpoDupBenefitColl>
        <xsl:for-each select=""InputMessagePart_1/ns0:Application/DpoDupBenefitColl"">
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
            </Dpo_DupBenefits>
          </xsl:for-each>
        </xsl:for-each>
      </DpoDupBenefitColl>
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
    </ns0:Application>
  </xsl:template>
  <xsl:template name=""PopulateSalesForceID"">
<xsl:param name=""SalesForceResponseRow"" />
<xsl:element name=""SalesForceApplicantID"">
<xsl:value-of select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='table' and namespace-uri()='http://sba-oda/DLAP/Applicant__c']/*[local-name()='row' and namespace-uri()='http://sba-oda/DLAP/Applicant__c'][number($SalesForceResponseRow)]/*[local-name()='Id' and namespace-uri()='http://sba-oda/DLAP/Applicant__c']/text()"" />
</xsl:element>
</xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+table";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c.table _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceApplicant__c+table";
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
