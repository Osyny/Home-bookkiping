using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Local_DB
{
    public class HomeBugaltery
    {
        static private HomeBugaltery instance = null;

        BisnesLogic bisnesLogic;
        private List<OrdersView> orderCostsProfit;
        List<OrdersView> listOrders;
      
        List<Categories> listCategories;
        List<Users> listUsers;

        static public HomeBugaltery getInstance()
        {
            if (instance == null)
                instance = new HomeBugaltery();

            return instance;
        }

        private HomeBugaltery()
        {
            bisnesLogic = new BisnesLogic();

            //filteredListOrders = new List<OrdersView>();
            orderCostsProfit = new List<OrdersView>();

            //usersSaldo = new List<UserSaldo>();

            validateLocalData();

        }

        public List<OrdersView> ListOrders { get { return listOrders; } }

        public List<Categories> ListCategories { get { return listCategories; } }
        public List<Users> ListUsers { get { return listUsers; } }

        // Filter Order for Expens, Revenues
        public List<OrdersView> OrderCostsProfitList { get { return orderCostsProfit; } }
        //
        public void validateLocalData()
        {
            // Valid data with
            listOrders = bisnesLogic.getAllOrders();
            listCategories = bisnesLogic.getAllCategory();
            listUsers = bisnesLogic.getAllUsers();


        }

        public void addOrder(string categoryName, string userName, DateTime dateOrder, decimal price, string description)
        {
            bisnesLogic.addOrder(categoryName, userName, dateOrder, price, description);
            validateLocalData();
        }

        public void changeOrder(int id, string categoryName, string userName, DateTime dateOrder, decimal price, string description)
        {
            bisnesLogic.updateOrder(id, categoryName, userName, dateOrder, price, description);
            validateLocalData();
        }

        public void addCategory(string categoryName, bool type)
        {
            bisnesLogic.addCategory(categoryName, type);
            validateLocalData();
        }

        // deleteOrder
        public void deleteOrder(int id)
        {
            bisnesLogic.deleteOrder(id);
            validateLocalData();
        }

        // deleteCategory
        public void deleteCategory(int id)
        {
            bisnesLogic.delateCategory(id);
            validateLocalData();
        }

        // change category
        public void changeCategory(int id, string newName, bool newType)
        {
            bisnesLogic.updateCategory(id, newName, newType);
            validateLocalData();
        }

        public Users getUserById(int id)
        {
            var user = bisnesLogic.getUserById(id);
            return user;
        }

        // add user
        public void addNewUser(string email, string name, string password, int famalyId)
        {
            bisnesLogic.addNewUser(email, name, password, famalyId);
            validateLocalData();
        }

        //CHANGE local user
        public void updateUser(int id, string email, string name, string pass/*, int familyId*/)
        {
            bisnesLogic.updateUser(id, email, name, pass);
            validateLocalData();
        }

        // Delete user for Id
        public void deleteUser(int id)
        {
            bisnesLogic.deleteUser(id);
            validateLocalData();
        }

        public decimal applyFiltersForCostsProfit(bool type, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            orderCostsProfit.Clear();
            decimal sum = 0;

            foreach (OrdersView order in listOrders)
            {
                bool orderCategoryType = listCategories.Where(c => c.Name == order.CategoryName).FirstOrDefault().Type;

                if ((dateFrom == null || order.DateOrder >= dateFrom) && (dateTo == null || order.DateOrder <= dateTo) &&
                    (type == orderCategoryType))
                {
                    sum += order.Price;
                    orderCostsProfit.Add(order);
                }
            }
            return sum;

        }
        public string getFamilyName(int id)
        {
            var fam = bisnesLogic.getFamilyName(id).Name;
            return fam;
        }



    }
}
