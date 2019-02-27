namespace DLAPDocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentListDefinition.DocumentListRequest", typeof(global::DocumentListDefinition.DocumentListRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+Request", typeof(global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request))]
    public sealed class MakeRestApplicationInfoRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentList/DocumentListRequest"" xmlns:ns0=""http://SBA.gov/REST/Query/DLAPDocumentList/ApplicationInfo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DocumentListRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:DocumentListRequest"">
    <ns0:Request>
      <ns0:ApplicationNumber>
        <xsl:text />
      </ns0:ApplicationNumber>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DocumentListDefinition.DocumentListRequest";
        
        private const global::DocumentListDefinition.DocumentListRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+Request";
        
        private const global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DocumentListDefinition.DocumentListRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.RestApplicationInfoRequestResponse+Request";
                return _TrgSchemas;
            }
        }
    }
}
