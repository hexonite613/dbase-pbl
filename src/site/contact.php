

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
		<header id="site-header" class="w3l-header fixed-top" >
			<!--/nav-->
			<nav class="navbar navbar-expand-lg navbar-light fill px-lg-0 py-0 px-3">
				<div class="container">
					<h1><a class="navbar-brand" href="index.php"><span class="fa fa-play icon-log" aria-hidden="true"></span>
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
							<li class="nav-item">
								<a class="nav-link" href="genre.php">장르</a>
							</li>
							<li class="nav-item active">
								<a class="nav-link" href="contact.php">오시는 길</a>
							</li>
							<?php
                			$connect = mysqli_connect("","","dbase3333","") or die ("connect fail");
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
			<a href="index.html">메인</a> » <span class="breadcrumb_last" aria-current="page">오시는 길</span>
			</div>
		</nav>
	</div>
 <!--//breadcrumbs -->
	  <!-- contact1 -->
	  <section class="w3l-contact-1">
		<div class="contacts-9 py-5">
		  <div class="container py-lg-4">
			<div class="headerhny-title text-center">
				<h4 class="sub-title text-center">오시는 길 및 문의처</h4>
			  <div class="d-grid contact-addres-inf mt-5 pt-lg-4">
				<div class="contact-info-left d-grid">
					<div class="contact-info">
						<div class="icon">
							<span class="fa fa-location-arrow" aria-hidden="true"></span>
						</div>
						<div class="contact-details">
							<h4>본사:</h4>
							<p>경기도 안산시 사동 한양대학로</p>
						</div>
					</div>
					<div class="contact-info">
						<div class="icon">
							<span class="fa fa-phone" aria-hidden="true"></span>
						</div>
						<div class="contact-details">
							<h4>연락처:</h4>
							<p><a href="tel:+82010-1111-1111">+82 010-1111-1111</a></p>
							<p><a href="tel:+82010-0000-0000">+82 010-0000-0000</a></p>
						</div>
					</div>
					<div class="contact-info">
						<div class="icon">
							<span class="fa fa-envelope-open-o" aria-hidden="true"></span>
						</div>
						<div class="contact-details">
							<h4>메일:</h4>
							<p><a href="mailto:dbase@hanyang.ac.kr" class="email">dbase@hanyang.ac.kr</a></p>
						</div>
					</div>
				</div>
			</div>
			</div>
		  </div>
		</div>
		<div class="contact-map">
			<iframe src="https://www.google.com/maps/embed/v1/place?key=AIzaSyBrej4Uk_WDm1ot6odOMB9hhgQR5kV7uMw
			&q=한양대학교+ERICA캠퍼스" style="border:0" allowfullscreen=""></iframe>
		</div>
	  </section>
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
<!-- Template JavaScript -->
<!--/theme-change-->
<script src="assets/js/theme-change.js"></script>
<!-- //theme-change-->
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