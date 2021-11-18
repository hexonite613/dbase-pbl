<?php
$orgid = $_POST['orgmovieId'];
$id = $_POST['movieId'];
$rt = $_POST['runtime'];
$name = $_POST['koname'];
$enname = $_POST['enname'];
$rate = $_POST['rate'];
$gid = $_POST['gerneid'];
$desc = $_POST['desctext'];

if ($rate == '') {
    echo '<script>alert("등급을 지정해 주세요");history.back();</script>';
    exit();
}

// 문자열 이스케이프 처리

$name = str_replace("\\", "\\\\", $name);
$enname = str_replace("\\", "\\\\", $enname);
$desc = str_replace("\\", "\\\\", $desc);
$name = str_replace("'", "\\'", $name);
$enname = str_replace("'", "\\'", $enname);
$desc = str_replace("'", "\\'", $desc);

$mysqli = mysqli_connect("","","","");

if ($orgid != $id) {
    $check = "SELECT * from movie WHERE movie_id='$id'";
    $result = $mysqli->query($check);

    if ($result->num_rows!=0) {
        echo '<script>alert("이미 존재하는 영화 ID입니다. 다른 ID로 설정해 주세요.");history.back();</script>';
        exit();
    }
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

$add = mysqli_query($mysqli, "UPDATE `movie` SET `movie_id` = '$id', `gerne_id` = '$gid', `name` = '$name', `enname` = '$enname', `movie_time` = '$rt', `descr` = '$desc', `rating` = '$rate' WHERE `movie`.`movie_id` = ".$orgid);

if ($add) {
    echo '<script>alert("수정에 성공하였습니다");window.location.href="../";</script>';
    exit();
} else {
    echo '<script>alert("수정에 실패하였습니다");window.location.href="../";</script>';
    exit();
}

?>