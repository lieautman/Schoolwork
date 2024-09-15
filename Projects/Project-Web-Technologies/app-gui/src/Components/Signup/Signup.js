import React, { useState } from 'react';
import store from './SignupStore';
import './SignUp.css';
//iau starea redux
import { useDispatch } from 'react-redux';
import * as actions from './../../States/Actions';

export default function SignUp() {
  //var locale pentru parametrii
  const [firstName, setFirstName] = useState(null);
  const [lastName, setLastName] = useState(null);
  const [type, setType] = useState('TST');
  const [email, setEmail] = useState(null);
  const [username, setUsername] = useState(null);
  const [password, setPassword] = useState(null);

  //var din redux
  const dispatch = useDispatch();
  const [eroare, setEroare] = useState('');
  //functie de signup
  const signup = () => {
    store.Signup(firstName, lastName, type, email, username, password);
    store.emitter.addListener('SIGNUP_SUCCESS', () => {
      //setam starea globala la login
      dispatch(actions.mainActions.go_login());
    });
    store.emitter.addListener('SIGNUP_ERROR', (err) => {
      setEroare(err.message);
    });
  };
  //setam starea globala la login
  const back = () => {
    dispatch(actions.mainActions.go_login());
  };

  //pt form
  const isEnterPressed = (evt) => {
    const key = evt.key;
    if (key === 'Enter') {
      signup();
    }
  };

  return (
    <div>
      <form>
        <h1>Sign Up</h1>

        <div id='formSignUp'>
          <label className='labelSignUP'>First name</label>
          <input
            type='text'
            className='form-control'
            placeholder='First name'
            onChange={(evt) => setFirstName(evt.target.value)}
            onKeyPress={(evt) => isEnterPressed(evt)}
          />
          <label className='labelSignUP'>Last name</label>
          <input
            type='text'
            className='form-control'
            placeholder='Last name'
            onChange={(evt) => setLastName(evt.target.value)}
            onKeyPress={(evt) => isEnterPressed(evt)}
          />
          <label className='labelSignUP'>Type</label>
          <select
            className='form-control'
            onChange={(evt) => setType(evt.target.value)}
          >
            <option value='TST'>Tester</option>
            <option value='MP'>Project member</option>
          </select>
          <label className='labelSignUP'>Email address</label>
          <input
            type='email'
            className='form-control'
            placeholder='Enter email'
            onChange={(evt) => setEmail(evt.target.value)}
            onKeyPress={(evt) => isEnterPressed(evt)}
          />
          <label className='labelSignUP'>Username</label>
          <input
            type='text'
            className='form-control'
            placeholder='Enter Username'
            onChange={(evt) => setUsername(evt.target.value)}
            onKeyPress={(evt) => isEnterPressed(evt)}
          />
          <label className='labelSignUP'>Password</label>
          <input
            type='password'
            className='form-control'
            placeholder='Enter password'
            onChange={(evt) => setPassword(evt.target.value)}
            onKeyPress={(evt) => isEnterPressed(evt)}
          />
          <input
            type='button'
            value='Sign Up'
            onClick={signup}
            className='button'
            id='buttonSignUp'
          ></input>
          <input
            type='button'
            value='Back to login'
            onClick={back}
            className='button'
            id='btnBack'
          ></input>
        </div>
      </form>

      <div>{eroare}</div>
    </div>
  );
}
