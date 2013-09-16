using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Data.Common;


using Riziv.BizTalk.Common;
using System.Data.SqlClient;
using System.Transactions;


namespace TestXmlDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start =  System.DateTime.Now;

            string path = @"D:\Riziv\Projects\Medega import\Code\MedegaImport\Dev\Src\";
            string filename = @"big1.xml";

            string strConn= "Persist Security Info=True;Data Source=SQLDEV1;Initial Catalog=DHODMedega;User ID=MedegaImport_user;Password=Mdgimus";
            string destTable = "MedegaXmlNode";

            Console.WriteLine("Creating conn...");

            TransactionOptions options = new TransactionOptions();
            options.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            options.Timeout = new TimeSpan(0,30,0);

            using(TransactionScope trans = new TransactionScope(TransactionScopeOption.RequiresNew, options));
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (XmlTextReader xmlTR = new XmlTextReader(path + filename))
                    {
                        using (MedegaDataReader medegaReader = new MedegaDataReader(xmlTR))
                        {
                            //while (medegaReader.Read())
                            //{
                            //    Console.WriteLine("Col0: " + medegaReader[0].ToString() + " Col1: " + medegaReader[1].ToString());

                            //}
                            Console.WriteLine("Opening conn...");
                            conn.Open();
                            Console.WriteLine("Connection open.");

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

                            Console.WriteLine("Copying...");
                            bulkcpy.DestinationTableName = destTable;
                            bulkcpy.WriteToServer(medegaReader);
                            Console.WriteLine("Copy done.");
                            conn.Close();
                        }
                    }
                    Console.WriteLine("Finished.");
                    DateTime end = DateTime.Now;
                    Console.WriteLine("Elapsed: " + (end - start).TotalSeconds);
                    Console.ReadLine();
                }
            }
        }
    }


    public class MedegaDataReader : XmlDataReader
    {
        //Containing element in the Xml file that contains the rows to bulkload
        private const string XmlTagRow = "ROW";

        private const int FieldCount = 14;
        private const int InvalidItemId = -1;

        public MedegaDataReader(XmlReader xmlReader)
            : base(xmlReader, FieldCount, XmlTagRow) { }

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
                    return 1; //return a fixed fileid
                case 15:
                    return 1; //return a fixed status
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
