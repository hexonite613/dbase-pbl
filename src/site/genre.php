
<!--
Author: W3layouts
Author URL: http://w3layouts.com
-->
<!doctype html>
<html lang="zxx">

<head>
	<!-- Required meta tags -->
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Dbase 영화관</title>
	<!-- Template CSS -->
	<link rel="stylesheet" href="assets/css/style-starter.css">
	<!-- Template CSS -->
	<link href="//fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,600;0,700;1,600&display=swap"
		rel="stylesheet">
	<!-- Template CSS -->
</head>

<body>
	<!-- header -->
	<header id="site-header" class="w3l-header fixed-top">
		<!--/nav-->
		<nav class="navbar navbar-expand-lg navbar-light fill px-lg-0 py-0 px-3">
			<div class="container">
				<h1><a class="navbar-brand" href="index.php"><span class="fa fa-play icon-log"
							aria-hidden="true"></span>
						Dbase</a></h1>
				<!-- if logo is image enable this   
							<a class="navbar-brand" href="#index.html">
								<img src="image-path" alt="Your logo" title="Your logo" style="height:35px;" />
							</a> -->
				<button class="navbar-toggler collapsed" type="button" data-toggle="collapse"
					data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
					aria-label="Toggle navigation">
					<!-- <span class="navbar-toggler-icon"></span> -->
					<span class="fa icon-expand fa-bars"></span>
					<span class="fa icon-close fa-times"></span>
				</button>

				<div class="collapse navbar-collapse" id="navbarSupportedContent">
					<ul class="navbar-nav ml-auto">
						<li class="nav-item">
							<a class="nav-link" href="index.php">메인</a>
						</li>
						<li class="nav-item">
						<a class="nav-link" href="about.php">소개</a>
						</li>
						<li class="nav-item active">
							<a class="nav-link" href="genre.php">장르</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="contact.php">오시는 길</a>
						</li>
						<?php
                			$connect = mysqli_connect("","","","") or die ("connect fail");
                			$userquery ="select * from board order by number desc";
               				$result = $connect->query($userquery);
                			$total = mysqli_num_rows($result);
 
                			session_start();

							if(isset($_SESSION['userid'])){
								?>
								<li class="nav-items">
									<a class="nav-link" href="reservecheck.php">어서오세요, <?php echo $_SESSION['userid'];?>님</a>
								</li>
								<li class="nav-items">
									<a class="nav-link" href="php/logout.php">로그아웃</a>
								</li>
								<?php
							}

							else{
								?>
								<li class="nav-items">
									<a class="nav-link" href="login.html">로그인</a>
								</li>
								<?php
							}
							?>
					</ul>

					<!--/search-right-->
					<!--/search-right-->
					<div class="search-right">
						<a href="#search" class="btn search-hny mr-lg-3 mt-lg-0 mt-4" title="search" >검색 <span
								class="fa fa-search ml-3" aria-hidden="true"></span></a>
						<!-- search popup -->
						<div id="search" class="pop-overlay">
							<div class="popup">
								<form action="./search.php" method="get" class="search-box" target="popup_window">
									<input type="search" name="title" placeholder="영화명을 검색하세요"
										required="required" autofocus="">
										<button type="submit" class="btn"><span class="fa fa-search"
											aria-hidden="true"></span></button>
								</form>
							</div>
							<a class="close" href="#close">×</a>
						</div>
						<!-- /search popup -->
						<!--/search-right-->
					</div>
				</div>
				<!-- toggle switch for light and dark theme -->
				<div class="mobile-position">
					<nav class="navigation">
						<div class="theme-switch-wrapper">
							<label class="theme-switch" for="checkbox">
								<input type="checkbox" id="checkbox">
								<div class="mode-container">
									<i class="gg-sun"></i>
									<i class="gg-moon"></i>
								</div>
							</label>
						</div>
					</nav>
				</div>
				<!-- //toggle switch for light and dark theme -->
			</div>
		</nav>
		<!--//nav-->
	</header>
	<!-- //header -->
	<!--/breadcrumbs -->
	<div class="w3l-breadcrumbs">
		<nav id="breadcrumbs" class="breadcrumbs">
			<div class="container page-wrapper">
				<a href="index.html">메인</a> » <span class="breadcrumb_last" aria-current="page">장르</span>
			</div>
		</nav>
	</div>
	<!--//breadcrumbs -->
	<!--/genre -->
	<!--grids-sec1-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">액션</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=1";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>
	
	<!-- 장르 id 2번 -->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">애니메이션</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					$movierequest2="SELECT * from movie where genre_id=2";
					$movieresult=mysqli_query($connect,$movierequest2);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!-- 장르 3번 -->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">드라마</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=3";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 4번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">스릴러</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=4";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 5번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">멜로/로맨스</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=5";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 6번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">코미디</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=6";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 7번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">범죄</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=7";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 8번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">공포</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=8";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 9번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">미스터리</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=9";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<!--장르 10번-->
	<section class="w3l-grids">
		<div class="grids-main py-5">
			<div class="container py-lg-3">
				<div class="headerhny-title">
					<div class="w3l-title-grids">
						<div class="headerhny-left">
							<h3 class="hny-title">사극</h3>
						</div>
					</div>
				</div>
				<!-- 사진 및 정보는 다음 영화에서 가져옴-->
				<div class="owl-three owl-carousel owl-theme">
				<?php
					session_start();
					$connect = mysqli_connect("","","","") or die ("connect fail");
					$movierequest1="SELECT * from movie where genre_id=10";
					$movieresult=mysqli_query($connect,$movierequest1);
					while($board=mysqli_fetch_array($movieresult)){
				?>
					<div class="item vhny-grid">
						<div class="box16 mb-0">
							<a>
								<figure>
									<?php
									echo "<img class=img-fluid src=".$board['poster'].">";
									?>
								</figure>
								<div class="box-content">
									<h4> <span class="post"><span class="fa fa-clock-o"> </span>
										<?php
											echo $board['movie_time']."분";
										?>
										</span>
									</h4>
								</div>
								<span class="fa fa-play video-icon" aria-hidden="true"></span>
							</a>
						</div>
						<h3> <a class="title-gd"><?php echo $board['name'] ?></a></h3>
						<p><?php echo $board['desdbase3c']?></p>
						<div class="button-center text-center mt-4">
							<?php 
							if(isset($_SESSION['userid'])){
								?>
								<a href="../booking_test/movie_day.php?movie_id=<?=$board['movie_id']?>" class="btn watch-button" target="popup_window">예매하기</a>
								<?php
							}
							else{
								?>
								<a href="./login.html" class="btn watch-button">예매하기</a>
								<?php
							}
							?>
						</div>
					</div>
					<?php
				}
				?>
			</div>
		</div>
	</section>

	<footer class="w3l-footer">
			<!-- move top -->
			<button onclick="topFunction()" id="movetop" title="Go to top">
				<span class="fa fa-arrow-up" aria-hidden="true"></span>
			</button>
			<script>
				// When the user scrolls down 20px from the top of the document, show the button
				window.onscroll = function () {
					scrollFunction()
				};

				function scrollFunction() {
					if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
						document.getElementById("movetop").style.display = "block";
					} else {
						document.getElementById("movetop").style.display = "none";
					}
				}

				// When the user clicks on the button, scroll to the top of the document
				function topFunction() {
					document.body.scrollTop = 0;
					document.documentElement.scrollTop = 0;
				}
			</script>
			<!-- /move top -->

		</section>
	</footer>
	<!--//footer-66 -->
