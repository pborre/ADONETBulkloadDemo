namespace MedegaImport.Mappings {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImportSchema.Schemas.Medega_Guard", typeof(global::MedegaImportSchema.Schemas.Medega_Guard))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.sqlBinding_MedegaXmlNode+Insert", typeof(global::MedegaImport.sqlBinding_MedegaXmlNode.Insert))]
    public sealed class WCFSQLInsert : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.riziv.fgov.be/medega/v2.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/MedegaXmlNode"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ROWSET"" />
  </xsl:template>
  <xsl:template match=""/s0:ROWSET"">
    <ns0:Insert>
      <ns0:Rows>
        <xsl:for-each select=""ROW"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;555&quot;)"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
          <ns3:MedegaXmlNode>
            <ns3:MedegaFileId>
              <xsl:value-of select=""$var:v1"" />
            </ns3:MedegaFileId>
            <ns3:Status>
              <xsl:value-of select=""$var:v2"" />
            </ns3:Status>
            <ns3:MEMBER_INAMI_NUMBER>
              <xsl:value-of select=""MEMBER_INAMI_NUMBER/text()"" />
            </ns3:MEMBER_INAMI_NUMBER>
            <ns3:MEMBER_LASTNAME>
              <xsl:value-of select=""MEMBER_LASTNAME/text()"" />
            </ns3:MEMBER_LASTNAME>
            <ns3:MEMBER_FIRSTNAME>
              <xsl:value-of select=""MEMBER_FIRSTNAME/text()"" />
            </ns3:MEMBER_FIRSTNAME>
            <ns3:FEE_DATE>
              <xsl:value-of select=""FEE_DATE/text()"" />
            </ns3:FEE_DATE>
            <ns3:ASSOCIATION_ID>
              <xsl:value-of select=""ASSOCIATION_ID/text()"" />
            </ns3:ASSOCIATION_ID>
            <ns3:ASSOCIATION_NAME>
              <xsl:value-of select=""ASSOCIATION_NAME/text()"" />
            </ns3:ASSOCIATION_NAME>
            <ns3:GEOGRAPHIC_ENTITY_NAME>
              <xsl:value-of select=""GEOGRAPHIC_ENTITY_NAME/text()"" />
            </ns3:GEOGRAPHIC_ENTITY_NAME>
            <ns3:NIS_CODE>
              <xsl:value-of select=""NIS_CODE/text()"" />
            </ns3:NIS_CODE>
            <ns3:ZIP_CODE>
              <xsl:value-of select=""ZIP_CODE/text()"" />
            </ns3:ZIP_CODE>
            <ns3:MANAGER_LASTNAME>
              <xsl:value-of select=""MANAGER_LASTNAME/text()"" />
            </ns3:MANAGER_LASTNAME>
            <ns3:MANAGER_FIRSTNAME>
              <xsl:value-of select=""MANAGER_FIRSTNAME/text()"" />
            </ns3:MANAGER_FIRSTNAME>
            <ns3:MANAGER_INAMI_NUMBER>
              <xsl:value-of select=""MANAGER_INAMI_NUMBER/text()"" />
            </ns3:MANAGER_INAMI_NUMBER>
            <ns3:PERIOD_START_TIME>
              <xsl:value-of select=""PERIOD_START_TIME/text()"" />
            </ns3:PERIOD_START_TIME>
            <ns3:PERIOD_END_TIME>
              <xsl:value-of select=""PERIOD_END_TIME/text()"" />
            </ns3:PERIOD_END_TIME>
          </ns3:MedegaXmlNode>
        </xsl:for-each>
      </ns0:Rows>
    </ns0:Insert>
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
        
        private const string _strTrgSchemasList0 = @"MedegaImport.sqlBinding_MedegaXmlNode+Insert";
        
        private const global::MedegaImport.sqlBinding_MedegaXmlNode.Insert _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MedegaImport.sqlBinding_MedegaXmlNode+Insert";
                return _TrgSchemas;
            }
        }
    }
}
