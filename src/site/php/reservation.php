<?php
$mysqli=mysqli_connect("","","","");

$book_num=$rand_number = rand(111111,999999);
$seat_num=$_GET['seat'];
$movie_time=$_GET['time'];
$movie_id=$_GET['movie_id'];
$cinema_num2=$_GET['cinema_num2'];
$theater_id2=$_GET=['theater_id2'];
$cinema_num=$_GET['cinema_num'];
$theater_id=$_GET=['theater_id'];

error_reporting(E_ALL);

ini_set("display_errors", 1);


$query="insert into book_seat(book_num,seat_num,movie_time,movie_id,cinema_num2,theater_id2,cinema_num,theater_id) values 
('$book_num','$seat_num','$movie_time','$movie_id','$cinema_num2','$theater_id2','$cinema_num','$theater_id')";

$moviequery=mysqli_query($mysqli,"select movie_id,name from movie where movie_id='$movie_id'");
$row=mysqli_fetch_assoc($moviequery);
$movie_name=$row['name'];

$result=$mysqli->query($query);

if($result) {
?>      <script>
        alert("예약이 완료되었습니다"+"\n"+"\n"+"영화제목 : "+"<?=$movie_name?>"+"\n"+"예매 시간 : "+"<?=$movie_time?>"+"\n"+"좌석 : "+"<?=$seat_num?>");
        location.replace("../index.php");
        </script>

<?php   }
    else{
?>     <script>
        alert("fail");
        alert("관리자에게 문의하세요")
        </script>
<?php   }

    mysqli_close($mysqli);
?>