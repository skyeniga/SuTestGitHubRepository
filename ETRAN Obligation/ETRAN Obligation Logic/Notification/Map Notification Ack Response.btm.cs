namespace SBA.ETRANObligation.Logic.Notification {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notifications", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound.notifications))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse))]
    public sealed class MapNotificationAckResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns1=""urn:sobject.enterprise.soap.sforce.com"" xmlns:ns2=""urn:enterprise.soap.sforce.com"" xmlns:ns0=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:notifications"" />
  </xsl:template>
  <xsl:template match=""/ns0:notifications"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalAllExistWithValue(string(ns0:Notification/ns0:sObject/ns1:Application_Number__c/text()) , string(ns0:Notification/ns0:sObject/ns1:SObject_ID__c/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalNot(string($var:v1))"" />
    <ns0:notificationsResponse>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""&quot;true&quot;"" />
        <ns0:Ack>
          <xsl:value-of select=""$var:v2"" />
        </ns0:Ack>
      </xsl:if>
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""&quot;false&quot;"" />
        <ns0:Ack>
          <xsl:value-of select=""$var:v4"" />
        </ns0:Ack>
      </xsl:if>
    </ns0:notificationsResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public System.Boolean LogicalAllExistWithValue(System.Object param0, System.Object param1)
{
	return (
		(param0 != null && !System.String.IsNullOrWhiteSpace(param0.ToString())) &&
		(param1 != null && !System.String.IsNullOrWhiteSpace(param1.ToString()))
	);
	

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
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notifications";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound.notifications _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notifications";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Salesforce.Notification.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse";
                return _TrgSchemas;
            }
        }
    }
}
