using May15.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

public static class JobService
{
    private static string dbconnstr = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
    public static JobModel Query(Guid id)
    {
        using (SqlConnection conn = new SqlConnection(dbconnstr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select * from jobs where id=@id ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    var item = new JobModel();
                    item.Id = Guid.Parse(dr["id"].ToString());
                    item.Name = dr["name"].ToString();
                    item.Code = dr["code"].ToString();
                    item.Desc = dr["desc"].ToString();
                    item.JobLocation = dr["joblocation"].ToString();

                    if (!string.IsNullOrEmpty(dr["minsalary"].ToString()))
                    {
                        item.MinSalary = int.Parse(dr["minsalary"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["maxsalary"].ToString()))
                    {
                        item.MaxSalary = int.Parse(dr["maxsalary"].ToString());
                    }

                    return item;
                }
                dr.Close();
            }
        }

        return null;
    }

    public static List<JobModel> Query(string name, int? pay)
    {
        List<JobModel> result = new List<JobModel>();

        using (SqlConnection conn = new SqlConnection(dbconnstr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string wherestr = string.Empty;
                cmd.Connection = conn;

                cmd.CommandText = @"select * from jobs ";

                if (!string.IsNullOrEmpty(name))
                {
                    if (!string.IsNullOrEmpty(wherestr))
                    {
                        wherestr += " and ";
                    }
                    wherestr += " name like @name ";
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                }

                if (pay.HasValue)
                {
                    if (!string.IsNullOrEmpty(wherestr))
                    {
                        wherestr += " and ";
                    }
                    wherestr += " minsalary>=@pay ";
                    cmd.Parameters.AddWithValue("@pay", pay);
                }

                if (!string.IsNullOrEmpty(wherestr))
                {
                    cmd.CommandText += " where " + wherestr;
                }

                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var item = new JobModel();
                    item.Id = Guid.Parse(dr["id"].ToString());
                    item.Name = dr["name"].ToString();
                    item.Code = dr["code"].ToString();
                    item.Desc = dr["desc"].ToString();
                    item.JobLocation = dr["joblocation"].ToString();

                    if (!string.IsNullOrEmpty(dr["minsalary"].ToString()))
                    {
                        item.MinSalary = int.Parse(dr["minsalary"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["maxsalary"].ToString()))
                    {
                        item.MaxSalary = int.Parse(dr["maxsalary"].ToString());
                    }

                    result.Add(item);
                }
                dr.Close();
            }
        }

        return result;
    }

    public static void Add(JobModel item)
    {
        using (SqlConnection conn = new SqlConnection(dbconnstr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                cmd.CommandText = @"insert into jobs(code,name,minsalary,maxsalary,[desc],joblocation) 
                                        values(@code,@name,@minsalary,@maxsalary,@desc,@joblocation)";

                cmd.Parameters.AddWithValue("@code", item.Code);
                cmd.Parameters.AddWithValue("@name", item.Name);
                if (item.MinSalary.HasValue)
                {
                    cmd.Parameters.AddWithValue("@minsalary", item.MinSalary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@minsalary", DBNull.Value);
                }
                if (item.MaxSalary.HasValue)
                {
                    cmd.Parameters.AddWithValue("@maxsalary", item.MaxSalary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maxsalary", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(item.Desc))
                {
                    cmd.Parameters.AddWithValue("@desc", item.Desc);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(item.JobLocation))
                {
                    cmd.Parameters.AddWithValue("@joblocation", item.JobLocation);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@joblocation", DBNull.Value);
                }

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static void Edit(JobModel item)
    {
        using (SqlConnection conn = new SqlConnection(dbconnstr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                cmd.CommandText = @"update jobs set 
                                        code=@code,
                                        name=@name,
                                        [desc]=@desc,
                                        minsalary=@minsalary,
                                        maxsalary=@maxsalary,
                                        joblocation=@joblocation
                                        where id=@id";

                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@code", item.Code);
                cmd.Parameters.AddWithValue("@name", item.Name);
                if (item.MinSalary.HasValue)
                {
                    cmd.Parameters.AddWithValue("@minsalary", item.MinSalary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@minsalary", DBNull.Value);
                }
                if (item.MinSalary.HasValue)
                {
                    cmd.Parameters.AddWithValue("@maxsalary", item.MaxSalary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maxsalary", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(item.Desc))
                {
                    cmd.Parameters.AddWithValue("@desc", item.Desc);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(item.JobLocation))
                {
                    cmd.Parameters.AddWithValue("@joblocation", item.JobLocation);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@joblocation", DBNull.Value);
                }
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static void Del(Guid id)
    {
        using (SqlConnection conn = new SqlConnection(dbconnstr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                cmd.CommandText = @"delete from jobs where id=@id";

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}