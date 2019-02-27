namespace DLAPDocumentListLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response", typeof(global::DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID", typeof(global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID))]
    public sealed class MakeConcatenatedCheckListItemSFIDValues : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://DLAPDocumentListDefinition.ClosingDocsSFID"" xmlns:s0=""http://SBA.gov/DLAPDocumentList/Checklist_Item__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Response"" />
  </xsl:template>
  <xsl:template match=""/s0:Response"">
    <ns0:SFIDValues>
      <xsl:variable name=""var:v1"" select=""userCSharp:InitCumulativeConcat(0)"" />
      <xsl:for-each select=""/s0:Response/s0:row/s0:Id"">
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalExistence(boolean(.))"" />
        <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(../s0:Type__c/text()) , &quot;Closing Documents&quot;)"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v3))"" />
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v5"" select=""./text()"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;,'&quot; , string($var:v5) , &quot;'&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v6),&quot;1000&quot;)"" />
        </xsl:if>
      </xsl:for-each>
      <xsl:variable name=""var:v8"" select=""userCSharp:GetCumulativeConcat(0)"" />
      <xsl:variable name=""var:v9"" select=""userCSharp:StringSize(string($var:v8))"" />
      <xsl:variable name=""var:v10"" select=""userCSharp:StringSubstring(string($var:v8) , &quot;2&quot; , string($var:v9))"" />
      <xsl:variable name=""var:v11"" select=""userCSharp:RemoveSymbol(string($var:v10))"" />
      <Multiple_Checklistitem_SFID_Values>
        <xsl:value-of select=""$var:v11"" />
      </Multiple_Checklistitem_SFID_Values>
    </ns0:SFIDValues>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public string InitCumulativeConcat(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeConcatArray.Count)
		{
			int i = myCumulativeConcatArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeConcatArray.Add("""");
			}
		}
		else
		{
			myCumulativeConcatArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeConcatArray = new System.Collections.ArrayList();

public string AddToCumulativeConcat(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	myCumulativeConcatArray[index] = (string)(myCumulativeConcatArray[index]) + val;
	return myCumulativeConcatArray[index].ToString();
}

public string GetCumulativeConcat(int index)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	return myCumulativeConcatArray[index].ToString();
}

public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string StringSubstring(string str, string left, string right)
{
	string retval = """";
	double dleft = 0;
	double dright = 0;
	if (str != null && IsNumeric(left, ref dleft) && IsNumeric(right, ref dright))
	{
		int lt = (int)dleft;
		int rt = (int)dright;
		lt--; rt--;
		if (lt >= 0 && rt >= lt && lt < str.Length)
		{
			if (rt < str.Length)
			{
				retval = str.Substring(lt, rt-lt+1);
			}
			else
			{
				retval = str.Substring(lt, str.Length-lt);
			}
		}
	}
	return retval;
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string RemoveSymbol(string p1)
{
  if(p1.Contains(""'',""))

{
 return p1.Replace(""'',"","""");
}

	else {return p1;}
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
        
        private const string _strSrcSchemasList0 = @"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response";
        
        private const global::DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c.Response _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID";
        
        private const global::DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DocumentSalesforceListDefinition.SalesforceQuery_Checklist_Item__c+Response";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentListSalesforceDefinition.Rest_Schemas.Checklistitem_ClosingDocs_SFID";
                return _TrgSchemas;
            }
        }
    }
}
