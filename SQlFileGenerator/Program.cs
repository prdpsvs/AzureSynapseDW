using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SQlFileGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            string schemaName;
            string tableName;
            string sourcePath = "C:\\Users\\pvenkat\\source\\repos\\AzureSynapseDW\\DWSSDT\\";
            string schemaPath = "C:\\Users\\pvenkat\\source\\repos\\AzureSynapseDW\\DWSSDT\\Security\\Schemas\\";

            int noOfSchemas = 200;
            int noOfTables = 3000;
            DirectoryInfo folder;

            for (int i = 0; i < noOfSchemas; i++)
            {
                    Console.WriteLine($"<Build Include=\"{"sch_" + i.ToString()}\\Views\\*.sql\" />");
             
            }

                for (int i=0; i< noOfSchemas; i++ )
            {
                schemaName = "sch_" + i.ToString();

                if (!File.Exists(schemaPath + schemaName + ".sql"))
                {
                    Console.WriteLine("Created a schema file " + schemaPath + schemaName);
                    File.WriteAllText(schemaPath + schemaName + ".sql", "CREATE SCHEMA " + schemaName);
                }

                if (!Directory.Exists(sourcePath + schemaName))
                {
                    folder = Directory.CreateDirectory(sourcePath + schemaName);
                    folder = Directory.CreateDirectory(sourcePath + schemaName + "\\Tables");
                }

                if (!Directory.Exists(sourcePath + schemaName + "\\Views"))
                    folder = Directory.CreateDirectory(sourcePath + schemaName + "\\Views");
            }

            for (int i = 0; i < noOfSchemas; i++)
            {
                schemaName = "sch_" + i.ToString();
                for (int j = 0; j < noOfTables; j++)
                {
                    tableName = "tbl_" + j.ToString();                    
                    string tableContent = getTableContent(schemaName, tableName);
                    File.WriteAllText(sourcePath + schemaName + "\\Tables\\" + tableName + ".sql", tableContent);
                }
            }

            for (int i = 0; i < noOfSchemas; i++)
            {
                schemaName = "sch_" + i.ToString();
                for (int j = 0; j < noOfTables; j++)
                {
                    tableName = "vw_" + j.ToString();
                    string tableContent = getViewContent(schemaName, tableName, "tbl_" + j.ToString());
                    File.WriteAllText(sourcePath + schemaName + "\\Views\\" + tableName + ".sql", tableContent);
                }
            }

        }

        private static string getTableContent(string schemaName, string tableName)
        {
            return "CREATE TABLE [" + schemaName + "].[" + tableName + "]\r\n(\r\n\t[STRS_IN_CENSUS_DIVISIONS] [varchar](56) NULL,\r\n\t[PG_MILITARY_4GLOBAL] [varchar](250) NULL,\r\n\t[SUPUP] [varchar](17) NULL,\r\n\t[PG_GLOBAL_4MARKET] [varchar](250) NULL,\r\n\t[ODMP_DISP_NAME] [varchar](69) NULL,\r\n\t[CS_CHANNEL] [varchar](250) NULL,\r\n\t[PG_INTERNAL_MARKET_2CHANNEL] [varchar](250) NULL,\r\n\t[STRS_IN_CENSUS_REGIONS] [varchar](23) NULL,\r\n\t[CSL_BLK_DT] [date] NULL,\r\n\t[MRKT_TT_DMG_CD] [numeric](38, 0) NULL,\r\n\t[PG_ARCHIVE_MKT_OPS_1CHANNEL] [varchar](250) NULL,\r\n\t[MADRAS_ID] [varchar](250) NULL,\r\n\t[CS_MARKET_TYPE] [varchar](250) NULL,\r\n\t[WGHT_RULE_NUM] [numeric](38, 0) NULL,\r\n\t[PG_ARCHIVE_MKT_OPS_4BANNER] [varchar](250) NULL,\r\n\t[WALMART_CMA_REM] [varchar](250) NULL,\r\n\t[MRKT_STS_ID] [varchar](14) NULL,\r\n\t[NOTES] [varchar](250) NULL,\r\n\t[TAGRS] [varchar](14) NULL,\r\n\t[PG_MKT_OPS_1CHANNEL] [varchar](250) NULL,\r\n\t[PG_GLOBAL_3SUBCHANNEL] [varchar](250) NULL,\r\n\t[TOP_CITIES] [varchar](250) NULL,\r\n\t[CS_TA_CHANNEL] [varchar](250) NULL,\r\n\t[WALMART_CMA] [varchar](250) NULL,\r\n\t[XAOC_COMP_MKT_KEY] [numeric](38, 0) NULL,\r\n\t[DOMINATE_DMA_NAME] [varchar](14) NULL,\r\n\t[PG_CCA_CBA_FORMAT_AGGS] [varchar](250) NULL,\r\n\t[PG_AGGREGATE_2TA] [varchar](250) NULL,\r\n\t[MRKT_TYP_DTL] [varchar](14) NULL,\r\n\t[PG_MKT_OPS_3ACCOUNT] [varchar](250) NULL,\r\n\t[TA_REM] [varchar](250) NULL,\r\n\t[GEOGRAPHY] [varchar](250) NULL,\r\n\t[COMP_KEY] [varchar](14) NULL,\r\n\t[CLIENT_ID] [varchar](14) NULL,\r\n\t[XAOC_TA_REM] [varchar](250) NULL,\r\n\t[MRKT_TYP] [varchar](17) NULL,\r\n\t[DMG_CD] [varchar](250) NULL,\r\n\t[PRIMARY_MARKET] [varchar](250) NULL,\r\n\t[POD_RLS_IND] [varchar](14) NULL,\r\n\t[PG_GLOBAL_2CHANNEL] [varchar](250) NULL,\r\n\t[CS_MARKET_SET] [varchar](250) NULL,\r\n\t[PG_AGG4_3TA] [varchar](250) NULL,\r\n\t[PG_ARCHIVE_MKT_OPS_2CST_TEAM] [varchar](250) NULL,\r\n\t[TOP_CUSTOMERS] [varchar](250) NULL,\r\n\t[COUNTRY] [varchar](14) NULL,\r\n\t[WALMART_NON_CMA] [varchar](250) NULL,\r\n\t[MRKT_RPTBL_STRT_DT] [varchar](14) NULL,\r\n\t[MRKT_HRCH_LVL] [varchar](14) NULL,\r\n\t[PG_MILITARY_1WW] [varchar](250) NULL,\r\n\t[STRS_IN_STATES] [varchar](38) NULL,\r\n\t[SAMS_RSTR_IND] [varchar](14) NULL,\r\n\t[PG_AGG4_1MARKETS] [varchar](250) NULL,\r\n\t[MARKET_FULFILLMENT_TYPE] [varchar](250) NULL,\r\n\t[PG_MILITARY_6MARKET] [varchar](250) NULL,\r\n\t[COMP_MRKT_NM] [varchar](65) NULL,\r\n\t[MRKT_KEY] [numeric](38, 0) NULL,\r\n\t[WALMART_NON_CMA_REM] [varchar](250) NULL,\r\n\t[MRKT_DSC_LNG] [varchar](71) NULL,\r\n\t[MARRKET_DATA_SOURCE] [varchar](250) NULL,\r\n\t[PG_MILITARY_3CUSTOMER] [varchar](250) NULL,\r\n\t[LTA_TYPE] [varchar](14) NULL,\r\n\t[PG_MKT_OPS_2CUSTOMER_TEAM] [varchar](250) NULL,\r\n\t[AOD_MKT_CODE] [varchar](250) NULL,\r\n\t[ZGMI_MARKET_TYPE] [varchar](250) NULL,\r\n\t[COMP_MRKT_ALL_SINGLE_CHANNEL] [varchar](250) NULL,\r\n\t[CHANNEL] [varchar](50) NULL,\r\n\t[CS_MARKET_TYPE_SET] [varchar](250) NULL,\r\n\t[PG_MKT_OPS_4BANNER] [varchar](250) NULL,\r\n\t[ZGMI_HIGHEST_ACCOUNT] [varchar](250) NULL,\r\n\t[PG_MILITARY_5MARKET_TTL] [varchar](250) NULL,\r\n\t[REPORTABLEYONLY] [varchar](250) NULL,\r\n\t[PG_EXTERNALLY_SHAREABLE_AGGS_2] [varchar](250) NULL,\r\n\t[ZGMI_LOWEST_ACCOUNT] [varchar](250) NULL,\r\n\t[TRADING_AREA_ALL_RETAILERS] [varchar](250) NULL,\r\n\t[SHR_MRKT_KEY] [numeric](38, 0) NULL,\r\n\t[MRKT_DRILL_IND] [varchar](50) NULL,\r\n\t[COMPARATIVE_MARKET_ALL_XAOC] [varchar](250) NULL,\r\n\t[SAMPL] [varchar](250) NULL,\r\n\t[CS_MARKET_SET_DETAIL] [varchar](250) NULL,\r\n\t[MRKT_RSTR_POS] [numeric](38, 0) NULL,\r\n\t[ZGMI_SALES_ZONE] [varchar](250) NULL,\r\n\t[XAOC_CM_TA_RM_ALL] [varchar](250) NULL,\r\n\t[PG_AGGREGATE_1MARKETS] [varchar](250) NULL,\r\n\t[MKT_DISP_NAME] [varchar](250) NULL,\r\n\t[STR_PL_RSTR] [varchar](50) NULL,\r\n\t[MRKT_TYPE_HS] [varchar](50) NULL,\r\n\t[COMP_CHNL] [varchar](14) NULL,\r\n\t[MRKT_IND] [varchar](50) NULL,\r\n\t[XDIM_MRKT2STR] [varchar](250) NULL,\r\n\t[MRKT_RPTBL_STOP_DT] [varchar](14) NULL,\r\n\t[MRKT_CD] [varchar](14) NULL,\r\n\t[MRKT_RSTR_ID] [numeric](38, 0) NULL,\r\n\t[PG_INTERNAL_MARKET_1TTL] [varchar](250) NULL,\r\n\t[DOMINATE_SMM] [varchar](31) NULL,\r\n\t[PRJCTD_IND] [varchar](14) NULL,\r\n\t[MRKT_DISP_NAME_FRNT_END] [varchar](250) NULL,\r\n\t[STATELINE] [varchar](250) NULL,\r\n\t[ZGMI_REGION_GROUPS] [varchar](250) NULL,\r\n\t[MARKET_DEFINITION] [varchar](250) NULL,\r\n\t[E122] [varchar](250) NULL,\r\n\t[PG_INTERNAL_MARKET_3TA] [varchar](250) NULL,\r\n\t[ZGMI_CORP_PARENT] [varchar](250) NULL,\r\n\t[E321] [varchar](250) NULL,\r\n\t[DT_SRC_DTL_NM] [varchar](18) NULL,\r\n\t[GO_LIVE_IND] [varchar](250) NULL,\r\n\t[PG_EXTERNALLY_SHAREABLE_AGGS] [varchar](250) NULL,\r\n\t[CM_TA_RM_ALL] [varchar](250) NULL,\r\n\t[LTA_NAME] [varchar](69) NULL,\r\n\t[REPORTABLE] [varchar](250) NULL,\r\n\t[COMP_MKT] [varchar](250) NULL,\r\n\t[CLIENT_SALES_AREAS] [varchar](250) NULL,\r\n\t[ACV_ADJ_IND] [numeric](38, 0) NULL,\r\n\t[COMP_MKT_KEY] [numeric](38, 0) NULL,\r\n\t[PG_MILITARY_2CUSTOMER_TTL] [varchar](250) NULL,\r\n\t[MRKT_DSC_SHRT] [varchar](71) NULL,\r\n\t[SUPPRESSION] [varchar](15) NULL,\r\n\t[DYN_MRKT_FLG] [varchar](250) NULL,\r\n\t[PG_AGG4_2TEAMS] [varchar](250) NULL,\r\n\t[ZGMI_CHANNEL] [varchar](250) NULL,\r\n\t[ETH_MRKT_TYP] [varchar](250) NULL,\r\n\t[MARKET_TYPE] [varchar](160) NULL,\r\n\t[PG_ARCHIVE_MKT_OPS_3ACCOUNT] [varchar](250) NULL,\r\n\t[MRKT_AGG_FLG] [numeric](38, 0) NULL,\r\n\t[XAOC_COMP_MKT] [varchar](250) NULL,\r\n\t[PG_GLOBAL_1TOTAL] [varchar](250) NULL,\r\n\t[DEF_MRKT_FLG] [varchar](250) NULL,\r\n\t[OWNER] [varchar](250) NULL\r\n)\r\nWITH\r\n(\r\n\tDISTRIBUTION = REPLICATE,\r\n\tCLUSTERED INDEX\r\n\t(\r\n\t\t[MRKT_KEY] ASC\r\n\t)\r\n)";
        }

        private static string getViewContent(string schemaName, string viewName, string tableName)
        {
            return "CREATE VIEW [" + schemaName + "].[" + viewName + "]\r\nAS select * from [" + schemaName + "].[" + tableName + "];";
        }
    }
}
