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