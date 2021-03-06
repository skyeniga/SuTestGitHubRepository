<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0" version="1.0" xmlns:s0="http://DocumentUploadDefinition.DocumentUpload">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:copy>
      <xsl:value-of select="normalize-space(/*[local-name()='DOCUMENT' ]/*[local-name()='DOCUMENT_METADATA'])" disable-output-escaping="yes" />
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>