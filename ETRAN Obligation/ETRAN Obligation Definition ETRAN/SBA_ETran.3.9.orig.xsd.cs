namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"SBA_ETran")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "version", XPath = @"/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='version' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SBA_ETran"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes))]
    public sealed class SBA_ETran_3_9_orig : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:xhtml=""http://www.w3.org/1999/xhtml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes"" />
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes"" />
  <xs:annotation>
    <xs:documentation>
      <xhtml:h1 xmlns:xhtml=""http://www.w3.org/1999/xhtml"">XSD for SBA_ETran 3.9, Origination</xhtml:h1>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				This is one of the first Electronic Lending XSDs to use &lt;annotation&gt; and &lt;documentation&gt; tags. 
				Before using them more extensively, 
				it would be good to provide us with feedback as to whether 
				you find this technique more useful than XML comments. 
			</xhtml:p>
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""SBA_ETran"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='version' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""App"" type=""SBA_LoanApplication"">
          <xs:annotation>
            <xs:documentation>
              <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
								The SBA's ""root tag"" (&lt;SBA_ETran&gt;) for Origination must contain 
								at least one &lt;App&gt; tag. 
								It may contain more than one. 
								If more than one &lt;App&gt; tag is given, 
								each &lt;App&gt; tag will commit to the SBA's database, 
								or roll back from it, independently of all other &lt;App&gt; tags in the same submission. 
								For this reason, &lt;App&gt; is sometimes referred to as the 
								""transaction tag"" of Origination. 
							</xhtml:p>
            </xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""version"" type=""SBA_ETranVersions"">
        <xs:annotation>
          <xs:documentation>
            <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
							Your ""root tag"" should be &lt;SBA_ETran version=""3.9""&gt; 
							for XML that conforms to this XSD. 
							See SBA_ETranTypes.xsd for an explanation of ETran version numbers 
							and their coding implications. 
						</xhtml:p>
          </xs:documentation>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""SBA_LoanApplication"">
    <xs:choice maxOccurs=""unbounded"">
      <xs:element name=""LoanApplication"" type=""LoanApplication"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Assistance"" type=""Assistance"" />
      <xs:element minOccurs=""0"" name=""BalanceSheet"" type=""BalanceSheet"" />
      <xs:element maxOccurs=""unbounded"" name=""Borrower"" type=""Borrower"" />
      <xs:element maxOccurs=""unbounded"" name=""BorrowerRace"" type=""BorrowerRace"" />
      <xs:element maxOccurs=""unbounded"" name=""BusAppr"" type=""BusAppr"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ChangeOfOwnership"" type=""ChangeOfOwnership"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Collateral"" type=""Collateral"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CollateralLiens"" type=""CollateralLiens"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Comments"" type=""Comments"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CommunityAdvantage"" type=""CommunityAdvantage"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CounselingHours"" type=""CounselingHours"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CounselingSource"" type=""CounselingSource"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CreditUnavailReasons"" type=""CreditUnavailReasons"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Eligibility"" type=""Eligibility"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FederalEmployee"" type=""FederalEmployee"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Guarantor"" type=""Guarantor"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IncomeStatement"" type=""IncomeStatement"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Indebtedness"" type=""Indebtedness"" />
      <xs:element minOccurs=""1"" maxOccurs=""2"" name=""Interest"" type=""Interest"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Injection"" type=""Injection"" />
      <xs:element minOccurs=""0"" name=""LoanReasons"" type=""LoanReasons"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PartcipatLender"" type=""PartcipatLender"" />
      <xs:element minOccurs=""0"" name=""PartnerInformation"" type=""PartnerInformation"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PersonalFinancials"" type=""PersonalFinancials"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PreviousGovtFinance"" type=""PreviousGovtFinance"" />
      <xs:element maxOccurs=""unbounded"" name=""Principal"" type=""Principal"" />
      <xs:element maxOccurs=""unbounded"" name=""PrincipalRace"" type=""PrincipalRace"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SpecialPurpose"" type=""SpecialPurpose"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UnderservedMarket"" type=""UnderservedMarket"" />
      <xs:element maxOccurs=""unbounded"" name=""UseOfProceeds"" type=""UseOfProceeds"" />
    </xs:choice>
    <xs:attribute name=""number"" type=""xs:positiveInteger"" />
  </xs:complexType>
  <xs:complexType name=""LoanApplication"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AgentInvolved"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BorrowerContribPct"" type=""SBA_Dec3v2"" />
      <xs:element minOccurs=""0"" name=""BorrowerContribAmt"" type=""xs:decimal"" />
      <xs:element name=""BusinessAgeCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""ClosingCostAmt"" type=""xs:decimal"" />
      <xs:element name=""CollateralInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""CurrEmpQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""DisasterCntrlNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""DisasterApplicNmb"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EconDevObjctCd"" type=""SBA_Str3"" />
      <xs:element name=""EligPassiveCompanyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EWCPPostShipmntInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EWCPSnglTransInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseCd"" type=""SBA_Str5"" />
      <xs:element name=""FrnchiseInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""FullAmortPymtInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FundingFeeAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GntyFeeAmt"" type=""xs:decimal"" />
      <xs:element name=""InterestStructureCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""InjectionInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""JobsCreatdQty"" type=""xs:int"" />
      <xs:element name=""JobsRetaindQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""JobRqmtMetInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LenderApplicNmb"" type=""SBA_Str20"" />
      <xs:element name=""LenderCntctEmail"" type=""SBA_Str255"" />
      <xs:element name=""LenderCntctFax"" type=""SBA_Str20"" />
      <xs:element name=""LenderCntctFirstName"" type=""SBA_Str40"" />
      <xs:element name=""LenderCntctLastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LenderCntctMiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""LenderCntctNameSuffix"" type=""SBA_Str4"" />
      <xs:element name=""LenderCntctPhnNmb"" type=""SBA_Str20"" />
      <xs:element name=""LenderCntctTitl"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LenderLoanNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LifeInsurRqmtInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""LoanName"" type=""SBA_Str80"" />
      <xs:element name=""LoanPackageSourcTypCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerName"" type=""SBA_Str150"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerZip4Cd"" type=""SBA_Str4"" />
      <xs:element name=""LoanTermMnths"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""MnthsIntrstOnlyQty"" type=""xs:short"" />
      <xs:element name=""NAICSCd"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""NetDebentrAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NetEarningsClause"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""NetExprtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OutPrgrmAreaOfOperInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""OverallPortfolioJobRatio"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""ProcessingFeeAmt"" type=""xs:decimal"" />
      <xs:element name=""ProcessingMethodCd"" type=""SBA_Str3"" />
      <xs:element name=""ProjectCityName"" type=""SBA_Str40"" />
      <xs:element name=""ProjectStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ProjectStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ProjectStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""ProjectStrtSuffix"" type=""SBA_Str4"" />
      <xs:element name=""ProjectStCd"" type=""SBA_Str2"" />
      <xs:element name=""ProjectZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""ProjectZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PymtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ReconsiderationInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""RequestedAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RevolvingInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""RuralUrbanInd"" type=""SBA_Str1"" />
      <xs:element name=""SBAGntyPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""SBAServicingOffice"" type=""SBA_Num4"" />
      <xs:element minOccurs=""0"" name=""SeprateProcessFeeInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""UnderwritingBy"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""UnderwrtrsFeeAmt"" type=""xs:decimal"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Assistance"">
    <xs:all>
      <xs:element name=""AreaCode"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""AreaDescription"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""BalanceSheet"">
    <xs:all>
      <xs:element name=""BalanceSheetDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AssetCashEqvlntAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AssetNetTrdRecvAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AssetTotInvtryAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AssetOthCurrAmt"" type=""xs:decimal"" />
      <xs:element name=""AssetTotCurrAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AssetTotFixAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AssetTotOthAmt"" type=""xs:decimal"" />
      <xs:element name=""AssetTotAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabAcctsPayblAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabCurrLongTermDebtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabOthCurrAmt"" type=""xs:decimal"" />
      <xs:element name=""LiabTotCurrAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabLongTermDebtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabOthLongTermAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LiabStbyDebtAmt"" type=""xs:decimal"" />
      <xs:element name=""LiabTotAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BusNetWrthAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TngblNetWrthAmt"" type=""xs:decimal"" />
      <xs:element name=""ActlProFormaInd"" type=""SBA_Str1"" />
      <xs:element name=""FinanclStmtSourcCd"" type=""xs:unsignedByte"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Borrower"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AffiliatedInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BorrPhnNmb"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EPCOperatingCompnyCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""ExporterInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiltInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""IntrstOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""MailStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""MailZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""PhysCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element name=""PrimaryBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""BorrowerRace"">
    <xs:all>
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element name=""RaceCd"" type=""xs:unsignedByte"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""BusAppr"">
    <xs:all>
      <xs:element name=""Ind"" type=""SBA_Str3"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""ChangeOfOwnership"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Loan7aPymtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellerFinanFullStbyAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""SellerFinanNonFullStbyAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyCashAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyCashDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyBorrAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyOthAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyOthDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""TotAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AcctRecvAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""InvtryAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ReAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RevalTypInd"" type=""SBA_AppraisedOrBookValue"" />
      <xs:element minOccurs=""0"" name=""EquipAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""EquipValTypInd"" type=""SBA_AppraisedOrBookValue"" />
      <xs:element minOccurs=""0"" name=""FixAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""IntangAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthAssetDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""CovntAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CustAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LicnsAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""FrnchsAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""GoodwillAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthIntangAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthIntangAssetDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""TotApprAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BusApprNm"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""BusApprFeeAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BusBrkrComisnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusBrkrNm"" type=""SBA_Str150"" />
      <xs:element minOccurs=""0"" name=""BusBrkrComisnAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BusBrkrAdr"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Collateral"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""CollateralAppraisalOrderedDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CollateralCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""CollateralCountyCode"" type=""SBA_CountyCode"" />
      <xs:element name=""CollateralDesc"" type=""SBA_Str80"" />
      <xs:element name=""CollateralMrktValuAmt"" type=""xs:decimal"" />
      <xs:element name=""CollateralOwnrRecrd"" type=""SBA_Str20"" />
      <xs:element name=""CollateralSequenceNmb"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CollateralStatus"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CollateralStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""CollateralStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CollateralStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CollateralStrtNameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""CollateralStrtNmb"" type=""SBA_Str30"" />
      <xs:element minOccurs=""0"" name=""CollateralSubtypCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CollateralTitleReportOrderedDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CollateralTitleReportReceivedDt"" type=""xs:string"" />
      <xs:element name=""CollateralTypCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CollateralZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""CollateralZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MrktValuDt"" type=""xs:string"" />
      <xs:element name=""MrktValuSourcCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""SBALienPos"" type=""xs:unsignedByte"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""CollateralLiens"">
    <xs:all>
      <xs:element name=""CollateralSequenceNmb"" type=""xs:unsignedByte"" />
      <xs:element name=""LienBalanceAmt"" type=""xs:decimal"" />
      <xs:element name=""LienHldrName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LienPosition"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""LienComment"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Comments"">
    <xs:all>
      <xs:element name=""CommntTxt"" type=""SBA_MandText"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""CommunityAdvantage"">
    <xs:all>
      <xs:element name=""ExistingBus"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""GrossRevenueSales"" type=""xs:decimal"" />
      <xs:element name=""RcvdAssistanceOrCounseling"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""CounselingHours"">
    <xs:all>
      <xs:element name=""HourCode"" type=""xs:short"" />
      <xs:element name=""TypeCode"" type=""xs:short"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""CounselingSource"">
    <xs:all>
      <xs:element name=""SourceCode"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""SourceDescription"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""CreditUnavailReasons"">
    <xs:all>
      <xs:element name=""CreditUnavailReasonCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CreditUnavailReasonCommnt"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Eligibility"">
    <xs:all>
      <xs:element name=""EligibleCd"" type=""xs:short"" />
      <xs:element name=""EligibleInd"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""FederalEmployee"">
    <xs:all>
      <xs:element name=""AgncyOffice"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""CityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""StCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""StrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""StrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""StrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""StrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""ZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""Zip4Cd"" type=""SBA_Str4"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Guarantor"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AffiliatedInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExporterInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiliatesInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GuaranteeTypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InterestOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""MailStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""MailZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""OperatingCompnyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PhysCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""PhysCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""IncomeStatement"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AnnualIntrstExpenseAmt"" type=""xs:decimal"" />
      <xs:element name=""BeginDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CshflwAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CostOfGoodsSoldAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""DeprctAmortAmt"" type=""xs:decimal"" />
      <xs:element name=""EndDt"" type=""xs:string"" />
      <xs:element name=""FinanclStmtSourcCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""GrossProfitAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""IncomeTaxAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NetIncomeAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NetIncomeBefTaxWthdrlAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NetSalesRevnuAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OperatingProfitAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OwnrSalaryAmt"" type=""xs:decimal"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Indebtedness"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""CollateralDesc"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrBalanceAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""IndebtednessPurpose"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""IntrstRate"" type=""SBA_Dec3v2"" />
      <xs:element minOccurs=""0"" name=""LoanStatusCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""MaturityDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrigntnDt"" type=""xs:string"" />
      <xs:element name=""PayblToName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PymtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""PymtFrequency"" type=""SBA_Str1"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Interest"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AdjustPeriodCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""AdjustPeriodMnths"" type=""SBA_Num3"" />
      <xs:element name=""BaseIntrstRatePct"" type=""SBA_Dec3v3"" />
      <xs:element name=""BaseRateSourcTypCd"" type=""SBA_Str3"" />
      <xs:element name=""BorrIntrstRatePct"" type=""SBA_Dec3v3"" />
      <xs:element name=""IntrstTypInd"" type=""SBA_FixVarInd"" />
      <xs:element name=""Phase"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ShareOfTotalMnths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""ShareOfTotalPct"" type=""SBA_Dec3v3"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Injection"">
    <xs:all>
      <xs:element name=""InjctnAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""InjctnOthDescTxt"" type=""SBA_Str255"" />
      <xs:element name=""InjctnTypCd"" type=""SBA_Str1"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""LoanReasons"">
    <xs:all>
      <xs:element name=""LoanReason"" type=""xs:short"" />
      <xs:element minOccurs=""0"" name=""LoanReasonOthDescTxt"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PartcipatLender"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrAmt"" type=""xs:decimal"" />
      <xs:element name=""LendrName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrPhnNmb"" type=""SBA_Str20"" />
      <xs:element name=""LendrTypCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""LendrCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrLocId"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LendrStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LendrStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LendrStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""LendrStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""LendrStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""LendrZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""LendrZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""LienPosition"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PartnerInformation"">
    <xs:all>
      <xs:element name=""LocationId"" type=""xs:int"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PersonalFinancials"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AnnSalaryAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""BusOwnrshpAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""CredCardDbtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""InstlDbtAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""LqdAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""MnthlyHsngAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""NetWrthAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthAnnIncAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""OthLiabAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RealEstateAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""RealEstateLiabAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ResOwnRentOthInd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""SourcOfOthIncTxt"" type=""SBA_Str20"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""TotAssetAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotLiabAmt"" type=""xs:decimal"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PreviousGovtFinance"">
    <xs:all>
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""0"" name=""CurrBalanceAmt"" type=""xs:decimal"" />
      <xs:element name=""FinancAgencyNm"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""FinancAppvDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FinancLoanNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""LoanStatusCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""OrigBalanceAmt"" type=""xs:decimal"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""Principal"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AffiliatedInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element name=""BusinessTaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EthnicCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiliatesInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GndrCd"" type=""SBA_Str1"" />
      <xs:element name=""GntyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsuranceAmt"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""InsureName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""InterestOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""MailStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""MailZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element name=""OwnrshpInBusinessPct"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PhysCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""PhysCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNameSuffix"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysStrtNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PrimBusExprnceYrNmb"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""VetCd"" type=""xs:unsignedByte"" />
      <xs:element minOccurs=""0"" name=""VetCertInd"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PrincipalRace"">
    <xs:all>
      <xs:element name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element name=""RaceCd"" type=""xs:unsignedByte"" />
      <xs:element name=""TaxId"" type=""SBA_TaxId"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""SpecialPurpose"">
    <xs:all>
      <xs:element name=""SpcPurpsLoanCd"" type=""SBA_Str4"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""UnderservedMarket"">
    <xs:all>
      <xs:element name=""MarketCode"" type=""SBA_Num2"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""UseOfProceeds"">
    <xs:all>
      <xs:element name=""LoanProceedTypCd"" type=""SBA_Str2"" />
      <xs:element name=""ProceedTypCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""ProceedOthTypTxt"" type=""SBA_Str80"" />
      <xs:element name=""ProceedAmt"" type=""xs:decimal"" />
    </xs:all>
    <xs:attribute fixed=""insert"" name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
</xs:schema>";
        
        public SBA_ETran_3_9_orig() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SBA_ETran";
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