</body>

</html>
<script src="assets/js/jquery-3.3.1.min.js"></script>
<!--/theme-change-->
<script src="assets/js/theme-change.js"></script>
<!-- //theme-change-->
<script src="assets/js/owl.carousel.js"></script>
<script>
	$(document).ready(function () {
		$('.owl-three').owlCarousel({
			loop: true,
			margin: 20,
			nav: false,
			responsiveClass: true,
			autoplay: true,
			autoplayTimeout: 5000,
			autoplaySpeed: 1000,
			autoplayHoverPause: false,
			responsive: {
				0: {
					items: 2,
					nav: false
				},
				480: {
					items: 2,
					nav: true
				},
				667: {
					items: 3,
					nav: true
				},
				1000: {
					items: 5,
					nav: true
				}
			}
		})
	})
</script>
<script>
	$(document).ready(function () {
		$('.owl-two').owlCarousel({
			loop: true,
			margin: 40,
			nav: false,
			responsiveClass: true,
			autoplay: true,
			autoplayTimeout: 5000,
			autoplaySpeed: 1000,
			autoplayHoverPause: false,
			responsive: {
				0: {
					items: 1,
					nav: false
				},
				480: {
					items: 2,
					nav: true
				},
				667: {
					items: 2,
					margin: 20,
					nav: true
				},
				1000: {
					items: 3,
					nav: true
				}
			}
		})
	})
</script>
<!-- //script -->
<!-- //script -->
<!-- script for owlcarousel -->
<!-- disable body scroll which navbar is in active -->
<script>
	$(function () {
		$('.navbar-toggler').click(function () {
			$('body').toggleClass('noscroll');
		})
	});
</script>
<!-- disable body scroll which navbar is in active -->

<!--/MENU-JS-->
<script>
	$(window).on("scroll", function () {
		var scroll = $(window).scrollTop();

		if (scroll >= 80) {
			$("#site-header").addClass("nav-fixed");
		} else {
			$("#site-header").removeClass("nav-fixed");
		}
	});

	//Main navigation Active Class Add Remove
	$(".navbar-toggler").on("click", function () {
		$("header").toggleClass("active");
	});
	$(document).on("ready", function () {
		if ($(window).width() > 991) {
			$("header").removeClass("active");
		}
		$(window).on("resize", function () {
			if ($(window).width() > 991) {
				$("header").removeClass("active");
			}
		});
	});
</script>
<!--//MENU-JS-->
<script src="assets/js/bootstrap.min.js"></script>