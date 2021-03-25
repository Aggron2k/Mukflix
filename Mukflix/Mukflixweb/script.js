//openlink
function openlink(){
  window.open("fooldal.php","_self");
}

//menusor
window.onscroll = function() {myFunction()};

var header = document.getElementById("myHeader");
var sticky = header.offsetTop;

function myFunction() {
  if (window.pageYOffset > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}

//slideshow
var myIndex = 0;
carousel();

function carousel() {
  var i;
  var x = document.getElementsByClassName("mySlides");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  myIndex++;
  if (myIndex > x.length) {myIndex = 1}    
  x[myIndex-1].style.display = "block";  
  setTimeout(carousel, 2000);
}
//dátum
n =  new Date();
y = n.getFullYear();
m = n.getMonth() + 1;
d = n.getDate();
document.getElementById("datum").innerHTML = y + ". " + m + ". " + d + ".";

////nyeremenyjatek
//küldés-értékelés
function send(){
  var jovalaszok = 0;
  var kerdes1 = document.quiz.answer1.value;
  var kerdes2 = document.quiz.answer2.value;
  var kerdes3 = document.quiz.answer3.value;
  var kerdes4 = document.quiz.answer4.value;
  var kerdes5 = document.quiz.answer5.value;

  if(kerdes1 == "jo")
  {
      jovalaszok++;
  }
  if(kerdes2 == "jo")
  {
      jovalaszok++;
  }
  if(kerdes3 == "jo")
  {
      jovalaszok++;
  }
  if(kerdes4 == "jo")
  {
      jovalaszok++;
  }
  if(kerdes5 == "jo")
  {
      jovalaszok++;
  }
  console.log(jovalaszok);
  if(jovalaszok === 5)
  {
    alert("Gratulálunk eltalálta az összeset! :) Bekertül a kalapba, sorsolás napjárol a hirekon olvashat!");
      
      
      //document.getElementById("eredmeny").innerHTML = "Gratulálunk eltalálta az összeset! :) Bekertül a kalapba, sorsolás napjárol a hirekon olvashat!";
      
  }
  else
  {
    alert("Sajnos nem sikerült! :( De jövő hónapba ismét megpróbálhatja!");
      
     
      //document.getElementById("eredmeny").innerHTML = "Sajnos nem sikerült! :( De jövő hónapba ismét megpróbálhatja!";
  }

}
//restart
function restart(){
  var ele1 = document.getElementsByName("answer1");
  for(var i = 0; i < ele1.length;i++)
  {
      ele1[i].checked = false;
  }
  var ele2 = document.getElementsByName("answer2");
  for(var i = 0; i < ele2.length;i++)
  {
      ele2[i].checked = false;
  }
  var ele3 = document.getElementsByName("answer3");
  for(var i = 0; i < ele3.length;i++)
  {
      ele3[i].checked = false;
  }
  var ele4 = document.getElementsByName("answer4");
  for(var i = 0; i < ele4.length;i++)
  {
      ele4[i].checked = false;
  }
  var ele5 = document.getElementsByName("answer5");
  for(var i = 0; i < ele5.length;i++)
  {
      ele5[i].checked = false;
  }
  document.getElementById("eredmeny").innerHTML = "";
}