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

function instantShow() {
    var modal = document.getElementById("myModal");
    modal.style.display = "block";
}

function toggleReservationButtons() {
    var saveButton = document.getElementById("saveButton");
    saveButton.disabled = false;
    var reservationButton = document.getElementById("reservationButton");
    reservationButton.disabled = true;
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
    var desired = document.getElementById("filterPersonCount").value;
    var chosen = document.getElementsByClassName("selected-table");
    var button = document.getElementById("reservationButton");
    var sum = 0;
    for (var i = 0; i < chosen.length; i++) {
        sum += parseInt(chosen[i].textContent);
    }
    if (sum >= desired) {
        button.disabled = false;
    }
    else {
        button.disabled = true;
    }
}

function transferData() {
    var hours = document.getElementById("filterHour").value;
    var postHours = document.getElementById("filterHourHidden");
    postHours.value = hours;
    var date = document.getElementById("filterDatefield").value;
    var postDate = document.getElementById("filterDateHidden");
    postDate.value = date;
}

function getAllSelectedTables() {
    transferData();
    var tables = document.getElementsByClassName('selected-table');
    var postInput = document.getElementById('postInput');
    postInput.value = Array.from(tables).map(t => t.id).join('_');
}

function filter(target) {
    var divs = document.getElementsByClassName('content');
    for (var j = 0; j < divs.length; j++) {
        divs[j].style.setProperty("display", "none");
        var temp = divs[j].getElementsByClassName('tag-section')[0];
        if (temp.textContent.includes(target.outerText)) {
            divs[j].style.setProperty("display", "block");
        }
    }
}

function unfilter() {
    var divs = document.getElementsByClassName('content');
    for (var j = 0; j < divs.length; j++) {
        divs[j].style.setProperty("display", "block");
    }
}

function changeTheme() {
    var root = document.querySelector(":root");
    var randomColor = Math.floor(Math.min(Math.random(), 0.9)*16777215).toString(16);
    root.style.setProperty("--main-background-color", "#" + randomColor);
}

function randomCarpetBG(){
    var random= Math.floor(Math.random() * 4) + 0;
    var bigSize = ["url('/img/carpet1.jpg')",
                    "url('/img/carpet2.jpg')",
                    "url('/img/carpet3.jpg')",
                    "url('/img/carpet4.jpg')"];
    var myArr = document.getElementsByClassName("grid-item");
    for (const element of myArr) {
        element.style.backgroundImage=bigSize[random];
    }
  }

//   function randomTableBG(){
//     var random= Math.floor(Math.random() * 6) + 0;
//     var bigSize = ["url('../SitAndEat/Images/wood.jpg')",
//                     "url('../SitAndEat/Images/wood2.jpg')",
//                     "url('../SitAndEat/Images/wood3.jpg')",
//                     "url('../SitAndEat/Images/marble.jpg')"];
//     var myArr = document.getElementsByClassName("with-table");
//     for (const element of myArr) {
//         if (!element.classList.contains("taken-table") && !element.classList.contains("selected-table")){
//             element.style.backgroundImage=bigSize[random];
//         }
//     }
//   }

function LoadDetailPage(restaurantId, isInstantReservation) {
    let textInputHour = document.getElementById("textInputHour");
    let textInputPerson = document.getElementById("textInputPerson");
    let datefield = document.getElementById("datefield");
    window.location.href = `/Restaurant/Details?id=${restaurantId}&filterHour=${textInputHour.value}&filterDate=${datefield.value}&filterPeople=${textInputPerson.value}&isInstantReservationChosen=${isInstantReservation}`;
}

function ReloadDetailPage(restaurantId, isInstantReservation) {
    let textInputHour = document.getElementById("filterHour");
    let textInputPerson = document.getElementById("filterPersonCount");
    let datefield = document.getElementById("filterDatefield");
    window.location.href = `/Restaurant/Details?id=${restaurantId}&filterHour=${textInputHour.value}&filterDate=${datefield.value}&filterPeople=${textInputPerson.value}&isInstantReservationChosen=${isInstantReservation}`;
}

function updateColors(timeStamp) {
    let root = document.querySelector(":root");
	let red = Math.floor(Math.sin(timeStamp*0.0011)*127+127);
	let green = Math.floor(Math.sin(timeStamp*0.0012)*127+127);
	let blue = Math.floor(Math.sin(timeStamp*0.0013)*127+127);
	let alpha = Math.sin(timeStamp*0.0014)*0.25+0.75;
    root.style.setProperty("--main-background-color", "rgba("+red+","+green+","+blue+","+alpha+")");
	
    window.requestAnimationFrame(updateColors);
}
//window.requestAnimationFrame(updateColors);