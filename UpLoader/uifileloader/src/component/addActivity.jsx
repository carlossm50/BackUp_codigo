import React from 'react';
import { useState } from 'react'
import axios from 'axios'
import {ToastContainer,toast } from 'react-toastify';


function FormFiles() {

  /*Uso de Hook para definir los estado*/
  var [list, setList] = useState([]);
  var [actNameValue, setActNameValue] = useState("");
  var [responsableValue, setResponsableValue] = useState("");
  var [descriptionValue, setDescriptionValue] = useState("");
  var [dateValue, setDateValue] = useState("");
  var [disabledValue, setDisabledValue] = useState(true);



  /* Evento para los inputs. Identifica el por el nombre input que llama el evento 
     y asigna valor con la funcion declarada en el Hook useState mas arriba  */

  const chanceValue = (e) => {
    switch (e.target.name) {
      case 'actName': { setActNameValue(e.target.value); break; }
      case 'responsable': { setResponsableValue(e.target.value); break; }
      case 'description': { setDescriptionValue(e.target.value); break; }
      case 'date': { setDateValue(e.target.value); break; }
    };

    /* Se hace la validacion de lon input con JavaScript puro para cambiar el estado para la propiedad Disable (truo o false) del boton enviar. 
       Cuando se intentó hacer con el valor de los estado no funcionno como se esperaba */
    if (document.getElementById('idName').value !== '' && document.getElementById('idResponsable').value !== '' &&
        document.getElementById('idDesciption').value !== '' && document.getElementById('idDate').value !== '') {
        document.getElementById('formAct').className = 'was-validated';//Se agreaga la clase was-validated por codigo para que el form no se muestre desde el inicio con las alerta en rojo de no validado
        setDisabledValue(false);
    } else setDisabledValue(true);
  };

  const fileChange = (e) => {
    var list = []
    var key = 0;
    for (var i of e.target.files) {
      list.push(<div key={key++}>{i.name}</div>)
    }
    setList(list);
  }

  const submit = (e) => {
    e.preventDefault();
    const formdata = new FormData(e.target);

    /*Llamada a la API */
    axios({
      method: 'post',
      url: 'http://10.0.0.11:4000/addActivity',
      data: formdata
    })
      .then(data => {
        /*Linpiar los valores del  formulario*/
        setActNameValue("");
        setResponsableValue("");
        setDescriptionValue("");
        setDateValue("");
        setList([]);
        setDisabledValue(true);
        var input = document.getElementById("idEvidencia");
        input.value = '';
        document.getElementById('formAct').className = ''; //Se elimina la clase was-validated por codigo para que el form no se muestre desde el inicio con las alerta en rojo de no validado
        toast.success("Data was added sucessfoly! ",{position: toast.POSITION.TOP_CENTER});
      });


  }
  return (
    <div className="container">
      <form onSubmit={(e) => { submit(e) }} action="/" method="post" encType="multipart/form-data" className='' id='formAct'>
        <label htmlFor="idName">Nombre de la actividad:</label>
        <input id="idName" type="input" name="actName" placeholder="Actividad" className="form-control" value={actNameValue} onChange={(e) => chanceValue(e)} required></input><br />

        <label htmlFor="idResponsable">Responsable:</label>
        <input id="idResponsable" type="text" name="responsable" placeholder="Responsable" className="form-control" value={responsableValue} onChange={(e) => chanceValue(e)} required></input><br />

        <label htmlFor="idDesciption">Descipción de la actividad:</label>
        <textarea id="idDesciption" name="description" rows="4" cols="50" className="form-control" value={descriptionValue} onChange={(e) => chanceValue(e)} required>
        </textarea><br />
        <label htmlFor="idDate"> Fecha en que se realizó la actividad:</label>
        <input id="idDate" type="date" name="date" className="form-control" value={dateValue} onChange={(e) => chanceValue(e)} required /><br />
        <label htmlFor="idEvidencia">Evicencias:</label>
        <input id="idEvidencia" type="file" name="myFile" className="form-control" onChange={(e) => fileChange(e)} multiple /><br />
        <ul>
          {list}
        </ul>
        <input id='button' className="btn btn-warning" type="submit" value="Enviar" data-bs-dismiss='modal' disabled={disabledValue}></input>
      </form>
      <ToastContainer/>
    </div>
  );
}

export default FormFiles;