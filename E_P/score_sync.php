<?PHP

if(isset($_POST['txt_email']) && isset($_POST['txt_point']) && isset($_POST['txt_level']))
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
$txt_point=$_POST['txt_point'];
$prev_result=mysql_query("select point from level_zone where email='$txt_email' ") or die("Email ID already Exist!!!");
while ($row = mysql_fetch_array($prev_result)) {
    $temp = $row['point'];
}
if($temp>0)
{
$txt_point += $temp;
$temp1=mysql_query("Update level_zone set point='$txt_point', compl_level='$txt_level' where email='$txt_email' ") or die("Email ID already Exist!!!");
if($temp1)
{
echo "Succesfully Registerd";
}
}
else
{
$result_reg=mysql_query("insert into level_zone values('$txt_email','$txt_level','$txt_point')") or die("Email ID already Exist!!!");
if($result_reg)
{
echo "Succesfully Registerd";
}
}
}
?>


