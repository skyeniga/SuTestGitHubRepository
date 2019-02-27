namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SingleNotificationEvent", typeof(global::DLAPEventsSalesforceDefinition.SingleNotificationEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Request", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request))]
    public sealed class MakeSalesforceQueryStatusApplicationInfoRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s2 s0 userCSharp"" version=""1.0"" xmlns:s1=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:s2=""urn:sobject.enterprise.soap.sforce.com"" xmlns:ns0=""http://SBA.gov/DLAPEvents/Application_Info__c"" xmlns:s0=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Notifications"" />
  </xsl:template>
  <xsl:template match=""/s1:Notifications"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(s0:Notification/s0:sObject/s2:Application_Number__c/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;2&quot;)"" />
    <ns0:Request>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v3"" select=""s0:Notification/s0:sObject/s2:Application_Number__c/text()"" />
        <ns0:ApplicationNumber>
          <xsl:value-of select=""$var:v3"" />
        </ns0:ApplicationNumber>
      </xsl:if>
    </ns0:Request>
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


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
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


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.SingleNotificationEvent";
        
        private const global::DLAPEventsSalesforceDefinition.SingleNotificationEvent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Request";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Request _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Request";
                return _TrgSchemas;
            }
        }
    }
}
