namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplication", typeof(global::Application_Import_Definition.HomeDisasterLoanApplication))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    public sealed class MakeCanonicalApplication : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/Application"" />
  </xsl:template>
  <xsl:template match=""/Application"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:Application>
      <VERSION>
        <xsl:value-of select=""VERSION/text()"" />
      </VERSION>
      <APP_ID>
        <xsl:value-of select=""APP_ID/text()"" />
      </APP_ID>
      <APP_ELA_REFERENCE_NBR>
        <xsl:value-of select=""APP_ELA_REFERENCE_NBR/text()"" />
      </APP_ELA_REFERENCE_NBR>
      <SalesForceAccountID>
        <xsl:value-of select=""$var:v1"" />
      </SalesForceAccountID>
      <SalesForceApplication__cID>
        <xsl:value-of select=""$var:v1"" />
      </SalesForceApplication__cID>
      <OrchestrationID>
        <xsl:value-of select=""$var:v1"" />
      </OrchestrationID>
      <APP_CREATE_DATE>
        <xsl:value-of select=""APP_CREATE_DATE/text()"" />
      </APP_CREATE_DATE>
      <APP_SUBMIT_DATE>
        <xsl:value-of select=""APP_SUBMIT_DATE/text()"" />
      </APP_SUBMIT_DATE>
      <APP_PRD_PRODUCT>
        <xsl:value-of select=""APP_PRD_PRODUCT/text()"" />
      </APP_PRD_PRODUCT>
      <APP_DPO_OWN_IND>
        <xsl:value-of select=""APP_DPO_OWN_IND/text()"" />
      </APP_DPO_OWN_IND>
      <APP_DPO_PRIMARY_IND>
        <xsl:value-of select=""APP_DPO_PRIMARY_IND/text()"" />
      </APP_DPO_PRIMARY_IND>
      <APP_DPO_SECONDARY_IND>
        <xsl:value-of select=""APP_DPO_SECONDARY_IND/text()"" />
      </APP_DPO_SECONDARY_IND>
      <APP_DPO_RENTAL_IND>
        <xsl:value-of select=""APP_DPO_RENTAL_IND/text()"" />
      </APP_DPO_RENTAL_IND>
      <APP_DPO_EXTFAM_IND>
        <xsl:value-of select=""APP_DPO_EXTFAM_IND/text()"" />
      </APP_DPO_EXTFAM_IND>
      <APP_BUS_RE>
        <xsl:value-of select=""APP_BUS_RE/text()"" />
      </APP_BUS_RE>
      <APP_BUS_CONT>
        <xsl:value-of select=""APP_BUS_CONT/text()"" />
      </APP_BUS_CONT>
      <APP_BUS_EIDL>
        <xsl:value-of select=""APP_BUS_EIDL/text()"" />
      </APP_BUS_EIDL>
      <APP_BUS_MREIDL>
        <xsl:value-of select=""APP_BUS_MREIDL/text()"" />
      </APP_BUS_MREIDL>
      <APP_PRO_ID>
        <xsl:value-of select=""APP_PRO_ID/text()"" />
      </APP_PRO_ID>
      <APP_DMG_STATE_CD>
        <xsl:value-of select=""APP_DMG_STATE_CD/text()"" />
      </APP_DMG_STATE_CD>
      <APP_DMG_COUNTY>
        <xsl:value-of select=""APP_DMG_COUNTY/text()"" />
      </APP_DMG_COUNTY>
      <APP_FEMA_REGIS_NBR>
        <xsl:value-of select=""APP_FEMA_REGIS_NBR/text()"" />
      </APP_FEMA_REGIS_NBR>
      <FemaReferralTrackingId>
        <xsl:value-of select=""FemaReferralTrackingId/text()"" />
      </FemaReferralTrackingId>
      <PrepopulatedWithFemaData>
        <xsl:value-of select=""PrepopulatedWithFemaData/text()"" />
      </PrepopulatedWithFemaData>
      <APP_CONSENT_IND>
        <xsl:value-of select=""APP_CONSENT_IND/text()"" />
      </APP_CONSENT_IND>
      <APP_ACKNOWLEDGE_IND>
        <xsl:value-of select=""APP_ACKNOWLEDGE_IND/text()"" />
      </APP_ACKNOWLEDGE_IND>
      <APP_CERTIFY_IND>
        <xsl:value-of select=""APP_CERTIFY_IND/text()"" />
      </APP_CERTIFY_IND>
      <LateFilingJustification>
        <xsl:value-of select=""LateFilingJustification/text()"" />
      </LateFilingJustification>
      <APP_CONTACT_NAME>
        <xsl:value-of select=""APP_CONTACT_NAME/text()"" />
      </APP_CONTACT_NAME>
      <APP_CONTACT_NBR>
        <xsl:value-of select=""APP_CONTACT_NBR/text()"" />
      </APP_CONTACT_NBR>
      <APP_INSP_NAME>
        <xsl:value-of select=""APP_INSP_NAME/text()"" />
      </APP_INSP_NAME>
      <APP_INSP_NBR>
        <xsl:value-of select=""APP_INSP_NBR/text()"" />
      </APP_INSP_NBR>
      <APP_SUMMARY_DECLINE_CODE>
        <xsl:value-of select=""APP_SUMMARY_DECLINE_CODE/text()"" />
      </APP_SUMMARY_DECLINE_CODE>
      <EST_LOSS_RE>
        <xsl:value-of select=""EST_LOSS_RE/text()"" />
      </EST_LOSS_RE>
      <EST_LOSS_INV>
        <xsl:value-of select=""EST_LOSS_INV/text()"" />
      </EST_LOSS_INV>
      <EST_LOSS_EQUIP>
        <xsl:value-of select=""EST_LOSS_EQUIP/text()"" />
      </EST_LOSS_EQUIP>
      <EST_LOSS_IMPROVE>
        <xsl:value-of select=""EST_LOSS_IMPROVE/text()"" />
      </EST_LOSS_IMPROVE>
      <NoIndividualOwner>
        <xsl:value-of select=""NoIndividualOwner/text()"" />
      </NoIndividualOwner>
      <NoEntityOwner>
        <xsl:value-of select=""NoEntityOwner/text()"" />
      </NoEntityOwner>
      <PackageId>
        <xsl:value-of select=""PackageId/text()"" />
      </PackageId>
      <ApplicantColl>
        <xsl:for-each select=""ApplicantColl/Applicants"">
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <Applicants>
            <SalesForceContactID>
              <xsl:value-of select=""$var:v2"" />
            </SalesForceContactID>
            <AppId>
              <xsl:value-of select=""AppId/text()"" />
            </AppId>
            <ApplicantId>
              <xsl:value-of select=""ApplicantId/text()"" />
            </ApplicantId>
            <SalesForceApplicantID>
              <xsl:value-of select=""$var:v2"" />
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
              <xsl:copy-of select=""MailingAddress/@*"" />
              <xsl:copy-of select=""MailingAddress/*"" />
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
              <xsl:copy-of select=""AplWageColl/@*"" />
              <xsl:copy-of select=""AplWageColl/*"" />
            </AplWageColl>
            <NoOtherIncome>
              <xsl:value-of select=""NoOtherIncome/text()"" />
            </NoOtherIncome>
            <AplOtherIncomeColl>
              <xsl:copy-of select=""AplOtherIncomeColl/@*"" />
              <xsl:copy-of select=""AplOtherIncomeColl/*"" />
            </AplOtherIncomeColl>
            <APL_AFFILIATE_IND>
              <xsl:value-of select=""APL_AFFILIATE_IND/text()"" />
            </APL_AFFILIATE_IND>
            <AplAffiliateColl>
              <xsl:copy-of select=""AplAffiliateColl/@*"" />
              <xsl:copy-of select=""AplAffiliateColl/*"" />
            </AplAffiliateColl>
            <TaxTranscriptRequest>
              <xsl:copy-of select=""TaxTranscriptRequest/@*"" />
              <xsl:copy-of select=""TaxTranscriptRequest/*"" />
            </TaxTranscriptRequest>
          </Applicants>
        </xsl:for-each>
      </ApplicantColl>
      <DmgPropertyColl>
        <xsl:copy-of select=""DmgPropertyColl/@*"" />
        <xsl:copy-of select=""DmgPropertyColl/*"" />
      </DmgPropertyColl>
      <DpoDupBenefitColl>
        <xsl:copy-of select=""DpoDupBenefitColl/@*"" />
        <xsl:copy-of select=""DpoDupBenefitColl/*"" />
      </DpoDupBenefitColl>
      <Assets>
        <xsl:copy-of select=""Assets/@*"" />
        <xsl:copy-of select=""Assets/*"" />
      </Assets>
      <Debts>
        <xsl:copy-of select=""Debts/@*"" />
        <xsl:copy-of select=""Debts/*"" />
      </Debts>
      <ExtraExpenseColl>
        <xsl:copy-of select=""ExtraExpenseColl/@*"" />
        <xsl:copy-of select=""ExtraExpenseColl/*"" />
      </ExtraExpenseColl>
      <Final_Questions>
        <xsl:copy-of select=""Final_Questions/@*"" />
        <xsl:copy-of select=""Final_Questions/*"" />
      </Final_Questions>
      <RegUser>
        <xsl:copy-of select=""RegUser/@*"" />
        <xsl:copy-of select=""RegUser/*"" />
      </RegUser>
      <PaperApplication>
        <xsl:value-of select=""PaperApplication/text()"" />
      </PaperApplication>
      <Disaster_Declaration__c>
        <xsl:value-of select=""$var:v1"" />
      </Disaster_Declaration__c>
      <Record_SF_Business_Loan_Application>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Business_Loan_Application>
      <Record_SF_Default_Applicant>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Default_Applicant>
      <Record_SF_EIDL_Application>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_EIDL_Application>
      <Record_SF_Home_Loan_Application>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Home_Loan_Application>
      <Record_SF_New_Read_Only_Application>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_New_Read_Only_Application>
      <Record_SF_New_Read_Only_Applicant>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_New_Read_Only_Applicant>
      <Record_SF_Affiliate_Applicant>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Affiliate_Applicant>
      <Record_SF_Business_Entity_Applicant>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Business_Entity_Applicant>
      <Record_SF_Business_Owner_Applicant>
        <xsl:value-of select=""$var:v1"" />
      </Record_SF_Business_Owner_Applicant>
    </ns0:Application>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplication";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplication _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplication";
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
