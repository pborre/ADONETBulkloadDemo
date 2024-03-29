<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s1 s0 ScriptNS0" version="1.0" xmlns:s1="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:ns0="http://inami-riziv.fgov.be.medega" xmlns:s0="http://www.riziv.fgov.be/medega/v2.0" xmlns:ScriptNS0="http://schemas.microsoft.com/BizTalk/2003/ScriptNS0">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s1:Root" />
  </xsl:template>
  <xsl:template match="/s1:Root">
    <ns0:CreateMedegaXmlNodeRequest>
      <xsl:for-each select="InputMessagePart_0/s0:ROWSET/ROW">
        <ns0:sp_CreateMedegaXmlNode>
          <xsl:attribute name="AssociationId">
            <xsl:value-of select="ASSOCIATION_ID/text()" />
          </xsl:attribute>
          <xsl:attribute name="AssociationName">
            <xsl:value-of select="ASSOCIATION_NAME/text()" />
          </xsl:attribute>
          <xsl:attribute name="FeeDate">
            <xsl:value-of select="FEE_DATE/text()" />
          </xsl:attribute>
	  	  <xsl:attribute name="FileId">
		 	<xsl:value-of select="/s1:Root/InputMessagePart_1/*[local-name()='CreateMedegaFileResponse']/*[local-name()='FileId']/text()" />
		  </xsl:attribute>
          <xsl:attribute name="GeographicEntityName">
            <xsl:value-of select="GEOGRAPHIC_ENTITY_NAME/text()" />
          </xsl:attribute>
          <xsl:attribute name="ManagerFirstName">
            <xsl:value-of select="MANAGER_FIRSTNAME/text()" />
          </xsl:attribute>
          <xsl:attribute name="ManagerInamiNumber">
            <xsl:value-of select="MANAGER_INAMI_NUMBER/text()" />
          </xsl:attribute>
          <xsl:attribute name="ManagerLastName">
            <xsl:value-of select="MANAGER_LASTNAME/text()" />
          </xsl:attribute>
          <!--<xsl:attribute name="MemberBankAccount">
            <xsl:value-of select="MEMBER_BANK_ACCOUNT/text()" />
          </xsl:attribute>-->
          <!-- <xsl:if test="MEMBER_BANK_ACCOUNT_OWNER"> -->
            <!--<xsl:attribute name="MemberBankAccountOwner">
              <xsl:value-of select="MEMBER_BANK_ACCOUNT_OWNER/text()" />
            </xsl:attribute>-->
          <!-- </xsl:if> -->
          <xsl:attribute name="MemberFirstName">
            <xsl:value-of select="MEMBER_FIRSTNAME/text()" />
          </xsl:attribute>
          <xsl:attribute name="MemberInamiNumber">
            <xsl:value-of select="MEMBER_INAMI_NUMBER/text()" />
          </xsl:attribute>
          <xsl:attribute name="MemberLastName">
            <xsl:value-of select="MEMBER_LASTNAME/text()" />
          </xsl:attribute>
          <xsl:attribute name="NisCode">
            <xsl:value-of select="NIS_CODE/text()" />
          </xsl:attribute>
          <xsl:attribute name="PeriodEndTime">
            <xsl:value-of select="PERIOD_END_TIME/text()" />
          </xsl:attribute>
          <xsl:attribute name="PeriodStartTime">
            <xsl:value-of select="PERIOD_START_TIME/text()" />
          </xsl:attribute>
          <xsl:variable name="var:v1" select="ScriptNS0:ImportStartedStringValue()" />
          <xsl:attribute name="Status">
            <xsl:value-of select="$var:v1" />
          </xsl:attribute>
          <xsl:attribute name="ZipCode">
            <xsl:value-of select="ZIP_CODE/text()" />
          </xsl:attribute>
		  <xsl:attribute name="NodeId">0</xsl:attribute>
		</ns0:sp_CreateMedegaXmlNode>
      </xsl:for-each>
    </ns0:CreateMedegaXmlNodeRequest>
  </xsl:template>
</xsl:stylesheet>