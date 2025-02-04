var slideIndex = 1;
showDivs(slideIndex);

function plusDivs(n) {
  showDivs(slideIndex += n);
}

function showDivs(n) {
  var i;
  var x = document.getElementsByClassName("mySlides");
  if (n > x.length) {slideIndex = 4}
  if (n < 1) {slideIndex = 1}
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  x[slideIndex-1].style.display = "block";  
}

function selectionSort(tr) {
  for (var i = 0; i < tr.length - 1; i++) {
    var minIndex = i;
    for (var j = i + 1; j < tr.length; j++) {
      if (tr[j] < tr[minIndex]) {
        minIndex = j;
      }
    }
    var temp = tr[i];
    tr[i] = tr[minIndex];
    tr[minIndex] = temp;
  }
  return tr;
}