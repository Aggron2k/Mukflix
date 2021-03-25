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

  <title>Mukflix | Nyereményjáték</title>
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
        <a href="nyeremenyjatek.php" class="active">Nyereményjáték</a>
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
  <?php

    if(isset($_POST['kuldes']))
    {
      require('kapcs.php');
      dbkapcs();
      //error_reporting(0);
                        
      $query="select phone from giveaway
              where phone='$_POST[phone]'";
      $eredm=mysqli_query($kapcs,$query);
      
      if(mysqli_num_rows($eredm)!=0)
      {
        echo "
				<script>alert('Erre a telefonszámra már van egy felhasználó regisztrálva a nyereményjátékra!')</script>
				<script>window.location = 'fooldal.php'</script>
				";
      }
      else
      {
        $query="Insert into giveaway values
        ('$_POST[id]',
        '$_POST[name]',
        '$_POST[email]',
        '$_POST[phone]',
        '$_POST[answer1]',
        '$_POST[answer2]',
        '$_POST[answer3]',
        '$_POST[answer4]',
        '$_POST[answer5]')";
        mysqli_query($kapcs,$query);
        echo"Válaszok felvezetve!";
      }
    }
    ?>
  <form action="" method="POST" id="quiz" name="quiz">
  <div class="quiz">
      <div class="roundedborderv2">
        <font color="red"><b>Nyerj mozizást a családdal!</b></font><br>
        Áprilisi nyereményjátékunk során a helyesen válaszolok között kisorsolunk 4 jegyet a Haverok Harca című filmre! <br> <br>
        Feltétele hogy az összes kérdésre helyesen kell válaszolni. Nyeremény hirdetés: <br>
        <b>Március 28. Vasránap.</b><br>
        Email-en értesítjük a nyerteseket! Sok szerencsét mindenkinek! <br>
      </div>
    <input type="hidden" name="id">
    <p>Név: <input type="text" name="name" placeholder="Családnév Vezetéknév" value="<?php echo $fetch['name']?>" readonly></p>
    <p>E-mail: <input type="email" name="email" placeholder="valaki@gmail.com" value="<?php echo $fetch['email']?>" readonly></p>
    <p>Telefonszám: <input type="number" name="phone" placeholder="305554422"></p>

    <p>1. Melyik címen érhető el a Mukflix mozi?</p>
      <input type="radio" name="answer1" value="jo"><label for="">a. Szeged, Szilléri sgrt. 43</label><br>
      <input type="radio" name="answer1" value="rossz"><label for="">b. Szentes, Szent Gellért sgrt. 13</label><br>
      <input type="radio" name="answer1" value="rossz"><label for="">c. Budapest,  Tökhöly út 43</label><br>
      <input type="radio" name="answer1" value="rossz"><label for="">d. Győr, Álmos utca 17</label><br>
    <p>2. Melyik filmet forgatjuk április 5.-én?</p>
      <input type="radio" name="answer2" value="rossz"><label for="">a. Venom</label><br>
      <input type="radio" name="answer2" value="rossz"><label for="">b. Baywatch</label><br>
      <input type="radio" name="answer2" value="jo"><label for="">c. A platform</label><br>
      <input type="radio" name="answer2" value="rossz"><label for="">d. Egyiket sem ezek közül</label><br>
    <p>3. Melyik jegyfajta kerül 4500Ft-ba?</p>
      <input type="radio" name="answer3" value="rossz"><label for="">a. Nomál jegy</label><br>
      <input type="radio" name="answer3" value="rossz"><label for="">b. Kedvezményes jegy</label><br>
      <input type="radio" name="answer3" value="jo"><label for="">c. Családi jegy</label><br>
      <input type="radio" name="answer3" value="rossz"><label for="">d. Baráti jegy</label><br>
    <p>4. A Valós halál(Altered carbon) című sorozatnak az első évadjának hány része van?</p>
      <input type="radio" name="answer4" value="rossz"><label for="">a. 8</label><br>
      <input type="radio" name="answer4" value="jo"><label for="">b. 10</label><br>
      <input type="radio" name="answer4" value="rossz"><label for="">c. 9</label><br>
      <input type="radio" name="answer4" value="rossz"><label for="">d. 12</label><br>
    <p>5. Hány kérdésből áll ez a quiz?</p>
      <input type="radio" name="answer5" value="rossz"><label for="">a. 3</label><br>
      <input type="radio" name="answer5" value="rossz"><label for="">b. 4</label><br>
      <input type="radio" name="answer5" value="rossz"><label for="">c. 6</label><br>
      <input type="radio" name="answer5" value="jo"><label for="">d. 5</label><br>
    <br>

    <input type="button" onclick="restart()" value="Alapállapot" id="clear" class="button"><br><br>
    <input type="submit" onclick="send()" name="kuldes" value="Küldés!" class="button"><br>
    <p id="eredmeny"></p>
    </div>
    </form>    
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
