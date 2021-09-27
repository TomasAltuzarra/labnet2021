function validateForm() {
    let nombre = document.forms["formulario"]["name"].value;
    let apellido = document.forms["formulario"]["surname"].value;
    if (nombre == "" || apellido == "") {
      alert("Los campos Nombre y Apellido son obligatorios");
      return false;
    }
  };
  
function clearForm() {
    document.getElementById("formulario").reset();
};
