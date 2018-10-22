<?php
	include('config.php');
	session_start();
	//include('login.php');

	header ('Content-type: text/html; charset=utf-8');
?>

<html>
<head>
	<title>Napló</title>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>  
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />  
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script> 
	
</head>
<body>
	<div class="container" style="width:700px;">  
                <h3 align="">Napló</h3><br />                 
                <div class="table-responsive">
<table class="table table-striped">
<tr>
	<td>Név</td>
	<td>Matek</td>
	<td>Kémia</td>
	<td>Fizika</td>
	<td>Rajz</td>
	<td>Tesi</td>
	<td>Osztály</td>
<tr>
<?php

include('parent.php');
include('teacher.php');
include('princ.php');



$perm=$_SESSION['Permission'];
//echo $perm[0];

switch($perm[0]){
case 'admin': princ();break;
case 'mod': teacher();break;
case 'user': parent();break;
}



?>
</table>
<form action="login.php">
	<input type="submit" value="Kijelentkezés" />
</form>
</div>
</div>
</body>
</html>
