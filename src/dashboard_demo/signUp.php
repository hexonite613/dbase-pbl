<?php
$id = $_POST['id'];
$pw = $_POST['pw'];
$pwc = $_POST['pwc'];
$name = $_POST['name'];
$email = $_POST['email'];

if ($pw != $pwc) {
    echo '<script>alert("비밀번호 확인값이 일치하지 않습니다");history.back();</script>';
    exit();
}

if ($id==NULL || $pw==NULL || $name==NULL || $email==NULL) {
    echo '<script>alert("칸을 모두 채워주세요");history.back();</script>';
    exit();
}

$mysqli = mysqli_connect("","","","");

echo "1";

$check = "SELECT *from user WHERE userid='$id'";
$result = $mysqli->query($check);

if ($result->num_rows==1) {
    echo '<script>alert("중복된 ID입니다. 다른 ID로 설정해주세요");history.back();</script>';
    exit();
}

// 비밀번호 암호화
$hpw = hash('sha256', $pw);

$signup = mysqli_query($mysqli, "INSERT INTO user(userid, pw, name, mail) VALUES ('$id', '$hpw', '$name', '$email')");

if ($signup) {
    echo '<script>alert("로그인 성공");</script>';
    header('location: ./index.php');
    exit();
}

?>