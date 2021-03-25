<!DOCTYPE html>
<?php
	require 'conn.php';
	session_start();
	
	if(!ISSET($_SESSION['user'])){
		header('location:belepes.php');
	}
?>
<html lang="hu">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="icon" href ="webkepek/logo_xvq_icon.ico" type = "image/x-icon"> 
  <link rel="stylesheet" href="bootstrapcss.css" type="text/css">
  <link rel="stylesheet" type="text/css" href="lightbox.min.css">
  <script src="lightbox-plus-jquery.min.js"></script>

  <title>Mukflix | Galéria</title>
</head>
<body>
<div class="fejlec" id="myHeader">
  <img src="webkepek/textsmall.png" alt="Fejléc" class="kepfejlec" onclick="openlink()">
  <div class="menu">
        <a href="fooldal.php">Kezdőlap</a>
        <a href="foglalas.php">Foglalás</a>
        <a href="jegyarak.php">Jegyárak</a>
        <a href="hirek.php">Hírek</a>
        <a href="galeria.php" class="active">Galéria</a>
        <a href="nyeremenyjatek.php">Nyereményjáték</a>
        <a href="profil.php">
        <?php
          $id = $_SESSION['user'];
          $sql = $conn->prepare("SELECT * FROM `users` WHERE `id`='$id'");
          $sql->execute();
          $fetch = $sql->fetch();
			  ?>
        <?php echo $fetch['username']?>
        </a>
        <a href="kijelentkezes.php">Kijelentkezés</a>
  </div>
</div>

<div class="tartalom">
  <div class="fo">
  <center><img src="webkepek\textsmallv3.png"></center>
    <div class="gallery"> 
      <a href="webkepek\posters\the_platform_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\the_platform_poster.jpg"></a>
      <a href="webkepek\posters\bad_boys_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\bad_boys_poster.jpg"></a>
      <a href="webkepek\posters\tyler_Rake_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\tyler_Rake_poster.jpg"></a>
      <a href="webkepek\posters\baywatch_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\baywatch_poster.jpg"></a>
      <a href="webkepek\posters\valos_halal_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\valos_halal_poster.jpg"></a>
      <a href="webkepek\posters\idegpalya_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\idegpalya_poster.jpg"></a>
      <a href="webkepek\posters\haverok_harca_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\haverok_harca_poster.jpg"></a>
      <a href="webkepek\posters\coco_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\coco_poster.jpg"></a>
      <a href="webkepek\posters\john_wick_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\john_wick_poster.jpg"></a>
      <a href="webkepek\posters\sonic_a_sundiszno_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\sonic_a_sundiszno_poster.jpg"></a>
      <a href="webkepek\posters\nyomd_bebi_nyomd_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\nyomd_bebi_nyomd_poster.jpg"></a>
      <a href="webkepek\posters\matrix_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\matrix_poster.jpg"></a>
      <a href="webkepek\posters\venom_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\venom_poster.jpg"></a>
      <a href="webkepek\posters\john_wick2_poster_big.jpg" data-lightbox="mygallery"><img src="webkepek\posters\john_wick2_poster.jpg"></a>
    </div> 
    </div>

  <div class="jobb">
      <img src="webkepek\posters\the_platform_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\bad_boys_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\tyler_Rake_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\baywatch_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\valos_halal_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\idegpalya_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\haverok_harca_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\coco_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\john_wick_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\sonic_a_sundiszno_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\nyomd_bebi_nyomd_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\matrix_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\venom_poster.jpg" class="mySlides" style="width:100%">
      <img src="webkepek\posters\john_wick2_poster.jpg" class="mySlides" style="width:100%">
  </div>

  <div class="jobb">
    <h2>Áprilisi poster:</h2>
    <a href="webkepek\filmlist\poster_aprilis.png" data-lightbox="mygallery"><img src="webkepek\filmlist\poster_aprilis.png" alt="" style="width:100%"></a>
  </div>
  

  <div class="jobb">
    <h2>Mai dátum:</h2>
    <p id="datum"></p>
  </div>
</div>

<div class="lablec">
  <table class="lablec-table">
    <tr>
      <td><h3>Információk</h3></td>
      <td><h3>Elérhetőségek</h3></td>
      <td><h3>Impresszum</h3></td>
    </tr>
    <tr>
      <td><a href="fizetes_tajekoztato.php">Fizetési tájékoztató</a><br><a href="adatvedelmi.php">Adatvédelmi és jogi nyilatkozat</a></td>
      <td>Mukflix Mozi Szeged<br>6723 Szeged, Szilléri sgrt. 43<br>Telefon: +36-62-255-308<br>E-mail: mukflix2021@gmail.com<br>Pénztár nyitvatartása: kezdés előtt fél órával.</td>
      <td>Mukflix Inc. (Szeged)<br>6723 Szeged<br>Szilléri sgrt. 43<br>Adószám:23697248236</td>
    </tr>
  </table>
  <br>
  <h4>&copy Copyright | Mukflix</h4>
</div>
<script src="script.js">
</script>
</body>
</html>
