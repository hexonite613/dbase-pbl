<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <link rel="stylesheet" href="./assets/css/reservestyle.css" />
    <title>Movie Seat Booking</title>
  </head>
  <body>
    <?php

    ?>
    <div class="movie-container">
      <select id="movie">
        <option value="10">Avengers: Endgame ($10)</option>
        <option value="12">Joker ($12)</option>
        <option value="8">Toy Story 4 ($8)</option>
        <option value="9">The Lion King ($9)</option>
      </select>
    </div>

    <ul class="showcase">
      <li>
        <div class="seat"></div>
        <small>N/A</small>
      </li>
      <li>
        <div class="seat selected"></div>
        <small>Selected</small>
      </li>
      <li>
        <div class="seat occupied"></div>
        <small>Occupied</small>
      </li>
    </ul>


    <div class="container">
      <div class="screen"></div>
      <form method="get" action="./php/reservation.php">
      <?php
      $conn = mysqli_connect("", "", "dbase3333" , "erdtest");
      $sql = "SELECT id,cus_phonenum FROM book_seat";

      session_start();
      // 페이지에서 영화(아이디), 시간을 받아온다
      $movie_id=movie;
      $time=time;
      // 상영관 번호 랜덤으로
      $cinema_num=rand(1,12);
      $cinema_num2=$cinema_num; /**중복됨 */
      // 영화관 코드
      $theater_id=theater_id;
      $theater_id2=$theater_id; /**중복됨 */

      
      for($i = 1; $i<= 25; $i++) { 
          echo "<label><input name=seat type=checkbox name=seat[] onclick=ischecked() value='A{$i}' class='seat'> </label>";
          if($i%10==3 || $i%10==7 ) echo "&nbsp&nbsp&nbsp";
          if($i%10==0) echo "<br>";
          if($i%60==0) echo "<br>";
      }
      ?>
      

    </div>


    <button type="submit" value="submit">결제하기</button>

    <script src="./assets/js/reservescript.js"></script>
  </body>
</html>