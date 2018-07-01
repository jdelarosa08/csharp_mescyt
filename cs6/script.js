// this get the number of rows in the table then this number is assigned to the ID input. 
function getId(table){
    var idValue = document.getElementById(table).rows.length;
    document.getElementById("id").value = idValue;
}


//Show the modal
var mostrarModal = function () {
    $('.modal').modal('show');
    getId('tabla')
}


//this add the row with all her cells
var agregarTodo = function () {

    var id = $('#id').val();
    var todo = $('#todo').val();
    var done = $('#done').is(':checked');

    // CELL ID
    tr = document.createElement('tr');
    td = document.createElement('th');
    td.innerText = id;
    tr.appendChild(td);

    // CELL TODO
    td = document.createElement('td');
    td.innerText = todo;
    tr.appendChild(td);

    //CELL Created
    td = document.createElement('td');
    var currentdate = new Date();
    var datetime = currentdate.getDate() + "/"
                + (currentdate.getMonth()+1)  + "/" 
                + currentdate.getFullYear();
    td.innerText = datetime
    tr.appendChild(td);

    //CELL Complete
    td = document.createElement('td');
    badge = document.createElement('span');
    badge.setAttribute('class', 'badge badge-warning');
    badge.innerText = 'pending';
    td.appendChild(badge);
    tr.appendChild(td);

    //CELL Done
    td = document.createElement('td');
    checkbox = document.createElement('input');
    checkbox.setAttribute('type', 'checkbox');
    checkbox.setAttribute('onclick','updateDone(this)')
    td.appendChild(checkbox);
    tr.appendChild(td);

    //CELL ACTION
    td = document.createElement('td');
    btn = document.createElement('button');
    btn.setAttribute('onclick', 'borrarFila(this)');
    btn.setAttribute('class', 'btn btn-danger btn-sm');
    btn.innerHTML = 'delete';
    td.appendChild(btn);
    tr.appendChild(td);
    
    //Create the row her cells in the table
    tabla = document.getElementById('tabla');
    tabla.appendChild(tr);
    
    //Clean the input
    limpiar();
    
}


//this delete a row
function borrarFila(btn) {
    fila = btn.parentNode.parentNode;
    if (confirm('Desea borrar este registro?')) {
        fila.parentNode.removeChild(fila);
    }

}


//this clean the inputs 
function limpiar() {
    $('#id').val("");
    $('#todo').val("");
    getId('tabla')
}



//this update the Checkbox in the column Done
function updateDone(x){
    tr = x.parentNode.parentNode;
    complete = tr.getElementsByClassName('badge');
    console.log(complete)

    if (complete[0].className != 'badge badge-success') {
        complete[0].setAttribute('class', 'badge badge-success');
        complete[0].innerText = 'complete';
    }
    else
    {
        complete[0].setAttribute('class', 'badge badge-warning');
        complete[0].innerText = 'pending';
    }
}
