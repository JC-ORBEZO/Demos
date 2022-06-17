
resaltarInput=(id)=>{
    if(id.value.trim()==""){
        id.style.border="2px red solid";
    }else{
        id.style.border="1px red black";
    }
}

enviar=(e)=>{
    event.preventDefault();
    let formu=document.getElementById("formulario");
    let name=document.getElementById("name");
    let lastName=document.getElementById("lastName");
    let business=document.getElementById("business");
    let dateOfBirth=document.getElementById("dateOfBirth");    
    let boton=document.getElementById("boton");
    let edad=document.getElementById("edad");

    let fechaCompleta2=(dateOfBirth.value).split("-");;
    
    //console.log(fechaCompleta);
    console.log("fechas");
    console.log(parseInt(fechaCompleta2[0])+1);
    console.log(parseInt(fechaCompleta2[1])+1);
    console.log(parseInt(fechaCompleta2[2])+1);
    var diaIngresado=parseInt(fechaCompleta2[2]);
    var mesIngresado=parseInt(fechaCompleta2[1]);
    var anioIngresado=parseInt(fechaCompleta2[0]);

    //Fecha Actual: Enteros todos
    let dateActual = new Date();
    let diaActual=dateActual.getDate();
    let mesActual=dateActual.getMonth() +1;
    let anioActual=dateActual.getFullYear();
    var edadActual=0;
    if(mesActual>=mesIngresado){         
        if(mesActual==mesIngresado){
            if(diaIngresado>=diaActual){
                edadActual=anioActual-anioIngresado;
                if(diaIngresado==diaActual) edadActual=anioActual-anioIngresado;
            }else{
                edadActual=anioActual-anioIngresado-1;
            }                       
        }else{
            edadActual=anioActual-anioIngresado;
        }               
    }else{
        edadActual=anioActual-anioIngresado-1;
    }

    boton.disabled = true;

    resaltarInput(name);
    resaltarInput(lastName);
    resaltarInput(business);
    resaltarInput(dateOfBirth);
    if(anioIngresado!=0){
        edad.style.visibility="visible";
        edad.textContent="Edad: " + edadActual;
    }
    
    
}

recargar=(e)=>{
    event.preventDefault();
    window.location.reload()
}