using SuperShopDatabase.Dao.Impl;
using SuperShopDatabase.Dao.Inter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Config
{
    public class Context
    {
        private static IAdminDAO adminDAO = null;
        private static IBarcodeDAO barcodeDAO = null;
        private static IOperatorDAO operatorDAO = null;
        private static IProductCompanyDAO productCompanyDAO = null;
        private static IProductKindDAO productKindDAO = null;
        private static IProductNumberDAO productNumberDAO = null;
        private static IProductScalesDAO productScalesDAO = null;
        private static IProductWeightDAO productWeightDAO = null;
        private static IWorkSectorDAO sectorDAO = null;
        private static IWorkerDAO workerDAO = null;
        private static ICashierDAO cashierDAO = null;

        public static IAdminDAO GetAdminDAO ()
        {
            if (adminDAO == null)
                adminDAO = new AdminDAO();

            return adminDAO;
        }

        public static IBarcodeDAO GetBarcodeDAO ()
        {
            if (barcodeDAO == null)
                barcodeDAO = new BarcodeDAO();

            return barcodeDAO;
        }

        public static IOperatorDAO GetOperatorDAO ()
        {
            if (operatorDAO == null)
                operatorDAO = new OperatorDAO();

            return operatorDAO;
        }

        public static IProductCompanyDAO GetProductCompanyDAO ()
        {
            if (productCompanyDAO == null)
                productCompanyDAO = new ProductCompanyDAO();

            return productCompanyDAO;
        }

        public static IProductKindDAO GetProductKindDAO ()
        {
            if (productKindDAO == null)
                productKindDAO = new ProductKindDAO();

            return productKindDAO;
        }

        public static IProductNumberDAO GetProductNumberDAO ()
        {
            if (productNumberDAO == null)
                productNumberDAO = new ProductNumberDAO();

            return productNumberDAO;
        }

        public static IProductScalesDAO GetProductScalesDAO ()
        {
            if (productScalesDAO == null)
                productScalesDAO = new ProductScalesDAO();

            return productScalesDAO;
        }

        public static IProductWeightDAO GetProductWeightDAO ()
        {
            if (productWeightDAO == null)
                productWeightDAO = new ProductWeightDAO();

            return productWeightDAO;
        }

        public static IWorkSectorDAO GetWorkSectorDAO ()
        {
            if (sectorDAO == null)
                sectorDAO = new WorkSectorDAO();

            return sectorDAO;
        }

        public static IWorkerDAO GetWorkerDAO ()
        {
            if (workerDAO == null)
                workerDAO = new WorkerDAO();

            return workerDAO;
        }

        public static ICashierDAO GetCashierDAO ()
        {
            if (cashierDAO == null)
                cashierDAO = new CashierDAO();

            return cashierDAO;
        }
    }
}
