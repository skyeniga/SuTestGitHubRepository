namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SingleNotificationEvent", typeof(global::DLAPEventsSalesforceDefinition.SingleNotificationEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest", typeof(global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest))]
    public sealed class MakeRestQueryApplicationInfoRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s2 s0"" version=""1.0"" xmlns:ns0=""http://SBA.gov/REST/Query/DLAPEvents/CheckStatusApplicationInfoRequest"" xmlns:s1=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:s2=""urn:sobject.enterprise.soap.sforce.com"" xmlns:s0=""http://soap.sforce.com/2005/09/outbound"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Notifications"" />
  </xsl:template>
  <xsl:template match=""/s1:Notifications"">
    <ns0:RestApplicationRequest>
      <ApplicationNumberListQuery>
        <xsl:text />
      </ApplicationNumberListQuery>
    </ns0:RestApplicationRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
        
        private const global::DLAPEventsSalesforceDefinition.SingleNotificationEvent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest";
        
        private const global::DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.RestCheckStatus.RestCheckStatusSalesforceRequest";
                return _TrgSchemas;
            }
        }
    }
}
