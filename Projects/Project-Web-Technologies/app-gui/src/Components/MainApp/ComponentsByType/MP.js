import React, { useEffect, useState } from 'react';
import './MP.css';
//iau starea redux
import { useSelector, shallowEqual, useDispatch } from 'react-redux';
import * as actions from './../../../States/Actions';

//preiau date din stare
const idSelector = (state) => state.main.id;
const tokenSelector = (state) => state.main.token;
const typeSelector = (state) => state.main.type;
const projectListSelector = (state) => state.project.projectList;
const personalProjectListSelector = (state) =>
  state.project.personalProjectList;
const bugListSelector = (state) => state.bug.bugList;

function USER_MP() {
  //dispatch pentru celelalte componente
  const dispatch = useDispatch();
  //preiau date din stare
  const id = useSelector(idSelector, shallowEqual);
  const token = useSelector(tokenSelector, shallowEqual);
  const type = useSelector(typeSelector, shallowEqual);
  const projectList = useSelector(projectListSelector, shallowEqual);
  const personalProjectList = useSelector(
    personalProjectListSelector,
    shallowEqual
  );
  const bugList = useSelector(bugListSelector, shallowEqual);

  //salvam local valorile
  const [linkRepo, setLinkRepo] = useState('');
  const [nume, setNume] = useState('');
  const [linkRepoUpdate, setLinkRepoUpdate] = useState('');
  const [numeUpdate, setNumeUpdate] = useState('');

  //var pentru rezolvare bug
  const [linkBugSolve, setLinkBugSolve] = useState('');

  //reducer pt proiecte
  useEffect(() => {
    dispatch(actions.projectActions.getPersonalProjects(type, token));
    dispatch(actions.projectActions.getProjects());
    dispatch(actions.bugActions.getBugs());
  }, [dispatch, type, token]);
  //functie de afisare proiecte
  function afisareListaProiecte() {
    if (projectList !== undefined)
      return projectList.map((e) => (
        <div key={e.id} id='listaToateProiectele'>
          Project name: {e.nume}; Link: {e.linkRepo}
        </div>
      ));
    else return null;
  }
  //creaza un poriect prin stare, actiune, api in bd
  function createProject() {
    dispatch(
      actions.projectActions.createProject(linkRepo, nume, id, type, token)
    );
  }
  //afisaza update
  const [isHidden, setIsHidden] = useState(true);
  const [proiectDeActualizat, setProiectDeActualizat] = useState(null);
  function editProject(proiect) {
    setIsHidden(!isHidden);
    setProiectDeActualizat(proiect);
  }
  function showEditScreen(proiect) {
    if (isHidden === true) {
      return null;
    } else {
      return (
        <form id='formularEditareMP'>
          Edit project: {proiect.nume} at the link: {proiect.linkRepo}.<br></br>
          <input
            className='inputEdit'
            type='text'
            placeholder='Link'
            onChange={(evt) => setLinkRepoUpdate(evt.target.value)}
          />
          <input
            className='inputEdit'
            type='text'
            placeholder='Name'
            onChange={(evt) => setNumeUpdate(evt.target.value)}
          />
          <input
            id='btnEditeazaProiect'
            type='button'
            value='Modify'
            onClick={() => updateProject(proiect.id)}
          ></input>
        </form>
      );
    }
  }
  //update un poriect prin stare, actiune, api in bd
  function updateProject(idProiect) {
    dispatch(
      actions.projectActions.updateProject(
        idProiect,
        linkRepoUpdate,
        numeUpdate,
        id,
        type,
        token
      )
    );
    setIsHidden(true);
  }
  //sterge un poriect prin stare, actiune, api in bd
  function deleteProject(idProiect) {
    setIsHidden(true);
    dispatch(actions.projectActions.deleteProject(idProiect, type, token));
  }
  //functie de creare obiect personal editabil si eliminabil
  function desenareObiectPersonal(proiect) {
    return (
      <div key={proiect.id} id='listaProiectePersonale'>
        <div>
          Project name: {proiect.nume}; Link: {proiect.linkRepo}
        </div>
        <input
          className='btnListaMP'
          type='button'
          value='Edit'
          onClick={() => editProject(proiect)}
        ></input>
        <input
          className='btnListaMP'
          type='button'
          value='Delete'
          onClick={() => deleteProject(proiect.id)}
        ></input>
        <input
          className='btnListaMP'
          type='button'
          value='Display bug list'
          onClick={() => displayBugs(proiect)}
        ></input>
      </div>
    );
  }
  //functie de afisare proiecte personale
  function afisareListaProiectePerosnale() {
    if (personalProjectList !== undefined)
      return personalProjectList.map((e) => desenareObiectPersonal(e));
    else return null;
  }

  //afisare lista de bug-uri
  const [isHiddenDisplayBugs, setIsHiddenDisplayBugs] = useState(true);
  const [proiectDisplayBugs, setProiectDisplayBugs] = useState(null);
  function displayBugs(proiect) {
    setIsHiddenDisplayBugs(!isHiddenDisplayBugs);
    setProiectDisplayBugs(proiect);
  }
  function showDisplayBug(proiect) {
    if (isHiddenDisplayBugs === true) {
      return null;
    } else {
      return (
        <form id='formBugs'>
          List of bugs for the project: {proiect.nume}
          <br></br>
          Github link: {proiect.linkRepo} {afisareListaBug(proiect)}
        </form>
      );
    }
  }
  function afisareListaBug(proiect) {
    if (bugList !== undefined) {
      return bugList.map((e) => afisareBug(proiect, e));
    } else {
      return null;
    }
  }
  function afisareBug(proiect, bug) {
    if (proiect.id === bug.idOfProject) {
      return (
        <div key={bug.id} id='listaBugs'>
          Severity: {bug.severity}
          <br></br>Priority: {bug.priority}
          <br></br>Description: {bug.description}
          <br></br>Link with the solution: {bug.link}
          <br></br>
          <input
            id='linkRezolvareBug'
            type='text'
            placeholder='Link'
            onChange={(evt) => setLinkBugSolve(evt.target.value)}
          />
          <br></br>
          <input
            id='btnRezolvaBug'
            type='button'
            value='Solve bug'
            onClick={() => solveBug(bug)}
          ></input>
        </div>
      );
    } else {
      return null;
    }
  }

  //solve bug functions
  function solveBug(bug) {
    dispatch(actions.bugActions.updateSolve(bug.id, linkBugSolve));
  }

  return (
    <>
      <div>
        <h2>List of all projects:</h2>
        {afisareListaProiecte()}
      </div>
      <div>
        <h2>List of all personal projects:</h2>
        {afisareListaProiectePerosnale()}
      </div>
      <div>{showEditScreen(proiectDeActualizat)}</div>
      <div>{showDisplayBug(proiectDisplayBugs)}</div>
      <form id='formularMP'>
        <h3>Add a new project</h3>
        <div>
          <label className='labelMPCreate'>Link repository:</label>
          <input
            id='linkRepoMPCreate'
            type='text'
            placeholder='Add link'
            onChange={(evt) => setLinkRepo(evt.target.value)}
          />
          <label className='labelMPCreate'>Project name:</label>
          <input
            id='DenumireProiectMPCreate'
            type='text'
            placeholder='Add project name'
            onChange={(evt) => setNume(evt.target.value)}
          />
          <input
            type='button'
            value='Create'
            onClick={createProject}
            id='btnCreateProject'
          ></input>
        </div>
      </form>
    </>
  );
}

export default USER_MP;
