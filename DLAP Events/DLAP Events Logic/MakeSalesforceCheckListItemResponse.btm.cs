namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse", typeof(global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response))]
    public sealed class MakeSalesforceCheckListItemResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPEventsDocument/Checklist_Item__c"" xmlns:s0=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:Response>
      <xsl:for-each select=""s0:records"">
        <xsl:for-each select=""s0:Checklist_Items__r/s0:records"">
          <ns0:row>
            <ns0:Id>
              <xsl:value-of select=""s0:Id/text()"" />
            </ns0:Id>
            <ns0:Name>
              <xsl:value-of select=""s0:Name/text()"" />
            </ns0:Name>
            <ns0:Case__c>
              <xsl:value-of select=""s0:Case__c/text()"" />
            </ns0:Case__c>
            <ns0:Applicant__c>
              <xsl:value-of select=""s0:Applicant__c/text()"" />
            </ns0:Applicant__c>
            <ns0:Application__c>
              <xsl:value-of select=""s0:Application__c/text()"" />
            </ns0:Application__c>
            <ns0:Checklist_Item_Status__c>
              <xsl:value-of select=""s0:Checklist_Item_Status__c/text()"" />
            </ns0:Checklist_Item_Status__c>
            <ns0:Checklist_Item_Text__c>
              <xsl:value-of select=""s0:Checklist_Item_Text__c/text()"" />
            </ns0:Checklist_Item_Text__c>
            <ns0:Type__c>
              <xsl:value-of select=""s0:Type__c/text()"" />
            </ns0:Type__c>
            <ns0:Verified_Date__c>
              <xsl:value-of select=""s0:Verified_Date__c/text()"" />
            </ns0:Verified_Date__c>
            <ns0:CreatedDate>
              <xsl:value-of select=""s0:CreatedDate/text()"" />
            </ns0:CreatedDate>
            <ns0:Checklist_Item_Due_Date__c>
              <xsl:value-of select=""s0:Checklist_Item_Due_Date__c/text()"" />
            </ns0:Checklist_Item_Due_Date__c>
            <ns0:DocumentType__c>
              <xsl:value-of select=""s0:DocumentType__c/text()"" />
            </ns0:DocumentType__c>
            <ns0:ApplicantExternalId>
              <xsl:value-of select=""s0:Applicant__r/s0:External_ID__c/text()"" />
            </ns0:ApplicantExternalId>
            <ns0:MasterCheckListName>
              <xsl:value-of select=""s0:Master_Checklist__r/s0:Name/text()"" />
            </ns0:MasterCheckListName>
            <ns0:MasterCheckListDescription>
              <xsl:value-of select=""s0:Master_Checklist__r/s0:Checklist_Description__c/text()"" />
            </ns0:MasterCheckListDescription>
          </ns0:row>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Response>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse";
        
        private const global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
                return _TrgSchemas;
            }
        }
    }
}
