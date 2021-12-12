<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php
    $connect=mysqli_connect("", "", "", "") or die("connection fail");

    $book_num = $_POST["book_num"];
    $screen_id=$_POST["screen_id"];
    $theater_id=$POST["theater_id"];
    $seat_id=$_POST["seat_id"];

    $query="delete from booking where book_num =$book_num";
    $result = mysqli_query($connect, $query);

    if ($result) {
        ?>
        <script>
            alert("예매 취소가 완료 되었습니다");
            location.replace("./reservecheck.php");
        </script>
        <?php
    } 
    else {
        ?>
        <script>
            alert("예매 취소에 오류가 생겼습니다");
            location.replace("../index.php");
        </script>
        <?php
    }
        mysqli_close($connect);
?>

</body>
</html>