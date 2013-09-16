using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.XLANGs.BaseTypes;
using System.Xml;
using System.IO;
using System.Transactions;
using System.Data.SqlClient;
using Riziv.BizTalk.Common;

namespace Riziv.MedegaImport.Bulkloader
{
    [Serializable]
    public class MedegaBulkloader
    {
        /// <summary>
        /// Nessary Fields in the ConfigDB:
        /// </summary>
        /// <configvalue name="Medega.StrConn.Validator">connstring</configvalue>
        /// <configvalue name="Medega.BulkCopyDestinationTable">MedegaXmlNode</configvalue>
        /// <configvalue name="Medega.BulkloadTimeout">30</configvalue>
        /// <configvalue name="Medega.ElementToBulkload">ROW</configvalue>
        /// <configvalue name="msg"></configvalue>
        /// <configvalue name="msg"></configvalue>
        /// <configvalue name="msg"></configvalue>
        /// <returns></returns>

        public bool LoadGuardNodes(XLANGMessage msg, int MedegaFileId, int Status)
        {
            string strConn, destTable;
            int bulkLoadTimeout;
            string XmlTagRow;
            int FieldCount;
            
            try
            {
                strConn = RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.StrConn.Validator");
                destTable = RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.BulkCopyDestinationTable");
                bulkLoadTimeout = Convert.ToInt32(RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.BulkloadTimeout"));
                XmlTagRow = RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.ElementToBulkload");
                FieldCount = Convert.ToInt32(RIZIV.BizTalk.Common.BTSConfigReader.Instance.ReadConfigValueAsString("MedegaImport", "Medega.BulkloadFieldCount")); 
            }
            catch(Exception ex)
            {
                throw new Exception("Error while loading the MedegaImport config values from the BTS config DB!", ex);
            }

            try
            {

                Stream stream = (Stream)msg[0].RetrieveAs(typeof(Stream));
                XmlReader xmlReader = new XmlTextReader(stream);

                TransactionOptions options = new TransactionOptions();
                options.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                options.Timeout = new TimeSpan(0, bulkLoadTimeout, 0);

                using (TransactionScope trans = new TransactionScope(TransactionScopeOption.RequiresNew, options))
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        using (MedegaDataReader medegaReader = new MedegaDataReader(xmlReader, MedegaFileId, Status, FieldCount, XmlTagRow))
                        {
                            conn.Open();

                            #region Mapping Xml to Table
                            SqlBulkCopy bulkcpy = new SqlBulkCopy(conn);
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(0, "MEMBER_INAMI_NUMBER"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(1, "MEMBER_LASTNAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(2, "MEMBER_FIRSTNAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(3, "FEE_DATE"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(4, "ASSOCIATION_ID"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(5, "ASSOCIATION_NAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(6, "GEOGRAPHIC_ENTITY_NAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(7, "NIS_CODE"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(8, "ZIP_CODE"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(9, "MANAGER_LASTNAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(10, "MANAGER_FIRSTNAME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(11, "MANAGER_INAMI_NUMBER"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(12, "PERIOD_START_TIME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(13, "PERIOD_END_TIME"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(14, "MedegaFileId"));
                            bulkcpy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(15, "Status"));
                            #endregion
                            
                            bulkcpy.BulkCopyTimeout = bulkLoadTimeout*60;
                            bulkcpy.DestinationTableName = destTable;
                            bulkcpy.WriteToServer(medegaReader);
                            conn.Close();
                        }
                    }
                    trans.Complete();
                    return true;
                }
            }
            catch (Exception exc)
            {
                throw new Exception("Error while executing the bulkload for Medega", exc);
                return false;
            }
        }
    }

    public class MedegaDataReader : XmlDataReader
    {
        private const int InvalidItemId = -1;
        private int medegaFileId;
        private int status;

        public MedegaDataReader(XmlReader xmlReader, int MedegaFileId, int Status, int FieldCount, string XmlTagRow)
            : base(xmlReader, FieldCount, XmlTagRow) 
        {
            medegaFileId = MedegaFileId;
            status = Status;
        }

        /// <summary>
        /// Flatten the Xml row in this method
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public override object GetValue(int i)
        {
            switch (i)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    {
                        int j = 0;
                        int k = 0;
                        while (j <= CurrentElement.FirstChild.ChildNodes.Count)
                        {
                            if (CurrentElement.FirstChild.ChildNodes[j].NodeType == XmlNodeType.Element)
                            {
                                if (k == i)
                                    return CurrentElement.FirstChild.ChildNodes[j].FirstChild.Value;
                                k++;
                            }
                            j++;
                        }
                        throw new Exception("Element not found in the MedegaDataReader");
                    }
                case 14:
                    return medegaFileId; //return a fixed fileid
                case 15:
                    return status; //return a fixed status
                default:
                    return -9999;

            }

            #region Examples
            //switch (i)
            //{
            //    case 0:
            //        return CurrentElement.Attribute("type").EnumFromValue<ResultType>();
            //    case 1:
            //        return CurrentElement.Attribute("origin").EnumFromValue<Origin>();
            //    case 2:
            //        return CurrentElement.Element("name").value;
            //    case 3:
            //        return CurrentElement.Element("description").value;
            //    default:
            //        throw new InvalidOperationException("Column count mismatch.");
            //}
            #endregion
        }
    }
}
