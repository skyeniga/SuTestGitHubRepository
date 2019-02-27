namespace DocumentRetrievalLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+QueryResult", typeof(global::DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentRetrievalDefinition.DocumentRetrievalResponse", typeof(global::DocumentRetrievalDefinition.DocumentRetrievalResponse))]
    public sealed class MakeDocumentRetrievalResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentRetrieval/RetrievalResponse"" xmlns:s0=""http://SBA.gov/DLAPDocumentRetrieval/REST/QUERY/ContentDocument"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(s0:records/s0:LatestPublishedVersion/s0:VersionData/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;2&quot;)"" />
    <xsl:variable name=""var:v4"" select=""string(s0:records/s0:LatestPublishedVersion/s0:VersionData/text())"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringSize($var:v4)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;2&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:LogicalExistence(boolean(s0:records/s0:LatestPublishedVersion/s0:FileType))"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalAnd(string($var:v6) , string($var:v7))"" />
    <xsl:variable name=""var:v25"" select=""userCSharp:LogicalNot(string($var:v6))"" />
    <ns0:RetrievalResponse>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v3"" select=""&quot; &quot;"" />
        <Document_content>
          <xsl:value-of select=""$var:v3"" />
        </Document_content>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v9"" select=""s0:records/s0:LatestPublishedVersion/s0:FileType/text()"" />
        <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq(string($var:v9) , &quot;pdf&quot;)"" />
        <xsl:if test=""string($var:v10)='true'"">
          <xsl:variable name=""var:v11"" select=""&quot;application/pdf&quot;"" />
          <Doc_content_type>
            <xsl:value-of select=""$var:v11"" />
          </Doc_content_type>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v12"" select=""s0:records/s0:LatestPublishedVersion/s0:FileType/text()"" />
        <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq(string($var:v12) , &quot;jpg&quot;)"" />
        <xsl:variable name=""var:v14"" select=""userCSharp:LogicalNot(string($var:v13))"" />
        <xsl:variable name=""var:v15"" select=""boolean(s0:records/s0:LatestPublishedVersion/s0:FileType)"" />
        <xsl:variable name=""var:v16"" select=""userCSharp:LogicalExistence($var:v15)"" />
        <xsl:variable name=""var:v17"" select=""userCSharp:LogicalAnd(string($var:v6) , string($var:v16))"" />
        <xsl:if test=""string($var:v17)='true'"">
          <xsl:variable name=""var:v18"" select=""userCSharp:LogicalEq(string($var:v12) , &quot;pdf&quot;)"" />
          <xsl:variable name=""var:v19"" select=""userCSharp:LogicalNot(string($var:v18))"" />
          <xsl:variable name=""var:v20"" select=""userCSharp:LogicalAnd(string($var:v14) , string($var:v19))"" />
          <xsl:if test=""string($var:v17)='true'"">
            <xsl:if test=""string($var:v20)='true'"">
              <xsl:variable name=""var:v21"" select=""string($var:v12)"" />
              <Doc_content_type>
                <xsl:value-of select=""$var:v21"" />
              </Doc_content_type>
            </xsl:if>
          </xsl:if>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v22"" select=""s0:records/s0:LatestPublishedVersion/s0:FileType/text()"" />
        <xsl:variable name=""var:v23"" select=""userCSharp:LogicalEq(string($var:v22) , &quot;jpg&quot;)"" />
        <xsl:if test=""string($var:v23)='true'"">
          <xsl:variable name=""var:v24"" select=""&quot;image/jpg&quot;"" />
          <Doc_content_type>
            <xsl:value-of select=""$var:v24"" />
          </Doc_content_type>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""string($var:v25)='true'"">
        <xsl:variable name=""var:v26"" select=""&quot;FAILED&quot;"" />
        <Doc_retrieve_status>
          <xsl:value-of select=""$var:v26"" />
        </Doc_retrieve_status>
      </xsl:if>
      <xsl:if test=""string($var:v6)='true'"">
        <xsl:variable name=""var:v27"" select=""&quot;SUCCESS&quot;"" />
        <Doc_retrieve_status>
          <xsl:value-of select=""$var:v27"" />
        </Doc_retrieve_status>
      </xsl:if>
      <xsl:if test=""string($var:v25)='true'"">
        <xsl:variable name=""var:v28"" select=""&quot;Error: No Documents Found on the Application &quot;"" />
        <Doc_retrieve_status_details>
          <xsl:value-of select=""$var:v28"" />
        </Doc_retrieve_status_details>
      </xsl:if>
    </ns0:RetrievalResponse>
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


public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
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
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+QueryResult";
        
        private const global::DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument.QueryResult _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DocumentRetrievalDefinition.DocumentRetrievalResponse";
        
        private const global::DocumentRetrievalDefinition.DocumentRetrievalResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentRetrievalSalesforceDefinition.Rest.RestContentDocument+QueryResult";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DocumentRetrievalDefinition.DocumentRetrievalResponse";
                return _TrgSchemas;
            }
        }
    }
}
