namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SingleNotificationEvent", typeof(global::DLAPEventsSalesforceDefinition.SingleNotificationEvent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsOracleDefinition.OracleEventNotification+Insert", typeof(global::DLAPEventsOracleDefinition.OracleEventNotification.Insert))]
    public sealed class MakeOracleEventNotificationStatusRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s2 s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/EVENT_NOTIFICATION_DCMS"" xmlns:s1=""http://DLAPEventsSalesforceDefinition/SingleNotificationEvent"" xmlns:s2=""urn:sobject.enterprise.soap.sforce.com"" xmlns:s0=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Notifications"" />
  </xsl:template>
  <xsl:template match=""/s1:Notifications"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;event_notification_seqnum.NEXTVAL&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;BizTalk&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:Insert>
      <ns0:RECORDSET>
        <ns0:EVENT_NOTIFICATION_DCMSRECORDINSERT>
          <ns0:ID>
            <xsl:attribute name=""InlineValue"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
          </ns0:ID>
          <xsl:for-each select=""s0:Notification"">
            <xsl:variable name=""var:v2"" select=""userCSharp:StringSize(string(s0:sObject/s2:Application_Number__c/text()))"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:LogicalGt(string($var:v2) , &quot;1&quot;)"" />
            <ns0:APP_NBR>
              <xsl:if test=""string($var:v3)='true'"">
                <xsl:variable name=""var:v4"" select=""s0:sObject/s2:Application_Number__c/text()"" />
                <xsl:value-of select=""$var:v4"" />
              </xsl:if>
            </ns0:APP_NBR>
          </xsl:for-each>
          <ns0:EVENT_TYPE>
            <xsl:text />
          </ns0:EVENT_TYPE>
          <ns0:EVENT_DATA>
            <xsl:text />
          </ns0:EVENT_DATA>
          <ns0:CREATED_BY>
            <xsl:value-of select=""$var:v5"" />
          </ns0:CREATED_BY>
          <ns0:CREATION_DATE>
            <xsl:value-of select=""$var:v6"" />
          </ns0:CREATION_DATE>
          <ns0:LAST_UPDATED_BY>
            <xsl:value-of select=""$var:v5"" />
          </ns0:LAST_UPDATED_BY>
          <ns0:LAST_UPDATE_DATE>
            <xsl:value-of select=""$var:v6"" />
          </ns0:LAST_UPDATE_DATE>
        </ns0:EVENT_NOTIFICATION_DCMSRECORDINSERT>
      </ns0:RECORDSET>
    </ns0:Insert>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
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
        
        private const string _strTrgSchemasList0 = @"DLAPEventsOracleDefinition.OracleEventNotification+Insert";
        
        private const global::DLAPEventsOracleDefinition.OracleEventNotification.Insert _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DLAPEventsOracleDefinition.OracleEventNotification+Insert";
                return _TrgSchemas;
            }
        }
    }
}
