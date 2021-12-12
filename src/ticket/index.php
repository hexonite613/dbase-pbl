<?php
$tid = $_GET['tid'];

if (is_numeric(str_replace("-", "", $tid)) == false) {
    echo "<script>alert('유효하지 않은 티켓입니다');history.back();</script>";
    exit;
}

$conn = mysqli_connect('', '', '', '');
$sql="SELECT * FROM (SELECT * FROM booking NATURAL JOIN schedule WHERE book_id = '".$tid."')a JOIN movie ON movie.movie_id = a.movie_id";
$result=mysqli_query($conn,$sql);

if (mysqli_num_rows($result) < 1) {
    echo "<script>alert('유효하지 않은 티켓입니다');history.back();</script>";
    exit;
}





?>


<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>DBASE CINEMA E-Ticket</title>
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">

                    <?php while($ticket = mysqli_fetch_array($result)) { ?>
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">MOVIE TICKET</h3></div>
                                    <div class="card-body text-center">


                                        <img class='my-3' src="https://api.qrserver.com/v1/create-qr-code/?size=300x300&data=<?=urlencode("http://dbase.kro.kr/ticket?tid=").$tid?>" width="300px" height="300px">


                                        <div class="row mb-5">
                                            <div class="fs-2">
                                                <?=$ticket['name']?>
                                            </div>
                                            <div class="fs-5">
                                                2021-12-08 21:29
                                            </div>

                                            <div class="col fs-2 text-end">
                                                <?php 
                                                
                                                $res = mysqli_query($conn,"SELECT * FROM theater WHERE theater_id = '".$ticket['theater_id']."'");
                                                $theater_name = mysqli_fetch_array($res)['theater_name'];

                                                $res = mysqli_query($conn,"SELECT * FROM screen WHERE screen_id = '".$ticket['screen_id']."'");
                                                $scr_name = mysqli_fetch_array($res)['screen_name'];

                                                $res = mysqli_query($conn,"SELECT * FROM screen_seat WHERE seat_id = '".$ticket['seat_id']."'");
                                                $seat = mysqli_fetch_array($res);

                                                $seat_row = $seat['seat_row'];
                                                $seat_col = $seat['seat_col'];
                                                
                                                ?>
                                                <?=$theater_name?><br>
                                                <span class="badge rounded-pill bg-warning text-dark"><?=$scr_name?> <?=$seat_row?><?=$seat_col?></span>
                                            </div>
                                            <div class="col fs-2 text-start">
                                                <?php 
                                                
                                                // $res = mysqli_query($conn,"SELECT * FROM movie");
                                                // $ticket = mysqli_fetch_array($result)
                                                
                                                ?>
                                                <span class="badge bg-info"><?php
                                                switch ($ticket['book_type']) {
                                                    case "normal":
                                                        echo "일반";
                                                        break;
                                                    case "youth":
                                                        echo "청소년";
                                                        break;
                                                    case "disable":
                                                        echo "장애인";
                                                        break;
                                                    case "elder":
                                                        echo "경로";
                                                        break;
                                                }
                                                ?></span><br>
                                                <span class="text-secondary"><?=$ticket['pay_price']?>원</span>  
                                            </div> 
                                        
                                        </div>
                                    </div>                                        
                                </div>
                            </div>
                        </div>

                        <?php } ?>
                    </div>
                </main>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
