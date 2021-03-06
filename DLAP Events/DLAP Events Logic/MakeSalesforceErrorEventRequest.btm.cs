namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SingleNotificationEvent", typeof(global::DLAPEventsSalesforceDefinition.SingleNotificationEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.Salesforce_EventRequest+Request", typeof(global::DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request))]
    public sealed class MakeSalesforceErrorEventRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s2 s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPEvents/Event_Request__c"" xmlns:s1=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:s2=""urn:sobject.enterprise.soap.sforce.com"" xmlns:s0=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Notifications"" />
  </xsl:template>
  <xsl:template match=""/s1:Notifications"">
    <ns0:Request>
      <ns0:sync>
        <ns0:before>
          <xsl:for-each select=""s0:Notification"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s0:sObject/s2:Id))"" />
            <ns0:Event_Request__c>
              <xsl:if test=""string($var:v1)='true'"">
                <xsl:variable name=""var:v2"" select=""s0:sObject/s2:Id/text()"" />
                <xsl:attribute name=""Id"">
                  <xsl:value-of select=""$var:v2"" />
                </xsl:attribute>
              </xsl:if>
            </ns0:Event_Request__c>
          </xsl:for-each>
        </ns0:before>
        <ns0:after>
          <ns0:Event_Request__c>
            <xsl:attribute name=""GUID__c"">
              <xsl:text />
            </xsl:attribute>
            <xsl:attribute name=""Log_Message__c"">
              <xsl:text />
            </xsl:attribute>
            <xsl:attribute name=""Stage__c"">
              <xsl:text>Notification Sent to DLAP</xsl:text>
            </xsl:attribute>
            <xsl:attribute name=""Status__c"">
              <xsl:text>Error</xsl:text>
            </xsl:attribute>
          </ns0:Event_Request__c>
        </ns0:after>
      </ns0:sync>
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
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
        
        private const global::DLAPEventsSalesforceDefinition.SingleNotificationEvent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.Salesforce_EventRequest+Request";
        
        private const global::DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.Salesforce_EventRequest+Request";
                return _TrgSchemas;
            }
        }
    }
}
