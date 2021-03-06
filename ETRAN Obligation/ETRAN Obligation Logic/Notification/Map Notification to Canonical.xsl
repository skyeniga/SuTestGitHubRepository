<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" 
                exclude-result-prefixes="msxsl var" version="1.0" 
                xmlns:disaster="http://SBA.gov/ETRANObligation/Salesforce/Query/Disaster__c/" 
                xmlns:contact="http://SBA.gov/ETRANObligation/Salesforce/Query/Contact/" 
                xmlns:defaults="http://SBA.gov/ETRANObligation/ETRANOriginate/ETRANOriginateAppDefaults/" 
                xmlns:sforce="urn:enterprise.soap.sforce.com" 
                xmlns:sobject="urn:sobject.enterprise.soap.sforce.com" 
                xmlns:event="http://SBA.gov/ETRANObligation/Salesforce/Insert/Event_Request__c/" 
                xmlns:bustyp="http://SBA.gov/ETRANObligation/Borrower/BusinessTypeMapping/" 
                xmlns:notify="http://soap.sforce.com/2005/09/outbound" 
                xmlns:app="http://SBA.gov/ETRANObligation/Salesforce/Query/Application__c/" 
                xmlns:apl="http://SBA.gov/ETRANObligation/Salesforce/Query/Applicant__c/" 
                xmlns:canonical="http://SBA.gov/ETRANObligation/Canonical/" 
                xmlns:notify1="http://SBA.gov/ETRANObligation/Salesforce/NotificationSingle/" 
                xmlns:loan="http://SBA.gov/ETRANObligation/Salesforce/Query/Loan__c/" 
                xmlns:prop="http://SBA.gov/ETRANObligation/Salesforce/Query/Property__c/" 
                xmlns:acct="http://SBA.gov/ETRANObligation/Salesforce/Query/Account/" 
                xmlns:etran="http://ws.elend" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />  
  <xsl:template match="/">
    <xsl:apply-templates select="/notify:Notification | /notify1:Notification" />    
  </xsl:template>
  <xsl:template match="/notify:Notification | /notify1:Notification">
    <canonical:Canonical>
      <notify1:Notification>
        <notify:Id>
          <xsl:value-of select="notify:Id/text()" />
        </notify:Id>
        <notify:sObject>
          <xsl:for-each select="notify:sObject/sobject:fieldsToNull">
            <xsl:variable name="var:v1" select="string(./@xsi:nil) = 'true'" />
            <xsl:if test="string($var:v1)='true'">
              <sobject:fieldsToNull>
                <xsl:attribute name="xsi:nil">
                  <xsl:value-of select="'true'" />
                </xsl:attribute>
              </sobject:fieldsToNull>
            </xsl:if>
            <xsl:if test="string($var:v1)='false'">
              <sobject:fieldsToNull>
                <xsl:value-of select="./text()" />
              </sobject:fieldsToNull>
            </xsl:if>
          </xsl:for-each>
          <xsl:variable name="var:v2" select="string(notify:sObject/sobject:Id/@xsi:nil) = 'true'" />
          <xsl:if test="string($var:v2)='true'">
            <sobject:Id>
              <xsl:attribute name="xsi:nil">
                <xsl:value-of select="'true'" />
              </xsl:attribute>
            </sobject:Id>
          </xsl:if>
          <xsl:if test="string($var:v2)='false'">
            <sobject:Id>
              <xsl:value-of select="notify:sObject/sobject:Id/text()" />
            </sobject:Id>
          </xsl:if>
          <xsl:if test="notify:sObject/sobject:Application_Number__c">
            <xsl:variable name="var:v3" select="string(notify:sObject/sobject:Application_Number__c/@xsi:nil) = 'true'" />
            <xsl:if test="string($var:v3)='true'">
              <sobject:Application_Number__c>
                <xsl:attribute name="xsi:nil">
                  <xsl:value-of select="'true'" />
                </xsl:attribute>
              </sobject:Application_Number__c>
            </xsl:if>
            <xsl:if test="string($var:v3)='false'">
              <sobject:Application_Number__c>
                <xsl:value-of select="notify:sObject/sobject:Application_Number__c/text()" />
              </sobject:Application_Number__c>
            </xsl:if>
          </xsl:if>
          <xsl:if test="notify:sObject/sobject:SObject_ID__c">
            <xsl:variable name="var:v4" select="string(notify:sObject/sobject:SObject_ID__c/@xsi:nil) = 'true'" />
            <xsl:if test="string($var:v4)='true'">
              <sobject:SObject_ID__c>
                <xsl:attribute name="xsi:nil">
                  <xsl:value-of select="'true'" />
                </xsl:attribute>
              </sobject:SObject_ID__c>
            </xsl:if>
            <xsl:if test="string($var:v4)='false'">
              <sobject:SObject_ID__c>
                <xsl:value-of select="notify:sObject/sobject:SObject_ID__c/text()" />
              </sobject:SObject_ID__c>
            </xsl:if>
          </xsl:if>
          <xsl:value-of select="notify:sObject/text()" />
        </notify:sObject>
      </notify1:Notification>
      <canonical:ETRAN_Originate_App_Defaults>
        <defaults:LoanApplication>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:InterestStructureCd>
            <xsl:text>F</xsl:text>
          </defaults:InterestStructureCd>
          <defaults:NetEarningsClause>
            <xsl:text>N</xsl:text>
          </defaults:NetEarningsClause>
          <defaults:RevolvingInd>
            <xsl:text>N</xsl:text>
          </defaults:RevolvingInd>
        </defaults:LoanApplication>
        <defaults:Interest>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:BaseRateSourcTypCd>
            <xsl:text>DSR</xsl:text>
          </defaults:BaseRateSourcTypCd>
          <defaults:IntrstTypInd>
            <xsl:text>F</xsl:text>
          </defaults:IntrstTypInd>
          <defaults:Phase>
            <xsl:text>1</xsl:text>
          </defaults:Phase>
        </defaults:Interest>
        <defaults:Borrower>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:CreditScorSourcCd>
            <xsl:text>13</xsl:text>
          </defaults:CreditScorSourcCd>
          <defaults:PhysCountryCd>
            <xsl:text>US</xsl:text>
          </defaults:PhysCountryCd>
        </defaults:Borrower>
        <defaults:BorrowerRace>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:RaceCd>
            <xsl:text>6</xsl:text>
          </defaults:RaceCd>
        </defaults:BorrowerRace>
        <defaults:Principal>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:EthnicCd>
            <xsl:text>UN</xsl:text>
          </defaults:EthnicCd>
          <defaults:ExtrnlCreditScorInd>
            <xsl:text>N</xsl:text>
          </defaults:ExtrnlCreditScorInd>
          <defaults:GndrCd>
            <xsl:text>U</xsl:text>
          </defaults:GndrCd>
          <defaults:GntyInd>
            <xsl:text>N</xsl:text>
          </defaults:GntyInd>
          <defaults:VetCd>
            <xsl:text>5</xsl:text>
          </defaults:VetCd>
        </defaults:Principal>
        <defaults:PrincipalRace>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:RaceCd>
            <xsl:text>6</xsl:text>
          </defaults:RaceCd>
        </defaults:PrincipalRace>
        <defaults:UseOfProceeds>
          <xsl:attribute name="defaults:action">
            <xsl:text>insert</xsl:text>
          </xsl:attribute>
          <defaults:LoanProceedTypCd>
            <xsl:text>05</xsl:text>
          </defaults:LoanProceedTypCd>
          <defaults:ProceedTypCd>
            <xsl:text>D</xsl:text>
          </defaults:ProceedTypCd>
        </defaults:UseOfProceeds>
      </canonical:ETRAN_Originate_App_Defaults>
    </canonical:Canonical>
  </xsl:template>
</xsl:stylesheet>