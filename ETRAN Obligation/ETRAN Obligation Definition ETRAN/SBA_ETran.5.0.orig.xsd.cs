namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"SBA_ETran")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "environment", XPath = @"/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='environment' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "reason", XPath = @"/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='reason' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "version", XPath = @"/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='version' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SBA_ETran"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes))]
    public sealed class SBA_ETran_5_0_orig : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:xhtml=""http://www.w3.org/1999/xhtml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_ETranTypes"" />
  <xs:include schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBA_SimpleTypes"" />
  <xs:annotation>
    <xs:documentation>
      <xhtml:h1 xmlns:xhtml=""http://www.w3.org/1999/xhtml"">XSD for SBA_ETran 5.0, Origination. Publication Date: 12/12/2016. </xhtml:h1>
      <xhtml:h2 xmlns:xhtml=""http://www.w3.org/1999/xhtml"">General Information</xhtml:h2>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				The following XSD documents &lt;SBA_ETran version=""5.0""&gt; and its subelements for the 
				Originate3, OrigScore, OrigUpdate and Underwriting web service methods. 
				(OrigBypass doesn't allow XML changes.) 
			</xhtml:p>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				When creating a new loan application (Originate3 and OrigScore), missing elements are treated as 
				having no value (also known as null or nullstring). 
			</xhtml:p>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				But when updating an existing loan application (OrigUpdate and Underwriting), missing elements are 
				treated as requiring no change from the existing data already received by the SBA. 
				This is true both at the group level and individual data element level. 
				For example, if no special purpose changes are needed, it is not necessary to give any &lt;SpecialPurpose&gt; 
				elements at all, even though one would normally need to give at least NOSP when creating a new application. 
				When updating an existing loan application, the absence of &lt;SpecialPurpose&gt; elements simply means 
				that none of them changed. 
			</xhtml:p>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				For this reason, LoanApplication, Borrower, Interest, Principal, PrincipalRace, SpecialPurpose and 
				UseOfProceeds are now all identified as optional (minOccurs=""0""). 
				But the need to give these elements when creating a new application is the same as always. 
			</xhtml:p>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				Except for elements used as prime keys to identify which data entity is to be updated, 
				and except for ProcessingMethodCd, LocationId and changing UnderwritingBy from SBA back to LNDR, 
				any element that a submitter has role and permissions to give when creating a new application, 
				that same element can also be updated using version 4.0 or 5.0. 
				Versions 4.0 and 5.0 give OrigUpdate and Underwriting the same full updating capability that the SBA web pages have. 
			</xhtml:p>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				Specifics about the few elements that remain unchangable when updating an existing application 
				are given in the XML comments that immediately follow those elements in this XSD. 
			</xhtml:p>
      <xhtml:h2 xmlns:xhtml=""http://www.w3.org/1999/xhtml"">New Predeletion Feature when Updating an Existing App (action=""deleteall"")</xhtml:h2>
      <xhtml:p xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				It may not be possible for some users of OrigUpdate or Underwriting to completely track what changes have been made to an application. 
				In such situations, and for some complexTypes, it may be possible to ""predelete"" all data associated with a complexType 
				and simply re-insert the elements as they are now, starting over from scratch. 
				When updating an existing app, versions 4.0 and 5.0 now allow the first action attribute of some complexTypes to be ""deleteall"", 
				provided that all subsequent action attributes of the same complexType are ""insert"". 
				In database jargon, this is sometimes referred to as ""delete-and-insert logic"". 
				For example: 
			</xhtml:p>
      <xhtml:ul xmlns:xhtml=""http://www.w3.org/1999/xhtml"">
				&lt;SpecialPurpose action=""deleteall""/&gt;
				<xhtml:br />
				&lt;SpecialPurpose action=""insert""&gt;&lt;SpcPurpsLoanCd&gt;ITRD&lt;/SpcPurpsLoanCd&gt;&lt;/SpecialPurpose&gt;
				<xhtml:br />
				&lt;SpecialPurpose action=""insert""&gt;&lt;SpcPurpsLoanCd&gt;REVL&lt;/SpcPurpsLoanCd&gt;&lt;/SpecialPurpose&gt;
			</xhtml:ul>
      <xhtml:p>
				In this example, it's guaranteed that all pre-existing SpecialPurpose data will have already been deleted at the time the inserts are saved. 
				There are pros and cons to using delete-and-insert logic, of course. 
				The pros are eliminating the need to track what already exists on the SBA's Origination database 
				and no longer having to individually delete no-longer-applicable data. 
				The cons are having to re-insert data that had already been inserted 
				and having a larger XML file size as a result. 
			</xhtml:p>
      <xhtml:p>
				This exact pattern above (""deleteall"" first, all the rest ""insert"") 
				is the <xhtml:em>only</xhtml:em> way the predeletion feature can function properly. 
				For this reason, it's not good enough for ""deleteall"" to be allowed by the xs:attribute's type for the action. 
				It must also be used only in the first occurrence of the complexType within the ""App"", following the pattern above. 
				Otherwise, the predeletion feature is disabled (for that complexType) and all the old rules for updating an existing app apply 
				(the prime key must exist for ""delete"" and ""update"" or must not exist for ""insert"", if allowed by the type). 
			</xhtml:p>
      <xhtml:p>
				Not all complexTypes support action=""deleteall"". 
				For this reason, be sure to read the comments associated with the action attributes below. 
				Alternatively, be sure you have the most current version of SBA_ETranTypes.xsd 
				and look there to see whether or not ""deleteall"" is enumerated for the action's type. 
			</xhtml:p>
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""SBA_ETran"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='environment' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='reason' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SBA_ETran' and namespace-uri()='']/@*[local-name()='version' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""App"" type=""SBA_LoanApplication"">
          <xs:annotation>
            <xs:documentation>
              <xhtml:p>
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
      <xs:attribute name=""environment"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>
            <xhtml:p>
							ExtractOrigination may optionally generate this attribute. 
							It is ignored by Originate3, OrigScore, OrigUpdate and Underwriting. 
							It is defined in the XSD solely to prevent validating parser errors. 
						</xhtml:p>
          </xs:documentation>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""reason"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>
            <xhtml:p>
							ExtractOrigination may optionally generate this attribute. 
							It is ignored by Originate3, OrigScore, OrigUpdate and Underwriting. 
							It is defined in the XSD solely to prevent validating parser errors. 
						</xhtml:p>
          </xs:documentation>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""version"" type=""SBA_ETranVersions"">
        <xs:annotation>
          <xs:documentation>
            <xhtml:p>
							Your ""root tag"" should be &lt;SBA_ETran version=""5.0""&gt; 
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
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LoanApplication"" type=""LoanApplication"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Assistance"" type=""Assistance"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BalanceSheet"" type=""BalanceSheet"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Borrower"" type=""Borrower"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BorrowerRace"" type=""BorrowerRace"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BusAppr"" type=""BusAppr"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ChangeOfOwnership"" type=""ChangeOfOwnership"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Collateral"" type=""Collateral"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CollateralGuars"" type=""CollateralGuars"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CollateralLiens"" type=""CollateralLiens"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Comments"" type=""Comments"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CommunityAdvantage"" type=""CommunityAdvantage"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CounselingHours"" type=""CounselingHours"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CounselingSource"" type=""CounselingSource"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CreditUnavailReasons"" type=""CreditUnavailReasons"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Eligibility"" type=""Eligibility"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FederalEmployee"" type=""FederalEmployee"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Guarantor"" type=""Guarantor"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IncomeStatement"" type=""IncomeStatement"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Indebtedness"" type=""Indebtedness"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Injection"" type=""Injection"" />
      <xs:element minOccurs=""0"" maxOccurs=""2"" name=""Interest"" type=""Interest"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LoanReasons"" type=""LoanReasons"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PartcipatLender"" type=""PartcipatLender"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PartnerInformation"" type=""PartnerInformation"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PersonalFinancials"" type=""PersonalFinancials"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PreviousGovtFinance"" type=""PreviousGovtFinance"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Principal"" type=""Principal"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PrincipalRace"" type=""PrincipalRace"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SpecialPurpose"" type=""SpecialPurpose"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""StandbyAgreement"" type=""StandbyAgreement"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UnderservedMarket"" type=""UnderservedMarket"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UseOfProceeds"" type=""UseOfProceeds"" />
    </xs:choice>
    <xs:attribute name=""number"" type=""xs:positiveInteger"" />
  </xs:complexType>
  <xs:complexType name=""LoanApplication"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""AgentInvolved"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BorrowerContribPct"" type=""SBA_Dec3v2"" />
      <xs:element minOccurs=""0"" name=""BorrowerContribAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusinessAgeCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""ClosingCostAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""CollateralInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrEmpQty"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""DisasterCntrlNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""DisasterApplicNmb"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EconDevObjctCd"" type=""SBA_Str3"" />
      <xs:element minOccurs=""0"" name=""EligPassiveCompanyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EWCPPostShipmntInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EWCPSnglTransInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""FrnchiseDeferPymtInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseDeferPymtMonths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""FrnchiseInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""FrnchiseOpporCureInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiserBooksInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FrnchiseWarnTermInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FullAmortPymtInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FundingFeeAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""GntyFeeAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""InterestStructureCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""InjectionInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""JobsCreatdQty"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""JobsRetaindQty"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""JobRqmtMetInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LenderApplicNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LenderCntctEmail"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""LenderCntctFax"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LenderCntctFirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LenderCntctLastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LenderCntctMiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""LenderCntctNameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""LenderCntctPhnNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LenderCntctTitl"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LenderLoanNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LifeInsurRqmtInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LimitCompensationInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LimitCompensationAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LimitExemptionInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LimitFixedAssetInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LimitFixedAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LimitLocation"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LiquidCreditScore"" type=""SBA_Str3"" />
      <xs:element minOccurs=""0"" name=""LoanName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanPackageSourcTypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerName"" type=""SBA_Str150"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""LoanPackagerZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""LoanTermMnths"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""LoanTermStartTypInd"" type=""SBA_TermStartType"" />
      <xs:element minOccurs=""0"" name=""MnthsIntrstOnlyQty"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""NAICSCd"" type=""SBA_Num6"" />
      <xs:element minOccurs=""0"" name=""NetDebentrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""NetEarningsClause"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""NetExprtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OutPrgrmAreaOfOperInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""OverallPortfolioJobRatio"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""ProcessingFeeAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ProcessingMethodCd"" type=""SBA_Str3"" />
      <xs:element minOccurs=""0"" name=""ProjectCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""ProjectStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ProjectStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ProjectStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""ProjectZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""ProjectZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PymtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PymtCeilingAndFloorCode"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""PymtCeilingMaxPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""PymtEscrowInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PymtFloorMinPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""PymtFrequency"" type=""SBA_FreqCode"" />
      <xs:element minOccurs=""0"" name=""PymtIntOnlyDayOfMonth"" type=""SBA_Num2"" />
      <xs:element minOccurs=""0"" name=""PymtIntOnlyFreqCode"" type=""SBA_FreqCode"" />
      <xs:element minOccurs=""0"" name=""PymtIntOnlySkipMonths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""PymtIntRateDeductionInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PymtIntRateProgramOther"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PymtLateChargeInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PymtLateChargeDays"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""PymtLateChargePct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""PymtNetEarnPrepayAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PymtNetEarnPrepayPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""PymtNetEarnRecaptureInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PymtPrinAndIntDayOfMonth"" type=""SBA_Num2"" />
      <xs:element minOccurs=""0"" name=""PymtPrinAndIntSkipMonths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""PymtSchedule"" type=""SBA_FreqSchedule"" />
      <xs:element minOccurs=""0"" name=""PymtTypeCode"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""ReconsiderationInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""RequestedAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RevolvingInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""RuralUrbanInd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""SBAGntyPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""SBAServicingOffice"" type=""SBA_Num4"" />
      <xs:element minOccurs=""0"" name=""SeprateProcessFeeInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""StateLawComplianceForBulkInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""UnderwritingBy"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""UnderwrtrsFeeAmt"" type=""SBA_Money"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertOrUpdateIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Assistance"">
    <xs:all>
      <xs:element name=""AreaCode"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""AreaDescription"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""BalanceSheet"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""BalanceSheetDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AssetCashEqvlntAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetNetTrdRecvAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetTotInvtryAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetOthCurrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetTotCurrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetTotFixAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetTotOthAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AssetTotAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabAcctsPayblAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabCurrLongTermDebtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabOthCurrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabTotCurrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabLongTermDebtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabOthLongTermAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabStbyDebtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LiabTotAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusNetWrthAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""TngblNetWrthAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ActlProFormaInd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""FinanclStmtSourcCd"" type=""SBA_Num3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Borrower"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BooksToLenderType"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""BooksToLenderWithinDays"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ControlInterestType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditReport"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CreditScore"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EPCOperatingCompnyCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""ExporterInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiltInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""IntrstOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurLiabInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurLiabProductInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurLiquorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurMalpracticeInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurOtherInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsurOtherDesc"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""MailZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PaymentsLessThanCCInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""PhysCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PrimaryBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""BorrowerRace"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""1"" name=""RaceCd"" type=""SBA_MandNum3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""BusAppr"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Ind"" type=""SBA_Str3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""ChangeOfOwnership"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""Loan7aPymtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""SellerFinanFullStbyAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""SellerFinanNonFullStbyAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyCashAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyCashDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyBorrAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyOthAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BuyerEqtyOthDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""TotAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""AcctRecvAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""InvtryAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ReAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RevalTypInd"" type=""SBA_AppraisedOrBookValue"" />
      <xs:element minOccurs=""0"" name=""EquipAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""EquipValTypInd"" type=""SBA_AppraisedOrBookValue"" />
      <xs:element minOccurs=""0"" name=""FixAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""IntangAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthAssetDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""CovntAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""CustAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LicnsAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""FrnchsAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""GoodwillAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthIntangAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthIntangAssetDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""TotApprAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusApprNm"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""BusApprFeeAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusBrkrComisnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusBrkrNm"" type=""SBA_Str150"" />
      <xs:element minOccurs=""0"" name=""BusBrkrComisnAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusBrkrAdr"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Collateral"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CollateralSequenceNmb"" type=""SBA_MandNum3"" />
      <xs:element minOccurs=""0"" name=""ALTATitleInsuredInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ApprCode"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""ApprOrderedDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CDCDeedInEscrowInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""CommRealEnvInvMustBeApprInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CountyCode"" type=""SBA_CountyCode"" />
      <xs:element minOccurs=""0"" name=""DescriptionTxt"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""InsFloodInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsMarineFullInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsPerPropHazInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsRealEstHazInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InstrumentTypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LandlordWaiverInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LeaseTermOverLoanYrNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LessorTermNoticeDaysNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LienLimitedAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LienOnLiqLicInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LocationTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""MadeYr"" type=""SBA_Year"" />
      <xs:element minOccurs=""0"" name=""MakeName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""MrktValuAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""MrktValuDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""MrktValuSourcCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""OnLeasedPremCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""OnLeasedPremExtraYrNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""NoteSecuredInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""OtherPropertyTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""OwedToSellerAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OwnrRecrd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PariPassuAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PariPassuLenderName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""PriorAsgnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PriorAsgnLimitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PriorAsgnTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""PriorLienLimitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PriorLienTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""PropertyAcqWithLoanInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PropertyTypTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""PurchaserName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""RentAsgnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""SecurityAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""SecurityDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""SecurityDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""SecurityOwnrName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""SellerIntDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""SellerIntTypInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""SellerName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""SharedPariPassuInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""SharedPariPassuNonSBAInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""StatusCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""StCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""StockSharesNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""StrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""StrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""SubtypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""TitlePriorLienInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""TitleReportOrderedDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TitleReportReceivedDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""WaterRightsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""Zip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""SBALienPos"" type=""SBA_Num3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CollateralGuars"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CollateralSequenceNmb"" type=""SBA_MandNum3"" />
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CollateralLiens"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CollateralSequenceNmb"" type=""SBA_MandNum3"" />
      <xs:element minOccurs=""0"" name=""LienSequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LienBalanceAmt"" type=""SBA_Money"" />
      <xs:element name=""LienHldrName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LienPosition"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""LienComment"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Comments"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CommntTxt"" type=""SBA_MandText"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CommunityAdvantage"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""ExistingBus"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""GrossRevenueSales"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RcvdAssistanceOrCounseling"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CounselingHours"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""TypeCode"" type=""SBA_MandNum"" />
      <xs:element minOccurs=""0"" name=""HourCode"" type=""SBA_Num"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CounselingSource"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""SourceCode"" type=""SBA_MandNum"" />
      <xs:element minOccurs=""0"" name=""SourceDescription"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""CreditUnavailReasons"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""CreditUnavailReasonCd"" type=""SBA_MandNum3"" />
      <xs:element minOccurs=""0"" name=""CreditUnavailReasonCommnt"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Eligibility"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""EligibleCd"" type=""SBA_MandNum"" />
      <xs:element minOccurs=""0"" name=""EligibleInd"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""FederalEmployee"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""SequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""AgncyOffice"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""CityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""StCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""StrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""StrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""Zip4Cd"" type=""SBA_Str4"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Guarantor"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExporterInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiltInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GntyLimitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""GntyLimitCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitCollatSeqNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitYrNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyTypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""IntrstOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
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
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""IncomeStatement"">
    <xs:all>
      <xs:element name=""BeginDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AnnualIntrstExpenseAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""CshflwAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""CostOfGoodsSoldAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""DeprctAmortAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""EndDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FinanclStmtSourcCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GrossProfitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""IncomeTaxAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""NetIncomeAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""NetIncomeBefTaxWthdrlAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""NetSalesRevnuAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OperatingProfitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OwnrSalaryAmt"" type=""SBA_Money"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Indebtedness"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""SequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""CollateralDesc"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrBalanceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""IndebtednessPurpose"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""IntrstRate"" type=""SBA_Dec3v2"" />
      <xs:element minOccurs=""0"" name=""LoanStatusCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""MaturityDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrigntnDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PayblToName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PymtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PymtFrequency"" type=""SBA_Str1"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Injection"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""InjctnTypCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""InjctnAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""InjctnOthDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""InjctnTermNotLessThanYrNmb"" type=""SBA_Num3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Interest"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""Phase"" type=""SBA_Num1"" />
      <xs:element minOccurs=""0"" name=""AdjustPeriodCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""AdjustPeriodMnths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""BaseIntrstRatePct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""BaseRateSourcTypCd"" type=""SBA_Str3"" />
      <xs:element minOccurs=""0"" name=""BorrIntrstRatePct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""IntrstTypInd"" type=""SBA_FixVarInd"" />
      <xs:element minOccurs=""0"" name=""ShareOfTotalMnths"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""ShareOfTotalPct"" type=""SBA_Dec3v3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""LoanReasons"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""LoanReason"" type=""SBA_MandNum"" />
      <xs:element minOccurs=""0"" name=""LoanReasonOthDescTxt"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""PartcipatLender"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""SequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""GrossBalanceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""GrossInterestPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrAmt"" type=""SBA_Money"" />
      <xs:element name=""LendrName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrPhnNmb"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""LendrServFeePct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""LendrTaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""LendrTypCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""LendrCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LendrLocId"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LendrStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LendrStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""LendrStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""LendrZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""LendrZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""LienPosition"" type=""SBA_Num5"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""PartnerInformation"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""LocationId"" type=""SBA_MandNum"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionInsertOnly"" />
  </xs:complexType>
  <xs:complexType name=""PersonalFinancials"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""AnnSalaryAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""BusOwnrshpAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""CredCardDbtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""InstlDbtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""LqdAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""MnthlyHsngAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""NetWrthAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthAnnIncAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""OthLiabAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RealEstateAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RealEstateLiabAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ResOwnRentOthInd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""SourcOfOthIncTxt"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""TotAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""TotLiabAmt"" type=""SBA_Money"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""PreviousGovtFinance"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""SequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""CurrBalanceAmt"" type=""SBA_Money"" />
      <xs:element name=""FinancAgencyNm"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""FinancAppvDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FinancLoanNmb"" type=""SBA_Str10"" />
      <xs:element minOccurs=""0"" name=""LoanStatusCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""OrigBalanceAmt"" type=""SBA_Money"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""Principal"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""1"" name=""BusinessTaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""0"" name=""AlienRgstrtnNmb"" type=""SBA_Str12"" />
      <xs:element minOccurs=""0"" name=""BirthDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""BirthCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BirthStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""BirthCntryName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""BnkrptcyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""BusDUNSNmb"" type=""SBA_Num9"" />
      <xs:element minOccurs=""0"" name=""BusinessName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""ChkngAcctBalanceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ControlInterestType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ConvictdInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CreditReport"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CreditScore"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""CreditScorSourcCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""CrmnlOffnsInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""CurrBankName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""CurrOwnrshpEstblshDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EINCertInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""EthnicCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""ExporterInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""ExtrnlCreditScorNmb"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""FedEmplyAffiltInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""FirstName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""FngrprntWaivDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""GndrCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""GntyInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""GntyTypCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""GntyLimitPct"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitCollatSeqNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""GntyLimitYrNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""IndctPrleProbatnInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsuranceAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""InsuranceDisabInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsuranceLifeInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""InsureDisabNames"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""InsureName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""IntrstOthBusinessInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LastName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""LawsuitInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""LegalOrgnztnCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""LiquidCreditScore"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""MailCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""MailCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""MailStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""MailStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""MailStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""MailZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""MailZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""MiddleInitial"" type=""SBA_Str1"" />
      <xs:element minOccurs=""0"" name=""NameSuffix"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""NoNCAInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""NoNCACompetitorName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""OwnrshpInBusinessPct"" type=""SBA_Num"" />
      <xs:element minOccurs=""0"" name=""PhysCityName"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""PhysCountryCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysPostalCd"" type=""SBA_Str20"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName1"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStrtName2"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PhysStCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""PhysStNm"" type=""SBA_Str60"" />
      <xs:element minOccurs=""0"" name=""PhysZipCd"" type=""SBA_Str5"" />
      <xs:element minOccurs=""0"" name=""PhysZip4Cd"" type=""SBA_Str4"" />
      <xs:element minOccurs=""0"" name=""PrimaryPhone"" type=""SBA_Num10"" />
      <xs:element minOccurs=""0"" name=""PrimBusExprnceYrNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""PriorSBALoanInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""Title"" type=""SBA_Str40"" />
      <xs:element minOccurs=""0"" name=""TradeName"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""USCitznInd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""VetCd"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""VetCertInd"" type=""SBA_YesNoInd"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""PrincipalRace"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""BusinessPersonInd"" type=""SBA_BusPerInd"" />
      <xs:element minOccurs=""1"" name=""TaxId"" type=""SBA_TaxId"" />
      <xs:element minOccurs=""1"" name=""RaceCd"" type=""SBA_MandNum3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""SpecialPurpose"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""SpcPurpsLoanCd"" type=""SBA_Str4"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""StandbyAgreement"">
    <xs:all>
      <xs:element minOccurs=""0"" name=""SequenceNmb"" type=""SBA_Num3"" />
      <xs:element minOccurs=""0"" name=""BeginDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CreditorName"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""PymtAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RepayAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""RepayAPR"" type=""SBA_Dec3v3"" />
      <xs:element minOccurs=""0"" name=""RepayOtherDesc"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""RepayTypeCd"" type=""SBA_Num3"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""UnderservedMarket"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""MarketCode"" type=""SBA_Num2"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"" />
  </xs:complexType>
  <xs:complexType name=""UseOfProceeds"">
    <xs:all>
      <xs:element minOccurs=""1"" name=""ProceedTypCd"" type=""SBA_Str1"" />
      <xs:element minOccurs=""1"" name=""LoanProceedTypCd"" type=""SBA_Str2"" />
      <xs:element minOccurs=""0"" name=""ProceedAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""ProceedOthTypTxt"" type=""SBA_Str80"" />
      <xs:element minOccurs=""0"" name=""PurchaseAgrmtDt"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PurchaseAgrmtNCAInd"" type=""SBA_YesNoInd"" />
      <xs:element minOccurs=""0"" name=""PurchaseIntngblAssetAmt"" type=""SBA_Money"" />
      <xs:element minOccurs=""0"" name=""PurchaseIntngblAssetDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""RefDescTxt"" type=""SBA_Str255"" />
      <xs:element minOccurs=""0"" name=""StockholderName"" type=""SBA_Str255"" />
    </xs:all>
    <xs:attribute name=""action"" type=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"" />
  </xs:complexType>
</xs:schema>";
        
        public SBA_ETran_5_0_orig() {
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
