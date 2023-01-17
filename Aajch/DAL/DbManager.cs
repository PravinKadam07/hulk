namespace DAL;
using  MySql.Data.MySqlClient;
using BOL;
using System.Collections.Generic;
public class DbManager
{
public static string conString = @"server=localhost;user=pokemon;port=3306;password=root123;database=product";

 public static void InsertStudentData(Student student)
    {
        MySqlConnection mysqlCon = new MySqlConnection();
        mysqlCon.ConnectionString = conString;
        try
        {
            mysqlCon.Open();

            string query = "Insert into Student values(" + student.id + ",'" + student.name + "','" + student.place + "')";
            MySqlCommand sqlCommand = new MySqlCommand(query,mysqlCon);
            sqlCommand.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            mysqlCon.Close();
        }



    }







}
