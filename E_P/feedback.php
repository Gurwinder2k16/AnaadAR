<?PHP
if(isset($_POST['txt_email']) && isset($_POST['txt_mssg']))
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
$txt_mssg=$_POST['txt_mssg'];
$result_reg=mysql_query("insert into feed_back values('$txt_email','$txt_mssg','none','false')") or die("Error");
if($result_reg)
{
echo "Send Succesfully";
}
}
?>

