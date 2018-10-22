<?php
function teacher() {

include ("config.php");

$sql = "SELECT Name, math, chem, physics, drawing, phyEd, Class FROM subject RIGHT JOIN student ON subject.id=student.id ORDER BY Class, Name";
$result = mysqli_query($db, $sql);

if (mysqli_num_rows($result) > 0)
{
	while($row = mysqli_fetch_array($result))
	{
?>
	<tr>
		<td><?php echo $row["Name"];?></td>
		<td><?php echo $row["math"];?></td>
		<td><?php echo $row["chem"];?></td>
		<td><?php echo $row["physics"];?></td>
		<td><?php echo $row["drawing"];?></td>
		<td><?php echo $row["phyEd"];?></td>
		<td><?php echo $row["Class"];?></td>
	</tr>
<?php
	}
}

?>

<form action="change.php"><input type="submit" value="Jegy beírás/megváltoztatás" /></form>

<?php

}

?>


