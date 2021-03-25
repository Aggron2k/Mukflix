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

  <title>Mukflix | Főoldal</title>
</head>
<body>

<div class="fejlec" id="myHeader">
  <img src="webkepek/textsmall.png" alt="Fejléc" class="kepfejlec" onclick="openlink()">
  <div class="menu">
        <a href="fooldal.php" class="active">Kezdőlap</a>
        <a href="foglalas.php">Foglalás</a>
        <a href="jegyarak.php">Jegyárak</a>
        <a href="hirek.php">Hírek</a>
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
  <div class="fo">
  <center><img src="webkepek\textsmallv3.png"></center>
    <h1>Rólunk</h1>
    <p>A Mukflix inc. első mozija az Alföldön, Csongrád megye megyeszékhelyén.</p>
    <br>
    <p>A kezdeti teljeskörű felújításra és digitalizálásra óriási szükség volt, hogy a városnak újra legyen saját mozija,
    és a népes filmrajongó tábor ne maradjon filmek nélkül. A modern belső térnek köszönhetően a mozizás új fogalmat nyer.</p>
    <br>
    <p>A helyi igényekre való érzékenységnek köszönhetően a mozi mára újra hatalmas törzsközönséggel rendelkezik.</p>
      <br>
      <br>
    <img src="webkepek\szekek.jpg" alt="" style="width:100%">
      <br>
      <br>
    <h3>Áprilisi vetítések dátumai:</h3>
      <table class="roundedborder">
        <tr>
          <td><p>ÁPRILIS</p><h1>05</h1><b>hétfő</b></td>
          <td><p>ÁPRILIS</p><h1>06</h1><b>kedd</b></td>
          <td><p>ÁPRILIS</p><h1>07</h1><b>szerda</b></td>
          <td><p>ÁPRILIS</p><h1>08</h1><b>csütrötök</b></td>
          <td><p>ÁPRILIS</p><h1>09</h1><b>péntek</b></td>
        </tr>
        <tr>
          <td><p>ÁPRILIS</p><h1>12</h1><b>hétfő</b></td>
          <td><p>ÁPRILIS</p><h1>13</h1><b>kedd</b></td>
          <td><p>ÁPRILIS</p><h1>14</h1><b>szerda</b></td>
          <td><p>ÁPRILIS</p><h1>15</h1><b>csütrötök</b></td>
          <td><p>ÁPRILIS</p><h1>16</h1><b>péntek</b></td>
        </tr>
        <tr>
          <td><p>ÁPRILIS</p><h1>19</h1><b>hétfő</b></td>
          <td><p>ÁPRILIS</p><h1>20</h1><b>kedd</b></td>
          <td><p>ÁPRILIS</p><h1>21</h1><b>szerda</b></td>
          <td><p>ÁPRILIS</p><h1>22</h1><b>csütrötök</b></td>
          <td><p>ÁPRILIS</p><h1>23</h1><b>péntek</b></td>
        </tr>
      </table>
</div>

  <div class="jobb">
      <div>
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
