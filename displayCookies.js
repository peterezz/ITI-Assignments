var userPhoto = document.getElementById("photo");
getAllCookies();
userPhoto.src=cookieArr.gender;

var date = new Date();
date.setMonth(date.getMonth() + 1);
setCookie("visitNum", +cookieArr.visitNum+1, date);
var welcomeMassege = document.getElementById("WelcomeMassege");
welcomeMassege.innerHTML = "Welcome <span style='color:"+cookieArr.list+"'>"+cookieArr.username+"</span> your age is <span style='color:"+cookieArr.list+"'>"+cookieArr.age+"</span> you visited the website <span style='color:"+cookieArr.list+"'>"+cookieArr.visitNum+"</span> times" ;

