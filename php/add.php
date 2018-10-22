<?php
	include('config.php');
	

	if($_SERVER["REQUEST_METHOD"] == "POST") {
	$Name = mysqli_real_escape_string($db,$_POST['name']);
	$Class = mysqli_real_escape_string($db,$_POST['class']);

	$sql_add = "INSERT INTO student (Name, Class) VALUES ('$Name', '$Class')";
	$add = mysqli_query($db,$sql_add);

	$sql_id = "SELECT id FROM student WHERE Name = '$Name'";
	$result = mysqli_query($db,$sql_id);
	$id = mysqli_fetch_array($result,MYSQLI_BOTH);

	$sql_i = "INSERT INTO subject (id) VALUES ('$id[0]')";
	$i = mysqli_query($db,$sql_i);
	}
?>

<html>
	<head><title>Tanuló hozzáadása</title></head>
	<body>
	<div>
	<form action = "" method = "post">
                  <label>Név  :</label><input type = "text" name = "name" class = "box"/>
		  <label>Osztály  :</label><input type = "text" name = "class" class = "box"/>
                  <input type = "submit" value = " OK "/>
               </form>
	</div>
	<a href='subject.php'>Vissza</a>
	</body>
</html>
