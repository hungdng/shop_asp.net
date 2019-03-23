using System;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Lop nay dung de xu ly du lieu....
/// </summary>
public class LopDungChung
{
	public LopDungChung()
	{
	}

    //Ket noi CSDL
    private SqlConnection ketNoi()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\DUY_TAN\ChoDienTu_rewrite\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        //con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Shop_Online;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Shop_Online.mdf";
        try
        //file:///C:\Users\Administrator\Desktop\ChoDienTu\App_Data\Database.mdf
        {
            con.Open();
        }catch(SqlException ex)
        {
            return null;
        }
        return con;
    }

    public int xuLy(string query)
    {
        SqlCommand com = new SqlCommand(query, ketNoi());
        try
        {
            return com.ExecuteNonQuery();
        }catch(SqlException)
        {
            return 0;
        }
    }

    public object docDuyNhat(string query)
    {
        SqlCommand com = new SqlCommand(query, ketNoi());
        try
        {
            return com.ExecuteScalar();
        }
        catch (SqlException)
        {
            return null;
        }
    }
    public SqlDataReader docNhieuDuLieu(string query)
    {
        SqlCommand com = new SqlCommand(query, ketNoi());
        try
        {
            return com.ExecuteReader();
        }
        catch (SqlException)
        {
            return null;
        }
    }
}