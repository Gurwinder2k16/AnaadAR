<?PHP

if(isset($_POST['txt_email']) && isset($_POST['txt_user']) && isset($_POST['txt_opt']))
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
$txt_user=$_POST['txt_user'];
$txt_opt=$_POST['txt_opt'];
if($txt_opt=="1")
{
$result_reg=mysql_query("insert into user_login values('$txt_email','$txt_user','none','false')") or die("Email ID already Exist!!!");
if($result_reg)
{
echo "Succesfully Registerd";
}
}
else if($txt_opt=="2")
{
$result_login=mysql_query("select * from user_login where email='$txt_email' and user_name='$txt_user' ") or die("Email ID not Exist!!!");
if (mysql_num_rows($result_login) > 0) 
{
    echo 'Sucessfully Logined..';
} 
else 
{
    echo 'Email ID not Exist!!!';
}
}
}
?>

