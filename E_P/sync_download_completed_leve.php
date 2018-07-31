<?PHP

if(isset($_POST['txt_email'])  && isset($_POST['txt_level']))
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
$txt_level=$_POST['txt_level'];
$result_login=mysql_query("select * from level_zone where email='$txt_email' and compl_level='$txt_level' ") or die("Email ID not Exist!!!");
if (mysql_num_rows($result_login) > 0) 
{
    echo 'completed';
} 
else 
{
    echo 'pending';
}
}
?>

