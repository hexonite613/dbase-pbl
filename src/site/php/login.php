<?php
session_start();
$mysqli=mysqli_connect("","","","");  //첫번째는 ip, 마지막은 데베

error_reporting(E_ALL);

ini_set("display_errors", 1);

$id=$_GET['id'];
$pw=hash('sha256',$_GET['pw']);


if($mysqli===false){
    die("Error:connection fail".mysqli_connect_error());
}
 
$userquery="Select * from user where id='$id'";
$result= $mysqli->query($userquery);

if (mysqli_num_rows($result)==1){
    $row=mysqli_fetch_assoc($result);

    if($row['password']==$pw){
        $_SESSION['userid']=$id;
        if(isset($_SESSION['userid'])){
            ?>  <script>
                    alert("로그인 성공");
                    location.replace("../index.php");
                </script>
<?php
        }
        else{
            echo "Session fail";
        }
    }
    else{
        ?>  <script>
                alert("비밀번호가 잘못되었습니다");
                history.back();
            </script>
    <?php
        }
    }
        else{
?>      <script>
            alert("아이디가 잘못되었습니다");
            history.back()
        </script>
<?php
}
?>