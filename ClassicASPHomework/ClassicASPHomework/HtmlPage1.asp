<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
     <% 
        set conn=Server.CreateObject("ADODB.Connection")
        conn.Provider="Microsoft.Jet.OLEDB.4.0"
        conn.Open "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        set rs = Server.CreateObject("ADODB.recordset")
        rs.Open "SELECT * FROM Games", conn
       
        while resultSet != null
        {
          <p>resultSet['GameName', 'genre','GameType','review']</p>
          <p>resultSet['GameName', 'genre','GameType','review']</p>
        }
        rs.Close
        conn.Close
    %>

</body>
</html>