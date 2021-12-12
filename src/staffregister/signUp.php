<?php
$id = $_POST['id'];
$pw = $_POST['pw'];
$pwc = $_POST['pwc'];
$name = $_POST['name'];
$email = $_POST['email'];
$staffcode = hash('sha256', $_POST['staffcode']);
$type = 'normal';

if ($pw != $pwc) {
    echo '<script>alert("비밀번호 확인값이 일치하지 않습니다");history.back();</script>';
    exit();
}

if ($id==NULL || $pw==NULL || $name==NULL || $email==NULL) {
    echo '<script>alert("칸을 모두 채워주세요");history.back();</script>';
    exit();
}

$mysqli = mysqli_connect("", "", "", "");

echo "1";

$check = "SELECT * FROM staff WHERE id='$id'";
$result = $mysqli->query($check);

if ($result->num_rows==1) {
    echo '<script>alert("중복된 ID입니다. 다른 ID로 설정해주세요");history.back();</script>';
    exit();
}

$check = "SELECT * FROM `staff_auth` WHERE auth_key = '$staffcode' AND valid_date >= now()";
$result = $mysqli->query($check);

if ($result->num_rows < 1) {
    echo '<script>alert("올바른 인증코드가 아닙니다");history.back();</script>';
    exit();
} else {
    $res = mysqli_fetch_array($result);
    $type = $res['staff_type'];
    $theather = $res['theater_id'];
}



// 비밀번호 암호화
$hpw = hash('sha256', $pw);

$signup = mysqli_query($mysqli, "INSERT INTO `staff` (`id`, `division_id`, `theater_id`, `name`, `addr`, `pwd`, `email`, `phonenum`, `staff_type`) VALUES ('$id', NULL, '$theather', '$name', NULL, '$hpw', NULL, NULL, '$type')");

echo "INSERT INTO `staff` (`id`, `division_id`, `theater_id`, `name`, `addr`, `pwd`, `email`, `phonenum`, `staff_type`) VALUES ('$id', NULL, '$theather', '$name', NULL, '$hpw', NULL, NULL, '$type')";

if ($signup) {
    echo '<script>alert("가입 성공");</script>';
    header('location: ./complete.html');
    exit();
}

?>