var bookContainer = document.getElementById('book-info')
var btn = document.getElementById('btn');


btn.addEventListener("click", function (){
    var ourRequest = new XMLHttpRequest();
    ourRequest.open('GET', 'https://www.googleapis.com/books/v1/volumes?q=$' + document.getElementById('books').value);
    ourRequest.onload = function () {
        var ourData = JSON.parse(ourRequest.responseText);
        console.log(ourData)
        renderHTML(ourData);
        var btn2 = document.getElementById('btn2');
        btn2.addEventListener("click", function () {
            bookContainer.innerHTML = "";
            document.getElementById('title').value = ourData.items[0].volumeInfo.title;
            document.getElementById('author').value = ourData.items[0].volumeInfo.authors[0];
        });
        var btn3 = document.getElementById('btn3');
        btn3.addEventListener("click", function () {
            bookContainer.innerHTML = "";
        });
    }
ourRequest.send();
});

function renderHTML(data) {
    bookContainer.innerHTML = "";
    if (data.items[0].volumeInfo.imageLinks.hasOwnProperty('thumbnail')) {
        var thumbnail = data.items[0].volumeInfo.imageLinks.thumbnail;
    } else {
        var thumbnail = "";
    }
    if (data.items[0].volumeInfo.hasOwnProperty('title')) {
        var title = data.items[0].volumeInfo.title;
    }
    else {
        var title = "";
    }
    if (data.items[0].volumeInfo.hasOwnProperty('authors')) {
        var author = data.items[0].volumeInfo.authors[0];
    }
    else {
        var author = "";
    }
    if (data.items[0].volumeInfo.hasOwnProperty('description')) {
        var description = data.items[0].volumeInfo.description;
    }
    else {
        var description = ""
    }

    var htmlString = "</br><div style='padding-left: 170px'><img src="
        + thumbnail + "></div><div style='padding-left:  110px'><strong>Title: </strong>"
        + title + "</div><div style='padding-left: 110px'><strong>Author: </strong>"
        + author + "</div><div style='padding-left: 110px'style ='border: 1px solid black;'><strong>Description: </strong>"
        + description +
        "</div><div style='padding-left: 110px'><button id=btn2 class='btn btn-default btn-md' ><strong>Use book information</strong></button>" +
        "<button id=btn3 class='btn btn-default btn-md' ><strong>Enter Manually</strong></button></div>";
    console.log(htmlString)
    bookContainer.insertAdjacentHTML('beforeend', htmlString)

}