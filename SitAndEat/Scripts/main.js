function showModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "block";
}

function closeModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "none";
}

function stickToTop() {
    var stickyElem = document.querySelector(".navbar2");
    var parentElem = document.querySelector(".banner-container");
    var size = parentElem.offsetHeight - stickyElem.offsetHeight;
    if(window.pageYOffset > size) {
        if(!stickyElem.classList.contains("sticky")) {
            stickyElem.classList.add("sticky")
        }
    } else {
        if (stickyElem.classList.contains("sticky")) {
            stickyElem.classList.remove("sticky");
        }
    }
}

<<<<<<< HEAD
function updateTextInput(val) {
    document.getElementById('textInputHour').value=val; 
  }
function updateTextInput2(val) {
    document.getElementById('textInputPerson').value=val; 
  }
=======
function makeSelection(target) {
    if (!target.classList.contains("taken-table")) {
        target.classList.toggle("selected-table");
    }
}
>>>>>>> 6d243177cf001ed4a32e9f07407b4ec25f13b077
