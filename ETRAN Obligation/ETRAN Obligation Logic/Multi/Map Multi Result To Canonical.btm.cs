namespace SBA.ETRANObligation.Logic.Multi {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+QueryResult", typeof(global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical", typeof(global::SBA.ETRANObligation.Definition.Canonical.ETRANObligationCanonical))]
    public sealed class Map_Multi_Result_To_Canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
        <xsl:for-each select=""InputMessagePart_0/ns0:Canonical/ns0:Multi"">
          <xsl:for-each select=""ns0:Request"">
            <ns0:Request>
              <xsl:copy-of select=""./@*"" />
              <xsl:copy-of select=""./*"" />
            </ns0:Request>
          </xsl:for-each>
        </xsl:for-each>
        <ns0:QueryResult>
          <multi:done>
            <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:done/text()"" />
          </multi:done>
          <multi:records>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/@type"">
              <xsl:attribute name=""type"">
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/@type"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/@url"">
              <xsl:attribute name=""url"">
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/@url"" />
              </xsl:attribute>
            </xsl:if>
            <multi:Id>
              <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Id/text()"" />
            </multi:Id>
            <multi:RecordType>
              <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/@type"">
                <xsl:attribute name=""type"">
                  <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/@type"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/@url"">
                <xsl:attribute name=""url"">
                  <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/@url"" />
                </xsl:attribute>
              </xsl:if>
              <multi:Name>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/multi:Name/text()"" />
              </multi:Name>
              <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:RecordType/text()"" />
            </multi:RecordType>
            <multi:Name>
              <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Name/text()"" />
            </multi:Name>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Previous_SBA_Loans__c"">
              <multi:Previous_SBA_Loans__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Previous_SBA_Loans__c/text()"" />
              </multi:Previous_SBA_Loans__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loan_Type__c"">
              <multi:Loan_Type__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loan_Type__c/text()"" />
              </multi:Loan_Type__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Org_Type__c"">
              <multi:Org_Type__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Org_Type__c/text()"" />
              </multi:Org_Type__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Application_Type__c"">
              <multi:Application_Type__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Application_Type__c/text()"" />
              </multi:Application_Type__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loan_Type2__c"">
              <multi:Loan_Type2__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loan_Type2__c/text()"" />
              </multi:Loan_Type2__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loss_Type__c"">
              <multi:Loss_Type__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loss_Type__c/text()"" />
              </multi:Loss_Type__c>
            </xsl:if>
            <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:FEMA_Registration_Number__c"">
              <multi:FEMA_Registration_Number__c>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:FEMA_Registration_Number__c/text()"" />
              </multi:FEMA_Registration_Number__c>
            </xsl:if>
            <multi:Loans__r>
              <multi:done>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:done/text()"" />
              </multi:done>
              <multi:records>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/@type"">
                  <xsl:attribute name=""type"">
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/@type"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/@url"">
                  <xsl:attribute name=""url"">
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/@url"" />
                  </xsl:attribute>
                </xsl:if>
                <multi:Id>
                  <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Id/text()"" />
                </multi:Id>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Interest_Rate__c"">
                  <multi:Interest_Rate__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Interest_Rate__c/text()"" />
                  </multi:Interest_Rate__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Loan_Amount__c"">
                  <multi:Loan_Amount__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Loan_Amount__c/text()"" />
                  </multi:Loan_Amount__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Payment_Amount__c"">
                  <multi:Payment_Amount__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Payment_Amount__c/text()"" />
                  </multi:Payment_Amount__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Secure__c"">
                  <multi:Secure__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Secure__c/text()"" />
                  </multi:Secure__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Servicing_Office__c"">
                  <multi:Servicing_Office__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Servicing_Office__c/text()"" />
                  </multi:Servicing_Office__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Total_Term__c"">
                  <multi:Total_Term__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Total_Term__c/text()"" />
                  </multi:Total_Term__c>
                </xsl:if>
                <xsl:if test=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__c"">
                  <multi:Disaster_Declaration__c>
                    <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__c/text()"" />
                  </multi:Disaster_Declaration__c>
                </xsl:if>
                <xsl:for-each select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/multi:Disaster_Declaration__r"">
                  <multi:Disaster_Declaration__r>
                    <xsl:if test=""@type"">
                      <xsl:attribute name=""type"">
                        <xsl:value-of select=""@type"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""@url"">
                      <xsl:attribute name=""url"">
                        <xsl:value-of select=""@url"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""multi:Name"">
                      <multi:Name>
                        <xsl:value-of select=""multi:Name/text()"" />
                      </multi:Name>
                    </xsl:if>
                    <xsl:if test=""multi:Disaster_Damaged_Type__c"">
                      <multi:Disaster_Damaged_Type__c>
                        <xsl:value-of select=""multi:Disaster_Damaged_Type__c/text()"" />
                      </multi:Disaster_Damaged_Type__c>
                    </xsl:if>
                    <xsl:if test=""multi:Physical_Number__c"">
                      <multi:Physical_Number__c>
                        <xsl:value-of select=""multi:Physical_Number__c/text()"" />
                      </multi:Physical_Number__c>
                    </xsl:if>
                    <xsl:if test=""multi:EIDL_Number__c"">
                      <multi:EIDL_Number__c>
                        <xsl:value-of select=""multi:EIDL_Number__c/text()"" />
                      </multi:EIDL_Number__c>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </multi:Disaster_Declaration__r>
                </xsl:for-each>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:records/text()"" />
              </multi:records>
              <multi:totalSize>
                <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/multi:totalSize/text()"" />
              </multi:totalSize>
              <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Loans__r/text()"" />
            </multi:Loans__r>
            <xsl:for-each select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Processing_Application_Review__r"">
              <multi:Processing_Application_Review__r>
                <multi:done>
                  <xsl:value-of select=""multi:done/text()"" />
                </multi:done>
                <xsl:for-each select=""multi:records"">
                  <multi:records>
                    <xsl:if test=""@type"">
                      <xsl:attribute name=""type"">
                        <xsl:value-of select=""@type"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""@url"">
                      <xsl:attribute name=""url"">
                        <xsl:value-of select=""@url"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""multi:Credit_Elsewhere_Test__c"">
                      <multi:Credit_Elsewhere_Test__c>
                        <xsl:value-of select=""multi:Credit_Elsewhere_Test__c/text()"" />
                      </multi:Credit_Elsewhere_Test__c>
                    </xsl:if>
                    <xsl:if test=""multi:Physical_Allocated_Amount__c"">
                      <multi:Physical_Allocated_Amount__c>
                        <xsl:value-of select=""multi:Physical_Allocated_Amount__c/text()"" />
                      </multi:Physical_Allocated_Amount__c>
                    </xsl:if>
                    <xsl:if test=""multi:EIDL_Allocated_Amount__c"">
                      <multi:EIDL_Allocated_Amount__c>
                        <xsl:value-of select=""multi:EIDL_Allocated_Amount__c/text()"" />
                      </multi:EIDL_Allocated_Amount__c>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </multi:records>
                </xsl:for-each>
                <multi:totalSize>
                  <xsl:value-of select=""multi:totalSize/text()"" />
                </multi:totalSize>
                <xsl:value-of select=""./text()"" />
              </multi:Processing_Application_Review__r>
            </xsl:for-each>
            <xsl:for-each select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Property__r"">
              <multi:Property__r>
                <multi:done>
                  <xsl:value-of select=""multi:done/text()"" />
                </multi:done>
                <xsl:for-each select=""multi:records"">
                  <multi:records>
                    <xsl:if test=""@type"">
                      <xsl:attribute name=""type"">
                        <xsl:value-of select=""@type"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""@url"">
                      <xsl:attribute name=""url"">
                        <xsl:value-of select=""@url"" />
                      </xsl:attribute>
                    </xsl:if>
                    <multi:Id>
                      <xsl:value-of select=""multi:Id/text()"" />
                    </multi:Id>
                    <xsl:if test=""multi:Property_Address__c"">
                      <multi:Property_Address__c>
                        <xsl:value-of select=""multi:Property_Address__c/text()"" />
                      </multi:Property_Address__c>
                    </xsl:if>
                    <xsl:if test=""multi:City__c"">
                      <multi:City__c>
                        <xsl:value-of select=""multi:City__c/text()"" />
                      </multi:City__c>
                    </xsl:if>
                    <xsl:if test=""multi:State__c"">
                      <multi:State__c>
                        <xsl:value-of select=""multi:State__c/text()"" />
                      </multi:State__c>
                    </xsl:if>
                    <xsl:if test=""multi:Zip_Code__c"">
                      <multi:Zip_Code__c>
                        <xsl:value-of select=""multi:Zip_Code__c/text()"" />
                      </multi:Zip_Code__c>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </multi:records>
                </xsl:for-each>
                <multi:totalSize>
                  <xsl:value-of select=""multi:totalSize/text()"" />
                </multi:totalSize>
                <xsl:value-of select=""./text()"" />
              </multi:Property__r>
            </xsl:for-each>
            <xsl:for-each select=""InputMessagePart_1/multi:QueryResult/multi:records/multi:Applicants__r"">
              <multi:Applicants__r>
                <multi:done>
                  <xsl:value-of select=""multi:done/text()"" />
                </multi:done>
                <xsl:for-each select=""multi:records"">
                  <multi:records>
                    <xsl:if test=""@type"">
                      <xsl:attribute name=""type"">
                        <xsl:value-of select=""@type"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""@url"">
                      <xsl:attribute name=""url"">
                        <xsl:value-of select=""@url"" />
                      </xsl:attribute>
                    </xsl:if>
                    <multi:Id>
                      <xsl:value-of select=""multi:Id/text()"" />
                    </multi:Id>
                    <multi:RecordType>
                      <xsl:if test=""multi:RecordType/@type"">
                        <xsl:attribute name=""type"">
                          <xsl:value-of select=""multi:RecordType/@type"" />
                        </xsl:attribute>
                      </xsl:if>
                      <xsl:if test=""multi:RecordType/@url"">
                        <xsl:attribute name=""url"">
                          <xsl:value-of select=""multi:RecordType/@url"" />
                        </xsl:attribute>
                      </xsl:if>
                      <multi:Name>
                        <xsl:value-of select=""multi:RecordType/multi:Name/text()"" />
                      </multi:Name>
                      <xsl:value-of select=""multi:RecordType/text()"" />
                    </multi:RecordType>
                    <multi:Name>
                      <xsl:value-of select=""multi:Name/text()"" />
                    </multi:Name>
                    <xsl:if test=""multi:Primary_Applicant__c"">
                      <multi:Primary_Applicant__c>
                        <xsl:value-of select=""multi:Primary_Applicant__c/text()"" />
                      </multi:Primary_Applicant__c>
                    </xsl:if>
                    <xsl:if test=""multi:Tax_ID__c"">
                      <multi:Tax_ID__c>
                        <xsl:value-of select=""multi:Tax_ID__c/text()"" />
                      </multi:Tax_ID__c>
                    </xsl:if>
                    <xsl:for-each select=""multi:Related_Parent__r"">
                      <multi:Related_Parent__r>
                        <xsl:if test=""@type"">
                          <xsl:attribute name=""type"">
                            <xsl:value-of select=""@type"" />
                          </xsl:attribute>
                        </xsl:if>
                        <xsl:if test=""@url"">
                          <xsl:attribute name=""url"">
                            <xsl:value-of select=""@url"" />
                          </xsl:attribute>
                        </xsl:if>
                        <xsl:if test=""multi:Tax_ID__c"">
                          <multi:Tax_ID__c>
                            <xsl:value-of select=""multi:Tax_ID__c/text()"" />
                          </multi:Tax_ID__c>
                        </xsl:if>
                        <xsl:value-of select=""./text()"" />
                      </multi:Related_Parent__r>
                    </xsl:for-each>
                    <xsl:if test=""multi:Entity_Type__c"">
                      <multi:Entity_Type__c>
                        <xsl:value-of select=""multi:Entity_Type__c/text()"" />
                      </multi:Entity_Type__c>
                    </xsl:if>
                    <xsl:if test=""multi:Applicant_Relation_Type__c"">
                      <multi:Applicant_Relation_Type__c>
                        <xsl:value-of select=""multi:Applicant_Relation_Type__c/text()"" />
                      </multi:Applicant_Relation_Type__c>
                    </xsl:if>
                    <xsl:if test=""multi:Ownership_Percent__c"">
                      <multi:Ownership_Percent__c>
                        <xsl:value-of select=""multi:Ownership_Percent__c/text()"" />
                      </multi:Ownership_Percent__c>
                    </xsl:if>
                    <xsl:if test=""multi:Borrower_Guarantor__c"">
                      <multi:Borrower_Guarantor__c>
                        <xsl:value-of select=""multi:Borrower_Guarantor__c/text()"" />
                      </multi:Borrower_Guarantor__c>
                    </xsl:if>
                    <xsl:for-each select=""multi:Account__r"">
                      <multi:Account__r>
                        <xsl:if test=""@type"">
                          <xsl:attribute name=""type"">
                            <xsl:value-of select=""@type"" />
                          </xsl:attribute>
                        </xsl:if>
                        <xsl:if test=""@url"">
                          <xsl:attribute name=""url"">
                            <xsl:value-of select=""@url"" />
                          </xsl:attribute>
                        </xsl:if>
                        <multi:Id>
                          <xsl:value-of select=""multi:Id/text()"" />
                        </multi:Id>
                        <multi:Name>
                          <xsl:value-of select=""multi:Name/text()"" />
                        </multi:Name>
                        <xsl:if test=""multi:Business_Type__c"">
                          <multi:Business_Type__c>
                            <xsl:value-of select=""multi:Business_Type__c/text()"" />
                          </multi:Business_Type__c>
                        </xsl:if>
                        <xsl:if test=""multi:Trade_Name__c"">
                          <multi:Trade_Name__c>
                            <xsl:value-of select=""multi:Trade_Name__c/text()"" />
                          </multi:Trade_Name__c>
                        </xsl:if>
                        <xsl:if test=""multi:Phone"">
                          <multi:Phone>
                            <xsl:value-of select=""multi:Phone/text()"" />
                          </multi:Phone>
                        </xsl:if>
                        <xsl:if test=""multi:Phone_Number__c"">
                          <multi:Phone_Number__c>
                            <xsl:value-of select=""multi:Phone_Number__c/text()"" />
                          </multi:Phone_Number__c>
                        </xsl:if>
                        <xsl:if test=""multi:ShippingStreet"">
                          <multi:ShippingStreet>
                            <xsl:value-of select=""multi:ShippingStreet/text()"" />
                          </multi:ShippingStreet>
                        </xsl:if>
                        <xsl:if test=""multi:ShippingCity"">
                          <multi:ShippingCity>
                            <xsl:value-of select=""multi:ShippingCity/text()"" />
                          </multi:ShippingCity>
                        </xsl:if>
                        <xsl:if test=""multi:ShippingState"">
                          <multi:ShippingState>
                            <xsl:value-of select=""multi:ShippingState/text()"" />
                          </multi:ShippingState>
                        </xsl:if>
                        <xsl:if test=""multi:ShippingPostalCode"">
                          <multi:ShippingPostalCode>
                            <xsl:value-of select=""multi:ShippingPostalCode/text()"" />
                          </multi:ShippingPostalCode>
                        </xsl:if>
                        <xsl:value-of select=""./text()"" />
                      </multi:Account__r>
                    </xsl:for-each>
                    <xsl:for-each select=""multi:Contact__r"">
                      <multi:Contact__r>
                        <xsl:if test=""@type"">
                          <xsl:attribute name=""type"">
                            <xsl:value-of select=""@type"" />
                          </xsl:attribute>
                        </xsl:if>
                        <xsl:if test=""@url"">
                          <xsl:attribute name=""url"">
                            <xsl:value-of select=""@url"" />
                          </xsl:attribute>
                        </xsl:if>
                        <multi:Id>
                          <xsl:value-of select=""multi:Id/text()"" />
                        </multi:Id>
                        <xsl:if test=""multi:Birthdate"">
                          <multi:Birthdate>
                            <xsl:value-of select=""multi:Birthdate/text()"" />
                          </multi:Birthdate>
                        </xsl:if>
                        <xsl:if test=""multi:Title"">
                          <multi:Title>
                            <xsl:value-of select=""multi:Title/text()"" />
                          </multi:Title>
                        </xsl:if>
                        <xsl:if test=""multi:FirstName"">
                          <multi:FirstName>
                            <xsl:value-of select=""multi:FirstName/text()"" />
                          </multi:FirstName>
                        </xsl:if>
                        <xsl:if test=""multi:LastName"">
                          <multi:LastName>
                            <xsl:value-of select=""multi:LastName/text()"" />
                          </multi:LastName>
                        </xsl:if>
                        <xsl:if test=""multi:MiddleName"">
                          <multi:MiddleName>
                            <xsl:value-of select=""multi:MiddleName/text()"" />
                          </multi:MiddleName>
                        </xsl:if>
                        <xsl:if test=""multi:Suffix"">
                          <multi:Suffix>
                            <xsl:value-of select=""multi:Suffix/text()"" />
                          </multi:Suffix>
                        </xsl:if>
                        <xsl:if test=""multi:Phone"">
                          <multi:Phone>
                            <xsl:value-of select=""multi:Phone/text()"" />
                          </multi:Phone>
                        </xsl:if>
                        <xsl:if test=""multi:MobilePhone"">
                          <multi:MobilePhone>
                            <xsl:value-of select=""multi:MobilePhone/text()"" />
                          </multi:MobilePhone>
                        </xsl:if>
                        <xsl:if test=""multi:Work_Phone__c"">
                          <multi:Work_Phone__c>
                            <xsl:value-of select=""multi:Work_Phone__c/text()"" />
                          </multi:Work_Phone__c>
                        </xsl:if>
                        <xsl:if test=""multi:MailingStreet"">
                          <multi:MailingStreet>
                            <xsl:value-of select=""multi:MailingStreet/text()"" />
                          </multi:MailingStreet>
                        </xsl:if>
                        <xsl:if test=""multi:MailingCity"">
                          <multi:MailingCity>
                            <xsl:value-of select=""multi:MailingCity/text()"" />
                          </multi:MailingCity>
                        </xsl:if>
                        <xsl:if test=""multi:MailingState"">
                          <multi:MailingState>
                            <xsl:value-of select=""multi:MailingState/text()"" />
                          </multi:MailingState>
                        </xsl:if>
                        <xsl:if test=""multi:MailingPostalCode"">
                          <multi:MailingPostalCode>
                            <xsl:value-of select=""multi:MailingPostalCode/text()"" />
                          </multi:MailingPostalCode>
                        </xsl:if>
                        <xsl:value-of select=""./text()"" />
                      </multi:Contact__r>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </multi:records>
                </xsl:for-each>
                <multi:totalSize>
                  <xsl:value-of select=""multi:totalSize/text()"" />
                </multi:totalSize>
                <xsl:value-of select=""./text()"" />
              </multi:Applicants__r>
            </xsl:for-each>
            <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:records/text()"" />
          </multi:records>
          <multi:totalSize>
            <xsl:value-of select=""InputMessagePart_1/multi:QueryResult/multi:totalSize/text()"" />
          </multi:totalSize>
        </ns0:QueryResult>
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
        
        private const string _strSrcSchemasList1 = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+QueryResult";
        
        private const global::SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query.QueryResult _srcSchemaTypeReference1 = null;
        
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
                _SrcSchemas[1] = @"SBA.ETRANObligation.Definition.Salesforce.Multi.Salesforce_Multi_Query+QueryResult";
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
