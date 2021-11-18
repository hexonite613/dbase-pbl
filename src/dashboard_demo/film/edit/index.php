<?php
    session_start();

    if(!isset($_SESSION['userid']))
    {
        ?>
        <script>
            alert("로그인이 필요합니다");
            location.replace("../../login.php");
        </script>
        <?php
        exit();
    }

    $conn = mysqli_connect("","","","");
    $sql="SELECT * FROM movie WHERE movie_id=".$_GET['id'];
    $result=mysqli_query($conn,$sql);

    if ($result->num_rows==0) {
        echo '<script>alert("유효하지 않는 영화 ID입니다.");history.back();</script>';
        exit();
    }

    $film = mysqli_fetch_array($result);

?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>DBASE - 영화 관리 - 편집</title>
        <link href="../../css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
            <!-- Navbar Brand-->
            <a class="navbar-brand ps-3" href="index.html">영화 관리</a>
            <!-- Sidebar Toggle-->
            <button class="btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0" id="sidebarToggle" href="#!"><i class="fas fa-bars"></i></button>
            <!-- Navbar Search-->
            <form class="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
                <div class="input-group">
                    <input class="form-control" type="text" placeholder="Search for..." aria-label="Search for..." aria-describedby="btnNavbarSearch" />
                    <button class="btn btn-primary" id="btnNavbarSearch" type="button"><i class="fas fa-search"></i></button>
                </div>
            </form>
            <!-- Navbar-->
            <ul class="navbar-nav ms-auto ms-md-0 me-3 me-lg-4">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                    <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
                        <li><a class="dropdown-item" href="../logout.php">Logout</a></li>
                    </ul>
                </li>
            </ul>
        </nav>

        <div class="modal fade" id="confirmModal" tabindex="-1" aria-labelledby="confirmModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                <div class="modal-content">
                    <form action='./delete_film.php' method='post'>
                        <input type="hidden" id="movieId" name="movieId" value="<?php echo $film['movie_id'] ?>">
                        <div class="modal-header">
                            <h5 class="modal-title" id="confirmModalLabel">영화 삭제</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div class="container">
                                정말로 삭제하시겠습니까?
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">취소</button>
                            <input type='submit' class="btn btn-danger btn-block" value='네, 삭제합니다' />
                        </div>
                    </form>

                </div>
            </div>
        </div>

        <div id="layoutSidenav">
            <div id="layoutSidenav_nav">
                <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                    <div class="sb-sidenav-menu">
                        <div class="nav">
                            <!-- 사이드바 메뉴 -->
                            <div class="sb-sidenav-menu-heading">메인</div>
                            <a class="nav-link" href="../../">
                                <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                                대시보드
                            </a>
                            <div class="sb-sidenav-menu-heading">관리</div>
                            <a class="nav-link" href="../">
                                <div class="sb-nav-link-icon"><i class="fas fa-film"></i></div>
                                영화 정보
                            </a>
                        </div>
                    </div>
                    <div class="sb-sidenav-footer">
                        <?php echo $_SESSION['username'] ?>
                        <div class="small">회원님 환영합니다</div>
                    </div>
                </nav>
            </div>
            <div id="layoutSidenav_content">
                <main>
                    <form class="container-fluid px-4" action='./edit_film.php' method='post'>
                        <!-- 기존 영화 id -->
                        <input type="hidden" id="orgmovieId" name="orgmovieId" value="<?php echo $film['movie_id'] ?>">

                        <h2 class="mt-4">편집</h2>
                        <div class="header">
                            <h5 class="title">영화 편집</h5>
                        </div>
                        <div class="body">
                            <div class="row mb-3">
                                <div class="col-md-6">
                                    <div class="form-floating mb-3 mb-md-0">
                                        <input class="form-control" id="movieId" type="text" placeholder="영화 ID" name="movieId" value="<?php echo $film['movie_id'] ?>"/>
                                        <label for="movieId">영화 ID</label>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-floating">
                                        <input class="form-control" id="runtime" type="number" placeholder="상영시간 (분)" name="runtime" required value="<?php echo $film['movie_time'] ?>"/>
                                        <label for="runtime">상영 시간</label>
                                    </div>
                                </div>
                            </div>
                            <div class="form-floating mb-3">
                                <input class="form-control" name="koname" type="text" placeholder="영화명 (한글)" required value="<?php echo $film['name'] ?>"/>
                                <label for="koname">영화명 (한글)</label>
                            </div>
                            <div class="form-floating mb-3">
                                <input class="form-control" name="enname" type="text" placeholder="영화명 (영문)" value="<?php echo $film['enname'] ?>"/>
                                <label for="enname">영화명 (영문)</label>
                            </div>

                            <div class="row mb-3">
                                <div class="btn-group col-md-6" role="group" aria-label="Basic radio toggle button group" name="btnrdo">
                                    <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" onclick="document.getElementById('rate').value='ALL';"
                                    <?php if ($film['rating']=="ALL") {echo "checked";} ?>>
                                    <label class="btn btn-outline-primary" for="btnradio1">전체</label>

                                    <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off" onclick="document.getElementById('rate').value='12';"
                                    <?php if ($film['rating']=="12") {echo "checked";} ?>>
                                    <label class="btn btn-outline-primary" for="btnradio2">12+</label>

                                    <input type="radio" class="btn-check" name="btnradio" id="btnradio3" autocomplete="off" onclick="document.getElementById('rate').value='15';"
                                    <?php if ($film['rating']=="15") {echo "checked";} ?>>
                                    <label class="btn btn-outline-primary" for="btnradio3">15+</label>

                                    <input type="radio" class="btn-check" name="btnradio" id="btnradio4" autocomplete="off" onclick="document.getElementById('rate').value='18';"
                                    <?php if ($film['rating']=="18") {echo "checked";} ?>>
                                    <label class="btn btn-outline-primary" for="btnradio4">18+</label>

                                    <input type="radio" class="btn-check" name="btnradio" id="btnradio5" autocomplete="off" onclick="document.getElementById('rate').value='R18';"
                                    <?php if ($film['rating']=="R18") {echo "checked";} ?>>
                                    <label class="btn btn-outline-primary" for="btnradio5">R18</label>
                                </div>
                                <input type="hidden" id="rate" name="rate" value="<?php echo $film['rating'] ?>">
                                <div class="col-md-6">
                                    <input class="form-control" id="gerneid" type="number" placeholder="장르 ID" name="gerneid" required value="<?php echo $film['gerne_id'] ?>"/>
                                </div>
                            </div>
                            <div class="form-group mt-3">
                                <textarea class="form-control" rows="6" name="desctext" id="desctext" placeholder="시놉시스" required><?php echo $film['descr'] ?></textarea>
                            </div>
                        </div>
                        <div class="footer mt-3">
                            <div class="row">
                                <div class="col-6">
                                    <button type="button" class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#confirmModal">삭제</button>
                                </div>
                                <div class="col-6">
                                    <div class="d-flex flex-row-reverse">
                                        <input type='submit' class="btn btn-primary btn-block" value='변경사항 저장' />
                                        <button type="button" class="btn btn-secondary mx-2" onclick="location.href='../'">닫기</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </main>
            </div>
        </div>


        
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="../../js/scripts.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="assets/demo/chart-area-demo.js"></script>
        <script src="assets/demo/chart-bar-demo.js"></script>
        <script src="assets/demo/chart-pie-demo.js"></script>
    </body>
</html>
