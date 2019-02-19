using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;
using System.IO;

namespace Session
{
    public class Broker 
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;

        // Database connection
         void ConnectTo()
        {
            /// (Pattern) Data Source=DESKTOP-VHTTPF9\FILIPSZNIP;Initial Catalog=Baza1;Integrated Security=True
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-VHTTPF9\\FILIPSZNIP";
            connStringBuilder.InitialCatalog = "Baza1";
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
        }
        // Invoke the connection whenever the class object is initialized
        public Broker()
        {
            ConnectTo();
        }
        // Update the record in the table
        public void AddSquat(Squats newSq, Squats oldSq)
        {
            try
            {
                string cmdText = "UPDATE dbo.Squat SET Weight = @Weight, Reps = @Reps WHERE [Set] = @Set";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@Weight", newSq.Weights);
                cmd.Parameters.AddWithValue("@Reps", newSq.Reps);
                cmd.Parameters.AddWithValue("@Set", oldSq.Set);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Get records from the table 
        public List<Squats> CmbSQuat()
        {
            List<Squats> Squatlists = new List<Squats>();
            try
            {
                string cmdText = "SELECT * FROM baza1.dbo.Squat";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Squats s = new Squats();
                    s.Reps = Convert.ToInt32(reader["Reps"]);
                    s.Set = Convert.ToInt32(reader["Set"]);
                    s.Weights = Convert.ToInt32(reader["Weight"]);

                    Squatlists.Add(s);
                }
                return Squatlists;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Insert record into the table
        public void InsertSquat(Squats s)
        {
            try
            {
                string cmdText = "INSERT INTO baza1.dbo.Squat(Weight, Reps) VALUES(@Weight, @Reps)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@Weight", s.Weights);
                cmd.Parameters.AddWithValue("@Reps", s.Reps);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Set identity as 0
        public void ResetInc()
        {
            try
            {
                string cmdText = "DBCC CHECKIDENT (Squat, RESEED, 0)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Calculate total volume of training
        public int TotalVolume()
        {
            try
            {
                string cmdText = "select sum(Weight*Reps) as Volume from Baza1.dbo.Squat";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                int mySum = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return mySum;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Get max weight from the table
        public int MaxSquat()
        {
            try
            {
                string cmdText = "select max(Weight) as [Max] from Baza1.dbo.Squat";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                int mySum = Convert.ToInt32(cmd.ExecuteScalar());

                return mySum;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Insert volume record into the table
        public void SaveMaxVolume()
        {
            try
            {
                string cmdText = "insert into Baza1.dbo.VolumeMax(MaxVolume) values(@mySum)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@mySum", TotalVolume());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Get max volume record from the table
        public int GetMaxVolume()
        {
            try
            {
                string cmdText = "select max(MaxVolume) from VolumeMax";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                int mySum = Convert.ToInt32(cmd.ExecuteScalar());

                return mySum;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Insert max weight record into the table
        public void SaveMaxWeight()
        {
            try
            {
                string cmdText = "insert into Baza1.dbo.WeightMax(MaxWeight) values(@mySum)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@mySum", MaxSquat());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Get max weight record from the table
        public int GetMaxWeight()
        {
            try
            {
                string cmdText = "select max(MaxWeight) from WeightMax";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                int mySum = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return mySum;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Delete all records in the table
        public void Delete()
        {
            try
            {
                string cmdText = "delete from Baza1.dbo.Squat";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
