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

    
    let date = new Date();
    let dia=date.getDate();
    let mes=date.getMonth() +1;
    let anio=date.getFullYear();
    console.log(dia);
    console.log(mes);
    console.log(anio);

    boton.disabled = true;
    if(name.value.trim()==""){
        name.style.border="2px red solid";
    }else{
        name.style.border="1px red black";
    }

    if(lastName.value.trim()==""){
        lastName.style.border="2px red solid";
    }else{
        lastName.style.border="1px red black";
    }

    if(business.value.trim()==""){
        business.style.border="2px red solid";
    }else{
        business.style.border="1px red black";
    }
}

recargar=(e)=>{
    event.preventDefault();
    window.location.reload()
}