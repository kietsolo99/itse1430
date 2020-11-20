/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    /// <summary>Base class for product database.</summary>
    public class SqlProductDatabase : ProductDatabase
    {
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>

        public SqlProductDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
        protected override Product AddCore ( Product product )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "AddProduct";
                command.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", product.Name);
                command.Parameters.Add(parmName);

                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = product.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);

                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                object result = command.ExecuteScalar();
                var id = Convert.ToInt32(result);

                product.Id = id;
                return product;
            };
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        protected override Product GetCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "GetProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productId = reader.GetInt32(0);
                        if (productId == id)
                        {
                            return new Product() {
                                Id = productId,
                                Name = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetFieldValue<decimal>(3),
                                IsDiscontinued = reader.GetFieldValue<bool>(6)
                            };
                        };
                    };
                };
            };

            return null;
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet();

            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetAllProducts", connection);
                command.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter() {
                    SelectCommand = command
                };
                da.Fill(ds);
            };

            var table = ds.Tables.Count > 0 ? ds.Tables[0] : null;
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    yield return new Product() {
                        Id = Convert.ToInt32(row[0]),
                        Name = row["name"].ToString(),

                        Description = row.IsNull("Description") ? null : row.Field<string>("description"),
                        Price = row.Field<decimal>("Price"),
                        IsDiscontinued = row.Field<bool>("IsDiscontinued"),
                    };
                };
            };
        }
        /// <summary>Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        protected override void RemoveCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();

                command.CommandText = "RemoveProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        protected override Product UpdateCore ( Product existing, Product product )
        {
            //Replace 
            existing = FindProduct(product.Id);
            _products.Remove(existing);

            var newProduct = CopyProduct(product);
            _products.Add(newProduct);

            return CopyProduct(newProduct);
        }

        private Product CopyProduct ( Product product )
        {
            var newProduct = new Product();
            newProduct.Id = product.Id;
            newProduct.Name = product.Name;
            newProduct.Description = product.Description;
            newProduct.Price = product.Price;
            newProduct.IsDiscontinued = product.IsDiscontinued;

            return newProduct;
        }

        //Find a product by ID
        private Product FindProduct ( int id )
        {
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            };

            return null;
        }

        private List<Product> _products = new List<Product>();
        private int _nextId = 1;

        private SqlConnection OpenConnection ()
        {
            //Connect to database using connection string
            var conn = new SqlConnection(_connectionString);

            //SqlException if something goes wrong
            conn.Open();
            return conn;
        }
    }
}
