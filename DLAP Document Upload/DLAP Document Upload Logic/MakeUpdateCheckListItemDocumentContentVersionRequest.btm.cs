namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT", typeof(global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.SaveRequest))]
    public sealed class MakeUpdateCheckListItemDocumentContentVersionRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestContentVersion"" xmlns:s0=""http://DocumentUploadDefinition.DocumentUpload"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DOCUMENT"" />
  </xsl:template>
  <xsl:template match=""/s0:DOCUMENT"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(APPLICATION_NUMBER/text()) , &quot; &quot; , string(FILE_NAME/text()))"" />
    <xsl:variable name=""var:v2"" select=""string(APPLICATION_NUMBER/text())"" />
    <xsl:variable name=""var:v3"" select=""string(FILE_NAME/text())"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat($var:v2 , &quot; &quot; , $var:v3)"" />
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:text>true</xsl:text>
      </ns0:allOrNone>
      <ns0:records>
        <xsl:attribute name=""type"">
          <xsl:text>ContentVersion</xsl:text>
        </xsl:attribute>
        <ns0:Title>
          <xsl:value-of select=""$var:v1"" />
        </ns0:Title>
        <ns0:Description>
          <xsl:value-of select=""APPLICATION_NUMBER/text()"" />
        </ns0:Description>
        <ns0:PathOnClient>
          <xsl:value-of select=""$var:v4"" />
        </ns0:PathOnClient>
        <ns0:VersionData>
          <xsl:value-of select=""DOCUMENT_CONTENT/text()"" />
        </ns0:VersionData>
        <ns0:ContentDocumentId>
          <xsl:text />
        </ns0:ContentDocumentId>
        <ns0:DLAPUserID__c>
          <xsl:value-of select=""USER_ID/text()"" />
        </ns0:DLAPUserID__c>
        <ns0:DLAP_Document_Type__c>
          <xsl:value-of select=""DOCUMENT_TYPE/text()"" />
        </ns0:DLAP_Document_Type__c>
      </ns0:records>
    </ns0:SaveRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT";
        
        private const global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
