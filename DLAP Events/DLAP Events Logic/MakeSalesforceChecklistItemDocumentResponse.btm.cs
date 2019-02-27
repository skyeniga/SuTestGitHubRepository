namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+QueryResult", typeof(global::DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response))]
    public sealed class MakeSalesforceChecklistItemDocumentResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/REST/Query/DLAPEvents/DocumentsDetailsRequestResponse"" xmlns:ns0=""http://SBA.gov/DLAPEvents/ContentVersion__c"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:Response>
      <xsl:for-each select=""s0:records"">
        <ns0:row>
          <ns0:Title>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:Title/text()"" />
          </ns0:Title>
          <ns0:Description>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:Description/text()"" />
          </ns0:Description>
          <ns0:Document_Type__c>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:Document_Type__c/text()"" />
          </ns0:Document_Type__c>
          <ns0:CreatedDate>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:CreatedDate/text()"" />
          </ns0:CreatedDate>
          <ns0:Id>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:Id/text()"" />
          </ns0:Id>
          <ns0:ContentDocumentId>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:Id/text()"" />
          </ns0:ContentDocumentId>
          <ns0:DLAP_Document_Type__c>
            <xsl:value-of select=""s0:ContentDocument/s0:LatestPublishedVersion/s0:DLAP_Document_Type__c/text()"" />
          </ns0:DLAP_Document_Type__c>
        </ns0:row>
      </xsl:for-each>
    </ns0:Response>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+QueryResult";
        
        private const global::DLAPEventsSalesforceDefinition.RestDocument.RequestResponse.QueryResult _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c.Response _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.RestDocument.RequestResponse+QueryResult";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.SalesforceQuery_ContentVersion__c+Response";
                return _TrgSchemas;
            }
        }
    }
}
