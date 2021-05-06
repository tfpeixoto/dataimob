
//////// BUSCANDO ENDEREÇO
// getting all required elements
const searchWrapper = document.querySelector(".search-input");
const inputBox = searchWrapper.querySelector("input");
const suggBox = searchWrapper.querySelector(".autocom-box");
const icon = searchWrapper.querySelector(".icon");
let linkTag = searchWrapper.querySelector("a");
let webLink;

$(document).ready(function () {
  
    $.ajax({

        url: "/Home/Enderecos",
        method: "GET",

   
        success: function (data) {
           
            suggestions = [];
            for (var i = 0; i < data.length; i++) {
                if (data[i].labelfind!=null) {
                    suggestions.push({ label: (data[i].nome + " - " + data[i].cidade + " - " + data[i].uf ), labelfind: (data[i].labelfind) });
                }
               // console.log(suggestions[i]);
            }

         },
        error: function (err) {
            console.log(err);
        }
    })

});


// if user press any key and release
inputBox.onkeyup = (e) => {
      
    let userData = e.target.value; //user enetered data
    let emptyArray = [];
    if(userData){
        //icon.onclick = ()=>{
        //    webLink = "https://www.google.com/search?q=" + userData;
        //    linkTag.setAttribute("href", webLink);
        //    console.log(webLink);
        //    linkTag.click();
        //}
        emptyArray = suggestions.filter((data) => {
            //filtering array value and user characters to lowercase and return only those words which are start with user enetered chars
            let string = userData.toLocaleLowerCase().replace(',', '')
             return data.labelfind.toLocaleLowerCase().startsWith(string);

        });
 



        emptyArray = emptyArray.map((data)=>{
            // passing return data inside li tag
            return data = '<li>' + data.label + '</li>';
        });
        searchWrapper.classList.add("active"); //show autocomplete box
        showSuggestions(emptyArray);
        let allList = suggBox.querySelectorAll("li");
        for (let i = 0; i < allList.length; i++) {
            //adding onclick attribute in all li tag
            allList[i].setAttribute("onclick", "select(this)");
        }
    }else{
        searchWrapper.classList.remove("active"); //hide autocomplete box
    }
}

function select(element){
    let selectData = element.textContent;
    inputBox.value = selectData;

    //CLICA NO BUSCAR
    //icon.onclick = ()=>{
    //webLink = "https://www.google.com/search?q=" + selectData;
    //linkTag.setAttribute("href", webLink);
    //linkTag.click();
    //}

    searchWrapper.classList.remove("active");
}

function showSuggestions(list) {
  
    let listData;
    if(!list.length){
        userValue = inputBox.value;
        listData = '<li>'+ userValue +'</li>';
    }else{
        listData = list.join('');
    }
    suggBox.innerHTML = listData;
}