namespace SBA.ETRANObligation.Logic.Multi {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.Request))]
    public sealed class Map_Multi_Query_Request : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s6 s5 s9 s1 s2 s3 s7 s4 s8"" version=""1.0"" xmlns:s7=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:s0=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:s6=""http://soap.sforce.com/2005/09/outbound"" xmlns:s5=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:s9=""urn:enterprise.soap.sforce.com"" xmlns:s1=""http://ws.elend"" xmlns:s4=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s2=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:s3=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:s8=""urn:sobject.enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s5:Canonical"" />
  </xsl:template>
  <xsl:template match=""/s5:Canonical"">
    <ns0:Request>
      <ns0:q>
        <xsl:text>SELECT Id, RecordType.Name, Name, Previous_SBA_Loans__c, Loan_Type__c, Org_Type__c, Application_Type__c, Loan_Type2__c, Loss_Type__c, FEMA_Registration_Number__c, (SELECT Id, Interest_Rate__c, Loan_Amount__c, Payment_Amount__c, Secure__c, Servicing_Office__c, Total_Term__c, Disaster_Declaration__c, Disaster_Declaration__r.Name, Disaster_Declaration__r.Disaster_Damaged_Type__c, Disaster_Declaration__r.Physical_Number__c, Disaster_Declaration__r.EIDL_Number__c FROM Loans__r WHERE Id=@LoanId), (SELECT Credit_Elsewhere_Test__c, Physical_Allocated_Amount__c, EIDL_Allocated_Amount__c FROM Processing_Application_Review__r), (SELECT Id, Property_Address__c, City__c, State__c, Zip_Code__c FROM Property__r WHERE Active__c=true), (SELECT Id, RecordType.Name, Name, Primary_Applicant__c, Tax_ID__c, Related_Parent__r.Tax_ID__c, Entity_Type__c, Applicant_Relation_Type__c, Ownership_Percent__c, Borrower_Guarantor__c, Account__r.Id, Account__r.Name, Account__r.Business_Type__c, Account__r.Trade_Name__c, Account__r.Phone, Account__r.Phone_Number__c, Account__r.ShippingStreet, Account__r.ShippingCity, Account__r.ShippingState, Account__r.ShippingPostalCode, Contact__r.Id, Contact__r.Birthdate, Contact__r.Title, Contact__r.FirstName, Contact__r.LastName, Contact__r.MiddleName, Contact__r.Suffix, Contact__r.Phone, Contact__r.MobilePhone, Contact__r.Work_Phone__c, Contact__r.MailingStreet, Contact__r.MailingCity, Contact__r.MailingState, Contact__r.MailingPostalCode FROM Applicants__r WHERE Active__c=true) FROM Application__c WHERE Name=@ApplicationNumber</xsl:text>
      </ns0:q>
      <xsl:if test=""s0:Notification/s6:sObject/s8:Application_Number__c"">
        <ns0:ApplicationNumber>
          <xsl:value-of select=""s0:Notification/s6:sObject/s8:Application_Number__c/text()"" />
        </ns0:ApplicationNumber>
      </xsl:if>
      <xsl:if test=""s0:Notification/s6:sObject/s8:SObject_ID__c"">
        <ns0:LoanId>
          <xsl:value-of select=""s0:Notification/s6:sObject/s8:SObject_ID__c/text()"" />
        </ns0:LoanId>
      </xsl:if>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.Request _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request";
                return _TrgSchemas;
            }
        }
    }
}
