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

  <title>Mukflix | Fizetési Tájékoztató</title>
</head>
<body>

    <div class="fejlec" id="myHeader">
        <img src="webkepek/textsmall.png" alt="Fejléc" class="kepfejlec" onclick="openlink()">
        <div class="menu">
              <a href="fooldal.php">Kezdőlap</a>
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
        <div class="roundedborderv3">
            <h3>MIVEL LEHET FIZETNI?</h3>
            <p>Fizetni online tudsz:</p>
            <ul>
                <li>Bankkártyával (visa, visa elecron, maestro, mastercard, american express bankkártyát tudunk elfogadni, tehát nem csak dombornyomott kártyát) vagy</li>
                <li>Barion tárcával. A Barion tárcát viszont fel lehet tölteni készpénzzel (bármely CIB bankfiókban) és átutalással is, így nálunk indirekt módon készpénzzel és utalással is fizethetsz. A bankkártya elfogadást is a Barion rendszere végzi.</li>
            </ul>
            <p>A bankkártyás fizetéshez nem kötelező a Barion regisztráció (Barion tárca nyitása), elég megadni bankkártyád számát, a lejárati dátumot és a hátoldalon található CVC kódot.</p> 
            <p>Ha azonban regisztrálsz a Barion rendszerbe, soha többé nem kell begépelned a kártyaadataid egyetlen Barion elfogadóhelyen sem, a fizetéshez elég az e-mail címed és jelszavad. Ez nem csak kényelmes, de a biztonságodat is növeli!</p>
            <h3>NINCS BANKKÁRTYÁM, FIZETHETEK ÁTUTALÁSSAL, KÉSZPÉNZZEL?</h3> 
            <p>Igen! Készpénzzel is, de utalással nem:</p> 
            <p>Ha bankszámlád sincs, de van készpénzed, akkor:</p>
            <ul>
                <li>Nyiss egy ingyenes Barion tárcát a https://secure.barion.com/ címen.</li> 
                <li>Tegyél a Barion tárcádba megfelelő mennyiségű pénzt a vásárláshoz országszerte bármely CIB bankfiókban való készpénzes befizetéssel (bővebben itt).</li> 
                <li>Fizess nálunk a Barion tárcáddal.</li>
            </ul>
            <h3>BIZTONSÁGOS A BARION?</h3>
            <p>Maximálisan.</p> 
            <p>A Barion egy szuperkorszerű és szuperbiztonságos, valamint szuperegyszerű online fizetési mód.</p>
            <p>A Barion fizetést a Barion Payment Zrt, mint elektronikus pénz kibocsátó intézmény üzemelteti. Az egész Európai Unióra érvényes MNB (korábban PSZÁF) engedély száma: H-EN-I-1064/2013, Intézményi azonosító: 25353192.</p> 
            <p>A Barion rendszere megfelel PCI-DSS, azaz Payment Card Industry Data Security Standards követelményeinek! Bővebben erről itt olvashatsz: https://doksi.barion.com/PCI-DSS </p> 
            <p>A Barion rendszere a Symantec által kibocsátott, 2048-bites RSA kulccsal ellátott, Class 3 EV (Extended Validation) azaz a bankok weboldalain is használttal azonos biztonságot nyújtó SSL tanúsítvánnyal rendelkezik.</p> 
            <a href="Fooldal.php"><h3 style="color: yellow">Vissza a Főoldalra...</h3></a>
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
