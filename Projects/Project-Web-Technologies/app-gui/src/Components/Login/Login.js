import React, { useState } from 'react';
import store from './LoginStore';
import './login.css';

//iau starea redux
import { useDispatch } from 'react-redux';
import * as actions from '../../States/Actions';

export default function Login() {
  const [username, setUsername] = useState(null);
  const [password, setPassword] = useState(null);

  //var din redux
  const dispatch = useDispatch();
  const [eroare, setEroare] = useState('');
  //la logare corecta, updatam starea aplicatiei
  const login = () => {
    store.Login(username, password);
    store.emitter.addListener('LOGIN_SUCCESS', () => {
      //implementare token
      const id = store.data.id;
      const username = store.data.username;
      const type = store.data.type;
      const token = store.data.token;
      //setam starea globala la main
      dispatch(actions.mainActions.go_main(id, username, type, token));
    });
    store.emitter.addListener('LOGIN_ERROR', (err) => {
      setEroare(err.message);
    });
  };
  //setam starea globala la signup
  const signup = () => {
    dispatch(actions.mainActions.go_signup());
  };

  //pt form
  const isEnterPressed = (evt) => {
    const key = evt.key;
    if (key === 'Enter') {
      login();
    }
  };

  return (
    <div>
      <h1>Login to BugTracking</h1>
      <form id='loginForm'>
        <label id='labelUsername'>Username</label>
        <input
          className='credentials'
          type='text'
          placeholder='Enter Username'
          onChange={(evt) => setUsername(evt.target.value)}
          onKeyPress={(evt) => isEnterPressed(evt)}
        />

        <label id='labelPassword'>Password</label>
        <input
          className='credentials'
          type='password'
          placeholder='Enter password'
          onChange={(evt) => setPassword(evt.target.value)}
          onKeyPress={(evt) => isEnterPressed(evt)}
        />

        <input
          className='button'
          id='btnLogin'
          type='button'
          value='Login'
          onClick={login}
        ></input>
        <label id='labelAccount'>Don't have an account?</label>
        <input
          className='button'
          id='btnSignUp'
          type='button'
          value='Sign Up'
          onClick={signup}
        ></input>
      </form>

      <div>{eroare}</div>
    </div>
  );
}
