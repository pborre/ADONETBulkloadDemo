namespace MedegaImport {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.Schemas.CreateGuardNode", typeof(global::MedegaImport.Schemas.CreateGuardNode))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MedegaImport.GuardService_tempuri_org+CreateGuard", typeof(global::MedegaImport.GuardService_tempuri_org.CreateGuard))]
    public sealed class MapCreateGuardRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns1=""http://riziv.fgov.be/hodmedega/importmedegaguardresult"" xmlns:s0=""http://inami-riziv.fgov.be.medega"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns2=""http://riziv.fgov.be/hodmedega/importmedegaguardrequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Node"" />
  </xsl:template>
  <xsl:template match=""/s0:Node"">
    <ns0:CreateGuard>
      <ns0:medegaGuardRequest>
        <xsl:if test=""@FileID"">
          <ns2:FileId>
            <xsl:value-of select=""@FileID"" />
          </ns2:FileId>
        </xsl:if>
        <xsl:if test=""@NodeId"">
          <ns2:XmlNodeId>
            <xsl:value-of select=""@NodeId"" />
          </ns2:XmlNodeId>
        </xsl:if>
      </ns0:medegaGuardRequest>
    </ns0:CreateGuard>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MedegaImport.Schemas.CreateGuardNode";
        
        private const string _strTrgSchemasList0 = @"MedegaImport.GuardService_tempuri_org+CreateGuard";
        
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
                _SrcSchemas[0] = @"MedegaImport.Schemas.CreateGuardNode";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MedegaImport.GuardService_tempuri_org+CreateGuard";
                return _TrgSchemas;
            }
        }
    }
}
