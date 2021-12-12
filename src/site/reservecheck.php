
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
								<li class="nav-items active">
									<a class="nav-link" href="">어서오세요, <?php echo $_SESSION['userid'];?>님</a>
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
						<a href="#search" class="btn search-hny mr-lg-3 mt-lg-0 mt-4" title="search">검색 <span
								class="fa fa-search ml-3" aria-hidden="true"></span></a>
						<!-- search popup -->
						<div id="search" class="pop-overlay">
							<div class="popup">
								<form action="./search.php" method="get" class="search-box">
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
	<div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h2 class="mt-4">영화 관리</h2>
                        
                        <div class="card mb-4">
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>예매 번호</th>
										<th>영화명</td>
                                        <th>좌석 번호</th>
                                        <th>영화 상영 시간</th>
										<th>입장료</th>
										<th>결제 방식</th>
                                        <th>결제 금액</th>
										<th>예매 취소</th>
                                    </tr>
                                </thead>
                                <?php
									$conn= mysqli_connect('localhost', 'dbase', 'dbase3333', 'dbase');
									$user_id=$_SESSION['userid'];
									$query="SELECT * FROM booking left join schedule on booking.sche_id=schedule.sche_id left join movie on schedule.movie_id=movie.movie_id left join screen_seat on booking.seat_id=screen_seat.seat_id where id like '$user_id'";
									$result=mysqli_query($conn,$query);
                                    while($board = mysqli_fetch_array($result)){
										echo "<tr><td>".$board['book_id']."</td>";
										echo "<td>".$board['name']."</td>";
										echo "<td>".$board['seat_row'].$board['seat_col']."</td>";
										echo "<td>".$board['time']."</td>";
										if($board['book_type']=='normal'){
											echo "<td>성인</td>";
										}
										elseif($board['book_type']=='youth'){
											echo "<td>청소년</td>";
										}
										elseif($board['book_type']=='disable'){
											echo "<td>장애인</td>";
										}
										elseif($board['book_type']=='elder'){
											echo "<td>경로 우대</td>";
										}
										echo "<td>".$board['pay_method']."</td>";
										echo "<td>".$board['pay_price']."원</td>";
										echo "<form method='post' action='delete.php'>";
                                        echo "<input type='hidden' name='book_num' value=".$board['book_num']." />";
                                        echo "<td><button type='submit' class='btn btn-danger'>예매 취소</button></td>";
                                        echo "</form>";echo "</td></tr>\n";
                                    }
									
                                ?>

                            </table>
                        </div>
                    </div>
                </main>
            </div>
	<!-- //tabs-->
	<!-- footer-66 -->
	<footer class="w3l-footer">
			<!-- copyright -->
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
<!-- responsive tabs -->
<script src="assets/js/jquery-1.9.1.min.js"></script>
  <script src="assets/js/easyResponsiveTabs.js"></script>
  <script type="text/javascript">
    $(document).ready(function () {
      //Horizontal Tab
      $('#parentHorizontalTab').easyResponsiveTabs({
        type: 'default', //Types: default, vertical, accordion
        width: 'auto', //auto or any width like 600px
        fit: true, // 100% fit in a container
        tabidentify: 'hor_1', // The tab groups identifier
        activate: function (event) { // Callback function if tab is switched
          var $tab = $(this);
          var $info = $('#nested-tabInfo');
          var $name = $('span', $info);
          $name.text($tab.text());
          $info.show();
        }
      });
    });
  </script>  
<!-- //responsive tabs -->
<!--/theme-change-->
<script src="assets/js/theme-change.js"></script>
<!-- //theme-change-->
<script src="assets/js/owl.carousel.js"></script>
<!-- script for banner slider-->
<script>
	$(document).ready(function () {
		$('.owl-one').owlCarousel({
			stagePadding:280,
			loop: true,
			margin: 20,
			nav: true,
			responsiveClass: true,
			autoplay: true,
			autoplayTimeout: 5000,
			autoplaySpeed: 1000,
			autoplayHoverPause: false,
			responsive: {
				0: {
					items: 1,
					stagePadding:40,
					nav: false
				},
				480: {
					items: 1,
					stagePadding:60,
					nav: true
				},
				667: {
					items: 1,
					stagePadding:80,
					nav: true
				},
				1000: {
					items: 1,
					nav: true
				}
			}
		})
	})
</script>
<!-- //script -->
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
<!-- //script -->
<!-- /mid-script -->
<script>
	$(document).ready(function () {
		$('.owl-mid').owlCarousel({
			loop: true,
			margin: 0,
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
					items: 1,
					nav: false
				},
				667: {
					items: 1,
					nav: true
				},
				1000: {
					items: 1,
					nav: true
				}
			}
		})
	})
</script>
<!-- //mid-script -->

<!-- script for owlcarousel -->
<!-- Template JavaScript -->
<script src="assets/js/jquery.magnific-popup.min.js"></script>
<script>
	$(document).ready(function () {
		$('.popup-with-zoom-anim').magnificPopup({
			type: 'inline',

			fixedContentPos: false,
			fixedBgPos: true,

			overflowY: 'auto',

			closeBtnInside: true,
			preloader: false,

			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-zoom-in'
		});

		$('.popup-with-move-anim').magnificPopup({
			type: 'inline',

			fixedContentPos: false,
			fixedBgPos: true,

			overflowY: 'auto',

			closeBtnInside: true,
			preloader: false,

			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-slide-bottom'
		});
	});
</script>
<!--//-->
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