namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+results", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.results))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENTRESPONSE", typeof(global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENTRESPONSE))]
    public sealed class MakeCheckLIstItemDocumentUpdateUploadResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestContentVersion"" xmlns:ns0=""http://DocumentUploadDefinition.DocumentUpload"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:results"" />
  </xsl:template>
  <xsl:template match=""/s0:results"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(s0:result/s0:id/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;2&quot;)"" />
    <xsl:variable name=""var:v5"" select=""string(s0:result/s0:id/text())"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringSize($var:v5)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:LogicalGt(string($var:v6) , &quot;2&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
    <ns0:DOCUMENTRESPONSE>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v3"" select=""&quot;Success&quot;"" />
        <Upload_Status>
          <xsl:value-of select=""$var:v3"" />
        </Upload_Status>
      </xsl:if>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v4"" select=""&quot;File Uploaded Successfully&quot;"" />
        <Upload_Status>
          <xsl:value-of select=""$var:v4"" />
        </Upload_Status>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v9"" select=""&quot;FAILED&quot;"" />
        <Upload_Status_Details>
          <xsl:value-of select=""$var:v9"" />
        </Upload_Status_Details>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v10"" select=""&quot;Exception: Error while Linking Document&quot;"" />
        <Upload_Status_Details>
          <xsl:value-of select=""$var:v10"" />
        </Upload_Status_Details>
      </xsl:if>
    </ns0:DOCUMENTRESPONSE>
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
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+results";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion.results _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENTRESPONSE";
        
        private const global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENTRESPONSE _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestContentVersion+results";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENTRESPONSE";
                return _TrgSchemas;
            }
        }
    }
}
