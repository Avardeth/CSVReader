<?php
	include('config.php');
	//include('change.php');
	session_start();
	
	$Name=$_SESSION['name'];

	/*$sql_id = "SELECT id from student WHERE Name = '$Name'";	
	$result = mysqli_query($db,$sql_id);
	$id = mysqli_fetch_array($result,MYSQLI_BOTH);*/

	$id = $_SESSION['id'];
	
	if($_SERVER["REQUEST_METHOD"] == "POST") {
	$math = mysqli_real_escape_string($db,$_POST['math']);
	$chem = mysqli_real_escape_string($db,$_POST['chem']);
	$phys = mysqli_real_escape_string($db,$_POST['phys']);
	$draw = mysqli_real_escape_string($db,$_POST['draw']);
	$phyEd = mysqli_real_escape_string($db,$_POST['phyEd']);
	
	

	$sql_change = "INSERT INTO subject (id, math, chem, physics, drawing, phyEd) VALUES ('$id[0]', '$math', '$chem', '$phys', '$draw', '$phyEd') ON DUPLICATE KEY UPDATE math='$math', chem='$chem', physics='$phys', drawing='$draw', phyEd='$phyEd'";
	//$sql_change = "UPDATE subject SET id=$id[0], math='$math', chem='$chem', physics='$phys', drawing='$draw', phyEd='$phyEd' WHERE id='$id[0]'";
	//$sql_change = "REPLACE INTO subject VALUES ('$id[0]', '$math', '$chem', '$phys', '$draw', '$phyEd')";
	$change = mysqli_query($db,$sql_change);

	header("Location:subject.php");
	}

	
?>

<html>
	<head><title>Jegy beírás/megváltoztatás</title></head>
	<body>
	<div>
	
	</div>
	<form action = "" method = "post">
	<p>Név:<?php echo $Name; ?></p><br />
	<label>Matek  :</label><input type = "text" name = "math" class = "box"/>
	<label>Kémia  :</label><input type = "text" name = "chem" class = "box"/>
	<label>Fizika  :</label><input type = "text" name = "phys" class = "box"/>
	<label>Rajz  :</label><input type = "text" name = "draw" class = "box"/>
	<label>Tesi  :</label><input type = "text" name = "phyEd" class = "box"/>
	<input type = "submit" value = " OK "/>
	</form>
	<div>
	
	</div>

	<a href='subject.php'>Vissza</a>
	</body>
</html>
