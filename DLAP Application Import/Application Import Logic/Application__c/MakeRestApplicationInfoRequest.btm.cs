namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplication", typeof(global::Application_Import_Definition.HomeDisasterLoanApplication))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQuery+Request", typeof(global::Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQuery.Request))]
    public sealed class MakeRestApplicationInfoRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPApplicationImport/REST/Query/Application"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/Application"" />
  </xsl:template>
  <xsl:template match=""/Application"">
    <ns0:Request>
      <ns0:SOQL_APPLICATION_QUERY>
        <xsl:text />
      </ns0:SOQL_APPLICATION_QUERY>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplication";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplication _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQuery+Request";
        
        private const global::Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQuery.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplication";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition.Application__c.RestApplication__c.RestApplicationQuery+Request";
                return _TrgSchemas;
            }
        }
    }
}
