namespace MedegaImport.Mappings {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImportSchema.Schemas.Medega_Guard", typeof(global::MedegaImportSchema.Schemas.Medega_Guard))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse", typeof(global::MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.SQLCreateMedegaXmlNode+CreateMedegaXmlNodeRequest", typeof(global::MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest))]
    public sealed class SQLCreateMedegaXmlNode : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 ScriptNS0"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://inami-riziv.fgov.be.medega"" xmlns:s0=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:CreateMedegaXmlNodeRequest>
      <xsl:for-each select=""InputMessagePart_0/s0:ROWSET/ROW"">
        <ns0:sp_CreateMedegaXmlNode>
          <xsl:attribute name=""AssociationId"">
            <xsl:value-of select=""ASSOCIATION_ID/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""AssociationName"">
            <xsl:value-of select=""ASSOCIATION_NAME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""FeeDate"">
            <xsl:value-of select=""FEE_DATE/text()"" />
          </xsl:attribute>
	  	  <xsl:attribute name=""FileId"">
		 	<xsl:value-of select=""/s1:Root/InputMessagePart_1/*[local-name()='CreateMedegaFileResponse']/*[local-name()='FileId']/text()"" />
		  </xsl:attribute>
          <xsl:attribute name=""GeographicEntityName"">
            <xsl:value-of select=""GEOGRAPHIC_ENTITY_NAME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""ManagerFirstName"">
            <xsl:value-of select=""MANAGER_FIRSTNAME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""ManagerInamiNumber"">
            <xsl:value-of select=""MANAGER_INAMI_NUMBER/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""ManagerLastName"">
            <xsl:value-of select=""MANAGER_LASTNAME/text()"" />
          </xsl:attribute>
          <!--<xsl:attribute name=""MemberBankAccount"">
            <xsl:value-of select=""MEMBER_BANK_ACCOUNT/text()"" />
          </xsl:attribute>-->
          <!-- <xsl:if test=""MEMBER_BANK_ACCOUNT_OWNER""> -->
            <!--<xsl:attribute name=""MemberBankAccountOwner"">
              <xsl:value-of select=""MEMBER_BANK_ACCOUNT_OWNER/text()"" />
            </xsl:attribute>-->
          <!-- </xsl:if> -->
          <xsl:attribute name=""MemberFirstName"">
            <xsl:value-of select=""MEMBER_FIRSTNAME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""MemberInamiNumber"">
            <xsl:value-of select=""MEMBER_INAMI_NUMBER/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""MemberLastName"">
            <xsl:value-of select=""MEMBER_LASTNAME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""NisCode"">
            <xsl:value-of select=""NIS_CODE/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""PeriodEndTime"">
            <xsl:value-of select=""PERIOD_END_TIME/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""PeriodStartTime"">
            <xsl:value-of select=""PERIOD_START_TIME/text()"" />
          </xsl:attribute>
          <xsl:variable name=""var:v1"" select=""ScriptNS0:ImportStartedStringValue()"" />
          <xsl:attribute name=""Status"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <xsl:attribute name=""ZipCode"">
            <xsl:value-of select=""ZIP_CODE/text()"" />
          </xsl:attribute>
		  <xsl:attribute name=""NodeId"">0</xsl:attribute>
		</ns0:sp_CreateMedegaXmlNode>
      </xsl:for-each>
    </ns0:CreateMedegaXmlNodeRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
   <ExtensionObject
      Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0""
      AssemblyName=""RIZIV.MedegaImportTypes, Version=2.0.0.0, Culture=neutral, PublicKeyToken=7d624d93bf081b87""
      ClassName=""MedegaImport.MedegaImportTypes.NodeStatus"" />
</ExtensionObjects>
";
        
        private const string _strSrcSchemasList0 = @"MedegaImportSchema.Schemas.Medega_Guard";
        
        private const global::MedegaImportSchema.Schemas.Medega_Guard _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse";
        
        private const global::MedegaImport.SQLCreateMedegaFile.CreateMedegaFileResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MedegaImport.SQLCreateMedegaXmlNode+CreateMedegaXmlNodeRequest";
        
        private const global::MedegaImport.SQLCreateMedegaXmlNode.CreateMedegaXmlNodeRequest _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
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
                _SrcSchemas[0] = @"MedegaImportSchema.Schemas.Medega_Guard";
                _SrcSchemas[1] = @"MedegaImport.SQLCreateMedegaFile+CreateMedegaFileResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MedegaImport.SQLCreateMedegaXmlNode+CreateMedegaXmlNodeRequest";
                return _TrgSchemas;
            }
        }
    }
}
