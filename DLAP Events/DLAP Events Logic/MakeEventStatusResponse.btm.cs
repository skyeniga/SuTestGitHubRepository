namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsDefinition.EventStatusResponse", typeof(global::DLAPEventsDefinition.EventStatusResponse))]
    public sealed class MakeEventStatusResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s1 s0 s3 userCSharp"" version=""1.0"" xmlns:s2=""http://SBA.gov/DLAPEvents/Checklist_Item__c"" xmlns:s1=""http://SBA.gov/DLAPEvents/Loan_Info__c"" xmlns:s0=""http://SBA.gov/DLAPEvents/Application_Info__c"" xmlns:s3=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s3:Root"" />
  </xsl:template>
  <xsl:template match=""/s3:Root"">
    <xsl:variable name=""var:v1"" select=""count(/s3:Root/InputMessagePart_1/s2:Response/s2:row/s2:Id)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalExistence(boolean(InputMessagePart_2/s1:Response/s1:row/s1:Name))"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:DateCurrentDate()"" />
    <STATUS>
      <AppData>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:ApplicationName"">
          <App_Nbr>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:ApplicationName/text()"" />
          </App_Nbr>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:ApplicationLoanType"">
          <Loan_Type>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:ApplicationLoanType/text()"" />
          </Loan_Type>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:Disaster_Name"">
          <Disaster_Name>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:Disaster_Name/text()"" />
          </Disaster_Name>
        </xsl:if>
        <Requested_Document_Count>
          <xsl:value-of select=""$var:v1"" />
        </Requested_Document_Count>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:DisasterDeadlineDate"">
          <Disaster_Deadline_Date>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:DisasterDeadlineDate/text()"" />
          </Disaster_Deadline_Date>
        </xsl:if>
        <xsl:if test=""$var:v2"">
          <xsl:variable name=""var:v3"" select=""boolean(InputMessagePart_2/s1:Response/s1:row/s1:Name)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalExistence($var:v3)"" />
          <xsl:variable name=""var:v5"" select=""InputMessagePart_2/s1:Response/s1:row/s1:Name[1]/text()"" />
          <AccountInformation>
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v6"" select=""string($var:v5)"" />
              <Loan_Nbr>
                <xsl:value-of select=""$var:v6"" />
              </Loan_Nbr>
            </xsl:if>
          </AccountInformation>
        </xsl:if>
      </AppData>
      <StatusData>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:DLAP_Status__c"">
          <Short_Description>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:DLAP_Status__c/text()"" />
          </Short_Description>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s0:Response/s0:row/s0:DLAP_Status_Description__c"">
          <Long_Description>
            <xsl:value-of select=""InputMessagePart_0/s0:Response/s0:row/s0:DLAP_Status_Description__c/text()"" />
          </Long_Description>
        </xsl:if>
        <Status_Date>
          <xsl:value-of select=""$var:v7"" />
        </Status_Date>
      </StatusData>
    </STATUS>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public bool LogicalExistence(bool val)
{
	return val;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c.Response _srcSchemaTypeReference1 = null;
        
        private const string _strSrcSchemasList2 = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c.Response _srcSchemaTypeReference2 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsDefinition.EventStatusResponse";
        
        private const global::DLAPEventsDefinition.EventStatusResponse _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [3];
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response";
                _SrcSchemas[1] = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Checklist_Item__c+Response";
                _SrcSchemas[2] = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Loan_c+Response";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsDefinition.EventStatusResponse";
                return _TrgSchemas;
            }
        }
    }
}
