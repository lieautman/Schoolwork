import "./App.css"
import React, { useEffect, useState } from 'react';
import { useSelector, shallowEqual, useDispatch } from 'react-redux';
import * as actions from '../actions';


const spacecraftListSelector=(state)=>state.spacecraft.spacecraftList;
const errorMessageSelector=(state)=>state.spacecraft.error;

const astronautListSelector=(state)=>state.astronaut.astronautList;
const errorMessageSelectorAstronaut=(state)=>state.astronaut.error;


function App() {
  const spacecraftList = useSelector(spacecraftListSelector, shallowEqual);
  const errorMessage = useSelector(errorMessageSelector, shallowEqual);

  const astronautList = useSelector(astronautListSelector, shallowEqual);
  const errorMessageAstronaut = useSelector(errorMessageSelectorAstronaut, shallowEqual);




  const [idSpacecraft, setIdSpacecraft] = useState('');
  const [numeSpacecraft, setNumeSpacecraft] = useState('');
  const [vitezaMaximaSpacecraft, setVitezaMaximaSpacecraft] = useState(0);
  const [masaSpacecraft, setMasaSpacecraft] = useState(0);


  const dispatch=useDispatch()

  function createSpacecraft() {
    dispatch(
      actions.spacecraftActions.postSpacecraft(idSpacecraft, numeSpacecraft, vitezaMaximaSpacecraft, masaSpacecraft)
    );
  }

  function deleteSpacecraft(idSpacecraftDelete) {
    dispatch(
      actions.spacecraftActions.destroySpacecraft(idSpacecraftDelete)
    );
  }

  useEffect(()=>{
    dispatch(actions.spacecraftActions.getSpacecraft())
  },[dispatch])
  function afisareListaSpacecraft() {
    if (spacecraftList !== undefined)
      return spacecraftList.map((e) => (
        <div key={e.id}>
           <br/>
          Spacecraft id:{e.id};<br/>
          Spacecraft name: {e.nume};<br/>
          Spacecraft viteza maxima: {e.vitezaMaxima};<br/>
          Spacecraft masa: {e.masa};<br/>
          <input type='button' value='edit' onClick={()=>setIdSpacecraftUpdateSelectat(e.id)}></input>
          <input type='button' value='delete' onClick={()=>deleteSpacecraft(e.id)}></input>
          <input type='button' value='Arata astronauti' onClick={()=>{setBoolArataAstronauti(true);setIdSpacecraftPtAstronatui(e.id);dispatch(actions.astronautActions.getAstronaut(e.id))}}></input>
        </div>
      ));
    else return null;
  }

  const [idSpacecraftUpdateSelectat, setIdSpacecraftUpdateSelectat] = useState('');
  const [numeSpacecraftUpdate, setNumeSpacecraftUpdate] = useState('');
  const [vitezaMaximaSpacecraftUpdate, setVitezaMaximaSpacecraftUpdate] = useState(0);
  const [masaSpacecraftUpdate, setMasaSpacecraftUpdate] = useState(0);

  function updateSpacecraft(){
    dispatch(
      actions.spacecraftActions.putSpacecraft(idSpacecraftUpdateSelectat,numeSpacecraftUpdate,vitezaMaximaSpacecraftUpdate,masaSpacecraftUpdate)
    );
  }

  function showErrorMessage(){
    if(errorMessage==null)
      return null;
    else{
      return <><br/>{errorMessage.message}</>
    }
  }



  const [idAstronaut, setIdAstronaut] = useState('');
  const [numeAstronaut, setNumeAstronaut] = useState('');
  const [rolAstronaut, setRolAstronaut] = useState('COMMANDER');

  function createAstronaut(idSpacecraftPtAstronatui,idAstronaut,numeAstronaut,rolAstronaut) {
    dispatch(
      actions.astronautActions.postAstronaut(idSpacecraftPtAstronatui, idAstronaut, numeAstronaut, rolAstronaut)
    );
  }

  const [idAstronautUpdateSelectat, setIdAstronautUpdateSelectat] = useState(0);
  const [numeAstronautUpdate, setNumeAstronautUpdate] = useState('');
  const [rolAstronautUpdate, setRolAstronautUpdate] = useState('COMMANDER');
  function updateAstronaut(){
    dispatch(
      actions.astronautActions.putAstronaut(idSpacecraftPtAstronatui,idAstronautUpdateSelectat, numeAstronautUpdate, rolAstronautUpdate)
    );
  }

  function deleteAstronaut(idAstronautDel){
    dispatch(
      actions.astronautActions.destroyAstronaut(idSpacecraftPtAstronatui,idAstronautDel)
    );
  }

  function showErrorMessageAstronaut(){
    if(errorMessageAstronaut==null)
      return null;
    else{
      return <><br/>{errorMessageAstronaut.message}</>
    }
  }
  const [idSpacecraftPtAstronatui, setIdSpacecraftPtAstronatui] = useState(0);
  const [boolArataAstronauti, setBoolArataAstronauti] = useState(false);
  function arataAstronauti(){
    if(boolArataAstronauti==false)
      return null;
    else{
      return (      
      <div className="grid-item">
        <p>Id spacecraft este:{idSpacecraftPtAstronatui}</p>
        <input type='button' value='Cancel' onClick={()=>{setBoolArataAstronauti(false);setIdSpacecraftPtAstronatui(0)}}></input>
        <h1>Creaza un astronaut</h1>
        <div>
          <p>id astronaut</p>
          <input type="text" onChange={(evt)=>setIdAstronaut(evt.target.value)}></input>
          <p>nume astronaut</p>
          <input type="text" onChange={(evt)=>setNumeAstronaut(evt.target.value)}></input>
          <p>rol astronaut</p>
          <select name="cars" onChange={(evt)=>setRolAstronaut(evt.target.value)}>
            <option value="COMMANDER">COMMANDER</option>
            <option value="PILOT">PILOT</option>
            <option value="GUNNER">GUNNER</option>
          </select>

          <input type="button" value="create" onClick={()=>createAstronaut(idSpacecraftPtAstronatui,idAstronaut,numeAstronaut,rolAstronaut)}></input>
          {showErrorMessageAstronaut()}
        </div>
        <h1>Lista astronaut</h1>
        {afisareListaAstronaut()}
        {showErrorMessageAstronaut()}
        <h1>Selecteaza o nava si apoi editeaza-i caracteristicile mai jos {idAstronautUpdateSelectat}</h1>
        <div>
          <p>nume astronaut</p>
          <input type="text"onChange={(evt)=>setNumeAstronautUpdate(evt.target.value)}></input>
          <p>rol astronaut</p>
          <select name="cars" onChange={(evt)=>setRolAstronautUpdate(evt.target.value)}>
            <option value="COMMANDER">COMMANDER</option>
            <option value="PILOT">PILOT</option>
            <option value="GUNNER">GUNNER</option>
          </select>
          <input type="button" value="update" onClick={()=>updateAstronaut()}></input>
        </div>
      </div>
      )
    }
  }

  function afisareListaAstronaut() {
    if (astronautList !== undefined)
      return astronautList.map((e) => (
        <div key={e.id}>
           <br/>
          Astronaut id:{e.id};<br/>
          Astronaut name: {e.nume};<br/>
          Astronaut role: {e.rol};<br/>
          <input type='button' value='edit' onClick={()=>setIdAstronautUpdateSelectat(e.id)}></input>
          <input type='button' value='delete' onClick={()=>deleteAstronaut(e.id)}></input>

        </div>
      ));
    else return null;
  }


  function exportDB(){
    dispatch(actions.spacecraftActions.exportDB())
  }


  function importDB(DB){
    if (DB.files.length > 0){
      var result;
      let reader = new FileReader();
      reader.addEventListener('load', function() {
        result = JSON.parse(reader.result);
        dispatch(actions.spacecraftActions.importDB(result))
      })
      reader.readAsText(DB.files[0]);
      
    }
  }




  return (
    <div className="grid-container">
      <div className="grid-item">
        <input type='button' value='export' onClick={()=>exportDB()}></input>
        <input type='file' onChange={(evt)=>importDB(evt.target)}></input>
        <h1>Creaza un spaceship</h1>
        <div>
          <p>id spaceship</p>
          <input type="text" onChange={(evt)=>setIdSpacecraft(evt.target.value)}></input>
          <p>nume spaceship</p>
          <input type="text"onChange={(evt)=>setNumeSpacecraft(evt.target.value)}></input>
          <p>viteza maxima spaceship</p>
          <input type="number"onChange={(evt)=>setVitezaMaximaSpacecraft(evt.target.value)}></input>
          <p>masa spaceship</p>
          <input type="number"onChange={(evt)=>setMasaSpacecraft(evt.target.value)}></input>
          <input type="button" value="create" onClick={()=>createSpacecraft()}></input>
          {showErrorMessage()}
        </div>
        <h1>Lista spaceship</h1>
        {afisareListaSpacecraft()}
        {showErrorMessage()}
        <h1>Selecteaza o nava si apoi editeaza-i caracteristicile mai jos {idSpacecraftUpdateSelectat}</h1>
        <div>
          <p>nume spaceship</p>
          <input type="text"onChange={(evt)=>setNumeSpacecraftUpdate(evt.target.value)}></input>
          <p>viteza maxima spaceship</p>
          <input type="number"onChange={(evt)=>setVitezaMaximaSpacecraftUpdate(evt.target.value)}></input>
          <p>masa spaceship</p>
          <input type="number"onChange={(evt)=>setMasaSpacecraftUpdate(evt.target.value)}></input>
          <input type="button" value="update" onClick={()=>updateSpacecraft()}></input>
        </div>
        {showErrorMessage()}
      </div>

      {arataAstronauti()}

      <a id="downloadAnchorElem"></a>
    </div>
  );
}

export default App;
