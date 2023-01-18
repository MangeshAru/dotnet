// updade query for Mysql?
private void Update(string num,string name, string quant, string location, string category, string numquery)
    {
       // "UPDATE Inventory SET Inventorynumber='"+ num +"',Inventory_Name='"+name+"', Quantity ='"+ quant+"',Location ='"+ location+"' Category ='"+ category+"' WHERE Inventorynumber ='"+ numquery +"';";
        string query = "UPDATE Inventory SET Inventorynumber=@Inventorynumber,Inventory_Name=@Inventory_Name, Quantity =@Quantity ,Location =@Location,Category =@Category WHERE Inventorynumber =@Inventorynumber";
        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Inventorynumber",Convert.ToInt16(num));
            cmd.Parameters.AddWithValue("@Inventory_Name",name);
            cmd.Parameters.AddWithValue("@Quantity",quant);
            cmd.Parameters.AddWithValue("@Location",location);
            cmd.Parameters.AddWithValue("@Category",category);
            cmd.Parameters.AddWithValue("@Inventorynumber",Convert.ToInt16(numquery));
            cmd.Connection = serverconnection;
            cmd.ExecuteNonQuery();
            this.CloseConnection();
            Bind();
        }
    }






//Source: https://stackoverflow.com/questions/20492019


