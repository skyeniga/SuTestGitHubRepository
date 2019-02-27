namespace SBA.ETRANObligation.Logic.ETRANOriginate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults", typeof(global::SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_ETRAN_Originate_App_Defaults_To_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:ns4=""urn:enterprise.soap.sforce.com"" xmlns:etran=""http://ws.elend"" xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNot(&quot;true&quot;)"" />
    <ns0:Canonical>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/notify1:Notification"">
        <notify1:Notification>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </notify1:Notification>
      </xsl:for-each>
      <xsl:if test=""$var:v1"">
        <ns0:Multi>
          <ns0:Request>
            <multi:q>
              <xsl:text>SELECT Id, RecordType.Name, Name, Previous_SBA_Loans__c, Loan_Type__c, Org_Type__c, Application_Type__c, Loan_Type2__c, Loss_Type__c, FEMA_Registration_Number__c, (SELECT Id, Interest_Rate__c, Loan_Amount__c, Payment_Amount__c, Secure__c, Servicing_Office__c, Total_Term__c, Disaster_Declaration__c, Disaster_Declaration__r.Name, Disaster_Declaration__r.Disaster_Damaged_Type__c, Disaster_Declaration__r.Physical_Number__c, Disaster_Declaration__r.EIDL_Number__c FROM Loans__r WHERE Id=@LoanId), (SELECT Credit_Elsewhere_Test__c, Physical_Allocated_Amount__c, EIDL_Allocated_Amount__c FROM Processing_Application_Review__r), (SELECT Id, Property_Address__c, City__c, State__c, Zip_Code__c FROM Property__r WHERE Active__c=true), (SELECT Id, RecordType.Name, Name, Primary_Applicant__c, Tax_ID__c, Related_Parent__r.Tax_ID__c, Entity_Type__c, Applicant_Relation_Type__c, Ownership_Percent__c, Borrower_Guarantor__c, Account__r.Id, Account__r.Name, Account__r.Business_Type__c, Account__r.Trade_Name__c, Account__r.Phone, Account__r.Phone_Number__c, Account__r.ShippingStreet, Account__r.ShippingCity, Account__r.ShippingState, Account__r.ShippingPostalCode, Contact__r.Id, Contact__r.Birthdate, Contact__r.Title, Contact__r.FirstName, Contact__r.LastName, Contact__r.MiddleName, Contact__r.Suffix, Contact__r.Phone, Contact__r.MobilePhone, Contact__r.Work_Phone__c, Contact__r.MailingStreet, Contact__r.MailingCity, Contact__r.MailingState, Contact__r.MailingPostalCode FROM Applicants__r WHERE Active__c=true) FROM Application__c WHERE Name=@ApplicationNumber</xsl:text>
            </multi:q>
          </ns0:Request>
          <ns0:QueryResult>
            <multi:done>
              <xsl:text>false</xsl:text>
            </multi:done>
            <multi:records>
              <xsl:attribute name=""type"">
                <xsl:text>Application__c</xsl:text>
              </xsl:attribute>
              <multi:RecordType>
                <xsl:attribute name=""type"">
                  <xsl:text>RecordType</xsl:text>
                </xsl:attribute>
              </multi:RecordType>
              <multi:Loans__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Loan__c</xsl:text>
                  </xsl:attribute>
                  <multi:Disaster_Declaration__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Disaster__c</xsl:text>
                    </xsl:attribute>
                  </multi:Disaster_Declaration__r>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Loans__r>
              <multi:Processing_Application_Review__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Processing_Application_Review__c</xsl:text>
                  </xsl:attribute>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Processing_Application_Review__r>
              <multi:Property__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Property__c</xsl:text>
                  </xsl:attribute>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Property__r>
              <multi:Applicants__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Applicant__c</xsl:text>
                  </xsl:attribute>
                  <multi:RecordType>
                    <xsl:attribute name=""type"">
                      <xsl:text>RecordType</xsl:text>
                    </xsl:attribute>
                  </multi:RecordType>
                  <multi:Related_Parent__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Applicant__c</xsl:text>
                    </xsl:attribute>
                  </multi:Related_Parent__r>
                  <multi:Account__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Account</xsl:text>
                    </xsl:attribute>
                  </multi:Account__r>
                  <multi:Contact__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Contact</xsl:text>
                    </xsl:attribute>
                  </multi:Contact__r>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Applicants__r>
            </multi:records>
            <multi:totalSize>
              <xsl:text>0</xsl:text>
            </multi:totalSize>
          </ns0:QueryResult>
        </ns0:Multi>
      </xsl:if>
      <xsl:if test=""$var:v1"">
        <ns0:BorrowerBusinessTypes>
          <bbt:BorrowerBusinessType>
            <ns2:LegalOrgTypeMapping>
              <ns2:ETranLegalOrgTypeCode>
                <xsl:text>0</xsl:text>
              </ns2:ETranLegalOrgTypeCode>
            </ns2:LegalOrgTypeMapping>
          </bbt:BorrowerBusinessType>
        </ns0:BorrowerBusinessTypes>
      </xsl:if>
      <ns0:ETRAN_Originate_App_Defaults>
        <def:LoanApplication>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:InterestStructureCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/def:InterestStructureCd/text()"" />
          </def:InterestStructureCd>
          <def:NetEarningsClause>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/def:NetEarningsClause/text()"" />
          </def:NetEarningsClause>
          <def:RevolvingInd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/def:RevolvingInd/text()"" />
          </def:RevolvingInd>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:LoanApplication/text()"" />
        </def:LoanApplication>
        <def:Interest>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:BaseRateSourcTypCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/def:BaseRateSourcTypCd/text()"" />
          </def:BaseRateSourcTypCd>
          <def:IntrstTypInd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/def:IntrstTypInd/text()"" />
          </def:IntrstTypInd>
          <def:Phase>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/def:Phase/text()"" />
          </def:Phase>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Interest/text()"" />
        </def:Interest>
        <def:Borrower>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Borrower/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Borrower/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:CreditScorSourcCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Borrower/def:CreditScorSourcCd/text()"" />
          </def:CreditScorSourcCd>
          <def:PhysCountryCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Borrower/def:PhysCountryCd/text()"" />
          </def:PhysCountryCd>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Borrower/text()"" />
        </def:Borrower>
        <def:BorrowerRace>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:BorrowerRace/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:BorrowerRace/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:RaceCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:BorrowerRace/def:RaceCd/text()"" />
          </def:RaceCd>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:BorrowerRace/text()"" />
        </def:BorrowerRace>
        <def:Principal>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:EthnicCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/def:EthnicCd/text()"" />
          </def:EthnicCd>
          <def:ExtrnlCreditScorInd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/def:ExtrnlCreditScorInd/text()"" />
          </def:ExtrnlCreditScorInd>
          <def:GndrCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/def:GndrCd/text()"" />
          </def:GndrCd>
          <def:GntyInd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/def:GntyInd/text()"" />
          </def:GntyInd>
          <def:VetCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/def:VetCd/text()"" />
          </def:VetCd>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:Principal/text()"" />
        </def:Principal>
        <def:PrincipalRace>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:PrincipalRace/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:PrincipalRace/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:RaceCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:PrincipalRace/def:RaceCd/text()"" />
          </def:RaceCd>
          <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:PrincipalRace/text()"" />
        </def:PrincipalRace>
        <def:SpecialPurpose>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:SpecialPurpose/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:SpecialPurpose/@def:action"" />
            </xsl:attribute>
          </xsl:if>
        </def:SpecialPurpose>
        <def:UseOfProceeds_Physical>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_Physical/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_Physical/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:LoanProceedTypCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_Physical/def:LoanProceedTypCd/text()"" />
          </def:LoanProceedTypCd>
          <def:ProceedTypCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_Physical/def:ProceedTypCd/text()"" />
          </def:ProceedTypCd>
        </def:UseOfProceeds_Physical>
        <def:UseOfProceeds_EIDL>
          <xsl:if test=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_EIDL/@def:action"">
            <xsl:attribute name=""def:action"">
              <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_EIDL/@def:action"" />
            </xsl:attribute>
          </xsl:if>
          <def:LoanProceedTypCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_EIDL/def:LoanProceedTypCd/text()"" />
          </def:LoanProceedTypCd>
          <def:ProceedTypCd>
            <xsl:value-of select=""InputMessagePart_1/def:ETRAN_Originate_App_Defaults/def:UseOfProceeds_EIDL/def:ProceedTypCd/text()"" />
          </def:ProceedTypCd>
        </def:UseOfProceeds_EIDL>
      </ns0:ETRAN_Originate_App_Defaults>
      <xsl:if test=""$var:v1"">
        <ns0:SBA_ETran_Response />
      </xsl:if>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Event_Request__c"">
        <ns0:Event_Request__c>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:Event_Request__c>
      </xsl:for-each>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.ETRAN_Originate.ETRANOriginateAppDefaults";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _TrgSchemas;
            }
        }
    }
}
