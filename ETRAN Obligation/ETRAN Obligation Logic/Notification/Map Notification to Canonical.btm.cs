namespace SBA.ETRANObligation.Logic.Notification {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationSingle", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationSingle))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Notification_to_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:ns4=""urn:enterprise.soap.sforce.com"" xmlns:etran=""http://ws.elend"" xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/notify1:Notification"" />
  </xsl:template>
  <xsl:template match=""/notify1:Notification"">
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq(&quot;1&quot; , &quot;1&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNot(string($var:v5))"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;Loan__c&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;Loan Obligated&quot;)"" />
    <ns0:Canonical>
      <notify1:Notification>
        <ns1:Id>
          <xsl:value-of select=""ns1:Id/text()"" />
        </ns1:Id>
        <ns1:sObject>
          <xsl:for-each select=""ns1:sObject/ns3:fieldsToNull"">
            <xsl:variable name=""var:v1"" select=""string(./@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v1)='true'"">
              <ns3:fieldsToNull>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:fieldsToNull>
            </xsl:if>
            <xsl:if test=""string($var:v1)='false'"">
              <ns3:fieldsToNull>
                <xsl:value-of select=""./text()"" />
              </ns3:fieldsToNull>
            </xsl:if>
          </xsl:for-each>
          <xsl:variable name=""var:v2"" select=""string(ns1:sObject/ns3:Id/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v2)='true'"">
            <ns3:Id>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns3:Id>
          </xsl:if>
          <xsl:if test=""string($var:v2)='false'"">
            <ns3:Id>
              <xsl:value-of select=""ns1:sObject/ns3:Id/text()"" />
            </ns3:Id>
          </xsl:if>
          <xsl:if test=""ns1:sObject/ns3:Application_Number__c"">
            <xsl:variable name=""var:v3"" select=""string(ns1:sObject/ns3:Application_Number__c/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v3)='true'"">
              <ns3:Application_Number__c>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:Application_Number__c>
            </xsl:if>
            <xsl:if test=""string($var:v3)='false'"">
              <ns3:Application_Number__c>
                <xsl:value-of select=""ns1:sObject/ns3:Application_Number__c/text()"" />
              </ns3:Application_Number__c>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""ns1:sObject/ns3:SObject_ID__c"">
            <xsl:variable name=""var:v4"" select=""string(ns1:sObject/ns3:SObject_ID__c/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v4)='true'"">
              <ns3:SObject_ID__c>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:SObject_ID__c>
            </xsl:if>
            <xsl:if test=""string($var:v4)='false'"">
              <ns3:SObject_ID__c>
                <xsl:value-of select=""ns1:sObject/ns3:SObject_ID__c/text()"" />
              </ns3:SObject_ID__c>
            </xsl:if>
          </xsl:if>
          <xsl:value-of select=""ns1:sObject/text()"" />
        </ns1:sObject>
      </notify1:Notification>
      <xsl:if test=""$var:v6"">
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
      <xsl:if test=""$var:v6"">
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
      <xsl:if test=""$var:v6"">
        <ns0:ETRAN_Originate_App_Defaults>
          <def:LoanApplication>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:InterestStructureCd>
              <xsl:text>F</xsl:text>
            </def:InterestStructureCd>
            <def:NetEarningsClause>
              <xsl:text>N</xsl:text>
            </def:NetEarningsClause>
            <def:RevolvingInd>
              <xsl:text>N</xsl:text>
            </def:RevolvingInd>
          </def:LoanApplication>
          <def:Interest>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:BaseRateSourcTypCd>
              <xsl:text>DSR</xsl:text>
            </def:BaseRateSourcTypCd>
            <def:IntrstTypInd>
              <xsl:text>F</xsl:text>
            </def:IntrstTypInd>
            <def:Phase>
              <xsl:text>1</xsl:text>
            </def:Phase>
          </def:Interest>
          <def:Borrower>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:CreditScorSourcCd>
              <xsl:text>13</xsl:text>
            </def:CreditScorSourcCd>
            <def:PhysCountryCd>
              <xsl:text>US</xsl:text>
            </def:PhysCountryCd>
          </def:Borrower>
          <def:BorrowerRace>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:RaceCd>
              <xsl:text>6</xsl:text>
            </def:RaceCd>
          </def:BorrowerRace>
          <def:Principal>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:EthnicCd>
              <xsl:text>UN</xsl:text>
            </def:EthnicCd>
            <def:ExtrnlCreditScorInd>
              <xsl:text>N</xsl:text>
            </def:ExtrnlCreditScorInd>
            <def:GndrCd>
              <xsl:text>U</xsl:text>
            </def:GndrCd>
            <def:GntyInd>
              <xsl:text>N</xsl:text>
            </def:GntyInd>
            <def:VetCd>
              <xsl:text>5</xsl:text>
            </def:VetCd>
          </def:Principal>
          <def:PrincipalRace>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:RaceCd>
              <xsl:text>6</xsl:text>
            </def:RaceCd>
          </def:PrincipalRace>
          <def:SpecialPurpose>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
          </def:SpecialPurpose>
          <def:UseOfProceeds_Physical>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:LoanProceedTypCd>
              <xsl:text>05</xsl:text>
            </def:LoanProceedTypCd>
            <def:ProceedTypCd>
              <xsl:text>D</xsl:text>
            </def:ProceedTypCd>
          </def:UseOfProceeds_Physical>
          <def:UseOfProceeds_EIDL>
            <xsl:attribute name=""def:action"">
              <xsl:text>insert</xsl:text>
            </xsl:attribute>
            <def:LoanProceedTypCd>
              <xsl:text>04</xsl:text>
            </def:LoanProceedTypCd>
            <def:ProceedTypCd>
              <xsl:text>D</xsl:text>
            </def:ProceedTypCd>
          </def:UseOfProceeds_EIDL>
        </ns0:ETRAN_Originate_App_Defaults>
      </xsl:if>
      <xsl:if test=""$var:v6"">
        <ns0:SBA_ETran_Response />
      </xsl:if>
      <ns0:Event_Request__c>
        <xsl:attribute name=""GUID__c"">
          <xsl:value-of select=""$var:v7"" />
        </xsl:attribute>
        <xsl:if test=""ns1:sObject/ns3:Application_Number__c"">
          <xsl:attribute name=""Application_Number__c"">
            <xsl:value-of select=""ns1:sObject/ns3:Application_Number__c/text()"" />
          </xsl:attribute>
        </xsl:if>
        <xsl:attribute name=""Log_Message__c"">
          <xsl:value-of select=""$var:v7"" />
        </xsl:attribute>
        <xsl:if test=""ns1:sObject/ns3:SObject_ID__c"">
          <xsl:attribute name=""SObject_ID__c"">
            <xsl:value-of select=""ns1:sObject/ns3:SObject_ID__c/text()"" />
          </xsl:attribute>
        </xsl:if>
        <xsl:attribute name=""SObject_Name__c"">
          <xsl:value-of select=""$var:v8"" />
        </xsl:attribute>
        <xsl:attribute name=""Stage__c"">
          <xsl:value-of select=""$var:v9"" />
        </xsl:attribute>
        <xsl:attribute name=""Status__c"">
          <xsl:value-of select=""$var:v7"" />
        </xsl:attribute>
      </ns0:Event_Request__c>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
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
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationSingle";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationSingle _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationSingle";
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
