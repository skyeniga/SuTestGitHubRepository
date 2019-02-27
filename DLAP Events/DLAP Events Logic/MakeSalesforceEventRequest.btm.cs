namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SingleNotificationEvent", typeof(global::DLAPEventsSalesforceDefinition.SingleNotificationEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsOracleDefinition.OracleEventNotification+InsertResponse", typeof(global::DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.Salesforce_EventRequest+Request", typeof(global::DLAPEventsSalesforceDefinition.Salesforce_EventRequest.Request))]
    public sealed class MakeSalesforceEventRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1 s3 s4 userCSharp"" version=""1.0"" xmlns:s1=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:s4=""http://soap.sforce.com/2005/09/outbound"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://SBA.gov/DLAPEvents/Event_Request__c"" xmlns:s0=""http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS"" xmlns:s3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalGte(string(InputMessagePart_1/s0:InsertResponse/s0:InsertResult/text()) , &quot;1&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(string($var:v3))"" />
    <ns0:Request>
      <ns0:sync>
        <ns0:before>
          <xsl:for-each select=""InputMessagePart_0/s1:Notifications/s4:Notification"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s4:sObject/s3:Id))"" />
            <ns0:Event_Request__c>
              <xsl:if test=""string($var:v1)='true'"">
                <xsl:variable name=""var:v2"" select=""s4:sObject/s3:Id/text()"" />
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
            <xsl:if test=""string($var:v3)='true'"">
              <xsl:variable name=""var:v4"" select=""&quot;Successfully Sent Notification to DLAP&quot;"" />
              <xsl:attribute name=""Log_Message__c"">
                <xsl:value-of select=""$var:v4"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v5)='true'"">
              <xsl:variable name=""var:v6"" select=""&quot; DLAP Notification Failed&quot;"" />
              <xsl:attribute name=""Log_Message__c"">
                <xsl:value-of select=""$var:v6"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v3)='true'"">
              <xsl:variable name=""var:v7"" select=""&quot;Notification Sent to DLAP&quot;"" />
              <xsl:attribute name=""Stage__c"">
                <xsl:value-of select=""$var:v7"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v5)='true'"">
              <xsl:variable name=""var:v8"" select=""&quot;Notification Sent to DLAP&quot;"" />
              <xsl:attribute name=""Stage__c"">
                <xsl:value-of select=""$var:v8"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v3)='true'"">
              <xsl:variable name=""var:v9"" select=""&quot;Success&quot;"" />
              <xsl:attribute name=""Status__c"">
                <xsl:value-of select=""$var:v9"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""string($var:v5)='true'"">
              <xsl:variable name=""var:v10"" select=""&quot;Error&quot;"" />
              <xsl:attribute name=""Status__c"">
                <xsl:value-of select=""$var:v10"" />
              </xsl:attribute>
            </xsl:if>
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


public bool LogicalGte(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 >= d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) >= 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
        
        private const global::DLAPEventsSalesforceDefinition.SingleNotificationEvent _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DLAPEventsOracleDefinition.OracleEventNotification+InsertResponse";
        
        private const global::DLAPEventsOracleDefinition.OracleEventNotification.InsertResponse _srcSchemaTypeReference1 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
                _SrcSchemas[1] = @"DLAPEventsOracleDefinition.OracleEventNotification+InsertResponse";
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
