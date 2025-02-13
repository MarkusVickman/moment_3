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

    // loopar igenom alla rader i tabellen förutom head. 
    for (i = 1; i < tr.length; i++) {
        //bool för att bestämma om värdet hittades eller ej
        let rowFind = false;

        //För varje rad går nästa loop igenom alla kollumner
        td = tr[i].getElementsByTagName("td");
        for (j = 0; j < td.length -1; j++) {

            //Om kollumenen innehåller sökfras ändras rowFind till true
            if (td[j]) {
                txtValue = td[j].textContent || td[j].innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    rowFind = true;
                    break; // Avbryt loopen om ett matchande värde hittas
                }
            }
        }

        //Om sökfrasen hittades visas raden om inte ändras display til none.
        if (rowFind) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}