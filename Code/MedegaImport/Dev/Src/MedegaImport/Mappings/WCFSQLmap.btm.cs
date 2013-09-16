namespace MedegaImport.Mappings {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImportSchema.Schemas.Medega_Guard", typeof(global::MedegaImportSchema.Schemas.Medega_Guard))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.WCFSQL_dbo+sp_CreateMedegaXmlNode", typeof(global::MedegaImport.WCFSQL_dbo.sp_CreateMedegaXmlNode))]
    public sealed class WCFSQLmap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ROWSET"" />
  </xsl:template>
  <xsl:template match=""/s0:ROWSET"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;999&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;2&quot;)"" />
    <ns0:sp_CreateMedegaXmlNode>
      <ns0:FileId>
        <xsl:value-of select=""$var:v1"" />
      </ns0:FileId>
      <ns0:Status>
        <xsl:value-of select=""$var:v2"" />
      </ns0:Status>
      <xsl:for-each select=""ROW"">
        <ns0:MemberInamiNumber>
          <xsl:value-of select=""MEMBER_INAMI_NUMBER/text()"" />
        </ns0:MemberInamiNumber>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:MemberLastName>
          <xsl:value-of select=""MEMBER_LASTNAME/text()"" />
        </ns0:MemberLastName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:MemberFirstName>
          <xsl:value-of select=""MEMBER_FIRSTNAME/text()"" />
        </ns0:MemberFirstName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:FeeDate>
          <xsl:value-of select=""FEE_DATE/text()"" />
        </ns0:FeeDate>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:AssociationId>
          <xsl:value-of select=""ASSOCIATION_ID/text()"" />
        </ns0:AssociationId>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:AssociationName>
          <xsl:value-of select=""ASSOCIATION_NAME/text()"" />
        </ns0:AssociationName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:GeographicEntityName>
          <xsl:value-of select=""GEOGRAPHIC_ENTITY_NAME/text()"" />
        </ns0:GeographicEntityName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:NisCode>
          <xsl:value-of select=""NIS_CODE/text()"" />
        </ns0:NisCode>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:ZipCode>
          <xsl:value-of select=""ZIP_CODE/text()"" />
        </ns0:ZipCode>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:ManagerLastName>
          <xsl:value-of select=""MANAGER_LASTNAME/text()"" />
        </ns0:ManagerLastName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:ManagerFirstName>
          <xsl:value-of select=""MANAGER_FIRSTNAME/text()"" />
        </ns0:ManagerFirstName>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:ManagerInamiNumber>
          <xsl:value-of select=""MANAGER_INAMI_NUMBER/text()"" />
        </ns0:ManagerInamiNumber>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:PeriodStartTime>
          <xsl:value-of select=""PERIOD_START_TIME/text()"" />
        </ns0:PeriodStartTime>
      </xsl:for-each>
      <xsl:for-each select=""ROW"">
        <ns0:PeriodEndTime>
          <xsl:value-of select=""PERIOD_END_TIME/text()"" />
        </ns0:PeriodEndTime>
      </xsl:for-each>
      <ns0:NodeId>
        <xsl:value-of select=""$var:v3"" />
      </ns0:NodeId>
    </ns0:sp_CreateMedegaXmlNode>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MedegaImportSchema.Schemas.Medega_Guard";
        
        private const global::MedegaImportSchema.Schemas.Medega_Guard _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MedegaImport.WCFSQL_dbo+sp_CreateMedegaXmlNode";
        
        private const global::MedegaImport.WCFSQL_dbo.sp_CreateMedegaXmlNode _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MedegaImportSchema.Schemas.Medega_Guard";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MedegaImport.WCFSQL_dbo+sp_CreateMedegaXmlNode";
                return _TrgSchemas;
            }
        }
    }
}
