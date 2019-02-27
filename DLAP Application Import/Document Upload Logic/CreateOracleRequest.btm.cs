namespace Document_Upload_Logic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+Select", typeof(global::Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select))]
    public sealed class CreateOracleRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Message"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://Microsoft.LobServices.OracleDB/2007/03/ELA_DB/View/SUBMITTED_DOCUMENTS_DCMS2"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;DOC_USR_ID , APP_REFERENCE_NUMBER , DOC_ID , DOC_TYPE , LKC_DESC , DOC_CONTENTS , DOC_CONTENT_TYPE , DOC_INSTANCE_NAME , DOC_SOURCE , DOC_APPLICANT_ID , DOC_AFFILIATE_ID , DOC_ORIGIN&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;APP_REFERENCE_NUMBER='&quot; , string(APP_ELA_REFERENCE_NBR/text()) , &quot;'&quot;)"" />
    <ns0:Select>
      <ns0:COLUMN_NAMES>
        <xsl:value-of select=""$var:v1"" />
      </ns0:COLUMN_NAMES>
      <ns0:FILTER>
        <xsl:value-of select=""$var:v2"" />
      </ns0:FILTER>
    </ns0:Select>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+Select";
        
        private const global::Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2.Select _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Oracle_Application_Import_Definition.DLAPOracle_SUBMITTED_DOCUMENTS_DCMS2+Select";
                return _TrgSchemas;
            }
        }
    }
}
