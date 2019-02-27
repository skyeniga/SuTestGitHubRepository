namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT", typeof(global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItemDocumentDetails+Request", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItemDocumentDetails.Request))]
    public sealed class MakeContentDocumentLinkSelectCheckListItemRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/REST/QUERY/ContentDocument"" xmlns:s0=""http://DocumentUploadDefinition.DocumentUpload"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DOCUMENT"" />
  </xsl:template>
  <xsl:template match=""/s0:DOCUMENT"">
    <ns0:Request>
      <ns0:RequestSOQLQuery>
        <xsl:text />
      </ns0:RequestSOQLQuery>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT";
        
        private const global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItemDocumentDetails+Request";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItemDocumentDetails.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItemDocumentDetails+Request";
                return _TrgSchemas;
            }
        }
    }
}
