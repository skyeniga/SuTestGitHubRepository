namespace DLAPDocumentUploadLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadDefinition.UploadMetaData", typeof(global::DLAPDocumentUploadDefinition.UploadMetaData))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPDocumentUploadSalesForceDefinition.Rest.RestReceiptDocument+SaveRequest", typeof(global::DLAPDocumentUploadSalesForceDefinition.Rest.RestReceiptDocument.SaveRequest))]
    public sealed class MakeReceiptDocumentRequestMsg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPDocumentUpload/REST/INSERT/RestReceiptDocument"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ReceiptMetaData"" />
  </xsl:template>
  <xsl:template match=""/ReceiptMetaData"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(UploadDocumentName/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringSize(string(TotalAmount/text()))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalGt(string($var:v4) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringSize(string(DocumentNumber/text()))"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalGt(string($var:v7) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringSize(string(ServiceProviderName/text()))"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalGt(string($var:v11) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringSize(string(DamagedPropertyAddress/text()))"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalGt(string($var:v14) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringSize(string(DocumentType/text()))"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:LogicalGt(string($var:v17) , &quot;0&quot;)"" />
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:text>true</xsl:text>
      </ns0:allOrNone>
      <ns0:records>
        <xsl:attribute name=""type"">
          <xsl:text>ReceiptDocument__c</xsl:text>
        </xsl:attribute>
        <xsl:if test=""string($var:v2)='true'"">
          <xsl:variable name=""var:v3"" select=""UploadDocumentName/text()"" />
          <ns0:Name>
            <xsl:value-of select=""$var:v3"" />
          </ns0:Name>
        </xsl:if>
        <xsl:if test=""string($var:v5)='true'"">
          <xsl:variable name=""var:v6"" select=""TotalAmount/text()"" />
          <ns0:Amount__c>
            <xsl:value-of select=""$var:v6"" />
          </ns0:Amount__c>
        </xsl:if>
        <xsl:if test=""string($var:v8)='true'"">
          <xsl:variable name=""var:v9"" select=""DocumentNumber/text()"" />
          <ns0:Invoice__c>
            <xsl:value-of select=""$var:v9"" />
          </ns0:Invoice__c>
        </xsl:if>
        <xsl:variable name=""var:v10"" select=""userCSharp:ProceedsType(string(UseOfProceeds/text()))"" />
        <ns0:Use_of_Proceeds__c>
          <xsl:value-of select=""$var:v10"" />
        </ns0:Use_of_Proceeds__c>
        <xsl:if test=""string($var:v12)='true'"">
          <xsl:variable name=""var:v13"" select=""ServiceProviderName/text()"" />
          <ns0:Vendor__c>
            <xsl:value-of select=""$var:v13"" />
          </ns0:Vendor__c>
        </xsl:if>
        <ns0:Loan__c>
          <xsl:text />
        </ns0:Loan__c>
        <xsl:if test=""string($var:v15)='true'"">
          <xsl:variable name=""var:v16"" select=""DamagedPropertyAddress/text()"" />
          <ns0:Property_Name__c>
            <xsl:value-of select=""$var:v16"" />
          </ns0:Property_Name__c>
        </xsl:if>
        <xsl:if test=""string($var:v18)='true'"">
          <xsl:variable name=""var:v19"" select=""DocumentType/text()"" />
          <ns0:Type__c>
            <xsl:value-of select=""$var:v19"" />
          </ns0:Type__c>
        </xsl:if>
        <xsl:variable name=""var:v20"" select=""userCSharp:conDate(string(DocumentDate/text()))"" />
        <xsl:variable name=""var:v21"" select=""userCSharp:LogicalExistence(string($var:v20))"" />
        <xsl:if test=""string($var:v21)='true'"">
          <xsl:variable name=""var:v22"" select=""string($var:v20)"" />
          <ns0:Document_Date__c>
            <xsl:value-of select=""$var:v22"" />
          </ns0:Document_Date__c>
        </xsl:if>
      </ns0:records>
    </ns0:SaveRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string ProceedsType(string ProceedsValue)
{ 
    if (ProceedsValue == ""NONE"")
     { return ""N/A""; }     
				
    else if(ProceedsValue == ""REAL_ESTATE"")
    {return ""REAL_ESTATE""; } 
	 
	else if(ProceedsValue == ""CONTENTS"") 
    {return ""CONTENTS""; } 
	 
	else if(ProceedsValue == ""MOTOR_VEHICLE"") 
    {return ""VEHICLES""; } 
	
	else if(ProceedsValue == ""MITIGATION"") 
    {return ""MITIGATION""; }
	 
else
    { return """"; }
	 
}

public string conDate(string sfdate)
{
 if((!string.IsNullOrWhiteSpace(sfdate))&&((sfdate).Trim().Length >5))
   {      return Convert.ToDateTime(sfdate).ToString(""yyyy-MM-dd"");   }

return """";		
}

public bool LogicalExistence(bool val)
{
	return val;
}


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
        
        private const string _strSrcSchemasList0 = @"DLAPDocumentUploadDefinition.UploadMetaData";
        
        private const global::DLAPDocumentUploadDefinition.UploadMetaData _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestReceiptDocument+SaveRequest";
        
        private const global::DLAPDocumentUploadSalesForceDefinition.Rest.RestReceiptDocument.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPDocumentUploadDefinition.UploadMetaData";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPDocumentUploadSalesForceDefinition.Rest.RestReceiptDocument+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
