namespace DocumentRetrievalLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentRetrievalDefinition.DocumentRetrievalRequest", typeof(global::DocumentRetrievalDefinition.DocumentRetrievalRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request", typeof(global::DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request))]
    public sealed class MakeContentVersionRequestMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument"" xmlns:s0=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:RetrievalRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:RetrievalRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(SDCID))"" />
    <ns0:Request>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""SDCID/text()"" />
        <ns0:SOQL_ContentVersionId_Query>
          <xsl:value-of select=""$var:v2"" />
        </ns0:SOQL_ContentVersionId_Query>
      </xsl:if>
    </ns0:Request>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DocumentRetrievalDefinition.DocumentRetrievalRequest";
        
        private const global::DocumentRetrievalDefinition.DocumentRetrievalRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request";
        
        private const global::DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DocumentRetrievalDefinition.DocumentRetrievalRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+Request";
                return _TrgSchemas;
            }
        }
    }
}
