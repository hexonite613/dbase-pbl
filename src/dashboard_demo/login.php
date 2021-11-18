<!-- 로그인 페이지 -->

<?php
    session_start();

    if(isset($_SESSION['userid']))
    {
        echo '<script>alert("이미 로그인되어 있습니다");history.back();</script>';
    exit();
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
        <title>DBASE CINEMA 로그인</title>
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">DBASE CINEMA 로그인</h3></div>
                                    <div class="card-body">
                                        <form action='./login_check.php' method='post'>
                                            <div class="form-floating mb-3">
                                                <input class="form-control" id="id" type="text" placeholder="아이디를 입력하세요" name="id" required/>
                                                <label for="id">아이디(ID)</label>
                                            </div>
                                            <div class="form-floating mb-3">
                                                <input class="form-control" id="pw" type="password" placeholder="비밀번호를 입력하세요" name="pw" required/>
                                                <label for="pw">비밀번호</label>
                                            </div>
                                            <div class="d-flex flex-row-reverse">
                                                <input type='submit' class="btn btn-primary btn-block" value='로그인'>
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="register.html">계정이 없으신가요? 여기를 눌러 등록하세요</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
