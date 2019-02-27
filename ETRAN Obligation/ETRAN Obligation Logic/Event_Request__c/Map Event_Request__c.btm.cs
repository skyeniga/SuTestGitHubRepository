namespace SBA.ETRANObligation.Logic.Event_Request__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Event_Request_c : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" 
                xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" 
                xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" 
                exclude-result-prefixes=""msxsl var userCSharp"" 
                version=""1.0"" 
                xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/""
                xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/""
                xmlns:orgtype=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/""
                xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" 
                xmlns:event=""http://SBA.gov/ETRANObligation/Salesforce/Insert/Event_Request__c/"" 
                xmlns:ns1=""urn:enterprise.soap.sforce.com"" 
                xmlns:ns3=""http://soap.sforce.com/2005/09/outbound"" 
                xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" 
                xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" 
                xmlns:etran=""http://ws.elend"" 
                xmlns:ns4=""urn:sobject.enterprise.soap.sforce.com"" 
                xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" indent=""yes"" />
  <xsl:template name=""repeat"">
    <xsl:param name=""output"" />
    <xsl:param name=""count"" />
    <xsl:if test=""$count &gt; 0"">
      <xsl:value-of select=""$output"" />
      <xsl:call-template name=""repeat"">
        <xsl:with-param name=""output"" select=""$output"" />
        <xsl:with-param name=""count"" select=""$count - 1"" />
      </xsl:call-template>
    </xsl:if>
  </xsl:template>
  <xsl:template match=""*"" mode=""copy"">
    <xsl:element name=""{name()}"" namespace=""{namespace-uri()}"">
      <xsl:apply-templates select=""@*|node()"" mode=""copy"" />
    </xsl:element>
  </xsl:template>
  <xsl:template match=""@*|text()|comment()"" mode=""copy"">
    <xsl:copy/>
  </xsl:template>
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Canonical"" />
  </xsl:template>
  <xsl:template match=""/ns0:Canonical"">
    <ns0:Canonical>
      <xsl:apply-templates select=""notify1:Notification"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:Multi"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:BorrowerBusinessTypes"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:ETRAN_Originate_App_Defaults"" mode=""copy"" />
      <xsl:apply-templates select=""ns0:SBA_ETran_Response"" mode=""copy"" />
      <ns0:Event_Request__c>
        <xsl:variable name=""loanAppFundDtExists"" select=""userCSharp:LogicalExistence(boolean(ns0:SBA_ETran_Response/etran:App/etran:Results/etran:LoanAppFundDt))"" />
          <xsl:variable name=""loanAppFundDtIsDate"" select=""userCSharp:LogicalIsDate(string(ns0:SBA_ETran_Response/etran:App/etran:Results/etran:LoanAppFundDt/text()))"" />
          <xsl:variable name=""loanAppFundDtIsValid"" select=""userCSharp:LogicalAnd(string($loanAppFundDtExists) , string($loanAppFundDtIsDate))"" />
          <xsl:variable name=""loanNmbExists"" select=""userCSharp:LogicalExistence(boolean(ns0:SBA_ETran_Response/etran:App/etran:Results/etran:LoanNmb))"" />
          <xsl:variable name=""loanNmbIsNumeric"" select=""userCSharp:LogicalIsNumeric(string(ns0:SBA_ETran_Response/etran:App/etran:Results/etran:LoanNmb/text()))"" />
          <xsl:variable name=""loanNmbIsValid"" select=""userCSharp:LogicalAnd(string($loanNmbExists) , string($loanNmbIsNumeric))"" />
          <xsl:variable name=""resultIsSuccess"" select=""userCSharp:LogicalAnd(string($loanAppFundDtIsValid) , string($loanNmbIsValid))"" />
          <xsl:variable name=""loanAppFundDtIsNOTDate"" select=""userCSharp:LogicalNot(string($loanAppFundDtIsDate))"" />
          <xsl:variable name=""loanAppFundDtExistsAndNOTDate"" select=""userCSharp:LogicalAnd(string($loanAppFundDtExists) , string($loanAppFundDtIsNOTDate))"" />
          <xsl:variable name=""loanAppFundDtNOTExists"" select=""userCSharp:LogicalNot(string($loanAppFundDtExists))"" />
          <xsl:variable name=""loanAppFundDtIsNOTValid"" select=""userCSharp:LogicalOr(string($loanAppFundDtExistsAndNOTDate) , string($loanAppFundDtNOTExists))"" />
          <xsl:variable name=""loanNmbNOTExists"" select=""userCSharp:LogicalNot(string($loanNmbExists))"" />
          <xsl:variable name=""loanNmbIsNOTNumeric"" select=""userCSharp:LogicalNot(string($loanNmbIsNumeric))"" />
          <xsl:variable name=""loanNmbExistsAndNOTNumeric"" select=""userCSharp:LogicalAnd(string($loanNmbExists) , string($loanNmbIsNOTNumeric))"" />
          <xsl:variable name=""loanNmbIsNOTValid"" select=""userCSharp:LogicalOr(string($loanNmbNOTExists) , string($loanNmbExistsAndNOTNumeric))"" />
          <xsl:variable name=""resultIsFailure"" select=""userCSharp:LogicalOr(string($loanAppFundDtIsNOTValid) , string($loanNmbIsNOTValid))"" />
        <xsl:attribute name=""GUID__c"">
          <xsl:value-of select=""ns0:Event_Request__c/@GUID__c"" />
        </xsl:attribute>
        <xsl:attribute name=""Application_Number__c"">
          <xsl:value-of select=""ns0:Event_Request__c/@Application_Number__c"" />
        </xsl:attribute>
        <xsl:attribute name=""Log_Message__c"">
          <xsl:for-each select=""ns0:SBA_ETran_Response"">
            <xsl:text>ETran Response: &#xa;&#xd;</xsl:text>
            <xsl:for-each select=""etran:AuthErrorNmb"">
              <xsl:text> &#xa;&#xd;AuthErrorNmb: </xsl:text>
              <xsl:value-of select=""text()"" />
            </xsl:for-each>
            <xsl:for-each select=""etran:AuthErrorText"">
              <xsl:text> &#xa;&#xd;AuthErrorText: </xsl:text>
              <xsl:value-of select=""text()"" />
            </xsl:for-each>
            <xsl:for-each select=""etran:Synopsis"">
              <xsl:text> &#xa;&#xd;Synopsis[</xsl:text>
              <xsl:value-of select=""position()"" />
              <xsl:text>]: </xsl:text>
              <xsl:value-of select=""text()"" />
            </xsl:for-each>
            <xsl:for-each select=""etran:App/etran:Errors"">
              <xsl:text> &#xa;&#xd;Errors[</xsl:text>
              <xsl:value-of select=""position()"" />
              <xsl:text>]: </xsl:text>
              <xsl:value-of select=""text()"" />
            </xsl:for-each>
            <xsl:for-each select=""etran:App/etran:Warnings"">
              <xsl:text> &#xa;&#xd;Warnings[</xsl:text>
              <xsl:value-of select=""position()"" />
              <xsl:text>]: </xsl:text>
              <xsl:value-of select=""text()"" />
            </xsl:for-each>
          </xsl:for-each>
        </xsl:attribute>
        <xsl:attribute name=""SObject_ID__c"">
          <xsl:value-of select=""ns0:Event_Request__c/@SObject_ID__c"" />
        </xsl:attribute>
        <xsl:attribute name=""SObject_Name__c"">
          <xsl:value-of select=""ns0:Event_Request__c/@SObject_Name__c"" />
        </xsl:attribute>
        <xsl:attribute name=""Stage__c"">
          <xsl:value-of select=""ns0:Event_Request__c/@Stage__c"" />
        </xsl:attribute>
        <xsl:if test=""string($resultIsSuccess)='true'"">
          <xsl:attribute name=""Status__c"">
            <xsl:text>Success</xsl:text>
          </xsl:attribute>
        </xsl:if>
        <xsl:if test=""string($resultIsFailure)='true'"">
          <xsl:attribute name=""Status__c"">
            <xsl:text>Failure</xsl:text>
          </xsl:attribute>
        </xsl:if>
        <xsl:text></xsl:text>
      </ns0:Event_Request__c>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
}


public bool LogicalIsDate(string val)
{
	return IsDate(val);
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

public bool IsDate(string val)
{
	bool retval = true;
	try
	{
		DateTime dt = Convert.ToDateTime(val, System.Globalization.CultureInfo.InvariantCulture);
	}
	catch (Exception)
	{
		retval = false;
	}
	return retval;
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
        
        private const int _useXSLTransform = 1;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                return _TrgSchemas;
            }
        }
    }
}
