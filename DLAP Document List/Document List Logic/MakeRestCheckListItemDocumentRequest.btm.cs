namespace DLAPDocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+Request", typeof(global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request))]
    public sealed class MakeRestCheckListItemDocumentRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentList/Application_Info__c"" xmlns:ns0=""http://SBA.gov/REST/ClosingDocumentsDocumentList"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Response"" />
  </xsl:template>
  <xsl:template match=""/s0:Response"">
    <ns0:Request>
      <ns0:RequestSOQLQuery>
        <xsl:text />
      </ns0:RequestSOQLQuery>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c.Response _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+Request";
        
        private const global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DocumentSalesforceListDefinition.SalesforceQuery_Application_Info__c+Response";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Rest_CheckListItem_Document_Details+Request";
                return _TrgSchemas;
            }
        }
    }
}
