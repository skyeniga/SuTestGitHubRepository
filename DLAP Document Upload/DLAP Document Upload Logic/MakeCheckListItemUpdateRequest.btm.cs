namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT", typeof(global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItem+SaveRequest", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItem.SaveRequest))]
    public sealed class MakeCheckListItemUpdateRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://DocumentUploadDefinition.DocumentUpload"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/REST/UPDATE/RestChecklistItem"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DOCUMENT"" />
  </xsl:template>
  <xsl:template match=""/s0:DOCUMENT"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(DOCUMENT_TYPE/text()) , &quot;099&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalNot(string($var:v1))"" />
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:text>true</xsl:text>
      </ns0:allOrNone>
      <ns0:records>
        <xsl:attribute name=""type"">
          <xsl:text>Checklist_Item__c</xsl:text>
        </xsl:attribute>
        <ns0:Id>
          <xsl:value-of select=""ACTION_ID/text()"" />
        </ns0:Id>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""&quot;Pending Case Manager Review&quot;"" />
          <ns0:Checklist_Item_Status__c>
            <xsl:value-of select=""$var:v2"" />
          </ns0:Checklist_Item_Status__c>
        </xsl:if>
        <xsl:if test=""string($var:v3)='true'"">
          <xsl:variable name=""var:v4"" select=""&quot;Received&quot;"" />
          <ns0:Checklist_Item_Status__c>
            <xsl:value-of select=""$var:v4"" />
          </ns0:Checklist_Item_Status__c>
        </xsl:if>
      </ns0:records>
    </ns0:SaveRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT";
        
        private const global::SBA.DLAPDocumentUpload.Definition.DocumentUpload.DOCUMENT _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItem+SaveRequest";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItem.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.DLAPDocumentUpload.Definition.DocumentUpload+DOCUMENT";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestChecklistItem+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
