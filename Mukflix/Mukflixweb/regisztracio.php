<!DOCTYPE html>
<html lang="hu">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="icon" href ="webkepek/logo_xvq_icon.ico" type = "image/x-icon"> 
  <link rel="stylesheet" href="bootstrapcss.css" type="text/css">
  <link rel="stylesheet" type="text/css" href="lightbox.min.css">
  <script src="lightbox-plus-jquery.min.js"></script>

  <title>Mukflix | Regisztráció</title>
</head>
<body>

<div class="fejlec" id="myHeader">
  <img src="webkepek/textsmall.png" alt="Fejléc" class="kepfejlec">
</div>

<div class="tartalom">
  <div class="fo">
        <br>
        <div class="roundedborder">
            <h1>Regisztráció:</h1>
            <?php

                    if(isset($_POST['reg']))
                    {
                    require('kapcs.php');
                    dbkapcs();
                    error_reporting(0);
                            

                    $query="SELECT email FROM users
                            WHERE email='$_POST[email]'";
                    $eredm=mysqli_query($kapcs,$query);

                    if(mysqli_num_rows($eredm)!=0)
                    {
                        echo "Erre az emailre már van egy felhasználó regisztrálva!";
                    }
                    else
                    {
                            $query="INSERT INTO users VALUES
                            ('$_POST[id]',
                            '$_POST[nev]',
                            '$_POST[felhasznalonev]',
                            '$_POST[email]',
                            '$_POST[jelszo]',
                            '$_POST[admine]')";
                            mysqli_query($kapcs,$query);
                            echo"<center><h3>Regisztráció sikeres!<h3></center>";
                    }
                    }
        ?>
        <form action="" method="POST">
            <h3>Teljes név: </h3><input type="text" name="nev">
            <h3>Felhasználónév: </h3><input type="text" name="felhasznalonev">
            <h3>E-mail: </h3><input type="email" name="email">
            <h3>Jelszó: </h3><input type="password" name="jelszo"><br><br><br>
            <input type="submit" value="Regisztrálás!" name="reg" class="button">
        </form>
        <br>
        <br>
        <br>
        <a href="belepes.php"><h3 style="color: yellow">Vissza a belépéshez!...</h3></a>
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
      <td>Belépés után olvashatja a Fizetési tájékoztatónkat<br>és az Adatvédelmi és jogi nyilatkozatunkat</td>
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
