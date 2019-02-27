namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications", typeof(global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.NotificationService_outbound+notificationsResponse", typeof(global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse))]
    public sealed class MakeSFNotificationAckMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns1=""urn:sobject.enterprise.soap.sforce.com"" xmlns:ns2=""urn:enterprise.soap.sforce.com"" xmlns:ns0=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:notifications"" />
  </xsl:template>
  <xsl:template match=""/ns0:notifications"">
    <ns0:notificationsResponse>
      <xsl:variable name=""var:v1"" select=""userCSharp:AckResponse(string(ns0:Notification/ns0:sObject/ns1:Application_Number__c/text()) , string(ns0:Notification/ns0:sObject/ns1:Log_Message__c/text()) , string(ns0:Notification/ns0:sObject/ns1:SObject_ID__c/text()))"" />
      <ns0:Ack>
        <xsl:value-of select=""$var:v1"" />
      </ns0:Ack>
    </ns0:notificationsResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string AckResponse(string AppNumber, string LogMessage, string SObjectID)
  {

if ((!string.IsNullOrWhiteSpace(AppNumber))&&(!string.IsNullOrWhiteSpace(LogMessage)))
   {return ""true"";}             

else if((!string.IsNullOrWhiteSpace(AppNumber))&&(!string.IsNullOrWhiteSpace(SObjectID)))
       {return ""true"";}
        
else{return ""false"";}

   }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications";
        
        private const global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notificationsResponse";
        
        private const global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notificationsResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notificationsResponse";
                return _TrgSchemas;
            }
        }
    }
}
