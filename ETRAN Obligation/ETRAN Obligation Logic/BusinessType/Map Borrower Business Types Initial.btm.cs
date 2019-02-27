namespace SBA.ETRANObligation.Logic.BusinessType {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Borrower_Business_Types_Initial : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" 
                xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" 
                xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" 
                exclude-result-prefixes=""msxsl var"" 
                version=""1.0"" 
                xmlns:orgtype=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" 
                xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" 
                xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" 
                xmlns:bus=""http://SBA.gov/ETRANObligation/Borrower/BusinessTypeMapping/"" 
                xmlns:ns4=""urn:enterprise.soap.sforce.com"" 
                xmlns:etran=""http://ws.elend"" 
                xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" 
                xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" 
                xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" 
                xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" 
                xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" 
                xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" indent=""yes"" />
  <xsl:template match=""*"" mode=""copy"">
    <xsl:element name=""{name()}"" namespace=""{namespace-uri()}"">
      <xsl:apply-templates select=""@*|node()"" mode=""copy"" />
    </xsl:element>
  </xsl:template>
  <xsl:template match=""@*|text()|comment()"" mode=""copy"">
    <xsl:copy/>
  </xsl:template>
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Canonical"" />
  </xsl:template>
  <xsl:template match=""/ns0:Canonical"">
    <ns0:Canonical>
      <xsl:apply-templates select=""notify1:Notification"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:Multi"" mode=""copy"" />
      <xsl:variable name=""appRecordType"" select=""ns0:Multi/ns0:QueryResult/multi:records/multi:RecordType/multi:Name/text()"" />
      <xsl:variable name=""isBusinessLoan"" select=""$appRecordType!='Home Loan Application'"" />
      <xsl:variable name=""appOrgType"" select=""ns0:Multi/ns0:QueryResult/multi:records/multi:Org_Type__c/text()"" />
      <xsl:variable name=""isSoleProp"" select=""$isBusinessLoan and $appOrgType='Individual - Sole Prop'"" />
      <xsl:if test=""$isBusinessLoan"">
        <xsl:choose>
          <xsl:when test=""$isSoleProp"">
            <ns0:BorrowerBusinessTypes>
              <xsl:for-each select=""ns0:Multi/ns0:QueryResult/multi:records/multi:Applicants__r/multi:records"">
                <bbt:BorrowerBusinessType>
                  <bbt:ApplicantId>
                    <xsl:value-of select=""multi:Id/text()"" />
                  </bbt:ApplicantId>
                  <orgtype:LegalOrgTypeMapping>
                    <orgtype:SalesforceBusinessType>
                      <xsl:value-of select=""multi:Entity_Type__c/text()"" />
                    </orgtype:SalesforceBusinessType>
                    <orgtype:ETranLegalOrgTypeCode>
                      <xsl:text></xsl:text>
                    </orgtype:ETranLegalOrgTypeCode>
                  </orgtype:LegalOrgTypeMapping>
                </bbt:BorrowerBusinessType>
              </xsl:for-each>
            </ns0:BorrowerBusinessTypes>
          </xsl:when>
          <xsl:when test=""count(ns0:Multi/ns0:QueryResult/multi:records/multi:Applicants__r/multi:records[multi:Account__r/multi:Business_Type__c/text()!=''])>0"">
            <ns0:BorrowerBusinessTypes>
              <xsl:for-each select=""ns0:Multi/ns0:QueryResult/multi:records/multi:Applicants__r/multi:records[multi:Account__r/multi:Business_Type__c/text()!='']"">
                <bbt:BorrowerBusinessType>
                  <bbt:ApplicantId>
                    <xsl:value-of select=""multi:Id/text()"" />
                  </bbt:ApplicantId>
                  <orgtype:LegalOrgTypeMapping>
                    <orgtype:SalesforceBusinessType>
                      <xsl:value-of select=""multi:Account__r/multi:Business_Type__c/text()"" />
                    </orgtype:SalesforceBusinessType>
                    <orgtype:ETranLegalOrgTypeCode>
                      <xsl:text></xsl:text>
                    </orgtype:ETranLegalOrgTypeCode>
                  </orgtype:LegalOrgTypeMapping>
                </bbt:BorrowerBusinessType>
              </xsl:for-each>
            </ns0:BorrowerBusinessTypes>
          </xsl:when>
          <xsl:otherwise />
        </xsl:choose>
      </xsl:if>
      <xsl:apply-templates select=""ns0:ETRAN_Originate_App_Defaults"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:Event_Request__c"" mode=""copy"" />
    </ns0:Canonical>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 1;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
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
