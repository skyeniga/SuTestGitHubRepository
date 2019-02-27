namespace DLAPEventsLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response", typeof(global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPEventsDefinition.EventDocumentListResponse", typeof(global::DLAPEventsDefinition.EventDocumentListResponse))]
    public sealed class MakeEventsDocumentResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPEventsDocument/Checklist_Item__c"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s1=""http://SBA.gov/DLAPEvents/Application_Info__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(InputMessagePart_1/s0:Response/s0:row/s0:Id))"" />
    <xsl:variable name=""var:v2"" select=""count(/s2:Root/InputMessagePart_1/s0:Response/s0:row/s0:Id)"" />
    <DOCUMENT>
      <AppData>
        <xsl:if test=""InputMessagePart_0/s1:Response/s1:row/s1:ApplicationName"">
          <App_Nbr>
            <xsl:value-of select=""InputMessagePart_0/s1:Response/s1:row/s1:ApplicationName/text()"" />
          </App_Nbr>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s1:Response/s1:row/s1:ApplicationLoanType"">
          <Loan_Type>
            <xsl:value-of select=""InputMessagePart_0/s1:Response/s1:row/s1:ApplicationLoanType/text()"" />
          </Loan_Type>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s1:Response/s1:row/s1:Disaster_Name"">
          <Disaster_Name>
            <xsl:value-of select=""InputMessagePart_0/s1:Response/s1:row/s1:Disaster_Name/text()"" />
          </Disaster_Name>
        </xsl:if>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v3"" select=""string($var:v2)"" />
          <Requested_Document_Count>
            <xsl:value-of select=""$var:v3"" />
          </Requested_Document_Count>
        </xsl:if>
        <xsl:if test=""InputMessagePart_0/s1:Response/s1:row/s1:DisasterDeadlineDate"">
          <Disaster_Deadline_Date>
            <xsl:value-of select=""InputMessagePart_0/s1:Response/s1:row/s1:DisasterDeadlineDate/text()"" />
          </Disaster_Deadline_Date>
        </xsl:if>
      </AppData>
      <ApplicantList>
        <xsl:for-each select=""InputMessagePart_0/s1:Response/s1:row"">
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalExistence(boolean(s1:ApplicantId))"" />
          <xsl:if test=""$var:v4"">
            <Applicants>
              <xsl:if test=""s1:ApplicantId"">
                <ApplicantId>
                  <xsl:value-of select=""s1:ApplicantId/text()"" />
                </ApplicantId>
              </xsl:if>
              <xsl:if test=""s1:ApplicantName"">
                <LegalName>
                  <xsl:value-of select=""s1:ApplicantName/text()"" />
                </LegalName>
              </xsl:if>
              <xsl:if test=""s1:ApplicantRelationType"">
                <APL_RELATION_TYPE>
                  <xsl:value-of select=""s1:ApplicantRelationType/text()"" />
                </APL_RELATION_TYPE>
              </xsl:if>
            </Applicants>
          </xsl:if>
        </xsl:for-each>
      </ApplicantList>
      <DocumentList>
        <xsl:for-each select=""InputMessagePart_1/s0:Response/s0:row"">
          <DocumentDetails>
            <xsl:if test=""s0:Type__c"">
              <ChecklistType>
                <xsl:value-of select=""s0:Type__c/text()"" />
              </ChecklistType>
            </xsl:if>
            <xsl:if test=""s0:Id"">
              <ActionID>
                <xsl:value-of select=""s0:Id/text()"" />
              </ActionID>
            </xsl:if>
            <xsl:if test=""s0:Checklist_Item_Status__c"">
              <Status>
                <xsl:value-of select=""s0:Checklist_Item_Status__c/text()"" />
              </Status>
            </xsl:if>
            <xsl:if test=""s0:Verified_Date__c"">
              <ReceiveDate>
                <xsl:value-of select=""s0:Verified_Date__c/text()"" />
              </ReceiveDate>
            </xsl:if>
            <xsl:if test=""s0:Id"">
              <ScanDocumentID>
                <xsl:value-of select=""s0:Id/text()"" />
              </ScanDocumentID>
            </xsl:if>
            <xsl:if test=""s0:Name"">
              <DocumentTitle>
                <xsl:value-of select=""s0:Name/text()"" />
              </DocumentTitle>
            </xsl:if>
            <xsl:if test=""s0:Checklist_Item_Text__c"">
              <DocumentDescription>
                <xsl:value-of select=""s0:Checklist_Item_Text__c/text()"" />
              </DocumentDescription>
            </xsl:if>
          </DocumentDetails>
        </xsl:for-each>
      </DocumentList>
    </DOCUMENT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList1 = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
        
        private const global::DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c.Response _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPEventsDefinition.EventDocumentListResponse";
        
        private const global::DLAPEventsDefinition.EventDocumentListResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPEventsSalesforceDefinition.SalesforceQuery__Application_Info__c+Response";
                _SrcSchemas[1] = @"DLAPEventsSalesforceDefinition.SalesforceQuery_Document_Checklist_Item__c+Response";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPEventsDefinition.EventDocumentListResponse";
                return _TrgSchemas;
            }
        }
    }
}
