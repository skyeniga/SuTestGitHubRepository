namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadDefinition.UploadMetaData", typeof(global::DLAPDocumentUploadDefinition.UploadMetaData))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.SalesforceQuery_ReceiptDocument__c+Request", typeof(global::DLAPDocumentUploadSalesForceDefinition.SalesforceQuery_ReceiptDocument__c.Request))]
    public sealed class MakeReceiptDocumentRequestMsg_Copy : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/ReceiptDocument"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ReceiptMetaData"" />
  </xsl:template>
  <xsl:template match=""/ReceiptMetaData"">
    <ns0:Request>
      <ns0:sync>
        <ns0:after>
          <ns0:ReceiptDocument__c>
            <xsl:attribute name=""Name"">
              <xsl:value-of select=""UploadDocumentName/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Amount__c"">
              <xsl:value-of select=""TotalAmount/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Invoice__c"">
              <xsl:value-of select=""DocumentNumber/text()"" />
            </xsl:attribute>
            <xsl:variable name=""var:v1"" select=""userCSharp:ProceedsType(string(UseOfProceeds/text()))"" />
            <xsl:attribute name=""Use_of_Proceeds__c"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <xsl:attribute name=""Vendor__c"">
              <xsl:value-of select=""ServiceProviderName/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Loan__c"">
              <xsl:text />
            </xsl:attribute>
            <xsl:attribute name=""Property_Name__c"">
              <xsl:value-of select=""DamagedPropertyAddress/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Type__c"">
              <xsl:value-of select=""DocumentType/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Document_Date__c"">
              <xsl:value-of select=""DocumentDate/text()"" />
            </xsl:attribute>
          </ns0:ReceiptDocument__c>
        </ns0:after>
      </ns0:sync>
    </ns0:Request>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string ProceedsType(string ProceedsValue)
{ 
    if (ProceedsValue == ""NONE"")
     { return ""N/A""; }     
				
    else if(ProceedsValue == ""REAL_ESTATE"")
    {return ""REAL_ESTATE""; } 
	 
	else if(ProceedsValue == ""CONTENTS"") 
    {return ""CONTENTS""; } 
	 
	else if(ProceedsValue == ""MOTOR_VEHICLE"") 
    {return ""VEHICLES""; } 
	
	else if(ProceedsValue == ""MITIGATION"") 
    {return ""MITIGATION""; }
	 
else
    { return """"; }
	 
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentUploadDefinition.UploadMetaData";
        
        private const global::DLAPDocumentUploadDefinition.UploadMetaData _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.SalesforceQuery_ReceiptDocument__c+Request";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.SalesforceQuery_ReceiptDocument__c.Request _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentUploadDefinition.UploadMetaData";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.SalesforceQuery_ReceiptDocument__c+Request";
                return _TrgSchemas;
            }
        }
    }
}
