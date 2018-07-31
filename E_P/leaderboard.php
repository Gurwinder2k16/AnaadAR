<?PHP

$server_name="localhost";
$user_name="u395635989_skand";
$password="Asdfghjkl@123";
$con = mysql_connect($server_name, $user_name, $password) 
or die ('Server Error: ' . mysql_error());
$database_name='u395635989_skand';
mysql_select_db($database_name) or die(' DB Error: Unable to select db');
mysql_query("SET NAMES 'utf8'");
$result=mysql_query("SELECT * FROM level_zone WHERE point<=(select max(point) from level_zone) order by point desc") or die("Email ID already Exist!!!");
while($row=mysql_fetch_assoc($result)){$json[]=$row;}
print(json_encode($json));


?>
