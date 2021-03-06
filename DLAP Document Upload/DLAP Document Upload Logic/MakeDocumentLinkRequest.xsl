<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0 userCSharp" version="1.0" xmlns:s0="http://DocumentUploadDefinition/ContentLinkRequestInfo" xmlns:ns0="http://SBA.gov/DLAPDocumentUpload/ContentDocumentlink" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:ContentLinkRequestInfo" />
  </xsl:template>
  <xsl:template match="/s0:ContentLinkRequestInfo">
    <xsl:variable name="var:v1" select="userCSharp:LogicalExistence(boolean(ACTION_ID))" />
    <xsl:variable name="var:v2" select="userCSharp:LogicalNe(string(ACTION_ID/text()) , &quot;0&quot;)" />
    <xsl:variable name="var:v4" select="userCSharp:LogicalAnd(string($var:v1) , string($var:v2))" />
    <xsl:variable name="var:v15" select="userCSharp:LogicalExistence(boolean(RECEIPTDOCUMENT_ID))" />
    <xsl:variable name="var:v16" select="userCSharp:StringSize(string(RECEIPTDOCUMENT_ID/text()))" />
    <xsl:variable name="var:v17" select="userCSharp:LogicalGt(string($var:v16) , &quot;2&quot;)" />
    <xsl:variable name="var:v18" select="userCSharp:LogicalAnd(string($var:v15) , string($var:v17))" />
    <xsl:variable name="var:v30" select="userCSharp:LogicalExistence(boolean(APPLICATIONSFID))" />
    <xsl:variable name="var:v31" select="userCSharp:StringSize(string(APPLICATIONSFID/text()))" />
    <xsl:variable name="var:v32" select="userCSharp:LogicalGt(string($var:v31) , &quot;1&quot;)" />
    <xsl:variable name="var:v33" select="userCSharp:LogicalAnd(string($var:v30) , string($var:v32))" />
    <xsl:variable name="var:v1001" select="userCSharp:LogicalExistence(boolean(RECEIPTLOAN_NUMBER))" />
    <xsl:variable name="var:v1002" select="userCSharp:StringSize(string(RECEIPTLOAN_NUMBER/text()))" />
    <xsl:variable name="var:v1003" select="userCSharp:LogicalGt(string($var:v1002) , &quot;1&quot;)" />
    <xsl:variable name="var:v1004" select="userCSharp:LogicalAnd(string($var:v1001) , string($var:v1003))" />
    <ns0:Request>
      <ns0:sync>
        <xsl:if test="$var:v4">
          <xsl:variable name="var:v5" select="boolean(ACTION_ID)" />
          <xsl:variable name="var:v6" select="userCSharp:LogicalExistence($var:v5)" />
          <xsl:variable name="var:v7" select="string(ACTION_ID/text())" />
          <xsl:variable name="var:v9" select="userCSharp:LogicalNe($var:v7 , &quot;0&quot;)" />
          <xsl:variable name="var:v10" select="userCSharp:LogicalAnd(string($var:v6) , string($var:v9))" />
          <xsl:variable name="var:v12" select="userCSharp:StringSize(string(CONTENTVERSION_DOCUMENTID/text()))" />
          <xsl:variable name="var:v13" select="userCSharp:LogicalGt(string($var:v12) , &quot;1&quot;)" />
          <ns0:after>
            <ns0:ContentDocumentLink>
              <xsl:if test="string($var:v10)='true'">
                <xsl:variable name="var:v11" select="ACTION_ID/text()" />
                <xsl:attribute name="LinkedEntityId">
                  <xsl:value-of select="$var:v11" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test="string($var:v13)='true'">
                <xsl:variable name="var:v14" select="CONTENTVERSION_DOCUMENTID/text()" />
                <xsl:attribute name="ContentDocumentId">
                  <xsl:value-of select="$var:v14" />
                </xsl:attribute>
              </xsl:if>
              <xsl:attribute name="ShareType">
                <xsl:text>V</xsl:text>
              </xsl:attribute>
              <xsl:attribute name="Visibility">
                <xsl:text>AllUsers</xsl:text>
              </xsl:attribute>
            </ns0:ContentDocumentLink>
          </ns0:after>
        </xsl:if>
        <xsl:if test="$var:v18">
          <xsl:variable name="var:v19" select="boolean(RECEIPTDOCUMENT_ID)" />
          <xsl:variable name="var:v20" select="userCSharp:LogicalExistence($var:v19)" />
          <xsl:variable name="var:v21" select="string(RECEIPTDOCUMENT_ID/text())" />
          <xsl:variable name="var:v22" select="userCSharp:StringSize($var:v21)" />
          <xsl:variable name="var:v23" select="userCSharp:LogicalGt(string($var:v22) , &quot;2&quot;)" />
          <xsl:variable name="var:v24" select="userCSharp:LogicalAnd(string($var:v20) , string($var:v23))" />
          <xsl:variable name="var:v26" select="string(CONTENTVERSION_DOCUMENTID/text())" />
          <xsl:variable name="var:v27" select="userCSharp:StringSize($var:v26)" />
          <xsl:variable name="var:v28" select="userCSharp:LogicalGt(string($var:v27) , &quot;1&quot;)" />
          <ns0:after>
            <ns0:ContentDocumentLink>
              <xsl:if test="string($var:v24)='true'">
                <xsl:variable name="var:v25" select="RECEIPTDOCUMENT_ID/text()" />
                <xsl:attribute name="LinkedEntityId">
                  <xsl:value-of select="$var:v25" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test="string($var:v28)='true'">
                <xsl:variable name="var:v29" select="CONTENTVERSION_DOCUMENTID/text()" />
                <xsl:attribute name="ContentDocumentId">
                  <xsl:value-of select="$var:v29" />
                </xsl:attribute>
              </xsl:if>
              <xsl:attribute name="ShareType">
                <xsl:text>V</xsl:text>
              </xsl:attribute>
              <xsl:attribute name="Visibility">
                <xsl:text>AllUsers</xsl:text>
              </xsl:attribute>
            </ns0:ContentDocumentLink>
          </ns0:after>
        </xsl:if>
        <xsl:if test="$var:v33">
          <xsl:if test="not($var:v18 or $var:v1004)">
            <xsl:variable name="var:v34" select="boolean(APPLICATIONSFID)" />
            <xsl:variable name="var:v35" select="userCSharp:LogicalExistence($var:v34)" />
            <xsl:variable name="var:v36" select="string(APPLICATIONSFID/text())" />
            <xsl:variable name="var:v37" select="userCSharp:StringSize($var:v36)" />
            <xsl:variable name="var:v38" select="userCSharp:LogicalGt(string($var:v37) , &quot;1&quot;)" />
            <xsl:variable name="var:v39" select="userCSharp:LogicalAnd(string($var:v35) , string($var:v38))" />
            <xsl:variable name="var:v41" select="string(CONTENTVERSION_DOCUMENTID/text())" />
            <xsl:variable name="var:v42" select="userCSharp:StringSize($var:v41)" />
            <xsl:variable name="var:v43" select="userCSharp:LogicalGt(string($var:v42) , &quot;1&quot;)" />
            <ns0:after>
              <ns0:ContentDocumentLink>
                <xsl:if test="string($var:v39)='true'">
                  <xsl:variable name="var:v40" select="APPLICATIONSFID/text()" />
                  <xsl:attribute name="LinkedEntityId">
                    <xsl:value-of select="$var:v40" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test="string($var:v43)='true'">
                  <xsl:variable name="var:v44" select="CONTENTVERSION_DOCUMENTID/text()" />
                  <xsl:attribute name="ContentDocumentId">
                    <xsl:value-of select="$var:v44" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:attribute name="ShareType">
                  <xsl:text>V</xsl:text>
                </xsl:attribute>
                <xsl:attribute name="Visibility">
                  <xsl:text>AllUsers</xsl:text>
                </xsl:attribute>
              </ns0:ContentDocumentLink>
            </ns0:after>
          </xsl:if>
        </xsl:if>
      </ns0:sync>
    </ns0:Request>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp">
    <![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
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
public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}

]]>
  </msxsl:script>
</xsl:stylesheet>