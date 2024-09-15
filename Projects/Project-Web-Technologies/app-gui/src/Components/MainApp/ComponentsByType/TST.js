import React, { useEffect, useState } from 'react';
import './TST.css';
//iau starea redux
import { useSelector, shallowEqual, useDispatch } from 'react-redux';
import * as actions from './../../../States/Actions';

//preiau date din stare
const idSelector = (state) => state.main.id;
const tokenSelector = (state) => state.main.token;
const typeSelector = (state) => state.main.type;
const projectListSelector = (state) => state.project.projectList;
const bugListSelector = (state) => state.bug.bugList;
const personalBugListSelector = (state) => state.bug.perosnalBugList;
const createErrorSelector = (state) => state.bug.error;

function USER_TST() {
  //dispatch pentru celelalte componente
  const dispatch = useDispatch();
  //preiau date din stare
  const id = useSelector(idSelector, shallowEqual);
  const token = useSelector(tokenSelector, shallowEqual);
  const type = useSelector(typeSelector, shallowEqual);
  const projectList = useSelector(projectListSelector, shallowEqual);
  const bugList = useSelector(bugListSelector, shallowEqual);
  const personalBugList = useSelector(personalBugListSelector, shallowEqual);
  const createError = useSelector(createErrorSelector, shallowEqual);

  //reducer pt proiecte
  useEffect(() => {
    dispatch(actions.projectActions.getProjects());
    dispatch(actions.bugActions.getBugs());
    dispatch(actions.bugActions.getPersonalBugs(type, token));
  }, [dispatch, type, token]);
  //functii de afisare
  function afisareListaProiecte() {
    if (projectList !== undefined)
      return projectList.map((e) => desenareComenziProiect(e));
    else return null;
  }

  //functie de desenare comenzi pt adaugare bug
  function desenareComenziProiect(proiect) {
    return (
      <div key={proiect.id} id='proiectTST'>
        Project name: {proiect.nume}
        <br></br> Link:{proiect.linkRepo}
        <input
          className='btnTST'
          type='button'
          value='Add bug'
          onClick={() => adaugaBug(proiect)}
        ></input>
        <input
          className='btnTST'
          type='button'
          value='View bugs'
          onClick={() => afisazaBug(proiect)}
        ></input>
        <input
          className='btnTST'
          type='button'
          value='View personal bugs'
          onClick={() => afisazaPersonalBug(proiect)}
        ></input>
      </div>
    );
  }

  //variabile locale
  const [severitateBug, setSeveritateBug] = useState('');
  const [prioritateBug, setPrioritateBug] = useState('');
  const [descriereBug, setDescriereBug] = useState('');
  const [severitateBugUpdate, setSeveritateBugUpdate] = useState('');
  const [prioritateBugUpdate, setPrioritateBugUpdate] = useState('');
  const [descriereBugUpdate, setDescriereBugUpdate] = useState('');

  function createBug() {
    dispatch(
      actions.bugActions.createBug(
        severitateBug,
        prioritateBug,
        descriereBug,
        id,
        proiectPentruBug.id,
        type,
        token
      )
    );
  }
  //afisaza update
  const [isHiddenUpdate, setIsHiddenUpdate] = useState(true);
  const [bugDeActualizat, setBugDeActualizat] = useState();
  function editBug(bug) {
    setIsHiddenUpdate(!isHiddenUpdate);
    setBugDeActualizat(bug);
  }
  function showEditScreen(bug) {
    if (isHiddenUpdate === true) {
      return null;
    } else {
      return (
        <form id='editeazaBugForm'>
          <h4>
            Edit the bug with severity: {bug.severity}, priority: {bug.priority}
            , description: {bug.description} and the link: {bug.link}
          </h4>

          <br></br>
          <input
            className='inputUpdate'
            type='text'
            placeholder='Add new severity'
            onChange={(evt) => setSeveritateBugUpdate(evt.target.value)}
          />
          <input
            className='inputUpdate'
            type='text'
            placeholder='Add new priority'
            onChange={(evt) => setPrioritateBugUpdate(evt.target.value)}
          />
          <input
            className='inputUpdate'
            type='text'
            placeholder='Add new description'
            onChange={(evt) => setDescriereBugUpdate(evt.target.value)}
          />
          <input
            id='btnUpdateBug'
            type='button'
            value='Update'
            onClick={() => updateBug(bug)}
          ></input>
        </form>
      );
    }
  }
  function updateBug(bug) {
    dispatch(
      actions.bugActions.updateBug(
        bug.id,
        severitateBugUpdate,
        prioritateBugUpdate,
        descriereBugUpdate,
        bug.link,
        id,
        bug.idOfProject,
        type,
        token
      )
    );
  }
  function deleteBug(idBug) {
    dispatch(actions.bugActions.deleteBug(idBug, type, token));
  }
  //afisare comenzi pentru adaugare de bug pe un proiect
  const [isHiddenAddBug, setIsHiddenAddBug] = useState(true);
  const [proiectPentruBug, setProiectPentruBug] = useState(null);
  function adaugaBug(proiect) {
    setProiectPentruBug(proiect);
    setIsHiddenAddBug(!isHiddenAddBug);
  }
  function showAdaugaBug(proiect) {
    if (isHiddenAddBug === true) {
      return null;
    } else {
      return (
        <form id='formAdauga'>
          <h4>
            Add bug at the project: {proiect.nume} and the link:{' '}
            {proiect.linkRepo}
          </h4>
          <br></br>
          <input
            className='inputAdauga'
            type='text'
            placeholder='Add bug severity'
            onChange={(evt) => setSeveritateBug(evt.target.value)}
          />
          <input
            className='inputAdauga'
            type='text'
            placeholder='Add bug priority'
            onChange={(evt) => setPrioritateBug(evt.target.value)}
          />
          <input
            className='inputAdauga'
            type='text'
            placeholder='Add bug description'
            onChange={(evt) => setDescriereBug(evt.target.value)}
          />
          <input
            type='button'
            value='Add bug'
            onClick={createBug}
            id='btnAdaugaBug'
          ></input>
          {createError}
        </form>
      );
    }
  }

  //afisare lista bug-uri pentru un proiect
  const [isHiddenDisplayBugs, setIsHiddenDisplayBugs] = useState(true);
  const [proiectPentruDisplayBug, setProiectPentruDisplayBug] = useState(null);
  function afisazaBug(proiect) {
    setProiectPentruDisplayBug(proiect);
    setIsHiddenDisplayBugs(!isHiddenDisplayBugs);
  }
  function showAfisazaListaBugs(proiect) {
    if (isHiddenDisplayBugs === true) {
      return null;
    } else {
      return (
        <form id='listaBugProiect'>
          <h3>List of bugs for the project {proiect.nume}:</h3>
          <div>{afisareListaBuguri(proiect)}</div>
        </form>
      );
    }
  }
  function afisareListaBuguri(proiect) {
    if (bugList !== undefined)
      return bugList.map((e) => desenareDisplayBug(proiect, e));
    else return null;
  }
  function desenareDisplayBug(proiect, bug) {
    if (bug.idOfProject === proiect.id)
      return (
        <div key={bug.id} id='proprietatiBug'>
          Bug severity: {bug.severity}
          <br></br> Bug priority: {bug.priority}
          <br></br>
          Bug description: {bug.description}
          <br></br> Link with the solution: {bug.link}
        </div>
      );
    else return null;
  }

  //afisare lista bug-uri pentru un proiect
  const [isHiddenDisplayPersonalBugs, setIsHiddenDisplayPersonalBugs] =
    useState(true);
  const [proiectPentruDisplayPersonalBug, setProiectPentruDisplayPersonalBug] =
    useState(null);
  function afisazaPersonalBug(proiect) {
    setProiectPentruDisplayPersonalBug(proiect);
    setIsHiddenDisplayPersonalBugs(!isHiddenDisplayPersonalBugs);
  }
  function showAfisazaListaPersonalBugs(proiect) {
    if (isHiddenDisplayPersonalBugs === true) {
      return null;
    } else {
      return (
        <form id='listaBugsPersonale'>
          <h4>List of personal bugs for the project {proiect.nume} is:</h4>
          {afisareListaPersonalBuguri(proiect)}
        </form>
      );
    }
  }
  function afisareListaPersonalBuguri(proiect) {
    if (personalBugList !== undefined)
      return personalBugList.map((e) => desenareDisplayPersonalBug(proiect, e));
    else return null;
  }
  function desenareDisplayPersonalBug(proiect, bug) {
    if (bug.idOfProject === proiect.id)
      return (
        <div key={bug.id} id='bugPersonal'>
          <div>
            Bug severity: {bug.severity}
            <br></br> Bug priority: {bug.priority}
            <br></br> Bug description: {bug.description}
            <br></br> Link: {bug.link}
          </div>
          <input
            id='btnEditeaza'
            type='button'
            value='Edit'
            onClick={() => editBug(bug)}
          ></input>
          <input
            id='btnSterge'
            type='button'
            value='Delete'
            onClick={() => deleteBug(bug.id)}
          ></input>
        </div>
      );
    else return null;
  }

  return (
    <>
      {/* min-height 1000px */}
      <div id='listaProiecteDiv'>
        {/* margin-top 50px */}
        <h2 id='listaproiecteHeader'>List of all projects:</h2>
        {afisareListaProiecte()}
      </div>
      <div>{showAdaugaBug(proiectPentruBug)}</div>

      <div>{showAfisazaListaBugs(proiectPentruDisplayBug)}</div>
      <div>{showAfisazaListaPersonalBugs(proiectPentruDisplayPersonalBug)}</div>
      <div>{showEditScreen(bugDeActualizat)}</div>
    </>
  );
}

export default USER_TST;
