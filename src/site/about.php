
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
							<li class="nav-item active">
								<a class="nav-link" href="about.php">소개</a>
							</li>
							<li class="nav-item">
								<a class="nav-link" href="genre.php">장르</a>
							</li>
							<li class="nav-item">
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
			<a href="index.php">메인</a> » <span class="breadcrumb_last" aria-current="page">소개</span>
			</div>
		</nav>
	</div>
 <!--//breadcrumbs -->
	<!-- /about-->
	<div class="w3l-ab-grids py-5">
		<div class="container py-lg-4">
			<div class="row ab-grids-sec align-items-center">
				<div class="col-lg-6 ab-right">
					<img class="img-fluid" src="http://home.postech.ac.kr/wp-content/uploads/2019/10/164-19-1.jpg">
				</div>
				<div class="col-lg-6 ab-left pl-lg-4 mt-lg-0 mt-5">
					<h3 class="hny-title">최상의 서비스를 위하여 최선을 다합니다</h3>
					<p class="mt-3">저희 영화관은 고객님에게 최상의 서비스를 제공하기 위해 영화 관람 환경 뿐만 아니라 다양한 분야에서 지속적인 진화를 이루려 노력하고 있습니다</p>
					<div class="ready-more mt-4">
						<a href="contact.html" class="btn read-button">문의<span class="fa fa-angle-double-right ml-2" aria-hidden="true"></span></a>
					</div>
				</div>
			</div>
		   
			<div class="w3l-counter-stats-info text-center">
				<div class="stats_left">
					<div class="counter_grid">
						<div class="icon_info">
							<p class="counter">12</p>
							<h4>개의 영화</h4>

						</div>
					</div>
				</div>
				<div class="stats_left">
					<div class="counter_grid">
						<div class="icon_info">
							<p class="counter">5</p>
							<h4>개의 영화관</h4>

						</div>
					</div>
				</div>
				<div class="stats_left">
					<div class="counter_grid">
						<div class="icon_info">
							<p class="counter">589</p>
							<h4>명의 회원 수</h4>

						</div>
					</div>
				</div>
				<div class="stats_left">
					<div class="counter_grid">
						<div class="icon_info">
							<p class="counter">50</p>
							<h4>년의 역사</h4>

						</div>
					</div>
				</div>
			</div>

		</div>
	</div>
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
<!-- stats -->
<script src="assets/js/jquery.waypoints.min.js"></script>
<script src="assets/js/jquery.countup.js"></script>
<script>
	$('.counter').countUp();
</script>
<!-- //stats -->
<!--/theme-change-->
<script src="assets/js/theme-change.js"></script>
<!-- //theme-change-->
<script src="assets/js/owl.carousel.js"></script>
<!-- script for banner slider-->
<script>
	$(document).ready(function () {
		$('.owl-team').owlCarousel({
			loop: true,
			margin: 20,
			nav: false,
			responsiveClass: true,
			autoplay: false,
			autoplayTimeout: 5000,
			autoplaySpeed: 1000,
			autoplayHoverPause: false,
			responsive: {
				0: {
					items:2,
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
					items:4,
					nav: true
				}
			}
		})
	})
</script>
<script>
	$(document).ready(function () {
		$('.owl-three').owlCarousel({
			loop: true,
			margin: 20,
			nav: false,
			responsiveClass: true,
			autoplay:true,
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
					items: 6,
					nav: true
				}
			}
		})
	})
</script>
<!-- //script -->
<!-- for tesimonials carousel slider -->
<script>
	$(document).ready(function () {
		$(".owl-clients").owlCarousel({
			loop: true,
			margin:40,
			responsiveClass: true,
			responsive: {
				0: {
					items:1,
					nav: true
				},
				736: {
					items: 2,
					nav: false
				},
				1000: {
					items:3,
					nav: true,
					loop: false
				}
			}
		})
	})
</script>
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