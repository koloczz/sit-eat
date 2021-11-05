function showModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "block";
}

function closeModal(element) {
    if (element.classList.contains("modal") || element.classList.contains("close")) {
        var modal = document.getElementById("myModal");
        modal.style.display = "none";
    }
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

function updateTextInput(val) {
    document.getElementById('textInputHour').value=val; 
  }

function updateTextInput2(val) {
    document.getElementById('textInputPerson').value=val; 
  }

function makeSelection(target) {
    if (!target.classList.contains("taken-table")) {
        target.classList.toggle("selected-table");
    }
}

function changeTheme() {
    var root = document.querySelector(":root");
    var randomColor = Math.floor(Math.min(Math.random(), 0.9)*16777215).toString(16);
    root.style.setProperty("--main-background-color", "#" + randomColor);
}
