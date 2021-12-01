using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Config
{
    class DatabaseCreater
    {
        private static readonly Logger _log = new Logger("DatabaseCreater");

        public static Connection Connection { get; set; }

        public static void CreateDatabase ()
        {
            try
            {
                string query = String.Format("CREATE DATABASE IF NOT EXISTS {0}", Connection.Database);
                string conString = String.Format("host = {0}; port = {1}; username = {2}; password = {3};", Connection.Host, Connection.Port,
                    Connection.Decrypt(Connection.Username), Connection.Decrypt(Connection.Password));
                using (var con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return;
            }

            CreateAdminTable();
            CreateOperatorTable();
            CreateWorkSectorTable();
            CreateWorkerTable();
            CreateCashierTable();
            CreateProductCompanyTable();
            CreateProductKindTable();
            CreateProductNumberTable();
            CreateProductWeightTable();
            CreateProductScalesTable();
            CreateBarcodeTable();
        }

        private static void CreateAdminTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `admin`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`surname` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`email` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`password` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`status` tinyint NOT NULL," +
                "PRIMARY KEY(`id`) USING BTREE" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateOperatorTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `operator`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`surname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "PRIMARY KEY(`id`) USING BTREE" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateWorkSectorTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `work_sector`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "PRIMARY KEY(`id`) USING BTREE" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private static void CreateWorkerTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `worker`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`surname` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`father_name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`gender` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`birthday` date NULL DEFAULT NULL," +
                "`address` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`phone` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`email` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`image_path` varchar(1000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`sector` int NULL DEFAULT NULL," +
                "`wage` int NULL DEFAULT NULL," +
                "`start_time` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                "`end_time` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL," +
                " PRIMARY KEY(`id`) USING BTREE," +
                " INDEX `sector`(`sector`) USING BTREE," +
                "CONSTRAINT `worker_ibfk_1` FOREIGN KEY (`sector`) REFERENCES `work_sector` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateCashierTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `cashier`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`sales` double NULL DEFAULT NULL," +
                "`last_reset_time` datetime NULL DEFAULT NULL," +
                "`worker` int NULL DEFAULT NULL," +
                "PRIMARY KEY(`id`) USING BTREE," +
                " INDEX `worker`(`worker`) USING BTREE," +
                " CONSTRAINT `cashier_ibfk_1` FOREIGN KEY (`worker`) REFERENCES `worker` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateProductCompanyTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `product_company`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`begin_date` date NOT NULL," +
                "`end_date` date NOT NULL," +
                "`last_come_date` date NOT NULL," +
                " PRIMARY KEY (`id`) USING BTREE" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateProductKindTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `product_kind`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                " PRIMARY KEY (`id`) USING BTREE" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateProductNumberTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `product_number`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`arrival_price` double NOT NULL," +
                "`sale_price` double NOT NULL," +
                "`number` int NOT NULL," +
                "`last_come_date` date NOT NULL," +
                "`company` int NOT NULL," +
                "`kind` int NOT NULL," +
                " PRIMARY KEY (`id`) USING BTREE," +
                " INDEX `company`(`company`) USING BTREE," +
                " INDEX `kind`(`kind`) USING BTREE," +
                " CONSTRAINT `product_number_ibfk_1` FOREIGN KEY (`company`) REFERENCES `product_company` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT," +
                " CONSTRAINT `product_number_ibfk_2` FOREIGN KEY (`kind`) REFERENCES `product_kind` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateProductWeightTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `product_weight`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`name` varchar(225) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                "`arrival_price` double NOT NULL," +
                "`sale_price` double NOT NULL," +
                "`weight` double NOT NULL," +
                "`last_come_date` date NOT NULL," +
                "`company` int NOT NULL," +
                "`kind` int NOT NULL," +
                " PRIMARY KEY (`id`) USING BTREE," +
                " INDEX `company`(`company`) USING BTREE," +
                " INDEX `kind`(`kind`) USING BTREE," +
                " CONSTRAINT `product_weight_ibfk_1` FOREIGN KEY (`company`) REFERENCES `product_company` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT," +
                " CONSTRAINT `product_weight_ibfk_2` FOREIGN KEY (`kind`) REFERENCES `product_kind` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1000 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateProductScalesTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `product_scales`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`weight` double NOT NULL," +
                "`measure_date` date NOT NULL," +
                "`product_weight` int NOT NULL," +
                " PRIMARY KEY (`id`) USING BTREE," +
                " INDEX `product_weight`(`product_weight`) USING BTREE," +
                " CONSTRAINT `product_scales_ibfk_1` FOREIGN KEY (`product_weight`) REFERENCES `product_weight` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private static void CreateBarcodeTable ()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS `barcode`  (" +
                "`id` int NOT NULL AUTO_INCREMENT," +
                "`product_number` int NULL DEFAULT NULL," +
                "`product_scales` int NULL DEFAULT NULL," +
                " PRIMARY KEY(`id`) USING BTREE," +
                " INDEX `product_number`(`product_number`) USING BTREE," +
                " INDEX `product_scales`(`product_scales`) USING BTREE," +
                " CONSTRAINT `barcode_ibfk_1` FOREIGN KEY (`product_number`) REFERENCES `product_number` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT," +
                " CONSTRAINT `barcode_ibfk_2` FOREIGN KEY (`product_scales`) REFERENCES `product_scales` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT" +
                ") ENGINE = InnoDB AUTO_INCREMENT = 1000000000 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;" +
                "SET FOREIGN_KEY_CHECKS = 1; ";

                using (var con = new MySqlConnection(Connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
    }
}
