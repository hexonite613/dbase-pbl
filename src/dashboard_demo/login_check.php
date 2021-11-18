<?php
session_start();
$id=$_POST['id'];
$pw=hash('sha256', $_POST['pw']);

if ($id==NULL || $pw==NULL) {
    echo '<script>alert("아이디 또는 비밀번호를 입력하세요");history.back();</script>';
    exit();
}

$mysqli = mysqli_connect("","","","");

$check="SELECT * FROM user WHERE userid='$id'";
$result=$mysqli->query($check);

if($result->num_rows==1) {
    $row=$result->fetch_array(MYSQLI_ASSOC);
    if ($row['pw']==$pw) {
        $_SESSION['userid']=$id;
        $_SESSION['username']=$row['name'];

        if(isset($_SESSION['userid'])) {
            header('Location: ./index.php');
            exit();
        } else {
            echo '<script>alert("세션 저장 실패");history.back();</script>';
            exit();
        }
    } else {
        echo '<script>alert("아이디 또는 비밀번호가 올바르지 않습니다");history.back();</script>';
        exit();
    }
} else {
    echo '<script>alert("아이디 또는 비밀번호가 올바르지 않습니다");history.back();</script>';
    exit();
}

?>