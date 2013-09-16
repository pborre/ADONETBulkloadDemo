namespace MedegaImport.Mappings {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImportSchema.Schemas.Medega_Guard", typeof(global::MedegaImportSchema.Schemas.Medega_Guard))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.WCFSQL_SP+InsertGuard", typeof(global::MedegaImport.WCFSQL_SP.InsertGuard))]
    public sealed class WCFSQLSP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns2=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:ns1=""http://sp"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ROWSET"" />
  </xsl:template>
  <xsl:template match=""/s0:ROWSET"">
    <ns1:InsertGuard>
      <xsl:for-each select=""ROW"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;777&quot;)"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
        <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;3&quot;)"" />
        <ns0:sp_CreateMedegaXmlNode>
          <ns0:FileId>
            <xsl:value-of select=""$var:v1"" />
          </ns0:FileId>
          <ns0:Status>
            <xsl:value-of select=""$var:v2"" />
          </ns0:Status>
          <ns0:MemberInamiNumber>
            <xsl:value-of select=""MEMBER_INAMI_NUMBER/text()"" />
          </ns0:MemberInamiNumber>
          <ns0:MemberLastName>
            <xsl:value-of select=""MEMBER_LASTNAME/text()"" />
          </ns0:MemberLastName>
          <ns0:MemberFirstName>
            <xsl:value-of select=""MEMBER_FIRSTNAME/text()"" />
          </ns0:MemberFirstName>
          <ns0:FeeDate>
            <xsl:value-of select=""FEE_DATE/text()"" />
          </ns0:FeeDate>
          <ns0:AssociationId>
            <xsl:value-of select=""ASSOCIATION_ID/text()"" />
          </ns0:AssociationId>
          <ns0:AssociationName>
            <xsl:value-of select=""ASSOCIATION_NAME/text()"" />
          </ns0:AssociationName>
          <ns0:GeographicEntityName>
            <xsl:value-of select=""GEOGRAPHIC_ENTITY_NAME/text()"" />
          </ns0:GeographicEntityName>
          <ns0:NisCode>
            <xsl:value-of select=""NIS_CODE/text()"" />
          </ns0:NisCode>
          <ns0:ZipCode>
            <xsl:value-of select=""ZIP_CODE/text()"" />
          </ns0:ZipCode>
          <ns0:ManagerLastName>
            <xsl:value-of select=""MANAGER_LASTNAME/text()"" />
          </ns0:ManagerLastName>
          <ns0:ManagerFirstName>
            <xsl:value-of select=""MANAGER_FIRSTNAME/text()"" />
          </ns0:ManagerFirstName>
          <ns0:ManagerInamiNumber>
            <xsl:value-of select=""MANAGER_INAMI_NUMBER/text()"" />
          </ns0:ManagerInamiNumber>
          <ns0:PeriodStartTime>
            <xsl:value-of select=""PERIOD_START_TIME/text()"" />
          </ns0:PeriodStartTime>
          <ns0:PeriodEndTime>
            <xsl:value-of select=""PERIOD_END_TIME/text()"" />
          </ns0:PeriodEndTime>
          <ns0:NodeId>
            <xsl:value-of select=""$var:v3"" />
          </ns0:NodeId>
        </ns0:sp_CreateMedegaXmlNode>
      </xsl:for-each>
    </ns1:InsertGuard>
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
        
        private const string _strTrgSchemasList0 = @"MedegaImport.WCFSQL_SP+InsertGuard";
        
        private const global::MedegaImport.WCFSQL_SP.InsertGuard _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MedegaImport.WCFSQL_SP+InsertGuard";
                return _TrgSchemas;
            }
        }
    }
}
