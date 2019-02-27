namespace DocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentListDefinition.DocumentListRequest", typeof(global::DocumentListDefinition.DocumentListRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentListDefinition.DocumentListResponse", typeof(global::DocumentListDefinition.DocumentListResponse))]
    public sealed class MakeDocumentListErrorResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentList/DocumentListRequest"" xmlns:ns0=""http://SBA.gov/DLAPDocumentList/DocumentListResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DocumentListRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:DocumentListRequest"">
    <ns0:DOCUMENT>
      <AppData>
        <App_Nbr>
          <xsl:value-of select=""ApplicationNumber/text()"" />
        </App_Nbr>
      </AppData>
      <Error>
        <ErrorStatus>
          <xsl:text>FAILED</xsl:text>
        </ErrorStatus>
        <ErrorDetails>
          <xsl:text>Exception:Application ID/ Applicants couldn’t be found thus Document List details can't be retrieved</xsl:text>
        </ErrorDetails>
      </Error>
    </ns0:DOCUMENT>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DocumentListDefinition.DocumentListRequest";
        
        private const global::DocumentListDefinition.DocumentListRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DocumentListDefinition.DocumentListResponse";
        
        private const global::DocumentListDefinition.DocumentListResponse _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DocumentListDefinition.DocumentListResponse";
                return _TrgSchemas;
            }
        }
    }
}
