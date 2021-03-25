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

  <title>Mukflix | Hírek</title>
</head>
<body>

<div class="fejlec" id="myHeader">
  <img src="webkepek/textsmall.png" alt="Fejléc" class="kepfejlec" onclick="openlink()">
  <div class="menu">
        <a href="fooldal.php">Kezdőlap</a>
        <a href="foglalas.php">Foglalás</a>
        <a href="jegyarak.php">Jegyárak</a>
        <a href="hirek.php" class="active">Hírek</a>
        <a href="galeria.php">Galéria</a>
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
  <div class="fo" style="height: 2500px;'">
  <center><img src="webkepek\textsmallv3.png"></center>
    <div class="hirek-table">
    <?php
                    require('kapcs.php');
                    dbkapcs();

                    echo"<form action='' method='POST'>";

                    $query="SELECT * FROM news ORDER BY date DESC";
                    $eredm=mysqli_query($kapcs,$query);
                    while($sor=mysqli_fetch_array($eredm))
                    {
                        echo"<table class='hirek'>";
                        echo"<tr>";
                        echo"<th><img src='webkepek/user.png'></th>";
                        echo"<th>".$sor["username"]."</th>";
                        echo"<th>".$sor["date"]."</th>";
                        echo"</tr>";
                        echo"<tr>";
                        echo"<td colspan='3'>".$sor["post"]."</td>";
                        echo"</tr>";
                        echo"</table>";
                        echo"<br>";
                    }
                    echo"</form>";
                ?>
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
