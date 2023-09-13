using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class SQLConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            //throw new NotImplementedException();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@FirstName", model.Name);
                    p.Add("@LastName", model.LastName);
                    p.Add("@EmailAddress", model.EmailAddress);
                    p.Add("@PhoneNumber", model.PhoneNumber);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@Id");

                    return model;

                }
                // DynamicParamets (uses Dapper)
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();
            //model.Id = 1;
            //return model;
            // I want to create a new IdbConnection 
            // IdbConnection is something that microsoft has and in this case we gonna fill the connection with a stystem.data connection.
            // using -> I wanna wrap the entire line between the () and after using it I want to destroy that properly . PREVENTS MEMORY LEAKS.



            //@PlaceNumber		    int,
            //@PlaceName            nvarchar(50),
            //@PrizeAmount          money,
            //@PrizePercentage      \float,
            //@Id                   int = 0 output



            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@PlaceNumber", model.PlaceNumber);
                    p.Add("@PlaceName", model.PlaceName);
                    p.Add("@PrizePercentage", model.PrizePercentage);
                    p.Add("@PrizeAmount", model.PrizeAmount);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@Id");

                    return model;

                }
                // DynamicParamets (uses Dapper)
                catch (Exception)
                {
                    throw;
                }


            }


        }

        public List<PersonModel> GetPerson_ALL()
        {
            List<PersonModel> output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GetAll").ToList();

            }
            return output;
        }
    }
}
