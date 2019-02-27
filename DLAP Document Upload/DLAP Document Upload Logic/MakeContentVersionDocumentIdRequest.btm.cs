namespace SBA.DLAPDocumentUpload.Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.SaveRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+Request", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery.Request))]
    public sealed class MakeContentVersionDocumentIdRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestContentVersion"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/REST/QUERY/RestContentVersion"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:SaveRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:SaveRequest"">
    <ns0:Request>
      <ns0:SOQL_ContentDocument_Id_Query>
        <xsl:text />
      </ns0:SOQL_ContentDocument_Id_Query>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.SaveRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+Request";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersionQuery+Request";
                return _TrgSchemas;
            }
        }
    }
}
