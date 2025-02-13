// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function searchTable() {
    var input;
    var filter;
    var table;
    var tr;
    var td;
    var i;
    var txtValue;

    input = document.getElementById("searchInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("table");
    tr = table.getElementsByTagName("tr");

    // Loop through all table rows, and hide those who don't match the search query
    for (i = 1; i < tr.length; i++) { // Börja från 1 för att hoppa över tabellhuvudet
        let rowFind = false;

        td = tr[i].getElementsByTagName("td");
        for (j = 0; j < td.length -1; j++) {
            if (td[j]) {
                txtValue = td[j].textContent || td[j].innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    rowFind = true;
                    break; // Avbryt loopen om ett matchande värde hittas
                }
            }
        }

        if (rowFind) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}