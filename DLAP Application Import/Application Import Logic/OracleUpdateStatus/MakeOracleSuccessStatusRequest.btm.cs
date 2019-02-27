namespace Application_Import_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplication", typeof(global::Application_Import_Definition.HomeDisasterLoanApplication))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Oracle_Application_Import_Definition.DLAPOracle_UPDATE_SUBMITTED_APPLICATIONS_STATUS_DCMS2+Update", typeof(global::Oracle_Application_Import_Definition.DLAPOracle_UPDATE_SUBMITTED_APPLICATIONS_STATUS_DCMS2.Update))]
    public sealed class MakeOracleSuccessStatusRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://Microsoft.LobServices.OracleDB/2007/03/DCMS_INT/View/SUBMITTED_APPLICATIONS"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/Application"" />
  </xsl:template>
  <xsl:template match=""/Application"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;TRANSFER_COMPLETE&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;BizTalk&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;APP_REFERENCE_NUMBER='&quot; , string(APP_ELA_REFERENCE_NBR/text()) , &quot;'&quot; , &quot; AND&quot; , &quot; APP_STATUS='&quot; , &quot;TRANSFER_INITIATED&quot; , &quot;'&quot; , &quot; AND &quot; , &quot;DESTINATION_SYSTEM = '&quot; , &quot;DCMS2&quot; , &quot;'&quot;)"" />
    <ns0:Update>
      <ns0:RECORDSET>
        <ns0:APP_STATUS>
          <xsl:value-of select=""$var:v1"" />
        </ns0:APP_STATUS>
        <ns0:LAST_UPDATED_BY>
          <xsl:value-of select=""$var:v2"" />
        </ns0:LAST_UPDATED_BY>
        <ns0:LAST_UPDATE_DATE>
          <xsl:value-of select=""$var:v3"" />
        </ns0:LAST_UPDATE_DATE>
      </ns0:RECORDSET>
      <ns0:FILTER>
        <xsl:value-of select=""$var:v4"" />
      </ns0:FILTER>
    </ns0:Update>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplication";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplication _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Oracle_Application_Import_Definition.DLAPOracle_UPDATE_SUBMITTED_APPLICATIONS_STATUS_DCMS2+Update";
        
        private const global::Oracle_Application_Import_Definition.DLAPOracle_UPDATE_SUBMITTED_APPLICATIONS_STATUS_DCMS2.Update _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplication";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Oracle_Application_Import_Definition.DLAPOracle_UPDATE_SUBMITTED_APPLICATIONS_STATUS_DCMS2+Update";
                return _TrgSchemas;
            }
        }
    }
}
