<?PHP
if(isset($_POST['txt_lang']))
{
$server_name="localhost";
$user_name="u395635989_skand";
$password="Asdfghjkl@123";
$con = mysql_connect($server_name, $user_name, $password) 
or die ('Server Error: ' . mysql_error());
$database_name='u395635989_skand';
mysql_select_db($database_name) or die(' DB Error: Unable to select db');
mysql_query("SET NAMES 'utf8'");
$txt_place=$_POST['txt_place'];
$txt_lang=$_POST['txt_lang'];
$result=mysql_query("select history from history where place='$txt_place' and lang='$txt_lang'") or die("Error in database");
if(mysql_num_rows($result) > 0){
		//show data for each row
		while($row = mysql_fetch_assoc($result)){
			echo $row['history'];
		}
	}
}
?>