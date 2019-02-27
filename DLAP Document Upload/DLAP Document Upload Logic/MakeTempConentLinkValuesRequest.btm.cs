namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+QueryResult", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.DLAPDocumentUpload.Definition.ContentLinkRequestInfo", typeof(global::SBA.DLAPDocumentUpload.Definition.ContentLinkRequestInfo))]
    public sealed class MakeTempConentLinkValuesRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestContentVersion"" xmlns:ns0=""http://DocumentUploadDefinition/ContentLinkRequestInfo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:ContentLinkRequestInfo>
      <APPLICATIONSFID>
        <xsl:text />
      </APPLICATIONSFID>
      <ACTION_ID>
        <xsl:text />
      </ACTION_ID>
      <RECEIPTDOCUMENT_ID>
        <xsl:text />
      </RECEIPTDOCUMENT_ID>
      <CONTENTVERSION_DOCUMENTID>
        <xsl:text />
      </CONTENTVERSION_DOCUMENTID>
    </ns0:ContentLinkRequestInfo>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+QueryResult";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery.QueryResult _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.DLAPDocumentUpload.Definition.ContentLinkRequestInfo";
        
        private const global::SBA.DLAPDocumentUpload.Definition.ContentLinkRequestInfo _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+QueryResult";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.DLAPDocumentUpload.Definition.ContentLinkRequestInfo";
                return _TrgSchemas;
            }
        }
    }
}
