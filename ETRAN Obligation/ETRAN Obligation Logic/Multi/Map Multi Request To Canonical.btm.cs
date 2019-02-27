namespace SBA.ETRANObligation.Logic.Multi {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Multi_Request_To_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns2=""http://SBA.gov/ETRANObligation/Definition/Rules/LegalOrgTypeMapping/"" xmlns:notify1=""http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/"" xmlns:ns1=""http://soap.sforce.com/2005/09/outbound"" xmlns:ns0=""http://SBA.gov/ETRANObligation/Canonical/"" xmlns:ns4=""urn:enterprise.soap.sforce.com"" xmlns:etran=""http://ws.elend"" xmlns:bbt=""http://SBA.gov/ETRANObligation/Definition/Borrower/BorrowerBusinessTypes/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:def=""http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/"" xmlns:multi=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Multi/Query/"" xmlns:event=""http://SBA.gov/ETRANObligation/Definition/Salesforce/Event_Request__c/"" xmlns:ns3=""urn:sobject.enterprise.soap.sforce.com"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNot(&quot;true&quot;)"" />
    <ns0:Canonical>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/notify1:Notification"">
        <notify1:Notification>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </notify1:Notification>
      </xsl:for-each>
      <ns0:Multi>
        <ns0:Request>
          <multi:q>
            <xsl:value-of select=""InputMessagePart_1/multi:Request/multi:q/text()"" />
          </multi:q>
          <multi:ApplicationNumber>
            <xsl:value-of select=""InputMessagePart_1/multi:Request/multi:ApplicationNumber/text()"" />
          </multi:ApplicationNumber>
          <multi:LoanId>
            <xsl:value-of select=""InputMessagePart_1/multi:Request/multi:LoanId/text()"" />
          </multi:LoanId>
        </ns0:Request>
        <xsl:if test=""$var:v1"">
          <ns0:QueryResult>
            <multi:done>
              <xsl:text>false</xsl:text>
            </multi:done>
            <multi:records>
              <xsl:attribute name=""type"">
                <xsl:text>Application__c</xsl:text>
              </xsl:attribute>
              <multi:RecordType>
                <xsl:attribute name=""type"">
                  <xsl:text>RecordType</xsl:text>
                </xsl:attribute>
              </multi:RecordType>
              <multi:Loans__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Loan__c</xsl:text>
                  </xsl:attribute>
                  <multi:Disaster_Declaration__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Disaster__c</xsl:text>
                    </xsl:attribute>
                  </multi:Disaster_Declaration__r>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Loans__r>
              <multi:Processing_Application_Review__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Processing_Application_Review__c</xsl:text>
                  </xsl:attribute>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Processing_Application_Review__r>
              <multi:Property__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Property__c</xsl:text>
                  </xsl:attribute>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Property__r>
              <multi:Applicants__r>
                <multi:done>
                  <xsl:text>false</xsl:text>
                </multi:done>
                <multi:records>
                  <xsl:attribute name=""type"">
                    <xsl:text>Applicant__c</xsl:text>
                  </xsl:attribute>
                  <multi:RecordType>
                    <xsl:attribute name=""type"">
                      <xsl:text>RecordType</xsl:text>
                    </xsl:attribute>
                  </multi:RecordType>
                  <multi:Related_Parent__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Applicant__c</xsl:text>
                    </xsl:attribute>
                  </multi:Related_Parent__r>
                  <multi:Account__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Account</xsl:text>
                    </xsl:attribute>
                  </multi:Account__r>
                  <multi:Contact__r>
                    <xsl:attribute name=""type"">
                      <xsl:text>Contact</xsl:text>
                    </xsl:attribute>
                  </multi:Contact__r>
                </multi:records>
                <multi:totalSize>
                  <xsl:text>0</xsl:text>
                </multi:totalSize>
              </multi:Applicants__r>
            </multi:records>
            <multi:totalSize>
              <xsl:text>0</xsl:text>
            </multi:totalSize>
          </ns0:QueryResult>
        </xsl:if>
      </ns0:Multi>
      <xsl:if test=""$var:v1"">
        <ns0:BorrowerBusinessTypes>
          <bbt:BorrowerBusinessType>
            <ns2:LegalOrgTypeMapping>
              <ns2:ETranLegalOrgTypeCode>
                <xsl:text>0</xsl:text>
              </ns2:ETranLegalOrgTypeCode>
            </ns2:LegalOrgTypeMapping>
          </bbt:BorrowerBusinessType>
        </ns0:BorrowerBusinessTypes>
      </xsl:if>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:ETRAN_Originate_App_Defaults"">
        <ns0:ETRAN_Originate_App_Defaults>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:ETRAN_Originate_App_Defaults>
      </xsl:for-each>
      <xsl:if test=""$var:v1"">
        <ns0:SBA_ETran_Response />
      </xsl:if>
      <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Event_Request__c"">
        <ns0:Event_Request__c>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </ns0:Event_Request__c>
      </xsl:for-each>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
        
        private const global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.Request _srcSchemaTypeReference1 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical";
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+Request";
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
