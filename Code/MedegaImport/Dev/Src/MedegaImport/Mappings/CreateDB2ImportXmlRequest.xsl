<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s1 s0 userCSharp" version="1.0" xmlns:s1="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:ns0="http://inami-riziv.fgov.be.medega" xmlns:s0="http://www.riziv.fgov.be/medega/v1.0" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s1:Root" />
  </xsl:template>
  <xsl:template match="/s1:Root">
    <xsl:variable name="var:v1" select="userCSharp:StringConcat(&quot;0&quot;)" />
    <ns0:ImportXmlRequest>
      <sync>
        <StoredProcedure>
          <IMPORTXML>
			  <xsl:attribute name="FILEID">
				  <xsl:value-of select="InputMessagePart_1/*[local-name()='ImportFileResponse']/*[local-name()='Success']/*[local-name()='IMPORT_FILE']/@*[local-name()='FILEID']" />
			  </xsl:attribute>
			  <xsl:attribute name="PERIODID">
				  <xsl:value-of select="InputMessagePart_1/*[local-name()='ImportFileResponse']/*[local-name()='Success']/*[local-name()='IMPORT_FILE']/@*[local-name()='PERIODID']" />
			  </xsl:attribute>
			  <xsl:attribute name="INAMINUMBER">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MEMBER_INAMI_NUMBER']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MEMBERBANKACCOUNT">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MEMBER_BANK_ACCOUNT']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MEMBERLASTNAME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MEMBER_LASTNAME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MEMBERFIRSTNAME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MEMBER_FIRSTNAME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="FEEDATE">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='FEE_DATE']/text()" />
            </xsl:attribute>
            <xsl:attribute name="STARTTIME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='PERIOD_START_TIME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="ENDTIME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='PERIOD_END_TIME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="ASSOCIATIONID">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='ASSOCIATION_ID']/text()" />
            </xsl:attribute>
            <xsl:attribute name="GEOGRAPHICENTITYNAME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='GEOGRAPHIC_ENTITY_NAME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="NISCODE">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='NIS_CODE']/text()" />
            </xsl:attribute>
            <xsl:attribute name="ZIPCODE">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='ZIP_CODE']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MANAGERINAMINUMBER">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MANAGER_INAMI_NUMBER']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MANAGERLASTNAME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MANAGER_LASTNAME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="MANAGERFIRSTNAME">
              <xsl:value-of select="InputMessagePart_0/*[local-name()='ROW']/*[local-name()='MANAGER_FIRSTNAME']/text()" />
            </xsl:attribute>
            <xsl:attribute name="IMPORTGUARDID">
              <xsl:value-of select="$var:v1" />
            </xsl:attribute>
          </IMPORTXML>
        </StoredProcedure>
      </sync>
    </ns0:ImportXmlRequest>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>