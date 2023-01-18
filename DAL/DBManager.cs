namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conn = @"server=localhost;
                           user =root;
                           port= 3306;
                           password = welcome@123;
                           database = studentInfo";
    public static List<Student> getAll(){
        List<Student> data = new List<Student>();
        MySqlConnection mysql = new MySqlConnection();
        mysql.ConnectionString = conn;

        try{
            mysql.Open();
            MySqlCommand  cmd = new MySqlCommand();
            cmd.Connection=mysql;
            cmd.CommandText = "select * from student";
            MySqlDataReader  reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString()!);
                 string? name = reader["Name"].ToString();
                 int marks = int.Parse(reader["Marks"].ToString()!);
                Student std =new Student(){
                    Id=id,
                    Name=name,
                    Marks=marks
                };
                data.Add(std);
            }
            

        }catch(Exception e){
            Console.WriteLine(e.Message);

        }finally{
                mysql.Close();
        }
        return data;
    }

    public static void insertStdData(Student student){
         MySqlConnection mysql = new MySqlConnection();
        mysql.ConnectionString = conn;
        try{
            mysql.Open();
            string query = "insert into student values(" + student.Id + ",'" + student.Name + "','" + student.Marks +"')";
            MySqlCommand cmd = new MySqlCommand(query,mysql);
             cmd.ExecuteNonQuery();


        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mysql.Close();
        }

    }
    public static void  updateStd(Student std){

    }


    
}




