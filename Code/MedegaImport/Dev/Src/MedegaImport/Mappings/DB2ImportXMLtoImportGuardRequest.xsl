<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s1 s0 userCSharp" version="1.0" xmlns:s1="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:s0="http://inami-riziv.fgov.be.medega" xmlns:ns0="http://riziv.fgov.be/GuardsImportService" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s1:Root" />
  </xsl:template>
  <xsl:template match="/s1:Root">
    <xsl:variable name="var:v1" select="userCSharp:StringConcat(&quot;&quot;)" />
    <ns0:ImportMedegaGuardRequest>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@PERIODID">
        <ns0:PeriodId>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@PERIODID" />
        </ns0:PeriodId>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@FILEID">
        <ns0:FileId>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@FILEID" />
        </ns0:FileId>
      </xsl:if>
      <ns0:ImportXmlId>
		  <xsl:value-of select="InputMessagePart_1/*[local-name()='ImportXmlResponse']/*[local-name()='Success']/*[local-name()='IMPORTXML']/@*[local-name()='IMPORTGUARDID']" />
      </ns0:ImportXmlId>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@INAMINUMBER">
        <ns0:RizivNumber>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@INAMINUMBER" />
        </ns0:RizivNumber>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERLASTNAME">
        <ns0:LastName>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERLASTNAME" />
        </ns0:LastName>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERFIRSTNAME">
        <ns0:FirstName>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERFIRSTNAME" />
        </ns0:FirstName>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERBANKACCOUNT">
        <ns0:BankAccountNumber>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MEMBERBANKACCOUNT" />
        </ns0:BankAccountNumber>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@FEEDATE">
        <ns0:GuardDate>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@FEEDATE" />
        </ns0:GuardDate>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@STARTTIME">
        <ns0:GuardStartTime>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@STARTTIME" />
        </ns0:GuardStartTime>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ENDTIME">
        <ns0:GuardEndTime>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ENDTIME" />
        </ns0:GuardEndTime>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ASSOCIATIONID">
        <ns0:ZoneId>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ASSOCIATIONID" />
        </ns0:ZoneId>
      </xsl:if>
      <ns0:ZoneName>
        <xsl:value-of select="$var:v1" />
      </ns0:ZoneName>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@GEOGRAPHICENTITYNAME">
        <ns0:GeographicEntityName>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@GEOGRAPHICENTITYNAME" />
        </ns0:GeographicEntityName>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@NISCODE">
        <ns0:NisCode>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@NISCODE" />
        </ns0:NisCode>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ZIPCODE">
        <ns0:ZipCode>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@ZIPCODE" />
        </ns0:ZipCode>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERINAMINUMBER">
        <ns0:ResponsableRizivNumber>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERINAMINUMBER" />
        </ns0:ResponsableRizivNumber>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERLASTNAME">
        <ns0:ResponsableLastName>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERLASTNAME" />
        </ns0:ResponsableLastName>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERFIRSTNAME">
        <ns0:ResponsableFirstName>
          <xsl:value-of select="InputMessagePart_0/s0:ImportXmlRequest/sync/StoredProcedure/IMPORTXML/@MANAGERFIRSTNAME" />
        </ns0:ResponsableFirstName>
      </xsl:if>
    </ns0:ImportMedegaGuardRequest>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>