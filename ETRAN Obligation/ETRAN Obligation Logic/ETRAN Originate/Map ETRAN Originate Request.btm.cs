namespace SBA.ETRANObligation.Logic.ETRANOriginate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRAN.Shared.Definition.ETranCredentials", typeof(global::SBA.ETRAN.Shared.Definition.ETranCredentials))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Request", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Request))]
    public sealed class Map_ETRAN_Originate_Request : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" 
                xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" 
                xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" 
                exclude-result-prefixes=""msxsl var cred agg"" 
                version=""1.0"" 
                xmlns:agg=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" 
                xmlns:etran=""http://ws.elend"" 
                xmlns:cred=""http://SBA.gov/ETranShared/ETranCredentials/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" indent=""yes"" />
  <xsl:template match=""*"" mode=""copy"">
    <xsl:element name=""{name()}"" namespace=""{namespace-uri()}"">
      <xsl:apply-templates select=""@*|node()"" mode=""copy"" />
    </xsl:element>
  </xsl:template>
  <xsl:template match=""@*|text()|comment()"" mode=""copy"">
    <xsl:copy/>
  </xsl:template>
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/agg:Root"" />
  </xsl:template>
  <xsl:template match=""/agg:Root"">
    <etran:Originate3>
      <username>
        <xsl:value-of select=""InputMessagePart_1/cred:ETranCredentials/cred:username/text()"" />
      </username>
      <password>
        <xsl:value-of select=""InputMessagePart_1/cred:ETranCredentials/cred:password/text()"" />
      </password>
      <email>
        <xsl:value-of select=""InputMessagePart_1/cred:ETranCredentials/cred:email/text()"" />
      </email>
      <loanappxml>
        <xsl:text disable-output-escaping=""yes"">&lt;![CDATA[</xsl:text>
        <SBA_ETran version=""3.9"">
          <xsl:apply-templates mode=""copy"" select=""/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='SBA_ETran' and namespace-uri()='']/*[local-name()='App' and namespace-uri()='']""/>
        </SBA_ETran>
        <xsl:text disable-output-escaping=""yes"">]]&gt;</xsl:text>
      </loanappxml>
      <respfrmt>
        <xsl:variable name=""respfrmt"" select=""normalize-space(InputMessagePart_1/cred:ETranCredentials/cred:respfrmt/text())"" />
        <xsl:choose>
          <xsl:when test=""$respfrmt"">
            <xsl:value-of select=""$respfrmt""/>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text/>
          </xsl:otherwise>
        </xsl:choose>
      </respfrmt>
      <softwarevendorname>
        <xsl:value-of select=""InputMessagePart_1/cred:ETranCredentials/cred:softwarevendorname/text()"" />
      </softwarevendorname>
    </etran:Originate3>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 1;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRAN.Shared.Definition.ETranCredentials";
        
        private const global::SBA.ETRAN.Shared.Definition.ETranCredentials _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Request";
        
        private const global::SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Request _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.ETRAN.SBA_ETran_5_0_orig";
                _SrcSchemas[1] = @"SBA.ETRAN.Shared.Definition.ETranCredentials";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Request";
                return _TrgSchemas;
            }
        }
    }
}
