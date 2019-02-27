namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupResponse", typeof(global::Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup.table))]
    public sealed class MakeSalesforceDisasterLookupResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://sba-oda/DLAP/DisasterLookup"" xmlns:s0=""https://SBA.gov/REST/Query/DLAPApplicationImport/RestDisasterLookupResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:table>
      <ns0:row>
        <xsl:for-each select=""s0:records"">
          <ns0:Id>
            <xsl:value-of select=""s0:Id/text()"" />
          </ns0:Id>
        </xsl:for-each>
      </ns0:row>
    </ns0:table>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupResponse";
        
        private const global::Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup.table _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Salesforce_Application_Import_Definition.Application__c.RestDisaster__c.RestDisasterLookupResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDisasterLookup+table";
                return _TrgSchemas;
            }
        }
    }
}
