//khai bao biesn slideindex dai dien cho slide hien tai
var slideindex;
//khai bao ham hien thi slide
function showslide(){
    var i;
    var slides =document.getElementsByClassName("slide");
    var nuts=document.getElementsByClassName("nut");
    for(i = 0; i < slides.length; i++){
        slides[i].style.display="none";
    }
    for(i = 0; i < nuts.length; i++){
        nuts[i].className = nuts[i].className.replace(" active","");
    }
    slides[slideindex].style.display = "block";
    nuts[slideindex].className += " active";
    //chuyen den slide tiep theo
    slideindex++;
    //neu dang o slide cuoi cung thi chuyen ve slide dau
    if(slideindex > slides.length - 1){
        slideindex = 0
    }
    //tu dong chuyen doi slide sau 5s;
    setTimeout(showslide, 4000);
}
//mac dinh hien thi slide dau tien
showslide(slideindex = 0);

function currentslide(n){
    showslide(slideindex = n);
}