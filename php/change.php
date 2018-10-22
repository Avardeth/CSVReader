<?php
	include('config.php');
	session_start();

	if($_SERVER["REQUEST_METHOD"] == "POST") {
	$Name = mysqli_real_escape_string($db,$_POST['name']);
	//$id = "SELECT id from student WHERE Name = '$Name'";	
	$_SESSION['name']=$Name;
	

	$sql_id = "SELECT id from student WHERE Name = '$Name'";	
	$result = mysqli_query($db,$sql_id);
	$id = mysqli_fetch_array($result,MYSQLI_BOTH);

	$_SESSION['id']=$id;

	header("Location:change2.php");

	/*$sql_change = "";
	$change = mysqli_query($db,$sql_change);*/
	}

	
?>

<html>
	<head><title>Jegy beírás/megváltoztatás</title></head>
	<body>
	<div>
	<form action = "" method = "post">
                  <label>Név  :</label><input type = "text" name = "name" class = "box"/>
                  <input type = "submit" value = " OK "/>
               </form>
	</div>
	<a href='subject.php'>Vissza</a>
	</body>
</html>
