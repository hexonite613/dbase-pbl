<?php
$id = $_POST['movieId'];
$mysqli = mysqli_connect("","","","");

$check = "SELECT * from movie WHERE movie_id='$id'";
$result = $mysqli->query($check);

if ($result->num_rows==0) {
    echo '<script>alert("잘못된 영화 ID 값입니다. ID를 확인하세요.");history.back();</script>';
    exit();
}

/*
echo 'id '.$id.'<br>';
echo 'rt '.$rt.'<br>';
echo 'name '.$name.'<br>';
echo 'enname '.$enname.'<br>';
echo 'rate '.$rate.'<br>';
echo 'gid '.$gid.'<br>';
echo 'desc '.$desc.'<br>';

echo "INSERT INTO `movie` (`movie_id`, `gerne_id`, `name`, `enname`, `movie_time`, `desc`, `rating`) VALUES ('$id', '$gid', '$name', '$ename', '$rt', '$desc', '$rate')";
*/

$del = mysqli_query($mysqli, "DELETE FROM `movie` WHERE `movie`.`movie_id` = ".$id);

if ($del) {
    echo '<script>window.location.href="../";</script>';
    exit();
} else {
    echo '<script>alert("삭제에 실패하였습니다");history.back();</script>';
    exit();
}

?>