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
    console.log(formu);
    console.log(name.value);
    console.log(lastName.value);
    console.log(dateOfBirth.value);
    console.log(dateOfBirth);
    console.log(boton);
    console.log("formu");

    //let fechaCompleta=Date.Parse(dateOfBirth.value);
    let fechaCompleta2=(dateOfBirth.value).split("-");;
    //
    //console.log(fechaCompleta);
    console.log("fechas");
    console.log(fechaCompleta2[0]+1);
    console.log(fechaCompleta2[1]+1);
    console.log(fechaCompleta2[2]+1);

    
    let date = new Date();
    let dia=date.getDate();
    let mes=date.getMonth() +1;
    let anio=date.getFullYear();
    console.log(dia+1);
    console.log(mes);
    console.log(anio);

    boton.disabled = true;

    resaltarInput(name);
    resaltarInput(lastName);
    resaltarInput(business);
}

recargar=(e)=>{
    event.preventDefault();
    window.location.reload()
}