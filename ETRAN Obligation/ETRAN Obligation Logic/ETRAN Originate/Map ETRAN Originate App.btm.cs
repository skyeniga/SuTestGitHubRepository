namespace SBA.ETRANObligation.Logic.ETRANOriginate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig))]
    public sealed class MapETRANOriginateApp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform""
                xmlns:msxsl=""urn:schemas-microsoft-com:xslt""
                xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var""
                exclude-result-prefixes=""msxsl var bbt multi defaults event notify etran canonical entsf sfout sfobj orgtype""
                version=""1.0""
                xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/""
                xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/""
                xmlns:orgtype=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/""
                xmlns:defaults=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/""
                xmlns:event=""http://SBA.gov/ETRANObligation/Salesforce/Insert/Event_Request__c/""
                xmlns:notify=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/""
                xmlns:etran=""http://ws.elend""
                xmlns:canonical=""http://SBA.gov/ETRANObligation/Canonical/""
                xmlns:entsf=""urn:enterprise.soap.sforce.com""
                xmlns:sfout=""http://soap.sforce.com/2005/09/outbound""
                xmlns:sfobj=""urn:sobject.enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" indent=""yes"" />
  
  <xsl:variable name=""lcaseArray"" select=""'abcdefghijklmnopqrstuvwxyzàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿžšœ'"" />
  <xsl:variable name=""ucaseArray"" select=""'ABCDEFGHIJKLMNOPQRSTUVWXYZÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝÞŸŽŠŒ'"" />
  <xsl:template name=""uppercase"">
    <xsl:param name=""text"" />
    <xsl:value-of select=""translate($text, $lcaseArray, $ucaseArray)"" />
  </xsl:template>
  <xsl:template name=""lowercase"">
    <xsl:param name=""text"" />
    <xsl:value-of select=""translate($text, $ucaseArray, $lcaseArray)"" />
  </xsl:template>
  <xsl:template name=""ConvertBoolToText"">
    <xsl:param name=""Condition""/>
    <xsl:param name=""TrueText""/>
    <xsl:param name=""FalseText""/>
    <xsl:choose>
      <xsl:when test=""$Condition"">
        <xsl:value-of select=""$TrueText"" />
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""$FalseText"" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name=""ConvertBoolToYorN"">
    <xsl:param name=""Condition"" select=""false"" />
    <xsl:call-template name=""ConvertBoolToText"">
      <xsl:with-param name=""Condition"" select=""$Condition"" />
      <xsl:with-param name=""TrueText"" select=""'Y'"" />
      <xsl:with-param name=""FalseText"" select=""'N'"" />
    </xsl:call-template>
  </xsl:template>
  

  <xsl:variable name=""BusinessTypes"" select=""/canonical:Canonical/canonical:BorrowerBusinessTypes/bbt:BorrowerBusinessType"" />

  <xsl:variable name=""DefaultLoanApplication"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:LoanApplication[1]"" />
  <xsl:variable name=""DefaultInterest"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:Interest[1]"" />
  <xsl:variable name=""DefaultBorrower"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:Borrower[1]"" />
  <xsl:variable name=""DefaultBorrowerRace"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:BorrowerRace[1]"" />
  <xsl:variable name=""DefaultPrincipal"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:Principal[1]"" />
  <xsl:variable name=""DefaultPrincipalRace"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:PrincipalRace[1]"" />
  <xsl:variable name=""DefaultSpecialPurpose"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:SpecialPurpose[1]"" />
  <xsl:variable name=""DefaultUseOfProceeds_Physical"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:UseOfProceeds_Physical[1]"" />
  <xsl:variable name=""DefaultUseOfProceeds_EIDL"" select=""/canonical:Canonical/canonical:ETRAN_Originate_App_Defaults/defaults:UseOfProceeds_EIDL[1]"" />
  <xsl:variable name=""AppLoanType"" select=""/canonical:Canonical/canonical:Multi/canonical:QueryResult/multi:records/multi:RecordType/multi:Name/text()"" />
  <xsl:variable name=""IsHomeLoan"" select=""($AppLoanType='Home Loan Application')"" />
  <xsl:variable name=""IsBusinessLoan"" select=""not($IsHomeLoan)"" />
  <xsl:variable name=""IsBusinessSoleProp"" select=""($IsBusinessLoan) and (/canonical:Canonical/canonical:Multi/canonical:QueryResult/multi:records/multi:Org_Type__c/text()='Individual - Sole Prop')"" />

  <xsl:variable name=""AppHasPrevLoans"" select=""normalize-space(/canonical:Canonical/canonical:Multi/canonical:QueryResult/multi:records/multi:Previous_SBA_Loans__c/text()) != ''"" />
  <xsl:variable name=""ApplicantBorrowers"" select=""/canonical:Canonical/canonical:Multi/canonical:QueryResult/multi:records/multi:Applicants__r/multi:records[multi:Borrower_Guarantor__c/text()='Borrower' and ($IsBusinessLoan or (multi:Entity_Type__c/text()!='Trust' or multi:Primary_Applicant__c/text()='true'))]"" />
  <xsl:variable name=""ApplicantPrincipals"" select=""/canonical:Canonical/canonical:Multi/canonical:QueryResult/multi:records/multi:Applicants__r/multi:records[not($IsBusinessSoleProp) and (multi:Applicant_Relation_Type__c/text()='Owner')]"" />

  <xsl:template name=""PhoneNumber"">
    <xsl:param name=""phone"" />
    <xsl:variable name=""phoneNumOnly"" select=""translate($phone, translate($phone, '0123456789', ''), '')"" />
    <xsl:choose>
      <xsl:when test=""string-length($phoneNumOnly) &gt; 10 and starts-with($phoneNumOnly, '1')"">
        <xsl:value-of select=""substring($phoneNumOnly, 2, 10)"" />
      </xsl:when>
      <xsl:when test=""string-length($phoneNumOnly) &gt; 10"">
        <xsl:value-of select=""substring($phoneNumOnly, 1, 10)"" />
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""$phoneNumOnly"" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name=""numericOnly"">
    <xsl:param name=""text""/>
    <!-- this will remove any non-numeric characters from the text -->
    <xsl:value-of select=""normalize-space(translate($text, translate($text, '1234567890', ''), ''))"" />
  </xsl:template>
  <xsl:template name=""Zip5"">
    <xsl:param name=""zip""/>
    <xsl:variable name=""zipText"">
      <xsl:call-template name=""numericOnly"">
        <xsl:with-param name=""text"" select=""$zip"" />
      </xsl:call-template>
    </xsl:variable>
    <xsl:choose>
      <xsl:when test=""string-length($zipText) &gt; 5"">
        <xsl:value-of select=""substring($zipText, 1, 5)"" />
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""$zipText"" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name=""Zip4"">
    <xsl:param name=""zip""/>
    <xsl:variable name=""zipText"">
      <xsl:call-template name=""numericOnly"">
        <xsl:with-param name=""text"" select=""$zip"" />
      </xsl:call-template>
    </xsl:variable>
    <xsl:choose>
      <xsl:when test=""string-length($zipText) &gt;= 9"">
        <xsl:value-of select=""substring($zipText, 6, 4)"" />
      </xsl:when>
      <xsl:otherwise>
        <xsl:text></xsl:text>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name=""ApplicantPostalCodes"">
    <xsl:param name=""zip""/>
    <xsl:variable name=""aplZip5"">
      <xsl:call-template name=""Zip5"">
        <xsl:with-param name=""zip"" select=""$zip"" />
      </xsl:call-template>
    </xsl:variable>
    <xsl:variable name=""aplZip4"">
      <xsl:call-template name=""Zip4"">
        <xsl:with-param name=""zip"" select=""$zip"" />
      </xsl:call-template>
    </xsl:variable>
    <xsl:if test=""$aplZip5!=''"">
      <PhysZipCd>
        <xsl:value-of select=""$aplZip5"" />
      </PhysZipCd>
    </xsl:if>
    <xsl:if test=""$aplZip4!=''"">
      <PhysZip4Cd>
        <xsl:value-of select=""$aplZip4"" />
      </PhysZip4Cd>
    </xsl:if>
  </xsl:template>
  <xsl:template name=""GetApplicantAddressFields"">
    <xsl:param name=""Contact"" />
    <xsl:param name=""Account"" />
    <xsl:choose>
      <xsl:when test=""$Contact"">
        <xsl:if test=""$Contact/multi:MailingStreet/text()!=''"">
          <PhysStrtName1>
            <xsl:value-of select=""$Contact/multi:MailingStreet/text()"" />
          </PhysStrtName1>
        </xsl:if>
        <!--<PhysStrtName2>
          <xsl:value-of select="""" />
        </PhysStrtName2>-->
        <xsl:if test=""$Contact/multi:MailingCity/text()!=''"">
          <PhysCityName>
            <xsl:value-of select=""$Contact/multi:MailingCity/text()"" />
          </PhysCityName>
        </xsl:if>
        <PhysCountryCd>
          <xsl:value-of select=""$DefaultBorrower/defaults:PhysCountryCd/text()"" />
        </PhysCountryCd>
        <xsl:if test=""$Contact/multi:MailingState/text()!=''"">
          <PhysStCd>
            <xsl:value-of select=""$Contact/multi:MailingState/text()"" />
          </PhysStCd>
        </xsl:if>
        <!--<PhysStNm>
          <xsl:value-of select="""" />
        </PhysStNm>-->
        <xsl:call-template name=""ApplicantPostalCodes"">
          <xsl:with-param name=""zip"" select=""$Contact/multi:MailingPostalCode/text()"" />
        </xsl:call-template>
      </xsl:when>
      <xsl:when test=""$Account"">
        <xsl:if test=""$Account/multi:ShippingStreet/text()!=''"">
          <PhysStrtName1>
            <xsl:value-of select=""$Account/multi:ShippingStreet/text()"" />
          </PhysStrtName1>
        </xsl:if>
        <!--<PhysStrtName2>
          <xsl:value-of select="""" />
        </PhysStrtName2>-->
        <xsl:if test=""$Account/multi:ShippingCity/text()!=''"">
          <PhysCityName>
            <xsl:value-of select=""$Account/multi:ShippingCity/text()"" />
          </PhysCityName>
        </xsl:if>
        <PhysCountryCd>
          <xsl:value-of select=""$DefaultBorrower/defaults:PhysCountryCd/text()"" />
        </PhysCountryCd>
        <xsl:if test=""$Account/multi:ShippingState/text()!=''"">
          <PhysStCd>
            <xsl:value-of select=""$Account/multi:ShippingState/text()"" />
          </PhysStCd>
        </xsl:if>
        <!--<PhysStNm>
          <xsl:value-of select="""" />
        </PhysStNm>-->
        <xsl:call-template name=""ApplicantPostalCodes"">
          <xsl:with-param name=""zip"" select=""$Account/multi:ShippingPostalCode/text()"" />
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise />
    </xsl:choose>
  </xsl:template>
  <xsl:template name=""GetApplicantPhoneField"">
    <xsl:param name=""Contact"" />
    <xsl:param name=""Account"" />
    <xsl:choose>
      <xsl:when test=""$Contact"">
        <xsl:variable name=""aplPhone"">
          <xsl:call-template name=""PhoneNumber"">
            <xsl:with-param name=""phone"" select=""$Contact/multi:Phone/text()"" />
          </xsl:call-template>
        </xsl:variable>
        <xsl:if test=""$aplPhone!=''"">
          <PrimaryPhone>
            <xsl:value-of select=""$aplPhone"" />
          </PrimaryPhone>
        </xsl:if>
      </xsl:when>
      <xsl:when test=""$Account"">
        <xsl:variable name=""aplPhone"">
          <xsl:call-template name=""PhoneNumber"">
            <xsl:with-param name=""phone"" select=""$Account/multi:Phone/text()"" />
          </xsl:call-template>
        </xsl:variable>
        <xsl:choose>
          <xsl:when test=""$aplPhone!=''"">
            <PrimaryPhone>
              <xsl:value-of select=""$aplPhone"" />
            </PrimaryPhone>
          </xsl:when>
          <xsl:otherwise>
            <xsl:variable name=""aplPhoneNumber"">
              <xsl:call-template name=""PhoneNumber"">
                <xsl:with-param name=""phone"" select=""$Account/multi:Phone_Number__c/text()"" />
              </xsl:call-template>
            </xsl:variable>
            <xsl:if test=""$aplPhoneNumber!=''"">
              <PrimaryPhone>
                <xsl:value-of select=""$aplPhoneNumber"" />
              </PrimaryPhone>
            </xsl:if>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:when>
      <xsl:otherwise />
    </xsl:choose>
  </xsl:template>
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/canonical:Canonical"" />
  </xsl:template>
  <xsl:template match=""/canonical:Canonical"">
    <SBA_ETran version=""3.9"">
      <App>
        <LoanApplication>
          <xsl:variable name=""disasterDamagedType"" select=""normalize-space(./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__r/multi:Disaster_Damaged_Type__c/text())"" />
          <xsl:variable name=""disasterPhysicalNumber"" select=""normalize-space(./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__r/multi:Physical_Number__c/text())"" />
          <xsl:variable name=""disasterEIDLNumber"" select=""normalize-space(./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__r/multi:EIDL_Number__c/text())"" />
          <xsl:variable name=""LoanApp_DisasterControlNmb"">
            <xsl:choose>
              <xsl:when test=""$disasterDamagedType!='' and $disasterPhysicalNumber!=''"">
                <xsl:value-of  select=""concat($disasterPhysicalNumber, substring($disasterDamagedType,1,1))"" />
              </xsl:when>
              <xsl:when test=""$disasterDamagedType!='' and $disasterEIDLNumber!=''"">
                <xsl:value-of  select=""concat($disasterEIDLNumber, substring($disasterDamagedType,1,1))"" />
              </xsl:when>
              <xsl:otherwise>
                <xsl:text></xsl:text>
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$DefaultLoanApplication/@defaults:action"" />
          </xsl:attribute>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Secure__c/text()!=''"">
            <CollateralInd>
              <xsl:variable name=""secure"">
                <xsl:call-template name=""uppercase"">
                  <xsl:with-param name=""text"" select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Secure__c/text()"" />
                </xsl:call-template>
              </xsl:variable>
              <xsl:call-template name=""ConvertBoolToYorN"">
                <xsl:with-param name=""Condition"" select=""boolean($secure='TRUE')""/>
              </xsl:call-template>
            </CollateralInd>
          </xsl:if>
          <xsl:if test=""$LoanApp_DisasterControlNmb!=''"">
            <DisasterCntrlNmb>
              <xsl:value-of select=""$LoanApp_DisasterControlNmb"" />
            </DisasterCntrlNmb>
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Name/text()!=''"">
            <DisasterApplicNmb>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Name/text()"" />
            </DisasterApplicNmb>
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Total_Term__c/text()!=''"">
            <LoanTermMnths>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Total_Term__c/text()"" />
            </LoanTermMnths>
          </xsl:if>
          <InterestStructureCd>
            <xsl:value-of select=""$DefaultLoanApplication/defaults:InterestStructureCd/text()"" />
          </InterestStructureCd>
          <!--
          <NAICSCd>
            <xsl:value-of select="""" />
          </NAICSCd>
          -->
          <NetEarningsClause>
            <xsl:value-of select=""$DefaultLoanApplication/defaults:NetEarningsClause/text()"" />
          </NetEarningsClause>
          <ProcessingMethodCd>
            <xsl:call-template name=""ConvertBoolToText"">
              <xsl:with-param name=""Condition"" select=""$IsBusinessLoan"" />
              <xsl:with-param name=""TrueText"" select=""'DPB'"" />
              <xsl:with-param name=""FalseText"" select=""'DPH'"" />
            </xsl:call-template>
          </ProcessingMethodCd>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:City__c/text()!=''"">
            <ProjectCityName>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:City__c/text()"" />
            </ProjectCityName>
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:Property_Address__c/text()!=''"">
            <ProjectStrtName1>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:Property_Address__c/text()"" />
            </ProjectStrtName1>
            <!-- 
          <ProjectStrtName2>
            <xsl:value-of select="""" />
          </ProjectStrtName2>
          -->
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:State__c/text()!=''"">
            <ProjectStCd>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:State__c/text()"" />
            </ProjectStCd>
          </xsl:if>
          <xsl:variable name=""zipText"" select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Property__r/multi:records[1]/multi:Zip_Code__c/text()"" />
          <xsl:variable name=""zip5"">
            <xsl:call-template name=""Zip5"">
              <xsl:with-param name=""zip"" select=""$zipText"" />
            </xsl:call-template>
          </xsl:variable>
          <xsl:variable name=""zip4"">
            <xsl:call-template name=""Zip4"">
              <xsl:with-param name=""zip"" select=""$zipText"" />
            </xsl:call-template>
          </xsl:variable>
          <xsl:if test=""$zip5!=''"">
            <ProjectZipCd>
              <xsl:value-of select=""$zip5"" />
            </ProjectZipCd>
          </xsl:if>
          <xsl:if test=""$zip4!=''"">
            <ProjectZip4Cd>
              <xsl:value-of select=""$zip4"" />
            </ProjectZip4Cd>
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Payment_Amount__c/text()!=''"">
            <PymtAmt>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Payment_Amount__c/text()"" />
            </PymtAmt>
          </xsl:if>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Loan_Amount__c/text()!=''"">
            <RequestedAmt>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Loan_Amount__c/text()"" />
            </RequestedAmt>
          </xsl:if>
          <!-- 2018-06-29 Rick Kozlin - removed per Sri Gopalakrishna DCMS1.0 does not send this 
          <RevolvingInd>
            <xsl:value-of select=""$DefaultLoanApplication/defaults:RevolvingInd/text()"" />
          </RevolvingInd>-->
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Servicing_Office__c/text()!=''"">
            <SBAServicingOffice>
              <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Servicing_Office__c/text()"" />
            </SBAServicingOffice>
          </xsl:if>
        </LoanApplication>
        <Interest>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$DefaultInterest/@defaults:action"" />
          </xsl:attribute>
          <xsl:if test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Interest_Rate__c/text()!=''"">
          <BaseIntrstRatePct>
            <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Interest_Rate__c/text()"" />
          </BaseIntrstRatePct>
          </xsl:if>
          <BaseRateSourcTypCd>
            <xsl:value-of select=""$DefaultInterest/defaults:BaseRateSourcTypCd/text()"" />
          </BaseRateSourcTypCd>
          <IntrstTypInd>
            <xsl:value-of select=""$DefaultInterest/defaults:IntrstTypInd/text()"" />
          </IntrstTypInd>
          <Phase>
            <xsl:value-of select=""$DefaultInterest/defaults:Phase/text()"" />
          </Phase>
        </Interest>
        <!-- ForEach Applicant Borrower -->
        <xsl:for-each select=""$ApplicantBorrowers"">
          <xsl:variable name=""isPrimary"" select=""boolean(./multi:Primary_Applicant__c/text()='true')"" />
          <xsl:variable name=""taxId"" select=""normalize-space(./multi:Tax_ID__c/text())"" />
          <xsl:variable name=""AplEntityType"" select=""./multi:Entity_Type__c/text()"" />
          <xsl:variable name=""ApplicantIsPerson"" select=""$AplEntityType='Individual - Sole Prop'"" />
          <xsl:variable name=""ApplicantIsBusiness"" select=""not($ApplicantIsPerson)"" />
          <xsl:variable name=""AplContact"" select=""./multi:Contact__r"" />
          <xsl:variable name=""AplAccount"" select=""./multi:Account__r"" />
          <xsl:variable name=""DoAplContactFields"" select=""$AplContact and $ApplicantIsPerson"" />
          <xsl:variable name=""DoAplAccountFields"" select=""not(DoAplContactFields) and $AplAccount and $ApplicantIsBusiness"" />
          <Borrower>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultBorrower/@defaults:action"" />
            </xsl:attribute>
            <xsl:if test=""$AplContact/multi:Birthdate/text()!=''"">
              <BirthDt>
                <xsl:value-of select=""$AplContact/multi:Birthdate/text()"" />
              </BirthDt>
            </xsl:if>
            <xsl:choose>
              <xsl:when test=""$DoAplAccountFields"">
                <xsl:if test=""$AplAccount/multi:Name/text()!=''"">
                  <BusinessName>
                    <xsl:value-of select=""$AplAccount/multi:Name/text()"" />
                  </BusinessName>
                </xsl:if>
              </xsl:when>
              <xsl:otherwise />
            </xsl:choose>
            <BusinessPersonInd>
              <xsl:call-template name=""ConvertBoolToText"">
                <xsl:with-param name=""Condition"" select=""$ApplicantIsPerson"" />
                <xsl:with-param name=""TrueText"" select=""'P'"" />
                <xsl:with-param name=""FalseText"" select=""'B'"" />
              </xsl:call-template>
            </BusinessPersonInd>
            <xsl:if test=""$IsHomeLoan and $ApplicantIsPerson"">
              <CreditScorSourcCd>
                <xsl:value-of select=""$DefaultBorrower/defaults:CreditScorSourcCd/text()"" />
              </CreditScorSourcCd>
            </xsl:if>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:if test=""$AplContact/multi:FirstName/text()!=''"">
                <FirstName>
                  <xsl:value-of select=""$AplContact/multi:FirstName/text()"" />
                </FirstName>
              </xsl:if>
              <xsl:if test=""$AplContact/multi:LastName/text()!=''"">
                <LastName>
                  <xsl:value-of select=""$AplContact/multi:LastName/text()"" />
                </LastName>
              </xsl:if>
            </xsl:if>
            <xsl:choose>
              <xsl:when test=""$DoAplAccountFields or $IsBusinessSoleProp"">
                <xsl:variable name=""aplId"" select=""./multi:Id/text()"" />
                <xsl:variable name=""AplBusType"" select=""$BusinessTypes[bbt:ApplicantId/text()=$aplId][1]/orgtype:LegalOrgTypeMapping/orgtype:ETranLegalOrgTypeCode/text()"" />
                <xsl:if test=""$AplBusType!=''"">
                  <LegalOrgnztnCd>
                    <xsl:value-of select=""$AplBusType"" />
                  </LegalOrgnztnCd>
                </xsl:if>
              </xsl:when>
              <xsl:otherwise />
            </xsl:choose>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:if test=""$AplContact/multi:MiddleName/text()!=''"">
                <MiddleInitial>
                  <xsl:value-of select=""substring($AplContact/multi:MiddleName/text(),1,1)"" />
                </MiddleInitial>
              </xsl:if>
              <xsl:if test=""$AplContact/multi:Suffix/text()!=''"">
                <NameSuffix>
                  <xsl:value-of select=""$AplContact/multi:Suffix/text()"" />
                </NameSuffix>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:call-template name=""GetApplicantAddressFields"">
                <xsl:with-param name=""Contact"" select=""$AplContact"" />
              </xsl:call-template>  
            </xsl:if>
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:call-template name=""GetApplicantAddressFields"">
                <xsl:with-param name=""Account"" select=""$AplAccount"" />
              </xsl:call-template>
            </xsl:if>
            <PrimaryBusinessInd>
              <xsl:call-template name=""ConvertBoolToYorN"">
                <xsl:with-param name=""Condition"" select=""$isPrimary"" />
              </xsl:call-template>
            </PrimaryBusinessInd>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:call-template name=""GetApplicantPhoneField"">
                <xsl:with-param name=""Contact"" select=""$AplContact"" />
              </xsl:call-template>
            </xsl:if>
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:call-template name=""GetApplicantPhoneField"">
                <xsl:with-param name=""Account"" select=""$AplAccount"" />
              </xsl:call-template>
            </xsl:if>
            <PriorSBALoanInd>
              <xsl:call-template name=""ConvertBoolToYorN"">
                <xsl:with-param name=""Condition"" select=""$AppHasPrevLoans"" />
              </xsl:call-template>
            </PriorSBALoanInd>
            <xsl:if test=""$taxId!=''"">
              <TaxId>
                <xsl:value-of select=""$taxId"" />
              </TaxId>
            </xsl:if>
            <!-- 2018-08-20 - per Sri G. we do not want to send Title anymore 
            <xsl:if test=""./multi:Name/text()"">
              <Title>
                <xsl:value-of select=""./multi:Name/text()"" />
              </Title>
            </xsl:if>
            -->
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:if test=""./multi:Trade_Name__c/text()!=''"">
                <TradeName>
                  <xsl:value-of select=""$AplAccount/multi:Trade_Name__c/text()"" />
                </TradeName>
              </xsl:if>
            </xsl:if>
          </Borrower>
          <BorrowerRace>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultBorrowerRace/@defaults:action"" />
            </xsl:attribute>
            <BusinessPersonInd>
              <xsl:call-template name=""ConvertBoolToText"">
                <xsl:with-param name=""Condition"" select=""$ApplicantIsPerson"" />
                <xsl:with-param name=""TrueText"" select=""'P'"" />
                <xsl:with-param name=""FalseText"" select=""'B'"" />
              </xsl:call-template>
            </BusinessPersonInd>
            <xsl:if test=""$taxId!=''"">
            <TaxId>
              <xsl:value-of select=""$taxId"" />
            </TaxId>
            </xsl:if>
            <RaceCd>
              <xsl:value-of select=""$DefaultBorrowerRace/defaults:RaceCd/text()"" />
            </RaceCd>
          </BorrowerRace>
        </xsl:for-each>
        <!-- ForEach Applicant Principal -->
        <xsl:for-each select=""$ApplicantPrincipals"">
          <xsl:variable name=""AplEntityType"" select=""./multi:Entity_Type__c/text()"" />
          <xsl:variable name=""ApplicantIsPerson"" select=""$AplEntityType='Individual - Sole Prop'"" />
          <xsl:variable name=""ApplicantIsBusiness"" select=""not($ApplicantIsPerson)"" />
          <xsl:variable name=""AplContact"" select=""./multi:Contact__r"" />
          <xsl:variable name=""AplAccount"" select=""./multi:Account__r"" />
          <xsl:variable name=""DoAplContactFields"" select=""$AplContact and $ApplicantIsPerson"" />
          <xsl:variable name=""DoAplAccountFields"" select=""$AplAccount and $ApplicantIsBusiness"" />
          <Principal>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultPrincipal/@defaults:action"" />
            </xsl:attribute>
            <xsl:if test=""./multi:Name/text()!=''"">
              <BusinessName>
                <xsl:value-of select=""./multi:Name/text()"" />
              </BusinessName>
            </xsl:if>
            <BusinessPersonInd>
              <xsl:call-template name=""ConvertBoolToText"">
                <xsl:with-param name=""Condition"" select=""$ApplicantIsPerson"" />
                <xsl:with-param name=""TrueText"" select=""'P'"" />
                <xsl:with-param name=""FalseText"" select=""'B'"" />
              </xsl:call-template>
            </BusinessPersonInd>
            <xsl:variable name=""busTaxId"" select=""./multi:Related_Parent__r/multi:Tax_ID__c/text()"" />
            <xsl:if test=""$busTaxId!=''"">
              <BusinessTaxID>
                <xsl:value-of select=""$busTaxId"" />
              </BusinessTaxID>
            </xsl:if>
            <EthnicCd>
              <xsl:value-of select=""$DefaultPrincipal/defaults:EthnicCd/text()"" />
            </EthnicCd>
            <ExtrnlCreditScorInd>
              <xsl:value-of select=""$DefaultPrincipal/defaults:ExtrnlCreditScorInd/text()"" />
            </ExtrnlCreditScorInd>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:if test=""$AplContact/multi:FirstName/text()!=''"">
                <FirstName>
                  <xsl:value-of select=""$AplContact/multi:FirstName/text()"" />
                </FirstName>
              </xsl:if>
            </xsl:if>
            <GndrCd>
              <xsl:value-of select=""$DefaultPrincipal/defaults:GndrCd/text()"" />
            </GndrCd>
            <xsl:if test=""(/multi:Ownership_Percent__c/text()) and (20.0 > number(/multi:Ownership_Percent__c/text()))"">
            <GntyInd>
              <xsl:value-of select=""$DefaultPrincipal/defaults:GntyInd/text()"" />
            </GntyInd>
            </xsl:if>
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:variable name=""aplId"" select=""./multi:Id/text()"" />
              <xsl:variable name=""AplBusType"" select=""$BusinessTypes[bbt:ApplicantId/text()=$aplId][1]/orgtype:LegalOrgTypeMapping/orgtype:ETranLegalOrgTypeCode/text()"" />
              <xsl:if test=""$AplBusType!=''"">
                <LegalOrgnztnCd>
                  <xsl:value-of select=""$AplBusType"" />
                </LegalOrgnztnCd>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:if test=""$AplContact/multi:LastName/text()!=''"">
              <LastName>
                <xsl:value-of select=""$AplContact/multi:LastName/text()"" />
              </LastName>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""./multi:Ownership_Percent__c/text()!=''"">
            <OwnrshpInBusinessPct>
              <xsl:value-of select=""./multi:Ownership_Percent__c/text()"" />
            </OwnrshpInBusinessPct>
            </xsl:if>
            <xsl:if test=""$DoAplContactFields"">
              <xsl:call-template name=""GetApplicantAddressFields"">
                <xsl:with-param name=""Contact"" select=""$AplContact"" />
              </xsl:call-template>
            </xsl:if>
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:call-template name=""GetApplicantAddressFields"">
                <xsl:with-param name=""Account"" select=""$AplAccount"" />
              </xsl:call-template>
            </xsl:if>
            <xsl:if test=""./multi:Tax_ID__c/text()!=''"">
            <TaxId>
              <xsl:value-of select=""./multi:Tax_ID__c/text()"" />
            </TaxId>
            </xsl:if>
            <xsl:if test=""$DoAplAccountFields"">
              <xsl:if test=""$AplAccount/multi:Trade_Name__c/text()!=''"">
                <TradeName>
                  <xsl:value-of select=""$AplAccount/multi:Trade_Name__c/text()"" />
                </TradeName>
              </xsl:if>
            </xsl:if>
            <VetCd>
              <xsl:value-of select=""$DefaultPrincipal/defaults:VetCd/text()"" />
            </VetCd>
          </Principal>
          <PrincipalRace>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultPrincipalRace/@defaults:action"" />
            </xsl:attribute>
            <BusinessPersonInd>
              <xsl:call-template name=""ConvertBoolToText"">
                <xsl:with-param name=""Condition"" select=""$ApplicantIsPerson"" />
                <xsl:with-param name=""TrueText"" select=""'P'"" />
                <xsl:with-param name=""FalseText"" select=""'B'"" />
              </xsl:call-template>
            </BusinessPersonInd>
            <xsl:if test=""./multi:Tax_ID__c/text()!=''"">
              <TaxId>
                <xsl:value-of select=""./multi:Tax_ID__c/text()"" />
              </TaxId>
            </xsl:if>
            <RaceCd>
              <xsl:value-of select=""$DefaultPrincipalRace/defaults:RaceCd/text()"" />
            </RaceCd>
          </PrincipalRace>
        </xsl:for-each>        
        <xsl:variable name=""loan2Type"">
          <xsl:call-template name=""uppercase"">
            <xsl:with-param name=""text"" select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Loan_Type2__c/text()"" />
          </xsl:call-template>
        </xsl:variable>
        <xsl:variable name=""NPRF"" select=""'NON-PROFIT'"" />
        <xsl:variable name=""MGMT"" select=""'PRE-DISASTER MITIGATION'"" />
        <xsl:variable name=""section1"">
          <xsl:choose>
            <xsl:when test=""$IsHomeLoan"">
              <xsl:text>HOME</xsl:text>
            </xsl:when>
            <xsl:when test=""contains($loan2Type,$NPRF)"">
              <xsl:text>NPRF</xsl:text>
            </xsl:when>
            <xsl:when test=""contains($loan2Type,$MGMT)"">
              <xsl:text>MGMT</xsl:text>            
            </xsl:when>
            <xsl:otherwise>
              <xsl:text></xsl:text>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:variable>
        <xsl:if test=""$section1!=''"">
          <SpecialPurpose>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultSpecialPurpose/@defaults:action"" />
            </xsl:attribute>
            <SpcPurpsLoanCd>
              <xsl:value-of select=""$section1"" />
            </SpcPurpsLoanCd>
          </SpecialPurpose>
        </xsl:if>
        <xsl:variable name=""creditElsewhereTest"">
          <xsl:call-template name=""uppercase"">
            <xsl:with-param name=""text"" select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Processing_Application_Review__r/multi:records/multi:Credit_Elsewhere_Test__c/text()"" />
          </xsl:call-template>
        </xsl:variable>
        <xsl:variable name=""section2"">
          <xsl:choose>
            <xsl:when test=""$creditElsewhereTest='BELOW MARKET RATE'"">
              <xsl:text>DNCE</xsl:text>
            </xsl:when>
            <xsl:when test=""$creditElsewhereTest='MARKET RATE'"">
              <xsl:text>NOSP</xsl:text>
            </xsl:when>
            <xsl:otherwise>
              <xsl:text></xsl:text>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:variable>
        <xsl:if test=""$section2!=''"">
          <SpecialPurpose>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$DefaultSpecialPurpose/@defaults:action"" />
            </xsl:attribute>
            <SpcPurpsLoanCd>
              <xsl:value-of select=""$section2"" />
            </SpcPurpsLoanCd>
          </SpecialPurpose>
        </xsl:if>
        <UseOfProceeds>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$DefaultUseOfProceeds_Physical/@defaults:action"" />
          </xsl:attribute>
          <LoanProceedTypCd>
            <xsl:value-of select=""$DefaultUseOfProceeds_Physical/defaults:LoanProceedTypCd/text()"" />
          </LoanProceedTypCd>
          <ProceedTypCd>
            <xsl:value-of select=""$DefaultUseOfProceeds_Physical/defaults:ProceedTypCd/text()"" />
          </ProceedTypCd>
          <ProceedAmt>
            <xsl:choose>
              <xsl:when test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Processing_Application_Review__r/multi:records/multi:Physical_Allocated_Amount__c/text()!=''"">
                <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Processing_Application_Review__r/multi:records/multi:Physical_Allocated_Amount__c/text()"" />
              </xsl:when>
              <xsl:otherwise>
                <xsl:text>0</xsl:text>
              </xsl:otherwise>
            </xsl:choose>
          </ProceedAmt>
        </UseOfProceeds>
        <UseOfProceeds>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$DefaultUseOfProceeds_EIDL/@defaults:action"" />
          </xsl:attribute>
          <LoanProceedTypCd>
            <xsl:value-of select=""$DefaultUseOfProceeds_EIDL/defaults:LoanProceedTypCd/text()"" />
          </LoanProceedTypCd>
          <ProceedTypCd>
            <xsl:value-of select=""$DefaultUseOfProceeds_EIDL/defaults:ProceedTypCd/text()"" />
          </ProceedTypCd>
          <ProceedAmt>
            <xsl:choose>
              <xsl:when test=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Processing_Application_Review__r/multi:records/multi:EIDL_Allocated_Amount__c/text()!=''"">
                <xsl:value-of select=""./canonical:Multi/canonical:QueryResult/multi:records/multi:Processing_Application_Review__r/multi:records/multi:EIDL_Allocated_Amount__c/text()"" />
              </xsl:when>
              <xsl:otherwise>
                <xsl:text>0</xsl:text>
              </xsl:otherwise>
            </xsl:choose>
          </ProceedAmt>
        </UseOfProceeds>
      </App>
    </SBA_ETran>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 1;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig";
                return _TrgSchemas;
            }
        }
    }
}
