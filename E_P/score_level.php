<?PHP

if(isset($_POST['txt_email']))
{
$server_name="localhost";
$user_name="u395635989_skand";
$password="Asdfghjkl@123";
$con = mysql_connect($server_name, $user_name, $password) 
or die ('Server Error: ' . mysql_error());
$database_name='u395635989_skand';
mysql_select_db($database_name) or die(' DB Error: Unable to select db');
mysql_query("SET NAMES 'utf8'");
$txt_email=$_POST['txt_email'];
$result_login=mysql_query("select compl_level,SUM(point) from level_zone where email='$txt_email'") or die("Email ID not Exist!!!");
while($row=mysql_fetch_assoc($result)){$json[]=$row;}
print(json_encode($json));
}
?>

