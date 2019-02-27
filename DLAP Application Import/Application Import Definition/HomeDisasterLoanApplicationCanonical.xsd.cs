namespace Application_Import_Definition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.ODA.Gov/CanonicalApplication",@"Application")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SalesForceAccountID", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SalesForceAccountID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SalesForceApplication__cID", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SalesForceApplication__cID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrchestrationID", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='OrchestrationID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SFEvent_ID", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SFEvent_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_ID), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_ELA_REFERENCE_NBR), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_ELA_REFERENCE_NBR' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_FEMA_REGIS_NBR), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_FEMA_REGIS_NBR' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_PRO_ID), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_PRO_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_CREATE_DATE), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_CREATE_DATE' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.APP_SUBMIT_DATE), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_SUBMIT_DATE' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Application_Import_Definition.PackageId), XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='PackageId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Business_Loan_Application", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Loan_Application' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_EIDL_Application", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_EIDL_Application' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Home_Loan_Application", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Home_Loan_Application' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_New_Read_Only_Application", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_New_Read_Only_Application' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Default_Applicant", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Default_Applicant' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Business_Entity_Applicant", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Entity_Applicant' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Business_Owner_Applicant", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Owner_Applicant' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_Affiliate_Applicant", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Affiliate_Applicant' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Record_SF_New_Read_Only_Applicant", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_New_Read_Only_Applicant' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "APP_SUMMARY_DECLINE_CODE", XPath = @"/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_SUMMARY_DECLINE_CODE' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Application"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.DLAP_Property_Schema", typeof(global::Application_Import_Definition.DLAP_Property_Schema))]
    public sealed class HomeDisasterLoanApplicationCanonical : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Application_Import_Definition.DLAP_Property_Schema"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Application_Import_Definition.DLAP_Property_Schema"" location=""Application_Import_Definition.DLAP_Property_Schema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Application"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SalesForceAccountID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SalesForceApplication__cID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='OrchestrationID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='SFEvent_ID' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_ID"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_ID' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_ELA_REFERENCE_NBR"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_ELA_REFERENCE_NBR' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_FEMA_REGIS_NBR"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_FEMA_REGIS_NBR' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_PRO_ID"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_PRO_ID' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_CREATE_DATE"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_CREATE_DATE' and namespace-uri()='']"" />
          <b:property name=""ns0:APP_SUBMIT_DATE"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_SUBMIT_DATE' and namespace-uri()='']"" />
          <b:property name=""ns0:PackageId"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='PackageId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Loan_Application' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_EIDL_Application' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Home_Loan_Application' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_New_Read_Only_Application' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Default_Applicant' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Entity_Applicant' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Business_Owner_Applicant' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_Affiliate_Applicant' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='Record_SF_New_Read_Only_Applicant' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Application' and namespace-uri()='http://SBA.ODA.Gov/CanonicalApplication']/*[local-name()='APP_SUMMARY_DECLINE_CODE' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""VERSION"" type=""xs:string"" />
        <xs:element name=""APP_ID"" type=""xs:string"" />
        <xs:element name=""APP_ELA_REFERENCE_NBR"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" default="" "" name=""SalesForceAccountID"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" default="" "" name=""SalesForceApplication__cID"" type=""xs:string"" />
        <xs:element name=""OrchestrationID"" type=""xs:string"" />
        <xs:element name=""SFEvent_ID"" type=""xs:string"" />
        <xs:element name=""APP_CREATE_DATE"" type=""xs:string"" />
        <xs:element name=""APP_SUBMIT_DATE"" type=""xs:string"" />
        <xs:element name=""APP_PRD_PRODUCT"" type=""xs:string"" />
        <xs:element name=""APP_DPO_OWN_IND"" type=""xs:string"" />
        <xs:element name=""APP_DPO_PRIMARY_IND"" type=""xs:string"" />
        <xs:element name=""APP_DPO_SECONDARY_IND"" type=""xs:string"" />
        <xs:element name=""APP_DPO_RENTAL_IND"" type=""xs:string"" />
        <xs:element name=""APP_DPO_EXTFAM_IND"" type=""xs:string"" />
        <xs:element name=""APP_BUS_RE"" type=""xs:string"" />
        <xs:element name=""APP_BUS_CONT"" type=""xs:string"" />
        <xs:element name=""APP_BUS_EIDL"" type=""xs:string"" />
        <xs:element name=""APP_BUS_MREIDL"" type=""xs:string"" />
        <xs:element name=""APP_PRO_ID"" type=""xs:string"" />
        <xs:element name=""APP_DMG_STATE_CD"" type=""xs:string"" />
        <xs:element name=""APP_DMG_COUNTY"" type=""xs:string"" />
        <xs:element name=""APP_FEMA_REGIS_NBR"" type=""xs:string"" />
        <xs:element name=""FemaReferralTrackingId"" type=""xs:string"" />
        <xs:element name=""PrepopulatedWithFemaData"" type=""xs:string"" />
        <xs:element name=""APP_CONSENT_IND"" type=""xs:string"" />
        <xs:element name=""APP_ACKNOWLEDGE_IND"" type=""xs:string"" />
        <xs:element name=""APP_CERTIFY_IND"" type=""xs:string"" />
        <xs:element name=""LateFilingJustification"" type=""xs:string"" />
        <xs:element name=""APP_CONTACT_NAME"" type=""xs:string"" />
        <xs:element name=""APP_CONTACT_NBR"" type=""xs:string"" />
        <xs:element name=""APP_INSP_NAME"" type=""xs:string"" />
        <xs:element name=""APP_INSP_NBR"" type=""xs:string"" />
        <xs:element name=""APP_SUMMARY_DECLINE_CODE"" type=""xs:string"" />
        <xs:element name=""EST_LOSS_RE"" type=""xs:string"" />
        <xs:element name=""EST_LOSS_INV"" type=""xs:string"" />
        <xs:element name=""EST_LOSS_EQUIP"" type=""xs:string"" />
        <xs:element name=""EST_LOSS_IMPROVE"" type=""xs:string"" />
        <xs:element name=""NoIndividualOwner"" type=""xs:string"" />
        <xs:element name=""NoEntityOwner"" type=""xs:string"" />
        <xs:element name=""PackageId"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""ApplicantColl"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Applicants"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""SalesForceContactID"" nillable=""true"" type=""xs:string"" />
                    <xs:element name=""AppId"" type=""xs:string"" />
                    <xs:element name=""ApplicantId"" type=""xs:string"" />
                    <xs:element name=""SalesForceApplicantID"" type=""xs:string"" />
                    <xs:element name=""ApplicantType"" type=""xs:string"" />
                    <xs:element name=""APL_FIRST_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_MIDDLE_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_LAST_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_SUFFIX"" type=""xs:string"" />
                    <xs:element name=""APL_SSN"" type=""xs:string"" />
                    <xs:element name=""APL_DOB"" type=""xs:string"" />
                    <xs:element name=""APL_BIRTH_PLACE"" type=""xs:string"" />
                    <xs:element name=""APL_MARITAL_STATUS"" type=""xs:string"" />
                    <xs:element name=""APL_RELATION_TYPE"" type=""xs:string"" />
                    <xs:element name=""APL_RELATION_OTHER"" type=""xs:string"" />
                    <xs:element name=""APL_FAMILY_SIZE"" type=""xs:string"" />
                    <xs:element name=""APL_SBA_EMPLOYEE"" type=""xs:string"" />
                    <xs:element name=""APL_SELF_EMPLOYED"" type=""xs:string"" />
                    <xs:element name=""MailingAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                          <xs:element name=""MAR_CITY"" type=""xs:string"" />
                          <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                          <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                          <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""APL_CONTACT_METHOD"" type=""xs:string"" />
                    <xs:element name=""APL_PRIM_PHONE"" type=""xs:string"" />
                    <xs:element name=""APL_WORK_PHONE"" type=""xs:string"" />
                    <xs:element name=""APL_ALT_PHONE"" type=""xs:string"" />
                    <xs:element name=""APL_FAX"" type=""xs:string"" />
                    <xs:element name=""APL_EMAIL"" type=""xs:string"" />
                    <xs:element name=""APL_OTHER_CONTACT"" type=""xs:string"" />
                    <xs:element name=""APL_REL_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_REL_PHONE"" type=""xs:string"" />
                    <xs:element name=""APL_ORG_TYPE_CD"" type=""xs:string"" />
                    <xs:element name=""APL_LEGAL_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_EIN_NBR"" type=""xs:string"" />
                    <xs:element name=""APL_BUS_TRADE_NAME"" type=""xs:string"" />
                    <xs:element name=""APL_BUS_ACTIVITY"" type=""xs:string"" />
                    <xs:element name=""APL_NO_EMPL"" type=""xs:string"" />
                    <xs:element name=""APL_DATE_ESTD"" type=""xs:string"" />
                    <xs:element name=""APL_DATE_CURR_MGMT"" type=""xs:string"" />
                    <xs:element name=""APL_TITLEOFFICE"" type=""xs:string"" />
                    <xs:element name=""APL_PER_OWNERSHIP"" type=""xs:string"" />
                    <xs:element name=""APL_CITIZEN_IND"" type=""xs:string"" />
                    <xs:element name=""NotEmployed"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""AplWageColl"">
                      <xs:complexType>
                        <xs:sequence minOccurs=""0"">
                          <xs:element maxOccurs=""unbounded"" name=""Apl_Wages"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ApplicantId"" type=""xs:string"" />
                                <xs:element name=""WageId"" type=""xs:string"" />
                                <xs:element name=""APW_EMPL_NAME"" type=""xs:string"" />
                                <xs:element name=""MailingAddress"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                                      <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                                      <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                                      <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                                      <xs:element name=""MAR_CITY"" type=""xs:string"" />
                                      <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                                      <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                                      <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""APW_EMPL_YRS"" type=""xs:string"" />
                                <xs:element name=""APW_EMPL_MNTHS"" type=""xs:string"" />
                                <xs:element name=""APW_GROSS_INC_AMT"" type=""xs:string"" />
                                <xs:element name=""APW_GROSS_INC_FREQ"" type=""xs:string"" />
                                <xs:element name=""APW_OCCUPATION"" type=""xs:string"" />
                                <xs:element name=""APW_SELF_WAGE"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""NoOtherIncome"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""AplOtherIncomeColl"">
                      <xs:complexType>
                        <xs:sequence minOccurs=""0"">
                          <xs:element maxOccurs=""unbounded"" name=""Apl_Other_Income"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ApplicantId"" type=""xs:string"" />
                                <xs:element name=""OtherIncomeId"" type=""xs:string"" />
                                <xs:element name=""API_INCOME_SOURCE"" type=""xs:string"" />
                                <xs:element name=""API_INCOME_AMOUNT"" type=""xs:string"" />
                                <xs:element name=""API_INCOME_FREQ"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""APL_AFFILIATE_IND"" type=""xs:string"" />
                    <xs:element name=""AplAffiliateColl"" type=""xs:string"" />
                    <xs:element name=""TaxTranscriptRequest"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PreviousAddress"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                                <xs:element name=""MAR_CITY"" type=""xs:string"" />
                                <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                                <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                                <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""TaxForm"" type=""xs:string"" />
                          <xs:element name=""EndOfFiscalYear"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element maxOccurs=""unbounded"" name=""string"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""SignerTitle"" type=""xs:string"" />
                          <xs:element name=""Attestation"" type=""xs:string"" />
                          <xs:element name=""IncludeSpouse"" type=""xs:string"" />
                          <xs:element name=""SwitchedEntityOrder"" type=""xs:string"" />
                          <xs:element name=""DataEntryRequired"" type=""xs:string"" />
                          <xs:element name=""DownloadRequired"" type=""xs:string"" />
                          <xs:element name=""FileUploaded"" type=""xs:string"" />
                          <xs:element name=""SubmitOffline"" type=""xs:string"" />
                          <xs:element name=""SignatureRequired"" type=""xs:string"" />
                          <xs:element name=""FileName"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""APL_SalesForceAccountID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DmgPropertyColl"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Dmg_Properties"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""AppId"" type=""xs:string"" />
                    <xs:element name=""DmgPropertyId"" type=""xs:string"" />
                    <xs:element name=""MailingAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                          <xs:element name=""MAR_CITY"" type=""xs:string"" />
                          <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                          <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                          <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""DPO_PRIMARY_IND"" type=""xs:string"" />
                    <xs:element name=""DPO_OWN_IND"" type=""xs:string"" />
                    <xs:element name=""DPO_HOME_RE"" type=""xs:string"" />
                    <xs:element name=""DPO_HOME_PP"" type=""xs:string"" />
                    <xs:element name=""DPO_HOME_AUTO"" type=""xs:string"" />
                    <xs:element name=""DPO_NO_INSURANCE_IND"" type=""xs:string"" />
                    <xs:element name=""DpoInsuranceColl"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Dpo_Insurances"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""DmgPropertyId"" type=""xs:string"" />
                                <xs:element name=""InsuranceId"" type=""xs:string"" />
                                <xs:element name=""DPI_TYPE"" type=""xs:string"" />
                                <xs:element name=""DPI_INS_COMPANYNAME"" type=""xs:string"" />
                                <xs:element name=""DPI_INS_AGENTNAME"" type=""xs:string"" />
                                <xs:element name=""DPI_AGENT_PHONE"" type=""xs:string"" />
                                <xs:element name=""DPI_POLICY_NBR"" type=""xs:string"" />
                                <xs:element name=""DPI_AMT_RECVD"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""SalesForcePropertyID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DpoDupBenefitColl"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Dpo_DupBenefits"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DupBenefitsId"" type=""xs:string"" />
                    <xs:element name=""DOB_AGENCY_NAME"" type=""xs:string"" />
                    <xs:element name=""DOB_AMT_RECVD"" type=""xs:string"" />
                    <xs:element name=""DOB_OTHER_DESC"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Assets"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""APO_CASH_AMT"" type=""xs:string"" />
              <xs:element name=""APO_IRA_AMT"" type=""xs:string"" />
              <xs:element name=""APO_STOCK_AMT"" type=""xs:string"" />
              <xs:element name=""APO_GOODS_AMT"" type=""xs:string"" />
              <xs:element name=""APO_PRIMARY_RE_DESC"" type=""xs:string"" />
              <xs:element name=""APO_PRIMARY_RE_AMT"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE1_DESC"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE1_AMT"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE2_DESC"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE2_AMT"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE3_DESC"" type=""xs:string"" />
              <xs:element name=""APO_OTHER_RE3_AMT"" type=""xs:string"" />
              <xs:element name=""APO_OTHER1_DESC"" type=""xs:string"" />
              <xs:element name=""APO_OTHER1_AMT"" type=""xs:string"" />
              <xs:element name=""APO_OTHER2_DESC"" type=""xs:string"" />
              <xs:element name=""APO_OTHER2_AMT"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Debts"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""NoDebts"" type=""xs:string"" />
              <xs:element name=""RentedProperty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ARE_LANDLORD_NAME"" type=""xs:string"" />
                    <xs:element name=""MailingAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                          <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                          <xs:element name=""MAR_CITY"" type=""xs:string"" />
                          <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                          <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                          <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ARE_RENTLEASE_AMT"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""MortgageColl"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""unbounded"" name=""ARE_Mortgages"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""MortgageId"" type=""xs:string"" />
                          <xs:element name=""ARM_HOLDER_NAME"" type=""xs:string"" />
                          <xs:element name=""MailingAddress"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                                <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                                <xs:element name=""MAR_CITY"" type=""xs:string"" />
                                <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                                <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                                <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""ARM_PAY_AMT"" type=""xs:string"" />
                          <xs:element name=""ARM_BALANCE_AMT"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RealEstateTax"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Amount"" type=""xs:string"" />
                    <xs:element name=""Frequency"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""HazardInsurance"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Amount"" type=""xs:string"" />
                    <xs:element name=""Frequency"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CondoHoaFee"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Amount"" type=""xs:string"" />
                    <xs:element name=""Frequency"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OtherDebtColl"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OtherDebt"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""OtherDebtId"" type=""xs:string"" />
                          <xs:element name=""APB_CREDITOR_NAME"" type=""xs:string"" />
                          <xs:element name=""APB_LIABILITY_TYPE_CD"" type=""xs:string"" />
                          <xs:element name=""APB_PMT_AMT"" type=""xs:string"" />
                          <xs:element name=""APB_BALANCE_AMT"" type=""xs:string"" />
                          <xs:element name=""APB_SECURED_INFO"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ExtraExpenseColl"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Apl_Ext_Expense"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ExtraOrdExpenseId"" type=""xs:string"" />
                    <xs:element name=""AEE_AMOUNT"" type=""xs:string"" />
                    <xs:element name=""AEE_DESCRIPTION"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Final_Questions"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FQS_SBALOAN_IND"" type=""xs:string"" />
              <xs:element name=""FQS_SBA_LOCATION"" type=""xs:string"" />
              <xs:element name=""FQS_SBA_ACC_NBR"" type=""xs:string"" />
              <xs:element name=""FQS_FEDLOAN_IND"" type=""xs:string"" />
              <xs:element name=""FQS_FED_AGENCY_NAME"" type=""xs:string"" />
              <xs:element name=""FQS_FED_LOCATION"" type=""xs:string"" />
              <xs:element name=""FQS_FED_ACC_NBR"" type=""xs:string"" />
              <xs:element name=""FQS_FEDDEL_IND"" type=""xs:string"" />
              <xs:element name=""FQS_DEL_AGENCY_NAME"" type=""xs:string"" />
              <xs:element name=""FQS_DEL_LOCATION"" type=""xs:string"" />
              <xs:element name=""FQS_DEL_ACC_NBR"" type=""xs:string"" />
              <xs:element name=""FQS_BKRPY_IND"" type=""xs:string"" />
              <xs:element name=""FQS_BKRPY_DESC"" type=""xs:string"" />
              <xs:element name=""FQS_JDGMT_IND"" type=""xs:string"" />
              <xs:element name=""FQS_JDGMT_COMMENTS"" type=""xs:string"" />
              <xs:element name=""FQS_FELONY_IND"" type=""xs:string"" />
              <xs:element name=""FQS_FELONY_ID"" type=""xs:string"" />
              <xs:element name=""FQS_FELONY_DETAILS"" type=""xs:string"" />
              <xs:element name=""FQS_912_IND"" type=""xs:string"" />
              <xs:element name=""FQS_912_NAME1_ID"" type=""xs:string"" />
              <xs:element name=""FQS_912_DTLS"" type=""xs:string"" />
              <xs:element name=""FQS_DEBAR_IND"" type=""xs:string"" />
              <xs:element name=""FQS_DEBAR_DESC"" type=""xs:string"" />
              <xs:element name=""FQS_CITIZEN_IND"" type=""xs:string"" />
              <xs:element name=""FQS_CITIZEN_DTLS"" type=""xs:string"" />
              <xs:element name=""FQS_DISCUSS_MIT_IND"" type=""xs:string"" />
              <xs:element name=""FQS_LR_IND"" type=""xs:string"" />
              <xs:element name=""FQS_LR_NAME"" type=""xs:string"" />
              <xs:element name=""FQS_LR_COMPANY"" type=""xs:string"" />
              <xs:element name=""FQS_LR_PHONE"" type=""xs:string"" />
              <xs:element name=""MailingAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""MAR_ADDR_TYPE"" type=""xs:string"" />
                    <xs:element name=""MAR_ADDR_OTHER_DESC"" type=""xs:string"" />
                    <xs:element name=""MAR_ADDRESS1"" type=""xs:string"" />
                    <xs:element name=""MAR_ADDRESS2"" type=""xs:string"" />
                    <xs:element name=""MAR_CITY"" type=""xs:string"" />
                    <xs:element name=""MAR_STATE_CD"" type=""xs:string"" />
                    <xs:element name=""MAR_ZIP"" type=""xs:string"" />
                    <xs:element name=""MAR_COUNTY"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""FQS_LR_FEE"" type=""xs:string"" />
              <xs:element name=""FQS_LR_DISCUSS"" type=""xs:string"" />
              <xs:element name=""FQS_EMP_IND"" type=""xs:string"" />
              <xs:element name=""FQS_EMP_NAME1_ID"" type=""xs:string"" />
              <xs:element name=""FQS_AGREE_IND"" type=""xs:string"" />
              <xs:element name=""FQS_FINALCOMMENTS"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RegUser"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""USR_USER_ID"" type=""xs:string"" />
              <xs:element name=""USR_USER_NAME"" type=""xs:string"" />
              <xs:element name=""USR_FIRST_NAME"" type=""xs:string"" />
              <xs:element name=""USR_LAST_NAME"" type=""xs:string"" />
              <xs:element name=""USR_MIDDLE_NAME"" type=""xs:string"" />
              <xs:element name=""USR_SUFFIX"" type=""xs:string"" />
              <xs:element name=""USR_SSN"" type=""xs:string"" />
              <xs:element name=""USR_ADDRESS1"" type=""xs:string"" />
              <xs:element name=""USR_ADDRESS2"" type=""xs:string"" />
              <xs:element name=""USR_CITY"" type=""xs:string"" />
              <xs:element name=""USR_STATE_CD"" type=""xs:string"" />
              <xs:element name=""USR_ZIP"" type=""xs:string"" />
              <xs:element name=""USR_COUNTY"" type=""xs:string"" />
              <xs:element name=""USR_PRIM_PHONE"" type=""xs:string"" />
              <xs:element name=""USR_ALT_PHONE"" type=""xs:string"" />
              <xs:element name=""USR_EMAIL"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PaperApplication"" type=""xs:string"" />
        <xs:element name=""Disaster_Declaration__c"" nillable=""true"" type=""xs:string"" />
        <xs:element name=""Record_SF_Business_Loan_Application"" type=""xs:string"" />
        <xs:element name=""Record_SF_Default_Applicant"" type=""xs:string"" />
        <xs:element name=""Record_SF_EIDL_Application"" type=""xs:string"" />
        <xs:element name=""Record_SF_Home_Loan_Application"" type=""xs:string"" />
        <xs:element name=""Record_SF_New_Read_Only_Application"" type=""xs:string"" />
        <xs:element name=""Record_SF_New_Read_Only_Applicant"" type=""xs:string"" />
        <xs:element name=""Record_SF_Affiliate_Applicant"" type=""xs:string"" />
        <xs:element name=""Record_SF_Business_Entity_Applicant"" type=""xs:string"" />
        <xs:element name=""Record_SF_Business_Owner_Applicant"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HomeDisasterLoanApplicationCanonical() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Application";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
