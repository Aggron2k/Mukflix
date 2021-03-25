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

  <title>Mukflix | Adatvédelmi és jogi nyilatkozat</title>
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
            <h3>Adatvédelmi és jogi nyilatkozat</h3>
            <p>A jelen weblap üzemeltetője a Mukflix Inc.</p> 
            <p>Az Adatkezelő adatai:</p> 
            <p>Cégnév: Mukflix Inc.</p> 
            <p> Székhely: 6723 Szeged Szilléri sgrt. 43.</p> 
            <p> Weblap: http://mukflix.hu/</p> 
            <p> Kapcsolattartás: Horváth Krisztián, mozivezető </p> 
            <p> E-mail: kriszcso4@gmail.com</p> 
            <p> Telefon: +36-30-986-2503</p> 
            <p> E-mail: mukflix2021@gmail.com</p> 
            <p><strong><ins>Adatfeldolgozás:</ins></strong>	Az adatfeldolgozók tekintetében az egyes tevékenységekhez  kapcsolódóan adunk felvilágosítást (lásd lentebb vagy kérelemre)</p>
            <p><strong><ins>Külföldi adattovábbítás:</ins></strong>	Az adatfeldolgozók tekintetében az egyes tevékenységekhez  kapcsolódóan adunk felvilágosítást (lásd lentebb vagy kérelemre)</p>
            <p>A Mukflix Inc. adatkezelőként tiszteletben tartja mindazon személyek magánszféráját, akik számára személyes adatot adnak át és elkötelezett ezek védelmében.&nbsp;</p>
            <p>A jelen szabályzat egyaránt vonatkozik az ügyfeleinkre, az ügyfeleink számára dolgozó munkavállalókra, a weblap látogatóira, fogyasztókra forgalmazókra, szállítóinkra (és lehetséges szállítóinkra) illetőleg mindezek munkavállalóira.&nbsp;</p>
            <p>A jelen Szabályzat az alábbiakat tartalmazza:</p>
            <p>•	az általunk gyűjtött érintettek azonosító adatok típusait;&nbsp;</p>
            <p>•	az adatkezelési célok felsorolását;</p>
            <p>•	azon jogalapokat, amelyek alapján ezek kezelések történik;</p>
            <p>•	mindazok felsorolását, akikhez az adatok továbbításra kerülnek; és&nbsp;</p>
            <p>•	hogyan történik a tárolásuk.&nbsp;</p>
            <p>Kérjük figyelmesen olvassa el a jelen Szabályzatot, annak érdekében, hogy megértse, hogy hogyan kezeljük a személyes adatait.</p>
            <p><strong>1. Adatgyűjtés</strong></p>
            <p>Bizonyos adatokat közvetlenül Öntől kapunk, ez esetben vagy az Ön hozzájárulása vagy a közöttünk létrejövő szerződés adja az adatgyűjtés jogalapját.&nbsp;</p>
            <p>Előfordulhat olyan eset is, hogy más, Önre vonatkozó adatokat harmadik személyektől is kaphatunk, például: az Ön munkáltatójától, toborzási szolgáltatóktól, nyilvános weblapokról.</p>
            <p>Önre vonatkozó adat:</p>
            <p>(iv)	az Ön neve;</p>
            <p>(v)	cégnév;</p>
            <p>(vi)	e-mail cím;</p>
            <p>(vii)	az Ön telefonszáma;&nbsp;</p>
            <p>(viii)	születési ideje;&nbsp;</p>
            <p>(ix)	mindazok az adatok, amelyeket levelezés útján bocsát a rendelkezésünkre;</p>
            <p>(x)	amennyiben belép a székhelyünkre / telephelyünkre, kamerafelvétel Önre vonatkozóan.</p>
            <p>(b)	Adat weblapjaink látogatóiról és applikációink szoftvereink felhasználóiról (amennyiben releváns):</p>
            <p>(i)	amennyiben weblapunk látogatója, az Ön IP címe;</p>
            <p>(ii)	az Ön neve;</p>
            <p>(iii)	e-mail címe;</p>
            <p>(iv)	az Ön viselkedése a weblapon (például, a lehívott további weblapok) vagy az applikációnk szoftverében;</p>
            <p>(v)	fizetési adatok;&nbsp;</p>
            <p>(vi)	megrendelések és korábbi megrendelések;</p>
            <p>(c)	Adatok az általunk nyújtott szolgáltatásokról, illetve Termékeinkről:</p>
            <p>(i)	adatok, amelyek ahhoz szükségesek, hogy az Ön részére átadjuk a terméket, illetőleg amelyek a szolgáltatás nyújtásához szükségesek (beleértve az alábbiakat, név, e-mail cím, e-nyugta);</p>
            <p>(ii)	ügyfélszolgálati adatok; és</p>
            <p>(d)	Adatok, amelyek azokhoz a szolgáltatásokhoz kapcsolódnak, amelyeket mi veszünk igénybe Öntől&nbsp;</p>
            <p>(i)	azonosításhoz szükséges adat: név és e-mail cím;</p>
            <p>(ii)	fizetési adatok.</p>
            <p>Különleges adatot nem kezelünk.	</p>
            <p><strong>2.	Adatkezelési céljaink</strong></p>
            <p>Társaságunk, mint adatkezelő az alábbi célokból kezel személyes adatokat:</p>
            <p>(a)	üzletmenetfolytonosság;</p>
            <p>(b)	folyamatos szolgáltatásnyújtás;</p>
            <p>(c)	marketingtevékenység;</p>
            <p>(d)	minőségbiztosítás;</p>
            <p>(e)	személy és vagyonvédelem</p>
            <p><strong>3.	Jogalapok az Ön személyes adatainak felhasználáshoz</strong></p>
            <p>3.1	Az Ön személyes adatainak jelen Szabályzat szerinti használatát az alábbiak alapozzák meg mint jogalapok:</p>
            <p>(a)	az Ön személyes adatának használata ahhoz szükséges, hogy az Önnel kötött szerződésből származó kötelezettségeket teljesíteni tudjuk (például, hogy teljesíteni tudjunk egy megrendelést, amelyet Ön küld, vagy hogy megfeleljünk a weblapunk vagy a szoftverünk általános szerződési feltételeinek, amelyeket Ön akkor fogad el, amikor ezek használatát megkezdi, vagy amikor a szoftver applikációnkat letölti és/vagy hogy megfeleljünk a szolgáltatás nyújtására vonatkozó szerződéses kötelezettségeinknek, amelyet Önnel vagy munkáltatójával kötöttünk); vagy</p>
            <p>(b)	az Ön személyes adatának használata jogi kötelezettség teljesítése érdekében szükséges (például adóhatósági bejelentés teljesítése); vagy</p>
            <p>(c)	amennyiben sem az (a) sem a (b) jogalap nem alkalmazható a személyes adatainak kezeléséhez a jogos érdekünk, vagy harmadik személy jogos érdeke miatt szükséges, (ilyen lehet például weblapunk, vagy mobilalkalmazásunk biztonságának szükségessége). Jogi érdekeink védelme az alábbi okokból szükséges:</p>
            <p>(i)	üzletmenet működtetés és fejlesztés;</p>
            <p>(ii)	a weblap és a mobil alkalmazás működtetése;</p>
            <p>(iii)	marketing, piackutatás és üzletfejlesztés;</p>
            <p>(iv)	ügyfeleink számára termék értékesítése és szolgáltatás nyújtása, fizetni és fizetést fogadni, ügyfélszolgálat üzemeltetése és ehhez kapcsolódó tájékoztatás nyújtása;&nbsp;</p>
            <p>(v)	a szállítók részére megrendelés feladása és ennek figyelemmel kísérése; és</p>
            <p>3.2	A jövőben, a személyes adatának más módon történő használatának feltétele az Ön  hozzájárulásától függ (amelyet megadást követően bármikor visszavonhat a lent leírt módon. Amennyiben erről van szó, a jelen Szabályzat részletezi, hogy mely esetben van szükség hozzájárulásra, és milyen módon adható az meg.</p>
            <p><strong>4.	Cookie-k (sütik)</strong></p>
            <p>Mobilapplikációink és egyes oldalak a weblapjainkon sütiket használnak. A sütik, kis adatfájlok, amelyeket a böngészője telepít akkor amikor meglátogatja a weblapunkat, vagy használja a mobil applikációinkat. A kokikat azért használjuk, hogy testreszabbhassuk a jövőben az Ön számára weblapjainkat és alkalmazásainkat, olyan módon, hogy megértjük az Ö preferenciáit vagy megjegyezzük a böngészési szokásait.</p>
            <p>Amennyiben a weblapjainkon sütiket használunk, Ön ezeket a sütiket bármikor letilthatja. Ezt olyan módon teheti meg, hogy böngészőjében aktiválja azt a funkciót, amely a sütibeállításokat tudja letiltani.  Megjegyezzük ugyanakkor, hogy amennyiben az összes sütit letiltja a böngészőjében, előfordulhat, hogy nem lesz képes weblapjaink egyes részeit látogatni, vagy egyes funkciókat nem tud majd használni.</p>
            <p><strong>5.	Személyes adat továbbítása</strong></p>
            <p>5.1	Az Ön adatait harmadik személyek alábbi kategóriáival oszthatjuk meg:</p>
            <p>(a)	szolgáltatóink és alvállalkozóink, beleértve de nem kizárólagosan az alábbiakat: fizetési szolgáltatók, technikai és kisegítő szolgáltatást nyújtók, biztosítók, logisztikai szolgáltatást nyújtók, felhőszolgáltatást nyújtók;&nbsp;</p>
            <p>(b)	társaságok, amelyek marketing és promóciós tevékenységeinket segítik és</p>
            <p>(c)	analitikai és keresőmotor szolgáltatók, amelyek abban segítik munkánkat, hogy weblapjainkat és applikációinkat optimalizáljuk illetőleg fejlesszük.</p>
            <p>(d)	Az adatgyűjtés ténye, a kezelt adatok köre és az adatkezelés célja:&nbsp;</p>
            <p>Személyes adat 	Az adatkezelés célja&nbsp;</p>
            <p>Vezeték-és keresztnév 	A kapcsolatfelvételhez, foglaláshoz, a blog oldalon a hozzászólás írásához, a vásárláshoz és a szabályszerű számla kiállításához szükséges.</p>
            <p>E-mail cím 	Kapcsolattartás, a számlázással, vagy a mozival kapcsolatos kérdések hatékonyabb egyeztetése.</p>
            <p>Telefonszám 	Kapcsolattartás, a számlázással, vagy a mozival kapcsolatos kérdések hatékonyabb egyeztetése.&nbsp;</p>
            <p>Születési idő 	A Törzskártya adatok felvitele esetén szükséges, ajándékjegyek érvényesítéséhez.</p>
            <p>A vásárlás/regisztráció időpontja 	Technikai művelet végrehajtása.&nbsp;</p>
            <p>A vásárlás/regisztráció kori IP cím 	Technikai művelet végrehajtása.&nbsp;</p>
            <p>A fent megjelölt adatokat jegyfoglalás, vásárlás esetén az előadás időpontjától számítva 365 napig, a Törzskártya adatokat a lejárat után további 30 napig tároljuk.</p>
            <p>Korlátozunk (szerződéssel vagy törvényi rendelkezéssel) minden olyan harmadik személyt, akinek számára az Ön adatait továbbítjuk, abban a vonatkozásban, hogy ne legyenek képesek arra, hogy eltérő célja használják az Ön adatait, mint amilyen célra mi használjuk ezeket.&nbsp;</p>
            <p>A személyes adatának tárolására az adatkezelés céljának megvalósulását követően nem kerül sor. Az adatmegőrzés időtartama attól a céltól függ, amely az adat használatát meghatározza, vagy amely az adott jogszabályban meghatározott jogi kötelezettség teljesítéséhez, illetőleg jogvédelmi célból szükséges.</p>
            <p><strong>Az online jegyvásárlással kapcsolatos kérdéssel, illetve adatvédelmi incidens esetén az érintett a következő partnerünkhöz fordulhat, mint adatfeldolgozóhoz:</strong></p>
            <p>Barion Payment Zrt.</p>
            <p>Székhely: 1117 Budapest, Infopark sétány 1. I. épület 5. emelet 5</p>
            <p>E-mail: adatvedelem@barion.com,</p>
            <p>Telefonszám: +36 1 464 70 99</p>
            <p><strong>A weboldalunk működésének tekintetében, adatvédelmi incidens esetében, mint adatfeldolgozóhoz a következő címeken, elérhetőségeken tud tájékozódni: </strong></p>
            <p>Zalaszám Informatika Kft.</p>
            <p>Cím: 8900 Zalaegerszeg, Mártírok útja 53.</p>
            <p>Postacím: 8900 Zalaegerszeg, Pf. 113.</p>
            <p>E-mail: info@zalaszam.hu</p>
            <p>Telefon: +36-92-502-500</p>
            <p>Fax: +36-92-502-501</p>
            <p><strong>6.	Az Ön jogai</strong></p>
            <p>6.1	A személyes adataihoz kapcsolódóan Önnek meghatározott jogai vannak.&nbsp;</p>
            <p>6.2	Amennyiben ezekhez kapcsolódóan további információt szeretne kapni, vagy bármelyikkel élni kíván, bármikor kapcsolatba léphet velünk.</p>
            <p>Érintetti jogok:</p>
            <p>(a)	hozzáférés, az Önre vonatkozó általunk kezelt adathoz;</p>
            <p>(b)	amennyiben egy adat elavult vagy helytelen, ennek kiigazítása;</p>
            <p>(c)	az Önre vonatkozó általunk kezelt adat törlése;&nbsp;</p>
            <p>(d)	az adat kezelésének korlátozása;</p>
            <p>(e)	az Ön személyes adatának direkt marketing célokra való használatának megtiltása;</p>
            <p>(f)	személyes adatainak harmadik személy szolgáltató számára történő átadása, vagy ennek megtiltása;&nbsp;</p>
            <p>(g)	bármely Önre vonatkozó általunk kezelt személyes adatról másolat adása; vagy</p>
            <p>(h)	tiltakozás a személyes adatok általunk történő használata ellen.</p>
            <p>6.3	Minden fenti vonatkozásban érkező kérést ésszerű időn belül válaszolunk meg (minden esetben azonban az adott jogszabályi határidőn, azaz 30 napon belül).&nbsp;</p>
            <p>6.4	Az érintettek adatkezeléssel kapcsolatos jogainak ismertetése: A személyes adatok törlését, vagy módosítását az alábbi módokon tudja érintett kezdeményezni:</p>
            <p>(i)	postai úton: Mukflix - Szeged (6723)  Szilléri sgrt. 43</p>
            <p>(ii)	e-mail útján: mukflix2021@gmail.com</p>
            <p>(iii)	telefonon a ügyfélszolgálaton, munkanapokon 8.00 és 20.00 között a +36-70-306-7755-ös számon.</p>
            <p><strong>7.	 Információbiztonság</strong></p>
            <p>7.1	A Mukflix Inc. elkötelezetten védi a személyes adatokat az elvész, jogellenes használat, jogellenes továbbítás, módosítás, elérhetetlenség vagy megsemmisülés ellen, és megtesz minden szükséges intézkedést a személyes adatok bizalmasságának megőrzése érdekében, beleértve a megfelelő technikai és szervezési intézkedések használatát.&nbsp;</p>
            <p>7.2	A szervezeti intézkedések magukban foglalják az épületeinkben a fizikai hozzáférések ellenőrzését, munkavállalók oktatását, a papír alapú akták elzárását megfelelő helyiségekbe. A technikai intézkedések magukban foglalják a rendszereinkhez történ hozzáféréshez kapcsolódó titkosítást, jelszóvédelmet és a vírusírtó szoftverek használatát.</p>
            <p>7.3	Annak a folyamatnak a részeként, amely során Ön a rendelkezésünkre bocsátja a személyes adatait, ezek az adatok az interneten keresztül is továbbításra kerülhetnek. Annak ellenére, hogy minden szükséges intézkedést megteszünk az Ön által a rendelkezésünkre bocsátott személyes adatok védelme érdekében, az interneten történő adattovábbítás nem tekinthető teljes mértékben biztonságosnak. Ennek megfelelően, Önnek tudomásul kell vennie és el kell fogadnia, hogy a weblapunkon keresztül történő adattovábbítás biztonságáért nem tudunk teljes felelősséget vállalni, és az ilyen módon történő továbbítás az Ön saját felelősségére történhet. Amint az Ön személyes adata azonban megérkezik a rendszereinkbe, szigorú eljárásokat tartunk be a biztonság érdekében, és a jogellenes hozzáférés megakadályozása céljából.&nbsp;</p>
            <p>7.4	Azokban az esetekben, amikor mi adtunk Ön számára egy jelszót (vagy Ön választott egyet) Ön a felelős azért, hogy e jelszó bizalmasságát megőrizze. Arra kérjük, hogy ezt a jelszót senkivel ne ossza meg.</p>
            <p>7.5	Weblapjaink, mobil applikációnk illetőleg közösségi médiaoldalaink időről időre tartalmazhatnak olyan utalásokat, amelyek harmadik személyek által működtetett weblapokra mutatnak beleértve a tagvállalatok weblapjait, illetve a partner hálózatokat is, ezek új adatkezelése nem tartozik az általunk végzett tevékenységek közé.&nbsp;</p>
            <p><strong>8.	Jogorvoslati tájékoztatás</strong></p>
            <p>Magyarországon az adatvédelmi felügyeleti hatóság: Nemzeti Adatvédelmi és Információszabadság Hatóság (1125 Budapest, Szilágyi Erzsébet fasor 22/C) ugyfelszolgalat@naih.hu.</p>
            <p></p>
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
