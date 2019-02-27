namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications", typeof(global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsDefinition.OrchestrationInstanceId", typeof(global::DLAPEventsDefinition.OrchestrationInstanceId))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest", typeof(global::DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest))]
    public sealed class MakeSalesforceErrorUpdateEventRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s3 s4 s1"" version=""1.0"" xmlns:s1=""http://soap.sforce.com/2005/09/outbound"" xmlns:s0=""http://DLAPEventsDefinition.OrchestrationInstanceId"" xmlns:ns0=""http://SBA.gov/DLAPEvents/REST/INSERT/EventRequest"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:s4=""urn:enterprise.soap.sforce.com"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:text>true</xsl:text>
      </ns0:allOrNone>
      <xsl:for-each select=""InputMessagePart_0/s1:notifications/s1:Notification"">
        <ns0:records>
          <xsl:attribute name=""type"">
            <xsl:text>Event_Request__c</xsl:text>
          </xsl:attribute>
          <ns0:Id>
            <xsl:value-of select=""s1:sObject/s3:Id/text()"" />
          </ns0:Id>
          <xsl:if test=""s1:sObject/s3:Application_Number__c"">
            <ns0:Application_Number__c>
              <xsl:value-of select=""s1:sObject/s3:Application_Number__c/text()"" />
            </ns0:Application_Number__c>
          </xsl:if>
          <xsl:if test=""s1:sObject/s3:SObject_ID__c"">
            <ns0:SObject_ID__c>
              <xsl:value-of select=""s1:sObject/s3:SObject_ID__c/text()"" />
            </ns0:SObject_ID__c>
          </xsl:if>
          <ns0:Log_Message__c>
            <xsl:value-of select=""../../../InputMessagePart_1/s0:Instance/ErrorMessage/text()"" />
          </ns0:Log_Message__c>
          <xsl:if test=""s1:sObject/s3:SObject_Name__c"">
            <ns0:SObject_Name__c>
              <xsl:value-of select=""s1:sObject/s3:SObject_Name__c/text()"" />
            </ns0:SObject_Name__c>
          </xsl:if>
          <ns0:Stage__c>
            <xsl:text>Notification Sent to DLAP</xsl:text>
          </ns0:Stage__c>
          <ns0:Status__c>
            <xsl:text>Error</xsl:text>
          </ns0:Status__c>
          <ns0:Auto_Decline_Reason__c>
            <xsl:text>&lt;empty&gt;</xsl:text>
          </ns0:Auto_Decline_Reason__c>
          <ns0:GUID__c>
            <xsl:value-of select=""../../../InputMessagePart_1/s0:Instance/Id/text()"" />
          </ns0:GUID__c>
        </ns0:records>
      </xsl:for-each>
    </ns0:SaveRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications";
        
        private const global::DLAPEventsSalesforceDefinition.NotificationService_outbound.notifications _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DLAPEventsDefinition.OrchestrationInstanceId";
        
        private const global::DLAPEventsDefinition.OrchestrationInstanceId _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest";
        
        private const global::DLAPEventsSalesforceDefinition.RestEventRequest.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.NotificationService_outbound+notifications";
                _SrcSchemas[1] = @"DLAPEventsDefinition.OrchestrationInstanceId";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.RestEventRequest+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
