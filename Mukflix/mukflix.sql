-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Már 22. 17:47
-- Kiszolgáló verziója: 10.4.14-MariaDB
-- PHP verzió: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `mukflix`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `films`
--

CREATE TABLE `films` (
  `id` int(10) NOT NULL,
  `title` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `theme` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `director` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `age_limit` int(11) NOT NULL,
  `picture` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `projection date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `films`
--

INSERT INTO `films` (`id`, `title`, `theme`, `director`, `age_limit`, `picture`, `projection date`) VALUES
(1, 'A platform', 'Thriller/Horror', 'Galder Gaztelu-Urrutia', 18, 'the_platform_poster.jpg', '2021-04-05'),
(2, 'Haverok harca', 'Vígjáték', 'Jeff Tomsic', 16, 'haverok_harca_poster.jpg', '2021-04-06'),
(3, 'Tyler Rake: A kimenekítés', 'Akció/Thriller', 'Sam Hargrave', 16, 'tyler_rake_poster.jpg', '2021-04-07'),
(4, 'Coco', 'Gyerek/Kaland', 'Adrian Molina, Lee Unkrich', 6, 'coco_poster.jpg', '2021-04-08'),
(5, 'Venom', 'Akció/Sci-fi', 'Ruben Fleischer', 16, 'venom_poster.jpg', '2021-04-09'),
(6, 'Valós halál (S1 - E1, E2)', 'Sci-fi', '---', 16, 'valos_halal_poster.jpg', '2021-04-12'),
(7, 'Valós halál (S1 - E3, E4)', 'Sci-fi', '---', 16, 'valos_halal_poster.jpg', '2021-04-13'),
(8, 'Bad Boys', 'Akció', 'Michael Bay', 16, 'bad_boys_poster.jpg', '2021-04-14'),
(9, 'Mátrix', 'Akció/Sci-fi', 'Larry Wachowski, Lilly Wachowski', 16, 'matrix_poster.jpg', '2021-04-15'),
(10, 'Nyomd, bébi, nyomd', 'Akció/Thriller', 'Edgar Wright', 16, 'nyomd_bebi_nyomd_poster.jpg', '2021-04-16'),
(11, 'John Wick', 'Akció', 'Chad Stahelski', 18, 'john_wick_poster.jpg', '2021-04-19'),
(12, 'John Wick: 2. felvonás', 'Akció', 'Chad Stahelski', 18, 'john_wick2_poster.jpg', '2021-04-20'),
(13, 'Idegpálya', 'Thriller/Akció', 'Ariel Schulman, Henry Joost', 16, 'idegpalya_poster.jpg', '2021-04-21'),
(14, 'Baywatch', 'Vígjáték/Akció', 'Seth Gordon', 16, 'baywatch_poster.jpg', '2021-04-22'),
(15, 'Sonic, a sündisznó', 'Gyerek/Vígjáték', 'Jeff Fowler', 12, 'sonic_a_sundiszno_poster.jpg', '2021-04-23');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `giveaway`
--

CREATE TABLE `giveaway` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `phone` int(20) NOT NULL,
  `answer1` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `answer2` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `answer3` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `answer4` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `answer5` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `giveaway`
--

INSERT INTO `giveaway` (`id`, `name`, `email`, `phone`, `answer1`, `answer2`, `answer3`, `answer4`, `answer5`) VALUES
(1, 'Áldott Aura', 'aldott.aura2@gmail.com', 305540303, 'jo', 'rossz', 'jo', 'rossz', 'rossz'),
(2, 'Bak Tas', 'baktas.kiraly@freemail.hu', 904563883, 'rossz', 'jo', 'rossz', 'jo', 'rossz'),
(3, 'Git Áron', 'basszusgitar1999@freemail.hu', 904553120, 'rossz', 'jo', 'jo', 'rossz', 'jo'),
(4, 'Bekre Pál', 'bekrepal1@gmail.com', 904552299, 'jo', 'rossz', 'rossz', 'rossz', 'rossz'),
(5, 'Dil Emma', 'dilemma@gmail.com', 304209911, 'jo', 'jo', 'jo', 'jo', 'jo'),
(6, 'Eszte Lenke', 'eszter460a@pastemail.com', 708811212, 'jo', 'rossz', 'jo', 'rossz', 'jo'),
(7, 'Lakatos Imre', 'imike@gmail.com', 701234567, 'jo', 'rossz', 'jo', 'jo', 'rossz'),
(8, 'Szikla Szilárd', 'kavics44@freemail.hu', 309872604, 'rossz', 'jo', 'rossz', 'rossz', 'rossz'),
(10, 'Horváth Krisztián', 'kriszcso4@gmail.com', 309862503, 'rossz', 'jo', 'jo', 'rossz', 'rossz'),
(11, 'Bátor Vitéz', 'magyarvitez765@hotdog.hu', 707981165, 'jo', 'jo', 'jo', 'jo', 'jo'),
(12, 'Forró Napsugár', 'napsi2005@citromail.hu', 901289332, 'jo', 'rossz', 'rossz', 'rossz', 'jo'),
(13, 'Gá Zóra', 'nav20000313@gmail.com', 708885421, 'rossz', 'jo', 'rossz', 'jo', 'rossz'),
(14, 'Kér Ede', 'newedem@citromail.hu', 702239719, 'jo', 'jo', 'jo', 'jo', 'jo'),
(15, 'Patta Nóra', 'norkaborka9@gmail.com', 906689090, 'rossz', 'jo', 'rossz', 'rossz', 'jo'),
(16, 'Remete János', 'oregremete85@mako-pont.hu', 302238890, 'rossz', 'rossz', 'rossz', 'rossz', 'rossz');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `news`
--

CREATE TABLE `news` (
  `id` int(10) NOT NULL,
  `username` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `post` varchar(500) COLLATE utf8_hungarian_ci NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `news`
--

INSERT INTO `news` (`id`, `username`, `post`, `date`) VALUES
(1, 'admin', 'Kedves felhasználó!<br> Fontos hogy elolvasd a következő posztokat, mivel ezzel szeretnélek körbekalauzolni a weboldalon. Másodrészt pedig minden újítást a weboldalon itt jegyzünk fel. ', '2020-12-18'),
(2, 'admin', 'Fontos információ!<br> A mozi áprilistól első hetétől nyitja meg kapuit, előre láthatólag első három héten lesznek vetítések! Szeretettel várunk minden nézőt!', '2021-01-02'),
(3, 'admin', 'Poszter kedvelők figyelem!<br> A galéria részen elérhető az összes film posztere amit eddig vetítettünk vagy vetíteni fogunk! Szabadon letölthető és kinyomtatható bárki számára. ', '2021-01-05'),
(4, 'aggron2k', 'Figyelem felhívás!<br> Szeretnénk minél jobban felhasználó barátra készíteni weboldalunkat, így segítségeteket kérjük a fejlesztésben. Ha bármi ötlet vagy hiba merül fel akkor kérjük hogy az alábbi e-mailen: info@mukflix.hu kérjük jelezze számunkra.', '2021-01-06'),
(5, 'aggon2k', 'Ötlet megvalósítás!<br> Egy kedves felhasználó jelezte számunkra hogy egyszerű felhasználók nem igazán tudnak letölteni a galériából mivel nem tudják hogy hogyan lehet ezt kivitelezni. Felhasználó barátra szeretnénk alakítani így hamarosan egy letöltő gomb lesz minden gomb mellé csatolva így megsegítve a letöltés megkönnyítését. Köszönjük a segítséget, további ötleteket várjuk az info@mukflix.hu e-mail-re.', '2021-01-07'),
(6, 'admin', 'Jegyárak!<br> Az oldalunkon menüsorban megtalálható egy új fül, a jegyárak. Itt minden ár fel van tüntetve. Reméljük segítsége nyújt az árak kiszámolására.', '2021-01-07'),
(7, 'aggron2k', 'Galéria újra dizájnolása<br> A Galéria rész új design-t kapott, sokkal élvezhetőbb és élőbb összképet kapott, reméljük elnyeri tetszését minden felhasználónak.', '2021-01-09'),
(8, 'aggron2k', 'Megvalósítás csúsztatása<br> Fennakadások folytán a fejlesztés lassan halad de igyekszünk minden E-mailre válaszolni és megvalósítani minden ötletet.', '2021-01-09'),
(9, 'admin', 'Foglalások alternatív megoldása!<br> Foglalás oldal megoldása még problémákba ütközött így foglalásokat e-mailen fogadjuk! Megértésüket köszönjük!', '2021-01-09'),
(10, 'admin', 'Foglalható filmek!<br> Az oldalunk foglalás fülén megtekinthető a filmek listája megkönnyítve a foglalást. Továbbra is e-mailen fogadjuk a foglalásokat. Megértésüket köszönjük!', '2021-01-10'),
(11, 'admin', 'Figyelem felhívás! <br> Félreértések elkerülése érdekébe 1 felhasználó csak 4 helyet foglalhat le. Eddig elnézőek voltunk de kérjük ezentúl legyenek megértőek. Köszönjük!', '2021-01-12'),
(12, 'admin', '<font color=\"red\">Nyerj mozizást a családdal!</font> <br>Nyereményjáték indul az oldalon. A nyereményjáték fülön érhető el. Minden hónapba lesz lehetőség játszani. Az öt kérdésre helyeselők közt választjuk ki a nyertest véletlenszerűen. Email-en értesítjük a győztest! Sok szerencsét mindenkinek!', '2021-02-01'),
(13, 'admin', 'Nyereményjáték kihirdetésének időpontja!<br> Március utolsó vasárnapján 28.-án fogjuk a nyertest kihirdetni! Addig is várjuk a játékra jelentkezőket. Sok sikert mindenkinek!', '2021-02-03'),
(14, 'aggron2k', 'Apró változások! <br> Áprilisi nyertest itt a blog részen is kiírjuk, így kívánva gratulációt a nyereményhez! A játékra jelentkezőknek sok sikert kívánunk!', '2021-02-04'),
(15, 'admin', '<b>Az oldalunk elkészült!</b><br>Remek nap a mai, elkészült az oldal, továbbiakban tartalom frissítés és apró hiba javításokra lehet számítani. Köszönjük a segítséget! Változások során továbbra is itt közlünk mindent!', '2021-02-17');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `reservation`
--

CREATE TABLE `reservation` (
  `id` int(20) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `phone` bigint(50) NOT NULL,
  `film` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `chair1` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `chair2` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `chair3` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `chair4` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `date` date NOT NULL,
  `price` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `reservation`
--

INSERT INTO `reservation` (`id`, `name`, `email`, `phone`, `film`, `chair1`, `chair2`, `chair3`, `chair4`, `date`, `price`) VALUES
(1, 'Remete János', 'oregremete85@mako-pont.hu', 302238890, 'A platform', 'A3', 'A4', '', '', '2021-04-05', 2300),
(2, 'Gá Zóra', 'nav20000313@gmail.com', 708885421, 'A platform', 'B4', '', '', '', '2021-04-05', 1400),
(3, 'Git Áron', 'basszusgitar1999@freemail.hu', 904553120, 'A platform', 'D8', 'D7', '', '', '2021-04-05', 2800),
(4, 'Eszte Lenke', 'eszter460a@pastemail.com', 708811212, 'Tyler Rake: A kimenekítés', 'C3', 'C4', 'C5', 'C6', '2021-04-07', 4650),
(5, 'Áldott Aura', 'aldott.aura2@gmail.com', 305540303, 'Tyler Rake: A kimenekítés', 'B3', '', '', '', '2021-04-07', 1400),
(6, 'Lakatos Imre', 'imike@gmail.com', 701234567, 'Valós halál (S1 - E1, E2)', 'A7', 'A6', '', '', '2021-04-12', 2800),
(7, 'Dil Emma', 'dilemma@gmail.com', 304209911, 'Valós halál (S1 - E1, E2)', 'B3', 'B4', 'B5', '', '2021-04-12', 3450),
(8, 'Bak Tas', 'baktas.kiraly@freemail.hu', 904563883, 'Valós halál (S1 - E1, E2)', 'D5', 'D4', '', '', '2021-04-12', 2800),
(9, 'Bátor Vitéz', 'magyarvitez765@hotdog.hu', 707981165, 'Mátrix', 'B1', '', '', '', '2021-04-15', 2800),
(10, 'Horváth Krisztián', 'kriszcso4@gmail.com', 309862503, 'Nyomd, bébi, nyomd', 'B4', 'B5', '', '', '2021-04-16', 2300),
(11, 'Patta Nóra', 'norkaborka9@gmail.com', 906689090, 'Nyomd, bébi, nyomd', 'D6', 'D5', '', '', '2021-04-16', 2800),
(12, 'Kér Ede', 'newedem@citromail.hu', 702239719, 'Nyomd, bébi, nyomd', 'C6', '', '', '', '2021-04-16', 1400),
(13, 'Szikla Szilárd', 'kavics44@freemail.hu', 309872604, 'Idegpálya', 'A1', '', '', '', '2021-04-21', 1400),
(14, 'Bekre Pál', 'bekrepal1@gmail.com', 904552299, 'Idegpálya', 'A4', '', '', '', '2021-04-21', 1400),
(15, 'Forró Napsugár', 'napsi2005@citromail.hu', 901289332, 'Sonic, a sündisznó', 'B3', 'B4', 'B6', 'B8', '2021-04-23', 4500);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `username` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `name`, `username`, `email`, `password`, `admin`) VALUES
(1, 'Bekre Pál', 'bekrepal1', 'bekrepal1@gmail.com', 'bekrepal1', 1),
(2, 'Lakatos Imre', 'imike', 'imike@gmail.com', 'imiwokhelo', 0),
(3, 'Áldott Aura', 'aura2k11', 'aldott.aura2@gmail.com', 'lovejezus2k', 0),
(4, 'Bak Tas', 'Tasakkiraly', 'baktas.kiraly@freemail.hu', 'kiralyvagyok1987', 0),
(5, 'Bátor Vitéz', 'magyarvitez765', 'magyarvitez765@hotdog.hu', 'trianon', 0),
(6, 'Remete János', 'oregremete', 'oregremete85@mako-pont.hu', 'mako1985', 0),
(7, 'Horváth Krisztián', 'aggron2k', 'kriszcso4@gmail.com', 'betterthanotherspass', 1),
(8, 'Forró Napsugár', 'napsugarka2005', 'napsi2005@citromail.hu', 'napsikaittvan', 0),
(9, 'Gá Zóra', 'nav20000313', 'nav20000313@gmail.com', 'jottemleolvasni', 0),
(10, 'Szikla Szilárd', 'a.kavics', 'kavics44@freemail.hu', 'thekavics', 0),
(11, 'Kér Ede', 'Kerede', 'newedem@citromail.hu', 'newedem2k21', 0),
(12, 'Patta Nóra', 'norkaborka', 'norkaborka9@gmail.com', 'newpassword', 0),
(13, 'Git Áron', 'gitaron', 'basszusgitar1999@freemail.hu', 'gitarhur', 0),
(14, 'Eszte Lenke', 'eszter460', 'eszter460a@pastemail.com', 'password', 0),
(15, 'Dil Emma', 'dilemma', 'dilemma@gmail.com', 'milegyenajelszo', 1),
(16, 'Nagy Keszeg', 'keszeg123', 'keszeg123@gmail.com', 'keszeg123', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `films`
--
ALTER TABLE `films`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `giveaway`
--
ALTER TABLE `giveaway`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `news`
--
ALTER TABLE `news`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `films`
--
ALTER TABLE `films`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT a táblához `giveaway`
--
ALTER TABLE `giveaway`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT a táblához `news`
--
ALTER TABLE `news`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT a táblához `reservation`
--
ALTER TABLE `reservation`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
