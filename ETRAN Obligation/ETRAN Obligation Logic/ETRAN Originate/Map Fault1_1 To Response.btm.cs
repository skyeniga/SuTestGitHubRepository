namespace SBA.ETRANObligation.Logic.ETRAN_Originate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.soap_envelope_1__1+Fault", typeof(global::BTS.soap_envelope_1__1.Fault))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig))]
    public sealed class Map_Fault1_1_To_Response : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ws.elend"" xmlns:s0=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Fault"" />
  </xsl:template>
  <xsl:template match=""/s0:Fault"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNot(&quot;true&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:ConvertChr(&quot;13&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:ConvertChr(&quot;10&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string($var:v2) , string($var:v3))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;FaultCode: &quot; , string(faultcode/text()) , string($var:v4) , &quot;FaultString&quot; , string(faultstring/text()) , string($var:v4) , &quot;FaultActor: &quot; , string(faultactor/text()))"" />
    <ns0:SBA_Etran_Response>
      <xsl:if test=""$var:v1"" />
      <xsl:if test=""$var:v1"" />
      <ns0:Synopsis>
        <xsl:value-of select=""$var:v5"" />
      </ns0:Synopsis>
      <ns0:App>
        <xsl:if test=""$var:v1"">
          <ns0:Results />
        </xsl:if>
        <xsl:for-each select=""detail"">
          <ns0:Errors>
            <xsl:copy-of select=""./@*"" />
            <xsl:copy-of select=""./*"" />
          </ns0:Errors>
        </xsl:for-each>
      </ns0:App>
    </ns0:SBA_Etran_Response>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7;
}


public string ConvertChr(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		int v = (int) d;
		if (v >= 1 && v <= 127)
		{
			char c = (char)v;
			retval = c.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
	}
	return retval;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
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
        
        private const string _strSrcSchemasList0 = @"BTS.soap_envelope_1__1+Fault";
        
        private const global::BTS.soap_envelope_1__1.Fault _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BTS.soap_envelope_1__1+Fault";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_Response_orig";
                return _TrgSchemas;
            }
        }
    }
}
