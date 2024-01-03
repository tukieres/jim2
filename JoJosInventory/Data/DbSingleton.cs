using JoJosInventory.Classes;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace JoJosInventory.Data
{
    public class DbSingleton
    {
        private static DbSingleton instance = null;
        private SqlConnection connection;
        private string connectionStringLocal;

        //********** LookUp Queries **********************************************
        public Base RawCategoryGetList()
        {            
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            List<string> resultListCategories = new List<string>();
            List<string> resultListSku = new List<string>();
            List<string> resultListCities = new List<string>();
            
            try
            {
                string sql = string.Format("SELECT * FROM[jojosInventory].[dbo].[RawMaterial]");
                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultListCategories.Add(reader.GetString(1));
                        resultListSku.Add(reader.GetString(2));
                    }
                    
                }

                sql = string.Format("SELECT *  FROM [jojosInventory].[dbo].[Cities]");
                cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultListCities.Add(reader.GetString(1));                        
                    }
                    List<List<string>> list = new List<List<string>>();
                    list.Add(resultListCategories);
                    list.Add(resultListSku);
                    list.Add(resultListCities);
                    bs.objet = list;
                }

            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;

        }
        //********** Printed Products Queries **********************************************
        public Base PrintedProductsEdit(int id, string name, string sku, string shortDescription, string fullDescription, string qty, string city,string lista)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql;
                sql = string.Format("UPDATE Product SET Name ='{0}', Sku='{1}', ShortDescription = '{2}', FullDescription = '{3}', StockQuantity = {4}, City = '{5}'  WHERE Id ={6};",name,sku,shortDescription,fullDescription,qty,city,id);

                string sql2;
                sql2 = " DELETE FROM ProductDefinition WHERE IdProduct = " + id + ";";
                string sql3 = String.Empty;
                if (lista.Length > 0) { sql3 = " INSERT INTO ProductDefinition VALUES " + lista + ";"; }

                sql = sql + sql2 + sql3;

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }

        public Base PrintedProductsAdd(string name, string sku, string? shortD, string description, string qty, string city)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            int insertedId = 0; // Variable para almacenar el ID insertado
            try
            {
                string sql;
                if (shortD == null)
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[Product] VALUES ('{0}','{1}',NULL,'{2}', {3}, NULL,'{4}', NULL, NULL, NULL, NULL, NULL,0); SELECT SCOPE_IDENTITY();", name, sku, description, qty, city);
                }
                else
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[Product] VALUES ('{0}','{1}','{2}','{3}', {4}, NULL,'{5}', NULL, NULL, NULL, NULL, NULL,0); SELECT SCOPE_IDENTITY();", name, sku, shortD, description, qty, city);
                }

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {                    
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        insertedId = Convert.ToInt32(result);
                    }
                }
                bs.objet = insertedId;
                bs.message = "Inserted ID: " + insertedId;
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
            }
            return bs;
        }
        public Base PrintedProductsDelete(string list)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[Product] SET IsDeleted = 1 WHERE Id in {0}", list);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
        public Base PrintedProductsDefinition(int id)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("SELECT RawSMaterial.Id as RawId, RawSMaterial.Name, RawSMaterial.Sku, COALESCE(ProductDefinition.Quantity, 0) AS Quantity, CASE WHEN ProductDefinition.Quantity > 0 THEN 'True' ELSE 'False' END as Required FROM (Select * FROM RawMaterial WHERE isDelete = 0) as RawsMaterial LEFT JOIN ProductDefinition ON RawSMaterial.Id = ProductDefinition.IdRawMaterial AND ProductDefinition.IdProduct = " + id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bs.objet = dataTable;
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
            }
            return bs;
        }
        public Base PrintedProductsId(int id)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("SELECT * FROM [jojosInventory].[dbo].[Product] WHERE IsDeleted = 0 AND Id = " + id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bs.objet = dataTable;
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
            }
            return bs;
        }

        public Base PrintedProductsSearch(string? category, string? city, string? SKU, string? description)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("SELECT [Id],[Name],[Sku],[City],[StockQuantity],[FullDescription] FROM [jojosInventory].[dbo].[Product] WHERE IsDeleted = 0");
                if (!String.IsNullOrEmpty(category)) { sql = sql + " AND Name like '%" + category + "%'"; }
                if (!String.IsNullOrEmpty(SKU)) { sql = sql + " AND Sku like '%" + SKU + "%'"; }
                if (!String.IsNullOrEmpty(city)) { sql = sql + " AND City like '%" + SKU + "%'"; }
                if (!String.IsNullOrEmpty(description)) { sql = sql + " AND FullDescription like '%" + SKU + "%'"; }

                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bs.objet = dataTable;
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
            }
            return bs;
        }
        //********** Base material Queries **********************************************
        public Base BaseMaterialEdit(int Id, string name, string sku, DateOnly? dueDate, string qty)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql;
                if (dueDate == null)
                {
                    sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET Name = '{0}', Sku = '{1}', DueDate = null, CurrentAmount = {2} WHERE Id = {3}", name, sku, qty, Id);
                }
                else
                {
                    string dd = dueDate.Value.Year.ToString() + "-" + dueDate.Value.Month.ToString() + "-" + dueDate.Value.Day.ToString();
                    sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET Name = '{0}', Sku = '{1}', DueDate = '{2}', CurrentAmount = {3} WHERE Id = {4}", name, sku, dueDate.Value, qty, Id);
                }

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
        public Base BaseMaterialAdd(string name, string sku, DateOnly? dueDate, string qty)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql;
                if (dueDate == null)
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[RawMaterial] VALUES ('{0}','{1}',null,{2},0,0)", name, sku, qty);
                }else
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[RawMaterial] VALUES ('{0}','{1}','{2}',{3},0,0)", name, sku, dueDate.Value, qty);
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
        public Base BaseMaterialDelete(string list)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET IsDelete = 1 WHERE Id in {0}",list);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }                
            }
            catch (Exception ex)
            {
                bs.error = true; 
                bs.message=ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
        public Base BaseMaterialSearch(string? category, DateOnly? Duedate, string? SKU)
        {
            Base bs = new Base();            
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("SELECT Id, Name, Sku, DueDate, CurrentAmount, AmountLocked, (CurrentAmount - AmountLocked) AS QtyAvailable  FROM [jojosInventory].[dbo].[RawMaterial] WHERE IsDelete = 0");
                if (!String.IsNullOrEmpty(category)) { sql = sql + " AND Name like '%" + category + "%'"; }
                if (!(Duedate == null)) { sql = sql + " AND Duedate = '" + Duedate.Value + "'"; }
                if (!String.IsNullOrEmpty(SKU)) { sql = sql + " AND Sku like '%" + SKU + "%'"; }

                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bs.objet = dataTable;
                }               
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;

        }

        //********** Login Queries **********************************************
        public bool SetNewPassword(string id, string password)
        {           
            try
            {
                password = UtilityClass.CreateMD5(password);
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[Users] SET Password ='{0}', ResetPasswordRequired = 0 WHERE id = {1}", password, id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;

        }

        public string CheckReset(string email, string code)
        {
            string id = "0";
            string query = string.Format("SELECT *  FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND email = '{0}' AND code = '{1}'", email, code);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {                        
                        return reader[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return id;
        }
        
        public bool ForgotPassword(string email, string code)
        {
            string id = "0"; 
            string query = string.Format("SELECT id FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND email = '{0}'", email);
            SqlCommand command = new SqlCommand(query, connection);
            
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader[0].ToString();
                        break;
                    }
                    if (id == "0") return false;
                }
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[Users] SET code ='{0}', ResetPasswordRequired = 1 WHERE id = {1}",code,id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;

        }

        public bool Login(string user, string password)
        {            
            password = UtilityClass.CreateMD5(password);
            //string query = string.Format("SELECT *  FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND UserName = '{0}' AND Password = '{1}'",user,password);

            string query = string.Format(@"SELECT
    Users.*,
    (
        SELECT DISTINCT STRING_AGG(Code, ',') AS ACL
        FROM ACL
        WHERE Id IN
        (
            SELECT IdACL
            FROM Roles_ACL_Mapping
            WHERE IdRole IN
            (
                SELECT Id
                FROM ROLES
                WHERE Id IN
                (
                    SELECT IdRole
                    FROM User_Role_Mapping
                    WHERE IdUser = Users.Id
                )
                AND IsActive = 1
                AND IsDelete = 0
            )
        )
    ) AS UserACL
FROM
    [jojosInventory].[dbo].[Users]
WHERE
    IsActive = 1
    AND IsDelete = 0
    AND UserName = '{0}'
    AND Password = '{1}';",user,password);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BcLogin login = BcLogin.Instance;
                        login.Username = reader[1].ToString();
                        login.Email = reader[3].ToString();
                        login.ACLs = reader[8].ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);                
            }
            return false;

        }
        //************************** Instance & connections *******************************************
        private DbSingleton()
        {
        }

        public static DbSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbSingleton();
                }
                return instance;
            }
        }

        public void CreateConnection(string connectionString)
        {
            connectionStringLocal = connectionString;

            //using (connection = new SqlConnection(connectionStringLocal))
            connection = new SqlConnection(connectionStringLocal);
                //{
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error al conectarse a la base de datos: " + e.Message);
                }
            //}
        }

        public void CloseConnection()
        {       
            if (connection != null) 
            {
                try
                {            
                    if (connection.State.Equals(System.Data.ConnectionState.Open))connection.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error al conectarse a la base de datos: " + e.Message);
                }
            }
        }

    }
}
