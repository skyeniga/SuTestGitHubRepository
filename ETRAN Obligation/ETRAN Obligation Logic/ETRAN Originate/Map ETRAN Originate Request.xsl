<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" 
                exclude-result-prefixes="msxsl var cred agg" 
                version="1.0" 
                xmlns:agg="http://schemas.microsoft.com/BizTalk/2003/aggschema" 
                xmlns:etran="http://ws.elend" 
                xmlns:cred="http://SBA.gov/ETranShared/ETranCredentials/">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" indent="yes" />
  <xsl:template match="*" mode="copy">
    <xsl:element name="{name()}" namespace="{namespace-uri()}">
      <xsl:apply-templates select="@*|node()" mode="copy" />
    </xsl:element>
  </xsl:template>
  <xsl:template match="@*|text()|comment()" mode="copy">
    <xsl:copy/>
  </xsl:template>
  <xsl:template match="/">
    <xsl:apply-templates select="/agg:Root" />
  </xsl:template>
  <xsl:template match="/agg:Root">
    <etran:Originate3>
      <username>
        <xsl:value-of select="InputMessagePart_1/cred:ETranCredentials/cred:username/text()" />
      </username>
      <password>
        <xsl:value-of select="InputMessagePart_1/cred:ETranCredentials/cred:password/text()" />
      </password>
      <email>
        <xsl:value-of select="InputMessagePart_1/cred:ETranCredentials/cred:email/text()" />
      </email>
      <loanappxml>
        <xsl:text disable-output-escaping="yes">&lt;![CDATA[</xsl:text>
        <SBA_ETran version="3.9">
          <xsl:apply-templates mode="copy" select="/*[local-name()='Root' and namespace-uri()='http://schemas.microsoft.com/BizTalk/2003/aggschema']/*[local-name()='InputMessagePart_0' and namespace-uri()='']/*[local-name()='SBA_ETran' and namespace-uri()='']/*[local-name()='App' and namespace-uri()='']"/>
        </SBA_ETran>
        <xsl:text disable-output-escaping="yes">]]&gt;</xsl:text>
      </loanappxml>
      <respfrmt>
        <xsl:variable name="respfrmt" select="normalize-space(InputMessagePart_1/cred:ETranCredentials/cred:respfrmt/text())" />
        <xsl:choose>
          <xsl:when test="$respfrmt">
            <xsl:value-of select="$respfrmt"/>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text/>
          </xsl:otherwise>
        </xsl:choose>
      </respfrmt>
      <softwarevendorname>
        <xsl:value-of select="InputMessagePart_1/cred:ETranCredentials/cred:softwarevendorname/text()" />
      </softwarevendorname>
    </etran:Originate3>
  </xsl:template>
</xsl:stylesheet>