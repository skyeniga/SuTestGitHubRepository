<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0 s2 s3 s4 s1" version="1.0" xmlns:s1="http://soap.sforce.com/2005/09/outbound" xmlns:s0="http://DLAPEventsDefinition.OrchestrationInstanceId" xmlns:s2="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:ns0="http://SBA.gov/DLAPEvents/Event_Request__c" xmlns:s3="urn:sobject.enterprise.soap.sforce.com" xmlns:s4="urn:enterprise.soap.sforce.com">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s2:Root" />
  </xsl:template>
  <xsl:template match="/s2:Root">
    <ns0:Request>
      <ns0:sync>
        <xsl:for-each select="InputMessagePart_0/s1:notifications/s1:Notification">
          <ns0:before>
            <ns0:Event_Request__c>
              <xsl:attribute name="Id">
                <xsl:value-of select="s1:sObject/s3:Id/text()" />
              </xsl:attribute>
            </ns0:Event_Request__c>
          </ns0:before>
          <ns0:after>
            <ns0:Event_Request__c>
              <xsl:attribute name="Id">
                <xsl:value-of select="s1:sObject/s3:Id/text()" />
              </xsl:attribute>
              <xsl:attribute name="GUID__c">
                <xsl:value-of select="../../../InputMessagePart_1/s0:Instance/Id/text()" />
              </xsl:attribute>
              <xsl:attribute name="Log_Message__c">
                <xsl:value-of select="../../../InputMessagePart_1/s0:Instance/ErrorMessage/text()" />
              </xsl:attribute>
              <xsl:attribute name="Stage__c">
                <xsl:text>Notification Sent to DLAP</xsl:text>
              </xsl:attribute>
              <xsl:attribute name="Status__c">
                <xsl:text>Error</xsl:text>
              </xsl:attribute>
            </ns0:Event_Request__c>
          </ns0:after>
        </xsl:for-each>
      </ns0:sync>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>